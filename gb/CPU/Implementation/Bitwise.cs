// ReSharper disable once CheckNamespace

namespace gb.CPU;

public static partial class Executioner
{
    /// <summary>
    ///     0x07 RLCA - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: <br />
    ///         Immediate mode<br />
    ///         Flags: Z=0, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RLCA(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "RLCA");

        throw new NotImplementedException("RLCA");
    }

    /// <summary>
    ///     0x0F RRCA - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: <br />
    ///         Immediate mode<br />
    ///         Flags: Z=0, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RRCA(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "RRCA");

        throw new NotImplementedException("RRCA");
    }

    /// <summary>
    ///     0x17 RLA - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: <br />
    ///         Immediate mode<br />
    ///         Flags: Z=0, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RLA(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "RLA");

        throw new NotImplementedException("RLA");
    }

    /// <summary>
    ///     0x1F RRA - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: <br />
    ///         Immediate mode<br />
    ///         Flags: Z=0, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RRA(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "RRA");

        throw new NotImplementedException("RRA");
    }

    /// <summary>
    ///     0xA0 AND - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int AND_A_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "AND_A_B");

        throw new NotImplementedException("AND_A_B");
    }

    /// <summary>
    ///     0xA1 AND - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int AND_A_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "AND_A_C");

        throw new NotImplementedException("AND_A_C");
    }

    /// <summary>
    ///     0xA2 AND - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int AND_A_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "AND_A_D");

        throw new NotImplementedException("AND_A_D");
    }

    /// <summary>
    ///     0xA3 AND - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int AND_A_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "AND_A_E");

        throw new NotImplementedException("AND_A_E");
    }

    /// <summary>
    ///     0xA4 AND - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int AND_A_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "AND_A_H");

        throw new NotImplementedException("AND_A_H");
    }

    /// <summary>
    ///     0xA5 AND - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int AND_A_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "AND_A_L");

        throw new NotImplementedException("AND_A_L");
    }

    /// <summary>
    ///     0xA6 AND - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, [HL]<br />
    ///         Flags: Z=Z, N=0, H=1, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int AND_A_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "AND_A_iHL");

        throw new NotImplementedException("AND_A_iHL");
    }

    /// <summary>
    ///     0xA7 AND - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int AND_A_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "AND_A_A");

        throw new NotImplementedException("AND_A_A");
    }

    /// <summary>
    ///     0xA8 XOR - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int XOR_A_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "XOR_A_B");

        throw new NotImplementedException("XOR_A_B");
    }

    /// <summary>
    ///     0xA9 XOR - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int XOR_A_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "XOR_A_C");

        throw new NotImplementedException("XOR_A_C");
    }

    /// <summary>
    ///     0xAA XOR - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int XOR_A_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "XOR_A_D");

        throw new NotImplementedException("XOR_A_D");
    }

    /// <summary>
    ///     0xAB XOR - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int XOR_A_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "XOR_A_E");

        throw new NotImplementedException("XOR_A_E");
    }

    /// <summary>
    ///     0xAC XOR - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int XOR_A_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "XOR_A_H");

        throw new NotImplementedException("XOR_A_H");
    }

    /// <summary>
    ///     0xAD XOR - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int XOR_A_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "XOR_A_L");

        throw new NotImplementedException("XOR_A_L");
    }

    /// <summary>
    ///     0xAE XOR - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, [HL]<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int XOR_A_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "XOR_A_iHL");

        throw new NotImplementedException("XOR_A_iHL");
    }

    /// <summary>
    ///     0xAF XOR - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=1, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int XOR_A_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "XOR_A_A");

        throw new NotImplementedException("XOR_A_A");
    }

    /// <summary>
    ///     0xB0 OR - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int OR_A_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "OR_A_B");

        throw new NotImplementedException("OR_A_B");
    }

    /// <summary>
    ///     0xB1 OR - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int OR_A_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "OR_A_C");

        throw new NotImplementedException("OR_A_C");
    }

    /// <summary>
    ///     0xB2 OR - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int OR_A_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "OR_A_D");

        throw new NotImplementedException("OR_A_D");
    }

    /// <summary>
    ///     0xB3 OR - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int OR_A_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "OR_A_E");

        throw new NotImplementedException("OR_A_E");
    }

    /// <summary>
    ///     0xB4 OR - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int OR_A_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "OR_A_H");

        throw new NotImplementedException("OR_A_H");
    }

    /// <summary>
    ///     0xB5 OR - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int OR_A_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "OR_A_L");

        throw new NotImplementedException("OR_A_L");
    }

    /// <summary>
    ///     0xB6 OR - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, [HL]<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int OR_A_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "OR_A_iHL");

        throw new NotImplementedException("OR_A_iHL");
    }

    /// <summary>
    ///     0xB7 OR - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int OR_A_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "OR_A_A");

        throw new NotImplementedException("OR_A_A");
    }

    /// <summary>
    ///     0xE6 AND - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: A, n8<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=1, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int AND_A_n8(CpuState cpuState, IGameBoy gb)
    {
        var n8 = gb.ReadByte(cpuState.PC);
        cpuState.PC++;

        gb.TraceCpuOp(cpuState.PC, "AND_A_n8", n8);

        throw new NotImplementedException("AND_A_n8");
    }

    /// <summary>
    ///     0xEE XOR - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: A, n8<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int XOR_A_n8(CpuState cpuState, IGameBoy gb)
    {
        var n8 = gb.ReadByte(cpuState.PC);
        cpuState.PC++;

        gb.TraceCpuOp(cpuState.PC, "XOR_A_n8", n8);

        throw new NotImplementedException("XOR_A_n8");
    }

    /// <summary>
    ///     0xF6 OR - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: A, n8<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int OR_A_n8(CpuState cpuState, IGameBoy gb)
    {
        var n8 = gb.ReadByte(cpuState.PC);
        cpuState.PC++;

        gb.TraceCpuOp(cpuState.PC, "OR_A_n8", n8);

        throw new NotImplementedException("OR_A_n8");
    }
}