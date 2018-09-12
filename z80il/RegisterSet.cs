using System.Runtime.InteropServices;

namespace Z80
{
    [StructLayout(LayoutKind.Explicit)]
    public struct RegisterSet
    {
        [FieldOffset(0)]
        public byte f;
        [FieldOffset(1)]
        public byte a;
        [FieldOffset(2)]
        public byte c;
        [FieldOffset(3)]
        public byte b;
        [FieldOffset(4)]
        public byte e;
        [FieldOffset(5)]
        public byte d;
        [FieldOffset(6)]
        public byte l;
        [FieldOffset(7)]
        public byte h;
        [FieldOffset(8)]
        public byte ixl;
        [FieldOffset(9)]
        public byte ixh;
        [FieldOffset(10)]
        public byte iyl;
        [FieldOffset(11)]
        public byte iyh;

        [FieldOffset(0)]
        public ushort af;
        [FieldOffset(2)]
        public ushort bc;
        [FieldOffset(4)]
        public ushort de;
        [FieldOffset(6)]
        public ushort hl;
        [FieldOffset(8)]
        public ushort ix;
        [FieldOffset(10)]
        public ushort iy;
        [FieldOffset(12)]
        public ushort sp;
    }
}
