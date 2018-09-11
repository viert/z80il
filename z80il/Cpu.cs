using System;

namespace Z80 {
    public class Cpu: BaseCpu {

        public Cpu(IMemory mem) : base(mem) {
            
        }

        protected override void CreateTables() {
            base.CreateTables();

            // LD r, r'
            opcodeTable.entries[64] = new OpcodeTableEntry(ld_b_b, "ld b, b", new ArgType[0]);
            opcodeTable.entries[65] = new OpcodeTableEntry(ld_b_c, "ld b, c", new ArgType[0]);
            opcodeTable.entries[66] = new OpcodeTableEntry(ld_b_d, "ld b, d", new ArgType[0]);
            opcodeTable.entries[67] = new OpcodeTableEntry(ld_b_e, "ld b, e", new ArgType[0]);
            opcodeTable.entries[68] = new OpcodeTableEntry(ld_b_h, "ld b, h", new ArgType[0]);
            opcodeTable.entries[69] = new OpcodeTableEntry(ld_b_l, "ld b, l", new ArgType[0]);
            opcodeTable.entries[71] = new OpcodeTableEntry(ld_b_a, "ld b, a", new ArgType[0]);
            opcodeTable.entries[72] = new OpcodeTableEntry(ld_c_b, "ld c, b", new ArgType[0]);
            opcodeTable.entries[73] = new OpcodeTableEntry(ld_c_c, "ld c, c", new ArgType[0]);
            opcodeTable.entries[74] = new OpcodeTableEntry(ld_c_d, "ld c, d", new ArgType[0]);
            opcodeTable.entries[75] = new OpcodeTableEntry(ld_c_e, "ld c, e", new ArgType[0]);
            opcodeTable.entries[76] = new OpcodeTableEntry(ld_c_h, "ld c, h", new ArgType[0]);
            opcodeTable.entries[77] = new OpcodeTableEntry(ld_c_l, "ld c, l", new ArgType[0]);
            opcodeTable.entries[79] = new OpcodeTableEntry(ld_c_a, "ld c, a", new ArgType[0]);
            opcodeTable.entries[80] = new OpcodeTableEntry(ld_d_b, "ld d, b", new ArgType[0]);
            opcodeTable.entries[81] = new OpcodeTableEntry(ld_d_c, "ld d, c", new ArgType[0]);
            opcodeTable.entries[82] = new OpcodeTableEntry(ld_d_d, "ld d, d", new ArgType[0]);
            opcodeTable.entries[83] = new OpcodeTableEntry(ld_d_e, "ld d, e", new ArgType[0]);
            opcodeTable.entries[84] = new OpcodeTableEntry(ld_d_h, "ld d, h", new ArgType[0]);
            opcodeTable.entries[85] = new OpcodeTableEntry(ld_d_l, "ld d, l", new ArgType[0]);
            opcodeTable.entries[87] = new OpcodeTableEntry(ld_d_a, "ld d, a", new ArgType[0]);
            opcodeTable.entries[88] = new OpcodeTableEntry(ld_e_b, "ld e, b", new ArgType[0]);
            opcodeTable.entries[89] = new OpcodeTableEntry(ld_e_c, "ld e, c", new ArgType[0]);
            opcodeTable.entries[90] = new OpcodeTableEntry(ld_e_d, "ld e, d", new ArgType[0]);
            opcodeTable.entries[91] = new OpcodeTableEntry(ld_e_e, "ld e, e", new ArgType[0]);
            opcodeTable.entries[92] = new OpcodeTableEntry(ld_e_h, "ld e, h", new ArgType[0]);
            opcodeTable.entries[93] = new OpcodeTableEntry(ld_e_l, "ld e, l", new ArgType[0]);
            opcodeTable.entries[95] = new OpcodeTableEntry(ld_e_a, "ld e, a", new ArgType[0]);
            opcodeTable.entries[96] = new OpcodeTableEntry(ld_h_b, "ld h, b", new ArgType[0]);
            opcodeTable.entries[97] = new OpcodeTableEntry(ld_h_c, "ld h, c", new ArgType[0]);
            opcodeTable.entries[98] = new OpcodeTableEntry(ld_h_d, "ld h, d", new ArgType[0]);
            opcodeTable.entries[99] = new OpcodeTableEntry(ld_h_e, "ld h, e", new ArgType[0]);
            opcodeTable.entries[100] = new OpcodeTableEntry(ld_h_h, "ld h, h", new ArgType[0]);
            opcodeTable.entries[101] = new OpcodeTableEntry(ld_h_l, "ld h, l", new ArgType[0]);
            opcodeTable.entries[103] = new OpcodeTableEntry(ld_h_a, "ld h, a", new ArgType[0]);
            opcodeTable.entries[104] = new OpcodeTableEntry(ld_l_b, "ld l, b", new ArgType[0]);
            opcodeTable.entries[105] = new OpcodeTableEntry(ld_l_c, "ld l, c", new ArgType[0]);
            opcodeTable.entries[106] = new OpcodeTableEntry(ld_l_d, "ld l, d", new ArgType[0]);
            opcodeTable.entries[107] = new OpcodeTableEntry(ld_l_e, "ld l, e", new ArgType[0]);
            opcodeTable.entries[108] = new OpcodeTableEntry(ld_l_h, "ld l, h", new ArgType[0]);
            opcodeTable.entries[109] = new OpcodeTableEntry(ld_l_l, "ld l, l", new ArgType[0]);
            opcodeTable.entries[111] = new OpcodeTableEntry(ld_l_a, "ld l, a", new ArgType[0]);
            opcodeTable.entries[120] = new OpcodeTableEntry(ld_a_b, "ld a, b", new ArgType[0]);
            opcodeTable.entries[121] = new OpcodeTableEntry(ld_a_c, "ld a, c", new ArgType[0]);
            opcodeTable.entries[122] = new OpcodeTableEntry(ld_a_d, "ld a, d", new ArgType[0]);
            opcodeTable.entries[123] = new OpcodeTableEntry(ld_a_e, "ld a, e", new ArgType[0]);
            opcodeTable.entries[124] = new OpcodeTableEntry(ld_a_h, "ld a, h", new ArgType[0]);
            opcodeTable.entries[125] = new OpcodeTableEntry(ld_a_l, "ld a, l", new ArgType[0]);
            opcodeTable.entries[127] = new OpcodeTableEntry(ld_a_a, "ld a, a", new ArgType[0]);
 
        }

