// ReSharper disable once CheckNamespace

namespace gb.CPU;

public static partial class Executioner
{
    /// <summary>
    ///     0x01 LD - 12 cycles
    ///     <para>
    ///         Bytes: 3<br />
    ///         Operands: BC, n16<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_BC_n16(CpuState cpuState, IGameBoy gb)
    {
        var n16 = gb.ReadUShort(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "LD_BC_n16", n16);

        cpuState.PC += 2;

        cpuState.BC = n16;

        return 12;
    }

    /// <summary>
    ///     0x02 LD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: [BC], A<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_iBC_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_iBC_A");

        gb.WriteByte(cpuState.BC, cpuState.A);

        return 8;
    }

    /// <summary>
    ///     0x06 LD - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: B, n8<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_B_n8(CpuState cpuState, IGameBoy gb)
    {
        var n8 = gb.ReadByte(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "LD_B_n8", n8);

        cpuState.PC++;

        cpuState.B = n8;

        return 8;
    }

    /// <summary>
    ///     0x08 LD - 20 cycles
    ///     <para>
    ///         Bytes: 3<br />
    ///         Operands: [a16], SP<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_ia16_SP(CpuState cpuState, IGameBoy gb)
    {
        var a16 = gb.ReadUShort(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "LD_ia16_SP", a16);

        cpuState.PC += 2;

        gb.WriteUShort(a16, cpuState.SP);

        return 20;
    }

    /// <summary>
    ///     0x0A LD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, [BC]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_A_iBC(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_A_iBC");

        cpuState.A = gb.ReadByte(cpuState.BC);

        return 8;
    }

    /// <summary>
    ///     0x0E LD - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: C, n8<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_C_n8(CpuState cpuState, IGameBoy gb)
    {
        var n8 = gb.ReadByte(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "LD_C_n8", n8);

        cpuState.PC++;

        cpuState.C = n8;

        return 8;
    }

    /// <summary>
    ///     0x11 LD - 12 cycles
    ///     <para>
    ///         Bytes: 3<br />
    ///         Operands: DE, n16<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_DE_n16(CpuState cpuState, IGameBoy gb)
    {
        var n16 = gb.ReadUShort(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "LD_DE_n16", n16);

        cpuState.PC += 2;

        cpuState.DE = n16;

        return 12;
    }

    /// <summary>
    ///     0x12 LD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: [DE], A<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_iDE_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_iDE_A");

        gb.WriteByte(cpuState.DE, cpuState.A);

        return 8;
    }

    /// <summary>
    ///     0x16 LD - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: D, n8<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_D_n8(CpuState cpuState, IGameBoy gb)
    {
        var n8 = gb.ReadByte(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "LD_D_n8", n8);

        cpuState.PC++;

        cpuState.D = n8;

        return 8;
    }

    /// <summary>
    ///     0x1A LD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, [DE]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_A_iDE(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_A_iDE");

        cpuState.A = gb.ReadByte(cpuState.DE);

        return 8;
    }

    /// <summary>
    ///     0x1E LD - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: E, n8<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_E_n8(CpuState cpuState, IGameBoy gb)
    {
        var n8 = gb.ReadByte(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "LD_E_n8", n8);

        cpuState.PC++;

        cpuState.E = n8;

        return 8;
    }

    /// <summary>
    ///     0x21 LD - 12 cycles
    ///     <para>
    ///         Bytes: 3<br />
    ///         Operands: HL, n16<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_HL_n16(CpuState cpuState, IGameBoy gb)
    {
        var n16 = gb.ReadUShort(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "LD_HL_n16", n16);

        cpuState.PC += 2;

        cpuState.HL = n16;

        return 12;
    }

    /// <summary>
    ///     0x22 LD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: [HLI], A<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_iHLI_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_iHLI_A");

        gb.WriteByte(cpuState.HL++, cpuState.A);

        return 8;
    }

    /// <summary>
    ///     0x26 LD - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: H, n8<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_H_n8(CpuState cpuState, IGameBoy gb)
    {
        var n8 = gb.ReadByte(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "LD_H_n8", n8);

        cpuState.PC++;

        cpuState.H = n8;

        return 8;
    }

    /// <summary>
    ///     0x2A LD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, [HLI]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_A_iHLI(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_A_iHLI");

        cpuState.A = gb.ReadByte(cpuState.HL++);

        return 8;
    }

    /// <summary>
    ///     0x2E LD - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: L, n8<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_L_n8(CpuState cpuState, IGameBoy gb)
    {
        var n8 = gb.ReadByte(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "LD_L_n8", n8);

        cpuState.PC++;

        cpuState.L = n8;

        return 8;
    }

    /// <summary>
    ///     0x31 LD - 12 cycles
    ///     <para>
    ///         Bytes: 3<br />
    ///         Operands: SP, n16<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_SP_n16(CpuState cpuState, IGameBoy gb)
    {
        var n16 = gb.ReadUShort(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "LD_SP_n16", n16);

        cpuState.PC += 2;

        cpuState.SP = n16;

        return 12;
    }

    /// <summary>
    ///     0x32 LD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: [HLD], A<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_iHLD_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_iHLD_A");

        gb.WriteByte(cpuState.HL--, cpuState.A);

        return 8;
    }

    /// <summary>
    ///     0x36 LD - 12 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: [HL], n8<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_iHL_n8(CpuState cpuState, IGameBoy gb)
    {
        var n8 = gb.ReadByte(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "LD_iHL_n8", n8);

        cpuState.PC++;

        gb.WriteByte(cpuState.HL, n8);

        return 12;
    }

    /// <summary>
    ///     0x3A LD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, [HLD]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_A_iHLD(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_A_iHLD");

        cpuState.A = gb.ReadByte(cpuState.HL--);

        return 8;
    }

    /// <summary>
    ///     0x3E LD - 8 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: A, n8<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_A_n8(CpuState cpuState, IGameBoy gb)
    {
        var n8 = gb.ReadByte(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "LD_A_n8", n8);

        cpuState.PC++;

        cpuState.A = n8;

        return 8;
    }

    /// <summary>
    ///     0x40 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: B, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_B_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_B_B");

        // TODO: tf
        cpuState.B = cpuState.B;

        return 4;
    }

    /// <summary>
    ///     0x41 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: B, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_B_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_B_C");

        cpuState.B = cpuState.C;

        return 4;
    }

    /// <summary>
    ///     0x42 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: B, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_B_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_B_D");

        cpuState.B = cpuState.D;

        return 4;
    }

    /// <summary>
    ///     0x43 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: B, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_B_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_B_E");

        cpuState.B = cpuState.E;

        return 4;
    }

    /// <summary>
    ///     0x44 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: B, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_B_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_B_H");

        cpuState.B = cpuState.H;

        return 4;
    }

    /// <summary>
    ///     0x45 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: B, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_B_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_B_L");

        cpuState.B = cpuState.L;

        return 4;
    }

    /// <summary>
    ///     0x46 LD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: B, [HL]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_B_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_B_iHL");

        cpuState.B = gb.ReadByte(cpuState.HL);

        return 8;
    }

    /// <summary>
    ///     0x47 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: B, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_B_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_B_A");

        cpuState.B = cpuState.A;

        return 4;
    }

    /// <summary>
    ///     0x48 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: C, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_C_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_C_B");

        cpuState.C = cpuState.B;

        return 4;
    }

    /// <summary>
    ///     0x49 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: C, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_C_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_C_C");

        cpuState.C = cpuState.C;

        return 4;
    }

    /// <summary>
    ///     0x4A LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: C, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_C_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_C_D");

        cpuState.C = cpuState.D;

        return 4;
    }

    /// <summary>
    ///     0x4B LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: C, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_C_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_C_E");

        cpuState.C = cpuState.E;

        return 4;
    }

    /// <summary>
    ///     0x4C LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: C, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_C_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_C_H");

        cpuState.C = cpuState.H;

        return 4;
    }

    /// <summary>
    ///     0x4D LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: C, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_C_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_C_L");

        cpuState.C = cpuState.L;

        return 4;
    }

    /// <summary>
    ///     0x4E LD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: C, [HL]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_C_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_C_iHL");

        cpuState.C = gb.ReadByte(cpuState.HL);

        return 8;
    }

    /// <summary>
    ///     0x4F LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: C, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_C_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_C_A");

        cpuState.C = cpuState.A;

        return 4;
    }

    /// <summary>
    ///     0x50 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: D, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_D_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_D_B");

        cpuState.D = cpuState.B;

        return 4;
    }

    /// <summary>
    ///     0x51 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: D, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_D_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_D_C");

        cpuState.D = cpuState.C;

        return 4;
    }

    /// <summary>
    ///     0x52 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: D, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_D_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_D_D");

        cpuState.D = cpuState.D;

        return 4;
    }

    /// <summary>
    ///     0x53 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: D, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_D_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_D_E");

        cpuState.D = cpuState.E;

        return 4;
    }

    /// <summary>
    ///     0x54 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: D, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_D_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_D_H");

        cpuState.D = cpuState.H;

        return 4;
    }

    /// <summary>
    ///     0x55 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: D, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_D_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_D_L");

        cpuState.D = cpuState.L;

        return 4;
    }

    /// <summary>
    ///     0x56 LD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: D, [HL]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_D_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_D_iHL");

        cpuState.D = gb.ReadByte(cpuState.HL);

        return 8;
    }

    /// <summary>
    ///     0x57 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: D, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_D_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_D_A");

        cpuState.D = cpuState.A;

        return 4;
    }

    /// <summary>
    ///     0x58 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: E, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_E_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_E_B");

        cpuState.E = cpuState.B;

        return 4;
    }

    /// <summary>
    ///     0x59 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: E, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_E_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_E_C");

        cpuState.E = cpuState.C;

        return 4;
    }

    /// <summary>
    ///     0x5A LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: E, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_E_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_E_D");

        cpuState.E = cpuState.D;

        return 4;
    }

    /// <summary>
    ///     0x5B LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: E, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_E_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_E_E");

        cpuState.E = cpuState.E;

        return 4;
    }

    /// <summary>
    ///     0x5C LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: E, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_E_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_E_H");

        cpuState.E = cpuState.H;

        return 4;
    }

    /// <summary>
    ///     0x5D LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: E, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_E_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_E_L");

        cpuState.E = cpuState.L;

        return 4;
    }

    /// <summary>
    ///     0x5E LD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: E, [HL]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_E_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_E_iHL");

        cpuState.E = gb.ReadByte(cpuState.HL);

        return 8;
    }

    /// <summary>
    ///     0x5F LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: E, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_E_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_E_A");

        cpuState.E = cpuState.A;

        return 4;
    }

    /// <summary>
    ///     0x60 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: H, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_H_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_H_B");

        cpuState.H = cpuState.B;

        return 4;
    }

    /// <summary>
    ///     0x61 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: H, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_H_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_H_C");

        cpuState.H = cpuState.C;

        return 4;
    }

    /// <summary>
    ///     0x62 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: H, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_H_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_H_D");

        cpuState.H = cpuState.D;

        return 4;
    }

    /// <summary>
    ///     0x63 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: H, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_H_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_H_E");

        cpuState.H = cpuState.E;

        return 4;
    }

    /// <summary>
    ///     0x64 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: H, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_H_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_H_H");

        cpuState.H = cpuState.H;

        return 4;
    }

    /// <summary>
    ///     0x65 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: H, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_H_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_H_L");

        cpuState.H = cpuState.L;

        return 4;
    }

    /// <summary>
    ///     0x66 LD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: H, [HL]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_H_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_H_iHL");

        cpuState.H = gb.ReadByte(cpuState.HL);

        return 8;
    }

    /// <summary>
    ///     0x67 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: H, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_H_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_H_A");

        cpuState.H = cpuState.A;

        return 4;
    }

    /// <summary>
    ///     0x68 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: L, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_L_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_L_B");

        cpuState.L = cpuState.B;

        return 4;
    }

    /// <summary>
    ///     0x69 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: L, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_L_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_L_C");

        cpuState.L = cpuState.C;

        return 4;
    }

    /// <summary>
    ///     0x6A LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: L, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_L_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_L_D");

        cpuState.L = cpuState.D;

        return 4;
    }

    /// <summary>
    ///     0x6B LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: L, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_L_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_L_E");

        cpuState.L = cpuState.E;

        return 4;
    }

    /// <summary>
    ///     0x6C LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: L, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_L_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_L_H");

        cpuState.L = cpuState.H;

        return 4;
    }

    /// <summary>
    ///     0x6D LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: L, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_L_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_L_L");

        cpuState.L = cpuState.L;

        return 4;
    }

    /// <summary>
    ///     0x6E LD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: L, [HL]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_L_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_L_iHL");

        cpuState.L = gb.ReadByte(cpuState.HL);

        return 8;
    }

    /// <summary>
    ///     0x6F LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: L, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_L_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_L_A");

        cpuState.L = cpuState.A;

        return 4;
    }

    /// <summary>
    ///     0x70 LD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: [HL], B<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_iHL_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_iHL_B");

        gb.WriteByte(cpuState.HL, cpuState.B);

        return 8;
    }

    /// <summary>
    ///     0x71 LD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: [HL], C<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_iHL_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_iHL_C");

        gb.WriteByte(cpuState.HL, cpuState.C);

        return 8;
    }

    /// <summary>
    ///     0x72 LD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: [HL], D<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_iHL_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_iHL_D");

        gb.WriteByte(cpuState.HL, cpuState.D);

        return 8;
    }

    /// <summary>
    ///     0x73 LD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: [HL], E<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_iHL_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_iHL_E");

        gb.WriteByte(cpuState.HL, cpuState.E);

        return 8;
    }

    /// <summary>
    ///     0x74 LD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: [HL], H<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_iHL_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_iHL_H");

        gb.WriteByte(cpuState.HL, cpuState.H);

        return 8;
    }

    /// <summary>
    ///     0x75 LD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: [HL], L<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_iHL_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_iHL_L");

        gb.WriteByte(cpuState.HL, cpuState.L);

        return 8;
    }

    /// <summary>
    ///     0x77 LD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: [HL], A<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_iHL_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_iHL_A");

        gb.WriteByte(cpuState.HL, cpuState.A);

        return 8;
    }

    /// <summary>
    ///     0x78 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, B<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_A_B(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_A_B");

        cpuState.A = cpuState.B;

        return 4;
    }

    /// <summary>
    ///     0x79 LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, C<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_A_C(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_A_C");

        cpuState.A = cpuState.C;

        return 4;
    }

    /// <summary>
    ///     0x7A LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, D<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_A_D(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_A_D");

        cpuState.A = cpuState.D;

        return 4;
    }

    /// <summary>
    ///     0x7B LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, E<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_A_E(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_A_E");

        cpuState.A = cpuState.E;

        return 4;
    }

    /// <summary>
    ///     0x7C LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, H<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_A_H(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_A_H");

        cpuState.A = cpuState.H;

        return 4;
    }

    /// <summary>
    ///     0x7D LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, L<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_A_L(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_A_L");

        cpuState.A = cpuState.L;

        return 4;
    }

    /// <summary>
    ///     0x7E LD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, [HL]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_A_iHL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_A_iHL");

        cpuState.A = gb.ReadByte(cpuState.HL);

        return 8;
    }

    /// <summary>
    ///     0x7F LD - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, A<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_A_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_A_A");

        cpuState.A = cpuState.A;

        return 4;
    }

    /// <summary>
    ///     0xC1 POP - 12 cycles
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
    internal static int POP_BC(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "POP_BC");

        cpuState.BC = gb.Pop();

        return 12;
    }

    /// <summary>
    ///     0xC5 PUSH - 16 cycles
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
    internal static int PUSH_BC(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "PUSH_BC");

        gb.Push(cpuState.BC);

        return 16;
    }

    /// <summary>
    ///     0xD1 POP - 12 cycles
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
    internal static int POP_DE(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "POP_DE");

        cpuState.DE = gb.Pop();

        return 12;
    }

    /// <summary>
    ///     0xD5 PUSH - 16 cycles
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
    internal static int PUSH_DE(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "PUSH_DE");

        gb.Push(cpuState.DE);

        return 16;
    }

    /// <summary>
    ///     0xE0 LDH - 12 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: [a8], A<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LDH_ia8_A(CpuState cpuState, IGameBoy gb)
    {
        var a8 = (ushort)(0xFF00 + gb.ReadByte(cpuState.PC));
        gb.TraceCpuOp(cpuState.PC - 1, "LDH_ia8_A", a8);

        cpuState.PC++;

        gb.WriteByte(a8, cpuState.A);

        return 12;
    }

    /// <summary>
    ///     0xE1 POP - 12 cycles
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
    internal static int POP_HL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "POP_HL");

        cpuState.HL = gb.Pop();

        return 12;
    }

    /// <summary>
    ///     0xE2 LDH - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: [C], A<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LDH_iC_A(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LDH_iC_A");

        gb.WriteByte((ushort)(0xFF00 + cpuState.C), cpuState.A);

        return 8;
    }

    /// <summary>
    ///     0xE5 PUSH - 16 cycles
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
    internal static int PUSH_HL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "PUSH_HL");

        gb.Push(cpuState.HL);

        return 16;
    }

    /// <summary>
    ///     0xEA LD - 16 cycles
    ///     <para>
    ///         Bytes: 3<br />
    ///         Operands: [a16], A<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_ia16_A(CpuState cpuState, IGameBoy gb)
    {
        var a16 = gb.ReadUShort(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "LD_ia16_A", a16);

        cpuState.PC += 2;

        gb.WriteByte(a16, cpuState.A);

        return 16;
    }

    /// <summary>
    ///     0xF0 LDH - 12 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: A, [a8]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LDH_A_ia8(CpuState cpuState, IGameBoy gb)
    {
        var a8 = (ushort)(0xFF00 + gb.ReadByte(cpuState.PC));
        gb.TraceCpuOp(cpuState.PC - 1, "LDH_A_ia8", a8);

        cpuState.PC++;

        cpuState.A = gb.ReadByte(a8);

        return 12;
    }

    /// <summary>
    ///     0xF1 POP - 12 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: AF<br />
    ///         Immediate mode<br />
    ///         Flags: Z=Z, N=N, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int POP_AF(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "POP_AF");

        cpuState.AF = gb.Pop();

        return 12;
    }

    /// <summary>
    ///     0xF2 LDH - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: A, [C]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LDH_A_iC(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LDH_A_iC");

        throw new NotImplementedException("LDH_A_iC");
    }

    /// <summary>
    ///     0xF5 PUSH - 16 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: AF<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int PUSH_AF(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "PUSH_AF");

        gb.Push(cpuState.AF);

        return 16;
    }

    /// <summary>
    ///     0xF8 LD - 12 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: HL, SPI, e8<br />
    ///         Immediate mode<br />
    ///         Flags: Z=0, N=0, H=H, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_HL_SPI_e8(CpuState cpuState, IGameBoy gb)
    {
        var e8 = (sbyte)gb.ReadByte(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "LD_HL_SPI_e8", e8);

        cpuState.PC++;

        var sp = cpuState.SP;
        var result = sp + e8;

        cpuState.F = 0;
        if ((sp & 0x0F) + (e8 & 0x0F) > 0x0F)
            cpuState.F |= Flags.HalfCarry;
        if ((sp & 0xFF) + (e8 & 0xFF) > 0xFF)
            cpuState.F |= Flags.Carry;

        cpuState.HL = (ushort)result;

        return 12;
    }


    /// <summary>
    ///     0xF9 LD - 8 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: SP, HL<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_SP_HL(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC - 1, "LD_SP_HL");

        cpuState.SP = cpuState.HL;

        return 8;
    }

    /// <summary>
    ///     0xFA LD - 16 cycles
    ///     <para>
    ///         Bytes: 3<br />
    ///         Operands: A, [a16]<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int LD_A_ia16(CpuState cpuState, IGameBoy gb)
    {
        var a16 = gb.ReadUShort(cpuState.PC);
        gb.TraceCpuOp(cpuState.PC - 1, "LD_A_ia16", a16);

        cpuState.PC += 2;

        cpuState.A = gb.ReadByte(a16);

        return 16;
    }
}