namespace gb;

public interface IGameBoy
{
    void TraceCpuOp(ushort address, string op);
    void TraceCpuOp(ushort cpuStatePc, string op, sbyte imm);
    void TraceCpuOp(ushort cpuStatePc, string op, byte imm);
    void TraceCpuOp(ushort cpuStatePc, string op, ushort imm);
    void TraceCpuOp(ushort cpuStatePc, string op, short imm);
    byte ReadByte(ushort address);
    ushort ReadUShort(ushort address);
}