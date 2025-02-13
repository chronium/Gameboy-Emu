using gb.CPU;

namespace gb;

public class GameBoy : IGameBoy
{
    public readonly CpuState CpuState = new();

    public Memory Memory { get; } = new();

    public PPU PPU { get; } = new();

    public GameBoyCartridgeHeader? CartridgeHeader { get; private set; }

    public void TraceCpuOp(int address, string op)
    {
        Console.WriteLine($"${address:X4}: {op}");
    }

    public void TraceCpuOp(int cpuStatePc, string op, sbyte imm)
    {
        Console.WriteLine($"${cpuStatePc:X4}: {op} ${imm:X2}");
    }

    public void TraceCpuOp(int cpuStatePc, string op, byte imm)
    {
        Console.WriteLine($"${cpuStatePc:X4}: {op} ${imm:X2}");
    }

    public void TraceCpuOp(int cpuStatePc, string op, ushort imm)
    {
        Console.WriteLine($"${cpuStatePc:X4}: {op} ${imm:X4}");
    }

    public void TraceCpuOp(int cpuStatePc, string op, short imm)
    {
        Console.WriteLine($"${cpuStatePc:X4}: {op} ${imm:X4}");
    }

    public ushort ReadUShort(ushort address)
    {
        return (ushort)(ReadByte(address) | (ReadByte((ushort)(address + 1)) << 8));
    }

    public byte ReadByte(ushort address)
    {
        return address switch
        {
            >= 0xc000 and <= 0xdfff => Memory.ReadWRam(address),
            <= 0x4000 or <= 0x7fff => Memory.ReadByte(address),
            <= 0x9fff => PPU.VRAM[address - 0x8000],
            >= 0xfe00 and <= 0xfe9f => PPU.OAM[address - 0xfe00],
            >= 0xfea0 and <= 0xfeff => 0,
            >= 0xff00 and <= 0xff7f => ReadMMIO(address),
            >= 0xff80 and <= 0xfffe => Memory.HRAM[address - 0xff80],
            _ => throw new NotImplementedException($"Read from address {address:X4} not implemented"),
        };
    }

    public void WriteByte(ushort address, byte value)
    {
        switch (address)
        {
            case 0x2000:
                // TODO: MMC
                Console.WriteLine("TODO: Switch bank to " + value);
                break;
            case >= 0xc000 and <= 0xdfff:
                Memory.WriteWRam(address, value);
                break;
            case <= 0x7fff:
                throw new NotImplementedException(
                    $"Write to address {address:X4} not implemented");
            case <= 0x9fff:
                // Console.WriteLine($"PPU VRAM write {value:X4} to {address:X4}");
                PPU.VRAM[address - 0x8000] = value;
                break;
            case >= 0xFE00 and < 0xFEA0:
                PPU.OAM[address - 0xFE00] = value;
                break;
            case >= 0xFEA0 and <= 0xFEFF:
                // Unusable
                break;
            case 0xFF50:
                Console.WriteLine("Switch off boot ROM");
                Memory.BootRomEnabled = false;
                break;
            case >= 0xff00 and <= 0xff7f:
                WriteMMIO(address, value);
                break;
            case >= 0xff80 and <= 0xfffe:
                Memory.HRAM[address - 0xff80] = value;
                break;
            case 0xFFFF:
                // TODO: IME
                Console.WriteLine("TODO: IME");
                break;
            default: throw new NotImplementedException($"Write to address {address:X4} not implemented");
        }
    }

    public void WriteUShort(ushort address, ushort value)
    {
        WriteByte(address, (byte)value);
        WriteByte((ushort)(address + 1), (byte)(value >> 8));
    }

    public void Push(ushort value)
    {
        CpuState.SP -= 2;
        WriteUShort(CpuState.SP, value);
    }

    public ushort Pop()
    {
        var value = ReadUShort(CpuState.SP);
        CpuState.SP += 2;
        return value;
    }

    public void LoadBootRom(ReadOnlySpan<byte> bootRom)
    {
        Memory.WriteBootRom(bootRom);
    }

