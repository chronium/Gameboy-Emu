using System.Diagnostics;
using System.Runtime.InteropServices;

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

public struct Sprite : IComparable<Sprite>
{
    public byte Y;
    public byte X;
    public byte Tile;
    public byte Flags;

    public int CompareTo(Sprite other)
    {
        return X.CompareTo(other.X);
    }

    public bool Palette => (Flags & 0b0001_0000) != 0;
}

public class PPU
{
    private const uint White = 0xffc2f0c4;
    private const uint LightGray = 0xffa8b95a;
    private const uint DarkGray = 0xff6e601e;
    private const uint Black = 0xff001b2d;

    private readonly State _state = new();
    private int _lastSpriteIndex;
    public BgTileMapArea BgTileMapArea;

    public BgWinMode BgWinMode;

    public uint[] FrameBuffer = new uint[160 * 144];

    public byte LYC;

    public byte[] OAM = new byte[0xA0];

    public Sprite[] OamBuffer = new Sprite[10];

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

    public bool TwoTileHighSprites { get; set; }

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

            TwoTileHighSprites = (field & 0b00000100) != 0;
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

    public byte STAT
    {
        get
        {
            var lycEqualsLy = LY == LYC;

            var mode = Mode switch
            {
                Mode.HBlank => 0,
                Mode.VBlank => 1,
                Mode.OamScan => 2,
                Mode.Drawing => 3,
                _ => throw new UnreachableException(),
            };

            return (byte)((mode << 5) | (lycEqualsLy ? 4 : 0) | (LY == 0 ? 2 : 0) | (LY == LYC ? 1 : 0));
        }
        set => throw new NotImplementedException("STAT is read-only");
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

    private void DrawBackground(GameBoy gb, int x, int y)
    {
        // var tileX = (x + SCX) / 8;
        // var tileY = (y + SCY) / 8;
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

        // var tileXInTile = (x + SCX) % 8;
        // var tileYInTile = (y + SCY) % 8;
        var tileXInTile = x % 8;
        var tileYInTile = y % 8;

        var bit1 = (byte)(tileData[tileYInTile * 2] >> (7 - tileXInTile)) & 1;
        var bit2 = (byte)(tileData[tileYInTile * 2 + 1] >> (7 - tileXInTile)) & 1;

        FrameBuffer[x + y * 160] = GetColor(Palette, (byte)(bit1 | (bit2 << 1)));
    }

    public void PushSprite(Sprite sprite)
    {
        if (_lastSpriteIndex >= OamBuffer.Length)
            return;

        OamBuffer[_lastSpriteIndex++] = sprite;
    }

    public void Step(GameBoy gb)
    {
        if (Mode == Mode.OamScan && LX == 0)
        {
            _lastSpriteIndex = 0;

            foreach (var sprite in GetOamData())
                if (sprite.X > 0 && LY + 16 >= sprite.Y && LY + 16 < sprite.Y + (TwoTileHighSprites ? 16 : 8))
                    PushSprite(sprite);
        }

        if (Mode == Mode.Drawing)
        {
            var x = LX - 80;
            var y = LY;
            if (x is >= 0 and < 160 && y is >= 0 and < 144)
                if (_state.LcdEnable)
                {
                    DrawBackground(gb, x, y);

                    foreach (var sprite in OamBuffer[.._lastSpriteIndex])
                        if (sprite.X + 8 >= x && sprite.X <= x + 8)
                        {
                            if (sprite.Y + 16 >= y && sprite.Y + 16 < y + 8) continue;

                            var tileData = GetSpriteData(sprite.Tile);

                            var tileXInTile = x - sprite.X + 8;
                            var tileYInTile = y - sprite.Y + 16;

                            var palette = sprite.Palette ? OBP1 : OBP0;

                            if (tileYInTile < 8)
                            {
                                var bit1 = (byte)(tileData[tileYInTile * 2] >> (7 - tileXInTile)) & 1;
                                var bit2 = (byte)(tileData[tileYInTile * 2 + 1] >> (7 - tileXInTile)) & 1;

                                if (bit1 == 0 && bit2 == 0)
                                    continue;

                                FrameBuffer[x + y * 160] = GetColor(palette, (byte)(bit1 | (bit2 << 1)));
                            }
                            else if (TwoTileHighSprites)
                            {
                                tileYInTile -= 8;
                                var tileData2 = GetSpriteData((byte)(sprite.Tile + 1));

                                var bit1 = (byte)(tileData2[tileYInTile * 2] >> (7 - tileXInTile)) & 1;
                                var bit2 = (byte)(tileData2[tileYInTile * 2 + 1] >> (7 - tileXInTile)) & 1;

                                if (bit1 == 0 && bit2 == 0)
                                    continue;

                                FrameBuffer[x + y * 160] = GetColor(palette, (byte)(bit1 | (bit2 << 1)));
                            }
                        }
                }
                else
                {
                    FrameBuffer[x + y * 160] = GetColor(Palette, 0);
                }
        }

        LX++;

        if (LX >= 456)
        {
            LX = 0;
            LY++;

            if (LX == 0 && LY == 144) gb.VBlankInterruptRequested = true;
            // Console.WriteLine($"{gb.CpuState.IME}");
            if (LY >= 154)
            {
                LY = 0;
                Frame++;
            }
        }
    }

    public void WriteMMIO(GameBoy gb, ushort address, byte value)
    {
        switch (address)
        {
            case 0xFF40:
                gb.Trace($"LCDC: {value}");
                LCDC = value;
                break;
            case 0xFF41:
                // TODO: Write to STAT
                Console.WriteLine("TODO: Write to STAT");
                break;
            case 0xFF42:
                gb.Trace($"SCY: {value}");
                SCY = value;
                break;
            case 0xFF43:
                gb.Trace($"SCX: {value}");
                SCX = value;
                break;
            case 0xff45:
                gb.Trace($"LYC: {value}");
                LYC = value;
                break;
            case 0xff46:
                gb.RunningMode = GameBoy.EmulatorRunningMode.OamDma;
                gb.OamDmaSource = (ushort)(value << 8);
                break;
            case 0xFF47:
                gb.Trace($"BG Palette: {value}");
                Palette = value;
                break;
            case 0xFF48:
                gb.Trace($"OBP0: {value}");
                OBP0 = value;
                break;
            case 0xFF49:
                gb.Trace($"OBP1: {value}");
                OBP1 = value;
                break;
            case 0xFF4A:
                gb.Trace($"WY: {value}");
                WY = value;
                break;
            case 0xFF4B:
                gb.Trace($"WX: {value}");
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
            0xff41 => STAT,
            0xFF42 => SCY,
            0xFF43 => SCX,
            0xFF44 => (byte)LY,
            0xFF45 => LYC,
            _ => throw new NotImplementedException($"Read from PPU address {address:X4} not implemented"),
        };
    }

    public void Dump()
    {
        Console.WriteLine($"Palette: {Palette:X2}");
        Console.WriteLine($"LY: {LY} LX: {LX} Mode: {Mode}");
        Console.WriteLine($"Frame: {Frame}");
    }

    public uint GetColor(byte palette, byte c)
    {
        var color = (palette >> (c * 2)) & 0b11;

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
            var startIndex = tileIndex - 128;

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

    public Span<byte> GetSpriteData(byte spriteIndex)
    {
        var start = spriteIndex * 16;
        var end = spriteIndex * 16 + 16;
        return VRAM.AsSpan()[start..end];
    }

    public Span<Sprite> GetOamData()
    {
        return MemoryMarshal.Cast<byte, Sprite>(OAM);
    }

    private class State
    {
        public bool LcdEnable;
    }
}