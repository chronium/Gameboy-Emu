namespace gb;

public class GameBoy
{
    public CPU2 CPU { get; } = new();

    public Memory Memory { get; } = new();

    public PPU PPU { get; } = new();

    public void LoadBootRom(ReadOnlySpan<byte> bootRom)
    {
        Memory.WriteBootRom(bootRom);
    }

    public void LoadRom(ReadOnlySpan<byte> rom)
    {
        Memory.WriteRom(rom);
    }

    public void ResetNoBootRom(GameBoyCartridgeHeader header)
    {
        CPU.A = 0x01;
        CPU.F = 0;

        if (header.HeaderChecksum == 0)
        {
            CPU.F |= Flags.HalfCarry;
            CPU.F |= Flags.Carry;
        }

        CPU.B = 0;
        CPU.C = 0x13;
        CPU.D = 0;
        CPU.E = 0xD8;
        CPU.H = 0x01;
        CPU.L = 0x4D;
        CPU.PC = 0x0100;
        CPU.SP = 0xFFFE;
    }

    public int Step()
    {
        var cycles = CPU.Step(this);

        for (var i = 0; i < cycles; i++) PPU.Step(this);

        return cycles;
    }

    public byte ReadByte(ushort address)
    {
        switch (address)
        {
            case <= 0x4000:
                return Memory.ROM00[address];
            case <= 0x7fff:
                throw new NotImplementedException(
                    $"Read from address {address:X4} not implemented");
            case <= 0x9fff:
                return PPU.VRAM[address - 0x8000];
            case >= 0xff00 and <= 0xff7f:
                return ReadMMIO(address);
            case >= 0xff80 and <= 0xfffe:
                return Memory.HRAM[address - 0xff80];
            default: throw new NotImplementedException($"Read from address {address:X4} not implemented");
        }
    }

    public ushort ReadUShort(ushort address)
    {
        return (ushort)(ReadByte(address) | (ReadByte((ushort)(address + 1)) << 8));
    }

    public void WriteByte(ushort address, byte value)
    {
        switch (address)
        {
            case <= 0x7fff:
                throw new NotImplementedException(
                    $"Write to address {address:X4} not implemented");
            case <= 0x9fff:
                PPU.VRAM[address - 0x8000] = value;
                break;
            case >= 0xff00 and <= 0xff7f:
                WriteMMIO(address, value);
                break;
            case >= 0xff80 and <= 0xfffe:
                Memory.HRAM[address - 0xff80] = value;
                break;
            default: throw new NotImplementedException($"Write to address {address:X4} not implemented");
        }
    }

    public void WriteUShort(ushort address, ushort value)
    {
        WriteByte(address, (byte)value);
        WriteByte((ushort)(address + 1), (byte)(value >> 8));
    }

    public void WriteMMIO(ushort address, byte value)
    {
        switch (address)
        {
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
            case <= 0xFF3F:
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
        CPU.Dump();
        PPU.Dump();
    }
}

public enum Mode : byte
{
    HBlank = 0,
    VBlank = 1,
    OamScan = 2,
    Drawing = 3,
}

public enum BgWinMode
{
    UnsignedAddressing = 0,
    SignedAddressing = 1,
}

public class PPU
{
    private const uint White = 0xffc6eccf;
    private const uint LightGray = 0xffa8b479;
    private const uint DarkGray = 0xff6d5d37;
    private const uint Black = 0xff041d29;

    private readonly State _state = new();

    public BgWinMode BgWinMode;

    public uint[] FrameBuffer = new uint[160 * 144];

    public byte[] VRAM = new byte[0x2000];

    public byte Palette { get; set; } = 0b11100100;
    public ulong Frame { get; set; }

    public int LX { get; set; }
    public int LY { get; set; }

    public byte SCX { get; set; }
    public byte SCY { get; set; }

    public byte LCDC
    {
        get => field;
        set
        {
            field = value;

            if ((field & 0b00010000) != 0)
                BgWinMode = BgWinMode.UnsignedAddressing;
            else
                BgWinMode = BgWinMode.SignedAddressing;

            if ((field & 0b10000000) != 0)
                _state.LcdEnable = true;
            else
                _state.LcdEnable = false;
        }
    }

    public Mode Mode
    {
        get
        {
            if (LY >= 144)
                return Mode.VBlank;

            return LX switch
            {
                < 80 => Mode.OamScan,
                < 252 => Mode.Drawing,
                _ => Mode.HBlank,
            };
        }
    }

    public static uint ByteToFFBBGGRR(byte value)
    {
        // Extract 3-3-2 bits:
        var r3 = (byte)((value & 0b11100000) >> 5); // top 3 bits
        var g3 = (byte)((value & 0b00011100) >> 2); // middle 3 bits
        var b2 = (byte)(value & 0b00000011); // bottom 2 bits

        // Scale them up to 8 bits (0..7 => 0..255, 0..3 => 0..255):
        var r8 = (byte)(r3 * 255 / 7);
        var g8 = (byte)(g3 * 255 / 7);
        var b8 = (byte)(b2 * 255 / 3);

        // Pack into a 32-bit unsigned int in the form 0xFFBBGGRR:
        //  - Alpha (0xFF) in bits 24-31
        //  - Blue  in bits 16-23
        //  - Green in bits  8-15
        //  - Red   in bits  0- 7
        var alpha = 0xFFu;
        var color = (alpha << 24) | ((uint)b8 << 16) | ((uint)g8 << 8) | r8;

        return color;
    }