    public void LoadRom(byte[] rom)
    {
        Memory.WriteRom(rom);
        CartridgeHeader = GameBoyCartridgeHeader.FromBytes(rom[0x100..0x152]);
    }

    public void ResetNoBootRom(GameBoyCartridgeHeader header)
    {
        CpuState.A = 0x01;
        CpuState.F = 0;

        if (header.HeaderChecksum == 0)
        {
            CpuState.F |= Flags.HalfCarry;
            CpuState.F |= Flags.Carry;
        }

        CpuState.B = 0;
        CpuState.C = 0x13;
        CpuState.D = 0;
        CpuState.E = 0xD8;
        CpuState.H = 0x01;
        CpuState.L = 0x4D;
        CpuState.PC = 0x0100;
        CpuState.SP = 0xFFFE;

        Memory.BootRomEnabled = false;
    }

    public int Step()
    {
        var cycles = Executioner.Execute(CpuState, this);
        // var cycles = Cpu.Step(this);

        for (var i = 0; i < cycles; i++) PPU.Step(this);

        return cycles;
    }

    public void WriteMMIO(ushort address, byte value)
    {
        switch (address)
        {
            case 0xff01:
                throw new("Serial transfer not implemented");
                break;
            case <= 0xFF3F:
                Console.WriteLine($"Write {value:X4} to APU address {address:X4}");
                break;
            case <= 0xFF70:
                PPU.WriteMMIO(address, value);
                break;
            default:
                Console.WriteLine($"Write {value:X4} to I/O address {address:X4}");
                break;
        }
    }

    public byte ReadMMIO(ushort address)
    {
        switch (address)
        {
            case 0xFF00:
                return 0xFF;
            case >= 0xFF10 and <= 0xFF3F:
                Console.WriteLine($"Read from APU address {address:X4}");
                return 0;
            case <= 0xFF70:
                return PPU.ReadMMIO(address);
            default:
                Console.WriteLine($"Read from I/O address {address:X4}");
                return 0;
        }
    }

    public void Dump()
    {
        CpuState.Dump();
        // Cpu.Dump();
        PPU.Dump();
    }
}

public class Memory
{
    public byte[] BOOTROM = new byte[0x100];
    public byte[] HRAM = new byte[0x7F];
    public byte[] ROM00 = new byte[0x4000];
    public byte[] ROM01 = new byte[0x4000];

    public byte[] WRAM0 = new byte[0x1000];
    public byte[] WRAM1 = new byte[0x1000];

    public bool BootRomEnabled { get; set; } = true;

    public void WriteBootRom(ReadOnlySpan<byte> bootRom)
    {
        bootRom.CopyTo(BOOTROM);
    }

    public void WriteRom(ReadOnlySpan<byte> rom)
    {
        rom.Slice(0, 0x4000).CopyTo(ROM00);
        rom.Slice(0x4000).CopyTo(ROM01);

        if (rom.Length > 0x8000) Console.WriteLine("ROM is too large, only the first 32KB will be loaded");
    }

    public byte ReadByte(ushort address)
    {
        var b = address switch
        {
            < 0x100 when BootRomEnabled => BOOTROM[address],
            >= 0x4000 => ROM01[address - 0x4000],
            _ => ROM00[address],
        };

        if (address >= 0x104 && address <= 0x133) Console.WriteLine($"Read logo data from {address:X4} value {b:X2}");

        return b;
    }

    public byte ReadWRam(ushort address)
    {
        return address switch
        {
            >= 0xD000 => WRAM1[address - 0xD000],
            _ => WRAM0[address - 0xC000],
        };
    }

    public void WriteWRam(ushort address, byte value)
    {
        switch (address)
        {
            case >= 0xD000:
                WRAM1[address - 0xD000] = value;
                break;
            default:
                WRAM0[address - 0xC000] = value;
                break;
        }
    }
}

[Flags]
public enum Flags : byte
{
    Zero = 0b1000_0000,
    Subtract = 0b0100_0000,
    HalfCarry = 0b0010_0000,
    Carry = 0b0001_0000,
}