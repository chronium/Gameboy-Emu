// ReSharper disable once CheckNamespace

namespace gb.CPU;

public static partial class Executioner
{
    /// <summary>
    ///     0x00 NOP - 4 cycles
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
    internal static int NOP(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "NOP");

        throw new NotImplementedException("NOP");
    }

    /// <summary>
    ///     0x10 STOP - 4 cycles
    ///     <para>
    ///         Bytes: 2<br />
    ///         Operands: n8<br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=-, H=-, C=-
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int STOP_n8(CpuState cpuState, IGameBoy gb)
    {
        var n8 = gb.ReadByte(cpuState.PC);
        cpuState.PC++;

        gb.TraceCpuOp(cpuState.PC, "STOP_n8", n8);

        throw new NotImplementedException("STOP_n8");
    }

    /// <summary>
    ///     0x37 SCF - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: <br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=0, H=0, C=1
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int SCF(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "SCF");

        throw new NotImplementedException("SCF");
    }

    /// <summary>
    ///     0x3F CCF - 4 cycles
    ///     <para>
    ///         Bytes: 1<br />
    ///         Operands: <br />
    ///         Immediate mode<br />
    ///         Flags: Z=-, N=0, H=0, C=C
    ///     </para>
    /// </summary>
    /// <param cref="gb.CpuState" name="cpuState">The CPU state</param>
    /// <param cref="gb.IGameBoy" name="gb">The Game Boy instance</param>
    /// <returns>The number of cycles taken</returns>
    internal static int CCF(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "CCF");

        throw new NotImplementedException("CCF");
    }

    /// <summary>
    ///     0x76 HALT - 4 cycles
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
    internal static int HALT(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "HALT");

        throw new NotImplementedException("HALT");
    }

    /// <summary>
    ///     0xD3 ILLEGAL_D3 - 4 cycles
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
    internal static int ILLEGAL_D3(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "ILLEGAL_D3");

        throw new NotImplementedException("ILLEGAL_D3");
    }

    /// <summary>
    ///     0xDB ILLEGAL_DB - 4 cycles
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
    internal static int ILLEGAL_DB(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "ILLEGAL_DB");

        throw new NotImplementedException("ILLEGAL_DB");
    }

    /// <summary>
    ///     0xDD ILLEGAL_DD - 4 cycles
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
    internal static int ILLEGAL_DD(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "ILLEGAL_DD");

        throw new NotImplementedException("ILLEGAL_DD");
    }

    /// <summary>
    ///     0xE3 ILLEGAL_E3 - 4 cycles
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
    internal static int ILLEGAL_E3(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "ILLEGAL_E3");

        throw new NotImplementedException("ILLEGAL_E3");
    }

    /// <summary>
    ///     0xE4 ILLEGAL_E4 - 4 cycles
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
    internal static int ILLEGAL_E4(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "ILLEGAL_E4");

        throw new NotImplementedException("ILLEGAL_E4");
    }

    /// <summary>
    ///     0xEB ILLEGAL_EB - 4 cycles
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
    internal static int ILLEGAL_EB(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "ILLEGAL_EB");

        throw new NotImplementedException("ILLEGAL_EB");
    }

    /// <summary>
    ///     0xEC ILLEGAL_EC - 4 cycles
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
    internal static int ILLEGAL_EC(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "ILLEGAL_EC");

        throw new NotImplementedException("ILLEGAL_EC");
    }

    /// <summary>
    ///     0xED ILLEGAL_ED - 4 cycles
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
    internal static int ILLEGAL_ED(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "ILLEGAL_ED");

        throw new NotImplementedException("ILLEGAL_ED");
    }

    /// <summary>
    ///     0xF3 DI - 4 cycles
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
    internal static int DI(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "DI");

        throw new NotImplementedException("DI");
    }

    /// <summary>
    ///     0xF4 ILLEGAL_F4 - 4 cycles
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
    internal static int ILLEGAL_F4(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "ILLEGAL_F4");

        throw new NotImplementedException("ILLEGAL_F4");
    }

    /// <summary>
    ///     0xFB EI - 4 cycles
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
    internal static int EI(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "EI");

        throw new NotImplementedException("EI");
    }

    /// <summary>
    ///     0xFC ILLEGAL_FC - 4 cycles
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
    internal static int ILLEGAL_FC(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "ILLEGAL_FC");

        throw new NotImplementedException("ILLEGAL_FC");
    }

    /// <summary>
    ///     0xFD ILLEGAL_FD - 4 cycles
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
    internal static int ILLEGAL_FD(CpuState cpuState, IGameBoy gb)
    {
        gb.TraceCpuOp(cpuState.PC, "ILLEGAL_FD");

        throw new NotImplementedException("ILLEGAL_FD");
    }
}