using System;
using System.Collections.Generic;

namespace Z80
{
    public class CodesList: List<byte> {
        public override string ToString()
        {
            string result = "";
            foreach (byte code in this) {
                if (result != "") {
                    result += " ";
                }
                result += string.Format("#{0:X2}", code);
            }
            return result;
        }
    }

    public enum DisassembleMode { Dec, Hex };

    public class BaseCpu
    {
        /* Code generation helpers */
        // Parity Bit
        protected bool[] parityBit = {
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
        protected const bool isDec_dec = true;

        protected const bool isArithmeticsA = true;
        protected const bool isArithmeticsL = false;
        protected const bool bitStateSET = true;
        protected const bool bitStateRES = false;

        /* Code generation helpers end */

        protected IMemory memory;
        protected IPort io;

        // Registers
        public RegisterSet r1;
        public RegisterSet r2;

        public ushort pc;
        public byte r;
        public byte i;
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
        public ulong tStates;
        protected bool halted;
        HashSet<ushort> breakpoints = new HashSet<ushort>();

        // Disassembly
        DisassembleMode dasmMode = DisassembleMode.Hex;

        // Interrupts
        protected bool nmiRequested;
        protected bool intRequested;
        protected bool deferInt;
        protected bool execIntVector;
        protected byte intVector;

        protected byte IORead(ushort addr) {
            tStates += 4;
            return io.Read(addr);
        }

        protected void IOWrite(ushort addr, byte value) {
            tStates += 4;
            io.Write(addr, value);
        }

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
            r1.sp -= 2;
            Write16(r1.sp, value);
        }

        protected ushort DoPop() {
            ushort value = Read16(r1.sp);
            r1.sp += 2;
            return value;
        }

