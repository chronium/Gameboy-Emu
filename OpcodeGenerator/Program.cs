using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

var opcodesDefinition = File.ReadAllText("Opcodes.json");
var opcodes = JsonSerializer.Deserialize<Opcodes>(opcodesDefinition);

var generator = new Generator();

File.WriteAllText("Executioner.cs", generator.Generate(opcodes));

// Define opcode categories
var categories = new Dictionary<string, List<(string, Opcode)>>
{
    { "LoadStore", [] },
    { "Arithmetic", [] },
    { "Bitwise", [] },
    { "BitManipulation", [] },
    { "ControlFlow", [] },
    { "Misc", [] },
};

// Function to categorize an opcode
string CategorizeOpcode(string mnemonic)
{
    if (mnemonic.StartsWith("LD") || mnemonic.StartsWith("PUSH") || mnemonic.StartsWith("POP"))
        return "LoadStore";
    if (mnemonic.StartsWith("ADD") || mnemonic.StartsWith("SUB") || mnemonic == "ADC" || mnemonic == "SBC" ||
        mnemonic == "INC" || mnemonic == "DEC" ||
        mnemonic == "DAA" || mnemonic == "CPL" || mnemonic == "CP")
        return "Arithmetic";
    if (mnemonic.StartsWith("AND") || mnemonic.StartsWith("OR") || mnemonic.StartsWith("XOR") ||
        mnemonic.StartsWith("RL") || mnemonic.StartsWith("RR") || mnemonic.StartsWith("SLA") ||
        mnemonic.StartsWith("SRA"))
        return "Bitwise";
    if (mnemonic.StartsWith("BIT") || mnemonic.StartsWith("RES") || mnemonic.StartsWith("SET") || mnemonic == "SWAP")
        return "BitManipulation";
    if (mnemonic.StartsWith("JP") || mnemonic.StartsWith("JR") || mnemonic.StartsWith("CALL") ||
        mnemonic.StartsWith("RET") || mnemonic.StartsWith("RST"))
        return "ControlFlow";
    if (mnemonic is "NOP" or "HALT" or "STOP" or "DI" or "EI")
        return "Misc";

    return "Misc"; // Default category
}

// Categorize unprefixed opcodes
foreach (var kvp in opcodes.Unprefixed)
{
    var category = CategorizeOpcode(kvp.Value.Mnemonic);
    categories[category].Add((kvp.Key, kvp.Value));
}

// Categorize CB-prefixed opcodes
foreach (var kvp in opcodes.CbPrefixed)
    categories["BitManipulation"].Add((kvp.Key, kvp.Value));

if (!Directory.Exists("Implementation")) Directory.CreateDirectory("Implementation");

foreach (var (category, catOpcodes) in categories)
    File.WriteAllText($"Implementation/{category}.cs", generator.GenerateCategory(catOpcodes));

internal record Opcodes
{
    [JsonPropertyName("unprefixed")] public Dictionary<string, Opcode> Unprefixed { get; set; }

    [JsonPropertyName("cbprefixed")] public Dictionary<string, Opcode> CbPrefixed { get; set; }
}

internal record Opcode
{
    [JsonPropertyName("mnemonic")] public string Mnemonic { get; set; }

    [JsonPropertyName("bytes")] public int Bytes { get; set; }

    [JsonPropertyName("cycles")] public int[] Cycles { get; set; }

    [JsonPropertyName("operands")] public List<Operand> Operands { get; set; }

    [JsonPropertyName("immediate")] public bool Immediate { get; set; }

    [JsonPropertyName("flags")] public Flags Flags { get; set; }
}

internal record Operand
{
    [JsonPropertyName("name")] public string Name { get; set; }

    [JsonPropertyName("immediate")] public bool Immediate { get; set; }

    [JsonPropertyName("bytes")] public int? Bytes { get; set; }
    [JsonPropertyName("increment")] public bool? Increment { get; set; }
    [JsonPropertyName("decrement")] public bool? Decrement { get; set; }
}

internal record Flags
{
    [JsonPropertyName("Z")] public string Z { get; set; }

    [JsonPropertyName("N")] public string N { get; set; }

    [JsonPropertyName("H")] public string H { get; set; }

    [JsonPropertyName("C")] public string C { get; set; }
}

internal class Generator
{
    public StringBuilder sb { get; set; } = new();

    public int indentLevel { get; set; }

    public void Indent()
    {
        indentLevel++;
    }

    public void Unindent()
    {
        indentLevel--;
    }

    public void AppendLine(string line = "")
    {
        sb.AppendLine(new string(' ', indentLevel * 4) + line);
    }

    public void EnterScope(string scope = "")
    {
        if (!string.IsNullOrEmpty(scope)) AppendLine(scope);
        AppendLine("{");
        Indent();
    }

    public void ExitScope()
    {
        Unindent();
        AppendLine("}");
    }