    public void Step(GameBoy gb)
    {
        if (Mode == Mode.Drawing)
        {
            // var x = LX - 80;
            // var y = LY;
            //
            // if (x > 160 || y > 144)
            // {
            //     ;
            // }
            // else
            // {
            //     var pixelIndexOnScreen = x + y * 160;
            //
            //     // Dump entire tileset
            //     if (pixelIndexOnScreen < VRAM.Length)
            //     {
            //         var baseAddress = BgWindowDataArea;
            //
            //         var xTile = x / 8;
            //         var yTile = y / 8;
            //
            //         var tileIndex = xTile + yTile * 32;
            //
            //         var tileAddress = (ushort)(baseAddress + tileIndex * 16);
            //
            //         if (tileAddress <= 0xA000)
            //         {
            //             var tile = new byte[16];
            //             for (var i = 0; i < 16; i++) tile[i] = gb.ReadByte((ushort)(tileAddress + i));
            //
            //             var tileX = x % 8;
            //
            //             var tileY = y % 8;
            //
            //             var line = (tile[tileY * 2] << 8) | tile[tileY * 2 + 1];
            //
            //             var bit1 = (byte)(tile[tileY * 2] >> (7 - tileX)) & 1;
            //             var bit2 = (byte)(tile[tileY * 2 + 1] >> (7 - tileX)) & 1;
            //
            //             FrameBuffer[pixelIndexOnScreen] = GetColor((byte)(bit1 | (bit2 << 1)));
            //
            //             // Console.WriteLine($"{tileIndexInTile / 2} {tileIndexInTile % 2}");
            //
            //             // var colorIndex = (tile[tileIndexInTile / 2] >> (tileIndexInTile % 2 == 0 ? 4 : 0)) & 0b1111;
            //             //
            //             // FrameBuffer[pixelIndexOnScreen] = GetColor((byte)colorIndex);
            //         }
            //     }
            // }
            // // if (BgWindowDataArea + index < 0xA000)
            // {
            //     var color = gb.ReadByte((ushort)(BgWindowDataArea + index));
            //     FrameBuffer[x + y * 160] = ByteToFFBBGGRR(color);
            // }

            // var x = LX - 80;
            // var y = LY;
            //
            // var index = x + y * 160;
            //
            // // if (index < FrameBuffer.Length && _state.LcdEnable)
            // //     FrameBuffer[index] = GetColor(0);
            //
            // var tilemapArea = 0x9800;
            //
            // var tilemapIndex = (SCY + y) / 8 * 32 + (SCX + x) / 8;
            //
            // var tileIndex = gb.ReadByte((ushort)(tilemapArea + tilemapIndex));
            //
            // if (tileIndex != 0)
            //     FrameBuffer[index] = GetColor(1);
        }

        LX++;

        if (LX >= 456)
        {
            LX = 0;
            LY++;

            if (LY >= 154)
            {
                LY = 0;
                Frame++;
            }
        }
    }

    public void WriteMMIO(ushort address, byte value)
    {
        switch (address)
        {
            case 0xFF40:
                LCDC = value;
                break;
            case 0xFF43:
                SCX = value;
                break;
            case 0xFF47:
                Palette = value;
                break;
            default:
                throw new NotImplementedException($"Unknown PPU Register {address:X4}");
        }
    }

    public byte ReadMMIO(ushort address)
    {
        return address switch
        {
            0xFF44 => (byte)LY,
            _ => throw new NotImplementedException($"Read from PPU address {address:X4} not implemented"),
        };
    }

    public void Dump()
    {
        Console.WriteLine($"Palette: {Palette:X2}");
        Console.WriteLine($"LY: {LY} LX: {LX} Mode: {Mode}");
        Console.WriteLine($"Frame: {Frame}");
    }

    public uint GetColor(byte c)
    {
        var color = (Palette >> (c * 2)) & 0b11;

        return color switch
            // return c switch
            {
                0 => White,
                1 => LightGray,
                2 => DarkGray,
                3 => Black,
                _ => throw new NotImplementedException(),
            };
    }

    public byte[] GetTileData(ushort tileIndex)
    {
        var tileData = new byte[16];
        for (var i = 0; i < 16; i++) tileData[i] = VRAM[tileIndex * 16 + i];
        return tileData;
    }

    public byte[] GetBg0TileMap()
    {
        var tileMap = new byte[32 * 32];

        for (var i = 0; i < 32 * 32; i++) tileMap[i] = VRAM[0x1800 + i];

        return tileMap;
    }

    public byte[] GetBg1TileMap()
    {
        var tileMap = new byte[32 * 32];

        for (var i = 0; i < 32 * 32; i++) tileMap[i] = VRAM[0x1C00 + i];

        return tileMap;
    }

    public byte[] GetBgTile(byte tileIndex)
    {
        var tileData = new byte[16];

        if (BgWinMode == BgWinMode.UnsignedAddressing)
            for (var i = 0; i < 16; i++)
                tileData[i] = VRAM[tileIndex * 16 + i];
        else
            for (var i = 0; i < 16; i++)
                tileData[i] = VRAM[tileIndex * 16 + 0x1000 + (sbyte)i];

        return tileData;
    }

    private class State
    {
        public bool LcdEnable;
    }
}

public class Memory
{
    public byte[] HRAM = new byte[0x7F];
    public byte[] ROM00 = new byte[0x4000];
    public byte[] ROM01 = new byte[0x4000];

    public void WriteBootRom(ReadOnlySpan<byte> bootRom)
    {
        bootRom.CopyTo(ROM00);
    }

    public void WriteRom(ReadOnlySpan<byte> rom)
    {
        rom.Slice(0, 0x4000).CopyTo(ROM00);
        rom.Slice(0x4000).CopyTo(ROM01);

        if (rom.Length > 0x8000) Console.WriteLine("ROM is too large, only the first 32KB will be loaded");
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