        protected byte DoIncDec(byte value, bool isDec) {
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

        protected byte DoArithmetics(byte value, bool withCarry, bool isSub) {
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

        protected ushort DoAddWord(ushort a1, ushort a2, bool withCarry, bool isSub)
        {
            if (withCarry && GetFlag(f_c))
            {
                a2++;
            }

            int sum = a1;
            if (isSub)
            {
                sum -= a2;
                ValFlag(f_h, (((a1 & 0x0FFF) - (a2 & 0x0FFF)) & 0x1000) != 0);
            }
            else
            {
                sum += a2;
                ValFlag(f_h, (((a1 & 0x0FFF) + (a2 & 0x0FFF)) & 0x1000) != 0);
            }

            ValFlag(f_c, (sum & 0x10000) != 0);

            if (withCarry || isSub)
            {
                var minuedSign = a1 & 0x8000;
                var subtrahendSign = a2 & 0x8000;
                var resultSign = sum & 0x8000;
                bool overflow;
                if (isSub)
                {
                    overflow = minuedSign != subtrahendSign && resultSign != minuedSign;
                }
                else
                {
                    overflow = minuedSign == subtrahendSign && resultSign != minuedSign;
                }
                ValFlag(f_pv, overflow);
                ValFlag(f_s, resultSign != 0);
                ValFlag(f_z, sum == 0);
            }
            ValFlag(f_n, isSub);
            AdjustFlags((byte)(sum >> 8));
            return (ushort)sum;
        }

        protected void DoAND(byte value) {
            r1.a &= value;
            AdjustLogicFlag(true);
        }

        protected void DoOR(byte value) {
            r1.a |= value;
            AdjustLogicFlag(false);
        }

        protected void DoXOR(byte value) {
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

        protected byte DoCPHL() {
            byte value = Read8(r1.hl);
            byte res = DoArithmetics(value, false, true);
            AdjustFlags(value);
            return res;
        }

        protected byte DoRLC(byte value, bool adjust) {
            ValFlag(f_c, (value & 0x80) != 0);
            value <<= 1;
            byte cy = (byte)(GetFlag(f_c) ? 1 : 0);
            value |= cy;
            AdjustFlags(value);
            ResFlag(f_h | f_n);
            if (adjust) {
                AdjustFlagsSZP(value);
            }
            return value;
        }

        protected byte DoRRC(byte value, bool adjust)
        {
            ValFlag(f_c, (value & 0x01) != 0);
            value >>= 1;
            byte cy = (byte)(GetFlag(f_c) ? 0x80 : 0);
            value |= cy;
            AdjustFlags(value);
            ResFlag(f_h | f_n);
            if (adjust)
            {
                AdjustFlagsSZP(value);
            }
            return value;
        }

        protected byte DoRL(byte value, bool adjust)
        {
            byte cy = (byte)(GetFlag(f_c) ? 1 : 0);
            ValFlag(f_c, (value & 0x80) != 0);
            value <<= 1;
            value |= cy;
            AdjustFlags(value);
            ResFlag(f_h | f_n);
            if (adjust)
            {
                AdjustFlagsSZP(value);
            }
            return value;
        }

        protected byte DoRR(byte value, bool adjust)
        {
            byte cy = (byte)(GetFlag(f_c) ? 0x80 : 0);
            ValFlag(f_c, (value & 0x01) != 0);
            value >>= 1;
            value |= cy;
            AdjustFlags(value);
            ResFlag(f_h | f_n);
            if (adjust)
            {
                AdjustFlagsSZP(value);
            }
            return value;
        }

        protected byte DoSL(byte value, bool isArithmetics) {
            ValFlag(f_c, (value & 0x80) != 0);
            value <<= 1;
            if (!isArithmetics) {
                value |= 1;
            }
            AdjustFlags(value);
            ResFlag(f_h | f_n);
            AdjustFlagsSZP(value);
            return value;
        }
         
        protected byte DoSR(byte value, bool isArithmetics) {
            byte bit = (byte)(value & 0x80);
            ValFlag(f_c, (value & 0x01) != 0);
            value >>= 1;
            if (isArithmetics) {
                value |= bit;
            }
            AdjustFlags(value);
            ResFlag(f_h | f_n);
            AdjustFlagsSZP(value);
            return value;
        }
         
        virtual protected void CreateTables() {
            // Creating tables
            opcodeTable = new OpcodeTable();
            opcodeTableCB = new OpcodeTable();
            opcodeTableDD = new OpcodeTable();
            opcodeTableED = new OpcodeTable();
            opcodeTableFD = new OpcodeTable();
            opcodeTableDDCB = new OpcodeTable(1);
            opcodeTableFDCB = new OpcodeTable(1);

            // Linking tables
            opcodeTable.entries[0xCB] = new OpcodeTableEntry(null, "", null, opcodeTableCB);
            opcodeTable.entries[0xDD] = new OpcodeTableEntry(null, "", null, opcodeTableDD);
            opcodeTable.entries[0xED] = new OpcodeTableEntry(null, "", null, opcodeTableED);
            opcodeTable.entries[0xFD] = new OpcodeTableEntry(null, "", null, opcodeTableFD);
            opcodeTableDD.entries[0xCB] = new OpcodeTableEntry(null, "", null, opcodeTableDDCB);
            opcodeTableFD.entries[0xCB] = new OpcodeTableEntry(null, "", null, opcodeTableFDCB);

            opcodeTableDD.entries[0xDD] = new OpcodeTableEntry(null, "", null, opcodeTableDD);
            opcodeTableFD.entries[0xDD] = new OpcodeTableEntry(null, "", null, opcodeTableDD);
            opcodeTableDD.entries[0xFD] = new OpcodeTableEntry(null, "", null, opcodeTableFD);
            opcodeTableFD.entries[0xFD] = new OpcodeTableEntry(null, "", null, opcodeTableFD);
        }

        // Public methods
        // Constructor
        public BaseCpu(IMemory mem, IPort port)
        {
            io = port;
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

        // Execute() executes a single CPU operation
        // paying attention to interrupts

        public ulong Execute() {
            ulong t = tStates;
            if (nmiRequested) {
                DoNMI();
            } else if (intRequested && !deferInt && iff1) {
                DoINT();
            } else {
                deferInt = false;
                DoExecute();
            }

            return tStates - t;
        }

        // 
        // in case of pc == breakpoint Execute(tStates) stops and returns 0
        // remove breakpoint to move further or use Execute() to bypass
        public ulong Execute(ulong tStates) {
            ulong t = 0;
            while (t < tStates) {
                if (breakpoints.Contains(pc))
                {
                    break;
                }
                t += Execute();
            }
            return t;
        }

        protected void Unhalt() {
            if (halted) {
                halted = false;
                pc++;
            }
        }

        protected void DoNMI() {
            Unhalt();
            iff2 = iff1;
            iff1 = false;
            DoPush(pc);
            pc = 0x0066;
            nmiRequested = false;
            tStates += 5;
        }

        protected void DoINT() {
            Unhalt();
            iff1 = false;
            iff2 = false;
            intRequested = false;
            switch (im) {
                case 0:
                    execIntVector = true;
                    DoExecute();
                    execIntVector = false;
                    break;
                case 1:
                    DoPush(pc);
                    pc = 0x0038;
                    tStates += 7;
                    break;
                case 2:
                    DoPush(pc);
                    ushort vectorAddr = (ushort)((i << 8) | intVector);
                    pc = Read16(vectorAddr);
                    tStates += 7;
                    break;
            }
        }

        public void Nmi() {
            nmiRequested = true;
        }

        public void Int(byte value) {
            intVector = value;
            intRequested = true;
        }

        public void AddBreakpoint(ushort addr)
        {
            breakpoints.Add(addr);
        }

        public void RemoveBreakpoint(ushort addr)
        {
            breakpoints.Remove(addr);
        }

        public ushort[] GetBreakpoints()
        {
            ushort[] bkpts = new ushort[breakpoints.Count];
            breakpoints.CopyTo(bkpts);
            return bkpts;
        }

        protected void DoExecute() {
            byte opCode;
            int offset = 0;
            OpcodeTableEntry operation;
            OpcodeTable current = opcodeTable;
            ushort start = pc;

            while (true) {
                if (execIntVector) {
                    opCode = intVector;
                    tStates += 6;
                } else {
                    opCode = Read8((ushort)(pc + offset));
                    pc++;
                    tStates++;
                }
                IncR();

                operation = current.entries[opCode];
                if (operation == null) {
                    throw new NullReferenceException(
                        string.Format("Operation is not implemented at 0x{0:X4}", 
                                      start));
                }

                if (operation.func != null) {
                    pc = (ushort)(pc - offset);
                    operation.func();
                    pc = (ushort)(pc + offset);
                    break;
                }

                if (operation.nextTable != null) {
                    current = operation.nextTable;
                    offset = current.opcodeOffset;
                    if (offset > 0) {
                        DecR();
                    }
                } else
                {
                    break;
                }

            }
        }

        public int GetIM() {
            return im;
        }

        public bool GetIFF1() {
            return iff1;
        }

        public bool GetIFF2()
        {
            return iff2;
        }

        public void SetDisassembleMode(DisassembleMode mode) {
            dasmMode = mode;
        }

        // Disassemble(ushort addr) disassembles a single CPU operation
        // based at addr and puts it into result variable. Returns the addr
        // of the next instruction
        //
        public ushort Disassemble(ushort addr, out string result) {
            ushort start = addr;
            byte opCode;
            int offset = 0;
            OpcodeTableEntry operation;
            OpcodeTable current = opcodeTable;

            while (true)
            {
                opCode = memory.Read8((ushort)(addr + offset));
                addr++;

                operation = current.entries[opCode];
                if (operation == null)
                {
                    result = string.Format("Error disassembling at 0x{0:X4}", start);
                    return addr;
                }

                if (operation.func != null)
                {
                    addr = (ushort)(addr - offset);
                    object[] args = new object[operation.args.Length];
                    for (int j = 0; j < operation.args.Length; j++)
                    {
                        var argType = operation.args[j];
                        switch (argType)
                        {
                            case ArgType.Byte:
                                byte value = Read8(addr++);
                                if (dasmMode == DisassembleMode.Dec)
                                {
                                    args[j] = value;
                                }
                                else
                                {
                                    args[j] = string.Format("${0:X2}", value);
                                }
                                break;
                            case ArgType.Word:
                                ushort value16 = Read16(addr);
                                addr += 2;
                                if (dasmMode == DisassembleMode.Dec)
                                {
                                    args[j] = value16;
                                }
                                else
                                {
                                    args[j] = string.Format("${0:X4}", value16);
                                }
                                break;
                            case ArgType.Offset:
                                var idxOffset = (SByte)Read8(addr++);
                                string offFormat;
                                if (idxOffset >= 0)
                                {
                                    offFormat = "+{0}";

                                }
                                else
                                {
                                    offFormat = "{0}";
                                }
                                args[j] = string.Format(offFormat, idxOffset);
                                break;
                        }
                    }
                    addr = (ushort)(addr + offset);
                    result = string.Format(operation.dasm, args);
                    return addr;
                }

                if (operation.nextTable != null)
                {
                    current = operation.nextTable;
                    offset = current.opcodeOffset;
                } else
                {
                    break;
                }
            }
            result = "Disassembler logic error";
            return addr;
        }
    }
}
