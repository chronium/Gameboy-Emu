namespace gb;

public interface IGameBoy
{
    void TraceCpuOp(int address, string op);
    void TraceCpuOp(int cpuStatePc, string op, sbyte imm);
    void TraceCpuOp(int cpuStatePc, string op, byte imm);
    void TraceCpuOp(int cpuStatePc, string op, ushort imm);
    void TraceCpuOp(int cpuStatePc, string op, short imm);
    byte ReadByte(ushort address);
    ushort ReadUShort(ushort address);
    void WriteByte(ushort address, byte value);
    void WriteUShort(ushort address, ushort value);
    void Push(ushort value);
    ushort Pop();
}