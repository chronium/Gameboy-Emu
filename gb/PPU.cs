using System.Diagnostics;

namespace gb;

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

public enum BgTileMapArea
{
    Low9800 = 0,
    High9C00 = 1,
}

public class PPU
{
    private const uint White = 0xffc6eccf;
    private const uint LightGray = 0xffa8b479;
    private const uint DarkGray = 0xff6d5d37;
    private const uint Black = 0xff041d29;

    private readonly State _state = new();
    public BgTileMapArea BgTileMapArea;

    public BgWinMode BgWinMode;

    public uint[] FrameBuffer = new uint[160 * 144];

    public byte[] OAM = new byte[0xA0];

    public byte[] VRAM = new byte[0x2000];

    public byte Palette { get; set; } = 0b11100100;
    public byte OBP0 { get; set; } = 0b11100100;
    public byte OBP1 { get; set; } = 0b11100100;

    public ulong Frame { get; set; }

    public int LX { get; set; }
    public int LY { get; set; }

    public byte SCX { get; set; }
    public byte SCY { get; set; }

    public byte WY { get; set; }
    public byte WX { get; set; }

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

            if ((field & 0b00001000) != 0)
                BgTileMapArea = BgTileMapArea.High9C00;
            else
                BgTileMapArea = BgTileMapArea.Low9800;

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

    private void Draw(GameBoy gb, int x, int y)
    {
        var tileX = x / 8;
        var tileY = y / 8;

        var tileMapArea = BgTileMapArea switch
        {
            BgTileMapArea.Low9800 => 0x9800,
            BgTileMapArea.High9C00 => 0x9C00,
            _ => throw new UnreachableException(),
        };

        var tileMapIndex = tileY * 32 + tileX;

        var tile = gb.ReadByte((ushort)(tileMapArea + tileMapIndex));

        var tileData = GetBgTile(tile);

        var tileXInTile = x % 8;
        var tileYInTile = y % 8;

        var bit1 = (byte)(tileData[tileYInTile * 2] >> (7 - tileXInTile)) & 1;
        var bit2 = (byte)(tileData[tileYInTile * 2 + 1] >> (7 - tileXInTile)) & 1;

        FrameBuffer[x + y * 160] = GetColor((byte)(bit1 | (bit2 << 1)));
    }

    public void Step(GameBoy gb)
    {
        if (Mode == Mode.Drawing && _state.LcdEnable)
        {
            var x = LX - 80;
            var y = LY;
            if (x is >= 0 and < 160 && y is >= 0 and < 144)
                Draw(gb, x, y);
        }

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
                Console.WriteLine($"LCDC: {value}");
                LCDC = value;
                break;
            case 0xFF41:
                // TODO: Write to STAT
                Console.WriteLine("TODO: Write to STAT");
                break;
            case 0xFF42:
                Console.WriteLine($"SCY: {value}");
                SCY = value;
                break;
            case 0xFF43:
                Console.WriteLine($"SCX: {value}");
                SCX = value;
                break;
            case 0xFF47:
                Console.WriteLine($"BG Palette: {value}");
                Palette = value;
                break;
            case 0xFF48:
                Console.WriteLine($"OBP0: {value}");
                OBP0 = value;
                break;
            case 0xFF49:
                Console.WriteLine($"OBP1: {value}");
                OBP1 = value;
                break;
            case 0xFF4A:
                Console.WriteLine($"WY: {value}");
                WY = value;
                break;
            case 0xFF4B:
                Console.WriteLine($"WX: {value}");
                WX = value;
                break;
            default:
                throw new NotImplementedException($"Unknown PPU Register {address:X4}");
        }
    }

    public byte ReadMMIO(ushort address)
    {
        return address switch
        {
            0xFF40 => LCDC,
            0xFF42 => SCY,
            0xFF43 => SCX,
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

    public Span<byte> GetTileData(ushort tileIndex)
    {
        var start = tileIndex * 16;
        var end = tileIndex * 16 + 16;
        return VRAM.AsSpan()[start..end];
    }

    public Span<byte> GetBg0TileMap()
    {
        const int start = 0x1800;
        const int end = start + 32 * 32;

        return VRAM.AsSpan()[start..end];
    }

    public Span<byte> GetBg1TileMap()
    {
        const int start = 0x1C00;
        const int end = start + 32 * 32;

        return VRAM.AsSpan()[start..end];
    }

    public Span<byte> GetBgTile(byte tileIndex)
    {
        if (tileIndex > 127)
        {
            var startIndex = tileIndex - 127;

            var start = startIndex * 16 + 0x800;
            var end = startIndex * 16 + 16 + 0x800;

            return VRAM.AsSpan()[start..end];
        }

        if (BgWinMode == BgWinMode.UnsignedAddressing)
        {
            var start = tileIndex * 16;
            var end = tileIndex * 16 + 16;

            return VRAM.AsSpan()[start..end];
        }
        else
        {
            var start = tileIndex * 16 + 0x1000;
            var end = tileIndex * 16 + 16 + 0x1000;

            return VRAM.AsSpan()[start..end];
        }
    }

    private class State
    {
        public bool LcdEnable;
    }
}