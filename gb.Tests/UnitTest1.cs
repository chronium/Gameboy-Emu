using gb.CPU;

namespace gb.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(0x00, 0x00, Flags.Zero)]
    [InlineData(0x01, 0x00, (Flags)0)]
    [InlineData(0x00, 0x01, (Flags)0)]
    public void OR_A_C(byte a, byte c, Flags flags)
    {
        var cpu = new CpuState
        {
            A = a,
            C = c,
            F = Flags.Zero,
        };

        Executioner.OR_A_C(cpu, new GBMock());

        Assert.Equal((byte)(a | c), cpu.A);
        Assert.Equal(flags, cpu.F);
    }

    [Theory]
    [InlineData(Flags.Zero, 0x100, 0x02)]
    [InlineData(~Flags.Zero, 0x100, 0x100)]
    public void JP_NZ_a16(Flags flags, ushort dest, ushort expectedPc)
    {
        var cpu = new CpuState
        {
            PC = 0,
            F = flags,
        };

        var mock = new GBMock();
        mock.WriteUShort(0, dest);

        Executioner.JP_NZ_a16(cpu, mock);

        Assert.Equal(expectedPc, cpu.PC);
    }

    [Theory]
    [InlineData(0x100, 0x02)]
    public void LD_iHLI_A(ushort HL, byte A)
    {
        var cpu = new CpuState
        {
            HL = HL,
            A = A,
        };

        var mock = new GBMock();

        mock.WriteByte(HL, A);

        Executioner.LD_iHLI_A(cpu, mock);

        Assert.Equal(A, mock.ReadByte(HL));
        Assert.Equal((ushort)(HL + 1), cpu.HL);
    }

    [Theory]
    [InlineData(0xFF, 0xFE)]
    public void DEC_BC(byte initial, byte expected)
    {
        var cpu = new CpuState
        {
            B = 0x01,
            C = initial,
        };

        Executioner.DEC_BC(cpu, new GBMock());

        Assert.Equal(0x01, cpu.B);
        Assert.Equal(expected, cpu.C);
    }

    [Theory]
    [InlineData(0xFFFE, 0xFFFF)]
    public void INC_DE(ushort initial, ushort expected)
    {
        var cpu = new CpuState
        {
            D = (byte)(initial >> 8),
            E = (byte)initial,
        };

        Executioner.INC_DE(cpu, new GBMock());

        Assert.Equal((byte)(expected >> 8), cpu.D);
        Assert.Equal((byte)expected, cpu.E);
    }

    [Theory]
    [InlineData(0x100, 0x100)]
    public void JP_a16(ushort dest, ushort expectedPc)
    {
        var cpu = new CpuState
        {
            PC = 0,
        };

        var mock = new GBMock();
        mock.WriteUShort(0, dest);

        Executioner.JP_a16(cpu, mock);

        Assert.Equal(expectedPc, cpu.PC);
    }

    [Theory]
    [InlineData(0x100, 0x100, Flags.Carry)]
    [InlineData(0x100, 0x02, (Flags)0)]
    public void JP_C_a16(ushort dest, ushort expectedPc, Flags flags)
    {
        var cpu = new CpuState
        {
            PC = 0,
            F = flags,
        };

        var mock = new GBMock();
        mock.WriteUShort(0, dest);

        Executioner.JP_C_a16(cpu, mock);

        Assert.Equal(expectedPc, cpu.PC);
    }

    [Theory]
    [InlineData(0x1000)]
    public void LD_BC_n16(ushort data)
    {
        var cpu = new CpuState
        {
            PC = 0,
        };

        var mock = new GBMock();
        mock.WriteUShort(0, data);

        Executioner.LD_BC_n16(cpu, mock);

        Assert.Equal(data, cpu.BC);
    }

    [Theory]
    [InlineData(0x1000)]
    public void LD_DE_n16(ushort data)
    {
        var cpu = new CpuState
        {
            PC = 0,
        };

        var mock = new GBMock();
        mock.WriteUShort(0, data);

        Executioner.LD_DE_n16(cpu, mock);

        Assert.Equal(data, cpu.DE);
    }

    [Theory]
    [InlineData(0xFA, 0x100)]
    public void LD_A_iDE(ushort data, ushort address)
    {
        var cpu = new CpuState
        {
            DE = address,
        };

        var mock = new GBMock();
        mock.WriteByte(address, (byte)data);

        Executioner.LD_A_iDE(cpu, mock);

        Assert.Equal((byte)data, cpu.A);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(0xFF)]
    public void XOR_A_A(byte a)
    {
        var cpu = new CpuState
        {
            A = a,
            F = Flags.Zero,
        };

        Executioner.XOR_A_A(cpu, new GBMock());

        Assert.Equal(0, cpu.A);
        Assert.Equal(Flags.Zero, cpu.F);
    }

    [Theory]
    [InlineData(0x10, Flags.Negative | Flags.HalfCarry)]
    [InlineData(0x20, Flags.Negative | Flags.HalfCarry)]
    [InlineData(0x01, Flags.Negative | Flags.Zero)]
    [InlineData(0x00, Flags.Negative | Flags.HalfCarry)]
    [InlineData(0xFF, Flags.Negative)]
    public void DEC_C(byte value, Flags expected)
    {
        var cpu = new CpuState
        {
            C = value,
            F = 0,
        };

        Executioner.DEC_C(cpu, new GBMock());

        Assert.Equal((byte)(value - 1), cpu.C);
        Assert.Equal(expected, cpu.F);
    }


    [Theory]
    [InlineData(0x10, Flags.Negative | Flags.HalfCarry)]
    [InlineData(0x20, Flags.Negative | Flags.HalfCarry)]
    [InlineData(0x01, Flags.Negative | Flags.Zero)]
    [InlineData(0x00, Flags.Negative | Flags.HalfCarry)]
    [InlineData(0xFF, Flags.Negative)]
    public void DEC_A(byte value, Flags expected)
    {
        var cpu = new CpuState
        {
            A = value,
            F = 0,
        };

        Executioner.DEC_A(cpu, new GBMock());

        Assert.Equal((byte)(value - 1), cpu.A);
        Assert.Equal(expected, cpu.F);
    }

    [Theory]
    [InlineData(0x10, Flags.Negative | Flags.HalfCarry)]
    [InlineData(0x20, Flags.Negative | Flags.HalfCarry)]
    [InlineData(0x01, Flags.Negative | Flags.Zero)]
    [InlineData(0x00, Flags.Negative | Flags.HalfCarry)]
    [InlineData(0xFF, Flags.Negative)]
    public void DEC_B(byte value, Flags expected)
    {
        var cpu = new CpuState
        {
            B = value,
            F = 0,
        };

        Executioner.DEC_B(cpu, new GBMock());

        Assert.Equal((byte)(value - 1), cpu.B);
        Assert.Equal(expected, cpu.F);
    }

    [Theory]
    [InlineData(0x10, Flags.Negative | Flags.HalfCarry)]
    [InlineData(0x20, Flags.Negative | Flags.HalfCarry)]
    [InlineData(0x01, Flags.Negative | Flags.Zero)]
    [InlineData(0x00, Flags.Negative | Flags.HalfCarry)]
    [InlineData(0xFF, Flags.Negative)]
    public void DEC_D(byte value, Flags expected)
    {
        var cpu = new CpuState
        {
            D = value,
            F = 0,
        };

        Executioner.DEC_D(cpu, new GBMock());

        Assert.Equal((byte)(value - 1), cpu.D);
        Assert.Equal(expected, cpu.F);
    }

    [Theory]
    [InlineData(0x10, (Flags)0)]
    [InlineData(0x20, (Flags)0)]
    [InlineData(0x2f, Flags.HalfCarry)]
    [InlineData(0x01, (Flags)0)]
    [InlineData(0x00, (Flags)0)]
    [InlineData(0xff, Flags.Zero | Flags.HalfCarry)]
    [InlineData(0x0f, Flags.HalfCarry)]
    public void INC_C(byte value, Flags expected)
    {
        var cpu = new CpuState
        {
            C = value,
            F = 0,
        };

        Executioner.INC_C(cpu, new GBMock());

        Assert.Equal((byte)(value + 1), cpu.C);
        Assert.Equal(expected, cpu.F);
    }

    [Theory]
    [InlineData(0x00, Flags.Zero, 0x00)]
    [InlineData(0x01, (Flags)0, 0x02)]
    [InlineData(0xFF, Flags.Carry | Flags.HalfCarry, 0xFE)]
    [InlineData(0x80, Flags.Zero | Flags.Carry, 0x00)]
    [InlineData(0x7F, Flags.HalfCarry, 0xFE)]
    public void ADD_A_A(byte initialA, Flags expected, byte expectedA)
    {
        var cpu = new CpuState
        {
            A = initialA,
            F = 0,
        };

        Executioner.ADD_A_A(cpu, new GBMock());

        Assert.Equal(expectedA, cpu.A);
        Assert.Equal(expected, cpu.F);
    }

    [Theory]
    [InlineData(0x1000, 0x2000, 0x3000, (Flags)0)]
    [InlineData(0xfff0, 0x0010, 0x0000, Flags.Carry | Flags.HalfCarry)]
    [InlineData(0x0000, 0x0001, 0x0001, (Flags)0)]
    [InlineData(0x8000, 0x7fff, 0xffff, (Flags)0)]
    [InlineData(0x7fff, 0x0001, 0x8000, Flags.HalfCarry)]
    public void ADD_HL_DE(ushort hl, ushort de, ushort result, Flags expected)
    {
        var cpu = new CpuState
        {
            HL = hl,
            DE = de,
            F = 0,
        };

        Executioner.ADD_HL_DE(cpu, new GBMock());

        Assert.Equal(result, cpu.HL);
        Assert.Equal(expected, cpu.F);
    }

    [Theory]
    [InlineData(0x02, Flags.Zero | Flags.Negative, 0x00)] // 2 - 2 = 0, Zero flag set
    [InlineData(0x03, Flags.Negative, 0x01)] // 3 - 2 = 1, only Negative flag set
    [InlineData(0x01, Flags.Carry | Flags.HalfCarry | Flags.Negative,
        0xFF)] // 1 - 2 = -1 (wraps to 0xFF), Carry & HalfCarry set
    [InlineData(0x80, Flags.Negative | Flags.HalfCarry, 0x7E)] // 0x80 - 2 = 0x7E, only Negative flag set
    [InlineData(0x00, Flags.Carry | Flags.Negative | Flags.HalfCarry, 0xFE)] // 0 - 2 = -2 (wraps to 0xFE), Carry set
    public void SUB_A_B(byte initialA, Flags expected, byte expectedA)
    {
        var cpu = new CpuState
        {
            A = initialA,
            B = 0x02, // We assume B is 2 for all cases
            F = 0,
        };

        Executioner.SUB_A_B(cpu, new GBMock());

        Assert.Equal(expectedA, cpu.A);
        Assert.Equal(expected, cpu.F);
    }

    [Theory]
    [InlineData(0x00, 0x00, Flags.Zero, 0x00)]
    [InlineData(0x01, 0x01, (Flags)0, 0x02)]
    [InlineData(0xFF, 0xFF, Flags.Carry | Flags.HalfCarry, 0xFE)]
    [InlineData(0x80, 0x80, Flags.Zero | Flags.Carry, 0x00)]
    [InlineData(0x7F, 0x7f, Flags.HalfCarry, 0xFE)]
    public void ADD_A_n8(byte initialA, byte n8, Flags expected, byte expectedA)
    {
        var cpu = new CpuState
        {
            A = initialA,
            F = 0,
        };

        var mock = new GBMock();

        mock.WriteByte(0, n8);

        Executioner.ADD_A_n8(cpu, mock);

        Assert.Equal(expectedA, cpu.A);
        Assert.Equal(expected, cpu.F);
    }

    [Theory]
    [InlineData(0x02, Flags.Zero | Flags.Negative, 0x00)] // 2 - 2 = 0, Zero flag set
    [InlineData(0x03, Flags.Negative, 0x01)] // 3 - 2 = 1, only Negative flag set
    [InlineData(0x01, Flags.Carry | Flags.HalfCarry | Flags.Negative,
        0xFF)] // 1 - 2 = -1 (wraps to 0xFF), Carry & HalfCarry set
    [InlineData(0x80, Flags.Negative | Flags.HalfCarry, 0x7E)] // 0x80 - 2 = 0x7E, only Negative flag set
    [InlineData(0x00, Flags.Carry | Flags.Negative | Flags.HalfCarry, 0xFE)] // 0 - 2 = -2 (wraps to 0xFE), Carry set
    public void SUB_A_n8(byte initialA, Flags expected, byte expectedA)
    {
        var cpu = new CpuState
        {
            A = initialA,
            F = 0,
        };

        var mock = new GBMock();

        mock.WriteByte(0, 0x02);

        Executioner.SUB_A_n8(cpu, mock);

        Assert.Equal(expectedA, cpu.A);
        Assert.Equal(expected, cpu.F);
    }

    [Theory]
    [InlineData(0x02, (Flags)0, 0x01)] // 0x02 >> 1 = 0x01, no flags except N & H (always 0)
    [InlineData(0x01, Flags.Carry | Flags.Zero, 0x00)] // 0x01 >> 1 = 0x00, Carry set, Zero set
    [InlineData(0x80, (Flags)0, 0x40)] // 0x80 >> 1 = 0x40, no Carry
    [InlineData(0xFF, Flags.Carry, 0x7F)] // 0xFF >> 1 = 0x7F, Carry set
    [InlineData(0x00, Flags.Zero, 0x00)] // 0 remains 0, Zero set
    public void SRL_B(byte initialB, Flags expectedFlags, byte expectedB)
    {
        var cpu = new CpuState
        {
            B = initialB,
            F = 0,
        };

        Executioner.SRL_B(cpu, new GBMock());

        Assert.Equal(expectedB, cpu.B);
        Assert.Equal(expectedFlags, cpu.F);
    }

    [Theory]
    [InlineData(0x02, false, (Flags)0, 0x01)] // 0x02 >> 1 = 0x01, no carry
    [InlineData(0x01, false, Flags.Carry | Flags.Zero, 0x00)] // 0x01 >> 1 = 0x00, Carry set, Zero set
    [InlineData(0x80, false, (Flags)0, 0x40)] // 0x80 >> 1 = 0x40, no carry
    [InlineData(0xFF, false, Flags.Carry, 0x7F)] // 0xFF >> 1 = 0x7F, Carry set
    [InlineData(0x00, false, Flags.Zero, 0x00)] // 0 remains 0, Zero set
    [InlineData(0x01, true, Flags.Carry, 0x80)] // 0x01 >> 1, Carry in → 0x80, Carry out
    [InlineData(0x02, true, (Flags)0, 0x81)] // 0x02 >> 1, Carry in → 0x81, no Carry out
    public void RR_C(byte initialC, bool carryIn, Flags expectedFlags, byte expectedC)
    {
        var cpu = new CpuState
        {
            C = initialC,
            F = carryIn ? Flags.Carry : 0,
        };

        Executioner.RR_C(cpu, new GBMock());

        Assert.Equal(expectedC, cpu.C);
        Assert.Equal(expectedFlags, cpu.F);
    }

    [Theory]
    [InlineData(0x02, false, (Flags)0, 0x01)] // 0x02 >> 1 = 0x01, no carry
    [InlineData(0x01, false, Flags.Carry, 0x00)] // 0x01 >> 1 = 0x00, Carry set
    [InlineData(0x80, false, (Flags)0, 0x40)] // 0x80 >> 1 = 0x40, no carry
    [InlineData(0xFF, false, Flags.Carry, 0x7F)] // 0xFF >> 1 = 0x7F, Carry set
    [InlineData(0x00, false, (Flags)0, 0x00)] // 0 remains 0, no carry
    [InlineData(0x01, true, Flags.Carry, 0x80)] // 0x01 >> 1 with Carry in → 0x80, Carry out
    [InlineData(0x02, true, (Flags)0, 0x81)] // 0x02 >> 1 with Carry in → 0x81, no Carry out
    public void RRA(byte initialA, bool carryIn, Flags expectedFlags, byte expectedA)
    {
        var cpu = new CpuState
        {
            A = initialA,
            F = carryIn ? Flags.Carry : 0,
        };

        Executioner.RRA(cpu, new GBMock());

        Assert.Equal(expectedA, cpu.A);
        Assert.Equal(expectedFlags, cpu.F);
    }

    [Theory]
    [InlineData(0x10, 0x20, false, (Flags)0, 0x30)] // 0x10 + 0x20 = 0x30, no carry
    [InlineData(0xF0, 0x10, false, Flags.Zero | Flags.Carry, 0x00)] // 0xF0 + 0x10 = 0x00 (overflow), Half-Carry set
    [InlineData(0x80, 0x80, false, Flags.Carry | Flags.Zero, 0x00)] // 0x80 + 0x80 = 0x00 (overflow), Carry set
    [InlineData(0xFF, 0x01, false, Flags.Carry | Flags.Zero | Flags.HalfCarry, 0x00)] // 0xFF + 0x01 = 0x00, Carry set
    [InlineData(0x0F, 0x01, false, Flags.HalfCarry, 0x10)] // 0x0F + 0x01 = 0x10, Half-Carry set
    [InlineData(0xFF, 0x01, true, Flags.Carry | Flags.HalfCarry,
        0x01)] // 0xFF + 0x01 + Carry = 0x01, Carry and Half-Carry set
    [InlineData(0x00, 0x00, true, (Flags)0, 0x01)] // 0x00 + 0x00 + Carry = 0x01, Zero set
    public void ADC_A_n8(byte initialA, byte immediate, bool carryIn, Flags expectedFlags, byte expectedA)
    {
        var cpu = new CpuState
        {
            A = initialA,
            PC = 0x100, // Arbitrary program counter location
            F = carryIn ? Flags.Carry : 0,
        };

        var gbMock = new GBMock();
        gbMock.WriteByte(0x100, immediate);

        Executioner.ADC_A_n8(cpu, gbMock);

        Assert.Equal(expectedA, cpu.A);
        Assert.Equal(expectedFlags, cpu.F);
    }

    [Theory]
    [InlineData(0x02, Flags.Negative, 0x01)] // 0x02 - 1 = 0x01, only Negative set
    [InlineData(0x01, Flags.Zero | Flags.Negative, 0x00)] // 0x01 - 1 = 0x00, Zero and Negative set
    [InlineData(0x10, Flags.HalfCarry | Flags.Negative, 0x0F)] // 0x10 - 1 = 0x0F, Half-Carry set
    [InlineData(0x00, Flags.Zero | Flags.Negative | Flags.HalfCarry, 0xFF)] // 0x00 - 1 = 0xFF, Half-Carry set
    public void DEC_iHL(byte initialValue, Flags expectedFlags, byte expectedValue)
    {
        var cpu = new CpuState
        {
            HL = 0x1234, // Arbitrary memory address
            F = 0,
        };

        var gbMock = new GBMock();
        gbMock.WriteByte(0x1234, initialValue); // Set value at HL address

        Executioner.DEC_iHL(cpu, gbMock);

        Assert.Equal(expectedValue, gbMock.ReadByte(0x1234));
        Assert.Equal(expectedFlags, cpu.F);
    }


    private class GBMock : IGameBoy
    {
        private readonly byte[] _mem = new byte[0x2000];

        public GameBoyCartridgeHeader? CartridgeHeader { get; }

        public void TraceCpuOp(int address, string op)
        {
        }

        public void TraceCpuOp(int cpuStatePc, string op, sbyte imm)
        {
        }

        public void TraceCpuOp(int cpuStatePc, string op, byte imm)
        {
        }

        public void TraceCpuOp(int cpuStatePc, string op, ushort imm)
        {
        }

        public void TraceCpuOp(int cpuStatePc, string op, short imm)
        {
        }

        public byte ReadByte(ushort address)
        {
            return _mem[address];
        }

        public ushort ReadUShort(ushort address)
        {
            return (ushort)(_mem[address] | (_mem[address + 1] << 8));
        }

        public void WriteByte(ushort address, byte value)
        {
            _mem[address] = value;
        }

        public void WriteUShort(ushort address, ushort value)
        {
            _mem[address] = (byte)value;
            _mem[address + 1] = (byte)(value >> 8);
        }

        public void Push(ushort value)
        {
            throw new NotImplementedException();
        }

        public ushort Pop()
        {
            throw new NotImplementedException();
        }
    }
}