        protected void ld_a_a() {
        }

        protected void ld_a_b() {
            r1.a = r1.b;
        }

        protected void ld_a_c() {
            r1.a = r1.c;
        }

        protected void ld_a_d() {
            r1.a = r1.d;
        }

        protected void ld_a_e() {
            r1.a = r1.e;
        }

        protected void ld_a_h() {
            r1.a = r1.h;
        }

        protected void ld_a_l() {
            r1.a = r1.l;
        }

        protected void ld_a_ixh() {
            r1.a = r1.ixh;
        }

        protected void ld_a_ixl() {
            r1.a = r1.ixl;
        }

        protected void ld_a_iyh() {
            r1.a = r1.iyh;
        }

        protected void ld_a_iyl() {
            r1.a = r1.iyl;
        }

        protected void ld_b_a() {
            r1.b = r1.a;
        }

        protected void ld_b_b() {
        }

        protected void ld_b_c() {
            r1.b = r1.c;
        }

        protected void ld_b_d() {
            r1.b = r1.d;
        }

        protected void ld_b_e() {
            r1.b = r1.e;
        }

        protected void ld_b_h() {
            r1.b = r1.h;
        }

        protected void ld_b_l() {
            r1.b = r1.l;
        }

        protected void ld_b_ixh() {
            r1.b = r1.ixh;
        }

