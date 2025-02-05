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
        cpuState.PC++;

        gb.TraceCpuOp(cpuState.PC, "JR_e8", e8);

        throw new NotImplementedException("JR_e8");
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
        cpuState.PC++;

        gb.TraceCpuOp(cpuState.PC, "JR_NZ_e8", e8);

        throw new NotImplementedException("JR_NZ_e8");
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
        cpuState.PC++;

        gb.TraceCpuOp(cpuState.PC, "JR_Z_e8", e8);

        throw new NotImplementedException("JR_Z_e8");
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
        cpuState.PC++;

        gb.TraceCpuOp(cpuState.PC, "JR_NC_e8", e8);

        throw new NotImplementedException("JR_NC_e8");
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
        cpuState.PC++;

        gb.TraceCpuOp(cpuState.PC, "JR_C_e8", e8);

        throw new NotImplementedException("JR_C_e8");
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
        gb.TraceCpuOp(cpuState.PC, "RET_NZ");

        throw new NotImplementedException("RET_NZ");
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
        cpuState.PC += 2;

        gb.TraceCpuOp(cpuState.PC, "JP_NZ_a16", a16);

        throw new NotImplementedException("JP_NZ_a16");
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
        cpuState.PC += 2;

        gb.TraceCpuOp(cpuState.PC, "JP_a16", a16);

        throw new NotImplementedException("JP_a16");
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
        cpuState.PC += 2;

        gb.TraceCpuOp(cpuState.PC, "CALL_NZ_a16", a16);

        throw new NotImplementedException("CALL_NZ_a16");
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
        gb.TraceCpuOp(cpuState.PC, "RST_0x00");

        throw new NotImplementedException("RST_0x00");
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
        gb.TraceCpuOp(cpuState.PC, "RET_Z");

        throw new NotImplementedException("RET_Z");
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
        gb.TraceCpuOp(cpuState.PC, "RET");

        throw new NotImplementedException("RET");
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
        cpuState.PC += 2;

        gb.TraceCpuOp(cpuState.PC, "JP_Z_a16", a16);

        throw new NotImplementedException("JP_Z_a16");
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
        cpuState.PC += 2;

        gb.TraceCpuOp(cpuState.PC, "CALL_Z_a16", a16);

        throw new NotImplementedException("CALL_Z_a16");
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
        cpuState.PC += 2;

        gb.TraceCpuOp(cpuState.PC, "CALL_a16", a16);

        throw new NotImplementedException("CALL_a16");
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
        gb.TraceCpuOp(cpuState.PC, "RST_0x08");

        throw new NotImplementedException("RST_0x08");
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
        gb.TraceCpuOp(cpuState.PC, "RET_NC");

        throw new NotImplementedException("RET_NC");
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
        cpuState.PC += 2;

        gb.TraceCpuOp(cpuState.PC, "JP_NC_a16", a16);

        throw new NotImplementedException("JP_NC_a16");
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
        cpuState.PC += 2;

        gb.TraceCpuOp(cpuState.PC, "CALL_NC_a16", a16);

        throw new NotImplementedException("CALL_NC_a16");
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
        gb.TraceCpuOp(cpuState.PC, "RST_0x10");

        throw new NotImplementedException("RST_0x10");
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
        gb.TraceCpuOp(cpuState.PC, "RET_C");

        throw new NotImplementedException("RET_C");
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
        gb.TraceCpuOp(cpuState.PC, "RETI");

        throw new NotImplementedException("RETI");
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
        cpuState.PC += 2;

        gb.TraceCpuOp(cpuState.PC, "JP_C_a16", a16);

        throw new NotImplementedException("JP_C_a16");
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
        cpuState.PC += 2;

        gb.TraceCpuOp(cpuState.PC, "CALL_C_a16", a16);

        throw new NotImplementedException("CALL_C_a16");
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
        gb.TraceCpuOp(cpuState.PC, "RST_0x18");

        throw new NotImplementedException("RST_0x18");
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
        gb.TraceCpuOp(cpuState.PC, "RST_0x20");

        throw new NotImplementedException("RST_0x20");
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
        gb.TraceCpuOp(cpuState.PC, "JP_HL");

        throw new NotImplementedException("JP_HL");
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
        gb.TraceCpuOp(cpuState.PC, "RST_0x28");

        throw new NotImplementedException("RST_0x28");
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
        gb.TraceCpuOp(cpuState.PC, "RST_0x30");

        throw new NotImplementedException("RST_0x30");
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
        gb.TraceCpuOp(cpuState.PC, "RST_0x38");

        throw new NotImplementedException("RST_0x38");
    }
}