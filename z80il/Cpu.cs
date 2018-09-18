using System;

namespace Z80 {
    public class Cpu: BaseCpu {

        public Cpu(IMemory mem, IPort port) : base(mem, port) {
            
        }

        protected override void CreateTables() {
            base.CreateTables();

            // LD r, r'
            opcodeTable.entries[64] = new OpcodeTableEntry(ld_b_b, "ld b, b", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[64] =
                new OpcodeTableEntry(ld_b_b, "ld b, b", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[64] =
                new OpcodeTableEntry(ld_b_b, "ld b, b", new ArgType[]{});
            opcodeTable.entries[65] = new OpcodeTableEntry(ld_b_c, "ld b, c", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[65] =
                new OpcodeTableEntry(ld_b_c, "ld b, c", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[65] =
                new OpcodeTableEntry(ld_b_c, "ld b, c", new ArgType[]{});
            opcodeTable.entries[66] = new OpcodeTableEntry(ld_b_d, "ld b, d", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[66] =
                new OpcodeTableEntry(ld_b_d, "ld b, d", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[66] =
                new OpcodeTableEntry(ld_b_d, "ld b, d", new ArgType[]{});
            opcodeTable.entries[67] = new OpcodeTableEntry(ld_b_e, "ld b, e", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[67] =
                new OpcodeTableEntry(ld_b_e, "ld b, e", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[67] =
                new OpcodeTableEntry(ld_b_e, "ld b, e", new ArgType[]{});
            opcodeTable.entries[68] = new OpcodeTableEntry(ld_b_h, "ld b, h", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[68] =
                new OpcodeTableEntry(ld_b_ixh, "ld b, ixh", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[68] =
                new OpcodeTableEntry(ld_b_iyh, "ld b, iyh", new ArgType[]{});
            opcodeTable.entries[69] = new OpcodeTableEntry(ld_b_l, "ld b, l", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[69] =
                new OpcodeTableEntry(ld_b_ixl, "ld b, ixl", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[69] =
                new OpcodeTableEntry(ld_b_iyl, "ld b, iyl", new ArgType[]{});
            opcodeTable.entries[71] = new OpcodeTableEntry(ld_b_a, "ld b, a", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[71] =
                new OpcodeTableEntry(ld_b_a, "ld b, a", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[71] =
                new OpcodeTableEntry(ld_b_a, "ld b, a", new ArgType[]{});
            opcodeTable.entries[72] = new OpcodeTableEntry(ld_c_b, "ld c, b", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[72] =
                new OpcodeTableEntry(ld_c_b, "ld c, b", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[72] =
                new OpcodeTableEntry(ld_c_b, "ld c, b", new ArgType[]{});
            opcodeTable.entries[73] = new OpcodeTableEntry(ld_c_c, "ld c, c", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[73] =
                new OpcodeTableEntry(ld_c_c, "ld c, c", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[73] =
                new OpcodeTableEntry(ld_c_c, "ld c, c", new ArgType[]{});
            opcodeTable.entries[74] = new OpcodeTableEntry(ld_c_d, "ld c, d", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[74] =
                new OpcodeTableEntry(ld_c_d, "ld c, d", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[74] =
                new OpcodeTableEntry(ld_c_d, "ld c, d", new ArgType[]{});
            opcodeTable.entries[75] = new OpcodeTableEntry(ld_c_e, "ld c, e", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[75] =
                new OpcodeTableEntry(ld_c_e, "ld c, e", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[75] =
                new OpcodeTableEntry(ld_c_e, "ld c, e", new ArgType[]{});
            opcodeTable.entries[76] = new OpcodeTableEntry(ld_c_h, "ld c, h", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[76] =
                new OpcodeTableEntry(ld_c_ixh, "ld c, ixh", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[76] =
                new OpcodeTableEntry(ld_c_iyh, "ld c, iyh", new ArgType[]{});
            opcodeTable.entries[77] = new OpcodeTableEntry(ld_c_l, "ld c, l", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[77] =
                new OpcodeTableEntry(ld_c_ixl, "ld c, ixl", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[77] =
                new OpcodeTableEntry(ld_c_iyl, "ld c, iyl", new ArgType[]{});
            opcodeTable.entries[79] = new OpcodeTableEntry(ld_c_a, "ld c, a", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[79] =
                new OpcodeTableEntry(ld_c_a, "ld c, a", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[79] =
                new OpcodeTableEntry(ld_c_a, "ld c, a", new ArgType[]{});
            opcodeTable.entries[80] = new OpcodeTableEntry(ld_d_b, "ld d, b", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[80] =
                new OpcodeTableEntry(ld_d_b, "ld d, b", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[80] =
                new OpcodeTableEntry(ld_d_b, "ld d, b", new ArgType[]{});
            opcodeTable.entries[81] = new OpcodeTableEntry(ld_d_c, "ld d, c", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[81] =
                new OpcodeTableEntry(ld_d_c, "ld d, c", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[81] =
                new OpcodeTableEntry(ld_d_c, "ld d, c", new ArgType[]{});
            opcodeTable.entries[82] = new OpcodeTableEntry(ld_d_d, "ld d, d", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[82] =
                new OpcodeTableEntry(ld_d_d, "ld d, d", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[82] =
                new OpcodeTableEntry(ld_d_d, "ld d, d", new ArgType[]{});
            opcodeTable.entries[83] = new OpcodeTableEntry(ld_d_e, "ld d, e", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[83] =
                new OpcodeTableEntry(ld_d_e, "ld d, e", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[83] =
                new OpcodeTableEntry(ld_d_e, "ld d, e", new ArgType[]{});
            opcodeTable.entries[84] = new OpcodeTableEntry(ld_d_h, "ld d, h", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[84] =
                new OpcodeTableEntry(ld_d_ixh, "ld d, ixh", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[84] =
                new OpcodeTableEntry(ld_d_iyh, "ld d, iyh", new ArgType[]{});
            opcodeTable.entries[85] = new OpcodeTableEntry(ld_d_l, "ld d, l", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[85] =
                new OpcodeTableEntry(ld_d_ixl, "ld d, ixl", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[85] =
                new OpcodeTableEntry(ld_d_iyl, "ld d, iyl", new ArgType[]{});
            opcodeTable.entries[87] = new OpcodeTableEntry(ld_d_a, "ld d, a", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[87] =
                new OpcodeTableEntry(ld_d_a, "ld d, a", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[87] =
                new OpcodeTableEntry(ld_d_a, "ld d, a", new ArgType[]{});
            opcodeTable.entries[88] = new OpcodeTableEntry(ld_e_b, "ld e, b", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[88] =
                new OpcodeTableEntry(ld_e_b, "ld e, b", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[88] =
                new OpcodeTableEntry(ld_e_b, "ld e, b", new ArgType[]{});
            opcodeTable.entries[89] = new OpcodeTableEntry(ld_e_c, "ld e, c", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[89] =
                new OpcodeTableEntry(ld_e_c, "ld e, c", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[89] =
                new OpcodeTableEntry(ld_e_c, "ld e, c", new ArgType[]{});
            opcodeTable.entries[90] = new OpcodeTableEntry(ld_e_d, "ld e, d", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[90] =
                new OpcodeTableEntry(ld_e_d, "ld e, d", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[90] =
                new OpcodeTableEntry(ld_e_d, "ld e, d", new ArgType[]{});
            opcodeTable.entries[91] = new OpcodeTableEntry(ld_e_e, "ld e, e", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[91] =
                new OpcodeTableEntry(ld_e_e, "ld e, e", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[91] =
                new OpcodeTableEntry(ld_e_e, "ld e, e", new ArgType[]{});
            opcodeTable.entries[92] = new OpcodeTableEntry(ld_e_h, "ld e, h", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[92] =
                new OpcodeTableEntry(ld_e_ixh, "ld e, ixh", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[92] =
                new OpcodeTableEntry(ld_e_iyh, "ld e, iyh", new ArgType[]{});
            opcodeTable.entries[93] = new OpcodeTableEntry(ld_e_l, "ld e, l", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[93] =
                new OpcodeTableEntry(ld_e_ixl, "ld e, ixl", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[93] =
                new OpcodeTableEntry(ld_e_iyl, "ld e, iyl", new ArgType[]{});
            opcodeTable.entries[95] = new OpcodeTableEntry(ld_e_a, "ld e, a", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[95] =
                new OpcodeTableEntry(ld_e_a, "ld e, a", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[95] =
                new OpcodeTableEntry(ld_e_a, "ld e, a", new ArgType[]{});
            opcodeTable.entries[96] = new OpcodeTableEntry(ld_h_b, "ld h, b", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[96] =
                new OpcodeTableEntry(ld_ixh_b, "ld ixh, b", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[96] =
                new OpcodeTableEntry(ld_iyh_b, "ld iyh, b", new ArgType[]{});
            opcodeTable.entries[97] = new OpcodeTableEntry(ld_h_c, "ld h, c", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[97] =
                new OpcodeTableEntry(ld_ixh_c, "ld ixh, c", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[97] =
                new OpcodeTableEntry(ld_iyh_c, "ld iyh, c", new ArgType[]{});
            opcodeTable.entries[98] = new OpcodeTableEntry(ld_h_d, "ld h, d", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[98] =
                new OpcodeTableEntry(ld_ixh_d, "ld ixh, d", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[98] =
                new OpcodeTableEntry(ld_iyh_d, "ld iyh, d", new ArgType[]{});
            opcodeTable.entries[99] = new OpcodeTableEntry(ld_h_e, "ld h, e", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[99] =
                new OpcodeTableEntry(ld_ixh_e, "ld ixh, e", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[99] =
                new OpcodeTableEntry(ld_iyh_e, "ld iyh, e", new ArgType[]{});
            opcodeTable.entries[100] = new OpcodeTableEntry(ld_h_h, "ld h, h", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[100] =
                new OpcodeTableEntry(ld_ixh_ixh, "ld ixh, ixh", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[100] =
                new OpcodeTableEntry(ld_iyh_iyh, "ld iyh, iyh", new ArgType[]{});
            opcodeTable.entries[101] = new OpcodeTableEntry(ld_h_l, "ld h, l", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[101] =
                new OpcodeTableEntry(ld_ixh_ixl, "ld ixh, ixl", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[101] =
                new OpcodeTableEntry(ld_iyh_iyl, "ld iyh, iyl", new ArgType[]{});
            opcodeTable.entries[103] = new OpcodeTableEntry(ld_h_a, "ld h, a", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[103] =
                new OpcodeTableEntry(ld_ixh_a, "ld ixh, a", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[103] =
                new OpcodeTableEntry(ld_iyh_a, "ld iyh, a", new ArgType[]{});
            opcodeTable.entries[104] = new OpcodeTableEntry(ld_l_b, "ld l, b", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[104] =
                new OpcodeTableEntry(ld_ixl_b, "ld ixl, b", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[104] =
                new OpcodeTableEntry(ld_iyl_b, "ld iyl, b", new ArgType[]{});
            opcodeTable.entries[105] = new OpcodeTableEntry(ld_l_c, "ld l, c", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[105] =
                new OpcodeTableEntry(ld_ixl_c, "ld ixl, c", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[105] =
                new OpcodeTableEntry(ld_iyl_c, "ld iyl, c", new ArgType[]{});
            opcodeTable.entries[106] = new OpcodeTableEntry(ld_l_d, "ld l, d", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[106] =
                new OpcodeTableEntry(ld_ixl_d, "ld ixl, d", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[106] =
                new OpcodeTableEntry(ld_iyl_d, "ld iyl, d", new ArgType[]{});
            opcodeTable.entries[107] = new OpcodeTableEntry(ld_l_e, "ld l, e", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[107] =
                new OpcodeTableEntry(ld_ixl_e, "ld ixl, e", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[107] =
                new OpcodeTableEntry(ld_iyl_e, "ld iyl, e", new ArgType[]{});
            opcodeTable.entries[108] = new OpcodeTableEntry(ld_l_h, "ld l, h", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[108] =
                new OpcodeTableEntry(ld_ixl_ixh, "ld ixl, ixh", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[108] =
                new OpcodeTableEntry(ld_iyl_iyh, "ld iyl, iyh", new ArgType[]{});
            opcodeTable.entries[109] = new OpcodeTableEntry(ld_l_l, "ld l, l", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[109] =
                new OpcodeTableEntry(ld_ixl_ixl, "ld ixl, ixl", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[109] =
                new OpcodeTableEntry(ld_iyl_iyl, "ld iyl, iyl", new ArgType[]{});
            opcodeTable.entries[111] = new OpcodeTableEntry(ld_l_a, "ld l, a", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[111] =
                new OpcodeTableEntry(ld_ixl_a, "ld ixl, a", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[111] =
                new OpcodeTableEntry(ld_iyl_a, "ld iyl, a", new ArgType[]{});
            opcodeTable.entries[120] = new OpcodeTableEntry(ld_a_b, "ld a, b", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[120] =
                new OpcodeTableEntry(ld_a_b, "ld a, b", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[120] =
                new OpcodeTableEntry(ld_a_b, "ld a, b", new ArgType[]{});
            opcodeTable.entries[121] = new OpcodeTableEntry(ld_a_c, "ld a, c", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[121] =
                new OpcodeTableEntry(ld_a_c, "ld a, c", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[121] =
                new OpcodeTableEntry(ld_a_c, "ld a, c", new ArgType[]{});
            opcodeTable.entries[122] = new OpcodeTableEntry(ld_a_d, "ld a, d", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[122] =
                new OpcodeTableEntry(ld_a_d, "ld a, d", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[122] =
                new OpcodeTableEntry(ld_a_d, "ld a, d", new ArgType[]{});
            opcodeTable.entries[123] = new OpcodeTableEntry(ld_a_e, "ld a, e", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[123] =
                new OpcodeTableEntry(ld_a_e, "ld a, e", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[123] =
                new OpcodeTableEntry(ld_a_e, "ld a, e", new ArgType[]{});
            opcodeTable.entries[124] = new OpcodeTableEntry(ld_a_h, "ld a, h", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[124] =
                new OpcodeTableEntry(ld_a_ixh, "ld a, ixh", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[124] =
                new OpcodeTableEntry(ld_a_iyh, "ld a, iyh", new ArgType[]{});
            opcodeTable.entries[125] = new OpcodeTableEntry(ld_a_l, "ld a, l", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[125] =
                new OpcodeTableEntry(ld_a_ixl, "ld a, ixl", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[125] =
                new OpcodeTableEntry(ld_a_iyl, "ld a, iyl", new ArgType[]{});
            opcodeTable.entries[127] = new OpcodeTableEntry(ld_a_a, "ld a, a", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[127] =
                new OpcodeTableEntry(ld_a_a, "ld a, a", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[127] =
                new OpcodeTableEntry(ld_a_a, "ld a, a", new ArgType[]{});
            // NOP
            opcodeTable.entries[0x00] = new OpcodeTableEntry(nop, "nop", new ArgType[]{});

            // LD r, n
            opcodeTable.entries[6] = new OpcodeTableEntry(ld_b_n, "ld b, {0}", new ArgType[]{ArgType.Byte});
            opcodeTable.entries[14] = new OpcodeTableEntry(ld_c_n, "ld c, {0}", new ArgType[]{ArgType.Byte});
            opcodeTable.entries[22] = new OpcodeTableEntry(ld_d_n, "ld d, {0}", new ArgType[]{ArgType.Byte});
            opcodeTable.entries[30] = new OpcodeTableEntry(ld_e_n, "ld e, {0}", new ArgType[]{ArgType.Byte});
            opcodeTable.entries[38] = new OpcodeTableEntry(ld_h_n, "ld h, {0}", new ArgType[]{ArgType.Byte});
            opcodeTable.entries[46] = new OpcodeTableEntry(ld_l_n, "ld l, {0}", new ArgType[]{ArgType.Byte});
            opcodeTable.entries[62] = new OpcodeTableEntry(ld_a_n, "ld a, {0}", new ArgType[]{ArgType.Byte});
            opcodeTableDD.entries[0x26] = new OpcodeTableEntry(ld_ixh_n, "ld ixh, {0}", new ArgType[]{ArgType.Byte});
            opcodeTableDD.entries[0x2e] = new OpcodeTableEntry(ld_ixl_n, "ld ixl, {0}", new ArgType[]{ArgType.Byte});
            opcodeTableFD.entries[0x26] = new OpcodeTableEntry(ld_iyh_n, "ld iyh, {0}", new ArgType[]{ArgType.Byte});
            opcodeTableFD.entries[0x2e] = new OpcodeTableEntry(ld_iyl_n, "ld iyl, {0}", new ArgType[]{ArgType.Byte});
            
            // LD r, (HL)
            opcodeTable.entries[70] = new OpcodeTableEntry(ld_b__hl_, "ld b, (hl)", new ArgType[]{});
            opcodeTable.entries[78] = new OpcodeTableEntry(ld_c__hl_, "ld c, (hl)", new ArgType[]{});
            opcodeTable.entries[86] = new OpcodeTableEntry(ld_d__hl_, "ld d, (hl)", new ArgType[]{});
            opcodeTable.entries[94] = new OpcodeTableEntry(ld_e__hl_, "ld e, (hl)", new ArgType[]{});
            opcodeTable.entries[102] = new OpcodeTableEntry(ld_h__hl_, "ld h, (hl)", new ArgType[]{});
            opcodeTable.entries[110] = new OpcodeTableEntry(ld_l__hl_, "ld l, (hl)", new ArgType[]{});
            opcodeTable.entries[126] = new OpcodeTableEntry(ld_a__hl_, "ld a, (hl)", new ArgType[]{});

            // LD (HL), r
            opcodeTable.entries[112] = new OpcodeTableEntry(ld__hl__b, "ld (hl), b", new ArgType[]{});
            opcodeTable.entries[113] = new OpcodeTableEntry(ld__hl__c, "ld (hl), c", new ArgType[]{});
            opcodeTable.entries[114] = new OpcodeTableEntry(ld__hl__d, "ld (hl), d", new ArgType[]{});
            opcodeTable.entries[115] = new OpcodeTableEntry(ld__hl__e, "ld (hl), e", new ArgType[]{});
            opcodeTable.entries[116] = new OpcodeTableEntry(ld__hl__h, "ld (hl), h", new ArgType[]{});
            opcodeTable.entries[117] = new OpcodeTableEntry(ld__hl__l, "ld (hl), l", new ArgType[]{});
            opcodeTable.entries[119] = new OpcodeTableEntry(ld__hl__a, "ld (hl), a", new ArgType[]{});
            opcodeTable.entries[0x36] = new OpcodeTableEntry(ld__hl__n, "ld (hl), {0}", new ArgType[]{ArgType.Byte});
            
            // LD (DE/BC), A; LD A, (DE/BC)
            opcodeTable.entries[0x0A] = new OpcodeTableEntry(ld_a__bc_, "ld a, (bc)", new ArgType[]{});
            opcodeTable.entries[0x1A] = new OpcodeTableEntry(ld_a__de_, "ld a, (de)", new ArgType[]{});
            opcodeTable.entries[0x02] = new OpcodeTableEntry(ld__bc__a, "ld (bc), a", new ArgType[]{});
            opcodeTable.entries[0x12] = new OpcodeTableEntry(ld__de__a, "ld (de), a", new ArgType[]{});
            
            // LD A, (nn); LD (nn), A
            opcodeTable.entries[0x3A] = new OpcodeTableEntry(ld_a__nn_, "ld a, ({0})", new ArgType[]{ArgType.Word});
            opcodeTable.entries[0x32] = new OpcodeTableEntry(ld__nn__a, "ld ({0}), a", new ArgType[]{ArgType.Word});
            
            // LD A, R/I; LD R/I, A
            opcodeTableED.entries[0x57] = new OpcodeTableEntry(ld_a_i, "ld a, i", new ArgType[]{});
            opcodeTableED.entries[0x5F] = new OpcodeTableEntry(ld_a_r, "ld a, r", new ArgType[]{});
            opcodeTableED.entries[0x47] = new OpcodeTableEntry(ld_i_a, "ld i, a", new ArgType[]{});
            opcodeTableED.entries[0x4F] = new OpcodeTableEntry(ld_r_a, "ld r, a", new ArgType[]{});
            
            // Indexed 8 bit load
            opcodeTable.entries[221].nextTable.entries[70] = 
                new OpcodeTableEntry(ld_b__ix_d_, "ld b, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[70] = 
                new OpcodeTableEntry(ld_b__iy_d_, "ld b, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[78] = 
                new OpcodeTableEntry(ld_c__ix_d_, "ld c, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[78] = 
                new OpcodeTableEntry(ld_c__iy_d_, "ld c, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[86] = 
                new OpcodeTableEntry(ld_d__ix_d_, "ld d, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[86] = 
                new OpcodeTableEntry(ld_d__iy_d_, "ld d, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[94] = 
                new OpcodeTableEntry(ld_e__ix_d_, "ld e, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[94] = 
                new OpcodeTableEntry(ld_e__iy_d_, "ld e, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[102] = 
                new OpcodeTableEntry(ld_h__ix_d_, "ld h, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[102] = 
                new OpcodeTableEntry(ld_h__iy_d_, "ld h, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[110] = 
                new OpcodeTableEntry(ld_l__ix_d_, "ld l, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[110] = 
                new OpcodeTableEntry(ld_l__iy_d_, "ld l, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[126] = 
                new OpcodeTableEntry(ld_a__ix_d_, "ld a, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[126] = 
                new OpcodeTableEntry(ld_a__iy_d_, "ld a, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[112] = 
                new OpcodeTableEntry(ld__ix_d__b, "ld (ix{0}), b", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[112] = 
                new OpcodeTableEntry(ld__iy_d__b, "ld (iy{0}), b", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[113] = 
                new OpcodeTableEntry(ld__ix_d__c, "ld (ix{0}), c", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[113] = 
                new OpcodeTableEntry(ld__iy_d__c, "ld (iy{0}), c", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[114] = 
                new OpcodeTableEntry(ld__ix_d__d, "ld (ix{0}), d", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[114] = 
                new OpcodeTableEntry(ld__iy_d__d, "ld (iy{0}), d", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[115] = 
                new OpcodeTableEntry(ld__ix_d__e, "ld (ix{0}), e", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[115] = 
                new OpcodeTableEntry(ld__iy_d__e, "ld (iy{0}), e", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[116] = 
                new OpcodeTableEntry(ld__ix_d__h, "ld (ix{0}), h", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[116] = 
                new OpcodeTableEntry(ld__iy_d__h, "ld (iy{0}), h", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[117] = 
                new OpcodeTableEntry(ld__ix_d__l, "ld (ix{0}), l", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[117] = 
                new OpcodeTableEntry(ld__iy_d__l, "ld (iy{0}), l", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[119] = 
                new OpcodeTableEntry(ld__ix_d__a, "ld (ix{0}), a", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[119] = 
                new OpcodeTableEntry(ld__iy_d__a, "ld (iy{0}), a", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0x36] =
                new OpcodeTableEntry(ld__ix_d__n, "ld (ix{0}), {1}", new ArgType[]{ArgType.Offset, ArgType.Byte});
            opcodeTable.entries[253].nextTable.entries[0x36] =
                new OpcodeTableEntry(ld__iy_d__n, "ld (iy{0}), {1}", new ArgType[]{ArgType.Offset, ArgType.Byte});

            // LD dd, nn
            opcodeTable.entries[1] = new OpcodeTableEntry(ld_bc_nn, "ld bc, {0}", new ArgType[]{ArgType.Word});
            opcodeTable.entries[17] = new OpcodeTableEntry(ld_de_nn, "ld de, {0}", new ArgType[]{ArgType.Word});
            opcodeTable.entries[33] = new OpcodeTableEntry(ld_hl_nn, "ld hl, {0}", new ArgType[]{ArgType.Word});
            opcodeTable.entries[49] = new OpcodeTableEntry(ld_sp_nn, "ld sp, {0}", new ArgType[]{ArgType.Word});

            opcodeTable.entries[221].nextTable.entries[0x21] =
                new OpcodeTableEntry(ld_ix_nn, "ld ix, {0}", new ArgType[]{ArgType.Word});
            opcodeTable.entries[253].nextTable.entries[0x21] =
                new OpcodeTableEntry(ld_iy_nn, "ld iy, {0}", new ArgType[]{ArgType.Word});

            // LD dd, (nn)
            opcodeTableED.entries[75] = new OpcodeTableEntry(ld_bc__nn_, "ld bc, ({0})", new ArgType[]{ArgType.Word});
            opcodeTableED.entries[91] = new OpcodeTableEntry(ld_de__nn_, "ld de, ({0})", new ArgType[]{ArgType.Word});
            opcodeTableED.entries[107] = new OpcodeTableEntry(ld_hl__nn_, "ld hl, ({0})", new ArgType[]{ArgType.Word});
            opcodeTableED.entries[123] = new OpcodeTableEntry(ld_sp__nn_, "ld sp, ({0})", new ArgType[]{ArgType.Word});

            opcodeTable.entries[0x2A] = new OpcodeTableEntry(ld_hl__nn_, "ld hl, ({0})", new ArgType[]{ArgType.Word});
            opcodeTable.entries[221].nextTable.entries[0x2A] =
                new OpcodeTableEntry(ld_ix__nn_, "ld ix, ({0})", new ArgType[]{ArgType.Word});
            opcodeTable.entries[253].nextTable.entries[0x2A] =
                new OpcodeTableEntry(ld_iy__nn_, "ld iy, ({0})", new ArgType[]{ArgType.Word});

            // LD (nn), dd
            opcodeTableED.entries[67] = new OpcodeTableEntry(ld__nn__bc, "ld ({0}), bc", new ArgType[]{ArgType.Word});
            opcodeTableED.entries[83] = new OpcodeTableEntry(ld__nn__de, "ld ({0}), de", new ArgType[]{ArgType.Word});
            opcodeTableED.entries[99] = new OpcodeTableEntry(ld__nn__hl, "ld ({0}), hl", new ArgType[]{ArgType.Word});
            opcodeTableED.entries[115] = new OpcodeTableEntry(ld__nn__sp, "ld ({0}), sp", new ArgType[]{ArgType.Word});

            opcodeTable.entries[0x22] = new OpcodeTableEntry(ld__nn__hl, "ld ({0}), hl", new ArgType[]{ArgType.Word});
            opcodeTable.entries[221].nextTable.entries[0x22] =
                new OpcodeTableEntry(ld__nn__ix, "ld ({0}), ix", new ArgType[]{ArgType.Word});
            opcodeTable.entries[253].nextTable.entries[0x22] =
                new OpcodeTableEntry(ld__nn__iy, "ld ({0}), iy", new ArgType[]{ArgType.Word});
            opcodeTable.entries[0xF9] = new OpcodeTableEntry(ld_sp_hl, "ld sp, hl", new ArgType[]{});
            opcodeTableDD.entries[0xF9] = new OpcodeTableEntry(ld_sp_ix, "ld sp, ix", new ArgType[]{});
            opcodeTableFD.entries[0xF9] = new OpcodeTableEntry(ld_sp_iy, "ld sp, iy", new ArgType[]{});
            
            // PUSH qq / POP qq
            opcodeTable.entries[197] = new OpcodeTableEntry(push_bc, "push bc", new ArgType[]{});
            opcodeTable.entries[193] = new OpcodeTableEntry(pop_bc, "pop bc", new ArgType[]{});
            opcodeTable.entries[213] = new OpcodeTableEntry(push_de, "push de", new ArgType[]{});
            opcodeTable.entries[209] = new OpcodeTableEntry(pop_de, "pop de", new ArgType[]{});
            opcodeTable.entries[229] = new OpcodeTableEntry(push_hl, "push hl", new ArgType[]{});
            opcodeTable.entries[225] = new OpcodeTableEntry(pop_hl, "pop hl", new ArgType[]{});
            opcodeTable.entries[245] = new OpcodeTableEntry(push_af, "push af", new ArgType[]{});
            opcodeTable.entries[241] = new OpcodeTableEntry(pop_af, "pop af", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[0xE5] =
                new OpcodeTableEntry(push_ix, "push ix", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[0xE1] =
                new OpcodeTableEntry(pop_ix, "pop ix", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[0xE5] =
                new OpcodeTableEntry(push_iy, "push iy", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[0xE1] =
                new OpcodeTableEntry(pop_iy, "pop iy", new ArgType[]{});
          
            // More stack ops  
            opcodeTable.entries[0xEB] = new OpcodeTableEntry(ex_de_hl, "ex de, hl", new ArgType[]{});
            opcodeTable.entries[0x08] = new OpcodeTableEntry(ex_af_af_, "ex af, af'", new ArgType[]{});
            opcodeTable.entries[0xD9] = new OpcodeTableEntry(exx, "exx", new ArgType[]{});
            opcodeTable.entries[0xE3] = new OpcodeTableEntry(ex__sp__hl, "ex (sp), hl", new ArgType[]{});
            opcodeTableDD.entries[0xE3] = new OpcodeTableEntry(ex__sp__ix, "ex (sp), ix", new ArgType[]{});
            opcodeTableFD.entries[0xE3] = new OpcodeTableEntry(ex__sp__iy, "ex (sp), iy", new ArgType[]{});
            
            // Block operations
            opcodeTableED.entries[0xA0] = new OpcodeTableEntry(ldi, "ldi", new ArgType[] { });
            opcodeTableED.entries[0xB0] = new OpcodeTableEntry(ldir, "ldir", new ArgType[] { });
            opcodeTableED.entries[0xA8] = new OpcodeTableEntry(ldd, "ldd", new ArgType[] { });
            opcodeTableED.entries[0xB8] = new OpcodeTableEntry(lddr, "lddr", new ArgType[] { });
            opcodeTableED.entries[0xA1] = new OpcodeTableEntry(cpi, "cpi", new ArgType[] { });
            opcodeTableED.entries[0xB1] = new OpcodeTableEntry(cpir, "cpir", new ArgType[] { });
            opcodeTableED.entries[0xA9] = new OpcodeTableEntry(cpd, "cpd", new ArgType[] { });
            opcodeTableED.entries[0xB9] = new OpcodeTableEntry(cpdr, "cpdr", new ArgType[] { });
            opcodeTable.entries[128] = new OpcodeTableEntry(add_a_b, "add a, b", new ArgType[]{}); 
            opcodeTable.entries[136] = new OpcodeTableEntry(adc_a_b, "adc a, b", new ArgType[]{}); 
            opcodeTable.entries[144] = new OpcodeTableEntry(sub_a_b, "sub b", new ArgType[]{}); 
            opcodeTable.entries[152] = new OpcodeTableEntry(sbc_a_b, "sbc a, b", new ArgType[]{}); 
            opcodeTable.entries[129] = new OpcodeTableEntry(add_a_c, "add a, c", new ArgType[]{}); 
            opcodeTable.entries[137] = new OpcodeTableEntry(adc_a_c, "adc a, c", new ArgType[]{}); 
            opcodeTable.entries[145] = new OpcodeTableEntry(sub_a_c, "sub c", new ArgType[]{}); 
            opcodeTable.entries[153] = new OpcodeTableEntry(sbc_a_c, "sbc a, c", new ArgType[]{}); 
            opcodeTable.entries[130] = new OpcodeTableEntry(add_a_d, "add a, d", new ArgType[]{}); 
            opcodeTable.entries[138] = new OpcodeTableEntry(adc_a_d, "adc a, d", new ArgType[]{}); 
            opcodeTable.entries[146] = new OpcodeTableEntry(sub_a_d, "sub d", new ArgType[]{}); 
            opcodeTable.entries[154] = new OpcodeTableEntry(sbc_a_d, "sbc a, d", new ArgType[]{}); 
            opcodeTable.entries[131] = new OpcodeTableEntry(add_a_e, "add a, e", new ArgType[]{}); 
            opcodeTable.entries[139] = new OpcodeTableEntry(adc_a_e, "adc a, e", new ArgType[]{}); 
            opcodeTable.entries[147] = new OpcodeTableEntry(sub_a_e, "sub e", new ArgType[]{}); 
            opcodeTable.entries[155] = new OpcodeTableEntry(sbc_a_e, "sbc a, e", new ArgType[]{}); 
            opcodeTable.entries[132] = new OpcodeTableEntry(add_a_h, "add a, h", new ArgType[]{}); 
            opcodeTable.entries[140] = new OpcodeTableEntry(adc_a_h, "adc a, h", new ArgType[]{}); 
            opcodeTable.entries[148] = new OpcodeTableEntry(sub_a_h, "sub h", new ArgType[]{}); 
            opcodeTable.entries[156] = new OpcodeTableEntry(sbc_a_h, "sbc a, h", new ArgType[]{}); 
            opcodeTable.entries[133] = new OpcodeTableEntry(add_a_l, "add a, l", new ArgType[]{}); 
            opcodeTable.entries[141] = new OpcodeTableEntry(adc_a_l, "adc a, l", new ArgType[]{}); 
            opcodeTable.entries[149] = new OpcodeTableEntry(sub_a_l, "sub l", new ArgType[]{}); 
            opcodeTable.entries[157] = new OpcodeTableEntry(sbc_a_l, "sbc a, l", new ArgType[]{}); 
            opcodeTable.entries[135] = new OpcodeTableEntry(add_a_a, "add a, a", new ArgType[]{}); 
            opcodeTable.entries[143] = new OpcodeTableEntry(adc_a_a, "adc a, a", new ArgType[]{}); 
            opcodeTable.entries[151] = new OpcodeTableEntry(sub_a_a, "sub a", new ArgType[]{}); 
            opcodeTable.entries[159] = new OpcodeTableEntry(sbc_a_a, "sbc a, a", new ArgType[]{}); 
            
            opcodeTableDD.entries[0x84] = new OpcodeTableEntry(add_a_ixh, "add a, ixh", new ArgType[]{});
            opcodeTableDD.entries[0x85] = new OpcodeTableEntry(add_a_ixl, "add a, ixl", new ArgType[]{});
            opcodeTableFD.entries[0x84] = new OpcodeTableEntry(add_a_iyh, "add a, iyh", new ArgType[]{});
            opcodeTableFD.entries[0x85] = new OpcodeTableEntry(add_a_iyl, "add a, iyl", new ArgType[]{});
            
            opcodeTableDD.entries[0x8C] = new OpcodeTableEntry(adc_a_ixh, "adc a, ixh", new ArgType[]{});
            opcodeTableDD.entries[0x8D] = new OpcodeTableEntry(adc_a_ixl, "adc a, ixl", new ArgType[]{});
            opcodeTableFD.entries[0x8C] = new OpcodeTableEntry(adc_a_iyh, "adc a, iyh", new ArgType[]{});
            opcodeTableFD.entries[0x8D] = new OpcodeTableEntry(adc_a_iyl, "adc a, iyl", new ArgType[]{});

            opcodeTableDD.entries[0x94] = new OpcodeTableEntry(sub_a_ixh, "sub ixh", new ArgType[]{});
            opcodeTableDD.entries[0x95] = new OpcodeTableEntry(sub_a_ixl, "sub ixl", new ArgType[]{});
            opcodeTableFD.entries[0x94] = new OpcodeTableEntry(sub_a_iyh, "sub iyh", new ArgType[]{});
            opcodeTableFD.entries[0x95] = new OpcodeTableEntry(sub_a_iyl, "sub iyl", new ArgType[]{});
            
            opcodeTableDD.entries[0x9C] = new OpcodeTableEntry(sbc_a_ixh, "sbc a, ixh", new ArgType[]{});
            opcodeTableDD.entries[0x9D] = new OpcodeTableEntry(sbc_a_ixl, "sbc a, ixl", new ArgType[]{});
            opcodeTableFD.entries[0x9C] = new OpcodeTableEntry(sbc_a_iyh, "sbc a, iyh", new ArgType[]{});
            opcodeTableFD.entries[0x9D] = new OpcodeTableEntry(sbc_a_iyl, "sbc a, iyl", new ArgType[]{});
            
            opcodeTable.entries[0xC6] = new OpcodeTableEntry(add_a_n, "add a, {0}", new ArgType[]{ArgType.Byte});
            opcodeTable.entries[0xCE] = new OpcodeTableEntry(adc_a_n, "adc a, {0}", new ArgType[]{ArgType.Byte});
            opcodeTable.entries[0xD6] = new OpcodeTableEntry(sub_a_n, "sub {0}", new ArgType[]{ArgType.Byte});
            opcodeTable.entries[0xDE] = new OpcodeTableEntry(sbc_a_n, "sbc a, {0}", new ArgType[]{ArgType.Byte});

            opcodeTable.entries[0x86] = new OpcodeTableEntry(add_a__hl_, "add a, (hl)", new ArgType[]{});
            opcodeTableDD.entries[0x86] = new OpcodeTableEntry(add_a__ix_d_, "add a, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFD.entries[0x86] = new OpcodeTableEntry(add_a__iy_d_, "add a, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[0x8E] = new OpcodeTableEntry(adc_a__hl_, "adc a, (hl)", new ArgType[]{});
            opcodeTableDD.entries[0x8E] = new OpcodeTableEntry(adc_a__ix_d_, "adc a, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFD.entries[0x8E] = new OpcodeTableEntry(adc_a__iy_d_, "adc a, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[0x96] = new OpcodeTableEntry(sub_a__hl_, "sub (hl)", new ArgType[]{});
            opcodeTableDD.entries[0x96] = new OpcodeTableEntry(sub_a__ix_d_, "sub (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFD.entries[0x96] = new OpcodeTableEntry(sub_a__iy_d_, "sub (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[0x9E] = new OpcodeTableEntry(sbc_a__hl_, "sbc a, (hl)", new ArgType[]{});
            opcodeTableDD.entries[0x9E] = new OpcodeTableEntry(sbc_a__ix_d_, "sbc a, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFD.entries[0x9E] = new OpcodeTableEntry(sbc_a__iy_d_, "sbc a, (iy{0})", new ArgType[]{ArgType.Offset});

            // ADD HL, BC/DE/HL/SP
            opcodeTable.entries[9] = new OpcodeTableEntry(add_hl_bc, "add hl, bc", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[9] = 
                new OpcodeTableEntry(add_ix_bc, "add ix, bc", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[9] = 
                new OpcodeTableEntry(add_iy_bc, "add iy, bc", new ArgType[]{});
            opcodeTableED.entries[74] = new OpcodeTableEntry(adc_hl_bc, "adc hl, bc", new ArgType[]{});
            opcodeTableED.entries[66] = new OpcodeTableEntry(sbc_hl_bc, "sbc hl, bc", new ArgType[]{});
            opcodeTable.entries[25] = new OpcodeTableEntry(add_hl_de, "add hl, de", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[25] = 
                new OpcodeTableEntry(add_ix_de, "add ix, de", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[25] = 
                new OpcodeTableEntry(add_iy_de, "add iy, de", new ArgType[]{});
            opcodeTableED.entries[90] = new OpcodeTableEntry(adc_hl_de, "adc hl, de", new ArgType[]{});
            opcodeTableED.entries[82] = new OpcodeTableEntry(sbc_hl_de, "sbc hl, de", new ArgType[]{});
            opcodeTable.entries[41] = new OpcodeTableEntry(add_hl_hl, "add hl, hl", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[41] = 
                new OpcodeTableEntry(add_ix_ix, "add ix, ix", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[41] = 
                new OpcodeTableEntry(add_iy_iy, "add iy, iy", new ArgType[]{});
            opcodeTableED.entries[106] = new OpcodeTableEntry(adc_hl_hl, "adc hl, hl", new ArgType[]{});
            opcodeTableED.entries[98] = new OpcodeTableEntry(sbc_hl_hl, "sbc hl, hl", new ArgType[]{});
            opcodeTable.entries[57] = new OpcodeTableEntry(add_hl_sp, "add hl, sp", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[57] = 
                new OpcodeTableEntry(add_ix_sp, "add ix, sp", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[57] = 
                new OpcodeTableEntry(add_iy_sp, "add iy, sp", new ArgType[]{});
            opcodeTableED.entries[122] = new OpcodeTableEntry(adc_hl_sp, "adc hl, sp", new ArgType[]{});
            opcodeTableED.entries[114] = new OpcodeTableEntry(sbc_hl_sp, "sbc hl, sp", new ArgType[]{});
            opcodeTable.entries[160] = new OpcodeTableEntry(and_b, "and b", new ArgType[]{});
            opcodeTable.entries[176] = new OpcodeTableEntry(or_b, "or b", new ArgType[]{});
            opcodeTable.entries[168] = new OpcodeTableEntry(xor_b, "xor b", new ArgType[]{});
            opcodeTable.entries[184] = new OpcodeTableEntry(cp_b, "cp b", new ArgType[]{});
            opcodeTable.entries[4] = new OpcodeTableEntry(inc_b, "inc b", new ArgType[]{});
            opcodeTable.entries[5] = new OpcodeTableEntry(dec_b, "dec b", new ArgType[]{});
            opcodeTable.entries[161] = new OpcodeTableEntry(and_c, "and c", new ArgType[]{});
            opcodeTable.entries[177] = new OpcodeTableEntry(or_c, "or c", new ArgType[]{});
            opcodeTable.entries[169] = new OpcodeTableEntry(xor_c, "xor c", new ArgType[]{});
            opcodeTable.entries[185] = new OpcodeTableEntry(cp_c, "cp c", new ArgType[]{});
            opcodeTable.entries[12] = new OpcodeTableEntry(inc_c, "inc c", new ArgType[]{});
            opcodeTable.entries[13] = new OpcodeTableEntry(dec_c, "dec c", new ArgType[]{});
            opcodeTable.entries[162] = new OpcodeTableEntry(and_d, "and d", new ArgType[]{});
            opcodeTable.entries[178] = new OpcodeTableEntry(or_d, "or d", new ArgType[]{});
            opcodeTable.entries[170] = new OpcodeTableEntry(xor_d, "xor d", new ArgType[]{});
            opcodeTable.entries[186] = new OpcodeTableEntry(cp_d, "cp d", new ArgType[]{});
            opcodeTable.entries[20] = new OpcodeTableEntry(inc_d, "inc d", new ArgType[]{});
            opcodeTable.entries[21] = new OpcodeTableEntry(dec_d, "dec d", new ArgType[]{});
            opcodeTable.entries[163] = new OpcodeTableEntry(and_e, "and e", new ArgType[]{});
            opcodeTable.entries[179] = new OpcodeTableEntry(or_e, "or e", new ArgType[]{});
            opcodeTable.entries[171] = new OpcodeTableEntry(xor_e, "xor e", new ArgType[]{});
            opcodeTable.entries[187] = new OpcodeTableEntry(cp_e, "cp e", new ArgType[]{});
            opcodeTable.entries[28] = new OpcodeTableEntry(inc_e, "inc e", new ArgType[]{});
            opcodeTable.entries[29] = new OpcodeTableEntry(dec_e, "dec e", new ArgType[]{});
            opcodeTable.entries[164] = new OpcodeTableEntry(and_h, "and h", new ArgType[]{});
            opcodeTable.entries[180] = new OpcodeTableEntry(or_h, "or h", new ArgType[]{});
            opcodeTable.entries[172] = new OpcodeTableEntry(xor_h, "xor h", new ArgType[]{});
            opcodeTable.entries[188] = new OpcodeTableEntry(cp_h, "cp h", new ArgType[]{});
            opcodeTable.entries[36] = new OpcodeTableEntry(inc_h, "inc h", new ArgType[]{});
            opcodeTable.entries[37] = new OpcodeTableEntry(dec_h, "dec h", new ArgType[]{});
            opcodeTable.entries[165] = new OpcodeTableEntry(and_l, "and l", new ArgType[]{});
            opcodeTable.entries[181] = new OpcodeTableEntry(or_l, "or l", new ArgType[]{});
            opcodeTable.entries[173] = new OpcodeTableEntry(xor_l, "xor l", new ArgType[]{});
            opcodeTable.entries[189] = new OpcodeTableEntry(cp_l, "cp l", new ArgType[]{});
            opcodeTable.entries[44] = new OpcodeTableEntry(inc_l, "inc l", new ArgType[]{});
            opcodeTable.entries[45] = new OpcodeTableEntry(dec_l, "dec l", new ArgType[]{});
            opcodeTable.entries[167] = new OpcodeTableEntry(and_a, "and a", new ArgType[]{});
            opcodeTable.entries[183] = new OpcodeTableEntry(or_a, "or a", new ArgType[]{});
            opcodeTable.entries[175] = new OpcodeTableEntry(xor_a, "xor a", new ArgType[]{});
            opcodeTable.entries[191] = new OpcodeTableEntry(cp_a, "cp a", new ArgType[]{});
            opcodeTable.entries[60] = new OpcodeTableEntry(inc_a, "inc a", new ArgType[]{});
            opcodeTable.entries[61] = new OpcodeTableEntry(dec_a, "dec a", new ArgType[]{});

            opcodeTableDD.entries[0xA4] = new OpcodeTableEntry(and_ixh, "and ixh", new ArgType[]{});
            opcodeTableDD.entries[0xA5] = new OpcodeTableEntry(and_ixl, "and ixl", new ArgType[]{});
            opcodeTableFD.entries[0xA4] = new OpcodeTableEntry(and_iyh, "and iyh", new ArgType[]{});
            opcodeTableFD.entries[0xA5] = new OpcodeTableEntry(and_iyl, "and iyl", new ArgType[]{});

            opcodeTableDD.entries[0xB4] = new OpcodeTableEntry(or_ixh, "or ixh", new ArgType[]{});
            opcodeTableDD.entries[0xB5] = new OpcodeTableEntry(or_ixl, "or ixl", new ArgType[]{});
            opcodeTableFD.entries[0xB4] = new OpcodeTableEntry(or_iyh, "or iyh", new ArgType[]{});
            opcodeTableFD.entries[0xB5] = new OpcodeTableEntry(or_iyl, "or iyl", new ArgType[]{});

            opcodeTableDD.entries[0xAC] = new OpcodeTableEntry(xor_ixh, "xor ixh", new ArgType[]{});
            opcodeTableDD.entries[0xAD] = new OpcodeTableEntry(xor_ixl, "xor ixl", new ArgType[]{});
            opcodeTableFD.entries[0xAC] = new OpcodeTableEntry(xor_iyh, "xor iyh", new ArgType[]{});
            opcodeTableFD.entries[0xAD] = new OpcodeTableEntry(xor_iyl, "xor iyl", new ArgType[]{});
            
            opcodeTableDD.entries[0xBC] = new OpcodeTableEntry(cp_ixh, "cp ixh", new ArgType[]{});
            opcodeTableDD.entries[0xBD] = new OpcodeTableEntry(cp_ixl, "cp ixl", new ArgType[]{});
            opcodeTableFD.entries[0xBC] = new OpcodeTableEntry(cp_iyh, "cp iyh", new ArgType[]{});
            opcodeTableFD.entries[0xBD] = new OpcodeTableEntry(cp_iyl, "cp iyl", new ArgType[]{});

            opcodeTableDD.entries[0x25] = new OpcodeTableEntry(dec_ixh, "dec ixh", new ArgType[]{});
            opcodeTableDD.entries[0x2D] = new OpcodeTableEntry(dec_ixl, "dec ixl", new ArgType[]{});
            opcodeTableFD.entries[0x25] = new OpcodeTableEntry(dec_iyh, "dec iyh", new ArgType[]{});
            opcodeTableFD.entries[0x2D] = new OpcodeTableEntry(dec_iyl, "dec iyl", new ArgType[]{});
            
            opcodeTableDD.entries[0x24] = new OpcodeTableEntry(inc_ixh, "inc ixh", new ArgType[]{});
            opcodeTableDD.entries[0x2C] = new OpcodeTableEntry(inc_ixl, "inc ixl", new ArgType[]{});
            opcodeTableFD.entries[0x24] = new OpcodeTableEntry(inc_iyh, "inc iyh", new ArgType[]{});
            opcodeTableFD.entries[0x2C] = new OpcodeTableEntry(inc_iyl, "inc iyl", new ArgType[]{});
            
            opcodeTable.entries[0xE6] = new OpcodeTableEntry(and_n, "and {0}", new ArgType[]{ArgType.Byte});
            opcodeTable.entries[0xF6] = new OpcodeTableEntry(or_n, "or {0}", new ArgType[]{ArgType.Byte});
            opcodeTable.entries[0xEE] = new OpcodeTableEntry(xor_n, "xor {0}", new ArgType[]{ArgType.Byte});
            opcodeTable.entries[0xFE] = new OpcodeTableEntry(cp_n, "cp {0}", new ArgType[]{ArgType.Byte});
            
            opcodeTable.entries[0xA6] = new OpcodeTableEntry(and__hl_, "and (hl)", new ArgType[]{});
            opcodeTable.entries[0xB6] = new OpcodeTableEntry(or__hl_, "or (hl)", new ArgType[]{});
            opcodeTable.entries[0xAE] = new OpcodeTableEntry(xor__hl_, "xor (hl)", new ArgType[]{});
            opcodeTable.entries[0xBE] = new OpcodeTableEntry(cp__hl_, "cp (hl)", new ArgType[]{});
            opcodeTable.entries[0x34] = new OpcodeTableEntry(inc__hl_, "inc (hl)", new ArgType[]{});
            opcodeTable.entries[0x35] = new OpcodeTableEntry(dec__hl_, "dec (hl)", new ArgType[]{});
            
            opcodeTable.entries[221].nextTable.entries[0xA6] = 
                new OpcodeTableEntry(and__ix_d_, "and (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xB6] = 
                new OpcodeTableEntry(or__ix_d_, "or (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xAE] = 
                new OpcodeTableEntry(xor__ix_d_, "xor (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xBE] = 
                new OpcodeTableEntry(cp__ix_d_, "cp (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0x34] = 
                new OpcodeTableEntry(inc__ix_d_, "inc (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0x35] = 
                new OpcodeTableEntry(dec__ix_d_, "dec (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xA6] = 
                new OpcodeTableEntry(and__iy_d_, "and (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xB6] = 
                new OpcodeTableEntry(or__iy_d_, "or (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xAE] = 
                new OpcodeTableEntry(xor__iy_d_, "xor (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xBE] = 
                new OpcodeTableEntry(cp__iy_d_, "cp (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0x34] = 
                new OpcodeTableEntry(inc__iy_d_, "inc (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0x35] = 
                new OpcodeTableEntry(dec__iy_d_, "dec (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[3] = new OpcodeTableEntry(inc_bc, "inc bc", new ArgType[]{});
            opcodeTable.entries[11] = new OpcodeTableEntry(dec_bc, "dec bc", new ArgType[]{});
            opcodeTable.entries[19] = new OpcodeTableEntry(inc_de, "inc de", new ArgType[]{});
            opcodeTable.entries[27] = new OpcodeTableEntry(dec_de, "dec de", new ArgType[]{});
            opcodeTable.entries[35] = new OpcodeTableEntry(inc_hl, "inc hl", new ArgType[]{});
            opcodeTable.entries[43] = new OpcodeTableEntry(dec_hl, "dec hl", new ArgType[]{});
            opcodeTable.entries[51] = new OpcodeTableEntry(inc_sp, "inc sp", new ArgType[]{});
            opcodeTable.entries[59] = new OpcodeTableEntry(dec_sp, "dec sp", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[0x23] = 
                new OpcodeTableEntry(inc_ix, "inc ix", new ArgType[]{});
            opcodeTable.entries[221].nextTable.entries[0x2B] = 
                new OpcodeTableEntry(dec_ix, "dec ix", new ArgType[]{});
        
            opcodeTable.entries[253].nextTable.entries[0x23] = 
                new OpcodeTableEntry(inc_iy, "inc iy", new ArgType[]{});
            opcodeTable.entries[253].nextTable.entries[0x2B] = 
                new OpcodeTableEntry(dec_iy, "dec iy", new ArgType[]{});
        
            
            opcodeTable.entries[0x27] = new OpcodeTableEntry(daa, "daa", new ArgType[]{});
            opcodeTable.entries[0x2F] = new OpcodeTableEntry(cpl, "cpl", new ArgType[]{});
            opcodeTableED.entries[0x44] = new OpcodeTableEntry(neg, "neg", new ArgType[]{});
            opcodeTableED.entries[0x54] = new OpcodeTableEntry(neg, "neg", new ArgType[]{});
            opcodeTableED.entries[0x64] = new OpcodeTableEntry(neg, "neg", new ArgType[]{});
            opcodeTableED.entries[0x74] = new OpcodeTableEntry(neg, "neg", new ArgType[]{});
            opcodeTableED.entries[0x4C] = new OpcodeTableEntry(neg, "neg", new ArgType[]{});
            opcodeTableED.entries[0x5C] = new OpcodeTableEntry(neg, "neg", new ArgType[]{});
            opcodeTableED.entries[0x6C] = new OpcodeTableEntry(neg, "neg", new ArgType[]{});
            opcodeTableED.entries[0x7C] = new OpcodeTableEntry(neg, "neg", new ArgType[]{});
            opcodeTable.entries[0x3F] = new OpcodeTableEntry(ccf, "ccf", new ArgType[]{});
            opcodeTable.entries[0x37] = new OpcodeTableEntry(scf, "scf", new ArgType[]{});
            opcodeTable.entries[0x76] = new OpcodeTableEntry(halt, "halt", new ArgType[]{});
            opcodeTable.entries[0xF3] = new OpcodeTableEntry(di, "di", new ArgType[]{});
            opcodeTable.entries[0xFB] = new OpcodeTableEntry(ei, "ei", new ArgType[]{});
            
            opcodeTableED.entries[0x46] = new OpcodeTableEntry(im_0, "im 0", new ArgType[]{});
            opcodeTableED.entries[0x4E] = new OpcodeTableEntry(im_0, "im 0", new ArgType[]{});
            opcodeTableED.entries[0x66] = new OpcodeTableEntry(im_0, "im 0", new ArgType[]{});
            opcodeTableED.entries[0x6E] = new OpcodeTableEntry(im_0, "im 0", new ArgType[]{});
            opcodeTableED.entries[0x56] = new OpcodeTableEntry(im_1, "im 1", new ArgType[]{});
            opcodeTableED.entries[0x76] = new OpcodeTableEntry(im_1, "im 1", new ArgType[]{});
            opcodeTableED.entries[0x5E] = new OpcodeTableEntry(im_2, "im 2", new ArgType[]{});
            opcodeTableED.entries[0x7E] = new OpcodeTableEntry(im_2, "im 2", new ArgType[]{});
            
            // ROTATE AND SHIFT
            
            opcodeTable.entries[0x07] = new OpcodeTableEntry(rlca, "rlca", new ArgType[]{});
            opcodeTable.entries[0x17] = new OpcodeTableEntry(rla, "rla", new ArgType[]{});
            opcodeTable.entries[0x0F] = new OpcodeTableEntry(rrca, "rrca", new ArgType[]{});
            opcodeTable.entries[0x1F] = new OpcodeTableEntry(rra, "rra", new ArgType[]{});
            
            opcodeTableED.entries[0x6F] = new OpcodeTableEntry(rld, "rld", new ArgType[]{});
            opcodeTableED.entries[0x67] = new OpcodeTableEntry(rrd, "rrd", new ArgType[]{});
           
            opcodeTableCB.entries[0] = new OpcodeTableEntry(rlc_b, "rlc b", new ArgType[]{});
            opcodeTableCB.entries[16] = new OpcodeTableEntry(rl_b, "rl b", new ArgType[]{});
            opcodeTableCB.entries[8] = new OpcodeTableEntry(rrc_b, "rrc b", new ArgType[]{});
            opcodeTableCB.entries[24] = new OpcodeTableEntry(rr_b, "rr b", new ArgType[]{});
            opcodeTableCB.entries[32] = new OpcodeTableEntry(sla_b, "sla b", new ArgType[]{});
            opcodeTableCB.entries[40] = new OpcodeTableEntry(sra_b, "sra b", new ArgType[]{});
            opcodeTableCB.entries[48] = new OpcodeTableEntry(sll_b, "sll b", new ArgType[]{});
            opcodeTableCB.entries[56] = new OpcodeTableEntry(srl_b, "srl b", new ArgType[]{});
            opcodeTableCB.entries[1] = new OpcodeTableEntry(rlc_c, "rlc c", new ArgType[]{});
            opcodeTableCB.entries[17] = new OpcodeTableEntry(rl_c, "rl c", new ArgType[]{});
            opcodeTableCB.entries[9] = new OpcodeTableEntry(rrc_c, "rrc c", new ArgType[]{});
            opcodeTableCB.entries[25] = new OpcodeTableEntry(rr_c, "rr c", new ArgType[]{});
            opcodeTableCB.entries[33] = new OpcodeTableEntry(sla_c, "sla c", new ArgType[]{});
            opcodeTableCB.entries[41] = new OpcodeTableEntry(sra_c, "sra c", new ArgType[]{});
            opcodeTableCB.entries[49] = new OpcodeTableEntry(sll_c, "sll c", new ArgType[]{});
            opcodeTableCB.entries[57] = new OpcodeTableEntry(srl_c, "srl c", new ArgType[]{});
            opcodeTableCB.entries[2] = new OpcodeTableEntry(rlc_d, "rlc d", new ArgType[]{});
            opcodeTableCB.entries[18] = new OpcodeTableEntry(rl_d, "rl d", new ArgType[]{});
            opcodeTableCB.entries[10] = new OpcodeTableEntry(rrc_d, "rrc d", new ArgType[]{});
            opcodeTableCB.entries[26] = new OpcodeTableEntry(rr_d, "rr d", new ArgType[]{});
            opcodeTableCB.entries[34] = new OpcodeTableEntry(sla_d, "sla d", new ArgType[]{});
            opcodeTableCB.entries[42] = new OpcodeTableEntry(sra_d, "sra d", new ArgType[]{});
            opcodeTableCB.entries[50] = new OpcodeTableEntry(sll_d, "sll d", new ArgType[]{});
            opcodeTableCB.entries[58] = new OpcodeTableEntry(srl_d, "srl d", new ArgType[]{});
            opcodeTableCB.entries[3] = new OpcodeTableEntry(rlc_e, "rlc e", new ArgType[]{});
            opcodeTableCB.entries[19] = new OpcodeTableEntry(rl_e, "rl e", new ArgType[]{});
            opcodeTableCB.entries[11] = new OpcodeTableEntry(rrc_e, "rrc e", new ArgType[]{});
            opcodeTableCB.entries[27] = new OpcodeTableEntry(rr_e, "rr e", new ArgType[]{});
            opcodeTableCB.entries[35] = new OpcodeTableEntry(sla_e, "sla e", new ArgType[]{});
            opcodeTableCB.entries[43] = new OpcodeTableEntry(sra_e, "sra e", new ArgType[]{});
            opcodeTableCB.entries[51] = new OpcodeTableEntry(sll_e, "sll e", new ArgType[]{});
            opcodeTableCB.entries[59] = new OpcodeTableEntry(srl_e, "srl e", new ArgType[]{});
            opcodeTableCB.entries[4] = new OpcodeTableEntry(rlc_h, "rlc h", new ArgType[]{});
            opcodeTableCB.entries[20] = new OpcodeTableEntry(rl_h, "rl h", new ArgType[]{});
            opcodeTableCB.entries[12] = new OpcodeTableEntry(rrc_h, "rrc h", new ArgType[]{});
            opcodeTableCB.entries[28] = new OpcodeTableEntry(rr_h, "rr h", new ArgType[]{});
            opcodeTableCB.entries[36] = new OpcodeTableEntry(sla_h, "sla h", new ArgType[]{});
            opcodeTableCB.entries[44] = new OpcodeTableEntry(sra_h, "sra h", new ArgType[]{});
            opcodeTableCB.entries[52] = new OpcodeTableEntry(sll_h, "sll h", new ArgType[]{});
            opcodeTableCB.entries[60] = new OpcodeTableEntry(srl_h, "srl h", new ArgType[]{});
            opcodeTableCB.entries[5] = new OpcodeTableEntry(rlc_l, "rlc l", new ArgType[]{});
            opcodeTableCB.entries[21] = new OpcodeTableEntry(rl_l, "rl l", new ArgType[]{});
            opcodeTableCB.entries[13] = new OpcodeTableEntry(rrc_l, "rrc l", new ArgType[]{});
            opcodeTableCB.entries[29] = new OpcodeTableEntry(rr_l, "rr l", new ArgType[]{});
            opcodeTableCB.entries[37] = new OpcodeTableEntry(sla_l, "sla l", new ArgType[]{});
            opcodeTableCB.entries[45] = new OpcodeTableEntry(sra_l, "sra l", new ArgType[]{});
            opcodeTableCB.entries[53] = new OpcodeTableEntry(sll_l, "sll l", new ArgType[]{});
            opcodeTableCB.entries[61] = new OpcodeTableEntry(srl_l, "srl l", new ArgType[]{});
            opcodeTableCB.entries[7] = new OpcodeTableEntry(rlc_a, "rlc a", new ArgType[]{});
            opcodeTableCB.entries[23] = new OpcodeTableEntry(rl_a, "rl a", new ArgType[]{});
            opcodeTableCB.entries[15] = new OpcodeTableEntry(rrc_a, "rrc a", new ArgType[]{});
            opcodeTableCB.entries[31] = new OpcodeTableEntry(rr_a, "rr a", new ArgType[]{});
            opcodeTableCB.entries[39] = new OpcodeTableEntry(sla_a, "sla a", new ArgType[]{});
            opcodeTableCB.entries[47] = new OpcodeTableEntry(sra_a, "sra a", new ArgType[]{});
            opcodeTableCB.entries[55] = new OpcodeTableEntry(sll_a, "sll a", new ArgType[]{});
            opcodeTableCB.entries[63] = new OpcodeTableEntry(srl_a, "srl a", new ArgType[]{});

            opcodeTableCB.entries[0x06] = new OpcodeTableEntry(rlc__hl_, "rlc (hl)", new ArgType[]{});       
            opcodeTableCB.entries[0x16] = new OpcodeTableEntry(rl__hl_, "rl (hl)", new ArgType[]{});       
            opcodeTableCB.entries[0x0E] = new OpcodeTableEntry(rrc__hl_, "rrc (hl)", new ArgType[]{});       
            opcodeTableCB.entries[0x1E] = new OpcodeTableEntry(rr__hl_, "rr (hl)", new ArgType[]{});
            
            opcodeTableDDCB.entries[0x06] = new OpcodeTableEntry(rlc__ix_d_, "rlc (ix{0})", new ArgType[]{ArgType.Offset});       
            opcodeTableDDCB.entries[0x16] = new OpcodeTableEntry(rl__ix_d_, "rl (ix{0})", new ArgType[]{ArgType.Offset});       
            opcodeTableDDCB.entries[0x0E] = new OpcodeTableEntry(rrc__ix_d_, "rrc (ix{0})", new ArgType[]{ArgType.Offset});       
            opcodeTableDDCB.entries[0x1E] = new OpcodeTableEntry(rr__ix_d_, "rr (ix{0})", new ArgType[]{ArgType.Offset});  

            opcodeTableFDCB.entries[0x06] = new OpcodeTableEntry(rlc__iy_d_, "rlc (iy{0})", new ArgType[]{ArgType.Offset});       
            opcodeTableFDCB.entries[0x16] = new OpcodeTableEntry(rl__iy_d_, "rl (iy{0})", new ArgType[]{ArgType.Offset});       
            opcodeTableFDCB.entries[0x0E] = new OpcodeTableEntry(rrc__iy_d_, "rrc (iy{0})", new ArgType[]{ArgType.Offset});       
            opcodeTableFDCB.entries[0x1E] = new OpcodeTableEntry(rr__iy_d_, "rr (iy{0})", new ArgType[]{ArgType.Offset});  
            
            opcodeTableCB.entries[0x26] = new OpcodeTableEntry(sla__hl_, "sla (hl)", new ArgType[]{});       
            opcodeTableCB.entries[0x2E] = new OpcodeTableEntry(sra__hl_, "sra (hl)", new ArgType[]{});       
            opcodeTableCB.entries[0x36] = new OpcodeTableEntry(sll__hl_, "sll (hl)", new ArgType[]{});       
            opcodeTableCB.entries[0x3E] = new OpcodeTableEntry(srl__hl_, "srl (hl)", new ArgType[]{});

            opcodeTableDDCB.entries[0x26] = new OpcodeTableEntry(sla__ix_d_, "sla (ix{0})", new ArgType[]{ArgType.Offset});       
            opcodeTableDDCB.entries[0x2E] = new OpcodeTableEntry(sra__ix_d_, "sra (ix{0})", new ArgType[]{ArgType.Offset});       
            opcodeTableDDCB.entries[0x36] = new OpcodeTableEntry(sll__ix_d_, "sll (ix{0})", new ArgType[]{ArgType.Offset});       
            opcodeTableDDCB.entries[0x3E] = new OpcodeTableEntry(srl__ix_d_, "srl (ix{0})", new ArgType[]{ArgType.Offset});
                 
            opcodeTableFDCB.entries[0x26] = new OpcodeTableEntry(sla__iy_d_, "sla (iy{0})", new ArgType[]{ArgType.Offset});       
            opcodeTableFDCB.entries[0x2E] = new OpcodeTableEntry(sra__iy_d_, "sra (iy{0})", new ArgType[]{ArgType.Offset});       
            opcodeTableFDCB.entries[0x36] = new OpcodeTableEntry(sll__iy_d_, "sll (iy{0})", new ArgType[]{ArgType.Offset});       
            opcodeTableFDCB.entries[0x3E] = new OpcodeTableEntry(srl__iy_d_, "srl (iy{0})", new ArgType[]{ArgType.Offset});

            // BIT test
                        
            opcodeTableCB.entries[64] = new OpcodeTableEntry(bit_0_b, "bit 0, b", new ArgType[]{});
            opcodeTableCB.entries[65] = new OpcodeTableEntry(bit_0_c, "bit 0, c", new ArgType[]{});
            opcodeTableCB.entries[66] = new OpcodeTableEntry(bit_0_d, "bit 0, d", new ArgType[]{});
            opcodeTableCB.entries[67] = new OpcodeTableEntry(bit_0_e, "bit 0, e", new ArgType[]{});
            opcodeTableCB.entries[68] = new OpcodeTableEntry(bit_0_h, "bit 0, h", new ArgType[]{});
            opcodeTableCB.entries[69] = new OpcodeTableEntry(bit_0_l, "bit 0, l", new ArgType[]{});
            opcodeTableCB.entries[71] = new OpcodeTableEntry(bit_0_a, "bit 0, a", new ArgType[]{});
            opcodeTableCB.entries[70] = new OpcodeTableEntry(bit_0__hl_, "bit 0, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[64] = new OpcodeTableEntry(bit_0__ix_d_, "bit 0, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[64] = new OpcodeTableEntry(bit_0__iy_d_, "bit 0, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[65] = new OpcodeTableEntry(bit_0__ix_d_, "bit 0, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[65] = new OpcodeTableEntry(bit_0__iy_d_, "bit 0, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[66] = new OpcodeTableEntry(bit_0__ix_d_, "bit 0, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[66] = new OpcodeTableEntry(bit_0__iy_d_, "bit 0, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[67] = new OpcodeTableEntry(bit_0__ix_d_, "bit 0, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[67] = new OpcodeTableEntry(bit_0__iy_d_, "bit 0, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[68] = new OpcodeTableEntry(bit_0__ix_d_, "bit 0, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[68] = new OpcodeTableEntry(bit_0__iy_d_, "bit 0, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[69] = new OpcodeTableEntry(bit_0__ix_d_, "bit 0, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[69] = new OpcodeTableEntry(bit_0__iy_d_, "bit 0, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[70] = new OpcodeTableEntry(bit_0__ix_d_, "bit 0, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[70] = new OpcodeTableEntry(bit_0__iy_d_, "bit 0, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[71] = new OpcodeTableEntry(bit_0__ix_d_, "bit 0, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[71] = new OpcodeTableEntry(bit_0__iy_d_, "bit 0, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[72] = new OpcodeTableEntry(bit_1_b, "bit 1, b", new ArgType[]{});
            opcodeTableCB.entries[73] = new OpcodeTableEntry(bit_1_c, "bit 1, c", new ArgType[]{});
            opcodeTableCB.entries[74] = new OpcodeTableEntry(bit_1_d, "bit 1, d", new ArgType[]{});
            opcodeTableCB.entries[75] = new OpcodeTableEntry(bit_1_e, "bit 1, e", new ArgType[]{});
            opcodeTableCB.entries[76] = new OpcodeTableEntry(bit_1_h, "bit 1, h", new ArgType[]{});
            opcodeTableCB.entries[77] = new OpcodeTableEntry(bit_1_l, "bit 1, l", new ArgType[]{});
            opcodeTableCB.entries[79] = new OpcodeTableEntry(bit_1_a, "bit 1, a", new ArgType[]{});
            opcodeTableCB.entries[78] = new OpcodeTableEntry(bit_1__hl_, "bit 1, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[72] = new OpcodeTableEntry(bit_1__ix_d_, "bit 1, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[72] = new OpcodeTableEntry(bit_1__iy_d_, "bit 1, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[73] = new OpcodeTableEntry(bit_1__ix_d_, "bit 1, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[73] = new OpcodeTableEntry(bit_1__iy_d_, "bit 1, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[74] = new OpcodeTableEntry(bit_1__ix_d_, "bit 1, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[74] = new OpcodeTableEntry(bit_1__iy_d_, "bit 1, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[75] = new OpcodeTableEntry(bit_1__ix_d_, "bit 1, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[75] = new OpcodeTableEntry(bit_1__iy_d_, "bit 1, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[76] = new OpcodeTableEntry(bit_1__ix_d_, "bit 1, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[76] = new OpcodeTableEntry(bit_1__iy_d_, "bit 1, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[77] = new OpcodeTableEntry(bit_1__ix_d_, "bit 1, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[77] = new OpcodeTableEntry(bit_1__iy_d_, "bit 1, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[78] = new OpcodeTableEntry(bit_1__ix_d_, "bit 1, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[78] = new OpcodeTableEntry(bit_1__iy_d_, "bit 1, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[79] = new OpcodeTableEntry(bit_1__ix_d_, "bit 1, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[79] = new OpcodeTableEntry(bit_1__iy_d_, "bit 1, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[80] = new OpcodeTableEntry(bit_2_b, "bit 2, b", new ArgType[]{});
            opcodeTableCB.entries[81] = new OpcodeTableEntry(bit_2_c, "bit 2, c", new ArgType[]{});
            opcodeTableCB.entries[82] = new OpcodeTableEntry(bit_2_d, "bit 2, d", new ArgType[]{});
            opcodeTableCB.entries[83] = new OpcodeTableEntry(bit_2_e, "bit 2, e", new ArgType[]{});
            opcodeTableCB.entries[84] = new OpcodeTableEntry(bit_2_h, "bit 2, h", new ArgType[]{});
            opcodeTableCB.entries[85] = new OpcodeTableEntry(bit_2_l, "bit 2, l", new ArgType[]{});
            opcodeTableCB.entries[87] = new OpcodeTableEntry(bit_2_a, "bit 2, a", new ArgType[]{});
            opcodeTableCB.entries[86] = new OpcodeTableEntry(bit_2__hl_, "bit 2, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[80] = new OpcodeTableEntry(bit_2__ix_d_, "bit 2, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[80] = new OpcodeTableEntry(bit_2__iy_d_, "bit 2, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[81] = new OpcodeTableEntry(bit_2__ix_d_, "bit 2, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[81] = new OpcodeTableEntry(bit_2__iy_d_, "bit 2, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[82] = new OpcodeTableEntry(bit_2__ix_d_, "bit 2, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[82] = new OpcodeTableEntry(bit_2__iy_d_, "bit 2, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[83] = new OpcodeTableEntry(bit_2__ix_d_, "bit 2, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[83] = new OpcodeTableEntry(bit_2__iy_d_, "bit 2, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[84] = new OpcodeTableEntry(bit_2__ix_d_, "bit 2, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[84] = new OpcodeTableEntry(bit_2__iy_d_, "bit 2, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[85] = new OpcodeTableEntry(bit_2__ix_d_, "bit 2, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[85] = new OpcodeTableEntry(bit_2__iy_d_, "bit 2, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[86] = new OpcodeTableEntry(bit_2__ix_d_, "bit 2, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[86] = new OpcodeTableEntry(bit_2__iy_d_, "bit 2, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[87] = new OpcodeTableEntry(bit_2__ix_d_, "bit 2, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[87] = new OpcodeTableEntry(bit_2__iy_d_, "bit 2, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[88] = new OpcodeTableEntry(bit_3_b, "bit 3, b", new ArgType[]{});
            opcodeTableCB.entries[89] = new OpcodeTableEntry(bit_3_c, "bit 3, c", new ArgType[]{});
            opcodeTableCB.entries[90] = new OpcodeTableEntry(bit_3_d, "bit 3, d", new ArgType[]{});
            opcodeTableCB.entries[91] = new OpcodeTableEntry(bit_3_e, "bit 3, e", new ArgType[]{});
            opcodeTableCB.entries[92] = new OpcodeTableEntry(bit_3_h, "bit 3, h", new ArgType[]{});
            opcodeTableCB.entries[93] = new OpcodeTableEntry(bit_3_l, "bit 3, l", new ArgType[]{});
            opcodeTableCB.entries[95] = new OpcodeTableEntry(bit_3_a, "bit 3, a", new ArgType[]{});
            opcodeTableCB.entries[94] = new OpcodeTableEntry(bit_3__hl_, "bit 3, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[88] = new OpcodeTableEntry(bit_3__ix_d_, "bit 3, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[88] = new OpcodeTableEntry(bit_3__iy_d_, "bit 3, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[89] = new OpcodeTableEntry(bit_3__ix_d_, "bit 3, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[89] = new OpcodeTableEntry(bit_3__iy_d_, "bit 3, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[90] = new OpcodeTableEntry(bit_3__ix_d_, "bit 3, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[90] = new OpcodeTableEntry(bit_3__iy_d_, "bit 3, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[91] = new OpcodeTableEntry(bit_3__ix_d_, "bit 3, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[91] = new OpcodeTableEntry(bit_3__iy_d_, "bit 3, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[92] = new OpcodeTableEntry(bit_3__ix_d_, "bit 3, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[92] = new OpcodeTableEntry(bit_3__iy_d_, "bit 3, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[93] = new OpcodeTableEntry(bit_3__ix_d_, "bit 3, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[93] = new OpcodeTableEntry(bit_3__iy_d_, "bit 3, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[94] = new OpcodeTableEntry(bit_3__ix_d_, "bit 3, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[94] = new OpcodeTableEntry(bit_3__iy_d_, "bit 3, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[95] = new OpcodeTableEntry(bit_3__ix_d_, "bit 3, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[95] = new OpcodeTableEntry(bit_3__iy_d_, "bit 3, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[96] = new OpcodeTableEntry(bit_4_b, "bit 4, b", new ArgType[]{});
            opcodeTableCB.entries[97] = new OpcodeTableEntry(bit_4_c, "bit 4, c", new ArgType[]{});
            opcodeTableCB.entries[98] = new OpcodeTableEntry(bit_4_d, "bit 4, d", new ArgType[]{});
            opcodeTableCB.entries[99] = new OpcodeTableEntry(bit_4_e, "bit 4, e", new ArgType[]{});
            opcodeTableCB.entries[100] = new OpcodeTableEntry(bit_4_h, "bit 4, h", new ArgType[]{});
            opcodeTableCB.entries[101] = new OpcodeTableEntry(bit_4_l, "bit 4, l", new ArgType[]{});
            opcodeTableCB.entries[103] = new OpcodeTableEntry(bit_4_a, "bit 4, a", new ArgType[]{});
            opcodeTableCB.entries[102] = new OpcodeTableEntry(bit_4__hl_, "bit 4, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[96] = new OpcodeTableEntry(bit_4__ix_d_, "bit 4, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[96] = new OpcodeTableEntry(bit_4__iy_d_, "bit 4, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[97] = new OpcodeTableEntry(bit_4__ix_d_, "bit 4, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[97] = new OpcodeTableEntry(bit_4__iy_d_, "bit 4, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[98] = new OpcodeTableEntry(bit_4__ix_d_, "bit 4, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[98] = new OpcodeTableEntry(bit_4__iy_d_, "bit 4, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[99] = new OpcodeTableEntry(bit_4__ix_d_, "bit 4, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[99] = new OpcodeTableEntry(bit_4__iy_d_, "bit 4, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[100] = new OpcodeTableEntry(bit_4__ix_d_, "bit 4, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[100] = new OpcodeTableEntry(bit_4__iy_d_, "bit 4, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[101] = new OpcodeTableEntry(bit_4__ix_d_, "bit 4, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[101] = new OpcodeTableEntry(bit_4__iy_d_, "bit 4, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[102] = new OpcodeTableEntry(bit_4__ix_d_, "bit 4, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[102] = new OpcodeTableEntry(bit_4__iy_d_, "bit 4, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[103] = new OpcodeTableEntry(bit_4__ix_d_, "bit 4, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[103] = new OpcodeTableEntry(bit_4__iy_d_, "bit 4, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[104] = new OpcodeTableEntry(bit_5_b, "bit 5, b", new ArgType[]{});
            opcodeTableCB.entries[105] = new OpcodeTableEntry(bit_5_c, "bit 5, c", new ArgType[]{});
            opcodeTableCB.entries[106] = new OpcodeTableEntry(bit_5_d, "bit 5, d", new ArgType[]{});
            opcodeTableCB.entries[107] = new OpcodeTableEntry(bit_5_e, "bit 5, e", new ArgType[]{});
            opcodeTableCB.entries[108] = new OpcodeTableEntry(bit_5_h, "bit 5, h", new ArgType[]{});
            opcodeTableCB.entries[109] = new OpcodeTableEntry(bit_5_l, "bit 5, l", new ArgType[]{});
            opcodeTableCB.entries[111] = new OpcodeTableEntry(bit_5_a, "bit 5, a", new ArgType[]{});
            opcodeTableCB.entries[110] = new OpcodeTableEntry(bit_5__hl_, "bit 5, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[104] = new OpcodeTableEntry(bit_5__ix_d_, "bit 5, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[104] = new OpcodeTableEntry(bit_5__iy_d_, "bit 5, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[105] = new OpcodeTableEntry(bit_5__ix_d_, "bit 5, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[105] = new OpcodeTableEntry(bit_5__iy_d_, "bit 5, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[106] = new OpcodeTableEntry(bit_5__ix_d_, "bit 5, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[106] = new OpcodeTableEntry(bit_5__iy_d_, "bit 5, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[107] = new OpcodeTableEntry(bit_5__ix_d_, "bit 5, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[107] = new OpcodeTableEntry(bit_5__iy_d_, "bit 5, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[108] = new OpcodeTableEntry(bit_5__ix_d_, "bit 5, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[108] = new OpcodeTableEntry(bit_5__iy_d_, "bit 5, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[109] = new OpcodeTableEntry(bit_5__ix_d_, "bit 5, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[109] = new OpcodeTableEntry(bit_5__iy_d_, "bit 5, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[110] = new OpcodeTableEntry(bit_5__ix_d_, "bit 5, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[110] = new OpcodeTableEntry(bit_5__iy_d_, "bit 5, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[111] = new OpcodeTableEntry(bit_5__ix_d_, "bit 5, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[111] = new OpcodeTableEntry(bit_5__iy_d_, "bit 5, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[112] = new OpcodeTableEntry(bit_6_b, "bit 6, b", new ArgType[]{});
            opcodeTableCB.entries[113] = new OpcodeTableEntry(bit_6_c, "bit 6, c", new ArgType[]{});
            opcodeTableCB.entries[114] = new OpcodeTableEntry(bit_6_d, "bit 6, d", new ArgType[]{});
            opcodeTableCB.entries[115] = new OpcodeTableEntry(bit_6_e, "bit 6, e", new ArgType[]{});
            opcodeTableCB.entries[116] = new OpcodeTableEntry(bit_6_h, "bit 6, h", new ArgType[]{});
            opcodeTableCB.entries[117] = new OpcodeTableEntry(bit_6_l, "bit 6, l", new ArgType[]{});
            opcodeTableCB.entries[119] = new OpcodeTableEntry(bit_6_a, "bit 6, a", new ArgType[]{});
            opcodeTableCB.entries[118] = new OpcodeTableEntry(bit_6__hl_, "bit 6, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[112] = new OpcodeTableEntry(bit_6__ix_d_, "bit 6, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[112] = new OpcodeTableEntry(bit_6__iy_d_, "bit 6, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[113] = new OpcodeTableEntry(bit_6__ix_d_, "bit 6, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[113] = new OpcodeTableEntry(bit_6__iy_d_, "bit 6, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[114] = new OpcodeTableEntry(bit_6__ix_d_, "bit 6, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[114] = new OpcodeTableEntry(bit_6__iy_d_, "bit 6, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[115] = new OpcodeTableEntry(bit_6__ix_d_, "bit 6, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[115] = new OpcodeTableEntry(bit_6__iy_d_, "bit 6, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[116] = new OpcodeTableEntry(bit_6__ix_d_, "bit 6, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[116] = new OpcodeTableEntry(bit_6__iy_d_, "bit 6, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[117] = new OpcodeTableEntry(bit_6__ix_d_, "bit 6, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[117] = new OpcodeTableEntry(bit_6__iy_d_, "bit 6, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[118] = new OpcodeTableEntry(bit_6__ix_d_, "bit 6, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[118] = new OpcodeTableEntry(bit_6__iy_d_, "bit 6, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[119] = new OpcodeTableEntry(bit_6__ix_d_, "bit 6, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[119] = new OpcodeTableEntry(bit_6__iy_d_, "bit 6, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[120] = new OpcodeTableEntry(bit_7_b, "bit 7, b", new ArgType[]{});
            opcodeTableCB.entries[121] = new OpcodeTableEntry(bit_7_c, "bit 7, c", new ArgType[]{});
            opcodeTableCB.entries[122] = new OpcodeTableEntry(bit_7_d, "bit 7, d", new ArgType[]{});
            opcodeTableCB.entries[123] = new OpcodeTableEntry(bit_7_e, "bit 7, e", new ArgType[]{});
            opcodeTableCB.entries[124] = new OpcodeTableEntry(bit_7_h, "bit 7, h", new ArgType[]{});
            opcodeTableCB.entries[125] = new OpcodeTableEntry(bit_7_l, "bit 7, l", new ArgType[]{});
            opcodeTableCB.entries[127] = new OpcodeTableEntry(bit_7_a, "bit 7, a", new ArgType[]{});
            opcodeTableCB.entries[126] = new OpcodeTableEntry(bit_7__hl_, "bit 7, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[120] = new OpcodeTableEntry(bit_7__ix_d_, "bit 7, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[120] = new OpcodeTableEntry(bit_7__iy_d_, "bit 7, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[121] = new OpcodeTableEntry(bit_7__ix_d_, "bit 7, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[121] = new OpcodeTableEntry(bit_7__iy_d_, "bit 7, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[122] = new OpcodeTableEntry(bit_7__ix_d_, "bit 7, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[122] = new OpcodeTableEntry(bit_7__iy_d_, "bit 7, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[123] = new OpcodeTableEntry(bit_7__ix_d_, "bit 7, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[123] = new OpcodeTableEntry(bit_7__iy_d_, "bit 7, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[124] = new OpcodeTableEntry(bit_7__ix_d_, "bit 7, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[124] = new OpcodeTableEntry(bit_7__iy_d_, "bit 7, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[125] = new OpcodeTableEntry(bit_7__ix_d_, "bit 7, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[125] = new OpcodeTableEntry(bit_7__iy_d_, "bit 7, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[126] = new OpcodeTableEntry(bit_7__ix_d_, "bit 7, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[126] = new OpcodeTableEntry(bit_7__iy_d_, "bit 7, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[127] = new OpcodeTableEntry(bit_7__ix_d_, "bit 7, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[127] = new OpcodeTableEntry(bit_7__iy_d_, "bit 7, (iy{0})", new ArgType[]{ArgType.Offset});

            // SET / RES
            
            opcodeTableCB.entries[192] = new OpcodeTableEntry(set_0_b, "set 0, b", new ArgType[]{});
            opcodeTableCB.entries[193] = new OpcodeTableEntry(set_0_c, "set 0, c", new ArgType[]{});
            opcodeTableCB.entries[194] = new OpcodeTableEntry(set_0_d, "set 0, d", new ArgType[]{});
            opcodeTableCB.entries[195] = new OpcodeTableEntry(set_0_e, "set 0, e", new ArgType[]{});
            opcodeTableCB.entries[196] = new OpcodeTableEntry(set_0_h, "set 0, h", new ArgType[]{});
            opcodeTableCB.entries[197] = new OpcodeTableEntry(set_0_l, "set 0, l", new ArgType[]{});
            opcodeTableCB.entries[199] = new OpcodeTableEntry(set_0_a, "set 0, a", new ArgType[]{});
            opcodeTableCB.entries[198] = new OpcodeTableEntry(set_0__hl_, "set 0, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[198] = new OpcodeTableEntry(set_0__ix_d_, "set 0, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[198] = new OpcodeTableEntry(set_0__iy_d_, "set 0, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[200] = new OpcodeTableEntry(set_1_b, "set 1, b", new ArgType[]{});
            opcodeTableCB.entries[201] = new OpcodeTableEntry(set_1_c, "set 1, c", new ArgType[]{});
            opcodeTableCB.entries[202] = new OpcodeTableEntry(set_1_d, "set 1, d", new ArgType[]{});
            opcodeTableCB.entries[203] = new OpcodeTableEntry(set_1_e, "set 1, e", new ArgType[]{});
            opcodeTableCB.entries[204] = new OpcodeTableEntry(set_1_h, "set 1, h", new ArgType[]{});
            opcodeTableCB.entries[205] = new OpcodeTableEntry(set_1_l, "set 1, l", new ArgType[]{});
            opcodeTableCB.entries[207] = new OpcodeTableEntry(set_1_a, "set 1, a", new ArgType[]{});
            opcodeTableCB.entries[206] = new OpcodeTableEntry(set_1__hl_, "set 1, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[206] = new OpcodeTableEntry(set_1__ix_d_, "set 1, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[206] = new OpcodeTableEntry(set_1__iy_d_, "set 1, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[208] = new OpcodeTableEntry(set_2_b, "set 2, b", new ArgType[]{});
            opcodeTableCB.entries[209] = new OpcodeTableEntry(set_2_c, "set 2, c", new ArgType[]{});
            opcodeTableCB.entries[210] = new OpcodeTableEntry(set_2_d, "set 2, d", new ArgType[]{});
            opcodeTableCB.entries[211] = new OpcodeTableEntry(set_2_e, "set 2, e", new ArgType[]{});
            opcodeTableCB.entries[212] = new OpcodeTableEntry(set_2_h, "set 2, h", new ArgType[]{});
            opcodeTableCB.entries[213] = new OpcodeTableEntry(set_2_l, "set 2, l", new ArgType[]{});
            opcodeTableCB.entries[215] = new OpcodeTableEntry(set_2_a, "set 2, a", new ArgType[]{});
            opcodeTableCB.entries[214] = new OpcodeTableEntry(set_2__hl_, "set 2, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[214] = new OpcodeTableEntry(set_2__ix_d_, "set 2, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[214] = new OpcodeTableEntry(set_2__iy_d_, "set 2, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[216] = new OpcodeTableEntry(set_3_b, "set 3, b", new ArgType[]{});
            opcodeTableCB.entries[217] = new OpcodeTableEntry(set_3_c, "set 3, c", new ArgType[]{});
            opcodeTableCB.entries[218] = new OpcodeTableEntry(set_3_d, "set 3, d", new ArgType[]{});
            opcodeTableCB.entries[219] = new OpcodeTableEntry(set_3_e, "set 3, e", new ArgType[]{});
            opcodeTableCB.entries[220] = new OpcodeTableEntry(set_3_h, "set 3, h", new ArgType[]{});
            opcodeTableCB.entries[221] = new OpcodeTableEntry(set_3_l, "set 3, l", new ArgType[]{});
            opcodeTableCB.entries[223] = new OpcodeTableEntry(set_3_a, "set 3, a", new ArgType[]{});
            opcodeTableCB.entries[222] = new OpcodeTableEntry(set_3__hl_, "set 3, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[222] = new OpcodeTableEntry(set_3__ix_d_, "set 3, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[222] = new OpcodeTableEntry(set_3__iy_d_, "set 3, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[224] = new OpcodeTableEntry(set_4_b, "set 4, b", new ArgType[]{});
            opcodeTableCB.entries[225] = new OpcodeTableEntry(set_4_c, "set 4, c", new ArgType[]{});
            opcodeTableCB.entries[226] = new OpcodeTableEntry(set_4_d, "set 4, d", new ArgType[]{});
            opcodeTableCB.entries[227] = new OpcodeTableEntry(set_4_e, "set 4, e", new ArgType[]{});
            opcodeTableCB.entries[228] = new OpcodeTableEntry(set_4_h, "set 4, h", new ArgType[]{});
            opcodeTableCB.entries[229] = new OpcodeTableEntry(set_4_l, "set 4, l", new ArgType[]{});
            opcodeTableCB.entries[231] = new OpcodeTableEntry(set_4_a, "set 4, a", new ArgType[]{});
            opcodeTableCB.entries[230] = new OpcodeTableEntry(set_4__hl_, "set 4, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[230] = new OpcodeTableEntry(set_4__ix_d_, "set 4, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[230] = new OpcodeTableEntry(set_4__iy_d_, "set 4, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[232] = new OpcodeTableEntry(set_5_b, "set 5, b", new ArgType[]{});
            opcodeTableCB.entries[233] = new OpcodeTableEntry(set_5_c, "set 5, c", new ArgType[]{});
            opcodeTableCB.entries[234] = new OpcodeTableEntry(set_5_d, "set 5, d", new ArgType[]{});
            opcodeTableCB.entries[235] = new OpcodeTableEntry(set_5_e, "set 5, e", new ArgType[]{});
            opcodeTableCB.entries[236] = new OpcodeTableEntry(set_5_h, "set 5, h", new ArgType[]{});
            opcodeTableCB.entries[237] = new OpcodeTableEntry(set_5_l, "set 5, l", new ArgType[]{});
            opcodeTableCB.entries[239] = new OpcodeTableEntry(set_5_a, "set 5, a", new ArgType[]{});
            opcodeTableCB.entries[238] = new OpcodeTableEntry(set_5__hl_, "set 5, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[238] = new OpcodeTableEntry(set_5__ix_d_, "set 5, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[238] = new OpcodeTableEntry(set_5__iy_d_, "set 5, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[240] = new OpcodeTableEntry(set_6_b, "set 6, b", new ArgType[]{});
            opcodeTableCB.entries[241] = new OpcodeTableEntry(set_6_c, "set 6, c", new ArgType[]{});
            opcodeTableCB.entries[242] = new OpcodeTableEntry(set_6_d, "set 6, d", new ArgType[]{});
            opcodeTableCB.entries[243] = new OpcodeTableEntry(set_6_e, "set 6, e", new ArgType[]{});
            opcodeTableCB.entries[244] = new OpcodeTableEntry(set_6_h, "set 6, h", new ArgType[]{});
            opcodeTableCB.entries[245] = new OpcodeTableEntry(set_6_l, "set 6, l", new ArgType[]{});
            opcodeTableCB.entries[247] = new OpcodeTableEntry(set_6_a, "set 6, a", new ArgType[]{});
            opcodeTableCB.entries[246] = new OpcodeTableEntry(set_6__hl_, "set 6, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[246] = new OpcodeTableEntry(set_6__ix_d_, "set 6, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[246] = new OpcodeTableEntry(set_6__iy_d_, "set 6, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[248] = new OpcodeTableEntry(set_7_b, "set 7, b", new ArgType[]{});
            opcodeTableCB.entries[249] = new OpcodeTableEntry(set_7_c, "set 7, c", new ArgType[]{});
            opcodeTableCB.entries[250] = new OpcodeTableEntry(set_7_d, "set 7, d", new ArgType[]{});
            opcodeTableCB.entries[251] = new OpcodeTableEntry(set_7_e, "set 7, e", new ArgType[]{});
            opcodeTableCB.entries[252] = new OpcodeTableEntry(set_7_h, "set 7, h", new ArgType[]{});
            opcodeTableCB.entries[253] = new OpcodeTableEntry(set_7_l, "set 7, l", new ArgType[]{});
            opcodeTableCB.entries[255] = new OpcodeTableEntry(set_7_a, "set 7, a", new ArgType[]{});
            opcodeTableCB.entries[254] = new OpcodeTableEntry(set_7__hl_, "set 7, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[254] = new OpcodeTableEntry(set_7__ix_d_, "set 7, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[254] = new OpcodeTableEntry(set_7__iy_d_, "set 7, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[128] = new OpcodeTableEntry(res_0_b, "res 0, b", new ArgType[]{});
            opcodeTableCB.entries[129] = new OpcodeTableEntry(res_0_c, "res 0, c", new ArgType[]{});
            opcodeTableCB.entries[130] = new OpcodeTableEntry(res_0_d, "res 0, d", new ArgType[]{});
            opcodeTableCB.entries[131] = new OpcodeTableEntry(res_0_e, "res 0, e", new ArgType[]{});
            opcodeTableCB.entries[132] = new OpcodeTableEntry(res_0_h, "res 0, h", new ArgType[]{});
            opcodeTableCB.entries[133] = new OpcodeTableEntry(res_0_l, "res 0, l", new ArgType[]{});
            opcodeTableCB.entries[135] = new OpcodeTableEntry(res_0_a, "res 0, a", new ArgType[]{});
            opcodeTableCB.entries[134] = new OpcodeTableEntry(res_0__hl_, "res 0, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[134] = new OpcodeTableEntry(res_0__ix_d_, "res 0, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[134] = new OpcodeTableEntry(res_0__iy_d_, "res 0, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[136] = new OpcodeTableEntry(res_1_b, "res 1, b", new ArgType[]{});
            opcodeTableCB.entries[137] = new OpcodeTableEntry(res_1_c, "res 1, c", new ArgType[]{});
            opcodeTableCB.entries[138] = new OpcodeTableEntry(res_1_d, "res 1, d", new ArgType[]{});
            opcodeTableCB.entries[139] = new OpcodeTableEntry(res_1_e, "res 1, e", new ArgType[]{});
            opcodeTableCB.entries[140] = new OpcodeTableEntry(res_1_h, "res 1, h", new ArgType[]{});
            opcodeTableCB.entries[141] = new OpcodeTableEntry(res_1_l, "res 1, l", new ArgType[]{});
            opcodeTableCB.entries[143] = new OpcodeTableEntry(res_1_a, "res 1, a", new ArgType[]{});
            opcodeTableCB.entries[142] = new OpcodeTableEntry(res_1__hl_, "res 1, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[142] = new OpcodeTableEntry(res_1__ix_d_, "res 1, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[142] = new OpcodeTableEntry(res_1__iy_d_, "res 1, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[144] = new OpcodeTableEntry(res_2_b, "res 2, b", new ArgType[]{});
            opcodeTableCB.entries[145] = new OpcodeTableEntry(res_2_c, "res 2, c", new ArgType[]{});
            opcodeTableCB.entries[146] = new OpcodeTableEntry(res_2_d, "res 2, d", new ArgType[]{});
            opcodeTableCB.entries[147] = new OpcodeTableEntry(res_2_e, "res 2, e", new ArgType[]{});
            opcodeTableCB.entries[148] = new OpcodeTableEntry(res_2_h, "res 2, h", new ArgType[]{});
            opcodeTableCB.entries[149] = new OpcodeTableEntry(res_2_l, "res 2, l", new ArgType[]{});
            opcodeTableCB.entries[151] = new OpcodeTableEntry(res_2_a, "res 2, a", new ArgType[]{});
            opcodeTableCB.entries[150] = new OpcodeTableEntry(res_2__hl_, "res 2, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[150] = new OpcodeTableEntry(res_2__ix_d_, "res 2, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[150] = new OpcodeTableEntry(res_2__iy_d_, "res 2, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[152] = new OpcodeTableEntry(res_3_b, "res 3, b", new ArgType[]{});
            opcodeTableCB.entries[153] = new OpcodeTableEntry(res_3_c, "res 3, c", new ArgType[]{});
            opcodeTableCB.entries[154] = new OpcodeTableEntry(res_3_d, "res 3, d", new ArgType[]{});
            opcodeTableCB.entries[155] = new OpcodeTableEntry(res_3_e, "res 3, e", new ArgType[]{});
            opcodeTableCB.entries[156] = new OpcodeTableEntry(res_3_h, "res 3, h", new ArgType[]{});
            opcodeTableCB.entries[157] = new OpcodeTableEntry(res_3_l, "res 3, l", new ArgType[]{});
            opcodeTableCB.entries[159] = new OpcodeTableEntry(res_3_a, "res 3, a", new ArgType[]{});
            opcodeTableCB.entries[158] = new OpcodeTableEntry(res_3__hl_, "res 3, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[158] = new OpcodeTableEntry(res_3__ix_d_, "res 3, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[158] = new OpcodeTableEntry(res_3__iy_d_, "res 3, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[160] = new OpcodeTableEntry(res_4_b, "res 4, b", new ArgType[]{});
            opcodeTableCB.entries[161] = new OpcodeTableEntry(res_4_c, "res 4, c", new ArgType[]{});
            opcodeTableCB.entries[162] = new OpcodeTableEntry(res_4_d, "res 4, d", new ArgType[]{});
            opcodeTableCB.entries[163] = new OpcodeTableEntry(res_4_e, "res 4, e", new ArgType[]{});
            opcodeTableCB.entries[164] = new OpcodeTableEntry(res_4_h, "res 4, h", new ArgType[]{});
            opcodeTableCB.entries[165] = new OpcodeTableEntry(res_4_l, "res 4, l", new ArgType[]{});
            opcodeTableCB.entries[167] = new OpcodeTableEntry(res_4_a, "res 4, a", new ArgType[]{});
            opcodeTableCB.entries[166] = new OpcodeTableEntry(res_4__hl_, "res 4, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[166] = new OpcodeTableEntry(res_4__ix_d_, "res 4, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[166] = new OpcodeTableEntry(res_4__iy_d_, "res 4, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[168] = new OpcodeTableEntry(res_5_b, "res 5, b", new ArgType[]{});
            opcodeTableCB.entries[169] = new OpcodeTableEntry(res_5_c, "res 5, c", new ArgType[]{});
            opcodeTableCB.entries[170] = new OpcodeTableEntry(res_5_d, "res 5, d", new ArgType[]{});
            opcodeTableCB.entries[171] = new OpcodeTableEntry(res_5_e, "res 5, e", new ArgType[]{});
            opcodeTableCB.entries[172] = new OpcodeTableEntry(res_5_h, "res 5, h", new ArgType[]{});
            opcodeTableCB.entries[173] = new OpcodeTableEntry(res_5_l, "res 5, l", new ArgType[]{});
            opcodeTableCB.entries[175] = new OpcodeTableEntry(res_5_a, "res 5, a", new ArgType[]{});
            opcodeTableCB.entries[174] = new OpcodeTableEntry(res_5__hl_, "res 5, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[174] = new OpcodeTableEntry(res_5__ix_d_, "res 5, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[174] = new OpcodeTableEntry(res_5__iy_d_, "res 5, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[176] = new OpcodeTableEntry(res_6_b, "res 6, b", new ArgType[]{});
            opcodeTableCB.entries[177] = new OpcodeTableEntry(res_6_c, "res 6, c", new ArgType[]{});
            opcodeTableCB.entries[178] = new OpcodeTableEntry(res_6_d, "res 6, d", new ArgType[]{});
            opcodeTableCB.entries[179] = new OpcodeTableEntry(res_6_e, "res 6, e", new ArgType[]{});
            opcodeTableCB.entries[180] = new OpcodeTableEntry(res_6_h, "res 6, h", new ArgType[]{});
            opcodeTableCB.entries[181] = new OpcodeTableEntry(res_6_l, "res 6, l", new ArgType[]{});
            opcodeTableCB.entries[183] = new OpcodeTableEntry(res_6_a, "res 6, a", new ArgType[]{});
            opcodeTableCB.entries[182] = new OpcodeTableEntry(res_6__hl_, "res 6, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[182] = new OpcodeTableEntry(res_6__ix_d_, "res 6, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[182] = new OpcodeTableEntry(res_6__iy_d_, "res 6, (iy{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[184] = new OpcodeTableEntry(res_7_b, "res 7, b", new ArgType[]{});
            opcodeTableCB.entries[185] = new OpcodeTableEntry(res_7_c, "res 7, c", new ArgType[]{});
            opcodeTableCB.entries[186] = new OpcodeTableEntry(res_7_d, "res 7, d", new ArgType[]{});
            opcodeTableCB.entries[187] = new OpcodeTableEntry(res_7_e, "res 7, e", new ArgType[]{});
            opcodeTableCB.entries[188] = new OpcodeTableEntry(res_7_h, "res 7, h", new ArgType[]{});
            opcodeTableCB.entries[189] = new OpcodeTableEntry(res_7_l, "res 7, l", new ArgType[]{});
            opcodeTableCB.entries[191] = new OpcodeTableEntry(res_7_a, "res 7, a", new ArgType[]{});
            opcodeTableCB.entries[190] = new OpcodeTableEntry(res_7__hl_, "res 7, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[190] = new OpcodeTableEntry(res_7__ix_d_, "res 7, (ix{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[190] = new OpcodeTableEntry(res_7__iy_d_, "res 7, (iy{0})", new ArgType[]{ArgType.Offset});

            opcodeTable.entries[0xDB] = new OpcodeTableEntry(in_a__n_, "in a, ({0})", new ArgType[]{ArgType.Byte});
            opcodeTable.entries[0xD3] = new OpcodeTableEntry(out__n__a, "out ({0}), a", new ArgType[]{ArgType.Byte});
            
            opcodeTableED.entries[0x70] = new OpcodeTableEntry(in_f__c_, "in f, (c)", new ArgType[]{});
            opcodeTableED.entries[0x71] = new OpcodeTableEntry(out__c__0, "out (c), 0", new ArgType[]{});
            opcodeTableED.entries[64] = new OpcodeTableEntry(in_b__c_, "in b, (c)", new ArgType[]{});
            opcodeTableED.entries[65] = new OpcodeTableEntry(out__c__b, "out (c), b", new ArgType[]{});
            opcodeTableED.entries[72] = new OpcodeTableEntry(in_c__c_, "in c, (c)", new ArgType[]{});
            opcodeTableED.entries[73] = new OpcodeTableEntry(out__c__c, "out (c), c", new ArgType[]{});
            opcodeTableED.entries[80] = new OpcodeTableEntry(in_d__c_, "in d, (c)", new ArgType[]{});
            opcodeTableED.entries[81] = new OpcodeTableEntry(out__c__d, "out (c), d", new ArgType[]{});
            opcodeTableED.entries[88] = new OpcodeTableEntry(in_e__c_, "in e, (c)", new ArgType[]{});
            opcodeTableED.entries[89] = new OpcodeTableEntry(out__c__e, "out (c), e", new ArgType[]{});
            opcodeTableED.entries[96] = new OpcodeTableEntry(in_h__c_, "in h, (c)", new ArgType[]{});
            opcodeTableED.entries[97] = new OpcodeTableEntry(out__c__h, "out (c), h", new ArgType[]{});
            opcodeTableED.entries[104] = new OpcodeTableEntry(in_l__c_, "in l, (c)", new ArgType[]{});
            opcodeTableED.entries[105] = new OpcodeTableEntry(out__c__l, "out (c), l", new ArgType[]{});
            opcodeTableED.entries[120] = new OpcodeTableEntry(in_a__c_, "in a, (c)", new ArgType[]{});
            opcodeTableED.entries[121] = new OpcodeTableEntry(out__c__a, "out (c), a", new ArgType[]{});
            opcodeTableED.entries[0xA2] = new OpcodeTableEntry(ini, "ini", new ArgType[]{});
            opcodeTableED.entries[0xB2] = new OpcodeTableEntry(inir, "inir", new ArgType[]{});
            opcodeTableED.entries[0xAA] = new OpcodeTableEntry(ind, "ind", new ArgType[]{});
            opcodeTableED.entries[0xBA] = new OpcodeTableEntry(indr, "indr", new ArgType[]{});
            opcodeTableED.entries[0xA3] = new OpcodeTableEntry(outi, "outi", new ArgType[]{});
            opcodeTableED.entries[0xB3] = new OpcodeTableEntry(otir, "otir", new ArgType[]{});
            opcodeTableED.entries[0xAB] = new OpcodeTableEntry(outd, "outd", new ArgType[]{});
            opcodeTableED.entries[0xBB] = new OpcodeTableEntry(otdr, "otdr", new ArgType[]{});
            
            // Jumps and calls
            
            opcodeTable.entries[0xC3] = new OpcodeTableEntry(jp_nn, "jp {0}", new ArgType[]{ArgType.Word});
            opcodeTable.entries[0xCD] = new OpcodeTableEntry(call_nn, "call {0}", new ArgType[]{ArgType.Word});
            opcodeTable.entries[0x18] = new OpcodeTableEntry(jr_pc_e, "jr pc{0}", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[0xC9] = new OpcodeTableEntry(ret, "ret", new ArgType[]{});
            
            opcodeTable.entries[0x38] = new OpcodeTableEntry(jr_c_pc_e, "jr c, pc{0}", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[0x30] = new OpcodeTableEntry(jr_nc_pc_e, "jr nc, pc{0}", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[0x28] = new OpcodeTableEntry(jr_z_pc_e, "jr z, pc{0}", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[0x20] = new OpcodeTableEntry(jr_nz_pc_e, "jr nz, pc{0}", new ArgType[]{ArgType.Offset});
            
            opcodeTable.entries[0xE9] = new OpcodeTableEntry(jp__hl_, "jp (hl)", new ArgType[]{});
            opcodeTableDD.entries[0xE9] = new OpcodeTableEntry(jp__ix_, "jp (ix)", new ArgType[]{});
            opcodeTableFD.entries[0xE9] = new OpcodeTableEntry(jp__iy_, "jp (iy)", new ArgType[]{});
            
            opcodeTable.entries[0x10] = new OpcodeTableEntry(djnz_pc_e, "djnz pc{0}", new ArgType[]{ArgType.Offset});
            
            
            opcodeTable.entries[194] = new OpcodeTableEntry(jp_nz_nn, "jp nz, {0}", new ArgType[]{ArgType.Word});
            opcodeTable.entries[196] = new OpcodeTableEntry(call_nz_nn, "call nz, {0}", new ArgType[]{ArgType.Word});
            opcodeTable.entries[192] = new OpcodeTableEntry(ret_nz, "ret nz", new ArgType[]{});
            opcodeTable.entries[202] = new OpcodeTableEntry(jp_z_nn, "jp z, {0}", new ArgType[]{ArgType.Word});
            opcodeTable.entries[204] = new OpcodeTableEntry(call_z_nn, "call z, {0}", new ArgType[]{ArgType.Word});
            opcodeTable.entries[200] = new OpcodeTableEntry(ret_z, "ret z", new ArgType[]{});
            opcodeTable.entries[210] = new OpcodeTableEntry(jp_nc_nn, "jp nc, {0}", new ArgType[]{ArgType.Word});
            opcodeTable.entries[212] = new OpcodeTableEntry(call_nc_nn, "call nc, {0}", new ArgType[]{ArgType.Word});
            opcodeTable.entries[208] = new OpcodeTableEntry(ret_nc, "ret nc", new ArgType[]{});
            opcodeTable.entries[218] = new OpcodeTableEntry(jp_c_nn, "jp c, {0}", new ArgType[]{ArgType.Word});
            opcodeTable.entries[220] = new OpcodeTableEntry(call_c_nn, "call c, {0}", new ArgType[]{ArgType.Word});
            opcodeTable.entries[216] = new OpcodeTableEntry(ret_c, "ret c", new ArgType[]{});
            opcodeTable.entries[226] = new OpcodeTableEntry(jp_po_nn, "jp po, {0}", new ArgType[]{ArgType.Word});
            opcodeTable.entries[228] = new OpcodeTableEntry(call_po_nn, "call po, {0}", new ArgType[]{ArgType.Word});
            opcodeTable.entries[224] = new OpcodeTableEntry(ret_po, "ret po", new ArgType[]{});
            opcodeTable.entries[234] = new OpcodeTableEntry(jp_pe_nn, "jp pe, {0}", new ArgType[]{ArgType.Word});
            opcodeTable.entries[236] = new OpcodeTableEntry(call_pe_nn, "call pe, {0}", new ArgType[]{ArgType.Word});
            opcodeTable.entries[232] = new OpcodeTableEntry(ret_pe, "ret pe", new ArgType[]{});
            opcodeTable.entries[242] = new OpcodeTableEntry(jp_p_nn, "jp p, {0}", new ArgType[]{ArgType.Word});
            opcodeTable.entries[244] = new OpcodeTableEntry(call_p_nn, "call p, {0}", new ArgType[]{ArgType.Word});
            opcodeTable.entries[240] = new OpcodeTableEntry(ret_p, "ret p", new ArgType[]{});
            opcodeTable.entries[250] = new OpcodeTableEntry(jp_m_nn, "jp m, {0}", new ArgType[]{ArgType.Word});
            opcodeTable.entries[252] = new OpcodeTableEntry(call_m_nn, "call m, {0}", new ArgType[]{ArgType.Word});
            opcodeTable.entries[248] = new OpcodeTableEntry(ret_m, "ret m", new ArgType[]{});

            var retnDecl = new OpcodeTableEntry(retn, "retn", new ArgType[]{});
            opcodeTableED.entries[0x45] = retnDecl;                                                     
            opcodeTableED.entries[0x55] = retnDecl;                                                     
            opcodeTableED.entries[0x65] = retnDecl;                                                     
            opcodeTableED.entries[0x75] = retnDecl;                                                     
            opcodeTableED.entries[0x5D] = retnDecl;                                                     
            opcodeTableED.entries[0x6D] = retnDecl;                                                     
            opcodeTableED.entries[0x7D] = retnDecl;
            
            opcodeTableED.entries[0x4D] = new OpcodeTableEntry(reti, "reti", new ArgType[]{});
            
            opcodeTable.entries[199] = new OpcodeTableEntry(rst_00h, "rst 00h", new ArgType[]{});
            opcodeTable.entries[207] = new OpcodeTableEntry(rst_08h, "rst 08h", new ArgType[]{});
            opcodeTable.entries[215] = new OpcodeTableEntry(rst_10h, "rst 10h", new ArgType[]{});
            opcodeTable.entries[223] = new OpcodeTableEntry(rst_18h, "rst 18h", new ArgType[]{});
            opcodeTable.entries[231] = new OpcodeTableEntry(rst_20h, "rst 20h", new ArgType[]{});
            opcodeTable.entries[239] = new OpcodeTableEntry(rst_28h, "rst 28h", new ArgType[]{});
            opcodeTable.entries[247] = new OpcodeTableEntry(rst_30h, "rst 30h", new ArgType[]{});
            opcodeTable.entries[255] = new OpcodeTableEntry(rst_38h, "rst 38h", new ArgType[]{});

            // Sophisticated indexed loads
            opcodeTableDDCB.entries[128] =
                new OpcodeTableEntry(ld_b_res_0__ix_d_,
                                     "ld b, res 0, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[128] =
                new OpcodeTableEntry(ld_b_res_0__iy_d_,
                                     "ld b, res 0, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[192] =
                new OpcodeTableEntry(ld_b_set_0__ix_d_,
                                     "ld b, set 0, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[192] =
                new OpcodeTableEntry(ld_b_set_0__iy_d_,
                                     "ld b, set 0, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[129] =
                new OpcodeTableEntry(ld_c_res_0__ix_d_,
                                     "ld c, res 0, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[129] =
                new OpcodeTableEntry(ld_c_res_0__iy_d_,
                                     "ld c, res 0, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[193] =
                new OpcodeTableEntry(ld_c_set_0__ix_d_,
                                     "ld c, set 0, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[193] =
                new OpcodeTableEntry(ld_c_set_0__iy_d_,
                                     "ld c, set 0, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[130] =
                new OpcodeTableEntry(ld_d_res_0__ix_d_,
                                     "ld d, res 0, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[130] =
                new OpcodeTableEntry(ld_d_res_0__iy_d_,
                                     "ld d, res 0, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[194] =
                new OpcodeTableEntry(ld_d_set_0__ix_d_,
                                     "ld d, set 0, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[194] =
                new OpcodeTableEntry(ld_d_set_0__iy_d_,
                                     "ld d, set 0, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[131] =
                new OpcodeTableEntry(ld_e_res_0__ix_d_,
                                     "ld e, res 0, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[131] =
                new OpcodeTableEntry(ld_e_res_0__iy_d_,
                                     "ld e, res 0, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[195] =
                new OpcodeTableEntry(ld_e_set_0__ix_d_,
                                     "ld e, set 0, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[195] =
                new OpcodeTableEntry(ld_e_set_0__iy_d_,
                                     "ld e, set 0, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[132] =
                new OpcodeTableEntry(ld_h_res_0__ix_d_,
                                     "ld h, res 0, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[132] =
                new OpcodeTableEntry(ld_h_res_0__iy_d_,
                                     "ld h, res 0, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[196] =
                new OpcodeTableEntry(ld_h_set_0__ix_d_,
                                     "ld h, set 0, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[196] =
                new OpcodeTableEntry(ld_h_set_0__iy_d_,
                                     "ld h, set 0, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[133] =
                new OpcodeTableEntry(ld_l_res_0__ix_d_,
                                     "ld l, res 0, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[133] =
                new OpcodeTableEntry(ld_l_res_0__iy_d_,
                                     "ld l, res 0, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[197] =
                new OpcodeTableEntry(ld_l_set_0__ix_d_,
                                     "ld l, set 0, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[197] =
                new OpcodeTableEntry(ld_l_set_0__iy_d_,
                                     "ld l, set 0, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[135] =
                new OpcodeTableEntry(ld_a_res_0__ix_d_,
                                     "ld a, res 0, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[135] =
                new OpcodeTableEntry(ld_a_res_0__iy_d_,
                                     "ld a, res 0, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[199] =
                new OpcodeTableEntry(ld_a_set_0__ix_d_,
                                     "ld a, set 0, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[199] =
                new OpcodeTableEntry(ld_a_set_0__iy_d_,
                                     "ld a, set 0, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[136] =
                new OpcodeTableEntry(ld_b_res_1__ix_d_,
                                     "ld b, res 1, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[136] =
                new OpcodeTableEntry(ld_b_res_1__iy_d_,
                                     "ld b, res 1, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[200] =
                new OpcodeTableEntry(ld_b_set_1__ix_d_,
                                     "ld b, set 1, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[200] =
                new OpcodeTableEntry(ld_b_set_1__iy_d_,
                                     "ld b, set 1, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[137] =
                new OpcodeTableEntry(ld_c_res_1__ix_d_,
                                     "ld c, res 1, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[137] =
                new OpcodeTableEntry(ld_c_res_1__iy_d_,
                                     "ld c, res 1, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[201] =
                new OpcodeTableEntry(ld_c_set_1__ix_d_,
                                     "ld c, set 1, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[201] =
                new OpcodeTableEntry(ld_c_set_1__iy_d_,
                                     "ld c, set 1, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[138] =
                new OpcodeTableEntry(ld_d_res_1__ix_d_,
                                     "ld d, res 1, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[138] =
                new OpcodeTableEntry(ld_d_res_1__iy_d_,
                                     "ld d, res 1, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[202] =
                new OpcodeTableEntry(ld_d_set_1__ix_d_,
                                     "ld d, set 1, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[202] =
                new OpcodeTableEntry(ld_d_set_1__iy_d_,
                                     "ld d, set 1, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[139] =
                new OpcodeTableEntry(ld_e_res_1__ix_d_,
                                     "ld e, res 1, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[139] =
                new OpcodeTableEntry(ld_e_res_1__iy_d_,
                                     "ld e, res 1, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[203] =
                new OpcodeTableEntry(ld_e_set_1__ix_d_,
                                     "ld e, set 1, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[203] =
                new OpcodeTableEntry(ld_e_set_1__iy_d_,
                                     "ld e, set 1, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[140] =
                new OpcodeTableEntry(ld_h_res_1__ix_d_,
                                     "ld h, res 1, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[140] =
                new OpcodeTableEntry(ld_h_res_1__iy_d_,
                                     "ld h, res 1, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[204] =
                new OpcodeTableEntry(ld_h_set_1__ix_d_,
                                     "ld h, set 1, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[204] =
                new OpcodeTableEntry(ld_h_set_1__iy_d_,
                                     "ld h, set 1, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[141] =
                new OpcodeTableEntry(ld_l_res_1__ix_d_,
                                     "ld l, res 1, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[141] =
                new OpcodeTableEntry(ld_l_res_1__iy_d_,
                                     "ld l, res 1, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[205] =
                new OpcodeTableEntry(ld_l_set_1__ix_d_,
                                     "ld l, set 1, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[205] =
                new OpcodeTableEntry(ld_l_set_1__iy_d_,
                                     "ld l, set 1, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[143] =
                new OpcodeTableEntry(ld_a_res_1__ix_d_,
                                     "ld a, res 1, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[143] =
                new OpcodeTableEntry(ld_a_res_1__iy_d_,
                                     "ld a, res 1, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[207] =
                new OpcodeTableEntry(ld_a_set_1__ix_d_,
                                     "ld a, set 1, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[207] =
                new OpcodeTableEntry(ld_a_set_1__iy_d_,
                                     "ld a, set 1, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[144] =
                new OpcodeTableEntry(ld_b_res_2__ix_d_,
                                     "ld b, res 2, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[144] =
                new OpcodeTableEntry(ld_b_res_2__iy_d_,
                                     "ld b, res 2, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[208] =
                new OpcodeTableEntry(ld_b_set_2__ix_d_,
                                     "ld b, set 2, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[208] =
                new OpcodeTableEntry(ld_b_set_2__iy_d_,
                                     "ld b, set 2, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[145] =
                new OpcodeTableEntry(ld_c_res_2__ix_d_,
                                     "ld c, res 2, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[145] =
                new OpcodeTableEntry(ld_c_res_2__iy_d_,
                                     "ld c, res 2, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[209] =
                new OpcodeTableEntry(ld_c_set_2__ix_d_,
                                     "ld c, set 2, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[209] =
                new OpcodeTableEntry(ld_c_set_2__iy_d_,
                                     "ld c, set 2, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[146] =
                new OpcodeTableEntry(ld_d_res_2__ix_d_,
                                     "ld d, res 2, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[146] =
                new OpcodeTableEntry(ld_d_res_2__iy_d_,
                                     "ld d, res 2, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[210] =
                new OpcodeTableEntry(ld_d_set_2__ix_d_,
                                     "ld d, set 2, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[210] =
                new OpcodeTableEntry(ld_d_set_2__iy_d_,
                                     "ld d, set 2, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[147] =
                new OpcodeTableEntry(ld_e_res_2__ix_d_,
                                     "ld e, res 2, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[147] =
                new OpcodeTableEntry(ld_e_res_2__iy_d_,
                                     "ld e, res 2, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[211] =
                new OpcodeTableEntry(ld_e_set_2__ix_d_,
                                     "ld e, set 2, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[211] =
                new OpcodeTableEntry(ld_e_set_2__iy_d_,
                                     "ld e, set 2, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[148] =
                new OpcodeTableEntry(ld_h_res_2__ix_d_,
                                     "ld h, res 2, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[148] =
                new OpcodeTableEntry(ld_h_res_2__iy_d_,
                                     "ld h, res 2, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[212] =
                new OpcodeTableEntry(ld_h_set_2__ix_d_,
                                     "ld h, set 2, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[212] =
                new OpcodeTableEntry(ld_h_set_2__iy_d_,
                                     "ld h, set 2, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[149] =
                new OpcodeTableEntry(ld_l_res_2__ix_d_,
                                     "ld l, res 2, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[149] =
                new OpcodeTableEntry(ld_l_res_2__iy_d_,
                                     "ld l, res 2, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[213] =
                new OpcodeTableEntry(ld_l_set_2__ix_d_,
                                     "ld l, set 2, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[213] =
                new OpcodeTableEntry(ld_l_set_2__iy_d_,
                                     "ld l, set 2, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[151] =
                new OpcodeTableEntry(ld_a_res_2__ix_d_,
                                     "ld a, res 2, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[151] =
                new OpcodeTableEntry(ld_a_res_2__iy_d_,
                                     "ld a, res 2, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[215] =
                new OpcodeTableEntry(ld_a_set_2__ix_d_,
                                     "ld a, set 2, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[215] =
                new OpcodeTableEntry(ld_a_set_2__iy_d_,
                                     "ld a, set 2, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[152] =
                new OpcodeTableEntry(ld_b_res_3__ix_d_,
                                     "ld b, res 3, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[152] =
                new OpcodeTableEntry(ld_b_res_3__iy_d_,
                                     "ld b, res 3, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[216] =
                new OpcodeTableEntry(ld_b_set_3__ix_d_,
                                     "ld b, set 3, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[216] =
                new OpcodeTableEntry(ld_b_set_3__iy_d_,
                                     "ld b, set 3, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[153] =
                new OpcodeTableEntry(ld_c_res_3__ix_d_,
                                     "ld c, res 3, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[153] =
                new OpcodeTableEntry(ld_c_res_3__iy_d_,
                                     "ld c, res 3, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[217] =
                new OpcodeTableEntry(ld_c_set_3__ix_d_,
                                     "ld c, set 3, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[217] =
                new OpcodeTableEntry(ld_c_set_3__iy_d_,
                                     "ld c, set 3, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[154] =
                new OpcodeTableEntry(ld_d_res_3__ix_d_,
                                     "ld d, res 3, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[154] =
                new OpcodeTableEntry(ld_d_res_3__iy_d_,
                                     "ld d, res 3, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[218] =
                new OpcodeTableEntry(ld_d_set_3__ix_d_,
                                     "ld d, set 3, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[218] =
                new OpcodeTableEntry(ld_d_set_3__iy_d_,
                                     "ld d, set 3, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[155] =
                new OpcodeTableEntry(ld_e_res_3__ix_d_,
                                     "ld e, res 3, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[155] =
                new OpcodeTableEntry(ld_e_res_3__iy_d_,
                                     "ld e, res 3, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[219] =
                new OpcodeTableEntry(ld_e_set_3__ix_d_,
                                     "ld e, set 3, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[219] =
                new OpcodeTableEntry(ld_e_set_3__iy_d_,
                                     "ld e, set 3, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[156] =
                new OpcodeTableEntry(ld_h_res_3__ix_d_,
                                     "ld h, res 3, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[156] =
                new OpcodeTableEntry(ld_h_res_3__iy_d_,
                                     "ld h, res 3, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[220] =
                new OpcodeTableEntry(ld_h_set_3__ix_d_,
                                     "ld h, set 3, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[220] =
                new OpcodeTableEntry(ld_h_set_3__iy_d_,
                                     "ld h, set 3, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[157] =
                new OpcodeTableEntry(ld_l_res_3__ix_d_,
                                     "ld l, res 3, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[157] =
                new OpcodeTableEntry(ld_l_res_3__iy_d_,
                                     "ld l, res 3, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[221] =
                new OpcodeTableEntry(ld_l_set_3__ix_d_,
                                     "ld l, set 3, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[221] =
                new OpcodeTableEntry(ld_l_set_3__iy_d_,
                                     "ld l, set 3, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[159] =
                new OpcodeTableEntry(ld_a_res_3__ix_d_,
                                     "ld a, res 3, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[159] =
                new OpcodeTableEntry(ld_a_res_3__iy_d_,
                                     "ld a, res 3, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[223] =
                new OpcodeTableEntry(ld_a_set_3__ix_d_,
                                     "ld a, set 3, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[223] =
                new OpcodeTableEntry(ld_a_set_3__iy_d_,
                                     "ld a, set 3, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[160] =
                new OpcodeTableEntry(ld_b_res_4__ix_d_,
                                     "ld b, res 4, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[160] =
                new OpcodeTableEntry(ld_b_res_4__iy_d_,
                                     "ld b, res 4, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[224] =
                new OpcodeTableEntry(ld_b_set_4__ix_d_,
                                     "ld b, set 4, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[224] =
                new OpcodeTableEntry(ld_b_set_4__iy_d_,
                                     "ld b, set 4, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[161] =
                new OpcodeTableEntry(ld_c_res_4__ix_d_,
                                     "ld c, res 4, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[161] =
                new OpcodeTableEntry(ld_c_res_4__iy_d_,
                                     "ld c, res 4, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[225] =
                new OpcodeTableEntry(ld_c_set_4__ix_d_,
                                     "ld c, set 4, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[225] =
                new OpcodeTableEntry(ld_c_set_4__iy_d_,
                                     "ld c, set 4, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[162] =
                new OpcodeTableEntry(ld_d_res_4__ix_d_,
                                     "ld d, res 4, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[162] =
                new OpcodeTableEntry(ld_d_res_4__iy_d_,
                                     "ld d, res 4, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[226] =
                new OpcodeTableEntry(ld_d_set_4__ix_d_,
                                     "ld d, set 4, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[226] =
                new OpcodeTableEntry(ld_d_set_4__iy_d_,
                                     "ld d, set 4, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[163] =
                new OpcodeTableEntry(ld_e_res_4__ix_d_,
                                     "ld e, res 4, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[163] =
                new OpcodeTableEntry(ld_e_res_4__iy_d_,
                                     "ld e, res 4, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[227] =
                new OpcodeTableEntry(ld_e_set_4__ix_d_,
                                     "ld e, set 4, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[227] =
                new OpcodeTableEntry(ld_e_set_4__iy_d_,
                                     "ld e, set 4, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[164] =
                new OpcodeTableEntry(ld_h_res_4__ix_d_,
                                     "ld h, res 4, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[164] =
                new OpcodeTableEntry(ld_h_res_4__iy_d_,
                                     "ld h, res 4, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[228] =
                new OpcodeTableEntry(ld_h_set_4__ix_d_,
                                     "ld h, set 4, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[228] =
                new OpcodeTableEntry(ld_h_set_4__iy_d_,
                                     "ld h, set 4, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[165] =
                new OpcodeTableEntry(ld_l_res_4__ix_d_,
                                     "ld l, res 4, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[165] =
                new OpcodeTableEntry(ld_l_res_4__iy_d_,
                                     "ld l, res 4, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[229] =
                new OpcodeTableEntry(ld_l_set_4__ix_d_,
                                     "ld l, set 4, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[229] =
                new OpcodeTableEntry(ld_l_set_4__iy_d_,
                                     "ld l, set 4, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[167] =
                new OpcodeTableEntry(ld_a_res_4__ix_d_,
                                     "ld a, res 4, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[167] =
                new OpcodeTableEntry(ld_a_res_4__iy_d_,
                                     "ld a, res 4, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[231] =
                new OpcodeTableEntry(ld_a_set_4__ix_d_,
                                     "ld a, set 4, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[231] =
                new OpcodeTableEntry(ld_a_set_4__iy_d_,
                                     "ld a, set 4, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[168] =
                new OpcodeTableEntry(ld_b_res_5__ix_d_,
                                     "ld b, res 5, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[168] =
                new OpcodeTableEntry(ld_b_res_5__iy_d_,
                                     "ld b, res 5, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[232] =
                new OpcodeTableEntry(ld_b_set_5__ix_d_,
                                     "ld b, set 5, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[232] =
                new OpcodeTableEntry(ld_b_set_5__iy_d_,
                                     "ld b, set 5, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[169] =
                new OpcodeTableEntry(ld_c_res_5__ix_d_,
                                     "ld c, res 5, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[169] =
                new OpcodeTableEntry(ld_c_res_5__iy_d_,
                                     "ld c, res 5, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[233] =
                new OpcodeTableEntry(ld_c_set_5__ix_d_,
                                     "ld c, set 5, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[233] =
                new OpcodeTableEntry(ld_c_set_5__iy_d_,
                                     "ld c, set 5, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[170] =
                new OpcodeTableEntry(ld_d_res_5__ix_d_,
                                     "ld d, res 5, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[170] =
                new OpcodeTableEntry(ld_d_res_5__iy_d_,
                                     "ld d, res 5, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[234] =
                new OpcodeTableEntry(ld_d_set_5__ix_d_,
                                     "ld d, set 5, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[234] =
                new OpcodeTableEntry(ld_d_set_5__iy_d_,
                                     "ld d, set 5, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[171] =
                new OpcodeTableEntry(ld_e_res_5__ix_d_,
                                     "ld e, res 5, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[171] =
                new OpcodeTableEntry(ld_e_res_5__iy_d_,
                                     "ld e, res 5, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[235] =
                new OpcodeTableEntry(ld_e_set_5__ix_d_,
                                     "ld e, set 5, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[235] =
                new OpcodeTableEntry(ld_e_set_5__iy_d_,
                                     "ld e, set 5, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[172] =
                new OpcodeTableEntry(ld_h_res_5__ix_d_,
                                     "ld h, res 5, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[172] =
                new OpcodeTableEntry(ld_h_res_5__iy_d_,
                                     "ld h, res 5, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[236] =
                new OpcodeTableEntry(ld_h_set_5__ix_d_,
                                     "ld h, set 5, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[236] =
                new OpcodeTableEntry(ld_h_set_5__iy_d_,
                                     "ld h, set 5, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[173] =
                new OpcodeTableEntry(ld_l_res_5__ix_d_,
                                     "ld l, res 5, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[173] =
                new OpcodeTableEntry(ld_l_res_5__iy_d_,
                                     "ld l, res 5, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[237] =
                new OpcodeTableEntry(ld_l_set_5__ix_d_,
                                     "ld l, set 5, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[237] =
                new OpcodeTableEntry(ld_l_set_5__iy_d_,
                                     "ld l, set 5, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[175] =
                new OpcodeTableEntry(ld_a_res_5__ix_d_,
                                     "ld a, res 5, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[175] =
                new OpcodeTableEntry(ld_a_res_5__iy_d_,
                                     "ld a, res 5, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[239] =
                new OpcodeTableEntry(ld_a_set_5__ix_d_,
                                     "ld a, set 5, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[239] =
                new OpcodeTableEntry(ld_a_set_5__iy_d_,
                                     "ld a, set 5, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[176] =
                new OpcodeTableEntry(ld_b_res_6__ix_d_,
                                     "ld b, res 6, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[176] =
                new OpcodeTableEntry(ld_b_res_6__iy_d_,
                                     "ld b, res 6, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[240] =
                new OpcodeTableEntry(ld_b_set_6__ix_d_,
                                     "ld b, set 6, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[240] =
                new OpcodeTableEntry(ld_b_set_6__iy_d_,
                                     "ld b, set 6, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[177] =
                new OpcodeTableEntry(ld_c_res_6__ix_d_,
                                     "ld c, res 6, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[177] =
                new OpcodeTableEntry(ld_c_res_6__iy_d_,
                                     "ld c, res 6, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[241] =
                new OpcodeTableEntry(ld_c_set_6__ix_d_,
                                     "ld c, set 6, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[241] =
                new OpcodeTableEntry(ld_c_set_6__iy_d_,
                                     "ld c, set 6, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[178] =
                new OpcodeTableEntry(ld_d_res_6__ix_d_,
                                     "ld d, res 6, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[178] =
                new OpcodeTableEntry(ld_d_res_6__iy_d_,
                                     "ld d, res 6, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[242] =
                new OpcodeTableEntry(ld_d_set_6__ix_d_,
                                     "ld d, set 6, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[242] =
                new OpcodeTableEntry(ld_d_set_6__iy_d_,
                                     "ld d, set 6, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[179] =
                new OpcodeTableEntry(ld_e_res_6__ix_d_,
                                     "ld e, res 6, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[179] =
                new OpcodeTableEntry(ld_e_res_6__iy_d_,
                                     "ld e, res 6, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[243] =
                new OpcodeTableEntry(ld_e_set_6__ix_d_,
                                     "ld e, set 6, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[243] =
                new OpcodeTableEntry(ld_e_set_6__iy_d_,
                                     "ld e, set 6, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[180] =
                new OpcodeTableEntry(ld_h_res_6__ix_d_,
                                     "ld h, res 6, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[180] =
                new OpcodeTableEntry(ld_h_res_6__iy_d_,
                                     "ld h, res 6, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[244] =
                new OpcodeTableEntry(ld_h_set_6__ix_d_,
                                     "ld h, set 6, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[244] =
                new OpcodeTableEntry(ld_h_set_6__iy_d_,
                                     "ld h, set 6, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[181] =
                new OpcodeTableEntry(ld_l_res_6__ix_d_,
                                     "ld l, res 6, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[181] =
                new OpcodeTableEntry(ld_l_res_6__iy_d_,
                                     "ld l, res 6, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[245] =
                new OpcodeTableEntry(ld_l_set_6__ix_d_,
                                     "ld l, set 6, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[245] =
                new OpcodeTableEntry(ld_l_set_6__iy_d_,
                                     "ld l, set 6, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[183] =
                new OpcodeTableEntry(ld_a_res_6__ix_d_,
                                     "ld a, res 6, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[183] =
                new OpcodeTableEntry(ld_a_res_6__iy_d_,
                                     "ld a, res 6, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[247] =
                new OpcodeTableEntry(ld_a_set_6__ix_d_,
                                     "ld a, set 6, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[247] =
                new OpcodeTableEntry(ld_a_set_6__iy_d_,
                                     "ld a, set 6, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[184] =
                new OpcodeTableEntry(ld_b_res_7__ix_d_,
                                     "ld b, res 7, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[184] =
                new OpcodeTableEntry(ld_b_res_7__iy_d_,
                                     "ld b, res 7, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[248] =
                new OpcodeTableEntry(ld_b_set_7__ix_d_,
                                     "ld b, set 7, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[248] =
                new OpcodeTableEntry(ld_b_set_7__iy_d_,
                                     "ld b, set 7, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[185] =
                new OpcodeTableEntry(ld_c_res_7__ix_d_,
                                     "ld c, res 7, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[185] =
                new OpcodeTableEntry(ld_c_res_7__iy_d_,
                                     "ld c, res 7, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[249] =
                new OpcodeTableEntry(ld_c_set_7__ix_d_,
                                     "ld c, set 7, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[249] =
                new OpcodeTableEntry(ld_c_set_7__iy_d_,
                                     "ld c, set 7, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[186] =
                new OpcodeTableEntry(ld_d_res_7__ix_d_,
                                     "ld d, res 7, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[186] =
                new OpcodeTableEntry(ld_d_res_7__iy_d_,
                                     "ld d, res 7, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[250] =
                new OpcodeTableEntry(ld_d_set_7__ix_d_,
                                     "ld d, set 7, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[250] =
                new OpcodeTableEntry(ld_d_set_7__iy_d_,
                                     "ld d, set 7, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[187] =
                new OpcodeTableEntry(ld_e_res_7__ix_d_,
                                     "ld e, res 7, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[187] =
                new OpcodeTableEntry(ld_e_res_7__iy_d_,
                                     "ld e, res 7, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[251] =
                new OpcodeTableEntry(ld_e_set_7__ix_d_,
                                     "ld e, set 7, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[251] =
                new OpcodeTableEntry(ld_e_set_7__iy_d_,
                                     "ld e, set 7, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[188] =
                new OpcodeTableEntry(ld_h_res_7__ix_d_,
                                     "ld h, res 7, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[188] =
                new OpcodeTableEntry(ld_h_res_7__iy_d_,
                                     "ld h, res 7, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[252] =
                new OpcodeTableEntry(ld_h_set_7__ix_d_,
                                     "ld h, set 7, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[252] =
                new OpcodeTableEntry(ld_h_set_7__iy_d_,
                                     "ld h, set 7, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[189] =
                new OpcodeTableEntry(ld_l_res_7__ix_d_,
                                     "ld l, res 7, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[189] =
                new OpcodeTableEntry(ld_l_res_7__iy_d_,
                                     "ld l, res 7, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[253] =
                new OpcodeTableEntry(ld_l_set_7__ix_d_,
                                     "ld l, set 7, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[253] =
                new OpcodeTableEntry(ld_l_set_7__iy_d_,
                                     "ld l, set 7, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[191] =
                new OpcodeTableEntry(ld_a_res_7__ix_d_,
                                     "ld a, res 7, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[191] =
                new OpcodeTableEntry(ld_a_res_7__iy_d_,
                                     "ld a, res 7, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[255] =
                new OpcodeTableEntry(ld_a_set_7__ix_d_,
                                     "ld a, set 7, (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[255] =
                new OpcodeTableEntry(ld_a_set_7__iy_d_,
                                     "ld a, set 7, (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[32] =
                new OpcodeTableEntry(ld_b_sla__ix_d_,
                                     "ld b, sla (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[40] =
                new OpcodeTableEntry(ld_b_sra__ix_d_,
                                     "ld b, sra (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[48] =
                new OpcodeTableEntry(ld_b_sll__ix_d_,
                                     "ld b, sll (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[56] =
                new OpcodeTableEntry(ld_b_srl__ix_d_,
                                     "ld b, srl (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[0] =
                new OpcodeTableEntry(ld_b_rlc__ix_d_,
                                     "ld b, rlc (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[8] =
                new OpcodeTableEntry(ld_b_rrc__ix_d_,
                                     "ld b, rrc (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[16] =
                new OpcodeTableEntry(ld_b_rl__ix_d_,
                                     "ld b, rl (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[24] =
                new OpcodeTableEntry(ld_b_rr__ix_d_,
                                     "ld b, rr (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[32] =
                new OpcodeTableEntry(ld_b_sla__iy_d_,
                                     "ld b, sla (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[40] =
                new OpcodeTableEntry(ld_b_sra__iy_d_,
                                     "ld b, sra (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[48] =
                new OpcodeTableEntry(ld_b_sll__iy_d_,
                                     "ld b, sll (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[56] =
                new OpcodeTableEntry(ld_b_srl__iy_d_,
                                     "ld b, srl (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[0] =
                new OpcodeTableEntry(ld_b_rlc__iy_d_,
                                     "ld b, rlc (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[8] =
                new OpcodeTableEntry(ld_b_rrc__iy_d_,
                                     "ld b, rrc (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[16] =
                new OpcodeTableEntry(ld_b_rl__iy_d_,
                                     "ld b, rl (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[24] =
                new OpcodeTableEntry(ld_b_rr__iy_d_,
                                     "ld b, rr (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[33] =
                new OpcodeTableEntry(ld_c_sla__ix_d_,
                                     "ld c, sla (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[41] =
                new OpcodeTableEntry(ld_c_sra__ix_d_,
                                     "ld c, sra (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[49] =
                new OpcodeTableEntry(ld_c_sll__ix_d_,
                                     "ld c, sll (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[57] =
                new OpcodeTableEntry(ld_c_srl__ix_d_,
                                     "ld c, srl (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[1] =
                new OpcodeTableEntry(ld_c_rlc__ix_d_,
                                     "ld c, rlc (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[9] =
                new OpcodeTableEntry(ld_c_rrc__ix_d_,
                                     "ld c, rrc (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[17] =
                new OpcodeTableEntry(ld_c_rl__ix_d_,
                                     "ld c, rl (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[25] =
                new OpcodeTableEntry(ld_c_rr__ix_d_,
                                     "ld c, rr (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[33] =
                new OpcodeTableEntry(ld_c_sla__iy_d_,
                                     "ld c, sla (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[41] =
                new OpcodeTableEntry(ld_c_sra__iy_d_,
                                     "ld c, sra (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[49] =
                new OpcodeTableEntry(ld_c_sll__iy_d_,
                                     "ld c, sll (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[57] =
                new OpcodeTableEntry(ld_c_srl__iy_d_,
                                     "ld c, srl (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[1] =
                new OpcodeTableEntry(ld_c_rlc__iy_d_,
                                     "ld c, rlc (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[9] =
                new OpcodeTableEntry(ld_c_rrc__iy_d_,
                                     "ld c, rrc (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[17] =
                new OpcodeTableEntry(ld_c_rl__iy_d_,
                                     "ld c, rl (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[25] =
                new OpcodeTableEntry(ld_c_rr__iy_d_,
                                     "ld c, rr (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[34] =
                new OpcodeTableEntry(ld_d_sla__ix_d_,
                                     "ld d, sla (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[42] =
                new OpcodeTableEntry(ld_d_sra__ix_d_,
                                     "ld d, sra (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[50] =
                new OpcodeTableEntry(ld_d_sll__ix_d_,
                                     "ld d, sll (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[58] =
                new OpcodeTableEntry(ld_d_srl__ix_d_,
                                     "ld d, srl (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[2] =
                new OpcodeTableEntry(ld_d_rlc__ix_d_,
                                     "ld d, rlc (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[10] =
                new OpcodeTableEntry(ld_d_rrc__ix_d_,
                                     "ld d, rrc (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[18] =
                new OpcodeTableEntry(ld_d_rl__ix_d_,
                                     "ld d, rl (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[26] =
                new OpcodeTableEntry(ld_d_rr__ix_d_,
                                     "ld d, rr (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[34] =
                new OpcodeTableEntry(ld_d_sla__iy_d_,
                                     "ld d, sla (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[42] =
                new OpcodeTableEntry(ld_d_sra__iy_d_,
                                     "ld d, sra (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[50] =
                new OpcodeTableEntry(ld_d_sll__iy_d_,
                                     "ld d, sll (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[58] =
                new OpcodeTableEntry(ld_d_srl__iy_d_,
                                     "ld d, srl (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[2] =
                new OpcodeTableEntry(ld_d_rlc__iy_d_,
                                     "ld d, rlc (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[10] =
                new OpcodeTableEntry(ld_d_rrc__iy_d_,
                                     "ld d, rrc (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[18] =
                new OpcodeTableEntry(ld_d_rl__iy_d_,
                                     "ld d, rl (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[26] =
                new OpcodeTableEntry(ld_d_rr__iy_d_,
                                     "ld d, rr (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[35] =
                new OpcodeTableEntry(ld_e_sla__ix_d_,
                                     "ld e, sla (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[43] =
                new OpcodeTableEntry(ld_e_sra__ix_d_,
                                     "ld e, sra (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[51] =
                new OpcodeTableEntry(ld_e_sll__ix_d_,
                                     "ld e, sll (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[59] =
                new OpcodeTableEntry(ld_e_srl__ix_d_,
                                     "ld e, srl (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[3] =
                new OpcodeTableEntry(ld_e_rlc__ix_d_,
                                     "ld e, rlc (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[11] =
                new OpcodeTableEntry(ld_e_rrc__ix_d_,
                                     "ld e, rrc (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[19] =
                new OpcodeTableEntry(ld_e_rl__ix_d_,
                                     "ld e, rl (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[27] =
                new OpcodeTableEntry(ld_e_rr__ix_d_,
                                     "ld e, rr (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[35] =
                new OpcodeTableEntry(ld_e_sla__iy_d_,
                                     "ld e, sla (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[43] =
                new OpcodeTableEntry(ld_e_sra__iy_d_,
                                     "ld e, sra (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[51] =
                new OpcodeTableEntry(ld_e_sll__iy_d_,
                                     "ld e, sll (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[59] =
                new OpcodeTableEntry(ld_e_srl__iy_d_,
                                     "ld e, srl (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[3] =
                new OpcodeTableEntry(ld_e_rlc__iy_d_,
                                     "ld e, rlc (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[11] =
                new OpcodeTableEntry(ld_e_rrc__iy_d_,
                                     "ld e, rrc (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[19] =
                new OpcodeTableEntry(ld_e_rl__iy_d_,
                                     "ld e, rl (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[27] =
                new OpcodeTableEntry(ld_e_rr__iy_d_,
                                     "ld e, rr (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[36] =
                new OpcodeTableEntry(ld_h_sla__ix_d_,
                                     "ld h, sla (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[44] =
                new OpcodeTableEntry(ld_h_sra__ix_d_,
                                     "ld h, sra (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[52] =
                new OpcodeTableEntry(ld_h_sll__ix_d_,
                                     "ld h, sll (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[60] =
                new OpcodeTableEntry(ld_h_srl__ix_d_,
                                     "ld h, srl (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[4] =
                new OpcodeTableEntry(ld_h_rlc__ix_d_,
                                     "ld h, rlc (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[12] =
                new OpcodeTableEntry(ld_h_rrc__ix_d_,
                                     "ld h, rrc (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[20] =
                new OpcodeTableEntry(ld_h_rl__ix_d_,
                                     "ld h, rl (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[28] =
                new OpcodeTableEntry(ld_h_rr__ix_d_,
                                     "ld h, rr (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[36] =
                new OpcodeTableEntry(ld_h_sla__iy_d_,
                                     "ld h, sla (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[44] =
                new OpcodeTableEntry(ld_h_sra__iy_d_,
                                     "ld h, sra (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[52] =
                new OpcodeTableEntry(ld_h_sll__iy_d_,
                                     "ld h, sll (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[60] =
                new OpcodeTableEntry(ld_h_srl__iy_d_,
                                     "ld h, srl (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[4] =
                new OpcodeTableEntry(ld_h_rlc__iy_d_,
                                     "ld h, rlc (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[12] =
                new OpcodeTableEntry(ld_h_rrc__iy_d_,
                                     "ld h, rrc (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[20] =
                new OpcodeTableEntry(ld_h_rl__iy_d_,
                                     "ld h, rl (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[28] =
                new OpcodeTableEntry(ld_h_rr__iy_d_,
                                     "ld h, rr (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[37] =
                new OpcodeTableEntry(ld_l_sla__ix_d_,
                                     "ld l, sla (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[45] =
                new OpcodeTableEntry(ld_l_sra__ix_d_,
                                     "ld l, sra (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[53] =
                new OpcodeTableEntry(ld_l_sll__ix_d_,
                                     "ld l, sll (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[61] =
                new OpcodeTableEntry(ld_l_srl__ix_d_,
                                     "ld l, srl (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[5] =
                new OpcodeTableEntry(ld_l_rlc__ix_d_,
                                     "ld l, rlc (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[13] =
                new OpcodeTableEntry(ld_l_rrc__ix_d_,
                                     "ld l, rrc (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[21] =
                new OpcodeTableEntry(ld_l_rl__ix_d_,
                                     "ld l, rl (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[29] =
                new OpcodeTableEntry(ld_l_rr__ix_d_,
                                     "ld l, rr (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[37] =
                new OpcodeTableEntry(ld_l_sla__iy_d_,
                                     "ld l, sla (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[45] =
                new OpcodeTableEntry(ld_l_sra__iy_d_,
                                     "ld l, sra (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[53] =
                new OpcodeTableEntry(ld_l_sll__iy_d_,
                                     "ld l, sll (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[61] =
                new OpcodeTableEntry(ld_l_srl__iy_d_,
                                     "ld l, srl (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[5] =
                new OpcodeTableEntry(ld_l_rlc__iy_d_,
                                     "ld l, rlc (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[13] =
                new OpcodeTableEntry(ld_l_rrc__iy_d_,
                                     "ld l, rrc (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[21] =
                new OpcodeTableEntry(ld_l_rl__iy_d_,
                                     "ld l, rl (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[29] =
                new OpcodeTableEntry(ld_l_rr__iy_d_,
                                     "ld l, rr (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[39] =
                new OpcodeTableEntry(ld_a_sla__ix_d_,
                                     "ld a, sla (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[47] =
                new OpcodeTableEntry(ld_a_sra__ix_d_,
                                     "ld a, sra (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[55] =
                new OpcodeTableEntry(ld_a_sll__ix_d_,
                                     "ld a, sll (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[63] =
                new OpcodeTableEntry(ld_a_srl__ix_d_,
                                     "ld a, srl (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[7] =
                new OpcodeTableEntry(ld_a_rlc__ix_d_,
                                     "ld a, rlc (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[15] =
                new OpcodeTableEntry(ld_a_rrc__ix_d_,
                                     "ld a, rrc (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[23] =
                new OpcodeTableEntry(ld_a_rl__ix_d_,
                                     "ld a, rl (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xcb].nextTable.entries[31] =
                new OpcodeTableEntry(ld_a_rr__ix_d_,
                                     "ld a, rr (ix{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[39] =
                new OpcodeTableEntry(ld_a_sla__iy_d_,
                                     "ld a, sla (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[47] =
                new OpcodeTableEntry(ld_a_sra__iy_d_,
                                     "ld a, sra (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[55] =
                new OpcodeTableEntry(ld_a_sll__iy_d_,
                                     "ld a, sll (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[63] =
                new OpcodeTableEntry(ld_a_srl__iy_d_,
                                     "ld a, srl (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[7] =
                new OpcodeTableEntry(ld_a_rlc__iy_d_,
                                     "ld a, rlc (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[15] =
                new OpcodeTableEntry(ld_a_rrc__iy_d_,
                                     "ld a, rrc (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[23] =
                new OpcodeTableEntry(ld_a_rl__iy_d_,
                                     "ld a, rl (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xcb].nextTable.entries[31] =
                new OpcodeTableEntry(ld_a_rr__iy_d_,
                                     "ld a, rr (iy{0})",
                                     new ArgType[]{ArgType.Offset});
            for (var code = 0; code < 256; code++) {
                if (opcodeTableDD.entries[code] == null) {
                    opcodeTableDD.entries[code] = opcodeTable.entries[code];
                }
                if (opcodeTableFD.entries[code] == null) {
                    opcodeTableFD.entries[code] = opcodeTable.entries[code];
                }
            }
                                                                                                                                                                                                
        }
        
        void nop() {
            // NOP
        }
        void ld_a_a() {
        }

        void ld_a_b() {
            r1.a = r1.b;
        }

        void ld_a_c() {
            r1.a = r1.c;
        }

        void ld_a_d() {
            r1.a = r1.d;
        }

        void ld_a_e() {
            r1.a = r1.e;
        }

        void ld_a_h() {
            r1.a = r1.h;
        }

        void ld_a_l() {
            r1.a = r1.l;
        }

        void ld_a_ixh() {
            r1.a = r1.ixh;
        }

        void ld_a_ixl() {
            r1.a = r1.ixl;
        }

        void ld_a_iyh() {
            r1.a = r1.iyh;
        }

        void ld_a_iyl() {
            r1.a = r1.iyl;
        }

        void ld_b_a() {
            r1.b = r1.a;
        }

        void ld_b_b() {
        }

        void ld_b_c() {
            r1.b = r1.c;
        }

        void ld_b_d() {
            r1.b = r1.d;
        }

        void ld_b_e() {
            r1.b = r1.e;
        }

        void ld_b_h() {
            r1.b = r1.h;
        }

        void ld_b_l() {
            r1.b = r1.l;
        }

        void ld_b_ixh() {
            r1.b = r1.ixh;
        }

        void ld_b_ixl() {
            r1.b = r1.ixl;
        }

        void ld_b_iyh() {
            r1.b = r1.iyh;
        }

        void ld_b_iyl() {
            r1.b = r1.iyl;
        }

        void ld_c_a() {
            r1.c = r1.a;
        }

        void ld_c_b() {
            r1.c = r1.b;
        }

        void ld_c_c() {
        }

        void ld_c_d() {
            r1.c = r1.d;
        }

        void ld_c_e() {
            r1.c = r1.e;
        }

        void ld_c_h() {
            r1.c = r1.h;
        }

        void ld_c_l() {
            r1.c = r1.l;
        }

        void ld_c_ixh() {
            r1.c = r1.ixh;
        }

        void ld_c_ixl() {
            r1.c = r1.ixl;
        }

        void ld_c_iyh() {
            r1.c = r1.iyh;
        }

        void ld_c_iyl() {
            r1.c = r1.iyl;
        }

        void ld_d_a() {
            r1.d = r1.a;
        }

        void ld_d_b() {
            r1.d = r1.b;
        }

        void ld_d_c() {
            r1.d = r1.c;
        }

        void ld_d_d() {
        }

        void ld_d_e() {
            r1.d = r1.e;
        }

        void ld_d_h() {
            r1.d = r1.h;
        }

        void ld_d_l() {
            r1.d = r1.l;
        }

        void ld_d_ixh() {
            r1.d = r1.ixh;
        }

        void ld_d_ixl() {
            r1.d = r1.ixl;
        }

        void ld_d_iyh() {
            r1.d = r1.iyh;
        }

        void ld_d_iyl() {
            r1.d = r1.iyl;
        }

        void ld_e_a() {
            r1.e = r1.a;
        }

        void ld_e_b() {
            r1.e = r1.b;
        }

        void ld_e_c() {
            r1.e = r1.c;
        }

        void ld_e_d() {
            r1.e = r1.d;
        }

        void ld_e_e() {
        }

        void ld_e_h() {
            r1.e = r1.h;
        }

        void ld_e_l() {
            r1.e = r1.l;
        }

        void ld_e_ixh() {
            r1.e = r1.ixh;
        }

        void ld_e_ixl() {
            r1.e = r1.ixl;
        }

        void ld_e_iyh() {
            r1.e = r1.iyh;
        }

        void ld_e_iyl() {
            r1.e = r1.iyl;
        }

        void ld_h_a() {
            r1.h = r1.a;
        }

        void ld_h_b() {
            r1.h = r1.b;
        }

        void ld_h_c() {
            r1.h = r1.c;
        }

        void ld_h_d() {
            r1.h = r1.d;
        }

        void ld_h_e() {
            r1.h = r1.e;
        }

        void ld_h_h() {
        }

        void ld_h_l() {
            r1.h = r1.l;
        }

        void ld_h_ixh() {
            r1.h = r1.ixh;
        }

        void ld_h_ixl() {
            r1.h = r1.ixl;
        }

        void ld_h_iyh() {
            r1.h = r1.iyh;
        }

        void ld_h_iyl() {
            r1.h = r1.iyl;
        }

        void ld_l_a() {
            r1.l = r1.a;
        }

        void ld_l_b() {
            r1.l = r1.b;
        }

        void ld_l_c() {
            r1.l = r1.c;
        }

        void ld_l_d() {
            r1.l = r1.d;
        }

        void ld_l_e() {
            r1.l = r1.e;
        }

        void ld_l_h() {
            r1.l = r1.h;
        }

        void ld_l_l() {
        }

        void ld_l_ixh() {
            r1.l = r1.ixh;
        }

        void ld_l_ixl() {
            r1.l = r1.ixl;
        }

        void ld_l_iyh() {
            r1.l = r1.iyh;
        }

        void ld_l_iyl() {
            r1.l = r1.iyl;
        }

        void ld_ixh_a() {
            r1.ixh = r1.a;
        }

        void ld_ixh_b() {
            r1.ixh = r1.b;
        }

        void ld_ixh_c() {
            r1.ixh = r1.c;
        }

        void ld_ixh_d() {
            r1.ixh = r1.d;
        }

        void ld_ixh_e() {
            r1.ixh = r1.e;
        }

        void ld_ixh_h() {
            r1.ixh = r1.h;
        }

        void ld_ixh_l() {
            r1.ixh = r1.l;
        }

        void ld_ixh_ixh() {
        }

        void ld_ixh_ixl() {
            r1.ixh = r1.ixl;
        }

        void ld_ixh_iyh() {
            r1.ixh = r1.iyh;
        }

        void ld_ixh_iyl() {
            r1.ixh = r1.iyl;
        }

        void ld_ixl_a() {
            r1.ixl = r1.a;
        }

        void ld_ixl_b() {
            r1.ixl = r1.b;
        }

        void ld_ixl_c() {
            r1.ixl = r1.c;
        }

        void ld_ixl_d() {
            r1.ixl = r1.d;
        }

        void ld_ixl_e() {
            r1.ixl = r1.e;
        }

        void ld_ixl_h() {
            r1.ixl = r1.h;
        }

        void ld_ixl_l() {
            r1.ixl = r1.l;
        }

        void ld_ixl_ixh() {
            r1.ixl = r1.ixh;
        }

        void ld_ixl_ixl() {
        }

        void ld_ixl_iyh() {
            r1.ixl = r1.iyh;
        }

        void ld_ixl_iyl() {
            r1.ixl = r1.iyl;
        }

        void ld_iyh_a() {
            r1.iyh = r1.a;
        }

        void ld_iyh_b() {
            r1.iyh = r1.b;
        }

        void ld_iyh_c() {
            r1.iyh = r1.c;
        }

        void ld_iyh_d() {
            r1.iyh = r1.d;
        }

        void ld_iyh_e() {
            r1.iyh = r1.e;
        }

        void ld_iyh_h() {
            r1.iyh = r1.h;
        }

        void ld_iyh_l() {
            r1.iyh = r1.l;
        }

        void ld_iyh_ixh() {
            r1.iyh = r1.ixh;
        }

        void ld_iyh_ixl() {
            r1.iyh = r1.ixl;
        }

        void ld_iyh_iyh() {
        }

        void ld_iyh_iyl() {
            r1.iyh = r1.iyl;
        }

        void ld_iyl_a() {
            r1.iyl = r1.a;
        }

        void ld_iyl_b() {
            r1.iyl = r1.b;
        }

        void ld_iyl_c() {
            r1.iyl = r1.c;
        }

        void ld_iyl_d() {
            r1.iyl = r1.d;
        }

        void ld_iyl_e() {
            r1.iyl = r1.e;
        }

        void ld_iyl_h() {
            r1.iyl = r1.h;
        }

        void ld_iyl_l() {
            r1.iyl = r1.l;
        }

        void ld_iyl_ixh() {
            r1.iyl = r1.ixh;
        }

        void ld_iyl_ixl() {
            r1.iyl = r1.ixl;
        }

        void ld_iyl_iyh() {
            r1.iyl = r1.iyh;
        }

        void ld_iyl_iyl() {
        }

        void ld_a_n() {
            r1.a = Read8(pc++);
        }

        void ld_b_n() {
            r1.b = Read8(pc++);
        }

        void ld_c_n() {
            r1.c = Read8(pc++);
        }

        void ld_d_n() {
            r1.d = Read8(pc++);
        }

        void ld_e_n() {
            r1.e = Read8(pc++);
        }

        void ld_h_n() {
            r1.h = Read8(pc++);
        }

        void ld_l_n() {
            r1.l = Read8(pc++);
        }

        void ld_ixh_n() {
            r1.ixh = Read8(pc++);
        }

        void ld_ixl_n() {
            r1.ixl = Read8(pc++);
        }

        void ld_iyh_n() {
            r1.iyh = Read8(pc++);
        }

        void ld_iyl_n() {
            r1.iyl = Read8(pc++);
        }

        void ld_a__hl_() {
            r1.a = Read8(r1.hl);
        }

        void ld_b__hl_() {
            r1.b = Read8(r1.hl);
        }

        void ld_c__hl_() {
            r1.c = Read8(r1.hl);
        }

        void ld_d__hl_() {
            r1.d = Read8(r1.hl);
        }

        void ld_e__hl_() {
            r1.e = Read8(r1.hl);
        }

        void ld_h__hl_() {
            r1.h = Read8(r1.hl);
        }

        void ld_l__hl_() {
            r1.l = Read8(r1.hl);
        }

        void ld__hl__a() {
            Write8(r1.hl, r1.a);
        }

        void ld__hl__b() {
            Write8(r1.hl, r1.b);
        }

        void ld__hl__c() {
            Write8(r1.hl, r1.c);
        }

        void ld__hl__d() {
            Write8(r1.hl, r1.d);
        }

        void ld__hl__e() {
            Write8(r1.hl, r1.e);
        }

        void ld__hl__h() {
            Write8(r1.hl, r1.h);
        }

        void ld__hl__l() {
            Write8(r1.hl, r1.l);
        }

        void ld__hl__n() {
            Write8(r1.hl, Read8(pc++));
        }
        
        void ld_a__bc_() {
            r1.a = Read8(r1.bc);
        }
        
        void ld__bc__a() {
            Write8(r1.bc, r1.a);
        }
        void ld_a__de_() {
            r1.a = Read8(r1.de);
        }
        
        void ld__de__a() {
            Write8(r1.de, r1.a);
        }

        void ld_a__nn_() {
            r1.a = Read8(Read16(pc));
            pc += 2;
        }        
        
        void ld__nn__a() {
            Write8(Read16(pc), r1.a);
            pc += 2;
        }
        
        void ld_a_i() {
            tStates++;
            r1.a = i;
            AdjustFlags(r1.a);
            ResFlag(f_h | f_n);
            ValFlag(f_pv, iff2);
            ValFlag(f_s, (r1.a & 0x80) != 0);
            ValFlag(f_z, r1.a == 0);
        }
        
        void ld_i_a() {
            tStates++;
            i = r1.a;
        }
        void ld_a_r() {
            tStates++;
            r1.a = r;
            AdjustFlags(r1.a);
            ResFlag(f_h | f_n);
            ValFlag(f_pv, iff2);
            ValFlag(f_s, (r1.a & 0x80) != 0);
            ValFlag(f_z, r1.a == 0);
        }
        
        void ld_r_a() {
            tStates++;
            r = r1.a;
        }
        void ld_a__ix_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.a = Read8((ushort)(r1.ix + offset));
        }
        
        void ld__ix_d__a() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.ix + offset), r1.a);
        }
        
        void ld_a__iy_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.a = Read8((ushort)(r1.iy + offset));
        }
        
        void ld__iy_d__a() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.iy + offset), r1.a);
        }
        
        void ld_b__ix_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.b = Read8((ushort)(r1.ix + offset));
        }
        
        void ld__ix_d__b() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.ix + offset), r1.b);
        }
        
        void ld_b__iy_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.b = Read8((ushort)(r1.iy + offset));
        }
        
        void ld__iy_d__b() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.iy + offset), r1.b);
        }
        
        void ld_c__ix_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.c = Read8((ushort)(r1.ix + offset));
        }
        
        void ld__ix_d__c() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.ix + offset), r1.c);
        }
        
        void ld_c__iy_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.c = Read8((ushort)(r1.iy + offset));
        }
        
        void ld__iy_d__c() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.iy + offset), r1.c);
        }
        
        void ld_d__ix_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.d = Read8((ushort)(r1.ix + offset));
        }
        
        void ld__ix_d__d() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.ix + offset), r1.d);
        }
        
        void ld_d__iy_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.d = Read8((ushort)(r1.iy + offset));
        }
        
        void ld__iy_d__d() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.iy + offset), r1.d);
        }
        
        void ld_e__ix_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.e = Read8((ushort)(r1.ix + offset));
        }
        
        void ld__ix_d__e() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.ix + offset), r1.e);
        }
        
        void ld_e__iy_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.e = Read8((ushort)(r1.iy + offset));
        }
        
        void ld__iy_d__e() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.iy + offset), r1.e);
        }
        
        void ld_h__ix_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.h = Read8((ushort)(r1.ix + offset));
        }
        
        void ld__ix_d__h() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.ix + offset), r1.h);
        }
        
        void ld_h__iy_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.h = Read8((ushort)(r1.iy + offset));
        }
        
        void ld__iy_d__h() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.iy + offset), r1.h);
        }
        
        void ld_l__ix_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.l = Read8((ushort)(r1.ix + offset));
        }
        
        void ld__ix_d__l() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.ix + offset), r1.l);
        }
        
        void ld_l__iy_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.l = Read8((ushort)(r1.iy + offset));
        }
        
        void ld__iy_d__l() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.iy + offset), r1.l);
        }
        
        void ld__ix_d__n() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var n = Read8(pc++);
            Write8((ushort)(r1.ix + offset), n);
        }
        
        void ld__iy_d__n() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var n = Read8(pc++);
            Write8((ushort)(r1.iy + offset), n);
        }
        
        void ld_bc_nn() {
            r1.bc = Read16(pc);
            pc += 2;
        }
        
        void ld_bc__nn_() {
            r1.bc = Read16(Read16(pc));
            pc += 2;
        }
        
        void ld__nn__bc() {
            var addr = Read16(pc);
            pc += 2;
            Write16(addr, r1.bc);
        }
        
        void ld_de_nn() {
            r1.de = Read16(pc);
            pc += 2;
        }
        
        void ld_de__nn_() {
            r1.de = Read16(Read16(pc));
            pc += 2;
        }
        
        void ld__nn__de() {
            var addr = Read16(pc);
            pc += 2;
            Write16(addr, r1.de);
        }
        
        void ld_hl_nn() {
            r1.hl = Read16(pc);
            pc += 2;
        }
        
        void ld_hl__nn_() {
            r1.hl = Read16(Read16(pc));
            pc += 2;
        }
        
        void ld__nn__hl() {
            var addr = Read16(pc);
            pc += 2;
            Write16(addr, r1.hl);
        }
        
        void ld_sp_nn() {
            r1.sp = Read16(pc);
            pc += 2;
        }
        
        void ld_sp__nn_() {
            r1.sp = Read16(Read16(pc));
            pc += 2;
        }
        
        void ld__nn__sp() {
            var addr = Read16(pc);
            pc += 2;
            Write16(addr, r1.sp);
        }
        
        void ld_ix_nn() {
            r1.ix = Read16(pc);
            pc += 2;
        }
        
        void ld_ix__nn_() {
            r1.ix = Read16(Read16(pc));
            pc += 2;
        }
        
        void ld__nn__ix() {
            var addr = Read16(pc);
            pc += 2;
            Write16(addr, r1.ix);
        }
        
        void ld_iy_nn() {
            r1.iy = Read16(pc);
            pc += 2;
        }
        
        void ld_iy__nn_() {
            r1.iy = Read16(Read16(pc));
            pc += 2;
        }
        
        void ld__nn__iy() {
            var addr = Read16(pc);
            pc += 2;
            Write16(addr, r1.iy);
        }
        
        void ld_sp_hl() {
            tStates += 2;
            r1.sp = r1.hl;
        }
        
        void ex__sp__hl() {
            tStates += 3;
            var _t = r1.hl;
            r1.hl = Read16(r1.sp);
            Write16(r1.sp, _t);
        }
        
        void ld_sp_ix() {
            tStates += 2;
            r1.sp = r1.ix;
        }
        
        void ex__sp__ix() {
            tStates += 3;
            var _t = r1.ix;
            r1.ix = Read16(r1.sp);
            Write16(r1.sp, _t);
        }
        
        void ld_sp_iy() {
            tStates += 2;
            r1.sp = r1.iy;
        }
        
        void ex__sp__iy() {
            tStates += 3;
            var _t = r1.iy;
            r1.iy = Read16(r1.sp);
            Write16(r1.sp, _t);
        }
        
        void push_af() {
            tStates++;
            DoPush(r1.af);
        }
        
        void pop_af() {
            r1.af = DoPop();
        }
        void push_bc() {
            tStates++;
            DoPush(r1.bc);
        }
        
        void pop_bc() {
            r1.bc = DoPop();
        }
        void push_de() {
            tStates++;
            DoPush(r1.de);
        }
        
        void pop_de() {
            r1.de = DoPop();
        }
        void push_hl() {
            tStates++;
            DoPush(r1.hl);
        }
        
        void pop_hl() {
            r1.hl = DoPop();
        }
        void push_ix() {
            tStates++;
            DoPush(r1.ix);
        }
        
        void pop_ix() {
            r1.ix = DoPop();
        }
        void push_iy() {
            tStates++;
            DoPush(r1.iy);
        }
        
        void pop_iy() {
            r1.iy = DoPop();
        }
        void ex_de_hl() {
            var _t = r1.de;
            r1.de = r1.hl;
            r1.hl = _t;
        }
        
        void ex_af_af_() {
            var _t = r1.af;
            r1.af = r2.af;
            r2.af = _t;
        }
        
        void exx() {
            ushort _t;
            
            _t = r1.bc;
            r1.bc = r2.bc;
            r2.bc = _t;
            _t = r1.de;
            r1.de = r2.de;
            r2.de = _t;
            _t = r1.hl;
            r1.hl = r2.hl;
            r2.hl= _t;
        }
        
        void ldi() {
            byte val, sum;
            
            tStates += 2;
            val = Read8(r1.hl++);
            Write8(r1.de++, val);
            r1.bc--;
            sum = (byte)(r1.a + val);
            ValFlag(f_5, (sum & 0x02) != 0);
            ValFlag(f_3, (sum & f_3) != 0);
            ResFlag(f_h | f_n);
            ValFlag(f_pv, r1.bc != 0);
        }
        
        void ldir() {
            ldi();
            if (r1.bc != 0) {
                tStates += 5;
                pc -= 2;
            }
        }

        void ldd() {
            byte val, sum;
            
            tStates += 2;
            val = Read8(r1.hl--);
            Write8(r1.de--, val);
            r1.bc--;
            sum = (byte)(r1.a + val);
            ValFlag(f_5, (sum & 0x02) != 0);
            ValFlag(f_3, (sum & f_3) != 0);
            ResFlag(f_h | f_n);
            ValFlag(f_pv, r1.bc != 0);
        }
        
        void lddr() {
            ldd();
            if (r1.bc != 0) {
                tStates += 5;
                pc -= 2;
            }
        }
        
        void cpi() {
            tStates += 5;
            var carry = GetFlag(f_c);
            var value = DoCPHL();
            if (GetFlag(f_h)) {
                value--;
            }
            r1.hl++;
            r1.bc--;
            ValFlag(f_pv, r1.bc != 0);
            ValFlag(f_c, carry);
            ValFlag(f_5, (value & (1 << 2)) != 0);
            ValFlag(f_3, (value & (1 << 3)) != 0);
        }
        
        void cpir() {
            cpi();
            if (r1.bc != 0 && !GetFlag(f_z)) {
                tStates += 5;
                pc -= 2;
            }
        }
        
        void cpd() {
            tStates += 5;
            var carry = GetFlag(f_c);
            var value = DoCPHL();
            if (GetFlag(f_h)) {
                value--;
            }
            r1.hl--;
            r1.bc--;
            ValFlag(f_pv, r1.bc != 0);
            ValFlag(f_c, carry);
            ValFlag(f_5, (value & (1 << 1)) != 0);
            ValFlag(f_3, (value & (1 << 3)) != 0);
        }
        
        void cpdr() {
            cpd();
            if (r1.bc != 0 && !GetFlag(f_z)) {
                tStates += 5;
                pc -= 2;
            }
        }
        
        void adc_a_a() {
            r1.a = DoArithmetics(r1.a, hasCarry_adc, isSub_adc);
        }
        
        void adc_a_b() {
            r1.a = DoArithmetics(r1.b, hasCarry_adc, isSub_adc);
        }
        
        void adc_a_c() {
            r1.a = DoArithmetics(r1.c, hasCarry_adc, isSub_adc);
        }
        
        void adc_a_d() {
            r1.a = DoArithmetics(r1.d, hasCarry_adc, isSub_adc);
        }
        
        void adc_a_e() {
            r1.a = DoArithmetics(r1.e, hasCarry_adc, isSub_adc);
        }
        
        void adc_a_h() {
            r1.a = DoArithmetics(r1.h, hasCarry_adc, isSub_adc);
        }
        
        void adc_a_l() {
            r1.a = DoArithmetics(r1.l, hasCarry_adc, isSub_adc);
        }
        
        void adc_a_ixh() {
            r1.a = DoArithmetics(r1.ixh, hasCarry_adc, isSub_adc);
        }
        
        void adc_a_ixl() {
            r1.a = DoArithmetics(r1.ixl, hasCarry_adc, isSub_adc);
        }
        
        void adc_a_iyh() {
            r1.a = DoArithmetics(r1.iyh, hasCarry_adc, isSub_adc);
        }
        
        void adc_a_iyl() {
            r1.a = DoArithmetics(r1.iyl, hasCarry_adc, isSub_adc);
        }
        
        void adc_a_n() {
            r1.a = DoArithmetics(Read8(pc++), hasCarry_adc, isSub_adc);
        }

        void adc_a__hl_() {
            r1.a = DoArithmetics(Read8(r1.hl), hasCarry_adc, isSub_adc);
        }
        
        void adc_a__ix_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.a = DoArithmetics(Read8((ushort)(r1.ix + offset)), hasCarry_adc, isSub_adc);
        }
        
        void adc_a__iy_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.a = DoArithmetics(Read8((ushort)(r1.iy + offset)), hasCarry_adc, isSub_adc);
        }
        
        void sbc_a_a() {
            r1.a = DoArithmetics(r1.a, hasCarry_sbc, isSub_sbc);
        }
        
        void sbc_a_b() {
            r1.a = DoArithmetics(r1.b, hasCarry_sbc, isSub_sbc);
        }
        
        void sbc_a_c() {
            r1.a = DoArithmetics(r1.c, hasCarry_sbc, isSub_sbc);
        }
        
        void sbc_a_d() {
            r1.a = DoArithmetics(r1.d, hasCarry_sbc, isSub_sbc);
        }
        
        void sbc_a_e() {
            r1.a = DoArithmetics(r1.e, hasCarry_sbc, isSub_sbc);
        }
        
        void sbc_a_h() {
            r1.a = DoArithmetics(r1.h, hasCarry_sbc, isSub_sbc);
        }
        
        void sbc_a_l() {
            r1.a = DoArithmetics(r1.l, hasCarry_sbc, isSub_sbc);
        }
        
        void sbc_a_ixh() {
            r1.a = DoArithmetics(r1.ixh, hasCarry_sbc, isSub_sbc);
        }
        
        void sbc_a_ixl() {
            r1.a = DoArithmetics(r1.ixl, hasCarry_sbc, isSub_sbc);
        }
        
        void sbc_a_iyh() {
            r1.a = DoArithmetics(r1.iyh, hasCarry_sbc, isSub_sbc);
        }
        
        void sbc_a_iyl() {
            r1.a = DoArithmetics(r1.iyl, hasCarry_sbc, isSub_sbc);
        }
        
        void sbc_a_n() {
            r1.a = DoArithmetics(Read8(pc++), hasCarry_sbc, isSub_sbc);
        }

        void sbc_a__hl_() {
            r1.a = DoArithmetics(Read8(r1.hl), hasCarry_sbc, isSub_sbc);
        }
        
        void sbc_a__ix_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.a = DoArithmetics(Read8((ushort)(r1.ix + offset)), hasCarry_sbc, isSub_sbc);
        }
        
        void sbc_a__iy_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.a = DoArithmetics(Read8((ushort)(r1.iy + offset)), hasCarry_sbc, isSub_sbc);
        }
        
        void add_a_a() {
            r1.a = DoArithmetics(r1.a, hasCarry_add, isSub_add);
        }
        
        void add_a_b() {
            r1.a = DoArithmetics(r1.b, hasCarry_add, isSub_add);
        }
        
        void add_a_c() {
            r1.a = DoArithmetics(r1.c, hasCarry_add, isSub_add);
        }
        
        void add_a_d() {
            r1.a = DoArithmetics(r1.d, hasCarry_add, isSub_add);
        }
        
        void add_a_e() {
            r1.a = DoArithmetics(r1.e, hasCarry_add, isSub_add);
        }
        
        void add_a_h() {
            r1.a = DoArithmetics(r1.h, hasCarry_add, isSub_add);
        }
        
        void add_a_l() {
            r1.a = DoArithmetics(r1.l, hasCarry_add, isSub_add);
        }
        
        void add_a_ixh() {
            r1.a = DoArithmetics(r1.ixh, hasCarry_add, isSub_add);
        }
        
        void add_a_ixl() {
            r1.a = DoArithmetics(r1.ixl, hasCarry_add, isSub_add);
        }
        
        void add_a_iyh() {
            r1.a = DoArithmetics(r1.iyh, hasCarry_add, isSub_add);
        }
        
        void add_a_iyl() {
            r1.a = DoArithmetics(r1.iyl, hasCarry_add, isSub_add);
        }
        
        void add_a_n() {
            r1.a = DoArithmetics(Read8(pc++), hasCarry_add, isSub_add);
        }

        void add_a__hl_() {
            r1.a = DoArithmetics(Read8(r1.hl), hasCarry_add, isSub_add);
        }
        
        void add_a__ix_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.a = DoArithmetics(Read8((ushort)(r1.ix + offset)), hasCarry_add, isSub_add);
        }
        
        void add_a__iy_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.a = DoArithmetics(Read8((ushort)(r1.iy + offset)), hasCarry_add, isSub_add);
        }
        
        void sub_a_a() {
            r1.a = DoArithmetics(r1.a, hasCarry_sub, isSub_sub);
        }
        
        void sub_a_b() {
            r1.a = DoArithmetics(r1.b, hasCarry_sub, isSub_sub);
        }
        
        void sub_a_c() {
            r1.a = DoArithmetics(r1.c, hasCarry_sub, isSub_sub);
        }
        
        void sub_a_d() {
            r1.a = DoArithmetics(r1.d, hasCarry_sub, isSub_sub);
        }
        
        void sub_a_e() {
            r1.a = DoArithmetics(r1.e, hasCarry_sub, isSub_sub);
        }
        
        void sub_a_h() {
            r1.a = DoArithmetics(r1.h, hasCarry_sub, isSub_sub);
        }
        
        void sub_a_l() {
            r1.a = DoArithmetics(r1.l, hasCarry_sub, isSub_sub);
        }
        
        void sub_a_ixh() {
            r1.a = DoArithmetics(r1.ixh, hasCarry_sub, isSub_sub);
        }
        
        void sub_a_ixl() {
            r1.a = DoArithmetics(r1.ixl, hasCarry_sub, isSub_sub);
        }
        
        void sub_a_iyh() {
            r1.a = DoArithmetics(r1.iyh, hasCarry_sub, isSub_sub);
        }
        
        void sub_a_iyl() {
            r1.a = DoArithmetics(r1.iyl, hasCarry_sub, isSub_sub);
        }
        
        void sub_a_n() {
            r1.a = DoArithmetics(Read8(pc++), hasCarry_sub, isSub_sub);
        }

        void sub_a__hl_() {
            r1.a = DoArithmetics(Read8(r1.hl), hasCarry_sub, isSub_sub);
        }
        
        void sub_a__ix_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.a = DoArithmetics(Read8((ushort)(r1.ix + offset)), hasCarry_sub, isSub_sub);
        }
        
        void sub_a__iy_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.a = DoArithmetics(Read8((ushort)(r1.iy + offset)), hasCarry_sub, isSub_sub);
        }
        
        void add_hl_hl() {
            tStates += 7;
            r1.hl = DoAddWord(r1.hl, r1.hl,  hasCarry_add, isSub_add);
        }

        void add_hl_bc() {
            tStates += 7;
            r1.hl = DoAddWord(r1.hl, r1.bc,  hasCarry_add, isSub_add);
        }

        void add_hl_de() {
            tStates += 7;
            r1.hl = DoAddWord(r1.hl, r1.de,  hasCarry_add, isSub_add);
        }

        void add_hl_sp() {
            tStates += 7;
            r1.hl = DoAddWord(r1.hl, r1.sp,  hasCarry_add, isSub_add);
        }

        void adc_hl_hl() {
            tStates += 7;
            r1.hl = DoAddWord(r1.hl, r1.hl,  hasCarry_adc, isSub_adc);
        }

        void adc_hl_bc() {
            tStates += 7;
            r1.hl = DoAddWord(r1.hl, r1.bc,  hasCarry_adc, isSub_adc);
        }

        void adc_hl_de() {
            tStates += 7;
            r1.hl = DoAddWord(r1.hl, r1.de,  hasCarry_adc, isSub_adc);
        }

        void adc_hl_sp() {
            tStates += 7;
            r1.hl = DoAddWord(r1.hl, r1.sp,  hasCarry_adc, isSub_adc);
        }

        void sbc_hl_hl() {
            tStates += 7;
            r1.hl = DoAddWord(r1.hl, r1.hl,  hasCarry_sbc, isSub_sbc);
        }

        void sbc_hl_bc() {
            tStates += 7;
            r1.hl = DoAddWord(r1.hl, r1.bc,  hasCarry_sbc, isSub_sbc);
        }

        void sbc_hl_de() {
            tStates += 7;
            r1.hl = DoAddWord(r1.hl, r1.de,  hasCarry_sbc, isSub_sbc);
        }

        void sbc_hl_sp() {
            tStates += 7;
            r1.hl = DoAddWord(r1.hl, r1.sp,  hasCarry_sbc, isSub_sbc);
        }

        void add_ix_ix() {
            tStates += 7;
            r1.ix = DoAddWord(r1.ix, r1.ix,  false, false);
        }

        void add_ix_iy() {
            tStates += 7;
            r1.ix = DoAddWord(r1.ix, r1.iy,  false, false);
        }

        void add_ix_bc() {
            tStates += 7;
            r1.ix = DoAddWord(r1.ix, r1.bc,  false, false);
        }

        void add_ix_de() {
            tStates += 7;
            r1.ix = DoAddWord(r1.ix, r1.de,  false, false);
        }

        void add_ix_sp() {
            tStates += 7;
            r1.ix = DoAddWord(r1.ix, r1.sp,  false, false);
        }

        void add_iy_ix() {
            tStates += 7;
            r1.iy = DoAddWord(r1.iy, r1.ix,  false, false);
        }

        void add_iy_iy() {
            tStates += 7;
            r1.iy = DoAddWord(r1.iy, r1.iy,  false, false);
        }

        void add_iy_bc() {
            tStates += 7;
            r1.iy = DoAddWord(r1.iy, r1.bc,  false, false);
        }

        void add_iy_de() {
            tStates += 7;
            r1.iy = DoAddWord(r1.iy, r1.de,  false, false);
        }

        void add_iy_sp() {
            tStates += 7;
            r1.iy = DoAddWord(r1.iy, r1.sp,  false, false);
        }

        void and_a() {
            DoAND(r1.a);
        }
        
        void and_b() {
            DoAND(r1.b);
        }
        
        void and_c() {
            DoAND(r1.c);
        }
        
        void and_d() {
            DoAND(r1.d);
        }
        
        void and_e() {
            DoAND(r1.e);
        }
        
        void and_h() {
            DoAND(r1.h);
        }
        
        void and_l() {
            DoAND(r1.l);
        }
        
        void and_ixh() {
            DoAND(r1.ixh);
        }
        
        void and_ixl() {
            DoAND(r1.ixl);
        }
        
        void and_iyh() {
            DoAND(r1.iyh);
        }
        
        void and_iyl() {
            DoAND(r1.iyl);
        }
        
        void and_n() {
            DoAND(Read8(pc++));
        }

        void and__hl_() {
            DoAND(Read8(r1.hl));
        }
        
        void and__ix_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            DoAND(Read8((ushort)(r1.ix + offset)));
        }
        
        void and__iy_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            DoAND(Read8((ushort)(r1.iy + offset)));
        }
        
        void or_a() {
            DoOR(r1.a);
        }
        
        void or_b() {
            DoOR(r1.b);
        }
        
        void or_c() {
            DoOR(r1.c);
        }
        
        void or_d() {
            DoOR(r1.d);
        }
        
        void or_e() {
            DoOR(r1.e);
        }
        
        void or_h() {
            DoOR(r1.h);
        }
        
        void or_l() {
            DoOR(r1.l);
        }
        
        void or_ixh() {
            DoOR(r1.ixh);
        }
        
        void or_ixl() {
            DoOR(r1.ixl);
        }
        
        void or_iyh() {
            DoOR(r1.iyh);
        }
        
        void or_iyl() {
            DoOR(r1.iyl);
        }
        
        void or_n() {
            DoOR(Read8(pc++));
        }

        void or__hl_() {
            DoOR(Read8(r1.hl));
        }
        
        void or__ix_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            DoOR(Read8((ushort)(r1.ix + offset)));
        }
        
        void or__iy_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            DoOR(Read8((ushort)(r1.iy + offset)));
        }
        
        void xor_a() {
            DoXOR(r1.a);
        }
        
        void xor_b() {
            DoXOR(r1.b);
        }
        
        void xor_c() {
            DoXOR(r1.c);
        }
        
        void xor_d() {
            DoXOR(r1.d);
        }
        
        void xor_e() {
            DoXOR(r1.e);
        }
        
        void xor_h() {
            DoXOR(r1.h);
        }
        
        void xor_l() {
            DoXOR(r1.l);
        }
        
        void xor_ixh() {
            DoXOR(r1.ixh);
        }
        
        void xor_ixl() {
            DoXOR(r1.ixl);
        }
        
        void xor_iyh() {
            DoXOR(r1.iyh);
        }
        
        void xor_iyl() {
            DoXOR(r1.iyl);
        }
        
        void xor_n() {
            DoXOR(Read8(pc++));
        }

        void xor__hl_() {
            DoXOR(Read8(r1.hl));
        }
        
        void xor__ix_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            DoXOR(Read8((ushort)(r1.ix + offset)));
        }
        
        void xor__iy_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            DoXOR(Read8((ushort)(r1.iy + offset)));
        }
        
        void cp_a() {
            DoArithmetics(r1.a, false, true);
            AdjustFlags(r1.a);
        }
        
        void cp_b() {
            DoArithmetics(r1.b, false, true);
            AdjustFlags(r1.b);
        }
        
        void cp_c() {
            DoArithmetics(r1.c, false, true);
            AdjustFlags(r1.c);
        }
        
        void cp_d() {
            DoArithmetics(r1.d, false, true);
            AdjustFlags(r1.d);
        }
        
        void cp_e() {
            DoArithmetics(r1.e, false, true);
            AdjustFlags(r1.e);
        }
        
        void cp_h() {
            DoArithmetics(r1.h, false, true);
            AdjustFlags(r1.h);
        }
        
        void cp_l() {
            DoArithmetics(r1.l, false, true);
            AdjustFlags(r1.l);
        }
        
        void cp_ixh() {
            DoArithmetics(r1.ixh, false, true);
            AdjustFlags(r1.ixh);
        }
        
        void cp_ixl() {
            DoArithmetics(r1.ixl, false, true);
            AdjustFlags(r1.ixl);
        }
        
        void cp_iyh() {
            DoArithmetics(r1.iyh, false, true);
            AdjustFlags(r1.iyh);
        }
        
        void cp_iyl() {
            DoArithmetics(r1.iyl, false, true);
            AdjustFlags(r1.iyl);
        }
        
        void cp__hl_() {
            DoCPHL();
        }
        
        void cp_n() {
            var value = Read8(pc++);
            DoArithmetics(value, false, true);
            AdjustFlags(value);
        }
        
        void cp__ix_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            var value = Read8((ushort)(r1.ix + offset));
            DoArithmetics(value, false, true);
            AdjustFlags(value);
        }
        void cp__iy_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            var value = Read8((ushort)(r1.iy + offset));
            DoArithmetics(value, false, true);
            AdjustFlags(value);
        }

        void inc_a() {
            r1.a = DoIncDec(r1.a, isDec_inc);
        }
        
        void inc_b() {
            r1.b = DoIncDec(r1.b, isDec_inc);
        }
        
        void inc_c() {
            r1.c = DoIncDec(r1.c, isDec_inc);
        }
        
        void inc_d() {
            r1.d = DoIncDec(r1.d, isDec_inc);
        }
        
        void inc_e() {
            r1.e = DoIncDec(r1.e, isDec_inc);
        }
        
        void inc_h() {
            r1.h = DoIncDec(r1.h, isDec_inc);
        }
        
        void inc_l() {
            r1.l = DoIncDec(r1.l, isDec_inc);
        }
        
        void inc_ixh() {
            r1.ixh = DoIncDec(r1.ixh, isDec_inc);
        }
        
        void inc_ixl() {
            r1.ixl = DoIncDec(r1.ixl, isDec_inc);
        }
        
        void inc_iyh() {
            r1.iyh = DoIncDec(r1.iyh, isDec_inc);
        }
        
        void inc_iyl() {
            r1.iyl = DoIncDec(r1.iyl, isDec_inc);
        }
        
        void inc__hl_() {
            tStates++;
            var value = Read8(r1.hl);
            Write8(r1.hl, DoIncDec(value, isDec_inc));
        }
        void inc__ix_d_() {
            tStates += 6;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            var value = Read8(addr);
            Write8(addr, DoIncDec(value, isDec_inc));
        }
        
        void inc__iy_d_() {
            tStates += 6;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            var value = Read8(addr);
            Write8(addr, DoIncDec(value, isDec_inc));
        }
        
        void dec_a() {
            r1.a = DoIncDec(r1.a, isDec_dec);
        }
        
        void dec_b() {
            r1.b = DoIncDec(r1.b, isDec_dec);
        }
        
        void dec_c() {
            r1.c = DoIncDec(r1.c, isDec_dec);
        }
        
        void dec_d() {
            r1.d = DoIncDec(r1.d, isDec_dec);
        }
        
        void dec_e() {
            r1.e = DoIncDec(r1.e, isDec_dec);
        }
        
        void dec_h() {
            r1.h = DoIncDec(r1.h, isDec_dec);
        }
        
        void dec_l() {
            r1.l = DoIncDec(r1.l, isDec_dec);
        }
        
        void dec_ixh() {
            r1.ixh = DoIncDec(r1.ixh, isDec_dec);
        }
        
        void dec_ixl() {
            r1.ixl = DoIncDec(r1.ixl, isDec_dec);
        }
        
        void dec_iyh() {
            r1.iyh = DoIncDec(r1.iyh, isDec_dec);
        }
        
        void dec_iyl() {
            r1.iyl = DoIncDec(r1.iyl, isDec_dec);
        }
        
        void dec__hl_() {
            tStates++;
            var value = Read8(r1.hl);
            Write8(r1.hl, DoIncDec(value, isDec_dec));
        }
        void dec__ix_d_() {
            tStates += 6;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            var value = Read8(addr);
            Write8(addr, DoIncDec(value, isDec_dec));
        }
        
        void dec__iy_d_() {
            tStates += 6;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            var value = Read8(addr);
            Write8(addr, DoIncDec(value, isDec_dec));
        }
        
        void inc_hl() {
            tStates += 2;
            r1.hl++;
        }
        
        void dec_hl() {
            tStates += 2;
            r1.hl--;
        }
        
        void inc_sp() {
            tStates += 2;
            r1.sp++;
        }
        
        void dec_sp() {
            tStates += 2;
            r1.sp--;
        }
        
        void inc_de() {
            tStates += 2;
            r1.de++;
        }
        
        void dec_de() {
            tStates += 2;
            r1.de--;
        }
        
        void inc_bc() {
            tStates += 2;
            r1.bc++;
        }
        
        void dec_bc() {
            tStates += 2;
            r1.bc--;
        }
        
        void inc_ix() {
            tStates += 2;
            r1.ix++;
        }
        
        void dec_ix() {
            tStates += 2;
            r1.ix--;
        }
        
        void inc_iy() {
            tStates += 2;
            r1.iy++;
        }
        
        void dec_iy() {
            tStates += 2;
            r1.iy--;
        }
        

        void daa() {
            DoDAA();
        }
        
        void cpl() {
            r1.a = (byte)~r1.a;
            SetFlag(f_h | f_n);
            AdjustFlags(r1.a);
        }
        
        void neg() {
            var _t = r1.a;
            r1.a = 0;
            r1.a = DoArithmetics(_t, false, true);
            SetFlag(f_n);
        }
        
        void ccf() {
            ValFlag(f_c, !GetFlag(f_c));
            ResFlag(f_n);
            AdjustFlags(r1.a);
        }
        
        void scf() {
            SetFlag(f_c);
            ResFlag(f_h | f_n);
            AdjustFlags(r1.a);
        }
        
        void halt() {
            halted = true;
            pc--;
        }
        
        void di() {
            iff1 = false;
            iff2 = false;
            deferInt = true;
        }

        void ei() {
            iff1 = true;
            iff2 = true;
            deferInt = true;
        }
        void im_0() {
            im = 0;
        }
        
        void im_1() {
            im = 1;
        }
        
        void im_2() {
            im = 2;
        }
        

        // ROTATE AND SHIFT
        
        void rlca() {
            r1.a = DoRLC(r1.a, false);
        }
        
        void rlc_a() {
            r1.a = DoRLC(r1.a, true);
        }
        
        void rlc_b() {
            r1.b = DoRLC(r1.b, true);
        }
        
        void rlc_c() {
            r1.c = DoRLC(r1.c, true);
        }
        
        void rlc_d() {
            r1.d = DoRLC(r1.d, true);
        }
        
        void rlc_e() {
            r1.e = DoRLC(r1.e, true);
        }
        
        void rlc_h() {
            r1.h = DoRLC(r1.h, true);
        }
        
        void rlc_l() {
            r1.l = DoRLC(r1.l, true);
        }
        
        void rlc_ixh() {
            r1.ixh = DoRLC(r1.ixh, true);
        }
        
        void rlc_ixl() {
            r1.ixl = DoRLC(r1.ixl, true);
        }
        
        void rlc_iyh() {
            r1.iyh = DoRLC(r1.iyh, true);
        }
        
        void rlc_iyl() {
            r1.iyl = DoRLC(r1.iyl, true);
        }
        
        void rlc__hl_() {
            tStates++;
            Write8(r1.hl, DoRLC(Read8(r1.hl), true));
        }

        void rlc__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoRLC(Read8(addr), true));
        }
                
        void rlc__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoRLC(Read8(addr), true));
        }
                
        void rla() {
            r1.a = DoRL(r1.a, false);
        }
        
        void rl_a() {
            r1.a = DoRL(r1.a, true);
        }
        
        void rl_b() {
            r1.b = DoRL(r1.b, true);
        }
        
        void rl_c() {
            r1.c = DoRL(r1.c, true);
        }
        
        void rl_d() {
            r1.d = DoRL(r1.d, true);
        }
        
        void rl_e() {
            r1.e = DoRL(r1.e, true);
        }
        
        void rl_h() {
            r1.h = DoRL(r1.h, true);
        }
        
        void rl_l() {
            r1.l = DoRL(r1.l, true);
        }
        
        void rl_ixh() {
            r1.ixh = DoRL(r1.ixh, true);
        }
        
        void rl_ixl() {
            r1.ixl = DoRL(r1.ixl, true);
        }
        
        void rl_iyh() {
            r1.iyh = DoRL(r1.iyh, true);
        }
        
        void rl_iyl() {
            r1.iyl = DoRL(r1.iyl, true);
        }
        
        void rl__hl_() {
            tStates++;
            Write8(r1.hl, DoRL(Read8(r1.hl), true));
        }

        void rl__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoRL(Read8(addr), true));
        }
                
        void rl__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoRL(Read8(addr), true));
        }
                
        void rrca() {
            r1.a = DoRRC(r1.a, false);
        }
        
        void rrc_a() {
            r1.a = DoRRC(r1.a, true);
        }
        
        void rrc_b() {
            r1.b = DoRRC(r1.b, true);
        }
        
        void rrc_c() {
            r1.c = DoRRC(r1.c, true);
        }
        
        void rrc_d() {
            r1.d = DoRRC(r1.d, true);
        }
        
        void rrc_e() {
            r1.e = DoRRC(r1.e, true);
        }
        
        void rrc_h() {
            r1.h = DoRRC(r1.h, true);
        }
        
        void rrc_l() {
            r1.l = DoRRC(r1.l, true);
        }
        
        void rrc_ixh() {
            r1.ixh = DoRRC(r1.ixh, true);
        }
        
        void rrc_ixl() {
            r1.ixl = DoRRC(r1.ixl, true);
        }
        
        void rrc_iyh() {
            r1.iyh = DoRRC(r1.iyh, true);
        }
        
        void rrc_iyl() {
            r1.iyl = DoRRC(r1.iyl, true);
        }
        
        void rrc__hl_() {
            tStates++;
            Write8(r1.hl, DoRRC(Read8(r1.hl), true));
        }

        void rrc__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoRRC(Read8(addr), true));
        }
                
        void rrc__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoRRC(Read8(addr), true));
        }
                
        void rra() {
            r1.a = DoRR(r1.a, false);
        }
        
        void rr_a() {
            r1.a = DoRR(r1.a, true);
        }
        
        void rr_b() {
            r1.b = DoRR(r1.b, true);
        }
        
        void rr_c() {
            r1.c = DoRR(r1.c, true);
        }
        
        void rr_d() {
            r1.d = DoRR(r1.d, true);
        }
        
        void rr_e() {
            r1.e = DoRR(r1.e, true);
        }
        
        void rr_h() {
            r1.h = DoRR(r1.h, true);
        }
        
        void rr_l() {
            r1.l = DoRR(r1.l, true);
        }
        
        void rr_ixh() {
            r1.ixh = DoRR(r1.ixh, true);
        }
        
        void rr_ixl() {
            r1.ixl = DoRR(r1.ixl, true);
        }
        
        void rr_iyh() {
            r1.iyh = DoRR(r1.iyh, true);
        }
        
        void rr_iyl() {
            r1.iyl = DoRR(r1.iyl, true);
        }
        
        void rr__hl_() {
            tStates++;
            Write8(r1.hl, DoRR(Read8(r1.hl), true));
        }

        void rr__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoRR(Read8(addr), true));
        }
                
        void rr__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoRR(Read8(addr), true));
        }
                
        void sla_a() {
            r1.a = DoSL(r1.a, isArithmeticsA);
        }
        
        void sla_b() {
            r1.b = DoSL(r1.b, isArithmeticsA);
        }
        
        void sla_c() {
            r1.c = DoSL(r1.c, isArithmeticsA);
        }
        
        void sla_d() {
            r1.d = DoSL(r1.d, isArithmeticsA);
        }
        
        void sla_e() {
            r1.e = DoSL(r1.e, isArithmeticsA);
        }
        
        void sla_h() {
            r1.h = DoSL(r1.h, isArithmeticsA);
        }
        
        void sla_l() {
            r1.l = DoSL(r1.l, isArithmeticsA);
        }
        
        void sla_ixh() {
            r1.ixh = DoSL(r1.ixh, isArithmeticsA);
        }
        
        void sla_ixl() {
            r1.ixl = DoSL(r1.ixl, isArithmeticsA);
        }
        
        void sla_iyh() {
            r1.iyh = DoSL(r1.iyh, isArithmeticsA);
        }
        
        void sla_iyl() {
            r1.iyl = DoSL(r1.iyl, isArithmeticsA);
        }
        
        void sla__hl_() {
            tStates++;
            Write8(r1.hl, DoSL(Read8(r1.hl), isArithmeticsA));
        }

        void sla__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSL(Read8(addr), isArithmeticsA));
        }
                
        void sla__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSL(Read8(addr), isArithmeticsA));
        }
                
        void sll_a() {
            r1.a = DoSL(r1.a, isArithmeticsL);
        }
        
        void sll_b() {
            r1.b = DoSL(r1.b, isArithmeticsL);
        }
        
        void sll_c() {
            r1.c = DoSL(r1.c, isArithmeticsL);
        }
        
        void sll_d() {
            r1.d = DoSL(r1.d, isArithmeticsL);
        }
        
        void sll_e() {
            r1.e = DoSL(r1.e, isArithmeticsL);
        }
        
        void sll_h() {
            r1.h = DoSL(r1.h, isArithmeticsL);
        }
        
        void sll_l() {
            r1.l = DoSL(r1.l, isArithmeticsL);
        }
        
        void sll_ixh() {
            r1.ixh = DoSL(r1.ixh, isArithmeticsL);
        }
        
        void sll_ixl() {
            r1.ixl = DoSL(r1.ixl, isArithmeticsL);
        }
        
        void sll_iyh() {
            r1.iyh = DoSL(r1.iyh, isArithmeticsL);
        }
        
        void sll_iyl() {
            r1.iyl = DoSL(r1.iyl, isArithmeticsL);
        }
        
        void sll__hl_() {
            tStates++;
            Write8(r1.hl, DoSL(Read8(r1.hl), isArithmeticsL));
        }

        void sll__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSL(Read8(addr), isArithmeticsL));
        }
                
        void sll__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSL(Read8(addr), isArithmeticsL));
        }
                
        void sra_a() {
            r1.a = DoSR(r1.a, isArithmeticsA);
        }
        
        void sra_b() {
            r1.b = DoSR(r1.b, isArithmeticsA);
        }
        
        void sra_c() {
            r1.c = DoSR(r1.c, isArithmeticsA);
        }
        
        void sra_d() {
            r1.d = DoSR(r1.d, isArithmeticsA);
        }
        
        void sra_e() {
            r1.e = DoSR(r1.e, isArithmeticsA);
        }
        
        void sra_h() {
            r1.h = DoSR(r1.h, isArithmeticsA);
        }
        
        void sra_l() {
            r1.l = DoSR(r1.l, isArithmeticsA);
        }
        
        void sra_ixh() {
            r1.ixh = DoSR(r1.ixh, isArithmeticsA);
        }
        
        void sra_ixl() {
            r1.ixl = DoSR(r1.ixl, isArithmeticsA);
        }
        
        void sra_iyh() {
            r1.iyh = DoSR(r1.iyh, isArithmeticsA);
        }
        
        void sra_iyl() {
            r1.iyl = DoSR(r1.iyl, isArithmeticsA);
        }
        
        void sra__hl_() {
            tStates++;
            Write8(r1.hl, DoSR(Read8(r1.hl), isArithmeticsA));
        }

        void sra__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSR(Read8(addr), isArithmeticsA));
        }
                
        void sra__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSR(Read8(addr), isArithmeticsA));
        }
                
        void srl_a() {
            r1.a = DoSR(r1.a, isArithmeticsL);
        }
        
        void srl_b() {
            r1.b = DoSR(r1.b, isArithmeticsL);
        }
        
        void srl_c() {
            r1.c = DoSR(r1.c, isArithmeticsL);
        }
        
        void srl_d() {
            r1.d = DoSR(r1.d, isArithmeticsL);
        }
        
        void srl_e() {
            r1.e = DoSR(r1.e, isArithmeticsL);
        }
        
        void srl_h() {
            r1.h = DoSR(r1.h, isArithmeticsL);
        }
        
        void srl_l() {
            r1.l = DoSR(r1.l, isArithmeticsL);
        }
        
        void srl_ixh() {
            r1.ixh = DoSR(r1.ixh, isArithmeticsL);
        }
        
        void srl_ixl() {
            r1.ixl = DoSR(r1.ixl, isArithmeticsL);
        }
        
        void srl_iyh() {
            r1.iyh = DoSR(r1.iyh, isArithmeticsL);
        }
        
        void srl_iyl() {
            r1.iyl = DoSR(r1.iyl, isArithmeticsL);
        }
        
        void srl__hl_() {
            tStates++;
            Write8(r1.hl, DoSR(Read8(r1.hl), isArithmeticsL));
        }

        void srl__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSR(Read8(addr), isArithmeticsL));
        }
                
        void srl__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSR(Read8(addr), isArithmeticsL));
        }
                
        void rld() {
            tStates += 4;
            var ah = r1.a & 0x0F;
            var hl = Read8(r1.hl);
            r1.a = (byte)((r1.a & 0xF0) | ((hl & 0xF0) >> 4));
            hl = (byte)((hl << 4) | ah);
            Write8(r1.hl, hl);
            ResFlag(f_h | f_n);
            AdjustFlagsSZP(r1.a);
            AdjustFlags(r1.a);
        }
    
        void rrd() {
            tStates += 4;
            var ah = r1.a & 0x0F;
            var hl = Read8(r1.hl);
            r1.a = (byte)((r1.a & 0xF0) | (hl & 0x0F));
            hl = (byte)((hl >> 4) | (ah << 4));
            Write8(r1.hl, hl);
            ResFlag(f_h | f_n);
            AdjustFlagsSZP(r1.a);
        }
        
        void bit_0_a() {
            DoBitR(0, r1.a);
        }
        
        void bit_0_b() {
            DoBitR(0, r1.b);
        }
        
        void bit_0_c() {
            DoBitR(0, r1.c);
        }
        
        void bit_0_d() {
            DoBitR(0, r1.d);
        }
        
        void bit_0_e() {
            DoBitR(0, r1.e);
        }
        
        void bit_0_h() {
            DoBitR(0, r1.h);
        }
        
        void bit_0_l() {
            DoBitR(0, r1.l);
        }
        
        void bit_0__hl_() {
            tStates++;
            DoBitR(0, Read8(r1.hl));
        }
        
        void bit_0__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            DoBitIndexed(0, addr);
        }
        
        void bit_0__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            DoBitIndexed(0, addr);
        }
        
        void bit_1_a() {
            DoBitR(1, r1.a);
        }
        
        void bit_1_b() {
            DoBitR(1, r1.b);
        }
        
        void bit_1_c() {
            DoBitR(1, r1.c);
        }
        
        void bit_1_d() {
            DoBitR(1, r1.d);
        }
        
        void bit_1_e() {
            DoBitR(1, r1.e);
        }
        
        void bit_1_h() {
            DoBitR(1, r1.h);
        }
        
        void bit_1_l() {
            DoBitR(1, r1.l);
        }
        
        void bit_1__hl_() {
            tStates++;
            DoBitR(1, Read8(r1.hl));
        }
        
        void bit_1__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            DoBitIndexed(1, addr);
        }
        
        void bit_1__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            DoBitIndexed(1, addr);
        }
        
        void bit_2_a() {
            DoBitR(2, r1.a);
        }
        
        void bit_2_b() {
            DoBitR(2, r1.b);
        }
        
        void bit_2_c() {
            DoBitR(2, r1.c);
        }
        
        void bit_2_d() {
            DoBitR(2, r1.d);
        }
        
        void bit_2_e() {
            DoBitR(2, r1.e);
        }
        
        void bit_2_h() {
            DoBitR(2, r1.h);
        }
        
        void bit_2_l() {
            DoBitR(2, r1.l);
        }
        
        void bit_2__hl_() {
            tStates++;
            DoBitR(2, Read8(r1.hl));
        }
        
        void bit_2__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            DoBitIndexed(2, addr);
        }
        
        void bit_2__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            DoBitIndexed(2, addr);
        }
        
        void bit_3_a() {
            DoBitR(3, r1.a);
        }
        
        void bit_3_b() {
            DoBitR(3, r1.b);
        }
        
        void bit_3_c() {
            DoBitR(3, r1.c);
        }
        
        void bit_3_d() {
            DoBitR(3, r1.d);
        }
        
        void bit_3_e() {
            DoBitR(3, r1.e);
        }
        
        void bit_3_h() {
            DoBitR(3, r1.h);
        }
        
        void bit_3_l() {
            DoBitR(3, r1.l);
        }
        
        void bit_3__hl_() {
            tStates++;
            DoBitR(3, Read8(r1.hl));
        }
        
        void bit_3__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            DoBitIndexed(3, addr);
        }
        
        void bit_3__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            DoBitIndexed(3, addr);
        }
        
        void bit_4_a() {
            DoBitR(4, r1.a);
        }
        
        void bit_4_b() {
            DoBitR(4, r1.b);
        }
        
        void bit_4_c() {
            DoBitR(4, r1.c);
        }
        
        void bit_4_d() {
            DoBitR(4, r1.d);
        }
        
        void bit_4_e() {
            DoBitR(4, r1.e);
        }
        
        void bit_4_h() {
            DoBitR(4, r1.h);
        }
        
        void bit_4_l() {
            DoBitR(4, r1.l);
        }
        
        void bit_4__hl_() {
            tStates++;
            DoBitR(4, Read8(r1.hl));
        }
        
        void bit_4__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            DoBitIndexed(4, addr);
        }
        
        void bit_4__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            DoBitIndexed(4, addr);
        }
        
        void bit_5_a() {
            DoBitR(5, r1.a);
        }
        
        void bit_5_b() {
            DoBitR(5, r1.b);
        }
        
        void bit_5_c() {
            DoBitR(5, r1.c);
        }
        
        void bit_5_d() {
            DoBitR(5, r1.d);
        }
        
        void bit_5_e() {
            DoBitR(5, r1.e);
        }
        
        void bit_5_h() {
            DoBitR(5, r1.h);
        }
        
        void bit_5_l() {
            DoBitR(5, r1.l);
        }
        
        void bit_5__hl_() {
            tStates++;
            DoBitR(5, Read8(r1.hl));
        }
        
        void bit_5__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            DoBitIndexed(5, addr);
        }
        
        void bit_5__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            DoBitIndexed(5, addr);
        }
        
        void bit_6_a() {
            DoBitR(6, r1.a);
        }
        
        void bit_6_b() {
            DoBitR(6, r1.b);
        }
        
        void bit_6_c() {
            DoBitR(6, r1.c);
        }
        
        void bit_6_d() {
            DoBitR(6, r1.d);
        }
        
        void bit_6_e() {
            DoBitR(6, r1.e);
        }
        
        void bit_6_h() {
            DoBitR(6, r1.h);
        }
        
        void bit_6_l() {
            DoBitR(6, r1.l);
        }
        
        void bit_6__hl_() {
            tStates++;
            DoBitR(6, Read8(r1.hl));
        }
        
        void bit_6__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            DoBitIndexed(6, addr);
        }
        
        void bit_6__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            DoBitIndexed(6, addr);
        }
        
        void bit_7_a() {
            DoBitR(7, r1.a);
        }
        
        void bit_7_b() {
            DoBitR(7, r1.b);
        }
        
        void bit_7_c() {
            DoBitR(7, r1.c);
        }
        
        void bit_7_d() {
            DoBitR(7, r1.d);
        }
        
        void bit_7_e() {
            DoBitR(7, r1.e);
        }
        
        void bit_7_h() {
            DoBitR(7, r1.h);
        }
        
        void bit_7_l() {
            DoBitR(7, r1.l);
        }
        
        void bit_7__hl_() {
            tStates++;
            DoBitR(7, Read8(r1.hl));
        }
        
        void bit_7__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            DoBitIndexed(7, addr);
        }
        
        void bit_7__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            DoBitIndexed(7, addr);
        }
        

        // SET / RES
        
        void set_0_a() {
            r1.a = DoSetRes(bitStateSET, 0, r1.a);
        }
        
        void set_0_b() {
            r1.b = DoSetRes(bitStateSET, 0, r1.b);
        }
        
        void set_0_c() {
            r1.c = DoSetRes(bitStateSET, 0, r1.c);
        }
        
        void set_0_d() {
            r1.d = DoSetRes(bitStateSET, 0, r1.d);
        }
        
        void set_0_e() {
            r1.e = DoSetRes(bitStateSET, 0, r1.e);
        }
        
        void set_0_h() {
            r1.h = DoSetRes(bitStateSET, 0, r1.h);
        }
        
        void set_0_l() {
            r1.l = DoSetRes(bitStateSET, 0, r1.l);
        }
        
        void set_0__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateSET, 0, Read8(r1.hl)));
        }
        
        void set_0__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateSET, 0, Read8(addr)));
        }
        
        void set_0__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateSET, 0, Read8(addr)));
        }
        
        void set_1_a() {
            r1.a = DoSetRes(bitStateSET, 1, r1.a);
        }
        
        void set_1_b() {
            r1.b = DoSetRes(bitStateSET, 1, r1.b);
        }
        
        void set_1_c() {
            r1.c = DoSetRes(bitStateSET, 1, r1.c);
        }
        
        void set_1_d() {
            r1.d = DoSetRes(bitStateSET, 1, r1.d);
        }
        
        void set_1_e() {
            r1.e = DoSetRes(bitStateSET, 1, r1.e);
        }
        
        void set_1_h() {
            r1.h = DoSetRes(bitStateSET, 1, r1.h);
        }
        
        void set_1_l() {
            r1.l = DoSetRes(bitStateSET, 1, r1.l);
        }
        
        void set_1__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateSET, 1, Read8(r1.hl)));
        }
        
        void set_1__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateSET, 1, Read8(addr)));
        }
        
        void set_1__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateSET, 1, Read8(addr)));
        }
        
        void set_2_a() {
            r1.a = DoSetRes(bitStateSET, 2, r1.a);
        }
        
        void set_2_b() {
            r1.b = DoSetRes(bitStateSET, 2, r1.b);
        }
        
        void set_2_c() {
            r1.c = DoSetRes(bitStateSET, 2, r1.c);
        }
        
        void set_2_d() {
            r1.d = DoSetRes(bitStateSET, 2, r1.d);
        }
        
        void set_2_e() {
            r1.e = DoSetRes(bitStateSET, 2, r1.e);
        }
        
        void set_2_h() {
            r1.h = DoSetRes(bitStateSET, 2, r1.h);
        }
        
        void set_2_l() {
            r1.l = DoSetRes(bitStateSET, 2, r1.l);
        }
        
        void set_2__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateSET, 2, Read8(r1.hl)));
        }
        
        void set_2__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateSET, 2, Read8(addr)));
        }
        
        void set_2__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateSET, 2, Read8(addr)));
        }
        
        void set_3_a() {
            r1.a = DoSetRes(bitStateSET, 3, r1.a);
        }
        
        void set_3_b() {
            r1.b = DoSetRes(bitStateSET, 3, r1.b);
        }
        
        void set_3_c() {
            r1.c = DoSetRes(bitStateSET, 3, r1.c);
        }
        
        void set_3_d() {
            r1.d = DoSetRes(bitStateSET, 3, r1.d);
        }
        
        void set_3_e() {
            r1.e = DoSetRes(bitStateSET, 3, r1.e);
        }
        
        void set_3_h() {
            r1.h = DoSetRes(bitStateSET, 3, r1.h);
        }
        
        void set_3_l() {
            r1.l = DoSetRes(bitStateSET, 3, r1.l);
        }
        
        void set_3__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateSET, 3, Read8(r1.hl)));
        }
        
        void set_3__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateSET, 3, Read8(addr)));
        }
        
        void set_3__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateSET, 3, Read8(addr)));
        }
        
        void set_4_a() {
            r1.a = DoSetRes(bitStateSET, 4, r1.a);
        }
        
        void set_4_b() {
            r1.b = DoSetRes(bitStateSET, 4, r1.b);
        }
        
        void set_4_c() {
            r1.c = DoSetRes(bitStateSET, 4, r1.c);
        }
        
        void set_4_d() {
            r1.d = DoSetRes(bitStateSET, 4, r1.d);
        }
        
        void set_4_e() {
            r1.e = DoSetRes(bitStateSET, 4, r1.e);
        }
        
        void set_4_h() {
            r1.h = DoSetRes(bitStateSET, 4, r1.h);
        }
        
        void set_4_l() {
            r1.l = DoSetRes(bitStateSET, 4, r1.l);
        }
        
        void set_4__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateSET, 4, Read8(r1.hl)));
        }
        
        void set_4__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateSET, 4, Read8(addr)));
        }
        
        void set_4__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateSET, 4, Read8(addr)));
        }
        
        void set_5_a() {
            r1.a = DoSetRes(bitStateSET, 5, r1.a);
        }
        
        void set_5_b() {
            r1.b = DoSetRes(bitStateSET, 5, r1.b);
        }
        
        void set_5_c() {
            r1.c = DoSetRes(bitStateSET, 5, r1.c);
        }
        
        void set_5_d() {
            r1.d = DoSetRes(bitStateSET, 5, r1.d);
        }
        
        void set_5_e() {
            r1.e = DoSetRes(bitStateSET, 5, r1.e);
        }
        
        void set_5_h() {
            r1.h = DoSetRes(bitStateSET, 5, r1.h);
        }
        
        void set_5_l() {
            r1.l = DoSetRes(bitStateSET, 5, r1.l);
        }
        
        void set_5__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateSET, 5, Read8(r1.hl)));
        }
        
        void set_5__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateSET, 5, Read8(addr)));
        }
        
        void set_5__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateSET, 5, Read8(addr)));
        }
        
        void set_6_a() {
            r1.a = DoSetRes(bitStateSET, 6, r1.a);
        }
        
        void set_6_b() {
            r1.b = DoSetRes(bitStateSET, 6, r1.b);
        }
        
        void set_6_c() {
            r1.c = DoSetRes(bitStateSET, 6, r1.c);
        }
        
        void set_6_d() {
            r1.d = DoSetRes(bitStateSET, 6, r1.d);
        }
        
        void set_6_e() {
            r1.e = DoSetRes(bitStateSET, 6, r1.e);
        }
        
        void set_6_h() {
            r1.h = DoSetRes(bitStateSET, 6, r1.h);
        }
        
        void set_6_l() {
            r1.l = DoSetRes(bitStateSET, 6, r1.l);
        }
        
        void set_6__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateSET, 6, Read8(r1.hl)));
        }
        
        void set_6__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateSET, 6, Read8(addr)));
        }
        
        void set_6__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateSET, 6, Read8(addr)));
        }
        
        void set_7_a() {
            r1.a = DoSetRes(bitStateSET, 7, r1.a);
        }
        
        void set_7_b() {
            r1.b = DoSetRes(bitStateSET, 7, r1.b);
        }
        
        void set_7_c() {
            r1.c = DoSetRes(bitStateSET, 7, r1.c);
        }
        
        void set_7_d() {
            r1.d = DoSetRes(bitStateSET, 7, r1.d);
        }
        
        void set_7_e() {
            r1.e = DoSetRes(bitStateSET, 7, r1.e);
        }
        
        void set_7_h() {
            r1.h = DoSetRes(bitStateSET, 7, r1.h);
        }
        
        void set_7_l() {
            r1.l = DoSetRes(bitStateSET, 7, r1.l);
        }
        
        void set_7__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateSET, 7, Read8(r1.hl)));
        }
        
        void set_7__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateSET, 7, Read8(addr)));
        }
        
        void set_7__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateSET, 7, Read8(addr)));
        }
        
        void res_0_a() {
            r1.a = DoSetRes(bitStateRES, 0, r1.a);
        }
        
        void res_0_b() {
            r1.b = DoSetRes(bitStateRES, 0, r1.b);
        }
        
        void res_0_c() {
            r1.c = DoSetRes(bitStateRES, 0, r1.c);
        }
        
        void res_0_d() {
            r1.d = DoSetRes(bitStateRES, 0, r1.d);
        }
        
        void res_0_e() {
            r1.e = DoSetRes(bitStateRES, 0, r1.e);
        }
        
        void res_0_h() {
            r1.h = DoSetRes(bitStateRES, 0, r1.h);
        }
        
        void res_0_l() {
            r1.l = DoSetRes(bitStateRES, 0, r1.l);
        }
        
        void res_0__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateRES, 0, Read8(r1.hl)));
        }
        
        void res_0__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateRES, 0, Read8(addr)));
        }
        
        void res_0__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateRES, 0, Read8(addr)));
        }
        
        void res_1_a() {
            r1.a = DoSetRes(bitStateRES, 1, r1.a);
        }
        
        void res_1_b() {
            r1.b = DoSetRes(bitStateRES, 1, r1.b);
        }
        
        void res_1_c() {
            r1.c = DoSetRes(bitStateRES, 1, r1.c);
        }
        
        void res_1_d() {
            r1.d = DoSetRes(bitStateRES, 1, r1.d);
        }
        
        void res_1_e() {
            r1.e = DoSetRes(bitStateRES, 1, r1.e);
        }
        
        void res_1_h() {
            r1.h = DoSetRes(bitStateRES, 1, r1.h);
        }
        
        void res_1_l() {
            r1.l = DoSetRes(bitStateRES, 1, r1.l);
        }
        
        void res_1__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateRES, 1, Read8(r1.hl)));
        }
        
        void res_1__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateRES, 1, Read8(addr)));
        }
        
        void res_1__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateRES, 1, Read8(addr)));
        }
        
        void res_2_a() {
            r1.a = DoSetRes(bitStateRES, 2, r1.a);
        }
        
        void res_2_b() {
            r1.b = DoSetRes(bitStateRES, 2, r1.b);
        }
        
        void res_2_c() {
            r1.c = DoSetRes(bitStateRES, 2, r1.c);
        }
        
        void res_2_d() {
            r1.d = DoSetRes(bitStateRES, 2, r1.d);
        }
        
        void res_2_e() {
            r1.e = DoSetRes(bitStateRES, 2, r1.e);
        }
        
        void res_2_h() {
            r1.h = DoSetRes(bitStateRES, 2, r1.h);
        }
        
        void res_2_l() {
            r1.l = DoSetRes(bitStateRES, 2, r1.l);
        }
        
        void res_2__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateRES, 2, Read8(r1.hl)));
        }
        
        void res_2__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateRES, 2, Read8(addr)));
        }
        
        void res_2__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateRES, 2, Read8(addr)));
        }
        
        void res_3_a() {
            r1.a = DoSetRes(bitStateRES, 3, r1.a);
        }
        
        void res_3_b() {
            r1.b = DoSetRes(bitStateRES, 3, r1.b);
        }
        
        void res_3_c() {
            r1.c = DoSetRes(bitStateRES, 3, r1.c);
        }
        
        void res_3_d() {
            r1.d = DoSetRes(bitStateRES, 3, r1.d);
        }
        
        void res_3_e() {
            r1.e = DoSetRes(bitStateRES, 3, r1.e);
        }
        
        void res_3_h() {
            r1.h = DoSetRes(bitStateRES, 3, r1.h);
        }
        
        void res_3_l() {
            r1.l = DoSetRes(bitStateRES, 3, r1.l);
        }
        
        void res_3__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateRES, 3, Read8(r1.hl)));
        }
        
        void res_3__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateRES, 3, Read8(addr)));
        }
        
        void res_3__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateRES, 3, Read8(addr)));
        }
        
        void res_4_a() {
            r1.a = DoSetRes(bitStateRES, 4, r1.a);
        }
        
        void res_4_b() {
            r1.b = DoSetRes(bitStateRES, 4, r1.b);
        }
        
        void res_4_c() {
            r1.c = DoSetRes(bitStateRES, 4, r1.c);
        }
        
        void res_4_d() {
            r1.d = DoSetRes(bitStateRES, 4, r1.d);
        }
        
        void res_4_e() {
            r1.e = DoSetRes(bitStateRES, 4, r1.e);
        }
        
        void res_4_h() {
            r1.h = DoSetRes(bitStateRES, 4, r1.h);
        }
        
        void res_4_l() {
            r1.l = DoSetRes(bitStateRES, 4, r1.l);
        }
        
        void res_4__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateRES, 4, Read8(r1.hl)));
        }
        
        void res_4__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateRES, 4, Read8(addr)));
        }
        
        void res_4__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateRES, 4, Read8(addr)));
        }
        
        void res_5_a() {
            r1.a = DoSetRes(bitStateRES, 5, r1.a);
        }
        
        void res_5_b() {
            r1.b = DoSetRes(bitStateRES, 5, r1.b);
        }
        
        void res_5_c() {
            r1.c = DoSetRes(bitStateRES, 5, r1.c);
        }
        
        void res_5_d() {
            r1.d = DoSetRes(bitStateRES, 5, r1.d);
        }
        
        void res_5_e() {
            r1.e = DoSetRes(bitStateRES, 5, r1.e);
        }
        
        void res_5_h() {
            r1.h = DoSetRes(bitStateRES, 5, r1.h);
        }
        
        void res_5_l() {
            r1.l = DoSetRes(bitStateRES, 5, r1.l);
        }
        
        void res_5__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateRES, 5, Read8(r1.hl)));
        }
        
        void res_5__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateRES, 5, Read8(addr)));
        }
        
        void res_5__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateRES, 5, Read8(addr)));
        }
        
        void res_6_a() {
            r1.a = DoSetRes(bitStateRES, 6, r1.a);
        }
        
        void res_6_b() {
            r1.b = DoSetRes(bitStateRES, 6, r1.b);
        }
        
        void res_6_c() {
            r1.c = DoSetRes(bitStateRES, 6, r1.c);
        }
        
        void res_6_d() {
            r1.d = DoSetRes(bitStateRES, 6, r1.d);
        }
        
        void res_6_e() {
            r1.e = DoSetRes(bitStateRES, 6, r1.e);
        }
        
        void res_6_h() {
            r1.h = DoSetRes(bitStateRES, 6, r1.h);
        }
        
        void res_6_l() {
            r1.l = DoSetRes(bitStateRES, 6, r1.l);
        }
        
        void res_6__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateRES, 6, Read8(r1.hl)));
        }
        
        void res_6__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateRES, 6, Read8(addr)));
        }
        
        void res_6__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateRES, 6, Read8(addr)));
        }
        
        void res_7_a() {
            r1.a = DoSetRes(bitStateRES, 7, r1.a);
        }
        
        void res_7_b() {
            r1.b = DoSetRes(bitStateRES, 7, r1.b);
        }
        
        void res_7_c() {
            r1.c = DoSetRes(bitStateRES, 7, r1.c);
        }
        
        void res_7_d() {
            r1.d = DoSetRes(bitStateRES, 7, r1.d);
        }
        
        void res_7_e() {
            r1.e = DoSetRes(bitStateRES, 7, r1.e);
        }
        
        void res_7_h() {
            r1.h = DoSetRes(bitStateRES, 7, r1.h);
        }
        
        void res_7_l() {
            r1.l = DoSetRes(bitStateRES, 7, r1.l);
        }
        
        void res_7__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateRES, 7, Read8(r1.hl)));
        }
        
        void res_7__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateRES, 7, Read8(addr)));
        }
        
        void res_7__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateRES, 7, Read8(addr)));
        }
        
        void in_a__n_() {
            ushort port = (ushort)Read8(pc++);
            port = (ushort)((r1.a << 8) | port);
            r1.a = IORead(port);
        }
        
        void out__n__a() {
            ushort port = (ushort)Read8(pc++);
            port = (ushort)((r1.a << 8) | port);
            IOWrite(port, r1.a);        
        }
        
        void ind() {
            tStates++;
            var value = IORead(r1.bc);
            Write8(r1.hl--, value);
            r1.b = DoIncDec(r1.b, isDec_dec);
            ValFlag(f_n, (value & 0x80) != 0);
            var fv = value + ((r1.c - 1) & 0xff);
            ValFlag(f_h, fv > 0xFF);
            ValFlag(f_c, fv > 0xFF);
            ValFlag(f_pv, parityBit[(fv & 7) ^ r1.b]);
        }
        
        void indr() {
            ind();
            if (r1.b != 0) {
                tStates += 5;
                pc -= 2;
            }
        }
        
        void ini() {
            tStates++;
            var value = IORead(r1.bc);
            Write8(r1.hl++, value);
            r1.b = DoIncDec(r1.b, isDec_dec);
            ValFlag(f_n, (value & 0x80) != 0);
            var fv = value + ((r1.c + 1) & 0xff);
            ValFlag(f_h, fv > 0xFF);
            ValFlag(f_c, fv > 0xFF);
            ValFlag(f_pv, parityBit[(fv & 7) ^ r1.b]);
        }
        
        void inir() {
            ini();
            if (r1.b != 0) {
                tStates += 5;
                pc -= 2;
            }
        }
        
        void outi() {
            tStates++;
            var value = Read8(r1.hl++);
            r1.b = DoIncDec(r1.b, isDec_dec);
            IOWrite(r1.bc, value);
            var fv = value + r1.l;
            ValFlag(f_n, (value & 0x80) != 0);
            ValFlag(f_h, fv > 0xFF);
            ValFlag(f_c, fv > 0xFF);
            ValFlag(f_pv, parityBit[(fv & 7) ^ r1.b]);
            AdjustFlags(r1.b);
        }
        
        void otir() {
            outi();
            if (r1.b != 0) {
                tStates += 5;
                pc -= 2;
            }
        }
        
        void outd() {
            tStates++;
            var value = Read8(r1.hl--);
            r1.b = DoIncDec(r1.b, isDec_dec);
            IOWrite(r1.bc, value);
            var fv = value + r1.l;
            ValFlag(f_n, (value & 0x80) != 0);
            ValFlag(f_h, fv > 0xFF);
            ValFlag(f_c, fv > 0xFF);
            ValFlag(f_pv, parityBit[(fv & 7) ^ r1.b]);
            AdjustFlags(r1.b);
        }
        
        void otdr() {
            outd();
            if (r1.b != 0) {
                tStates += 5;
                pc -= 2;
            }
        }
        
        void in_a__c_() {
            r1.a = IORead(r1.bc);
            ResFlag(f_h | f_n);
            AdjustFlagsSZP(r1.a);
            AdjustFlags(r1.a);
        }    

        void out__c__a() {
            IOWrite(r1.bc, r1.a);
        }
        
        void in_b__c_() {
            r1.b = IORead(r1.bc);
            ResFlag(f_h | f_n);
            AdjustFlagsSZP(r1.b);
            AdjustFlags(r1.b);
        }    

        void out__c__b() {
            IOWrite(r1.bc, r1.b);
        }
        
        void in_c__c_() {
            r1.c = IORead(r1.bc);
            ResFlag(f_h | f_n);
            AdjustFlagsSZP(r1.c);
            AdjustFlags(r1.c);
        }    

        void out__c__c() {
            IOWrite(r1.bc, r1.c);
        }
        
        void in_d__c_() {
            r1.d = IORead(r1.bc);
            ResFlag(f_h | f_n);
            AdjustFlagsSZP(r1.d);
            AdjustFlags(r1.d);
        }    

        void out__c__d() {
            IOWrite(r1.bc, r1.d);
        }
        
        void in_e__c_() {
            r1.e = IORead(r1.bc);
            ResFlag(f_h | f_n);
            AdjustFlagsSZP(r1.e);
            AdjustFlags(r1.e);
        }    

        void out__c__e() {
            IOWrite(r1.bc, r1.e);
        }
        
        void in_f__c_() {
            r1.f = IORead(r1.bc);
            ResFlag(f_h | f_n);
            AdjustFlagsSZP(r1.f);
            AdjustFlags(r1.f);
        }    

        void in_h__c_() {
            r1.h = IORead(r1.bc);
            ResFlag(f_h | f_n);
            AdjustFlagsSZP(r1.h);
            AdjustFlags(r1.h);
        }    

        void out__c__h() {
            IOWrite(r1.bc, r1.h);
        }
        
        void in_l__c_() {
            r1.l = IORead(r1.bc);
            ResFlag(f_h | f_n);
            AdjustFlagsSZP(r1.l);
            AdjustFlags(r1.l);
        }    

        void out__c__l() {
            IOWrite(r1.bc, r1.l);
        }
        
      
        void out__c__0() {
            IOWrite(r1.bc, 0);
        }
        
        void jp_nn() {
            pc = Read16(pc);
        }
        
        void jr_pc_e() {
            var offset = (SByte)Read8(pc++);
            tStates += 5;
            pc = (ushort)(pc + offset);
        }
        
        void djnz_pc_e() {
            tStates++;
            var offset = (SByte)Read8(pc++);
            r1.b--;
            if (r1.b != 0) {
                tStates += 5;
                pc = (ushort)(pc + offset);
            }
        }
        
        void call_nn() {
            var addr = Read16(pc);
            pc += 2;
            tStates++;
            DoPush(pc);
            pc = addr;
        }
        
        void ret() {
            pc = DoPop();
        }
        
        void retn() {
            iff1 = iff2;
            ret();
        }
        
        void reti() {
            iff1 = iff2;
            ret();
        }
        
        void jp_nz_nn() {
            // no matter if the condition is true we spend 6 tstates to read the addr
            ushort addr = Read16(pc);
            if (Condition(c_nz)) {
                pc = addr;
            } else {
                pc += 2;
            }
        }
        
        void call_nz_nn() {
            var addr = Read16(pc);
            pc += 2;
            if (Condition(c_nz)) {
                tStates++;
                DoPush(pc);
                pc = addr;
            }
        }
        
        void ret_nz() {
            tStates++;
            if (Condition(c_nz)) {
                ret();
            }
        }
        
        void jp_z_nn() {
            // no matter if the condition is true we spend 6 tstates to read the addr
            ushort addr = Read16(pc);
            if (Condition(c_z)) {
                pc = addr;
            } else {
                pc += 2;
            }
        }
        
        void call_z_nn() {
            var addr = Read16(pc);
            pc += 2;
            if (Condition(c_z)) {
                tStates++;
                DoPush(pc);
                pc = addr;
            }
        }
        
        void ret_z() {
            tStates++;
            if (Condition(c_z)) {
                ret();
            }
        }
        
        void jp_nc_nn() {
            // no matter if the condition is true we spend 6 tstates to read the addr
            ushort addr = Read16(pc);
            if (Condition(c_nc)) {
                pc = addr;
            } else {
                pc += 2;
            }
        }
        
        void call_nc_nn() {
            var addr = Read16(pc);
            pc += 2;
            if (Condition(c_nc)) {
                tStates++;
                DoPush(pc);
                pc = addr;
            }
        }
        
        void ret_nc() {
            tStates++;
            if (Condition(c_nc)) {
                ret();
            }
        }
        
        void jp_c_nn() {
            // no matter if the condition is true we spend 6 tstates to read the addr
            ushort addr = Read16(pc);
            if (Condition(c_c)) {
                pc = addr;
            } else {
                pc += 2;
            }
        }
        
        void call_c_nn() {
            var addr = Read16(pc);
            pc += 2;
            if (Condition(c_c)) {
                tStates++;
                DoPush(pc);
                pc = addr;
            }
        }
        
        void ret_c() {
            tStates++;
            if (Condition(c_c)) {
                ret();
            }
        }
        
        void jp_po_nn() {
            // no matter if the condition is true we spend 6 tstates to read the addr
            ushort addr = Read16(pc);
            if (Condition(c_po)) {
                pc = addr;
            } else {
                pc += 2;
            }
        }
        
        void call_po_nn() {
            var addr = Read16(pc);
            pc += 2;
            if (Condition(c_po)) {
                tStates++;
                DoPush(pc);
                pc = addr;
            }
        }
        
        void ret_po() {
            tStates++;
            if (Condition(c_po)) {
                ret();
            }
        }
        
        void jp_pe_nn() {
            // no matter if the condition is true we spend 6 tstates to read the addr
            ushort addr = Read16(pc);
            if (Condition(c_pe)) {
                pc = addr;
            } else {
                pc += 2;
            }
        }
        
        void call_pe_nn() {
            var addr = Read16(pc);
            pc += 2;
            if (Condition(c_pe)) {
                tStates++;
                DoPush(pc);
                pc = addr;
            }
        }
        
        void ret_pe() {
            tStates++;
            if (Condition(c_pe)) {
                ret();
            }
        }
        
        void jp_p_nn() {
            // no matter if the condition is true we spend 6 tstates to read the addr
            ushort addr = Read16(pc);
            if (Condition(c_p)) {
                pc = addr;
            } else {
                pc += 2;
            }
        }
        
        void call_p_nn() {
            var addr = Read16(pc);
            pc += 2;
            if (Condition(c_p)) {
                tStates++;
                DoPush(pc);
                pc = addr;
            }
        }
        
        void ret_p() {
            tStates++;
            if (Condition(c_p)) {
                ret();
            }
        }
        
        void jp_m_nn() {
            // no matter if the condition is true we spend 6 tstates to read the addr
            ushort addr = Read16(pc);
            if (Condition(c_m)) {
                pc = addr;
            } else {
                pc += 2;
            }
        }
        
        void call_m_nn() {
            var addr = Read16(pc);
            pc += 2;
            if (Condition(c_m)) {
                tStates++;
                DoPush(pc);
                pc = addr;
            }
        }
        
        void ret_m() {
            tStates++;
            if (Condition(c_m)) {
                ret();
            }
        }
        
        void jr_c_pc_e() {
            var offset = (SByte)Read8(pc++);
            if (Condition(c_c)) {
                tStates += 5;
                pc = (ushort)(pc + offset);
            }
        }
        
        void jr_nc_pc_e() {
            var offset = (SByte)Read8(pc++);
            if (Condition(c_nc)) {
                tStates += 5;
                pc = (ushort)(pc + offset);
            }
        }
        
        void jr_z_pc_e() {
            var offset = (SByte)Read8(pc++);
            if (Condition(c_z)) {
                tStates += 5;
                pc = (ushort)(pc + offset);
            }
        }
        
        void jr_nz_pc_e() {
            var offset = (SByte)Read8(pc++);
            if (Condition(c_nz)) {
                tStates += 5;
                pc = (ushort)(pc + offset);
            }
        }
        
        void jp__hl_() {
            pc = r1.hl;
        }
        
        void jp__ix_() {
            pc = r1.ix;
        }
        
        void jp__iy_() {
            pc = r1.iy;
        }
        

        void rst_00h() {
            tStates++;
            DoPush(pc);
            pc = 0x00;
        }
        
        void rst_08h() {
            tStates++;
            DoPush(pc);
            pc = 0x08;
        }
        
        void rst_10h() {
            tStates++;
            DoPush(pc);
            pc = 0x10;
        }
        
        void rst_18h() {
            tStates++;
            DoPush(pc);
            pc = 0x18;
        }
        
        void rst_20h() {
            tStates++;
            DoPush(pc);
            pc = 0x20;
        }
        
        void rst_28h() {
            tStates++;
            DoPush(pc);
            pc = 0x28;
        }
        
        void rst_30h() {
            tStates++;
            DoPush(pc);
            pc = 0x30;
        }
        
        void rst_38h() {
            tStates++;
            DoPush(pc);
            pc = 0x38;
        }
        

        void ld_a_set_0__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.a = DoSetRes(bitStateSET, 0, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_set_0__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.a = DoSetRes(bitStateSET, 0, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_set_1__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.a = DoSetRes(bitStateSET, 1, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_set_1__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.a = DoSetRes(bitStateSET, 1, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_set_2__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.a = DoSetRes(bitStateSET, 2, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_set_2__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.a = DoSetRes(bitStateSET, 2, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_set_3__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.a = DoSetRes(bitStateSET, 3, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_set_3__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.a = DoSetRes(bitStateSET, 3, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_set_4__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.a = DoSetRes(bitStateSET, 4, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_set_4__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.a = DoSetRes(bitStateSET, 4, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_set_5__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.a = DoSetRes(bitStateSET, 5, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_set_5__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.a = DoSetRes(bitStateSET, 5, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_set_6__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.a = DoSetRes(bitStateSET, 6, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_set_6__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.a = DoSetRes(bitStateSET, 6, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_set_7__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.a = DoSetRes(bitStateSET, 7, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_set_7__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.a = DoSetRes(bitStateSET, 7, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_res_0__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.a = DoSetRes(bitStateRES, 0, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_res_0__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.a = DoSetRes(bitStateRES, 0, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_res_1__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.a = DoSetRes(bitStateRES, 1, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_res_1__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.a = DoSetRes(bitStateRES, 1, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_res_2__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.a = DoSetRes(bitStateRES, 2, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_res_2__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.a = DoSetRes(bitStateRES, 2, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_res_3__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.a = DoSetRes(bitStateRES, 3, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_res_3__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.a = DoSetRes(bitStateRES, 3, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_res_4__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.a = DoSetRes(bitStateRES, 4, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_res_4__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.a = DoSetRes(bitStateRES, 4, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_res_5__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.a = DoSetRes(bitStateRES, 5, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_res_5__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.a = DoSetRes(bitStateRES, 5, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_res_6__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.a = DoSetRes(bitStateRES, 6, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_res_6__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.a = DoSetRes(bitStateRES, 6, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_res_7__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.a = DoSetRes(bitStateRES, 7, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_res_7__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.a = DoSetRes(bitStateRES, 7, Read8(addr));
            Write8(addr, r1.a);
        }
        
        void ld_a_sla__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.a = DoSL(Read8(addr), isArithmeticsA);
            Write8(addr, r1.a);
            
        }
        
        void ld_a_sla__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.a = DoSL(Read8(addr), isArithmeticsA);
            Write8(addr, r1.a);
            
        }
        
        void ld_a_sll__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.a = DoSL(Read8(addr), isArithmeticsL);
            Write8(addr, r1.a);
            
        }
        
        void ld_a_sll__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.a = DoSL(Read8(addr), isArithmeticsL);
            Write8(addr, r1.a);
            
        }
        
        void ld_a_sra__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.a = DoSR(Read8(addr), isArithmeticsA);
            Write8(addr, r1.a);
            
        }
        
        void ld_a_sra__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.a = DoSR(Read8(addr), isArithmeticsA);
            Write8(addr, r1.a);
            
        }
        
        void ld_a_srl__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.a = DoSR(Read8(addr), isArithmeticsL);
            Write8(addr, r1.a);
            
        }
        
        void ld_a_srl__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.a = DoSR(Read8(addr), isArithmeticsL);
            Write8(addr, r1.a);
            
        }
        
        void ld_a_rl__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.a = DoRL(Read8(addr), true);
            Write8(addr, r1.a);            
        }
        
        void ld_a_rl__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.a = DoRL(Read8(addr), true);
            Write8(addr, r1.a);            
        }
        
        void ld_a_rlc__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.a = DoRLC(Read8(addr), true);
            Write8(addr, r1.a);            
        }
        
        void ld_a_rlc__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.a = DoRLC(Read8(addr), true);
            Write8(addr, r1.a);            
        }
        
        void ld_a_rr__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.a = DoRR(Read8(addr), true);
            Write8(addr, r1.a);            
        }
        
        void ld_a_rr__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.a = DoRR(Read8(addr), true);
            Write8(addr, r1.a);            
        }
        
        void ld_a_rrc__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.a = DoRRC(Read8(addr), true);
            Write8(addr, r1.a);            
        }
        
        void ld_a_rrc__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.a = DoRRC(Read8(addr), true);
            Write8(addr, r1.a);            
        }
        
        void ld_b_set_0__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.b = DoSetRes(bitStateSET, 0, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_set_0__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.b = DoSetRes(bitStateSET, 0, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_set_1__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.b = DoSetRes(bitStateSET, 1, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_set_1__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.b = DoSetRes(bitStateSET, 1, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_set_2__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.b = DoSetRes(bitStateSET, 2, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_set_2__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.b = DoSetRes(bitStateSET, 2, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_set_3__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.b = DoSetRes(bitStateSET, 3, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_set_3__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.b = DoSetRes(bitStateSET, 3, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_set_4__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.b = DoSetRes(bitStateSET, 4, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_set_4__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.b = DoSetRes(bitStateSET, 4, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_set_5__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.b = DoSetRes(bitStateSET, 5, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_set_5__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.b = DoSetRes(bitStateSET, 5, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_set_6__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.b = DoSetRes(bitStateSET, 6, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_set_6__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.b = DoSetRes(bitStateSET, 6, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_set_7__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.b = DoSetRes(bitStateSET, 7, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_set_7__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.b = DoSetRes(bitStateSET, 7, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_res_0__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.b = DoSetRes(bitStateRES, 0, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_res_0__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.b = DoSetRes(bitStateRES, 0, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_res_1__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.b = DoSetRes(bitStateRES, 1, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_res_1__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.b = DoSetRes(bitStateRES, 1, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_res_2__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.b = DoSetRes(bitStateRES, 2, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_res_2__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.b = DoSetRes(bitStateRES, 2, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_res_3__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.b = DoSetRes(bitStateRES, 3, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_res_3__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.b = DoSetRes(bitStateRES, 3, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_res_4__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.b = DoSetRes(bitStateRES, 4, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_res_4__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.b = DoSetRes(bitStateRES, 4, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_res_5__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.b = DoSetRes(bitStateRES, 5, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_res_5__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.b = DoSetRes(bitStateRES, 5, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_res_6__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.b = DoSetRes(bitStateRES, 6, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_res_6__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.b = DoSetRes(bitStateRES, 6, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_res_7__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.b = DoSetRes(bitStateRES, 7, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_res_7__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.b = DoSetRes(bitStateRES, 7, Read8(addr));
            Write8(addr, r1.b);
        }
        
        void ld_b_sla__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.b = DoSL(Read8(addr), isArithmeticsA);
            Write8(addr, r1.b);
            
        }
        
        void ld_b_sla__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.b = DoSL(Read8(addr), isArithmeticsA);
            Write8(addr, r1.b);
            
        }
        
        void ld_b_sll__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.b = DoSL(Read8(addr), isArithmeticsL);
            Write8(addr, r1.b);
            
        }
        
        void ld_b_sll__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.b = DoSL(Read8(addr), isArithmeticsL);
            Write8(addr, r1.b);
            
        }
        
        void ld_b_sra__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.b = DoSR(Read8(addr), isArithmeticsA);
            Write8(addr, r1.b);
            
        }
        
        void ld_b_sra__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.b = DoSR(Read8(addr), isArithmeticsA);
            Write8(addr, r1.b);
            
        }
        
        void ld_b_srl__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.b = DoSR(Read8(addr), isArithmeticsL);
            Write8(addr, r1.b);
            
        }
        
        void ld_b_srl__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.b = DoSR(Read8(addr), isArithmeticsL);
            Write8(addr, r1.b);
            
        }
        
        void ld_b_rl__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.b = DoRL(Read8(addr), true);
            Write8(addr, r1.b);            
        }
        
        void ld_b_rl__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.b = DoRL(Read8(addr), true);
            Write8(addr, r1.b);            
        }
        
        void ld_b_rlc__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.b = DoRLC(Read8(addr), true);
            Write8(addr, r1.b);            
        }
        
        void ld_b_rlc__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.b = DoRLC(Read8(addr), true);
            Write8(addr, r1.b);            
        }
        
        void ld_b_rr__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.b = DoRR(Read8(addr), true);
            Write8(addr, r1.b);            
        }
        
        void ld_b_rr__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.b = DoRR(Read8(addr), true);
            Write8(addr, r1.b);            
        }
        
        void ld_b_rrc__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.b = DoRRC(Read8(addr), true);
            Write8(addr, r1.b);            
        }
        
        void ld_b_rrc__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.b = DoRRC(Read8(addr), true);
            Write8(addr, r1.b);            
        }
        
        void ld_c_set_0__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.c = DoSetRes(bitStateSET, 0, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_set_0__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.c = DoSetRes(bitStateSET, 0, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_set_1__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.c = DoSetRes(bitStateSET, 1, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_set_1__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.c = DoSetRes(bitStateSET, 1, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_set_2__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.c = DoSetRes(bitStateSET, 2, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_set_2__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.c = DoSetRes(bitStateSET, 2, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_set_3__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.c = DoSetRes(bitStateSET, 3, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_set_3__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.c = DoSetRes(bitStateSET, 3, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_set_4__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.c = DoSetRes(bitStateSET, 4, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_set_4__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.c = DoSetRes(bitStateSET, 4, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_set_5__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.c = DoSetRes(bitStateSET, 5, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_set_5__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.c = DoSetRes(bitStateSET, 5, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_set_6__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.c = DoSetRes(bitStateSET, 6, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_set_6__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.c = DoSetRes(bitStateSET, 6, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_set_7__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.c = DoSetRes(bitStateSET, 7, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_set_7__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.c = DoSetRes(bitStateSET, 7, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_res_0__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.c = DoSetRes(bitStateRES, 0, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_res_0__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.c = DoSetRes(bitStateRES, 0, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_res_1__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.c = DoSetRes(bitStateRES, 1, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_res_1__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.c = DoSetRes(bitStateRES, 1, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_res_2__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.c = DoSetRes(bitStateRES, 2, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_res_2__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.c = DoSetRes(bitStateRES, 2, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_res_3__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.c = DoSetRes(bitStateRES, 3, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_res_3__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.c = DoSetRes(bitStateRES, 3, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_res_4__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.c = DoSetRes(bitStateRES, 4, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_res_4__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.c = DoSetRes(bitStateRES, 4, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_res_5__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.c = DoSetRes(bitStateRES, 5, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_res_5__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.c = DoSetRes(bitStateRES, 5, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_res_6__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.c = DoSetRes(bitStateRES, 6, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_res_6__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.c = DoSetRes(bitStateRES, 6, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_res_7__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.c = DoSetRes(bitStateRES, 7, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_res_7__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.c = DoSetRes(bitStateRES, 7, Read8(addr));
            Write8(addr, r1.c);
        }
        
        void ld_c_sla__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.c = DoSL(Read8(addr), isArithmeticsA);
            Write8(addr, r1.c);
            
        }
        
        void ld_c_sla__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.c = DoSL(Read8(addr), isArithmeticsA);
            Write8(addr, r1.c);
            
        }
        
        void ld_c_sll__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.c = DoSL(Read8(addr), isArithmeticsL);
            Write8(addr, r1.c);
            
        }
        
        void ld_c_sll__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.c = DoSL(Read8(addr), isArithmeticsL);
            Write8(addr, r1.c);
            
        }
        
        void ld_c_sra__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.c = DoSR(Read8(addr), isArithmeticsA);
            Write8(addr, r1.c);
            
        }
        
        void ld_c_sra__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.c = DoSR(Read8(addr), isArithmeticsA);
            Write8(addr, r1.c);
            
        }
        
        void ld_c_srl__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.c = DoSR(Read8(addr), isArithmeticsL);
            Write8(addr, r1.c);
            
        }
        
        void ld_c_srl__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.c = DoSR(Read8(addr), isArithmeticsL);
            Write8(addr, r1.c);
            
        }
        
        void ld_c_rl__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.c = DoRL(Read8(addr), true);
            Write8(addr, r1.c);            
        }
        
        void ld_c_rl__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.c = DoRL(Read8(addr), true);
            Write8(addr, r1.c);            
        }
        
        void ld_c_rlc__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.c = DoRLC(Read8(addr), true);
            Write8(addr, r1.c);            
        }
        
        void ld_c_rlc__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.c = DoRLC(Read8(addr), true);
            Write8(addr, r1.c);            
        }
        
        void ld_c_rr__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.c = DoRR(Read8(addr), true);
            Write8(addr, r1.c);            
        }
        
        void ld_c_rr__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.c = DoRR(Read8(addr), true);
            Write8(addr, r1.c);            
        }
        
        void ld_c_rrc__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.c = DoRRC(Read8(addr), true);
            Write8(addr, r1.c);            
        }
        
        void ld_c_rrc__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.c = DoRRC(Read8(addr), true);
            Write8(addr, r1.c);            
        }
        
        void ld_d_set_0__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.d = DoSetRes(bitStateSET, 0, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_set_0__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.d = DoSetRes(bitStateSET, 0, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_set_1__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.d = DoSetRes(bitStateSET, 1, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_set_1__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.d = DoSetRes(bitStateSET, 1, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_set_2__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.d = DoSetRes(bitStateSET, 2, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_set_2__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.d = DoSetRes(bitStateSET, 2, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_set_3__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.d = DoSetRes(bitStateSET, 3, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_set_3__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.d = DoSetRes(bitStateSET, 3, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_set_4__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.d = DoSetRes(bitStateSET, 4, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_set_4__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.d = DoSetRes(bitStateSET, 4, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_set_5__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.d = DoSetRes(bitStateSET, 5, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_set_5__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.d = DoSetRes(bitStateSET, 5, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_set_6__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.d = DoSetRes(bitStateSET, 6, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_set_6__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.d = DoSetRes(bitStateSET, 6, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_set_7__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.d = DoSetRes(bitStateSET, 7, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_set_7__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.d = DoSetRes(bitStateSET, 7, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_res_0__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.d = DoSetRes(bitStateRES, 0, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_res_0__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.d = DoSetRes(bitStateRES, 0, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_res_1__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.d = DoSetRes(bitStateRES, 1, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_res_1__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.d = DoSetRes(bitStateRES, 1, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_res_2__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.d = DoSetRes(bitStateRES, 2, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_res_2__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.d = DoSetRes(bitStateRES, 2, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_res_3__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.d = DoSetRes(bitStateRES, 3, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_res_3__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.d = DoSetRes(bitStateRES, 3, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_res_4__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.d = DoSetRes(bitStateRES, 4, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_res_4__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.d = DoSetRes(bitStateRES, 4, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_res_5__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.d = DoSetRes(bitStateRES, 5, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_res_5__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.d = DoSetRes(bitStateRES, 5, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_res_6__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.d = DoSetRes(bitStateRES, 6, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_res_6__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.d = DoSetRes(bitStateRES, 6, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_res_7__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.d = DoSetRes(bitStateRES, 7, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_res_7__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.d = DoSetRes(bitStateRES, 7, Read8(addr));
            Write8(addr, r1.d);
        }
        
        void ld_d_sla__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.d = DoSL(Read8(addr), isArithmeticsA);
            Write8(addr, r1.d);
            
        }
        
        void ld_d_sla__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.d = DoSL(Read8(addr), isArithmeticsA);
            Write8(addr, r1.d);
            
        }
        
        void ld_d_sll__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.d = DoSL(Read8(addr), isArithmeticsL);
            Write8(addr, r1.d);
            
        }
        
        void ld_d_sll__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.d = DoSL(Read8(addr), isArithmeticsL);
            Write8(addr, r1.d);
            
        }
        
        void ld_d_sra__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.d = DoSR(Read8(addr), isArithmeticsA);
            Write8(addr, r1.d);
            
        }
        
        void ld_d_sra__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.d = DoSR(Read8(addr), isArithmeticsA);
            Write8(addr, r1.d);
            
        }
        
        void ld_d_srl__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.d = DoSR(Read8(addr), isArithmeticsL);
            Write8(addr, r1.d);
            
        }
        
        void ld_d_srl__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.d = DoSR(Read8(addr), isArithmeticsL);
            Write8(addr, r1.d);
            
        }
        
        void ld_d_rl__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.d = DoRL(Read8(addr), true);
            Write8(addr, r1.d);            
        }
        
        void ld_d_rl__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.d = DoRL(Read8(addr), true);
            Write8(addr, r1.d);            
        }
        
        void ld_d_rlc__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.d = DoRLC(Read8(addr), true);
            Write8(addr, r1.d);            
        }
        
        void ld_d_rlc__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.d = DoRLC(Read8(addr), true);
            Write8(addr, r1.d);            
        }
        
        void ld_d_rr__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.d = DoRR(Read8(addr), true);
            Write8(addr, r1.d);            
        }
        
        void ld_d_rr__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.d = DoRR(Read8(addr), true);
            Write8(addr, r1.d);            
        }
        
        void ld_d_rrc__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.d = DoRRC(Read8(addr), true);
            Write8(addr, r1.d);            
        }
        
        void ld_d_rrc__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.d = DoRRC(Read8(addr), true);
            Write8(addr, r1.d);            
        }
        
        void ld_e_set_0__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.e = DoSetRes(bitStateSET, 0, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_set_0__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.e = DoSetRes(bitStateSET, 0, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_set_1__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.e = DoSetRes(bitStateSET, 1, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_set_1__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.e = DoSetRes(bitStateSET, 1, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_set_2__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.e = DoSetRes(bitStateSET, 2, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_set_2__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.e = DoSetRes(bitStateSET, 2, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_set_3__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.e = DoSetRes(bitStateSET, 3, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_set_3__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.e = DoSetRes(bitStateSET, 3, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_set_4__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.e = DoSetRes(bitStateSET, 4, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_set_4__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.e = DoSetRes(bitStateSET, 4, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_set_5__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.e = DoSetRes(bitStateSET, 5, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_set_5__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.e = DoSetRes(bitStateSET, 5, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_set_6__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.e = DoSetRes(bitStateSET, 6, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_set_6__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.e = DoSetRes(bitStateSET, 6, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_set_7__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.e = DoSetRes(bitStateSET, 7, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_set_7__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.e = DoSetRes(bitStateSET, 7, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_res_0__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.e = DoSetRes(bitStateRES, 0, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_res_0__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.e = DoSetRes(bitStateRES, 0, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_res_1__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.e = DoSetRes(bitStateRES, 1, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_res_1__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.e = DoSetRes(bitStateRES, 1, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_res_2__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.e = DoSetRes(bitStateRES, 2, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_res_2__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.e = DoSetRes(bitStateRES, 2, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_res_3__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.e = DoSetRes(bitStateRES, 3, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_res_3__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.e = DoSetRes(bitStateRES, 3, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_res_4__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.e = DoSetRes(bitStateRES, 4, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_res_4__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.e = DoSetRes(bitStateRES, 4, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_res_5__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.e = DoSetRes(bitStateRES, 5, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_res_5__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.e = DoSetRes(bitStateRES, 5, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_res_6__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.e = DoSetRes(bitStateRES, 6, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_res_6__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.e = DoSetRes(bitStateRES, 6, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_res_7__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.e = DoSetRes(bitStateRES, 7, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_res_7__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.e = DoSetRes(bitStateRES, 7, Read8(addr));
            Write8(addr, r1.e);
        }
        
        void ld_e_sla__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.e = DoSL(Read8(addr), isArithmeticsA);
            Write8(addr, r1.e);
            
        }
        
        void ld_e_sla__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.e = DoSL(Read8(addr), isArithmeticsA);
            Write8(addr, r1.e);
            
        }
        
        void ld_e_sll__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.e = DoSL(Read8(addr), isArithmeticsL);
            Write8(addr, r1.e);
            
        }
        
        void ld_e_sll__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.e = DoSL(Read8(addr), isArithmeticsL);
            Write8(addr, r1.e);
            
        }
        
        void ld_e_sra__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.e = DoSR(Read8(addr), isArithmeticsA);
            Write8(addr, r1.e);
            
        }
        
        void ld_e_sra__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.e = DoSR(Read8(addr), isArithmeticsA);
            Write8(addr, r1.e);
            
        }
        
        void ld_e_srl__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.e = DoSR(Read8(addr), isArithmeticsL);
            Write8(addr, r1.e);
            
        }
        
        void ld_e_srl__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.e = DoSR(Read8(addr), isArithmeticsL);
            Write8(addr, r1.e);
            
        }
        
        void ld_e_rl__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.e = DoRL(Read8(addr), true);
            Write8(addr, r1.e);            
        }
        
        void ld_e_rl__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.e = DoRL(Read8(addr), true);
            Write8(addr, r1.e);            
        }
        
        void ld_e_rlc__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.e = DoRLC(Read8(addr), true);
            Write8(addr, r1.e);            
        }
        
        void ld_e_rlc__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.e = DoRLC(Read8(addr), true);
            Write8(addr, r1.e);            
        }
        
        void ld_e_rr__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.e = DoRR(Read8(addr), true);
            Write8(addr, r1.e);            
        }
        
        void ld_e_rr__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.e = DoRR(Read8(addr), true);
            Write8(addr, r1.e);            
        }
        
        void ld_e_rrc__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.e = DoRRC(Read8(addr), true);
            Write8(addr, r1.e);            
        }
        
        void ld_e_rrc__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.e = DoRRC(Read8(addr), true);
            Write8(addr, r1.e);            
        }
        
        void ld_h_set_0__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.h = DoSetRes(bitStateSET, 0, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_set_0__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.h = DoSetRes(bitStateSET, 0, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_set_1__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.h = DoSetRes(bitStateSET, 1, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_set_1__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.h = DoSetRes(bitStateSET, 1, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_set_2__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.h = DoSetRes(bitStateSET, 2, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_set_2__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.h = DoSetRes(bitStateSET, 2, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_set_3__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.h = DoSetRes(bitStateSET, 3, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_set_3__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.h = DoSetRes(bitStateSET, 3, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_set_4__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.h = DoSetRes(bitStateSET, 4, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_set_4__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.h = DoSetRes(bitStateSET, 4, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_set_5__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.h = DoSetRes(bitStateSET, 5, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_set_5__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.h = DoSetRes(bitStateSET, 5, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_set_6__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.h = DoSetRes(bitStateSET, 6, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_set_6__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.h = DoSetRes(bitStateSET, 6, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_set_7__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.h = DoSetRes(bitStateSET, 7, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_set_7__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.h = DoSetRes(bitStateSET, 7, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_res_0__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.h = DoSetRes(bitStateRES, 0, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_res_0__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.h = DoSetRes(bitStateRES, 0, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_res_1__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.h = DoSetRes(bitStateRES, 1, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_res_1__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.h = DoSetRes(bitStateRES, 1, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_res_2__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.h = DoSetRes(bitStateRES, 2, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_res_2__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.h = DoSetRes(bitStateRES, 2, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_res_3__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.h = DoSetRes(bitStateRES, 3, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_res_3__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.h = DoSetRes(bitStateRES, 3, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_res_4__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.h = DoSetRes(bitStateRES, 4, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_res_4__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.h = DoSetRes(bitStateRES, 4, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_res_5__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.h = DoSetRes(bitStateRES, 5, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_res_5__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.h = DoSetRes(bitStateRES, 5, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_res_6__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.h = DoSetRes(bitStateRES, 6, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_res_6__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.h = DoSetRes(bitStateRES, 6, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_res_7__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.h = DoSetRes(bitStateRES, 7, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_res_7__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.h = DoSetRes(bitStateRES, 7, Read8(addr));
            Write8(addr, r1.h);
        }
        
        void ld_h_sla__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.h = DoSL(Read8(addr), isArithmeticsA);
            Write8(addr, r1.h);
            
        }
        
        void ld_h_sla__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.h = DoSL(Read8(addr), isArithmeticsA);
            Write8(addr, r1.h);
            
        }
        
        void ld_h_sll__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.h = DoSL(Read8(addr), isArithmeticsL);
            Write8(addr, r1.h);
            
        }
        
        void ld_h_sll__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.h = DoSL(Read8(addr), isArithmeticsL);
            Write8(addr, r1.h);
            
        }
        
        void ld_h_sra__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.h = DoSR(Read8(addr), isArithmeticsA);
            Write8(addr, r1.h);
            
        }
        
        void ld_h_sra__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.h = DoSR(Read8(addr), isArithmeticsA);
            Write8(addr, r1.h);
            
        }
        
        void ld_h_srl__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.h = DoSR(Read8(addr), isArithmeticsL);
            Write8(addr, r1.h);
            
        }
        
        void ld_h_srl__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.h = DoSR(Read8(addr), isArithmeticsL);
            Write8(addr, r1.h);
            
        }
        
        void ld_h_rl__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.h = DoRL(Read8(addr), true);
            Write8(addr, r1.h);            
        }
        
        void ld_h_rl__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.h = DoRL(Read8(addr), true);
            Write8(addr, r1.h);            
        }
        
        void ld_h_rlc__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.h = DoRLC(Read8(addr), true);
            Write8(addr, r1.h);            
        }
        
        void ld_h_rlc__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.h = DoRLC(Read8(addr), true);
            Write8(addr, r1.h);            
        }
        
        void ld_h_rr__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.h = DoRR(Read8(addr), true);
            Write8(addr, r1.h);            
        }
        
        void ld_h_rr__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.h = DoRR(Read8(addr), true);
            Write8(addr, r1.h);            
        }
        
        void ld_h_rrc__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.h = DoRRC(Read8(addr), true);
            Write8(addr, r1.h);            
        }
        
        void ld_h_rrc__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.h = DoRRC(Read8(addr), true);
            Write8(addr, r1.h);            
        }
        
        void ld_l_set_0__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.l = DoSetRes(bitStateSET, 0, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_set_0__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.l = DoSetRes(bitStateSET, 0, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_set_1__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.l = DoSetRes(bitStateSET, 1, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_set_1__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.l = DoSetRes(bitStateSET, 1, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_set_2__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.l = DoSetRes(bitStateSET, 2, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_set_2__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.l = DoSetRes(bitStateSET, 2, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_set_3__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.l = DoSetRes(bitStateSET, 3, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_set_3__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.l = DoSetRes(bitStateSET, 3, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_set_4__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.l = DoSetRes(bitStateSET, 4, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_set_4__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.l = DoSetRes(bitStateSET, 4, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_set_5__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.l = DoSetRes(bitStateSET, 5, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_set_5__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.l = DoSetRes(bitStateSET, 5, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_set_6__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.l = DoSetRes(bitStateSET, 6, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_set_6__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.l = DoSetRes(bitStateSET, 6, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_set_7__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.l = DoSetRes(bitStateSET, 7, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_set_7__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.l = DoSetRes(bitStateSET, 7, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_res_0__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.l = DoSetRes(bitStateRES, 0, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_res_0__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.l = DoSetRes(bitStateRES, 0, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_res_1__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.l = DoSetRes(bitStateRES, 1, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_res_1__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.l = DoSetRes(bitStateRES, 1, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_res_2__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.l = DoSetRes(bitStateRES, 2, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_res_2__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.l = DoSetRes(bitStateRES, 2, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_res_3__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.l = DoSetRes(bitStateRES, 3, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_res_3__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.l = DoSetRes(bitStateRES, 3, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_res_4__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.l = DoSetRes(bitStateRES, 4, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_res_4__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.l = DoSetRes(bitStateRES, 4, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_res_5__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.l = DoSetRes(bitStateRES, 5, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_res_5__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.l = DoSetRes(bitStateRES, 5, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_res_6__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.l = DoSetRes(bitStateRES, 6, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_res_6__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.l = DoSetRes(bitStateRES, 6, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_res_7__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.l = DoSetRes(bitStateRES, 7, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_res_7__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.l = DoSetRes(bitStateRES, 7, Read8(addr));
            Write8(addr, r1.l);
        }
        
        void ld_l_sla__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.l = DoSL(Read8(addr), isArithmeticsA);
            Write8(addr, r1.l);
            
        }
        
        void ld_l_sla__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.l = DoSL(Read8(addr), isArithmeticsA);
            Write8(addr, r1.l);
            
        }
        
        void ld_l_sll__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.l = DoSL(Read8(addr), isArithmeticsL);
            Write8(addr, r1.l);
            
        }
        
        void ld_l_sll__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.l = DoSL(Read8(addr), isArithmeticsL);
            Write8(addr, r1.l);
            
        }
        
        void ld_l_sra__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.l = DoSR(Read8(addr), isArithmeticsA);
            Write8(addr, r1.l);
            
        }
        
        void ld_l_sra__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.l = DoSR(Read8(addr), isArithmeticsA);
            Write8(addr, r1.l);
            
        }
        
        void ld_l_srl__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.l = DoSR(Read8(addr), isArithmeticsL);
            Write8(addr, r1.l);
            
        }
        
        void ld_l_srl__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.l = DoSR(Read8(addr), isArithmeticsL);
            Write8(addr, r1.l);
            
        }
        
        void ld_l_rl__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.l = DoRL(Read8(addr), true);
            Write8(addr, r1.l);            
        }
        
        void ld_l_rl__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.l = DoRL(Read8(addr), true);
            Write8(addr, r1.l);            
        }
        
        void ld_l_rlc__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.l = DoRLC(Read8(addr), true);
            Write8(addr, r1.l);            
        }
        
        void ld_l_rlc__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.l = DoRLC(Read8(addr), true);
            Write8(addr, r1.l);            
        }
        
        void ld_l_rr__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.l = DoRR(Read8(addr), true);
            Write8(addr, r1.l);            
        }
        
        void ld_l_rr__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.l = DoRR(Read8(addr), true);
            Write8(addr, r1.l);            
        }
        
        void ld_l_rrc__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.ix + offset);
            r1.l = DoRRC(Read8(addr), true);
            Write8(addr, r1.l);            
        }
        
        void ld_l_rrc__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            ushort addr = (ushort)(r1.iy + offset);
            r1.l = DoRRC(Read8(addr), true);
            Write8(addr, r1.l);            
        }
        

    }
}