        protected void ld_b_ixl() {
            r1.b = r1.ixl;
        }

        protected void ld_b_iyh() {
            r1.b = r1.iyh;
        }

        protected void ld_b_iyl() {
            r1.b = r1.iyl;
        }

        protected void ld_c_a() {
            r1.c = r1.a;
        }

        protected void ld_c_b() {
            r1.c = r1.b;
        }

        protected void ld_c_c() {
        }

        protected void ld_c_d() {
            r1.c = r1.d;
        }

        protected void ld_c_e() {
            r1.c = r1.e;
        }

        protected void ld_c_h() {
            r1.c = r1.h;
        }

        protected void ld_c_l() {
            r1.c = r1.l;
        }

        protected void ld_c_ixh() {
            r1.c = r1.ixh;
        }

        protected void ld_c_ixl() {
            r1.c = r1.ixl;
        }

        protected void ld_c_iyh() {
            r1.c = r1.iyh;
        }

        protected void ld_c_iyl() {
            r1.c = r1.iyl;
        }

        protected void ld_d_a() {
            r1.d = r1.a;
        }

        protected void ld_d_b() {
            r1.d = r1.b;
        }

        protected void ld_d_c() {
            r1.d = r1.c;
        }

        protected void ld_d_d() {
        }

        protected void ld_d_e() {
            r1.d = r1.e;
        }

        protected void ld_d_h() {
            r1.d = r1.h;
        }

        protected void ld_d_l() {
            r1.d = r1.l;
        }

        protected void ld_d_ixh() {
            r1.d = r1.ixh;
        }

        protected void ld_d_ixl() {
            r1.d = r1.ixl;
        }

        protected void ld_d_iyh() {
            r1.d = r1.iyh;
        }

        protected void ld_d_iyl() {
            r1.d = r1.iyl;
        }

        protected void ld_e_a() {
            r1.e = r1.a;
        }

        protected void ld_e_b() {
            r1.e = r1.b;
        }

        protected void ld_e_c() {
            r1.e = r1.c;
        }

        protected void ld_e_d() {
            r1.e = r1.d;
        }

        protected void ld_e_e() {
        }

        protected void ld_e_h() {
            r1.e = r1.h;
        }

        protected void ld_e_l() {
            r1.e = r1.l;
        }

        protected void ld_e_ixh() {
            r1.e = r1.ixh;
        }

        protected void ld_e_ixl() {
            r1.e = r1.ixl;
        }

        protected void ld_e_iyh() {
            r1.e = r1.iyh;
        }

        protected void ld_e_iyl() {
            r1.e = r1.iyl;
        }

        protected void ld_h_a() {
            r1.h = r1.a;
        }

        protected void ld_h_b() {
            r1.h = r1.b;
        }

        protected void ld_h_c() {
            r1.h = r1.c;
        }

        protected void ld_h_d() {
            r1.h = r1.d;
        }

        protected void ld_h_e() {
            r1.h = r1.e;
        }

        protected void ld_h_h() {
        }

        protected void ld_h_l() {
            r1.h = r1.l;
        }

        protected void ld_h_ixh() {
            r1.h = r1.ixh;
        }

        protected void ld_h_ixl() {
            r1.h = r1.ixl;
        }

        protected void ld_h_iyh() {
            r1.h = r1.iyh;
        }

        protected void ld_h_iyl() {
            r1.h = r1.iyl;
        }

        protected void ld_l_a() {
            r1.l = r1.a;
        }

        protected void ld_l_b() {
            r1.l = r1.b;
        }

        protected void ld_l_c() {
            r1.l = r1.c;
        }

        protected void ld_l_d() {
            r1.l = r1.d;
        }

        protected void ld_l_e() {
            r1.l = r1.e;
        }

        protected void ld_l_h() {
            r1.l = r1.h;
        }

        protected void ld_l_l() {
        }

