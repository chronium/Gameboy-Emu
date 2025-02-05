using System.Diagnostics;
using ImGuiNET;

namespace gb;

public class CPU2
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

    public int Step(GameBoy gb)
    {
        var opcode = gb.ReadByte(PC);

        if ((opcode & 0b11001111) == 0b00000001)
        {
            var r16 = (opcode & 0b00110001) >> 4;
            var imm16 = gb.ReadUShort((ushort)(PC + 1));

            // Console.WriteLine($"ld {R16(r16)}, {imm16:X4}");

            WriteR16(r16, imm16);

            PC += 3;
        }
        else if ((opcode & 0b11000111) == 0b00000110)
        {
            var r8 = (opcode & 0b00111000) >> 3;
            var imm8 = gb.ReadByte((ushort)(PC + 1));

            // Console.WriteLine($"ld {R8(r8)}, {imm8:X2}");

            WriteR8(r8, imm8);

            PC += 2;
        }
        else if ((opcode & 0b11001111) == 0b00000010)
        {
            var r16 = (opcode & 0b00110001) >> 4;
            var addr = ReadR16(r16);

            // Console.WriteLine($"ld [{R16Mem(r16)}], a");

            gb.WriteByte(addr, A);

            if (r16 == 0b10)
                WriteR16(r16, (ushort)(addr + 1));
            else if (r16 == 0b11)
                WriteR16(r16, (ushort)(addr - 1));

            PC += 1;
        }
        else if (opcode == 0xCB)
        {
            PC += 1;
            opcode = gb.ReadByte(PC);

            if ((opcode & 0b11000000) == 0b01000000)
            {
                var bit = (opcode & 0b00111000) >> 3;
                var r8 = opcode & 0b00000111;

                // Console.WriteLine($"bit {bit}, {R8(r8)}");

                if ((ReadR8(r8) & (1 << bit)) == 0)
                    F |= Flags.Zero;
                else
                    F &= ~Flags.Zero;

                F &= ~Flags.Subtract;
                F |= Flags.HalfCarry;

                PC += 1;
            }
            else if ((opcode & 0b11111000) == 0b00010000)
            {
                var r8 = opcode & 0b00000111;

                // Console.WriteLine($"rl {R8(r8)}");

                var value = ReadR8(r8);
                var carry = (F & Flags.Carry) != 0;
                var result = (byte)((value << 1) | (carry ? 1 : 0));

                if ((value & 0b1000_0000) != 0)
                    F |= Flags.Carry;
                else
                    F &= ~Flags.Carry;

                WriteR8(r8, result);

                PC += 1;
            }
        }
        else if ((opcode & 0b11100111) == 0b00100000)
        {
            var cond = (opcode & 0b00011000) >> 3;
            var imm8 = gb.ReadByte((ushort)(PC + 1));

            // Console.WriteLine($"jr {Condition(cond)}, {imm8:X2}");

            if (cond switch
                {
                    0b00 => (F & Flags.Zero) == 0,
                    0b01 => (F & Flags.Zero) != 0,
                    0b10 => (F & Flags.Carry) == 0,
                    0b11 => (F & Flags.Carry) != 0,
                    _ => throw new UnreachableException($"Unknown condition {cond}"),
                })
            {
                var pc = (int)PC;
                pc += (sbyte)imm8;
                PC = (ushort)pc;
            }

            PC += 2;
        }
        else if (opcode == 0b11100000)
        {
            var imm8 = gb.ReadByte((ushort)(PC + 1));

            // Console.WriteLine($"ldh [$FF{imm8:X2}], a");

            gb.WriteByte((ushort)(0xFF00 + imm8), A);

            PC += 2;
        }
        else if ((opcode & 0b11001111) == 0b00001010)
        {
            var r16 = (opcode & 0b00110001) >> 4;
            var addr = ReadR16(r16);

            // Console.WriteLine($"ld a, [{R16(r16)}]");

            A = gb.ReadByte(addr);

            PC += 1;
        }
        else if ((opcode & 0b11000000) == 0b01000000)
        {
            var r1 = (opcode & 0b00111000) >> 3;
            var r2 = opcode & 0b00000111;

            // Console.WriteLine($"ld {R8(r1)}, {R8(r2)}");

            WriteR8(r1, ReadR8(r2));

            PC += 1;
        }
        else if (opcode == 0xCD)
        {
            var imm16 = gb.ReadUShort((ushort)(PC + 1));

            // Console.WriteLine($"call {imm16:X4}");

            Push(gb, (ushort)(PC + 3));
            PC = imm16;
        }
        else if ((opcode & 0b11001111) == 0b11000101)
        {
            var r16 = (opcode & 0b00110001) >> 4;

            // Console.WriteLine($"push {R16Stk(r16)}");

            Push(gb, ReadU16Stk(r16));

            PC += 1;
        }
        else if (opcode == 0xC9)
        {
            // Console.WriteLine("ret");

            PC = Pop(gb);
        }
        else if ((opcode & 0b11001111) == 0b11000001)
        {
            var r16 = (opcode & 0b00110000) >> 4;

            // Console.WriteLine($"pop {R16Stk(r16)}");

            WriteR16Stk(r16, Pop(gb));

            PC += 1;
        }
        else if ((opcode & 0b11000111) == 0b00000101)
        {
            var r8 = (opcode & 0b00111000) >> 3;

            // Console.WriteLine($"dec {R8(r8)}");

            var value = ReadR8(r8);

            if ((value & 0x0F) == 0)
                F |= Flags.HalfCarry;
            else
                F &= ~Flags.HalfCarry;

            value--;

            if (value == 0)
                F |= Flags.Zero;
            else
                F &= ~Flags.Zero;

            F |= Flags.Subtract;

            WriteR8(r8, value);

            PC += 1;
        }
        else if ((opcode & 0b11001111) == 0b00000011)
        {
            var r16 = (opcode & 0b00110000) >> 4;

            // Console.WriteLine($"inc {R16(r16)}");

            WriteR16(r16, (ushort)(ReadR16(r16) + 1));

            PC += 1;
        }
        else if (opcode == 0b11111110)
        {
            var imm8 = gb.ReadByte((ushort)(PC + 1));

            // Console.WriteLine($"cp a, {imm8:X2}");

            var value = A;

            if (value == imm8)
                F |= Flags.Zero;
            else
                F &= ~Flags.Zero;

            F |= Flags.Subtract;

            if ((value & 0x0F) < (imm8 & 0x0F))
                F |= Flags.HalfCarry;
            else
                F &= ~Flags.HalfCarry;

            if (value < imm8)
                F |= Flags.Carry;
            else
                F &= ~Flags.Carry;

            PC += 2;
        }
        else if (opcode == 0b11101010)
        {
            var imm16 = gb.ReadUShort((ushort)(PC + 1));

            // Console.WriteLine($"ld [{imm16:X4}], a");

            gb.WriteByte(imm16, A);

            PC += 3;
        }
        else if (opcode == 0x18)
        {
            var imm8 = gb.ReadByte((ushort)(PC + 1));

            // Console.WriteLine($"jr {imm8:X2}");

            var pc = (int)PC;
            pc += (sbyte)imm8;
            PC = (ushort)pc;

            PC += 2;
        }
        else if (opcode == 0xC3)
        {
            var imm16 = gb.ReadUShort((ushort)(PC + 1));

            // Console.WriteLine($"jp {imm16:X4}");

            PC = imm16;
        }
        else if (opcode == 0xFA)
        {
            var imm16 = gb.ReadUShort((ushort)(PC + 1));

            // Console.WriteLine($"ld a, [${imm16:X4}]");

            A = gb.ReadByte(imm16);

            PC += 3;
        }
        else if ((opcode & 0b11100111) == 0b11000010)
        {
            var imm16 = gb.ReadUShort((ushort)(PC + 1));
            var cond = (opcode & 0b00011000) >> 3;

            // Console.WriteLine($"jp {Condition(cond)}, {imm16:X4}");

            if (cond switch
                {
                    0b00 => (F & Flags.Zero) == 0,
                    0b01 => (F & Flags.Zero) != 0,
                    0b10 => (F & Flags.Carry) == 0,
                    0b11 => (F & Flags.Carry) != 0,
                    _ => throw new UnreachableException($"Unknown condition {cond}"),
                })
                PC = imm16;
            else
                PC += 3;
        }
        else if ((opcode & 0b110001111) == 0b00001011)
        {
            var r16 = (opcode & 0b00110000) >> 4;

            // Console.WriteLine($"dec {R16(r16)}");

            WriteR16(r16, (ushort)(ReadR16(r16) - 1));

            PC += 1;
        }
        else if ((opcode & 0b11111000) == 0b10110000)
        {
            var r8 = opcode & 0b00000111;

            // Console.WriteLine($"or A, {R8(r8)}");

            A |= ReadR8(r8);

            if (A == 0)
                F |= Flags.Zero;
            else
                F &= ~Flags.Zero;

            F &= ~Flags.Subtract;

            PC += 1;
        }
        else
        {
            throw new UnreachableException($"Unknown opcode 0b{opcode:b8} 0x{opcode:X2} (PC = {PC:X4})");
        }

        return 4;
    }

    private string Condition(int cond)
    {
        return cond switch
        {
            0b00 => "NZ",
            0b01 => "Z",
            0b10 => "NC",
            0b11 => "C",
            _ => throw new UnreachableException($"Unknown condition {cond}"),
        };
    }

    private string R16(int r)
    {
        return r switch
        {
            0b00 => "BC",
            0b01 => "DE",
            0b10 => "HL",
            0b11 => "SP",
            _ => throw new UnreachableException($"Unknown register {r}"),
        };
    }

    private string R16Mem(int r)
    {
        return r switch
        {
            0b00 => "BC",
            0b01 => "DE",
            0b10 => "HL+",
            0b11 => "HL-",
            _ => throw new UnreachableException($"Unknown register {r}"),
        };
    }

    private string R16Stk(int r)
    {
        return r switch
        {
            0b00 => "BC",
            0b01 => "DE",
            0b10 => "HL",
            0b11 => "AF",
            _ => throw new UnreachableException($"Unknown register {r}"),
        };
    }

    private string R8(int r)
    {
        return r switch
        {
            0b000 => "B",
            0b001 => "C",
            0b010 => "D",
            0b011 => "E",
            0b100 => "H",
            0b101 => "L",
            0b110 => "(HL)",
            0b111 => "A",
            _ => throw new UnreachableException($"Unknown register {r}"),
        };
    }

    public ushort ReadR16(int r)
    {
        return r switch
        {
            0b00 => BC,
            0b01 => DE,
            0b10 => HL,
            0b11 => SP,
            _ => throw new UnreachableException($"Unknown register {r}"),
        };
    }

    public ushort ReadU16Stk(int r)
    {
        return r switch
        {
            0b00 => BC,
            0b01 => DE,
            0b10 => HL,
            0b11 => AF,
            _ => throw new UnreachableException($"Unknown register {r}"),
        };
    }

    public void WriteR16(int r, ushort value)
    {
        switch (r)
        {
            case 0b00:
                BC = value;
                break;
            case 0b01:
                DE = value;
                break;
            case 0b10:
                HL = value;
                break;
            case 0b11:
                SP = value;
                break;
            default:
                throw new UnreachableException($"Unknown register {r}");
        }
    }

    public void WriteR16Stk(int r, ushort value)
    {
        switch (r)
        {
            case 0b00:
                BC = value;
                break;
            case 0b01:
                DE = value;
                break;
            case 0b10:
                HL = value;
                break;
            case 0b11:
                AF = value;
                break;
            default:
                throw new UnreachableException($"Unknown register {r}");
        }
    }

    public byte ReadR8(int r)
    {
        return r switch
        {
            0b000 => B,
            0b001 => C,
            0b010 => D,
            0b011 => E,
            0b100 => H,
            0b101 => L,
            0b110 => throw new NotImplementedException(),
            0b111 => A,
            _ => throw new UnreachableException($"Unknown register {r}"),
        };
    }

    public void WriteR8(int r, byte value)
    {
        switch (r)
        {
            case 0b000:
                B = value;
                break;
            case 0b001:
                C = value;
                break;
            case 0b010:
                D = value;
                break;
            case 0b011:
                E = value;
                break;
            case 0b100:
                H = value;
                break;
            case 0b101:
                L = value;
                break;
            case 0b110:
                throw new NotImplementedException();
            case 0b111:
                A = value;
                break;
            default:
                throw new UnreachableException($"Unknown register {r}");
        }
    }

    public void Push(GameBoy gb, ushort value)
    {
        SP -= 2;
        gb.WriteUShort(SP, value);
    }

    public ushort Pop(GameBoy gb)
    {
        var value = gb.ReadUShort(SP);
        SP += 2;
        return value;
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
            F.HasFlag(Flags.HalfCarry) ? "H" : " ", F.HasFlag(Flags.Subtract) ? "S" : " ");

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
}