// ReSharper disable once CheckNamespace

namespace gb.CPU;

public static partial class Executioner
{
    /// <summary>
    ///     0x00 RLC - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RLC_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RLC_B");

        throw new NotImplementedException("RLC_B");
    }

    /// <summary>
    ///     0x01 RLC - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RLC_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RLC_C");

        throw new NotImplementedException("RLC_C");
    }

    /// <summary>
    ///     0x02 RLC - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RLC_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RLC_D");

        throw new NotImplementedException("RLC_D");
    }

    /// <summary>
    ///     0x03 RLC - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RLC_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RLC_E");

        throw new NotImplementedException("RLC_E");
    }

    /// <summary>
    ///     0x04 RLC - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RLC_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RLC_H");

        throw new NotImplementedException("RLC_H");
    }

    /// <summary>
    ///     0x05 RLC - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RLC_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RLC_L");

        throw new NotImplementedException("RLC_L");
    }

    /// <summary>
    ///     0x06 RLC - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: [HL]<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RLC_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RLC_iHL");

        throw new NotImplementedException("RLC_iHL");
    }

    /// <summary>
    ///     0x07 RLC - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RLC_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RLC_A");

        throw new NotImplementedException("RLC_A");
    }

    /// <summary>
    ///     0x08 RRC - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RRC_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RRC_B");

        throw new NotImplementedException("RRC_B");
    }

    /// <summary>
    ///     0x09 RRC - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RRC_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RRC_C");

        throw new NotImplementedException("RRC_C");
    }

    /// <summary>
    ///     0x0A RRC - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RRC_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RRC_D");

        throw new NotImplementedException("RRC_D");
    }

    /// <summary>
    ///     0x0B RRC - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RRC_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RRC_E");

        throw new NotImplementedException("RRC_E");
    }

    /// <summary>
    ///     0x0C RRC - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RRC_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RRC_H");

        throw new NotImplementedException("RRC_H");
    }

    /// <summary>
    ///     0x0D RRC - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RRC_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RRC_L");

        throw new NotImplementedException("RRC_L");
    }

    /// <summary>
    ///     0x0E RRC - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: [HL]<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RRC_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RRC_iHL");

        throw new NotImplementedException("RRC_iHL");
    }

    /// <summary>
    ///     0x0F RRC - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RRC_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RRC_A");

        throw new NotImplementedException("RRC_A");
    }

    /// <summary>
    ///     0x10 RL - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RL_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RL_B");

        cpuState.F = 0;

        var bit7 = (cpuState.B & 0b1000_0000) != 0;
        cpuState.F = bit7 ? cpuState.F | Flags.Carry : cpuState.F & ~Flags.Carry;

        cpuState.B = (byte)((cpuState.B << 1) | (bit7 ? 1 : 0));

        cpuState.F = cpuState.B == 0 ? cpuState.F | Flags.Zero : cpuState.F & ~Flags.Zero;

        return 8;
    }

    /// <summary>
    ///     0x11 RL - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RL_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RL_C");

        cpuState.F = 0;

        var bit7 = (cpuState.C & 0b1000_0000) != 0;
        cpuState.F = bit7 ? cpuState.F | Flags.Carry : cpuState.F & ~Flags.Carry;

        cpuState.C = (byte)((cpuState.C << 1) | (bit7 ? 1 : 0));

        cpuState.F = cpuState.C == 0 ? cpuState.F | Flags.Zero : cpuState.F & ~Flags.Zero;

        return 8;
    }

    /// <summary>
    ///     0x12 RL - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RL_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RL_D");

        throw new NotImplementedException("RL_D");
    }

    /// <summary>
    ///     0x13 RL - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RL_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RL_E");

        throw new NotImplementedException("RL_E");
    }

    /// <summary>
    ///     0x14 RL - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RL_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RL_H");

        throw new NotImplementedException("RL_H");
    }

    /// <summary>
    ///     0x15 RL - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RL_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RL_L");

        throw new NotImplementedException("RL_L");
    }

    /// <summary>
    ///     0x16 RL - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: [HL]<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RL_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RL_iHL");

        throw new NotImplementedException("RL_iHL");
    }

    /// <summary>
    ///     0x17 RL - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RL_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RL_A");

        throw new NotImplementedException("RL_A");
    }

    /// <summary>
    ///     0x18 RR - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RR_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RR_B");

        throw new NotImplementedException("RR_B");
    }

    /// <summary>
    ///     0x19 RR - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RR_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RR_C");

        throw new NotImplementedException("RR_C");
    }

    /// <summary>
    ///     0x1A RR - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RR_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RR_D");

        throw new NotImplementedException("RR_D");
    }

    /// <summary>
    ///     0x1B RR - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RR_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RR_E");

        throw new NotImplementedException("RR_E");
    }

    /// <summary>
    ///     0x1C RR - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RR_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RR_H");

        throw new NotImplementedException("RR_H");
    }

    /// <summary>
    ///     0x1D RR - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RR_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RR_L");

        throw new NotImplementedException("RR_L");
    }

    /// <summary>
    ///     0x1E RR - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: [HL]<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RR_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RR_iHL");

        throw new NotImplementedException("RR_iHL");
    }

    /// <summary>
    ///     0x1F RR - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RR_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RR_A");

        throw new NotImplementedException("RR_A");
    }

    /// <summary>
    ///     0x20 SLA - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SLA_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SLA_B");

        throw new NotImplementedException("SLA_B");
    }

    /// <summary>
    ///     0x21 SLA - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SLA_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SLA_C");

        throw new NotImplementedException("SLA_C");
    }

    /// <summary>
    ///     0x22 SLA - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SLA_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SLA_D");

        throw new NotImplementedException("SLA_D");
    }

    /// <summary>
    ///     0x23 SLA - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SLA_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SLA_E");

        throw new NotImplementedException("SLA_E");
    }

    /// <summary>
    ///     0x24 SLA - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SLA_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SLA_H");

        throw new NotImplementedException("SLA_H");
    }

    /// <summary>
    ///     0x25 SLA - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SLA_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SLA_L");

        throw new NotImplementedException("SLA_L");
    }

    /// <summary>
    ///     0x26 SLA - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: [HL]<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SLA_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SLA_iHL");

        throw new NotImplementedException("SLA_iHL");
    }

    /// <summary>
    ///     0x27 SLA - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SLA_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SLA_A");

        throw new NotImplementedException("SLA_A");
    }

    /// <summary>
    ///     0x28 SRA - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SRA_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SRA_B");

        throw new NotImplementedException("SRA_B");
    }

    /// <summary>
    ///     0x29 SRA - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SRA_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SRA_C");

        throw new NotImplementedException("SRA_C");
    }

    /// <summary>
    ///     0x2A SRA - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SRA_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SRA_D");

        throw new NotImplementedException("SRA_D");
    }

    /// <summary>
    ///     0x2B SRA - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SRA_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SRA_E");

        throw new NotImplementedException("SRA_E");
    }

    /// <summary>
    ///     0x2C SRA - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SRA_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SRA_H");

        throw new NotImplementedException("SRA_H");
    }

    /// <summary>
    ///     0x2D SRA - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SRA_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SRA_L");

        throw new NotImplementedException("SRA_L");
    }

    /// <summary>
    ///     0x2E SRA - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: [HL]<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SRA_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SRA_iHL");

        throw new NotImplementedException("SRA_iHL");
    }

    /// <summary>
    ///     0x2F SRA - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SRA_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SRA_A");

        throw new NotImplementedException("SRA_A");
    }

    /// <summary>
    ///     0x30 SWAP - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SWAP_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SWAP_B");

        throw new NotImplementedException("SWAP_B");
    }

    /// <summary>
    ///     0x31 SWAP - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SWAP_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SWAP_C");

        throw new NotImplementedException("SWAP_C");
    }

    /// <summary>
    ///     0x32 SWAP - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SWAP_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SWAP_D");

        throw new NotImplementedException("SWAP_D");
    }

    /// <summary>
    ///     0x33 SWAP - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SWAP_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SWAP_E");

        throw new NotImplementedException("SWAP_E");
    }

    /// <summary>
    ///     0x34 SWAP - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SWAP_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SWAP_H");

        throw new NotImplementedException("SWAP_H");
    }

    /// <summary>
    ///     0x35 SWAP - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SWAP_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SWAP_L");

        throw new NotImplementedException("SWAP_L");
    }

    /// <summary>
    ///     0x36 SWAP - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: [HL]<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SWAP_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SWAP_iHL");

        throw new NotImplementedException("SWAP_iHL");
    }

    /// <summary>
    ///     0x37 SWAP - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SWAP_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SWAP_A");

        cpuState.F = 0;

        cpuState.A = (byte)((cpuState.A >> 4) | (cpuState.A << 4));

        if (cpuState.A == 0)
            cpuState.F |= Flags.Zero;

        return 8;
    }

    /// <summary>
    ///     0x38 SRL - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SRL_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SRL_B");

        throw new NotImplementedException("SRL_B");
    }

    /// <summary>
    ///     0x39 SRL - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SRL_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SRL_C");

        throw new NotImplementedException("SRL_C");
    }

    /// <summary>
    ///     0x3A SRL - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SRL_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SRL_D");

        throw new NotImplementedException("SRL_D");
    }

    /// <summary>
    ///     0x3B SRL - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SRL_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SRL_E");

        throw new NotImplementedException("SRL_E");
    }

    /// <summary>
    ///     0x3C SRL - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SRL_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SRL_H");

        throw new NotImplementedException("SRL_H");
    }

    /// <summary>
    ///     0x3D SRL - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SRL_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SRL_L");

        throw new NotImplementedException("SRL_L");
    }

    /// <summary>
    ///     0x3E SRL - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: [HL]<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SRL_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SRL_iHL");

        throw new NotImplementedException("SRL_iHL");
    }

    /// <summary>
    ///     0x3F SRL - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SRL_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SRL_A");

        throw new NotImplementedException("SRL_A");
    }

    /// <summary>
    ///     0x40 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 0, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_0_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_0_B");

        throw new NotImplementedException("BIT_0_B");
    }

    /// <summary>
    ///     0x41 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 0, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_0_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_0_C");

        throw new NotImplementedException("BIT_0_C");
    }

    /// <summary>
    ///     0x42 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 0, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_0_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_0_D");

        throw new NotImplementedException("BIT_0_D");
    }

    /// <summary>
    ///     0x43 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 0, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_0_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_0_E");

        throw new NotImplementedException("BIT_0_E");
    }

    /// <summary>
    ///     0x44 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 0, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_0_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_0_H");

        throw new NotImplementedException("BIT_0_H");
    }

    /// <summary>
    ///     0x45 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 0, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_0_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_0_L");

        throw new NotImplementedException("BIT_0_L");
    }

    /// <summary>
    ///     0x46 BIT - 12 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 0, [HL]<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_0_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_0_iHL");

        throw new NotImplementedException("BIT_0_iHL");
    }

    /// <summary>
    ///     0x47 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 0, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_0_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_0_A");

        throw new NotImplementedException("BIT_0_A");
    }

    /// <summary>
    ///     0x48 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 1, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_1_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_1_B");

        throw new NotImplementedException("BIT_1_B");
    }

    /// <summary>
    ///     0x49 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 1, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_1_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_1_C");

        throw new NotImplementedException("BIT_1_C");
    }

    /// <summary>
    ///     0x4A BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 1, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_1_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_1_D");

        throw new NotImplementedException("BIT_1_D");
    }

    /// <summary>
    ///     0x4B BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 1, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_1_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_1_E");

        throw new NotImplementedException("BIT_1_E");
    }

    /// <summary>
    ///     0x4C BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 1, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_1_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_1_H");

        throw new NotImplementedException("BIT_1_H");
    }

    /// <summary>
    ///     0x4D BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 1, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_1_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_1_L");

        throw new NotImplementedException("BIT_1_L");
    }

    /// <summary>
    ///     0x4E BIT - 12 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 1, [HL]<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_1_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_1_iHL");

        throw new NotImplementedException("BIT_1_iHL");
    }

    /// <summary>
    ///     0x4F BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 1, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_1_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_1_A");

        throw new NotImplementedException("BIT_1_A");
    }

    /// <summary>
    ///     0x50 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 2, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_2_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_2_B");

        throw new NotImplementedException("BIT_2_B");
    }

    /// <summary>
    ///     0x51 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 2, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_2_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_2_C");

        throw new NotImplementedException("BIT_2_C");
    }

    /// <summary>
    ///     0x52 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 2, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_2_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_2_D");

        throw new NotImplementedException("BIT_2_D");
    }

    /// <summary>
    ///     0x53 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 2, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_2_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_2_E");

        throw new NotImplementedException("BIT_2_E");
    }

    /// <summary>
    ///     0x54 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 2, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_2_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_2_H");

        throw new NotImplementedException("BIT_2_H");
    }

    /// <summary>
    ///     0x55 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 2, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_2_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_2_L");

        throw new NotImplementedException("BIT_2_L");
    }

    /// <summary>
    ///     0x56 BIT - 12 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 2, [HL]<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_2_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_2_iHL");

        throw new NotImplementedException("BIT_2_iHL");
    }

    /// <summary>
    ///     0x57 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 2, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_2_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_2_A");

        throw new NotImplementedException("BIT_2_A");
    }

    /// <summary>
    ///     0x58 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 3, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_3_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_3_B");

        throw new NotImplementedException("BIT_3_B");
    }

    /// <summary>
    ///     0x59 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 3, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_3_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_3_C");

        throw new NotImplementedException("BIT_3_C");
    }

    /// <summary>
    ///     0x5A BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 3, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_3_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_3_D");

        throw new NotImplementedException("BIT_3_D");
    }

    /// <summary>
    ///     0x5B BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 3, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_3_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_3_E");

        throw new NotImplementedException("BIT_3_E");
    }

    /// <summary>
    ///     0x5C BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 3, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_3_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_3_H");

        throw new NotImplementedException("BIT_3_H");
    }

    /// <summary>
    ///     0x5D BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 3, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_3_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_3_L");

        throw new NotImplementedException("BIT_3_L");
    }

    /// <summary>
    ///     0x5E BIT - 12 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 3, [HL]<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_3_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_3_iHL");

        throw new NotImplementedException("BIT_3_iHL");
    }

    /// <summary>
    ///     0x5F BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 3, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_3_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_3_A");

        throw new NotImplementedException("BIT_3_A");
    }

    /// <summary>
    ///     0x60 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 4, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_4_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_4_B");

        throw new NotImplementedException("BIT_4_B");
    }

    /// <summary>
    ///     0x61 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 4, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_4_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_4_C");

        throw new NotImplementedException("BIT_4_C");
    }

    /// <summary>
    ///     0x62 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 4, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_4_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_4_D");

        throw new NotImplementedException("BIT_4_D");
    }

    /// <summary>
    ///     0x63 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 4, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_4_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_4_E");

        throw new NotImplementedException("BIT_4_E");
    }

    /// <summary>
    ///     0x64 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 4, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_4_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_4_H");

        throw new NotImplementedException("BIT_4_H");
    }

    /// <summary>
    ///     0x65 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 4, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_4_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_4_L");

        throw new NotImplementedException("BIT_4_L");
    }

    /// <summary>
    ///     0x66 BIT - 12 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 4, [HL]<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_4_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_4_iHL");

        throw new NotImplementedException("BIT_4_iHL");
    }

    /// <summary>
    ///     0x67 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 4, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_4_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_4_A");

        throw new NotImplementedException("BIT_4_A");
    }

    /// <summary>
    ///     0x68 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 5, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_5_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_5_B");

        throw new NotImplementedException("BIT_5_B");
    }

    /// <summary>
    ///     0x69 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 5, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_5_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_5_C");

        throw new NotImplementedException("BIT_5_C");
    }

    /// <summary>
    ///     0x6A BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 5, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_5_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_5_D");

        throw new NotImplementedException("BIT_5_D");
    }

    /// <summary>
    ///     0x6B BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 5, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_5_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_5_E");

        throw new NotImplementedException("BIT_5_E");
    }

    /// <summary>
    ///     0x6C BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 5, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_5_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_5_H");

        cpuState.F &= ~Flags.Subtract;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.H & 0b00100000) != 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
    }

    /// <summary>
    ///     0x6D BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 5, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_5_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_5_L");

        throw new NotImplementedException("BIT_5_L");
    }

    /// <summary>
    ///     0x6E BIT - 12 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 5, [HL]<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_5_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_5_iHL");

        throw new NotImplementedException("BIT_5_iHL");
    }

    /// <summary>
    ///     0x6F BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 5, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_5_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_5_A");

        throw new NotImplementedException("BIT_5_A");
    }

    /// <summary>
    ///     0x70 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 6, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_6_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_6_B");

        throw new NotImplementedException("BIT_6_B");
    }

    /// <summary>
    ///     0x71 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 6, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_6_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_6_C");

        throw new NotImplementedException("BIT_6_C");
    }

    /// <summary>
    ///     0x72 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 6, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_6_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_6_D");

        throw new NotImplementedException("BIT_6_D");
    }

    /// <summary>
    ///     0x73 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 6, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_6_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_6_E");

        throw new NotImplementedException("BIT_6_E");
    }

    /// <summary>
    ///     0x74 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 6, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_6_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_6_H");

        throw new NotImplementedException("BIT_6_H");
    }

    /// <summary>
    ///     0x75 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 6, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_6_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_6_L");

        throw new NotImplementedException("BIT_6_L");
    }

    /// <summary>
    ///     0x76 BIT - 12 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 6, [HL]<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_6_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_6_iHL");

        throw new NotImplementedException("BIT_6_iHL");
    }

    /// <summary>
    ///     0x77 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 6, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_6_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_6_A");

        throw new NotImplementedException("BIT_6_A");
    }

    /// <summary>
    ///     0x78 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 7, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_7_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_7_B");

        throw new NotImplementedException("BIT_7_B");
    }

    /// <summary>
    ///     0x79 BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 7, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_7_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_7_C");

        throw new NotImplementedException("BIT_7_C");
    }

    /// <summary>
    ///     0x7A BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 7, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_7_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_7_D");

        throw new NotImplementedException("BIT_7_D");
    }

    /// <summary>
    ///     0x7B BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 7, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_7_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_7_E");

        throw new NotImplementedException("BIT_7_E");
    }

    /// <summary>
    ///     0x7C BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 7, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_7_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_7_H");

        cpuState.F &= ~Flags.Subtract;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.H & 0b10000000) != 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
    }

    /// <summary>
    ///     0x7D BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 7, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_7_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_7_L");

        throw new NotImplementedException("BIT_7_L");
    }

    /// <summary>
    ///     0x7E BIT - 12 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 7, [HL]<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_7_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_7_iHL");

        throw new NotImplementedException("BIT_7_iHL");
    }

    /// <summary>
    ///     0x7F BIT - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 7, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int BIT_7_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "BIT_7_A");

        throw new NotImplementedException("BIT_7_A");
    }

    /// <summary>
    ///     0x80 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 0, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_0_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_0_B");

        throw new NotImplementedException("RES_0_B");
    }

    /// <summary>
    ///     0x81 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 0, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_0_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_0_C");

        throw new NotImplementedException("RES_0_C");
    }

    /// <summary>
    ///     0x82 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 0, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_0_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_0_D");

        throw new NotImplementedException("RES_0_D");
    }

    /// <summary>
    ///     0x83 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 0, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_0_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_0_E");

        throw new NotImplementedException("RES_0_E");
    }

    /// <summary>
    ///     0x84 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 0, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_0_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_0_H");

        throw new NotImplementedException("RES_0_H");
    }

    /// <summary>
    ///     0x85 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 0, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_0_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_0_L");

        throw new NotImplementedException("RES_0_L");
    }

    /// <summary>
    ///     0x86 RES - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 0, [HL]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_0_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_0_iHL");

        throw new NotImplementedException("RES_0_iHL");
    }

    /// <summary>
    ///     0x87 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 0, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_0_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_0_A");

        throw new NotImplementedException("RES_0_A");
    }

    /// <summary>
    ///     0x88 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 1, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_1_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_1_B");

        throw new NotImplementedException("RES_1_B");
    }

    /// <summary>
    ///     0x89 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 1, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_1_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_1_C");

        throw new NotImplementedException("RES_1_C");
    }

    /// <summary>
    ///     0x8A RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 1, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_1_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_1_D");

        throw new NotImplementedException("RES_1_D");
    }

    /// <summary>
    ///     0x8B RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 1, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_1_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_1_E");

        throw new NotImplementedException("RES_1_E");
    }

    /// <summary>
    ///     0x8C RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 1, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_1_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_1_H");

        throw new NotImplementedException("RES_1_H");
    }

    /// <summary>
    ///     0x8D RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 1, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_1_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_1_L");

        throw new NotImplementedException("RES_1_L");
    }

    /// <summary>
    ///     0x8E RES - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 1, [HL]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_1_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_1_iHL");

        throw new NotImplementedException("RES_1_iHL");
    }

    /// <summary>
    ///     0x8F RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 1, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_1_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_1_A");

        throw new NotImplementedException("RES_1_A");
    }

    /// <summary>
    ///     0x90 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 2, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_2_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_2_B");

        throw new NotImplementedException("RES_2_B");
    }

    /// <summary>
    ///     0x91 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 2, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_2_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_2_C");

        throw new NotImplementedException("RES_2_C");
    }

    /// <summary>
    ///     0x92 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 2, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_2_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_2_D");

        throw new NotImplementedException("RES_2_D");
    }

    /// <summary>
    ///     0x93 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 2, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_2_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_2_E");

        throw new NotImplementedException("RES_2_E");
    }

    /// <summary>
    ///     0x94 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 2, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_2_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_2_H");

        throw new NotImplementedException("RES_2_H");
    }

    /// <summary>
    ///     0x95 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 2, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_2_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_2_L");

        throw new NotImplementedException("RES_2_L");
    }

    /// <summary>
    ///     0x96 RES - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 2, [HL]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_2_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_2_iHL");

        throw new NotImplementedException("RES_2_iHL");
    }

    /// <summary>
    ///     0x97 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 2, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_2_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_2_A");

        throw new NotImplementedException("RES_2_A");
    }

    /// <summary>
    ///     0x98 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 3, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_3_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_3_B");

        throw new NotImplementedException("RES_3_B");
    }

    /// <summary>
    ///     0x99 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 3, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_3_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_3_C");

        throw new NotImplementedException("RES_3_C");
    }

    /// <summary>
    ///     0x9A RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 3, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_3_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_3_D");

        throw new NotImplementedException("RES_3_D");
    }

    /// <summary>
    ///     0x9B RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 3, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_3_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_3_E");

        throw new NotImplementedException("RES_3_E");
    }

    /// <summary>
    ///     0x9C RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 3, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_3_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_3_H");

        throw new NotImplementedException("RES_3_H");
    }

    /// <summary>
    ///     0x9D RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 3, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_3_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_3_L");

        throw new NotImplementedException("RES_3_L");
    }

    /// <summary>
    ///     0x9E RES - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 3, [HL]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_3_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_3_iHL");

        throw new NotImplementedException("RES_3_iHL");
    }

    /// <summary>
    ///     0x9F RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 3, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_3_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_3_A");

        throw new NotImplementedException("RES_3_A");
    }

    /// <summary>
    ///     0xA0 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 4, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_4_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_4_B");

        throw new NotImplementedException("RES_4_B");
    }

    /// <summary>
    ///     0xA1 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 4, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_4_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_4_C");

        throw new NotImplementedException("RES_4_C");
    }

    /// <summary>
    ///     0xA2 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 4, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_4_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_4_D");

        throw new NotImplementedException("RES_4_D");
    }

    /// <summary>
    ///     0xA3 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 4, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_4_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_4_E");

        throw new NotImplementedException("RES_4_E");
    }

    /// <summary>
    ///     0xA4 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 4, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_4_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_4_H");

        throw new NotImplementedException("RES_4_H");
    }

    /// <summary>
    ///     0xA5 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 4, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_4_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_4_L");

        throw new NotImplementedException("RES_4_L");
    }

    /// <summary>
    ///     0xA6 RES - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 4, [HL]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_4_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_4_iHL");

        throw new NotImplementedException("RES_4_iHL");
    }

    /// <summary>
    ///     0xA7 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 4, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_4_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_4_A");

        throw new NotImplementedException("RES_4_A");
    }

    /// <summary>
    ///     0xA8 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 5, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_5_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_5_B");

        throw new NotImplementedException("RES_5_B");
    }

    /// <summary>
    ///     0xA9 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 5, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_5_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_5_C");

        throw new NotImplementedException("RES_5_C");
    }

    /// <summary>
    ///     0xAA RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 5, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_5_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_5_D");

        throw new NotImplementedException("RES_5_D");
    }

    /// <summary>
    ///     0xAB RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 5, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_5_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_5_E");

        throw new NotImplementedException("RES_5_E");
    }

    /// <summary>
    ///     0xAC RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 5, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_5_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_5_H");

        throw new NotImplementedException("RES_5_H");
    }

    /// <summary>
    ///     0xAD RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 5, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_5_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_5_L");

        throw new NotImplementedException("RES_5_L");
    }

    /// <summary>
    ///     0xAE RES - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 5, [HL]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_5_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_5_iHL");

        throw new NotImplementedException("RES_5_iHL");
    }

    /// <summary>
    ///     0xAF RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 5, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_5_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_5_A");

        throw new NotImplementedException("RES_5_A");
    }

    /// <summary>
    ///     0xB0 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 6, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_6_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_6_B");

        throw new NotImplementedException("RES_6_B");
    }

    /// <summary>
    ///     0xB1 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 6, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_6_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_6_C");

        throw new NotImplementedException("RES_6_C");
    }

    /// <summary>
    ///     0xB2 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 6, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_6_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_6_D");

        throw new NotImplementedException("RES_6_D");
    }

    /// <summary>
    ///     0xB3 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 6, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_6_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_6_E");

        throw new NotImplementedException("RES_6_E");
    }

    /// <summary>
    ///     0xB4 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 6, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_6_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_6_H");

        throw new NotImplementedException("RES_6_H");
    }

    /// <summary>
    ///     0xB5 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 6, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_6_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_6_L");

        throw new NotImplementedException("RES_6_L");
    }

    /// <summary>
    ///     0xB6 RES - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 6, [HL]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_6_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_6_iHL");

        throw new NotImplementedException("RES_6_iHL");
    }

    /// <summary>
    ///     0xB7 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 6, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_6_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_6_A");

        throw new NotImplementedException("RES_6_A");
    }

    /// <summary>
    ///     0xB8 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 7, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_7_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_7_B");

        throw new NotImplementedException("RES_7_B");
    }

    /// <summary>
    ///     0xB9 RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 7, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_7_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_7_C");

        throw new NotImplementedException("RES_7_C");
    }

    /// <summary>
    ///     0xBA RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 7, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_7_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_7_D");

        throw new NotImplementedException("RES_7_D");
    }

    /// <summary>
    ///     0xBB RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 7, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_7_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_7_E");

        throw new NotImplementedException("RES_7_E");
    }

    /// <summary>
    ///     0xBC RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 7, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_7_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_7_H");

        throw new NotImplementedException("RES_7_H");
    }

    /// <summary>
    ///     0xBD RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 7, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_7_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_7_L");

        throw new NotImplementedException("RES_7_L");
    }

    /// <summary>
    ///     0xBE RES - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 7, [HL]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_7_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_7_iHL");

        throw new NotImplementedException("RES_7_iHL");
    }

    /// <summary>
    ///     0xBF RES - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 7, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RES_7_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RES_7_A");

        throw new NotImplementedException("RES_7_A");
    }

    /// <summary>
    ///     0xC0 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 0, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_0_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_0_B");

        throw new NotImplementedException("SET_0_B");
    }

    /// <summary>
    ///     0xC1 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 0, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_0_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_0_C");

        throw new NotImplementedException("SET_0_C");
    }

    /// <summary>
    ///     0xC2 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 0, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_0_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_0_D");

        throw new NotImplementedException("SET_0_D");
    }

    /// <summary>
    ///     0xC3 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 0, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_0_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_0_E");

        throw new NotImplementedException("SET_0_E");
    }

    /// <summary>
    ///     0xC4 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 0, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_0_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_0_H");

        throw new NotImplementedException("SET_0_H");
    }

    /// <summary>
    ///     0xC5 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 0, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_0_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_0_L");

        throw new NotImplementedException("SET_0_L");
    }

    /// <summary>
    ///     0xC6 SET - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 0, [HL]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_0_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_0_iHL");

        throw new NotImplementedException("SET_0_iHL");
    }

    /// <summary>
    ///     0xC7 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 0, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_0_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_0_A");

        throw new NotImplementedException("SET_0_A");
    }

    /// <summary>
    ///     0xC8 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 1, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_1_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_1_B");

        throw new NotImplementedException("SET_1_B");
    }

    /// <summary>
    ///     0xC9 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 1, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_1_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_1_C");

        throw new NotImplementedException("SET_1_C");
    }

    /// <summary>
    ///     0xCA SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 1, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_1_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_1_D");

        throw new NotImplementedException("SET_1_D");
    }

    /// <summary>
    ///     0xCB SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 1, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_1_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_1_E");

        throw new NotImplementedException("SET_1_E");
    }

    /// <summary>
    ///     0xCC SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 1, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_1_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_1_H");

        throw new NotImplementedException("SET_1_H");
    }

    /// <summary>
    ///     0xCD SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 1, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_1_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_1_L");

        throw new NotImplementedException("SET_1_L");
    }

    /// <summary>
    ///     0xCE SET - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 1, [HL]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_1_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_1_iHL");

        throw new NotImplementedException("SET_1_iHL");
    }

    /// <summary>
    ///     0xCF SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 1, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_1_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_1_A");

        throw new NotImplementedException("SET_1_A");
    }

    /// <summary>
    ///     0xD0 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 2, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_2_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_2_B");

        throw new NotImplementedException("SET_2_B");
    }

    /// <summary>
    ///     0xD1 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 2, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_2_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_2_C");

        throw new NotImplementedException("SET_2_C");
    }

    /// <summary>
    ///     0xD2 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 2, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_2_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_2_D");

        throw new NotImplementedException("SET_2_D");
    }

    /// <summary>
    ///     0xD3 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 2, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_2_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_2_E");

        throw new NotImplementedException("SET_2_E");
    }

    /// <summary>
    ///     0xD4 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 2, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_2_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_2_H");

        throw new NotImplementedException("SET_2_H");
    }

    /// <summary>
    ///     0xD5 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 2, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_2_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_2_L");

        throw new NotImplementedException("SET_2_L");
    }

    /// <summary>
    ///     0xD6 SET - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 2, [HL]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_2_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_2_iHL");

        throw new NotImplementedException("SET_2_iHL");
    }

    /// <summary>
    ///     0xD7 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 2, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_2_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_2_A");

        throw new NotImplementedException("SET_2_A");
    }

    /// <summary>
    ///     0xD8 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 3, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_3_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_3_B");

        throw new NotImplementedException("SET_3_B");
    }

    /// <summary>
    ///     0xD9 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 3, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_3_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_3_C");

        throw new NotImplementedException("SET_3_C");
    }

    /// <summary>
    ///     0xDA SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 3, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_3_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_3_D");

        throw new NotImplementedException("SET_3_D");
    }

    /// <summary>
    ///     0xDB SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 3, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_3_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_3_E");

        throw new NotImplementedException("SET_3_E");
    }

    /// <summary>
    ///     0xDC SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 3, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_3_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_3_H");

        throw new NotImplementedException("SET_3_H");
    }

    /// <summary>
    ///     0xDD SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 3, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_3_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_3_L");

        throw new NotImplementedException("SET_3_L");
    }

    /// <summary>
    ///     0xDE SET - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 3, [HL]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_3_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_3_iHL");

        throw new NotImplementedException("SET_3_iHL");
    }

    /// <summary>
    ///     0xDF SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 3, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_3_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_3_A");

        throw new NotImplementedException("SET_3_A");
    }

    /// <summary>
    ///     0xE0 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 4, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_4_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_4_B");

        throw new NotImplementedException("SET_4_B");
    }

    /// <summary>
    ///     0xE1 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 4, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_4_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_4_C");

        throw new NotImplementedException("SET_4_C");
    }

    /// <summary>
    ///     0xE2 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 4, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_4_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_4_D");

        throw new NotImplementedException("SET_4_D");
    }

    /// <summary>
    ///     0xE3 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 4, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_4_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_4_E");

        throw new NotImplementedException("SET_4_E");
    }

    /// <summary>
    ///     0xE4 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 4, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_4_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_4_H");

        throw new NotImplementedException("SET_4_H");
    }

    /// <summary>
    ///     0xE5 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 4, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_4_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_4_L");

        throw new NotImplementedException("SET_4_L");
    }

    /// <summary>
    ///     0xE6 SET - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 4, [HL]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_4_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_4_iHL");

        throw new NotImplementedException("SET_4_iHL");
    }

    /// <summary>
    ///     0xE7 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 4, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_4_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_4_A");

        throw new NotImplementedException("SET_4_A");
    }

    /// <summary>
    ///     0xE8 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 5, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_5_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_5_B");

        throw new NotImplementedException("SET_5_B");
    }

    /// <summary>
    ///     0xE9 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 5, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_5_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_5_C");

        throw new NotImplementedException("SET_5_C");
    }

    /// <summary>
    ///     0xEA SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 5, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_5_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_5_D");

        throw new NotImplementedException("SET_5_D");
    }

    /// <summary>
    ///     0xEB SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 5, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_5_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_5_E");

        throw new NotImplementedException("SET_5_E");
    }

    /// <summary>
    ///     0xEC SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 5, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_5_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_5_H");

        throw new NotImplementedException("SET_5_H");
    }

    /// <summary>
    ///     0xED SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 5, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_5_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_5_L");

        throw new NotImplementedException("SET_5_L");
    }

    /// <summary>
    ///     0xEE SET - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 5, [HL]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_5_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_5_iHL");

        throw new NotImplementedException("SET_5_iHL");
    }

    /// <summary>
    ///     0xEF SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 5, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_5_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_5_A");

        throw new NotImplementedException("SET_5_A");
    }

    /// <summary>
    ///     0xF0 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 6, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_6_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_6_B");

        throw new NotImplementedException("SET_6_B");
    }

    /// <summary>
    ///     0xF1 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 6, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_6_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_6_C");

        throw new NotImplementedException("SET_6_C");
    }

    /// <summary>
    ///     0xF2 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 6, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_6_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_6_D");

        throw new NotImplementedException("SET_6_D");
    }

    /// <summary>
    ///     0xF3 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 6, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_6_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_6_E");

        throw new NotImplementedException("SET_6_E");
    }

    /// <summary>
    ///     0xF4 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 6, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_6_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_6_H");

        throw new NotImplementedException("SET_6_H");
    }

    /// <summary>
    ///     0xF5 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 6, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_6_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_6_L");

        throw new NotImplementedException("SET_6_L");
    }

    /// <summary>
    ///     0xF6 SET - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 6, [HL]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_6_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_6_iHL");

        throw new NotImplementedException("SET_6_iHL");
    }

    /// <summary>
    ///     0xF7 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 6, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_6_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_6_A");

        throw new NotImplementedException("SET_6_A");
    }

    /// <summary>
    ///     0xF8 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 7, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_7_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_7_B");

        throw new NotImplementedException("SET_7_B");
    }

    /// <summary>
    ///     0xF9 SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 7, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_7_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_7_C");

        throw new NotImplementedException("SET_7_C");
    }

    /// <summary>
    ///     0xFA SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 7, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_7_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_7_D");

        throw new NotImplementedException("SET_7_D");
    }

    /// <summary>
    ///     0xFB SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 7, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_7_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_7_E");

        throw new NotImplementedException("SET_7_E");
    }

    /// <summary>
    ///     0xFC SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 7, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_7_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_7_H");

        throw new NotImplementedException("SET_7_H");
    }

    /// <summary>
    ///     0xFD SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 7, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_7_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_7_L");

        throw new NotImplementedException("SET_7_L");
    }

    /// <summary>
    ///     0xFE SET - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 7, [HL]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_7_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_7_iHL");

        throw new NotImplementedException("SET_7_iHL");
    }

    /// <summary>
    ///     0xFF SET - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: 7, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SET_7_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SET_7_A");

        throw new NotImplementedException("SET_7_A");
    }
}