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
        gb.TraceCpuOp(cpuState.PC - 1, "RLCA");

        var value = cpuState.A;
        var carryOut = (value & 0x80) != 0;

        cpuState.A = (byte)((value << 1) | (carryOut ? 0x01 : 0x00));

        cpuState.F = carryOut ? Flags.Carry : 0;

        return 4;
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
        gb.TraceCpuOp(cpuState.PC - 1, "RRCA");

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
        gb.TraceCpuOp(cpuState.PC - 1, "RLA");

        cpuState.F = 0;

        var bit7 = (cpuState.A & 0b1000_0000) != 0;
        cpuState.F = bit7 ? cpuState.F | Flags.Carry : cpuState.F & ~Flags.Carry;

        cpuState.A = (byte)((cpuState.B << 1) | (bit7 ? 1 : 0));

        cpuState.F = cpuState.A == 0 ? cpuState.F | Flags.Zero : cpuState.F & ~Flags.Zero;

        return 4;
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
        gb.TraceCpuOp(cpuState.PC - 1, "RRA");

        var value = cpuState.A;
        var oldCarry = (cpuState.F & Flags.Carry) != 0; // Get carry flag
        var newCarry = (value & 0x01) != 0; // Check if bit 0 is set

        cpuState.A = (byte)((value >> 1) | (oldCarry ? 0x80 : 0x00)); // Rotate A right through carry

        // Set flags
        cpuState.F = newCarry ? Flags.Carry : 0; // Only Carry flag is updated
        return 4; // This instruction takes 4 cycles
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
        gb.TraceCpuOp(cpuState.PC - 1, "AND_A_B");

        cpuState.F &= ~Flags.Zero;
        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;
        cpuState.F &= ~Flags.Carry;

        cpuState.A &= cpuState.B;

        if (cpuState.A == 0) cpuState.F |= Flags.Zero;

        return 4;
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
        gb.TraceCpuOp(cpuState.PC - 1, "AND_A_C");

        cpuState.F &= ~Flags.Zero;
        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;
        cpuState.F &= ~Flags.Carry;

        cpuState.A &= cpuState.C;

        if (cpuState.A == 0) cpuState.F |= Flags.Zero;

        return 4;
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
        gb.TraceCpuOp(cpuState.PC - 1, "AND_A_D");

        cpuState.F &= ~Flags.Zero;
        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;
        cpuState.F &= ~Flags.Carry;

        cpuState.A &= cpuState.D;

        if (cpuState.A == 0) cpuState.F |= Flags.Zero;

        return 4;
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
        gb.TraceCpuOp(cpuState.PC - 1, "AND_A_E");

        cpuState.F &= ~Flags.Zero;
        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;
        cpuState.F &= ~Flags.Carry;

        cpuState.A &= cpuState.E;

        if (cpuState.A == 0) cpuState.F |= Flags.Zero;

        return 4;
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
        gb.TraceCpuOp(cpuState.PC - 1, "AND_A_H");

        cpuState.F &= ~Flags.Zero;
        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;
        cpuState.F &= ~Flags.Carry;

        cpuState.A &= cpuState.H;

        if (cpuState.A == 0) cpuState.F |= Flags.Zero;

        return 4;
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
        gb.TraceCpuOp(cpuState.PC - 1, "AND_A_L");

        cpuState.F &= ~Flags.Zero;
        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;
        cpuState.F &= ~Flags.Carry;

        cpuState.A &= cpuState.L;

        if (cpuState.A == 0) cpuState.F |= Flags.Zero;

        return 4;
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
        gb.TraceCpuOp(cpuState.PC - 1, "AND_A_iHL");

        cpuState.F &= ~Flags.Zero;
        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;
        cpuState.F &= ~Flags.Carry;

        var value = gb.ReadByte(cpuState.HL);

        cpuState.A &= value;

        if (cpuState.A == 0) cpuState.F |= Flags.Zero;

        return 8;
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
        gb.TraceCpuOp(cpuState.PC - 1, "AND_A_A");

        cpuState.F &= ~Flags.Zero;
        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;
        cpuState.F &= ~Flags.Carry;

        cpuState.A &= cpuState.A;

        if (cpuState.A == 0) cpuState.F |= Flags.Zero;

        return 4;
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
        gb.TraceCpuOp(cpuState.PC - 1, "XOR_A_B");

        cpuState.F &= ~Flags.Zero;
        cpuState.F &= ~Flags.Negative;
        cpuState.F &= ~Flags.HalfCarry;
        cpuState.F &= ~Flags.Carry;

        cpuState.A ^= cpuState.B;

        cpuState.F |= Flags.Zero;

        return 4;
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
        gb.TraceCpuOp(cpuState.PC - 1, "XOR_A_C");

        cpuState.F &= ~Flags.Zero;
        cpuState.F &= ~Flags.Negative;
        cpuState.F &= ~Flags.HalfCarry;
        cpuState.F &= ~Flags.Carry;

        cpuState.A ^= cpuState.C;

        if (cpuState.A == 0) cpuState.F |= Flags.Zero;

        return 4;
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
        gb.TraceCpuOp(cpuState.PC - 1, "XOR_A_D");

        cpuState.F &= ~Flags.Zero;
        cpuState.F &= ~Flags.Negative;
        cpuState.F &= ~Flags.HalfCarry;
        cpuState.F &= ~Flags.Carry;

        cpuState.A ^= cpuState.D;

        cpuState.F |= Flags.Zero;

        return 4;
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
        gb.TraceCpuOp(cpuState.PC - 1, "XOR_A_E");

        cpuState.F &= ~Flags.Zero;
        cpuState.F &= ~Flags.Negative;
        cpuState.F &= ~Flags.HalfCarry;
        cpuState.F &= ~Flags.Carry;

        cpuState.A ^= cpuState.E;

        cpuState.F |= Flags.Zero;

        return 4;
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
        gb.TraceCpuOp(cpuState.PC - 1, "XOR_A_H");

        cpuState.F &= ~Flags.Zero;
        cpuState.F &= ~Flags.Negative;
        cpuState.F &= ~Flags.HalfCarry;
        cpuState.F &= ~Flags.Carry;

        cpuState.A ^= cpuState.H;

        cpuState.F |= Flags.Zero;

        return 4;
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
        gb.TraceCpuOp(cpuState.PC - 1, "XOR_A_L");

        cpuState.F &= ~Flags.Zero;
        cpuState.F &= ~Flags.Negative;
        cpuState.F &= ~Flags.HalfCarry;
        cpuState.F &= ~Flags.Carry;

        cpuState.A ^= cpuState.L;

        cpuState.F |= Flags.Zero;

        return 4;
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
        gb.TraceCpuOp(cpuState.PC - 1, "XOR_A_iHL");

        var value = gb.ReadByte(cpuState.HL);

        cpuState.F &= ~Flags.Zero;
        cpuState.F &= ~Flags.Negative;
        cpuState.F &= ~Flags.HalfCarry;
        cpuState.F &= ~Flags.Carry;

        cpuState.A ^= value;

        if (cpuState.A == 0) cpuState.F |= Flags.Zero;

        return 8;
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
        gb.TraceCpuOp(cpuState.PC - 1, "XOR_A_A");

        cpuState.F &= ~Flags.Zero;
        cpuState.F &= ~Flags.Negative;
        cpuState.F &= ~Flags.HalfCarry;
        cpuState.F &= ~Flags.Carry;

        cpuState.A ^= cpuState.A;

        cpuState.F |= Flags.Zero;

        return 4;
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
        gb.TraceCpuOp(cpuState.PC - 1, "OR_A_B");

        cpuState.F &= ~Flags.Zero;
        cpuState.F &= ~Flags.Negative;
        cpuState.F &= ~Flags.HalfCarry;
        cpuState.F &= ~Flags.Carry;

        cpuState.A |= cpuState.B;

        if (cpuState.A == 0) cpuState.F |= Flags.Zero;

        return 4;
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
        gb.TraceCpuOp(cpuState.PC - 1, "OR_A_C");

        cpuState.F &= ~Flags.Zero;
        cpuState.F &= ~Flags.Negative;
        cpuState.F &= ~Flags.HalfCarry;
        cpuState.F &= ~Flags.Carry;

        cpuState.A |= cpuState.C;

        if (cpuState.A == 0) cpuState.F |= Flags.Zero;

        return 4;
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
        gb.TraceCpuOp(cpuState.PC - 1, "OR_A_D");

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
        gb.TraceCpuOp(cpuState.PC - 1, "OR_A_E");

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
        gb.TraceCpuOp(cpuState.PC - 1, "OR_A_H");

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
        gb.TraceCpuOp(cpuState.PC - 1, "OR_A_L");

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
        gb.TraceCpuOp(cpuState.PC - 1, "OR_A_iHL");

        cpuState.F &= ~Flags.Zero;
        cpuState.F &= ~Flags.Negative;
        cpuState.F &= ~Flags.HalfCarry;
        cpuState.F &= ~Flags.Carry;

        cpuState.A |= gb.ReadByte(cpuState.HL);

        if (cpuState.A == 0) cpuState.F |= Flags.Zero;

        return 4;
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
        gb.TraceCpuOp(cpuState.PC - 1, "OR_A_A");

        cpuState.F &= ~Flags.Zero;
        cpuState.F &= ~Flags.Negative;
        cpuState.F &= ~Flags.HalfCarry;
        cpuState.F &= ~Flags.Carry;

        cpuState.A |= cpuState.A;

        if (cpuState.A == 0) cpuState.F |= Flags.Zero;

        return 4;
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
        gb.TraceCpuOp(cpuState.PC - 1, "AND_A_n8", n8);

        cpuState.PC++;

        cpuState.F &= ~Flags.Zero;
        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;
        cpuState.F &= ~Flags.Carry;

        cpuState.A &= n8;

        if (cpuState.A == 0) cpuState.F |= Flags.Zero;

        return 8;
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
        gb.TraceCpuOp(cpuState.PC - 1, "XOR_A_n8", n8);

        cpuState.PC++;

        cpuState.F &= ~Flags.Zero;
        cpuState.F &= ~Flags.Negative;
        cpuState.F &= ~Flags.HalfCarry;
        cpuState.F &= ~Flags.Carry;

        cpuState.A ^= n8;

        if (cpuState.A == 0) cpuState.F |= Flags.Zero;

        return 4;
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
        gb.TraceCpuOp(cpuState.PC - 1, "OR_A_n8", n8);

        cpuState.F &= ~Flags.Zero;
        cpuState.F &= ~Flags.Negative;
        cpuState.F &= ~Flags.HalfCarry;
        cpuState.F &= ~Flags.Carry;

        cpuState.A |= n8;

        if (cpuState.A == 0) cpuState.F |= Flags.Zero;

        return 4;
    }
}