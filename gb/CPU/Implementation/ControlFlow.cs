// ReSharper disable once CheckNamespace

namespace gb.CPU;

public static partial class Executioner
{
    /// <summary>
    ///     0x18 JR - 12 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: e8<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int JR_e8(CpuState cpuState, IGameBoy gb)
    {
        var e8 = (sbyte)gb.ReadByte(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "JR_e8", e8);

        cpuState.PC++;

        var addr = cpuState.PC + e8;
        cpuState.PC = (ushort)addr;

        return 12;
    }

    /// <summary>
    ///     0x20 JR - 12/8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: NZ, e8<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int JR_NZ_e8(CpuState cpuState, IGameBoy gb)
    {
        var e8 = (sbyte)gb.ReadByte(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "JR_NZ_e8", e8);

        cpuState.PC++;

        if (cpuState.F.HasFlag(Flags.Zero)) return 8;

        var addr = cpuState.PC + e8;

        cpuState.PC = (ushort)addr;

        return 12;
    }

    /// <summary>
    ///     0x28 JR - 12/8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: Z, e8<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int JR_Z_e8(CpuState cpuState, IGameBoy gb)
    {
        var e8 = (sbyte)gb.ReadByte(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "JR_Z_e8", (byte)e8);

        cpuState.PC++;

        if (!cpuState.F.HasFlag(Flags.Zero)) return 8;

        var addr = cpuState.PC + e8;

        cpuState.PC = (ushort)addr;

        return 12;
    }

    /// <summary>
    ///     0x30 JR - 12/8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: NC, e8<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int JR_NC_e8(CpuState cpuState, IGameBoy gb)
    {
        var e8 = (sbyte)gb.ReadByte(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "JR_NC_e8", e8);

        cpuState.PC++;

        if (cpuState.F.HasFlag(Flags.Carry)) return 8;

        var addr = cpuState.PC + e8;

        cpuState.PC = (ushort)addr;

        return 12;
    }

    /// <summary>
    ///     0x38 JR - 12/8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: C, e8<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int JR_C_e8(CpuState cpuState, IGameBoy gb)
    {
        var e8 = (sbyte)gb.ReadByte(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "JR_C_e8", e8);

        cpuState.PC++;

        if (!cpuState.F.HasFlag(Flags.Carry)) return 8;

        var addr = cpuState.PC + e8;

        cpuState.PC = (ushort)addr;

        return 12;
    }

    /// <summary>
    ///     0xC0 RET - 20/8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: NZ<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RET_NZ(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RET_NZ");

        if (cpuState.F.HasFlag(Flags.Zero)) return 8;

        cpuState.PC = gb.Pop();

