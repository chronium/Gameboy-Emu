namespace gb;

public class InputManager
{
    public bool Up { get; set; }
    public bool Down { get; set; }
    public bool Left { get; set; }
    public bool Right { get; set; }

    public bool A { get; set; }
    public bool B { get; set; }

    public bool Start { get; set; }
    public bool Select { get; set; }

    public byte ReadDirections()
    {
        byte result = 0;

        if (Up) result |= 1 << 2;
        if (Down) result |= 1 << 3;
        if (Left) result |= 1 << 1;
        if (Right) result |= 1 << 0;

        return (byte)~result;
    }

    public byte ReadButtons()
    {
        byte result = 0;

        if (A) result |= 1 << 0;
        if (B) result |= 1 << 1;
        if (Start) result |= 1 << 3;
        if (Select) result |= 1 << 2;

        return (byte)~result;
    }
}