    public string Generate(Opcodes opcodes)
    {
        sb.Clear();

        AppendLine("using gb;");
        AppendLine();

        AppendLine("namespace gb.CPU;");
        AppendLine();

        EnterScope("public static partial class Executioner");

        EnterScope("public static int Execute(CpuState cpuState, IGameBoy gb)");
        AppendLine("var opcode = gb.ReadByte(cpuState.PC);");
        AppendLine("cpuState.PC++;");
        AppendLine();
        EnterScope("switch (opcode)");

        foreach (var (op, opcode) in opcodes.Unprefixed)
            AppendLine($"case {op}: return {GetFunctionName(opcode)}(cpuState, gb);");

        ExitScope();
        ExitScope();

        EnterScope("public static int PREFIX(CpuState cpuState, IGameBoy gb)");
        AppendLine("var opcode = gb.ReadByte(cpuState.PC);");
        AppendLine("cpuState.PC++;");
        AppendLine();
        EnterScope("switch (opcode)");

        foreach (var (op, opcode) in opcodes.CbPrefixed)
            AppendLine($"case {op}: return {GetFunctionName(opcode)}(cpuState, gb);");

        ExitScope();
        ExitScope();

        ExitScope();

        return sb.ToString();
    }

    public string GenerateCategory(List<(string, Opcode)> opcodes)
    {
        sb.Clear();

        AppendLine("using gb;");
        AppendLine();
        AppendLine("namespace gb.CPU;");
        AppendLine();

        EnterScope("public static partial class Executioner");

        foreach (var opcode in opcodes)
            WriteFunction(opcode.Item1, opcode.Item2);

        ExitScope();

        return sb.ToString();
    }

    public string GetFunctionName(Opcode opcode)
    {
        var operands = string.Join("_",
            opcode.Operands.Select(op =>
                $"{(op.Immediate ? "" : "i")}{op.Name.Replace("$", "0x")}{(op.Increment ?? false ? "I" : "")}{(op.Decrement ?? false ? "D" : "")}"));

        return $"{opcode.Mnemonic}{(!string.IsNullOrEmpty(operands) ? $"_{operands}" : "")}";
    }

    public void WriteFunction(string op, Opcode opcode)
    {
        var fnName = GetFunctionName(opcode);

        AppendLine("/// <summary>");
        AppendLine($"/// {op} {opcode.Mnemonic} - {string.Join("/", opcode.Cycles)} cycles");
        AppendLine("/// <para>");
        AppendLine($"/// Bytes: {opcode.Bytes}<br />");

        var operands = string.Join(", ",
            opcode.Operands.Select(op =>
                $"{(op.Immediate ? "" : "[")}{op.Name}{(op.Increment ?? false ? "I" : "")}{(op.Decrement ?? false ? "D" : "")}{(op.Immediate ? "" : "]")}"));
        AppendLine($"/// Operands: {operands}<br />");

        if (opcode.Immediate) AppendLine("/// Immediate mode<br />");

        AppendLine($"/// Flags: Z={opcode.Flags.Z}, N={opcode.Flags.N}, H={opcode.Flags.H}, C={opcode.Flags.C}");
        AppendLine("/// </para>");
        AppendLine("/// </summary>");
        AppendLine("/// <param cref=\"gb.CpuState\" name=\"cpuState\">The CPU state</param>");
        AppendLine("/// <param cref=\"gb.IGameBoy\" name=\"gb\">The Game Boy instance</param>");
        AppendLine("/// <returns>The number of cycles taken</returns>");

        EnterScope($"internal static int {fnName}(CpuState cpuState, IGameBoy gb)");

        if (opcode.Operands.Any(op => op.Name == "n8"))
        {
            AppendLine("var n8 = gb.ReadByte(cpuState.PC);");
            AppendLine("cpuState.PC++;");
            AppendLine();

            AppendLine($"gb.TraceCpuOp(cpuState.PC, \"{fnName}\", n8);");
        }
        else if (opcode.Operands.Any(op => op.Name == "n16"))
        {
            AppendLine("var n16 = gb.ReadUShort(cpuState.PC);");
            AppendLine("cpuState.PC += 2;");
            AppendLine();

            AppendLine($"gb.TraceCpuOp(cpuState.PC, \"{fnName}\", n16);");
        }
        else if (opcode.Operands.Any(op => op.Name == "a8"))
        {
            AppendLine("var a8 = (ushort)(0xFF00 + gb.ReadByte(cpuState.PC));");
            AppendLine("cpuState.PC++;");
            AppendLine();

            AppendLine($"gb.TraceCpuOp(cpuState.PC, \"{fnName}\", a8);");
        }
        else if (opcode.Operands.Any(op => op.Name == "a16"))
        {
            AppendLine("var a16 = gb.ReadUShort(cpuState.PC);");
            AppendLine("cpuState.PC += 2;");
            AppendLine();

            AppendLine($"gb.TraceCpuOp(cpuState.PC, \"{fnName}\", a16);");
        }
        else if (opcode.Operands.Any(op => op.Name == "e8"))
        {
            AppendLine("var e8 = (sbyte)gb.ReadByte(cpuState.PC);");
            AppendLine("cpuState.PC++;");
            AppendLine();

            AppendLine($"gb.TraceCpuOp(cpuState.PC, \"{fnName}\", e8);");
        }
        else
        {
            AppendLine($"gb.TraceCpuOp(cpuState.PC, \"{fnName}\");");
        }

        AppendLine();

        AppendLine($"throw new NotImplementedException(\"{fnName}\");");

        ExitScope();

        AppendLine();
    }
}