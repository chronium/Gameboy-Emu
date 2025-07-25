namespace gb;

public interface IGameBoy
{
    GameBoyCartridgeHeader? CartridgeHeader { get; }

    byte this[ushort address]
    {
        get => ReadByte(address);
        set => WriteByte(address, value);
    }

    void TraceCpuOp(int address, string op);
    void TraceCpuOp(int cpuStatePc, string op, sbyte imm);
    void TraceCpuOp(int cpuStatePc, string op, byte imm);
    void TraceCpuOp(int cpuStatePc, string op, ushort imm);
    void TraceCpuOp(int cpuStatePc, string op, short imm);
    void Trace(string message);
    byte ReadByte(ushort address);
    ushort ReadUShort(ushort address);
    void WriteByte(ushort address, byte value);
    void WriteUShort(ushort address, ushort value);
    void Push(ushort value);
    ushort Pop();
    void Halt();
    void Resume();
}