using System;

namespace Z80
{
    public enum ArgType { Byte, Word, Offset };

    public class OpcodeTableEntry {
        public Action func;
        public string dasm;
        public ArgType[] args;
        public OpcodeTable nextTable;

        public OpcodeTableEntry(Action f, string d, ArgType[] a, OpcodeTable nt = null) {
            func = f;
            dasm = d;
            args = a;
            nextTable = nt;
        }

    }

    public class OpcodeTable
    {
        public OpcodeTableEntry[] entries;
        public int opcodeOffset;

        public OpcodeTable(int offset = 0)
        {
            entries = new OpcodeTableEntry[256];
            opcodeOffset = offset;
        }
    }
}
