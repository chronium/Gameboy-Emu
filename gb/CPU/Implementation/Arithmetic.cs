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

        throw new NotImplementedException("INC_B");
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

        cpuState.F |= Flags.Subtract;

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

        cpuState.F &= ~Flags.Subtract;

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

        cpuState.F |= Flags.Subtract;

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

        cpuState.F &= ~Flags.Subtract;

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

        cpuState.F |= Flags.Subtract;

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

        cpuState.F &= ~Flags.Subtract;

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

        throw new NotImplementedException("INC_E");
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

        cpuState.F |= Flags.Subtract;

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

        throw new NotImplementedException("INC_H");
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

        throw new NotImplementedException("DEC_H");
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

        throw new NotImplementedException("ADD_HL_HL");
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

        throw new NotImplementedException("INC_L");
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

        throw new NotImplementedException("DEC_L");
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

        cpuState.F |= Flags.Subtract;
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

        throw new NotImplementedException("INC_SP");
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

        throw new NotImplementedException("INC_iHL");
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

        throw new NotImplementedException("DEC_iHL");
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

        throw new NotImplementedException("ADD_HL_SP");
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

        throw new NotImplementedException("DEC_SP");
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

        throw new NotImplementedException("INC_A");
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

        cpuState.F |= Flags.Subtract;

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

        throw new NotImplementedException("ADD_A_iHL");
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

        cpuState.F &= ~Flags.Subtract;

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

        throw new NotImplementedException("ADC_A_iHL");
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

        throw new NotImplementedException("SUB_A_B");
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

        throw new NotImplementedException("SUB_A_iHL");
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

        throw new NotImplementedException("SBC_A_B");
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

        throw new NotImplementedException("SBC_A_C");
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

        throw new NotImplementedException("SBC_A_D");
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

        throw new NotImplementedException("SBC_A_E");
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

        throw new NotImplementedException("SBC_A_H");
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

        throw new NotImplementedException("SBC_A_L");
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

        throw new NotImplementedException("SBC_A_iHL");
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

        throw new NotImplementedException("CP_A_iHL");
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


        throw new NotImplementedException("ADD_A_n8");
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
        var n8 = gb.ReadByte(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "ADC_A_n8", n8);

        cpuState.PC++;


        throw new NotImplementedException("ADC_A_n8");
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


        throw new NotImplementedException("SUB_A_n8");
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


        throw new NotImplementedException("ADD_SP_e8");
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

        cpuState.F |= Flags.Subtract;

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