        return 20;
    }

    /// <summary>
    ///     0xC2 JP - 16/12 cycles
    ///     <para>
    ///         Bytes: 3<br />
    ///         Operands: NZ, a16<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int JP_NZ_a16(CpuState cpuState, IGameBoy gb)
    {
        var a16 = gb.ReadUShort(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "JP_NZ_a16", a16);

        cpuState.PC += 2;

        if (cpuState.F.HasFlag(Flags.Zero)) return 12;

        cpuState.PC = a16;

        return 16;
    }

    /// <summary>
    ///     0xC3 JP - 16 cycles
    ///     <para>
    ///         Bytes: 3<br />
    ///         Operands: a16<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int JP_a16(CpuState cpuState, IGameBoy gb)
    {
        var a16 = gb.ReadUShort(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "JP_a16", a16);

        cpuState.PC = a16;

        return 16;
    }

    /// <summary>
    ///     0xC4 CALL - 24/12 cycles
    ///     <para>
    ///         Bytes: 3<br />
    ///         Operands: NZ, a16<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int CALL_NZ_a16(CpuState cpuState, IGameBoy gb)
    {
        var a16 = gb.ReadUShort(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "CALL_NZ_a16", a16);

        cpuState.PC += 2;

        if (cpuState.F.HasFlag(Flags.Zero)) return 12;

        gb.Push(cpuState.PC);

        cpuState.PC = a16;

        return 24;
    }

    /// <summary>
    ///     0xC7 RST - 16 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: $00<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RST_0x00(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RST_0x00");

        gb.Push(cpuState.PC);

        cpuState.PC = 0x00;

        return 16;
    }

    /// <summary>
    ///     0xC8 RET - 20/8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: Z<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RET_Z(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RET_Z");

        if (!cpuState.F.HasFlag(Flags.Zero)) return 8;

        cpuState.PC = gb.Pop();

        return 20;
    }

    /// <summary>
    ///     0xC9 RET - 16 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: <br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RET(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RET");

        cpuState.PC = gb.Pop();

        return 16;
    }

    /// <summary>
    ///     0xCA JP - 16/12 cycles
    ///     <para>
    ///         Bytes: 3<br />
    ///         Operands: Z, a16<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int JP_Z_a16(CpuState cpuState, IGameBoy gb)
    {
        var a16 = gb.ReadUShort(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "JP_Z_a16", a16);

        cpuState.PC += 2;

        if (!cpuState.F.HasFlag(Flags.Zero)) return 12;

        cpuState.PC = a16;

        return 16;
    }

    /// <summary>
    ///     0xCC CALL - 24/12 cycles
    ///     <para>
    ///         Bytes: 3<br />
    ///         Operands: Z, a16<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int CALL_Z_a16(CpuState cpuState, IGameBoy gb)
    {
        var a16 = gb.ReadUShort(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "CALL_Z_a16", a16);

        cpuState.PC += 2;

        if (!cpuState.F.HasFlag(Flags.Zero)) return 12;

        gb.Push(cpuState.PC);

        cpuState.PC = a16;

        return 24;
    }

    /// <summary>
    ///     0xCD CALL - 24 cycles
    ///     <para>
    ///         Bytes: 3<br />
    ///         Operands: a16<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int CALL_a16(CpuState cpuState, IGameBoy gb)
    {
        var a16 = gb.ReadUShort(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "CALL_a16", a16);

        cpuState.PC += 2;

        gb.Push(cpuState.PC);

        cpuState.PC = a16;

        return 24;
    }

    /// <summary>
    ///     0xCF RST - 16 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: $08<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RST_0x08(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RST_0x08");

        gb.Push(cpuState.PC);

        cpuState.PC = 0x08;

        return 16;
    }

    /// <summary>
    ///     0xD0 RET - 20/8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: NC<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RET_NC(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RET_NC");

        if (cpuState.F.HasFlag(Flags.Carry)) return 8;

        cpuState.PC = gb.Pop();

        return 20;
    }

    /// <summary>
    ///     0xD2 JP - 16/12 cycles
    ///     <para>
    ///         Bytes: 3<br />
    ///         Operands: NC, a16<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int JP_NC_a16(CpuState cpuState, IGameBoy gb)
    {
        var a16 = gb.ReadUShort(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "JP_NC_a16", a16);

        cpuState.PC += 2;

        if (cpuState.F.HasFlag(Flags.Carry)) return 12;

        cpuState.PC = a16;

        return 16;
    }

    /// <summary>
    ///     0xD4 CALL - 24/12 cycles
    ///     <para>
    ///         Bytes: 3<br />
    ///         Operands: NC, a16<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int CALL_NC_a16(CpuState cpuState, IGameBoy gb)
    {
        var a16 = gb.ReadUShort(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "CALL_NC_a16", a16);

        cpuState.PC += 2;

        if (cpuState.F.HasFlag(Flags.Carry)) return 12;

        gb.Push(cpuState.PC);

        cpuState.PC = a16;

        return 24;
    }

    /// <summary>
    ///     0xD7 RST - 16 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: $10<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RST_0x10(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RST_0x10");

        gb.Push(cpuState.PC);

        cpuState.PC = 0x10;

        return 16;
    }

    /// <summary>
    ///     0xD8 RET - 20/8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RET_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RET_C");

        if (!cpuState.F.HasFlag(Flags.Carry)) return 8;

        cpuState.PC = gb.Pop();

        return 20;
    }

    /// <summary>
    ///     0xD9 RETI - 16 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: <br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RETI(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RETI");

        cpuState.PC = gb.Pop();
        cpuState.IME = true;

        gb.Resume();

        return 16;
    }

    /// <summary>
    ///     0xDA JP - 16/12 cycles
    ///     <para>
    ///         Bytes: 3<br />
    ///         Operands: C, a16<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int JP_C_a16(CpuState cpuState, IGameBoy gb)
    {
        var a16 = gb.ReadUShort(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "JP_C_a16", a16);

        cpuState.PC += 2;

        if (!cpuState.F.HasFlag(Flags.Carry)) return 12;

        cpuState.PC = a16;

        return 16;
    }

    /// <summary>
    ///     0xDC CALL - 24/12 cycles
    ///     <para>
    ///         Bytes: 3<br />
    ///         Operands: C, a16<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int CALL_C_a16(CpuState cpuState, IGameBoy gb)
    {
        var a16 = gb.ReadUShort(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "CALL_C_a16", a16);

        cpuState.PC += 2;

        if (!cpuState.F.HasFlag(Flags.Carry)) return 12;

        gb.Push(cpuState.PC);

        cpuState.PC = a16;

        return 24;
    }

    /// <summary>
    ///     0xDF RST - 16 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: $18<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RST_0x18(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RST_0x18");

        gb.Push(cpuState.PC);

        cpuState.PC = 0x18;

        return 16;
    }

    /// <summary>
    ///     0xE7 RST - 16 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: $20<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RST_0x20(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RST_0x20");

        gb.Push(cpuState.PC);

        cpuState.PC = 0x20;

        return 16;
    }

    /// <summary>
    ///     0xE9 JP - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: HL<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int JP_HL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "JP_HL");

        cpuState.PC = cpuState.HL;

        return 4;
    }

    /// <summary>
    ///     0xEF RST - 16 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: $28<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RST_0x28(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RST_0x28");

        gb.Push(cpuState.PC);

        cpuState.PC = 0x28;

        return 16;
    }

    /// <summary>
    ///     0xF7 RST - 16 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: $30<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RST_0x30(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RST_0x30");

        gb.Push(cpuState.PC);

        cpuState.PC = 0x30;

        return 16;
    }

    /// <summary>
    ///     0xFF RST - 16 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: $38<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RST_0x38(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RST_0x38");

        gb.Push(cpuState.PC);

        cpuState.PC = 0x38;

        return 16;
    }
}