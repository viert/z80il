namespace Z80
{
    public class Cpu
    {
        /* Code generation helpers */
        // Parity Bit
        protected bool[] parityBit = new bool[256] {
            true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true,
            false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false,
            false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false,
            true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true,
            false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false,
            true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true,
            true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true,
            false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false,
            false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false,
            true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true,
            true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true,
            false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false,
            true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true,
            false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false,
            false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false,
            true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true
        };

        // Flags
        protected const byte f_c = 1;
        protected const byte f_n = 2;
        protected const byte f_pv = 4;
        protected const byte f_3 = 8;
        protected const byte f_h = 16;
        protected const byte f_5 = 32;
        protected const byte f_z = 64;
        protected const byte f_s = 128;

        // Flag conditions
        protected const byte c_nz = 0;
        protected const byte c_z = 1;
        protected const byte c_nc = 2;
        protected const byte c_c = 3;
        protected const byte c_po = 4;
        protected const byte c_pe = 5;
        protected const byte c_p = 6;
        protected const byte c_m = 7;

        // Carry helpers
        protected const bool hasCarry_adc = true;
        protected const bool hasCarry_sbc = true;
        protected const bool hasCarry_add = false;
        protected const bool hasCarry_sub = false;

        // Subtraction helpers
        protected const bool isSub_adc = false;
        protected const bool isSub_sbc = true;
        protected const bool isSub_add = false;
        protected const bool isSub_sub = true;

        // Inc/Dec helpers
        protected const bool isDec_inc = false;
        protected const bool isDec_dec = false;

        /* Code generation helpers end */

        protected IMemory memory;

        // Registers
        protected RegisterSet r1;
        protected RegisterSet r2;

        protected ushort pc;
        protected ushort sp;
        protected byte r;
        protected byte i;
        protected int im;
        protected bool iff1, iff2;


        // Opcodes
        protected OpcodeTable opcodeTable;
        protected OpcodeTable opcodeTableCB;
        protected OpcodeTable opcodeTableED;
        protected OpcodeTable opcodeTableDD;
        protected OpcodeTable opcodeTableFD;
        protected OpcodeTable opcodeTableDDCB;
        protected OpcodeTable opcodeTableFDCB;

        // Execution
        protected ulong tStates;
        protected bool halted;

        // Interrupts
        protected bool nmiRequested;
        protected bool intRequested;
        protected bool deferInt;
        protected bool execIntVector;

        protected byte Read8(ushort addr) {
            tStates += 3;
            return memory.Read8(addr);
        }

        protected void Write8(ushort addr, byte value) {
            tStates += 3;
            memory.Write8(addr, value);
        }

        protected ushort Read16(ushort addr) {
            byte low, high;
            low = Read8(addr++);
            high = Read8(addr);
            return (ushort)(low | (high << 8));
        }

        protected void Write16(ushort addr, ushort value) {
            byte low = (byte)(value & 0xFF);
            byte high = (byte)((value >> 8) & 0xFF);
            Write8(addr++, low);
            Write8(addr, high);
        }

        protected void SetFlag(byte flag) {
            r1.f = (byte)(r1.f | flag);
        }

        protected void ResFlag(byte flag) {
            flag = (byte)~flag;
            r1.f = (byte)(r1.f & flag);
        }

        protected void ValFlag(byte flag, bool value) {
            if (value) {
                SetFlag(flag);
            } else {
                ResFlag(flag);
            }
        }

        protected bool GetFlag(byte flag) {
            return (r1.f & flag) != 0;
        }

        protected void AdjustFlags(byte value) {
            ValFlag(f_5, (value & f_5) != 0);
            ValFlag(f_3, (value & f_3) != 0);
        }

        protected void AdjustFlagsSZP(byte value) {
            ValFlag(f_s, (value & 0x80) != 0);
            ValFlag(f_z, value == 0);
            ValFlag(f_pv, parityBit[value]);
        }

        protected void AdjustLogicFlag(bool flagH) {
            AdjustFlagsSZP(r1.a);
            AdjustFlags(r1.a);
            ValFlag(f_h, flagH);
            ResFlag(f_n);
            ResFlag(f_c);
        }

        protected bool Condition(byte condition) {
            switch(condition) {
                case c_z:
                    return GetFlag(f_z);
                case c_nz:
                    return !GetFlag(f_z);
                case c_c:
                    return GetFlag(f_c);
                case c_nc:
                    return !GetFlag(f_c);
                case c_m:
                    return GetFlag(f_s);
                case c_p:
                    return !GetFlag(f_s);
                case c_pe:
                    return GetFlag(f_pv);
                case c_po:
                    return !GetFlag(f_pv);
                default:
                    return true;
            }
        }

        /* Stack-related functions */
        protected void DoPush(ushort value) {
            sp -= 2;
            Write16(sp, value);
        }

        protected ushort DoPop() {
            ushort value = Read16(sp);
            sp += 2;
            return value;
        }

        protected byte doIncDec(byte value, bool isDec) {
            if (isDec) {
                ValFlag(f_pv, (value & 0x80) != 0 && ((value - 1) & 0x80) == 0);
                value--;
                ValFlag(f_h, (value & 0x0F) == 0x0F);
            } else {
                ValFlag(f_pv, (value & 0x80) == 0 && ((value + 1) & 0x80) != 0);
                value++;
                ValFlag(f_h, (value & 0x0F) == 0);
            }

            ValFlag(f_s, (value & 0x80) != 0);
            ValFlag(f_z, value == 0);
            ValFlag(f_n, isDec);
            AdjustFlags(value);
            return value;
        }

        protected void IncR() {
            r = (byte)((r & 0x80) | ((r + 1) & 0x7f));
        }

        protected void DecR()
        {
            r = (byte)((r & 0x80) | ((r - 1) & 0x7f));
        }

        protected byte doArithmetics(byte value, bool withCarry, bool isSub) {
            ushort res;
            if (isSub) {
                SetFlag(f_n);
                ValFlag(f_h, (((r1.a & 0x0F) - (value & 0x0F)) & 0x10) != 0);
                res = (ushort)(r1.a - value);
                if (withCarry && GetFlag(f_c)) {
                    res--;
                }
            } else {
                ResFlag(f_n);
                ValFlag(f_h, (((r1.a & 0x0F) + (value & 0x0F)) & 0x10) != 0);
                res = (ushort)(r1.a + value);
                if (withCarry && GetFlag(f_c)) {
                    res++;
                }
            }

            ValFlag(f_s, (res & 0x80) != 0);
            ValFlag(f_c, (res & 0x100) != 0);
            ValFlag(f_z, (res & 0xFF) == 0);

            int minuedSign = r1.a & 0x80;
            int subtrahendSign = value & 0x80;
            int resultSign = res & 0x80;
            bool overflow;

            if (isSub) {
                overflow = minuedSign != subtrahendSign && resultSign != minuedSign;
            } else {
                overflow = minuedSign == subtrahendSign && resultSign != minuedSign;
            }
            ValFlag(f_pv, overflow);
            AdjustFlags((byte)(res & 0xFF));
            return (byte)(res & 0xFF);
        }

        protected void DoAnd(byte value) {
            r1.a &= value;
            AdjustLogicFlag(true);
        }

        protected void DoOr(byte value) {
            r1.a |= value;
            AdjustLogicFlag(false);
        }

        protected void DoXor(byte value) {
            r1.a ^= value;
            AdjustLogicFlag(false);
        }

        protected void DoBit(int b, byte value) {
            if ((value&(1<<b)) != 0) {
                ResFlag(f_z | f_pv);
            } else {
                SetFlag(f_z | f_pv);
            }
            SetFlag(f_h);
            ResFlag(f_n);
            ResFlag(f_s);
            if (b == 7 && !GetFlag(f_z)) {
                SetFlag(f_s);
            }
        }

        protected void DoBitR(int b, byte value) {
            DoBit(b, value);
            AdjustFlags(value);
        }

        protected void DoBitIndexed(int b, ushort addr) {
            byte value = Read8(addr);
            DoBit(b, value);
            byte high = (byte)(addr >> 8);
            AdjustFlags(high);
        }

        protected byte DoSetRes(bool state, int pos, byte value) {
            if (state) {
                return (byte)(value | (1 << pos));
            } else {
                return (byte)(value & ~(1 << pos));
            }
        }

        protected void DoDAA() {
            byte factor = 0;
            bool carry = false;

            if (r1.a > 0x99 || GetFlag(f_c)) {
                factor |= 0x60;
                carry = true;
            }
            if (((r1.a & 0x0F) > 9) || GetFlag(f_h)) {
                factor |= 0x06;
            }

            byte a = r1.a;
            if (GetFlag(f_n)) {
                r1.a -= factor;
            } else {
                r1.a += factor;
            }

            ValFlag(f_h, ((a ^ r1.a) & 0x10) != 0);
            ValFlag(f_c, carry);
            AdjustFlags(r1.a);
            AdjustFlagsSZP(r1.a);
        }
         
        protected void CreateTables() {
            // Creating tables
            opcodeTable = new OpcodeTable();
            opcodeTableCB = new OpcodeTable();
            opcodeTableDD = new OpcodeTable();
            opcodeTableED = new OpcodeTable();
            opcodeTableFD = new OpcodeTable();
            opcodeTableDDCB = new OpcodeTable(1);
            opcodeTableFDCB = new OpcodeTable(1);

            // Linking tables
            opcodeTable.entries[0xCB].nextTable = opcodeTableCB;
            opcodeTable.entries[0xDD].nextTable = opcodeTableDD;
            opcodeTable.entries[0xED].nextTable = opcodeTableED;
            opcodeTable.entries[0xFD].nextTable = opcodeTableFD;
            opcodeTableDD.entries[0xCB].nextTable = opcodeTableDDCB;
            opcodeTableFD.entries[0xCB].nextTable = opcodeTableFDCB;

            opcodeTableDD.entries[0xDD].nextTable = opcodeTableDD;
            opcodeTableFD.entries[0xDD].nextTable = opcodeTableDD;
            opcodeTableDD.entries[0xFD].nextTable = opcodeTableFD;
            opcodeTableFD.entries[0xFD].nextTable = opcodeTableFD;
        }

        // Public methods
        // Constructor
        public Cpu(IMemory mem)
        {
            memory = mem;
            CreateTables();
        }

        // Reset() resets the cpu instance
        public void Reset()
        {
            tStates = 0;
            halted = false;

            nmiRequested = false;
            intRequested = false;
            deferInt = false;
            execIntVector = false;

            pc = 0;
            r1.f = 0;
            im = 0;
            iff1 = false;
            iff2 = false;
            r = 0;
            i = 0;
        }

    }
}