        protected void ld_l_ixh() {
            r1.l = r1.ixh;
        }

        protected void ld_l_ixl() {
            r1.l = r1.ixl;
        }

        protected void ld_l_iyh() {
            r1.l = r1.iyh;
        }

        protected void ld_l_iyl() {
            r1.l = r1.iyl;
        }

        protected void ld_ixh_a() {
            r1.ixh = r1.a;
        }

        protected void ld_ixh_b() {
            r1.ixh = r1.b;
        }

        protected void ld_ixh_c() {
            r1.ixh = r1.c;
        }

        protected void ld_ixh_d() {
            r1.ixh = r1.d;
        }

        protected void ld_ixh_e() {
            r1.ixh = r1.e;
        }

        protected void ld_ixh_h() {
            r1.ixh = r1.h;
        }

        protected void ld_ixh_l() {
            r1.ixh = r1.l;
        }

        protected void ld_ixh_ixh() {
        }

        protected void ld_ixh_ixl() {
            r1.ixh = r1.ixl;
        }

        protected void ld_ixh_iyh() {
            r1.ixh = r1.iyh;
        }

        protected void ld_ixh_iyl() {
            r1.ixh = r1.iyl;
        }

        protected void ld_ixl_a() {
            r1.ixl = r1.a;
        }

        protected void ld_ixl_b() {
            r1.ixl = r1.b;
        }

        protected void ld_ixl_c() {
            r1.ixl = r1.c;
        }

        protected void ld_ixl_d() {
            r1.ixl = r1.d;
        }

        protected void ld_ixl_e() {
            r1.ixl = r1.e;
        }

        protected void ld_ixl_h() {
            r1.ixl = r1.h;
        }

        protected void ld_ixl_l() {
            r1.ixl = r1.l;
        }

        protected void ld_ixl_ixh() {
            r1.ixl = r1.ixh;
        }

        protected void ld_ixl_ixl() {
        }

        protected void ld_ixl_iyh() {
            r1.ixl = r1.iyh;
        }

        protected void ld_ixl_iyl() {
            r1.ixl = r1.iyl;
        }

        protected void ld_iyh_a() {
            r1.iyh = r1.a;
        }

        protected void ld_iyh_b() {
            r1.iyh = r1.b;
        }

        protected void ld_iyh_c() {
            r1.iyh = r1.c;
        }

        protected void ld_iyh_d() {
            r1.iyh = r1.d;
        }

        protected void ld_iyh_e() {
            r1.iyh = r1.e;
        }

        protected void ld_iyh_h() {
            r1.iyh = r1.h;
        }

        protected void ld_iyh_l() {
            r1.iyh = r1.l;
        }

        protected void ld_iyh_ixh() {
            r1.iyh = r1.ixh;
        }

        protected void ld_iyh_ixl() {
            r1.iyh = r1.ixl;
        }

        protected void ld_iyh_iyh() {
        }

        protected void ld_iyh_iyl() {
            r1.iyh = r1.iyl;
        }

        protected void ld_iyl_a() {
            r1.iyl = r1.a;
        }

        protected void ld_iyl_b() {
            r1.iyl = r1.b;
        }

        protected void ld_iyl_c() {
            r1.iyl = r1.c;
        }

        protected void ld_iyl_d() {
            r1.iyl = r1.d;
        }

        protected void ld_iyl_e() {
            r1.iyl = r1.e;
        }

        protected void ld_iyl_h() {
            r1.iyl = r1.h;
        }

        protected void ld_iyl_l() {
            r1.iyl = r1.l;
        }

        protected void ld_iyl_ixh() {
            r1.iyl = r1.ixh;
        }

        protected void ld_iyl_ixl() {
            r1.iyl = r1.ixl;
        }

        protected void ld_iyl_iyh() {
            r1.iyl = r1.iyh;
        }

        protected void ld_iyl_iyl() {
        }


    }
}