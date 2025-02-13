// ReSharper disable once CheckNamespace

namespace gb.CPU;

public static partial class Executioner
{
    /// <summary>
    ///     0x03 INC - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: BC<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int INC_BC(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "INC_BC");

        cpuState.BC++;

        return 8;
    }

    /// <summary>
    ///     0x04 INC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=H, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int INC_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "INC_B");

        if ((cpuState.B & 0x0F) == 0x0F)
            cpuState.F |= Flags.HalfCarry;
        else
            cpuState.F &= ~Flags.HalfCarry;

        cpuState.B++;

        cpuState.F &= ~Flags.Negative;

        if (cpuState.B == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 4;
    }

    /// <summary>
    ///     0x05 DEC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int DEC_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "DEC_B");

        if ((cpuState.B & 0x0F) == 0)
            cpuState.F |= Flags.HalfCarry;
        else
            cpuState.F &= ~Flags.HalfCarry;

        cpuState.B--;

        cpuState.F |= Flags.Negative;

        if (cpuState.B == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 4;
    }

    /// <summary>
    ///     0x09 ADD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: HL, BC<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=0, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int ADD_HL_BC(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "ADD_HL_BC");

        throw new NotImplementedException("ADD_HL_BC");
    }

    /// <summary>
    ///     0x0B DEC - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: BC<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int DEC_BC(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "DEC_BC");

        cpuState.BC--;

        return 8;
    }

    /// <summary>
    ///     0x0C INC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=H, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int INC_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "INC_C");

        if ((cpuState.C & 0x0F) == 0x0F)
            cpuState.F |= Flags.HalfCarry;
        else
            cpuState.F &= ~Flags.HalfCarry;

        cpuState.C++;

        cpuState.F &= ~Flags.Negative;

        if (cpuState.C == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 4;
    }

    /// <summary>
    ///     0x0D DEC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int DEC_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "DEC_C");

        if ((cpuState.C & 0x0F) == 0)
            cpuState.F |= Flags.HalfCarry;
        else
            cpuState.F &= ~Flags.HalfCarry;

        cpuState.C--;

        cpuState.F |= Flags.Negative;

        if (cpuState.C == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 4;
    }

    /// <summary>
    ///     0x13 INC - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: DE<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int INC_DE(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "INC_DE");

        cpuState.DE++;

        return 8;
    }

    /// <summary>
    ///     0x14 INC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=H, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int INC_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "INC_D");

        if ((cpuState.D & 0x0F) == 0x0F)
            cpuState.F |= Flags.HalfCarry;
        else
            cpuState.F &= ~Flags.HalfCarry;

        cpuState.D++;

        cpuState.F &= ~Flags.Negative;

        if (cpuState.D == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 4;
    }

    /// <summary>
    ///     0x15 DEC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int DEC_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "DEC_D");

        if ((cpuState.D & 0x0F) == 0)
            cpuState.F |= Flags.HalfCarry;
        else
            cpuState.F &= ~Flags.HalfCarry;

        cpuState.D--;

        cpuState.F |= Flags.Negative;

        if (cpuState.D == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 4;
    }

    /// <summary>
    ///     0x19 ADD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: HL, DE<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=0, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int ADD_HL_DE(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "ADD_HL_DE");

        cpuState.F &= ~Flags.Negative;

        if ((cpuState.HL & 0x0FFF) + (cpuState.DE & 0x0FFF) > 0x0FFF)
            cpuState.F |= Flags.HalfCarry;
        else
            cpuState.F &= ~Flags.HalfCarry;

        if (cpuState.HL + cpuState.DE > 0xFFFF)
        {
            cpuState.F |= Flags.Carry;
            cpuState.HL = (ushort)(cpuState.HL + cpuState.DE - 0x10000);
        }
        else
        {
            cpuState.F &= ~Flags.Carry;
            cpuState.HL += cpuState.DE;
        }

        return 8;
    }

    /// <summary>
    ///     0x1B DEC - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: DE<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int DEC_DE(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "DEC_DE");

        throw new NotImplementedException("DEC_DE");
    }

    /// <summary>
    ///     0x1C INC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=H, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int INC_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "INC_E");

        if ((cpuState.E & 0x0F) == 0x0F)
            cpuState.F |= Flags.HalfCarry;
        else
            cpuState.F &= ~Flags.HalfCarry;

        cpuState.E++;

        cpuState.F &= ~Flags.Negative;

        if (cpuState.E == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 4;
    }

    /// <summary>
    ///     0x1D DEC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int DEC_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "DEC_E");

        if ((cpuState.E & 0x0F) == 0)
            cpuState.F |= Flags.HalfCarry;
        else
            cpuState.F &= ~Flags.HalfCarry;

        cpuState.E--;

        cpuState.F |= Flags.Negative;

        if (cpuState.E == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 4;
    }

    /// <summary>
    ///     0x23 INC - 8 cycles
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
    internal static int INC_HL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "INC_HL");

        cpuState.HL++;

        return 8;
    }

    /// <summary>
    ///     0x24 INC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=H, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int INC_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "INC_H");

        if ((cpuState.H & 0x0F) == 0x0F)
            cpuState.F |= Flags.HalfCarry;
        else
            cpuState.F &= ~Flags.HalfCarry;

        cpuState.H++;

        cpuState.F &= ~Flags.Negative;

        if (cpuState.H == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 4;
    }

    /// <summary>
    ///     0x25 DEC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int DEC_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "DEC_H");

        if ((cpuState.H & 0x0F) == 0)
            cpuState.F |= Flags.HalfCarry;
        else
            cpuState.F &= ~Flags.HalfCarry;

        cpuState.H--;

        cpuState.F |= Flags.Negative;

        if (cpuState.H == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 4;
    }

    /// <summary>
    ///     0x27 DAA - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: <br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=-, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int DAA(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "DAA");

        throw new NotImplementedException("DAA");
    }

    /// <summary>
    ///     0x29 ADD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: HL, HL<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=0, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int ADD_HL_HL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "ADD_HL_HL");

        cpuState.F &= ~Flags.Negative;

        if ((cpuState.HL & 0x0FFF) + (cpuState.HL & 0x0FFF) > 0x0FFF)
            cpuState.F |= Flags.HalfCarry;
        else
            cpuState.F &= ~Flags.HalfCarry;

        if (cpuState.HL + cpuState.HL > 0xFFFF)
        {
            cpuState.F |= Flags.Carry;
            cpuState.HL = (ushort)(cpuState.HL + cpuState.HL - 0x10000);
        }
        else
        {
            cpuState.F &= ~Flags.Carry;
            cpuState.HL += cpuState.HL;
        }

        return 8;
    }

    /// <summary>
    ///     0x2B DEC - 8 cycles
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
    internal static int DEC_HL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "DEC_HL");

        throw new NotImplementedException("DEC_HL");
    }

    /// <summary>
    ///     0x2C INC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=H, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int INC_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "INC_L");

        if ((cpuState.L & 0x0F) == 0x0F)
            cpuState.F |= Flags.HalfCarry;
        else
            cpuState.F &= ~Flags.HalfCarry;

        cpuState.L++;

        cpuState.F &= ~Flags.Negative;

        if (cpuState.L == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 4;
    }

    /// <summary>
    ///     0x2D DEC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int DEC_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "DEC_L");

        if ((cpuState.L & 0x0F) == 0)
            cpuState.F |= Flags.HalfCarry;
        else
            cpuState.F &= ~Flags.HalfCarry;

        cpuState.L--;

        cpuState.F |= Flags.Negative;

        if (cpuState.L == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 4;
    }

    /// <summary>
    ///     0x2F CPL - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: <br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=1, H=1, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int CPL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "CPL");

        cpuState.F |= Flags.Negative;
        cpuState.F |= Flags.HalfCarry;

        cpuState.A = (byte)~cpuState.A;

        return 4;
    }

    /// <summary>
    ///     0x33 INC - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: SP<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int INC_SP(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "INC_SP");

        cpuState.SP++;

        return 8;
    }

    /// <summary>
    ///     0x34 INC - 12 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: [HL]<br />
    ///         Flags: Z=Z, N=0, H=H, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int INC_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "INC_iHL");

        var value = gb.ReadByte(cpuState.HL);

        if ((value & 0x0F) == 0x0F)
            cpuState.F |= Flags.HalfCarry;
        else
            cpuState.F &= ~Flags.HalfCarry;

        value++;

        cpuState.F &= ~Flags.Negative;

        if (value == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        gb.WriteByte(cpuState.HL, value);

        return 12;
    }

    /// <summary>
    ///     0x35 DEC - 12 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: [HL]<br />
    ///         Flags: Z=Z, N=1, H=H, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int DEC_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "DEC_iHL");

        var address = cpuState.HL;
        var value = gb.ReadByte(address);
        var result = (byte)(value - 1);

        cpuState.F &= Flags.Carry;
        cpuState.F |= Flags.Negative;

        if (result == 0)
            cpuState.F |= Flags.Zero;

        if ((value & 0x0F) == 0)
            cpuState.F |= Flags.HalfCarry;

        gb.WriteByte(address, result);

        return 12;
    }

    /// <summary>
    ///     0x39 ADD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: HL, SP<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=0, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int ADD_HL_SP(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "ADD_HL_SP");

        cpuState.F &= ~Flags.Negative;

        if ((cpuState.HL & 0x0FFF) + (cpuState.SP & 0x0FFF) > 0x0FFF)
            cpuState.F |= Flags.HalfCarry;
        else
            cpuState.F &= ~Flags.HalfCarry;

        if (cpuState.HL + cpuState.SP > 0xFFFF)
        {
            cpuState.F |= Flags.Carry;
            cpuState.HL = (ushort)(cpuState.HL + cpuState.SP - 0x10000);
        }
        else
        {
            cpuState.F &= ~Flags.Carry;
            cpuState.HL += cpuState.SP;
        }

        return 8;
    }

    /// <summary>
    ///     0x3B DEC - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: SP<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int DEC_SP(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "DEC_SP");

        cpuState.SP--;

        return 8;
    }

    /// <summary>
    ///     0x3C INC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=H, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int INC_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "INC_A");

        if ((cpuState.A & 0x0F) == 0x0F)
            cpuState.F |= Flags.HalfCarry;
        else
            cpuState.F &= ~Flags.HalfCarry;

        cpuState.A++;

        cpuState.F &= ~Flags.Negative;

        if (cpuState.A == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 4;
    }

    /// <summary>
    ///     0x3D DEC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int DEC_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "DEC_A");

        if ((cpuState.A & 0x0F) == 0)
            cpuState.F |= Flags.HalfCarry;
        else
            cpuState.F &= ~Flags.HalfCarry;

        cpuState.A--;

        cpuState.F |= Flags.Negative;

        if (cpuState.A == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        return 4;
    }

    /// <summary>
    ///     0x80 ADD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int ADD_A_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "ADD_A_B");

        throw new NotImplementedException("ADD_A_B");
    }

    /// <summary>
    ///     0x81 ADD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int ADD_A_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "ADD_A_C");

        throw new NotImplementedException("ADD_A_C");
    }

    /// <summary>
    ///     0x82 ADD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int ADD_A_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "ADD_A_D");

        throw new NotImplementedException("ADD_A_D");
    }

    /// <summary>
    ///     0x83 ADD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int ADD_A_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "ADD_A_E");

        throw new NotImplementedException("ADD_A_E");
    }

    /// <summary>
    ///     0x84 ADD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int ADD_A_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "ADD_A_H");

        throw new NotImplementedException("ADD_A_H");
    }

    /// <summary>
    ///     0x85 ADD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int ADD_A_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "ADD_A_L");

        throw new NotImplementedException("ADD_A_L");
    }

    /// <summary>
    ///     0x86 ADD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, [HL]<br />
    ///         Flags: Z=Z, N=0, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int ADD_A_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "ADD_A_iHL");

        var value = gb.ReadByte(cpuState.HL);

        var result = (byte)(cpuState.A + value);

        if (result == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        cpuState.F &= ~Flags.Negative;

        if ((cpuState.A & 0xF) + (value & 0xF) > 0xF)
            cpuState.F |= Flags.HalfCarry;
        else
            cpuState.F &= ~Flags.HalfCarry;

        if (result < value)
            cpuState.F |= Flags.Carry;
        else
            cpuState.F &= ~Flags.Carry;

        cpuState.A = result;

        return 8;
    }

    /// <summary>
    ///     0x87 ADD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int ADD_A_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "ADD_A_A");

        var result = (byte)(cpuState.A + cpuState.A);

        if (result == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        cpuState.F &= ~Flags.Negative;

        if ((cpuState.A & 0xF) + (cpuState.A & 0xF) > 0xF)
            cpuState.F |= Flags.HalfCarry;
        else
            cpuState.F &= ~Flags.HalfCarry;

        if (result < cpuState.A)
            cpuState.F |= Flags.Carry;
        else
            cpuState.F &= ~Flags.Carry;

        cpuState.A = result;

        return 4;
    }

    /// <summary>
    ///     0x88 ADC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int ADC_A_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "ADC_A_B");

        throw new NotImplementedException("ADC_A_B");
    }

    /// <summary>
    ///     0x89 ADC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int ADC_A_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "ADC_A_C");

        throw new NotImplementedException("ADC_A_C");
    }

    /// <summary>
    ///     0x8A ADC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int ADC_A_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "ADC_A_D");

        throw new NotImplementedException("ADC_A_D");
    }

    /// <summary>
    ///     0x8B ADC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int ADC_A_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "ADC_A_E");

        throw new NotImplementedException("ADC_A_E");
    }

    /// <summary>
    ///     0x8C ADC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int ADC_A_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "ADC_A_H");

        throw new NotImplementedException("ADC_A_H");
    }

    /// <summary>
    ///     0x8D ADC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int ADC_A_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "ADC_A_L");

        throw new NotImplementedException("ADC_A_L");
    }

    /// <summary>
    ///     0x8E ADC - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, [HL]<br />
    ///         Flags: Z=Z, N=0, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int ADC_A_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "ADC_A_iHL");

        var value = gb.ReadByte(cpuState.HL);

        var carry = (cpuState.F & Flags.Carry) != 0 ? 1 : 0;
        var result = cpuState.A + value + carry;

        cpuState.F = 0;
        if ((result & 0xFF) == 0)
            cpuState.F |= Flags.Zero;

        if ((cpuState.A & 0x0F) + (value & 0x0F) + carry > 0x0F)
            cpuState.F |= Flags.HalfCarry;

        if (result > 0xFF)
            cpuState.F |= Flags.Carry;

        cpuState.A = (byte)result;

        return 8;
    }

    /// <summary>
    ///     0x8F ADC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int ADC_A_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "ADC_A_A");

        throw new NotImplementedException("ADC_A_A");
    }

    /// <summary>
    ///     0x90 SUB - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SUB_A_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SUB_A_B");

        var value = cpuState.B;
        var result = cpuState.A - value;

        // Set flags
        cpuState.F = Flags.Negative; // Subtraction always sets the Negative flag

        if ((result & 0xFF) == 0) // Check if result is zero
            cpuState.F |= Flags.Zero;

        if (cpuState.A < value) // Check if there was a borrow (carry in subtraction)
            cpuState.F |= Flags.Carry;

        if ((cpuState.A & 0x0F) < (value & 0x0F)) // Check for half-carry (borrow from bit 4)
            cpuState.F |= Flags.HalfCarry;

        // Store the result in register A (8-bit wraparound behavior)
        cpuState.A = (byte)result;

        return 4;
    }

    /// <summary>
    ///     0x91 SUB - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SUB_A_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SUB_A_C");

        throw new NotImplementedException("SUB_A_C");
    }

    /// <summary>
    ///     0x92 SUB - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SUB_A_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SUB_A_D");

        throw new NotImplementedException("SUB_A_D");
    }

    /// <summary>
    ///     0x93 SUB - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SUB_A_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SUB_A_E");

        throw new NotImplementedException("SUB_A_E");
    }

    /// <summary>
    ///     0x94 SUB - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SUB_A_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SUB_A_H");

        throw new NotImplementedException("SUB_A_H");
    }

    /// <summary>
    ///     0x95 SUB - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SUB_A_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SUB_A_L");

        throw new NotImplementedException("SUB_A_L");
    }

    /// <summary>
    ///     0x96 SUB - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, [HL]<br />
    ///         Flags: Z=Z, N=1, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SUB_A_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SUB_A_iHL");

        var value = gb.ReadByte(cpuState.HL);
        var result = cpuState.A - value;

        cpuState.F = Flags.Negative;

        if ((result & 0xFF) == 0)
            cpuState.F |= Flags.Zero;

        if (cpuState.A < value)
            cpuState.F |= Flags.Carry;

        if ((cpuState.A & 0x0F) < (value & 0x0F))
            cpuState.F |= Flags.HalfCarry;

        cpuState.A = (byte)result;

        return 8;
    }

    /// <summary>
    ///     0x97 SUB - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=1, N=1, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SUB_A_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SUB_A_A");

        throw new NotImplementedException("SUB_A_A");
    }

    /// <summary>
    ///     0x98 SBC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SBC_A_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SBC_A_B");

        var carry = (cpuState.F & Flags.Carry) != 0 ? 1 : 0;
        var result = cpuState.A - cpuState.B - carry;

        cpuState.F = Flags.Negative;

        if ((result & 0xFF) == 0)
            cpuState.F |= Flags.Zero;

        if ((cpuState.A & 0x0F) - (cpuState.B & 0x0F) - carry < 0)
            cpuState.F |= Flags.HalfCarry;

        if (result < 0)
            cpuState.F |= Flags.Carry;

        cpuState.A = (byte)result;

        return 4;
    }


    /// <summary>
    ///     0x99 SBC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SBC_A_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SBC_A_C");

        var carry = (cpuState.F & Flags.Carry) != 0 ? 1 : 0;
        var result = cpuState.A - cpuState.C - carry;

        cpuState.F = Flags.Negative;

        if ((result & 0xFF) == 0)
            cpuState.F |= Flags.Zero;

        if ((cpuState.A & 0x0F) - (cpuState.C & 0x0F) - carry < 0)
            cpuState.F |= Flags.HalfCarry;

        if (result < 0)
            cpuState.F |= Flags.Carry;

        cpuState.A = (byte)result;

        return 4;
    }

    /// <summary>
    ///     0x9A SBC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SBC_A_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SBC_A_D");

        var carry = (cpuState.F & Flags.Carry) != 0 ? 1 : 0;
        var result = cpuState.A - cpuState.D - carry;

        cpuState.F = Flags.Negative;

        if ((result & 0xFF) == 0)
            cpuState.F |= Flags.Zero;

        if ((cpuState.A & 0x0F) - (cpuState.D & 0x0F) - carry < 0)
            cpuState.F |= Flags.HalfCarry;

        if (result < 0)
            cpuState.F |= Flags.Carry;

        cpuState.A = (byte)result;

        return 4;
    }

    /// <summary>
    ///     0x9B SBC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SBC_A_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SBC_A_E");

        var carry = (cpuState.F & Flags.Carry) != 0 ? 1 : 0;
        var result = cpuState.A - cpuState.E - carry;

        cpuState.F = Flags.Negative;

        if ((result & 0xFF) == 0)
            cpuState.F |= Flags.Zero;

        if ((cpuState.A & 0x0F) - (cpuState.E & 0x0F) - carry < 0)
            cpuState.F |= Flags.HalfCarry;

        if (result < 0)
            cpuState.F |= Flags.Carry;

        cpuState.A = (byte)result;

        return 4;
    }

    /// <summary>
    ///     0x9C SBC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SBC_A_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SBC_A_H");

        var carry = (cpuState.F & Flags.Carry) != 0 ? 1 : 0;
        var result = cpuState.A - cpuState.H - carry;

        cpuState.F = Flags.Negative;

        if ((result & 0xFF) == 0)
            cpuState.F |= Flags.Zero;

        if ((cpuState.A & 0x0F) - (cpuState.H & 0x0F) - carry < 0)
            cpuState.F |= Flags.HalfCarry;

        if (result < 0)
            cpuState.F |= Flags.Carry;

        cpuState.A = (byte)result;

        return 4;
    }

    /// <summary>
    ///     0x9D SBC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SBC_A_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SBC_A_L");

        var carry = (cpuState.F & Flags.Carry) != 0 ? 1 : 0;
        var result = cpuState.A - cpuState.L - carry;

        cpuState.F = Flags.Negative;

        if ((result & 0xFF) == 0)
            cpuState.F |= Flags.Zero;

        if ((cpuState.A & 0x0F) - (cpuState.L & 0x0F) - carry < 0)
            cpuState.F |= Flags.HalfCarry;

        if (result < 0)
            cpuState.F |= Flags.Carry;

        cpuState.A = (byte)result;

        return 4;
    }

    /// <summary>
    ///     0x9E SBC - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, [HL]<br />
    ///         Flags: Z=Z, N=1, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SBC_A_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SBC_A_iHL");

        var value = gb.ReadByte(cpuState.HL);

        var carry = (cpuState.F & Flags.Carry) != 0 ? 1 : 0;
        var result = cpuState.A - value - carry;

        cpuState.F = Flags.Negative;

        if ((result & 0xFF) == 0)
            cpuState.F |= Flags.Zero;

        if ((cpuState.A & 0x0F) - (value & 0x0F) - carry < 0)
            cpuState.F |= Flags.HalfCarry;

        if (result < 0)
            cpuState.F |= Flags.Carry;

        cpuState.A = (byte)result;

        return 8;
    }

    /// <summary>
    ///     0x9F SBC - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SBC_A_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "SBC_A_A");

        throw new NotImplementedException("SBC_A_A");
    }

    /// <summary>
    ///     0xB8 CP - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int CP_A_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "CP_A_B");

        throw new NotImplementedException("CP_A_B");
    }

    /// <summary>
    ///     0xB9 CP - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int CP_A_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "CP_A_C");

        throw new NotImplementedException("CP_A_C");
    }

    /// <summary>
    ///     0xBA CP - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int CP_A_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "CP_A_D");

        throw new NotImplementedException("CP_A_D");
    }

    /// <summary>
    ///     0xBB CP - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int CP_A_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "CP_A_E");

        throw new NotImplementedException("CP_A_E");
    }

    /// <summary>
    ///     0xBC CP - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int CP_A_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "CP_A_H");

        throw new NotImplementedException("CP_A_H");
    }

    /// <summary>
    ///     0xBD CP - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int CP_A_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "CP_A_L");

        throw new NotImplementedException("CP_A_L");
    }

    /// <summary>
    ///     0xBE CP - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, [HL]<br />
    ///         Flags: Z=Z, N=1, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int CP_A_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "CP_A_iHL");

        var value = gb.ReadByte(cpuState.HL);

        if (cpuState.A == value)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        cpuState.F |= Flags.Negative;

        if ((cpuState.A & 0x0F) < (value & 0x0F))
            cpuState.F |= Flags.HalfCarry;
        else
            cpuState.F &= ~Flags.HalfCarry;

        if (cpuState.A < value)
            cpuState.F |= Flags.Carry;
        else
            cpuState.F &= ~Flags.Carry;

        return 8;
    }

    /// <summary>
    ///     0xBF CP - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=1, N=1, H=0, C=0
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int CP_A_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "CP_A_A");

        throw new NotImplementedException("CP_A_A");
    }

    /// <summary>
    ///     0xC6 ADD - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: A, n8<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int ADD_A_n8(CpuState cpuState, IGameBoy gb)
    {
        var n8 = gb.ReadByte(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "ADD_A_n8", n8);

        cpuState.PC++;

        var result = (byte)(cpuState.A + n8);

        if (result == 0)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        cpuState.F &= ~Flags.Negative;

        if ((cpuState.A & 0xF) + (n8 & 0xF) > 0xF)
            cpuState.F |= Flags.HalfCarry;
        else
            cpuState.F &= ~Flags.HalfCarry;

        if (result < n8)
            cpuState.F |= Flags.Carry;
        else
            cpuState.F &= ~Flags.Carry;

        cpuState.A = result;

        return 4;
    }

    /// <summary>
    ///     0xCE ADC - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: A, n8<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=0, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int ADC_A_n8(CpuState cpuState, IGameBoy gb)
    {
        var n8 = gb.ReadByte(cpuState.PC); // Read immediate 8-bit value
        gb.TraceCpuOp(cpuState.PC - 1, "ADC_A_n8", n8);

        cpuState.PC++; // Increment PC to point after the immediate value

        var carry = (cpuState.F & Flags.Carry) != 0 ? 1 : 0;
        var result = cpuState.A + n8 + carry;

        // Set flags
        cpuState.F = 0;
        if ((result & 0xFF) == 0) // If result is zero, set Zero flag
            cpuState.F |= Flags.Zero;

        if ((cpuState.A & 0x0F) + (n8 & 0x0F) + carry > 0x0F) // Half-carry condition
            cpuState.F |= Flags.HalfCarry;

        if (result > 0xFF) // Overflow, set Carry flag
            cpuState.F |= Flags.Carry;

        cpuState.A = (byte)result; // Store result in A (8-bit wrap-around)

        return 8; // This instruction takes 8 cycles
    }

    /// <summary>
    ///     0xD6 SUB - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: A, n8<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SUB_A_n8(CpuState cpuState, IGameBoy gb)
    {
        var n8 = gb.ReadByte(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "SUB_A_n8", n8);

        cpuState.PC++;

        var result = cpuState.A - n8;

        // Set flags
        cpuState.F = Flags.Negative; // Subtraction always sets the Negative flag

        if ((result & 0xFF) == 0) // Check if result is zero
            cpuState.F |= Flags.Zero;

        if (cpuState.A < n8) // Check if there was a borrow (carry in subtraction)
            cpuState.F |= Flags.Carry;

        if ((cpuState.A & 0x0F) < (n8 & 0x0F)) // Check for half-carry (borrow from bit 4)
            cpuState.F |= Flags.HalfCarry;

        // Store the result in register A (8-bit wraparound behavior)
        cpuState.A = (byte)result;

        return 4;
    }

    /// <summary>
    ///     0xDE SBC - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: A, n8<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SBC_A_n8(CpuState cpuState, IGameBoy gb)
    {
        var n8 = gb.ReadByte(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "SBC_A_n8", n8);

        cpuState.PC++;


        throw new NotImplementedException("SBC_A_n8");
    }

    /// <summary>
    ///     0xE8 ADD - 16 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: SP, e8<br />
    ///         Immediate mode<br />
    ///         Flags: Z=0, N=0, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int ADD_SP_e8(CpuState cpuState, IGameBoy gb)
    {
        var e8 = (sbyte)gb.ReadByte(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "ADD_SP_e8", e8);

        cpuState.PC++;

        var sp = cpuState.SP;
        var result = sp + e8;

        cpuState.F = 0;
        if ((sp & 0x0F) + (e8 & 0x0F) > 0x0F)
            cpuState.F |= Flags.HalfCarry;
        if ((sp & 0xFF) + (e8 & 0xFF) > 0xFF)
            cpuState.F |= Flags.Carry;

        cpuState.SP = (ushort)result;

        return 16;
    }

    /// <summary>
    ///     0xFE CP - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: A, n8<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=1, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int CP_A_n8(CpuState cpuState, IGameBoy gb)
    {
        var n8 = gb.ReadByte(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "CP_A_n8", n8);

        cpuState.PC++;

        if (cpuState.A == n8)
            cpuState.F |= Flags.Zero;
        else
            cpuState.F &= ~Flags.Zero;

        cpuState.F |= Flags.Negative;

        if ((cpuState.A & 0x0F) < (n8 & 0x0F))
            cpuState.F |= Flags.HalfCarry;
        else
            cpuState.F &= ~Flags.HalfCarry;

        if (cpuState.A < n8)
            cpuState.F |= Flags.Carry;
        else
            cpuState.F &= ~Flags.Carry;

        return 8;
    }
}