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
}