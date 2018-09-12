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

            // LD r, n
            opcodeTable.entries[6] = new OpcodeTableEntry(ld_b_n, "ld b, {0}", new ArgType[1]{ArgType.Byte});
            opcodeTable.entries[14] = new OpcodeTableEntry(ld_c_n, "ld c, {0}", new ArgType[1]{ArgType.Byte});
            opcodeTable.entries[22] = new OpcodeTableEntry(ld_d_n, "ld d, {0}", new ArgType[1]{ArgType.Byte});
            opcodeTable.entries[30] = new OpcodeTableEntry(ld_e_n, "ld e, {0}", new ArgType[1]{ArgType.Byte});
            opcodeTable.entries[38] = new OpcodeTableEntry(ld_h_n, "ld h, {0}", new ArgType[1]{ArgType.Byte});
            opcodeTable.entries[46] = new OpcodeTableEntry(ld_l_n, "ld l, {0}", new ArgType[1]{ArgType.Byte});
            opcodeTable.entries[62] = new OpcodeTableEntry(ld_a_n, "ld a, {0}", new ArgType[1]{ArgType.Byte});
            opcodeTableDD.entries[0x26] = new OpcodeTableEntry(ld_ixh_n, "ld ixh, {0}", new ArgType[1]{ArgType.Byte});
            opcodeTableDD.entries[0x2e] = new OpcodeTableEntry(ld_ixl_n, "ld ixl, {0}", new ArgType[1]{ArgType.Byte});
            opcodeTableFD.entries[0x26] = new OpcodeTableEntry(ld_iyh_n, "ld iyh, {0}", new ArgType[1]{ArgType.Byte});
            opcodeTableFD.entries[0x2e] = new OpcodeTableEntry(ld_iyl_n, "ld iyl, {0}", new ArgType[1]{ArgType.Byte});
            
            // LD r, (HL)
            opcodeTable.entries[70] = new OpcodeTableEntry(ld_b__hl_, "ld b, (hl)", new ArgType[0]);
            opcodeTable.entries[78] = new OpcodeTableEntry(ld_c__hl_, "ld c, (hl)", new ArgType[0]);
            opcodeTable.entries[86] = new OpcodeTableEntry(ld_d__hl_, "ld d, (hl)", new ArgType[0]);
            opcodeTable.entries[94] = new OpcodeTableEntry(ld_e__hl_, "ld e, (hl)", new ArgType[0]);
            opcodeTable.entries[102] = new OpcodeTableEntry(ld_h__hl_, "ld h, (hl)", new ArgType[0]);
            opcodeTable.entries[110] = new OpcodeTableEntry(ld_l__hl_, "ld l, (hl)", new ArgType[0]);
            opcodeTable.entries[126] = new OpcodeTableEntry(ld_a__hl_, "ld a, (hl)", new ArgType[0]);

            // LD (HL), r
            opcodeTable.entries[112] = new OpcodeTableEntry(ld__hl__b, "ld (hl), b", new ArgType[0]);
            opcodeTable.entries[113] = new OpcodeTableEntry(ld__hl__c, "ld (hl), c", new ArgType[0]);
            opcodeTable.entries[114] = new OpcodeTableEntry(ld__hl__d, "ld (hl), d", new ArgType[0]);
            opcodeTable.entries[115] = new OpcodeTableEntry(ld__hl__e, "ld (hl), e", new ArgType[0]);
            opcodeTable.entries[116] = new OpcodeTableEntry(ld__hl__h, "ld (hl), h", new ArgType[0]);
            opcodeTable.entries[117] = new OpcodeTableEntry(ld__hl__l, "ld (hl), l", new ArgType[0]);
            opcodeTable.entries[119] = new OpcodeTableEntry(ld__hl__a, "ld (hl), a", new ArgType[0]);

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


        protected void ld_a_n() {
            r1.a = Read8(pc++);
        }

        protected void ld_b_n() {
            r1.b = Read8(pc++);
        }

        protected void ld_c_n() {
            r1.c = Read8(pc++);
        }

        protected void ld_d_n() {
            r1.d = Read8(pc++);
        }

        protected void ld_e_n() {
            r1.e = Read8(pc++);
        }

        protected void ld_h_n() {
            r1.h = Read8(pc++);
        }

        protected void ld_l_n() {
            r1.l = Read8(pc++);
        }

        protected void ld_ixh_n() {
            r1.ixh = Read8(pc++);
        }

        protected void ld_ixl_n() {
            r1.ixl = Read8(pc++);
        }

        protected void ld_iyh_n() {
            r1.iyh = Read8(pc++);
        }

        protected void ld_iyl_n() {
            r1.iyl = Read8(pc++);
        }


        protected void ld_a__hl_() {
            r1.a = Read8(r1.hl);
        }

        protected void ld_b__hl_() {
            r1.b = Read8(r1.hl);
        }

        protected void ld_c__hl_() {
            r1.c = Read8(r1.hl);
        }

        protected void ld_d__hl_() {
            r1.d = Read8(r1.hl);
        }

        protected void ld_e__hl_() {
            r1.e = Read8(r1.hl);
        }

        protected void ld_h__hl_() {
            r1.h = Read8(r1.hl);
        }

        protected void ld_l__hl_() {
            r1.l = Read8(r1.hl);
        }


        protected void ld__hl__a() {
            Write8(r1.hl, r1.a);
        }

        protected void ld__hl__b() {
            Write8(r1.hl, r1.b);
        }

        protected void ld__hl__c() {
            Write8(r1.hl, r1.c);
        }

        protected void ld__hl__d() {
            Write8(r1.hl, r1.d);
        }

        protected void ld__hl__e() {
            Write8(r1.hl, r1.e);
        }

        protected void ld__hl__h() {
            Write8(r1.hl, r1.h);
        }

        protected void ld__hl__l() {
            Write8(r1.hl, r1.l);
        }


    }
}