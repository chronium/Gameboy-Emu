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

        var value = cpuState.B;
        var carryOut = (value & 0x80) != 0;

        cpuState.B = (byte)((value << 1) | (carryOut ? 0x01 : 0x00));

        cpuState.F = carryOut ? Flags.Carry : 0;

        if (cpuState.B == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = cpuState.C;
        var carryOut = (value & 0x80) != 0;

        cpuState.C = (byte)((value << 1) | (carryOut ? 0x01 : 0x00));

        cpuState.F = carryOut ? Flags.Carry : 0;

        if (cpuState.C == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = cpuState.D;
        var carryOut = (value & 0x80) != 0;

        cpuState.D = (byte)((value << 1) | (carryOut ? 0x01 : 0x00));

        cpuState.F = carryOut ? Flags.Carry : 0;

        if (cpuState.D == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = cpuState.E;
        var carryOut = (value & 0x80) != 0;

        cpuState.E = (byte)((value << 1) | (carryOut ? 0x01 : 0x00));

        cpuState.F = carryOut ? Flags.Carry : 0;

        if (cpuState.E == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = cpuState.H;
        var carryOut = (value & 0x80) != 0;

        cpuState.H = (byte)((value << 1) | (carryOut ? 0x01 : 0x00));

        cpuState.F = carryOut ? Flags.Carry : 0;

        if (cpuState.H == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = cpuState.L;
        var carryOut = (value & 0x80) != 0;

        cpuState.L = (byte)((value << 1) | (carryOut ? 0x01 : 0x00));

        cpuState.F = carryOut ? Flags.Carry : 0;

        if (cpuState.L == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = gb.ReadByte(cpuState.HL);
        var carryOut = (value & 0x80) != 0;

        gb.WriteByte(cpuState.HL, (byte)((value << 1) | (carryOut ? 0x01 : 0x00)));

        cpuState.F = carryOut ? Flags.Carry : 0;

        if (gb.ReadByte(cpuState.HL) == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var oldValue = cpuState.A;
        var carryOut = (oldValue & 0x80) != 0;

        // Rotate left
        var result = (byte)((oldValue << 1) | (carryOut ? 1 : 0));
        cpuState.A = result;

        // Update flags
        Flags flags = 0;
        if (result == 0)
            flags |= Flags.Zero;
        if (carryOut)
            flags |= Flags.Carry;

        cpuState.F = flags;
        return 8;
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

        var value = cpuState.B;
        var carryOut = (value & 0x01) != 0;

        cpuState.B = (byte)((value >> 1) | (carryOut ? 0x80 : 0x00));

        cpuState.F = carryOut ? Flags.Carry : 0;
        if (cpuState.B == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = cpuState.C;
        var carryOut = (value & 0x01) != 0;

        cpuState.C = (byte)((value >> 1) | (carryOut ? 0x80 : 0x00));

        cpuState.F = carryOut ? Flags.Carry : 0;
        if (cpuState.C == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = cpuState.D;
        var carryOut = (value & 0x01) != 0;

        cpuState.D = (byte)((value >> 1) | (carryOut ? 0x80 : 0x00));

        cpuState.F = carryOut ? Flags.Carry : 0;
        if (cpuState.D == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = cpuState.E;
        var carryOut = (value & 0x01) != 0;

        cpuState.E = (byte)((value >> 1) | (carryOut ? 0x80 : 0x00));

        cpuState.F = carryOut ? Flags.Carry : 0;
        if (cpuState.E == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = cpuState.H;
        var carryOut = (value & 0x01) != 0;

        cpuState.H = (byte)((value >> 1) | (carryOut ? 0x80 : 0x00));

        cpuState.F = carryOut ? Flags.Carry : 0;
        if (cpuState.H == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = cpuState.L;
        var carryOut = (value & 0x01) != 0;

        cpuState.L = (byte)((value >> 1) | (carryOut ? 0x80 : 0x00));

        cpuState.F = carryOut ? Flags.Carry : 0;
        if (cpuState.L == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = gb.ReadByte(cpuState.HL);
        var carryOut = (value & 0x01) != 0;

        gb.WriteByte(cpuState.HL, (byte)((value >> 1) | (carryOut ? 0x80 : 0x00)));

        cpuState.F = carryOut ? Flags.Carry : 0;
        if (gb.ReadByte(cpuState.HL) == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = cpuState.A;
        var carryOut = (value & 0x01) != 0;

        cpuState.A = (byte)((value >> 1) | (carryOut ? 0x80 : 0x00));

        cpuState.F = carryOut ? Flags.Carry : 0;
        if (cpuState.A == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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
    /// <param name="cpuState">The CPU state</param>
    /// <param name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int RL_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "RL_B");

        var oldCarry = (cpuState.F & Flags.Carry) != 0 ? 1 : 0;
        var newCarry = (cpuState.B & 0x80) != 0;

        var result = (byte)((cpuState.B << 1) | oldCarry);
        cpuState.B = result;

        Flags flags = 0;
        if (result == 0)
            flags |= Flags.Zero;
        if (newCarry)
            flags |= Flags.Carry;

        cpuState.F = flags;

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

        var oldCarry = (cpuState.F & Flags.Carry) != 0 ? 1 : 0;
        var newCarry = (cpuState.C & 0x80) != 0;

        var result = (byte)((cpuState.C << 1) | oldCarry);
        cpuState.C = result;

        Flags flags = 0;
        if (result == 0)
            flags |= Flags.Zero;
        if (newCarry)
            flags |= Flags.Carry;

        cpuState.F = flags;

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

        var oldCarry = (cpuState.F & Flags.Carry) != 0 ? 1 : 0;
        var newCarry = (cpuState.D & 0x80) != 0;

        var result = (byte)((cpuState.D << 1) | oldCarry);
        cpuState.D = result;

        Flags flags = 0;
        if (result == 0)
            flags |= Flags.Zero;
        if (newCarry)
            flags |= Flags.Carry;

        cpuState.F = flags;

        return 8;
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

        var oldCarry = (cpuState.F & Flags.Carry) != 0 ? 1 : 0;
        var newCarry = (cpuState.E & 0x80) != 0;

        var result = (byte)((cpuState.E << 1) | oldCarry);
        cpuState.E = result;

        Flags flags = 0;
        if (result == 0)
            flags |= Flags.Zero;
        if (newCarry)
            flags |= Flags.Carry;

        cpuState.F = flags;

        return 8;
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

        var oldCarry = (cpuState.F & Flags.Carry) != 0 ? 1 : 0;
        var newCarry = (cpuState.H & 0x80) != 0;

        var result = (byte)((cpuState.H << 1) | oldCarry);
        cpuState.H = result;

        Flags flags = 0;
        if (result == 0)
            flags |= Flags.Zero;
        if (newCarry)
            flags |= Flags.Carry;

        cpuState.F = flags;

        return 8;
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

        var oldCarry = (cpuState.F & Flags.Carry) != 0 ? 1 : 0;
        var newCarry = (cpuState.L & 0x80) != 0;

        var result = (byte)((cpuState.L << 1) | oldCarry);
        cpuState.L = result;

        Flags flags = 0;
        if (result == 0)
            flags |= Flags.Zero;
        if (newCarry)
            flags |= Flags.Carry;

        cpuState.F = flags;

        return 8;
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

        var oldCarry = (cpuState.F & Flags.Carry) != 0 ? 1 : 0;
        var newCarry = (gb.ReadByte(cpuState.HL) & 0x80) != 0;

        var result = (byte)((gb.ReadByte(cpuState.HL) << 1) | oldCarry);
        gb.WriteByte(cpuState.HL, result);

        Flags flags = 0;
        if (result == 0)
            flags |= Flags.Zero;
        if (newCarry)
            flags |= Flags.Carry;

        cpuState.F = flags;

        return 8;
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

        var oldCarry = (cpuState.F & Flags.Carry) != 0 ? 1 : 0;
        var newCarry = (cpuState.A & 0x80) != 0;

        var result = (byte)((cpuState.A << 1) | oldCarry);
        cpuState.A = result;

        Flags flags = 0;
        if (result == 0)
            flags |= Flags.Zero;
        if (newCarry)
            flags |= Flags.Carry;

        cpuState.F = flags;

        return 8;
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

        var value = cpuState.B;
        var oldCarry = (cpuState.F & Flags.Carry) != 0;
        var newCarry = (value & 0x01) != 0;

        cpuState.B = (byte)((value >> 1) | (oldCarry ? 0x80 : 0x00));

        cpuState.F = 0;
        if (cpuState.B == 0)
            cpuState.F |= Flags.Zero;

        if (newCarry)
            cpuState.F |= Flags.Carry;

        return 8;
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

        var value = cpuState.C;
        var oldCarry = (cpuState.F & Flags.Carry) != 0;
        var newCarry = (value & 0x01) != 0;

        cpuState.C = (byte)((value >> 1) | (oldCarry ? 0x80 : 0x00));

        cpuState.F = 0;
        if (cpuState.C == 0)
            cpuState.F |= Flags.Zero;

        if (newCarry)
            cpuState.F |= Flags.Carry;

        return 8;
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

        var value = cpuState.D;
        var oldCarry = (cpuState.F & Flags.Carry) != 0;
        var newCarry = (value & 0x01) != 0;

        cpuState.D = (byte)((value >> 1) | (oldCarry ? 0x80 : 0x00));

        cpuState.F = 0;
        if (cpuState.D == 0)
            cpuState.F |= Flags.Zero;

        if (newCarry)
            cpuState.F |= Flags.Carry;

        return 8;
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

        var value = cpuState.E;
        var oldCarry = (cpuState.F & Flags.Carry) != 0;
        var newCarry = (value & 0x01) != 0;

        cpuState.E = (byte)((value >> 1) | (oldCarry ? 0x80 : 0x00));

        cpuState.F = 0;
        if (cpuState.E == 0)
            cpuState.F |= Flags.Zero;

        if (newCarry)
            cpuState.F |= Flags.Carry;

        return 8;
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

        var value = cpuState.H;
        var oldCarry = (cpuState.F & Flags.Carry) != 0;
        var newCarry = (value & 0x01) != 0;

        cpuState.H = (byte)((value >> 1) | (oldCarry ? 0x80 : 0x00));

        cpuState.F = 0;
        if (cpuState.H == 0)
            cpuState.F |= Flags.Zero;

        if (newCarry)
            cpuState.F |= Flags.Carry;

        return 8;
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

        var value = cpuState.L;
        var oldCarry = (cpuState.F & Flags.Carry) != 0;
        var newCarry = (value & 0x01) != 0;

        cpuState.L = (byte)((value >> 1) | (oldCarry ? 0x80 : 0x00));

        cpuState.F = 0;
        if (cpuState.L == 0)
            cpuState.F |= Flags.Zero;

        if (newCarry)
            cpuState.F |= Flags.Carry;

        return 8;
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

        var value = gb.ReadByte(cpuState.HL);
        var oldCarry = (cpuState.F & Flags.Carry) != 0;
        var newCarry = (value & 0x01) != 0;

        gb.WriteByte(cpuState.HL, (byte)((value >> 1) | (oldCarry ? 0x80 : 0x00)));

        cpuState.F = 0;
        if (gb.ReadByte(cpuState.HL) == 0)
            cpuState.F |= Flags.Zero;

        if (newCarry)
            cpuState.F |= Flags.Carry;

        return 8;
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

        var value = cpuState.A;
        var oldCarry = (cpuState.F & Flags.Carry) != 0;
        var newCarry = (value & 0x01) != 0;

        cpuState.A = (byte)((value >> 1) | (oldCarry ? 0x80 : 0x00));

        cpuState.F = 0;
        if (cpuState.A == 0)
            cpuState.F |= Flags.Zero;

        if (newCarry)
            cpuState.F |= Flags.Carry;

        return 8;
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

        var value = cpuState.B;
        var carryOut = (value & 0x80) != 0;

        cpuState.B = (byte)(value << 1);

        cpuState.F = carryOut ? Flags.Carry : 0;
        if (cpuState.B == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = cpuState.C;
        var carryOut = (value & 0x80) != 0;

        cpuState.C = (byte)(value << 1);

        cpuState.F = carryOut ? Flags.Carry : 0;
        if (cpuState.C == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = cpuState.D;
        var carryOut = (value & 0x80) != 0;

        cpuState.D = (byte)(value << 1);

        cpuState.F = carryOut ? Flags.Carry : 0;
        if (cpuState.D == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = cpuState.E;
        var carryOut = (value & 0x80) != 0;

        cpuState.E = (byte)(value << 1);

        cpuState.F = carryOut ? Flags.Carry : 0;
        if (cpuState.E == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = cpuState.H;
        var carryOut = (value & 0x80) != 0;

        cpuState.H = (byte)(value << 1);

        cpuState.F = carryOut ? Flags.Carry : 0;
        if (cpuState.H == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = cpuState.L;
        var carryOut = (value & 0x80) != 0;

        cpuState.L = (byte)(value << 1);

        cpuState.F = carryOut ? Flags.Carry : 0;
        if (cpuState.L == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = gb.ReadByte(cpuState.HL);
        var carryOut = (value & 0x80) != 0;

        gb.WriteByte(cpuState.HL, (byte)(value << 1));

        cpuState.F = carryOut ? Flags.Carry : 0;
        if (gb.ReadByte(cpuState.HL) == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = cpuState.A;
        var carryOut = (value & 0x80) != 0;

        cpuState.A = (byte)(value << 1);

        cpuState.F = carryOut ? Flags.Carry : 0;
        if (cpuState.A == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = cpuState.B;
        var carryOut = (value & 0x01) != 0;
        var signBit = (value & 0x80) != 0;

        cpuState.B = (byte)((value >> 1) | (signBit ? 0x80 : 0x00));

        cpuState.F = carryOut ? Flags.Carry : 0;
        if (cpuState.B == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = cpuState.C;
        var carryOut = (value & 0x01) != 0;
        var signBit = (value & 0x80) != 0;

        cpuState.C = (byte)((value >> 1) | (signBit ? 0x80 : 0x00));

        cpuState.F = carryOut ? Flags.Carry : 0;
        if (cpuState.C == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = cpuState.D;
        var carryOut = (value & 0x01) != 0;
        var signBit = (value & 0x80) != 0;

        cpuState.D = (byte)((value >> 1) | (signBit ? 0x80 : 0x00));

        cpuState.F = carryOut ? Flags.Carry : 0;
        if (cpuState.D == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = cpuState.E;
        var carryOut = (value & 0x01) != 0;
        var signBit = (value & 0x80) != 0;

        cpuState.E = (byte)((value >> 1) | (signBit ? 0x80 : 0x00));

        cpuState.F = carryOut ? Flags.Carry : 0;
        if (cpuState.E == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = cpuState.H;
        var carryOut = (value & 0x01) != 0;
        var signBit = (value & 0x80) != 0;

        cpuState.H = (byte)((value >> 1) | (signBit ? 0x80 : 0x00));

        cpuState.F = carryOut ? Flags.Carry : 0;
        if (cpuState.H == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = cpuState.L;
        var carryOut = (value & 0x01) != 0;
        var signBit = (value & 0x80) != 0;

        cpuState.L = (byte)((value >> 1) | (signBit ? 0x80 : 0x00));

        cpuState.F = carryOut ? Flags.Carry : 0;
        if (cpuState.L == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = gb.ReadByte(cpuState.HL);
        var carryOut = (value & 0x01) != 0;
        var signBit = (value & 0x80) != 0;

        gb.WriteByte(cpuState.HL, (byte)((value >> 1) | (signBit ? 0x80 : 0x00)));

        cpuState.F = carryOut ? Flags.Carry : 0;
        if (gb.ReadByte(cpuState.HL) == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = cpuState.A;
        var carryOut = (value & 0x01) != 0;
        var signBit = (value & 0x80) != 0;

        cpuState.A = (byte)((value >> 1) | (signBit ? 0x80 : 0x00));

        cpuState.F = carryOut ? Flags.Carry : 0;
        if (cpuState.A == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        cpuState.F = 0;

        cpuState.B = (byte)((cpuState.B >> 4) | (cpuState.B << 4));

        if (cpuState.B == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        cpuState.F = 0;

        cpuState.C = (byte)((cpuState.C >> 4) | (cpuState.C << 4));

        if (cpuState.C == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        cpuState.F = 0;

        cpuState.D = (byte)((cpuState.D >> 4) | (cpuState.D << 4));

        if (cpuState.D == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        cpuState.F = 0;

        cpuState.E = (byte)((cpuState.E >> 4) | (cpuState.E << 4));

        if (cpuState.E == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        cpuState.F = 0;

        cpuState.H = (byte)((cpuState.H >> 4) | (cpuState.H << 4));

        if (cpuState.H == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        cpuState.F = 0;

        cpuState.L = (byte)((cpuState.L >> 4) | (cpuState.L << 4));

        if (cpuState.L == 0)
            cpuState.F |= Flags.Zero;

        return 8;
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

        var value = gb.ReadByte(cpuState.HL);

        cpuState.F = 0;

        gb.WriteByte(cpuState.HL, (byte)((value >> 4) | (value << 4)));

        if (gb.ReadByte(cpuState.HL) == 0)
            cpuState.F |= Flags.Zero;

        return 16;
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

        var value = cpuState.B;
        var carry = (value & 0x01) != 0;

        cpuState.B = (byte)(value >> 1);

        cpuState.F = 0;
        if (cpuState.B == 0)
            cpuState.F |= Flags.Zero;

        if (carry)
            cpuState.F |= Flags.Carry;

        return 8;
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

        var value = cpuState.C;
        var carry = (value & 0x01) != 0;

        cpuState.C = (byte)(value >> 1);

        cpuState.F = 0;
        if (cpuState.C == 0)
            cpuState.F |= Flags.Zero;

        if (carry)
            cpuState.F |= Flags.Carry;

        return 8;
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

        var value = cpuState.D;
        var carry = (value & 0x01) != 0;

        cpuState.D = (byte)(value >> 1);

        cpuState.F = 0;
        if (cpuState.D == 0)
            cpuState.F |= Flags.Zero;

        if (carry)
            cpuState.F |= Flags.Carry;

        return 8;
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

        var value = cpuState.E;
        var carry = (value & 0x01) != 0;

        cpuState.E = (byte)(value >> 1);

        cpuState.F = 0;
        if (cpuState.E == 0)
            cpuState.F |= Flags.Zero;

        if (carry)
            cpuState.F |= Flags.Carry;

        return 8;
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

        var value = cpuState.H;
        var carry = (value & 0x01) != 0;

        cpuState.H = (byte)(value >> 1);

        cpuState.F = 0;
        if (cpuState.H == 0)
            cpuState.F |= Flags.Zero;

        if (carry)
            cpuState.F |= Flags.Carry;

        return 8;
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

        var value = cpuState.L;
        var carry = (value & 0x01) != 0;

        cpuState.L = (byte)(value >> 1);

        cpuState.F = 0;
        if (cpuState.L == 0)
            cpuState.F |= Flags.Zero;

        if (carry)
            cpuState.F |= Flags.Carry;

        return 8;
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

        var value = gb.ReadByte(cpuState.HL);
        var carry = (value & 0x01) != 0;

        gb.WriteByte(cpuState.HL, (byte)(value >> 1));

        cpuState.F = 0;
        if (gb.ReadByte(cpuState.HL) == 0)
            cpuState.F |= Flags.Zero;

        if (carry)
            cpuState.F |= Flags.Carry;

        return 16;
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

        var value = cpuState.A;
        var carry = (value & 0x01) != 0;

        cpuState.A = (byte)(value >> 1);

        cpuState.F = 0;
        if (cpuState.A == 0)
            cpuState.F |= Flags.Zero;

        if (carry)
            cpuState.F |= Flags.Carry;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.B & 0b00000001) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.C & 0b00000001) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.D & 0b00000001) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.E & 0b00000001) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.H & 0b00000001) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.L & 0b00000001) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((gb.ReadByte(cpuState.HL) & 0b00000001) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 12;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.A & 0b00000001) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.B & 0b00000010) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.C & 0b00000010) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.D & 0b00000010) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.E & 0b00000010) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.H & 0b00000010) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.L & 0b00000010) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((gb.ReadByte(cpuState.HL) & 0b00000010) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 12;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.A & 0b00000010) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.B & 0b00000100) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.C & 0b00000100) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.D & 0b00000100) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.E & 0b00000100) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.H & 0b00000100) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.L & 0b00000100) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((gb.ReadByte(cpuState.HL) & 0b00000100) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 12;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.A & 0b00000100) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.B & 0b00001000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.C & 0b00001000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.D & 0b00001000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.E & 0b00001000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.H & 0b00001000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.L & 0b00001000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((gb.ReadByte(cpuState.HL) & 0b00001000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 12;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.A & 0b00001000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.B & 0b00010000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.C & 0b00010000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.D & 0b00010000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.E & 0b00010000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.H & 0b00010000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.L & 0b00010000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((gb.ReadByte(cpuState.HL) & 0b00010000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 12;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.A & 0b00010000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.B & 0b00100000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.C & 0b00100000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.D & 0b00100000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.E & 0b00100000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.H & 0b00100000) == 0)
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.L & 0b00100000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((gb.ReadByte(cpuState.HL) & 0b00100000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 12;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.A & 0b00100000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.B & 0b01000000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.C & 0b01000000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.D & 0b01000000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.E & 0b01000000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.H & 0b01000000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.L & 0b01000000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((gb.ReadByte(cpuState.HL) & 0b01000000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 12;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.A & 0b01000000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.B & 0b10000000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.C & 0b10000000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.D & 0b10000000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.E & 0b10000000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.H & 0b10000000) == 0)
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.L & 0b10000000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((gb.ReadByte(cpuState.HL) & 0b10000000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 12;
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

        cpuState.F &= ~Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        if ((cpuState.A & 0b10000000) == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 8;
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

        cpuState.B &= 0b11111110;

        return 8;
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

        cpuState.C &= 0b11111110;

        return 8;
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

        cpuState.D &= 0b11111110;

        return 8;
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

        cpuState.E &= 0b11111110;

        return 8;
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

        cpuState.H &= 0b11111110;

        return 8;
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

        cpuState.L &= 0b11111110;

        return 8;
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

        gb[cpuState.HL] &= 0b11111110;

        return 16;
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

        cpuState.A &= 0b11111110;

        return 8;
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

        cpuState.B &= 0b11111101;

        return 8;
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

        cpuState.C &= 0b11111101;

        return 8;
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

        cpuState.D &= 0b11111101;

        return 8;
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

        cpuState.E &= 0b11111101;

        return 8;
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

        cpuState.H &= 0b11111101;

        return 8;
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

        cpuState.L &= 0b11111101;

        return 8;
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

        gb[cpuState.HL] &= 0b11111101;

        return 16;
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

        cpuState.A &= 0b11111101;

        return 8;
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

        cpuState.B &= 0b11111011;

        return 8;
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

        cpuState.C &= 0b11111011;

        return 8;
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

        cpuState.D &= 0b11111011;

        return 8;
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

        cpuState.E &= 0b11111011;

        return 8;
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

        cpuState.H &= 0b11111011;

        return 8;
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

        cpuState.L &= 0b11111011;

        return 8;
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

        gb[cpuState.HL] &= 0b11111011;

        return 16;
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

        cpuState.A &= 0b11111011;

        return 8;
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

        cpuState.B &= 0b11110111;

        return 8;
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

        cpuState.C &= 0b11110111;

        return 8;
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

        cpuState.D &= 0b11110111;

        return 8;
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

        cpuState.E &= 0b11110111;

        return 8;
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

        cpuState.H &= 0b11110111;

        return 8;
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

        cpuState.L &= 0b11110111;

        return 8;
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

        gb[cpuState.HL] &= 0b11110111;

        return 16;
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

        cpuState.A &= 0b11110111;

        return 8;
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

        cpuState.B &= 0b11101111;

        return 8;
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

        cpuState.C &= 0b11101111;

        return 8;
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

        cpuState.D &= 0b11101111;

        return 8;
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

        cpuState.E &= 0b11101111;

        return 8;
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

        cpuState.H &= 0b11101111;

        return 8;
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

        cpuState.L &= 0b11101111;

        return 8;
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

        gb[cpuState.HL] &= 0b11101111;

        return 16;
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

        cpuState.A &= 0b11101111;

        return 8;
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

        cpuState.B &= 0b11011111;

        return 8;
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

        cpuState.C &= 0b11011111;

        return 8;
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

        cpuState.D &= 0b11011111;

        return 8;
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

        cpuState.E &= 0b11011111;

        return 8;
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

        cpuState.H &= 0b11011111;

        return 8;
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

        cpuState.L &= 0b11011111;

        return 8;
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

        gb[cpuState.HL] &= 0b11011111;

        return 16;
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

        cpuState.A &= 0b11011111;

        return 8;
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

        cpuState.B &= 0b10111111;

        return 8;
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

        cpuState.C &= 0b10111111;

        return 8;
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

        cpuState.D &= 0b10111111;

        return 8;
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

        cpuState.E &= 0b10111111;

        return 8;
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

        cpuState.H &= 0b10111111;

        return 8;
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

        cpuState.L &= 0b10111111;

        return 8;
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

        gb[cpuState.HL] &= 0b10111111;

        return 16;
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

        cpuState.A &= 0b10111111;

        return 8;
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

        cpuState.B &= 0b01111111;

        return 8;
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

        cpuState.C &= 0b01111111;

        return 8;
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

        cpuState.D &= 0b01111111;

        return 8;
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

        cpuState.E &= 0b01111111;

        return 8;
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

        cpuState.H &= 0b01111111;

        return 8;
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

        cpuState.L &= 0b01111111;

        return 8;
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

        gb[cpuState.HL] &= 0b01111111;

        return 16;
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

        cpuState.A &= 0b01111111;

        return 8;
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

        cpuState.B |= 0b00000001;

        return 8;
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

        cpuState.C |= 0b00000001;

        return 8;
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

        cpuState.D |= 0b00000001;

        return 8;
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

        cpuState.E |= 0b00000001;

        return 8;
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

        cpuState.H |= 0b00000001;

        return 8;
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

        cpuState.L |= 0b00000001;

        return 8;
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

        gb[cpuState.HL] |= 0b00000001;

        return 16;
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

        cpuState.A |= 0b00000001;

        return 8;
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

        cpuState.B |= 0b00000010;

        return 8;
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

        cpuState.C |= 0b00000010;

        return 8;
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

        cpuState.D |= 0b00000010;

        return 8;
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

        cpuState.E |= 0b00000010;

        return 8;
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

        cpuState.H |= 0b00000010;

        return 8;
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

        cpuState.L |= 0b00000010;

        return 8;
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

        gb[cpuState.HL] |= 0b00000010;

        return 16;
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

        cpuState.A |= 0b00000010;

        return 8;
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

        cpuState.B |= 0b00000100;

        return 8;
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

        cpuState.C |= 0b00000100;

        return 8;
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

        cpuState.D |= 0b00000100;

        return 8;
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

        cpuState.E |= 0b00000100;

        return 8;
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

        cpuState.H |= 0b00000100;

        return 8;
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

        cpuState.L |= 0b00000100;

        return 8;
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

        gb[cpuState.HL] |= 0b00000100;

        return 16;
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

        cpuState.A |= 0b00000100;

        return 8;
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

        cpuState.B |= 0b00001000;

        return 8;
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

        cpuState.C |= 0b00001000;

        return 8;
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

        cpuState.D |= 0b00001000;

        return 8;
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

        cpuState.E |= 0b00001000;

        return 8;
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

        cpuState.H |= 0b00001000;

        return 8;
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

        cpuState.L |= 0b00001000;

        return 8;
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

        gb[cpuState.HL] |= 0b00001000;

        return 16;
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

        cpuState.A |= 0b00001000;

        return 8;
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

        cpuState.B |= 0b00010000;

        return 8;
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

        cpuState.C |= 0b00010000;

        return 8;
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

        cpuState.D |= 0b00010000;

        return 8;
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

        cpuState.E |= 0b00010000;

        return 8;
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

        cpuState.H |= 0b00010000;

        return 8;
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

        cpuState.L |= 0b00010000;

        return 8;
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

        gb[cpuState.HL] |= 0b00010000;

        return 16;
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

        cpuState.A |= 0b00010000;

        return 8;
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

        cpuState.B |= 0b00100000;

        return 8;
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

        cpuState.C |= 0b00100000;

        return 8;
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

        cpuState.D |= 0b00100000;

        return 8;
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

        cpuState.E |= 0b00100000;

        return 8;
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

        cpuState.H |= 0b00100000;

        return 8;
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

        cpuState.L |= 0b00100000;

        return 8;
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

        gb[cpuState.HL] |= 0b00100000;

        return 16;
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

        cpuState.A |= 0b00100000;

        return 8;
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

        cpuState.B |= 0b01000000;

        return 8;
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

        cpuState.C |= 0b01000000;

        return 8;
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

        cpuState.D |= 0b01000000;

        return 8;
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

        cpuState.E |= 0b01000000;

        return 8;
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

        cpuState.H |= 0b01000000;

        return 8;
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

        cpuState.L |= 0b01000000;

        return 8;
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

        gb[cpuState.HL] |= 0b01000000;

        return 16;
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

        cpuState.A |= 0b01000000;

        return 8;
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

        cpuState.B |= 0b10000000;

        return 8;
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

        cpuState.C |= 0b10000000;

        return 8;
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

        cpuState.D |= 0b10000000;

        return 8;
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

        cpuState.E |= 0b10000000;

        return 8;
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

        cpuState.H |= 0b10000000;

        return 8;
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

        cpuState.L |= 0b10000000;

        return 8;
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

        gb[cpuState.HL] |= 0b10000000;

        return 16;
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

        cpuState.A |= 0b10000000;

        return 8;
    }
}