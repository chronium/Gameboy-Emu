using ImGuiNET;

namespace gb;

public class CpuState
{
    public ushort PC { get; set; }
    public ushort SP { get; set; }

    public byte A { get; set; }
    public Flags F { get; set; }

    public byte B { get; set; }
    public byte C { get; set; }
    public byte D { get; set; }
    public byte E { get; set; }

    public byte H { get; set; }
    public byte L { get; set; }

    public bool IME { get; set; }

    public ushort BC
    {
        get => (ushort)((B << 8) | C);
        set
        {
            B = (byte)(value >> 8);
            C = (byte)value;
        }
    }

    public ushort DE
    {
        get => (ushort)((D << 8) | E);
        set
        {
            D = (byte)(value >> 8);
            E = (byte)value;
        }
    }

    public ushort HL
    {
        get => (ushort)((H << 8) | L);
        set
        {
            H = (byte)(value >> 8);
            L = (byte)value;
        }
    }

    public ushort AF
    {
        get => (ushort)((A << 8) | (byte)F);
        set
        {
            A = (byte)(value >> 8);
            F = (Flags)value;
        }
    }

    public void Dump()
    {
        Console.WriteLine($"A: {A:X2} F: {(byte)F:X2} B: {B:X2} C: {C:X2}");
        Console.WriteLine($"D: {D:X2} E: {E:X2} H: {H:X2} L: {L:X2}");

        Console.WriteLine($"PC: {PC:X4} SP: {SP:X4}");
        Console.WriteLine($"AF: {AF:X4} BC: {BC:X4}");
        Console.WriteLine($"DE: {DE:X4} HL: {HL:X4}");
    }

    public void ImGuiRegistersDisplay()
    {
        if (ImGui.Begin("Registers"))
        {
            ImGui.BeginTable("Registers", 4, ImGuiTableFlags.Borders | ImGuiTableFlags.NoHostExtendX);

            ImGui.TableSetupColumn("Reg", ImGuiTableColumnFlags.WidthFixed);
            ImGui.TableSetupColumn("Val", ImGuiTableColumnFlags.WidthFixed);
            ImGui.TableSetupColumn("Reg", ImGuiTableColumnFlags.WidthFixed);
            ImGui.TableSetupColumn("Val", ImGuiTableColumnFlags.WidthFixed);

            ImGui.TableHeadersRow();

            ImGui.TableNextColumn();
            ImGui.Text("PC");
            ImGui.TableNextColumn();
            ImGui.Text($"${PC:X4}");
            ImGui.TableNextColumn();
            ImGui.Text("A");
            ImGui.TableNextColumn();
            ImGui.Text($"${A:X2}");

            ImGui.TableNextRow();

            ImGui.TableNextColumn();
            ImGui.Text("SP");
            ImGui.TableNextColumn();
            ImGui.Text($"${SP:X4}");
            ImGui.TableNextColumn();
            ImGui.Text("BC");
            ImGui.TableNextColumn();
            ImGui.Text($"${BC:X4}");

            ImGui.TableNextRow();

            var flags = string.Join(" ", F.HasFlag(Flags.Zero) ? "Z" : " ", F.HasFlag(Flags.Carry) ? "C" : " ",
                F.HasFlag(Flags.HalfCarry) ? "H" : " ", F.HasFlag(Flags.Negative) ? "N" : " ");

            ImGui.TableNextColumn();
            ImGui.Text("F");
            ImGui.TableNextColumn();
            ImGui.Text($"{flags}");
            ImGui.TableNextColumn();
            ImGui.Text("DE");
            ImGui.TableNextColumn();
            ImGui.Text($"${DE:X4}");

            ImGui.TableNextRow();

            ImGui.TableNextColumn();
            ImGui.TableNextColumn();
            ImGui.TableNextColumn();
            ImGui.Text("HL");
            ImGui.TableNextColumn();
            ImGui.Text($"${HL:X4}");

            ImGui.EndTable();
        }

        ImGui.End();
    }
}