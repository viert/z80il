using System;

namespace Z80 {
    public class Cpu: BaseCpu {

        public Cpu(IMemory mem) : base(mem) {
            
        }

        protected override void CreateTables() {
            base.CreateTables();

            // LD r, r'
            opcodeTable.entries[64] = new OpcodeTableEntry(ld_b_b, "ld b, b", new ArgType[]{});
            opcodeTable.entries[65] = new OpcodeTableEntry(ld_b_c, "ld b, c", new ArgType[]{});
            opcodeTable.entries[66] = new OpcodeTableEntry(ld_b_d, "ld b, d", new ArgType[]{});
            opcodeTable.entries[67] = new OpcodeTableEntry(ld_b_e, "ld b, e", new ArgType[]{});
            opcodeTable.entries[68] = new OpcodeTableEntry(ld_b_h, "ld b, h", new ArgType[]{});
            opcodeTable.entries[69] = new OpcodeTableEntry(ld_b_l, "ld b, l", new ArgType[]{});
            opcodeTable.entries[71] = new OpcodeTableEntry(ld_b_a, "ld b, a", new ArgType[]{});
            opcodeTable.entries[72] = new OpcodeTableEntry(ld_c_b, "ld c, b", new ArgType[]{});
            opcodeTable.entries[73] = new OpcodeTableEntry(ld_c_c, "ld c, c", new ArgType[]{});
            opcodeTable.entries[74] = new OpcodeTableEntry(ld_c_d, "ld c, d", new ArgType[]{});
            opcodeTable.entries[75] = new OpcodeTableEntry(ld_c_e, "ld c, e", new ArgType[]{});
            opcodeTable.entries[76] = new OpcodeTableEntry(ld_c_h, "ld c, h", new ArgType[]{});
            opcodeTable.entries[77] = new OpcodeTableEntry(ld_c_l, "ld c, l", new ArgType[]{});
            opcodeTable.entries[79] = new OpcodeTableEntry(ld_c_a, "ld c, a", new ArgType[]{});
            opcodeTable.entries[80] = new OpcodeTableEntry(ld_d_b, "ld d, b", new ArgType[]{});
            opcodeTable.entries[81] = new OpcodeTableEntry(ld_d_c, "ld d, c", new ArgType[]{});
            opcodeTable.entries[82] = new OpcodeTableEntry(ld_d_d, "ld d, d", new ArgType[]{});
            opcodeTable.entries[83] = new OpcodeTableEntry(ld_d_e, "ld d, e", new ArgType[]{});
            opcodeTable.entries[84] = new OpcodeTableEntry(ld_d_h, "ld d, h", new ArgType[]{});
            opcodeTable.entries[85] = new OpcodeTableEntry(ld_d_l, "ld d, l", new ArgType[]{});
            opcodeTable.entries[87] = new OpcodeTableEntry(ld_d_a, "ld d, a", new ArgType[]{});
            opcodeTable.entries[88] = new OpcodeTableEntry(ld_e_b, "ld e, b", new ArgType[]{});
            opcodeTable.entries[89] = new OpcodeTableEntry(ld_e_c, "ld e, c", new ArgType[]{});
            opcodeTable.entries[90] = new OpcodeTableEntry(ld_e_d, "ld e, d", new ArgType[]{});
            opcodeTable.entries[91] = new OpcodeTableEntry(ld_e_e, "ld e, e", new ArgType[]{});
            opcodeTable.entries[92] = new OpcodeTableEntry(ld_e_h, "ld e, h", new ArgType[]{});
            opcodeTable.entries[93] = new OpcodeTableEntry(ld_e_l, "ld e, l", new ArgType[]{});
            opcodeTable.entries[95] = new OpcodeTableEntry(ld_e_a, "ld e, a", new ArgType[]{});
            opcodeTable.entries[96] = new OpcodeTableEntry(ld_h_b, "ld h, b", new ArgType[]{});
            opcodeTable.entries[97] = new OpcodeTableEntry(ld_h_c, "ld h, c", new ArgType[]{});
            opcodeTable.entries[98] = new OpcodeTableEntry(ld_h_d, "ld h, d", new ArgType[]{});
            opcodeTable.entries[99] = new OpcodeTableEntry(ld_h_e, "ld h, e", new ArgType[]{});
            opcodeTable.entries[100] = new OpcodeTableEntry(ld_h_h, "ld h, h", new ArgType[]{});
            opcodeTable.entries[101] = new OpcodeTableEntry(ld_h_l, "ld h, l", new ArgType[]{});
            opcodeTable.entries[103] = new OpcodeTableEntry(ld_h_a, "ld h, a", new ArgType[]{});
            opcodeTable.entries[104] = new OpcodeTableEntry(ld_l_b, "ld l, b", new ArgType[]{});
            opcodeTable.entries[105] = new OpcodeTableEntry(ld_l_c, "ld l, c", new ArgType[]{});
            opcodeTable.entries[106] = new OpcodeTableEntry(ld_l_d, "ld l, d", new ArgType[]{});
            opcodeTable.entries[107] = new OpcodeTableEntry(ld_l_e, "ld l, e", new ArgType[]{});
            opcodeTable.entries[108] = new OpcodeTableEntry(ld_l_h, "ld l, h", new ArgType[]{});
            opcodeTable.entries[109] = new OpcodeTableEntry(ld_l_l, "ld l, l", new ArgType[]{});
            opcodeTable.entries[111] = new OpcodeTableEntry(ld_l_a, "ld l, a", new ArgType[]{});
            opcodeTable.entries[120] = new OpcodeTableEntry(ld_a_b, "ld a, b", new ArgType[]{});
            opcodeTable.entries[121] = new OpcodeTableEntry(ld_a_c, "ld a, c", new ArgType[]{});
            opcodeTable.entries[122] = new OpcodeTableEntry(ld_a_d, "ld a, d", new ArgType[]{});
            opcodeTable.entries[123] = new OpcodeTableEntry(ld_a_e, "ld a, e", new ArgType[]{});
            opcodeTable.entries[124] = new OpcodeTableEntry(ld_a_h, "ld a, h", new ArgType[]{});
            opcodeTable.entries[125] = new OpcodeTableEntry(ld_a_l, "ld a, l", new ArgType[]{});
            opcodeTable.entries[127] = new OpcodeTableEntry(ld_a_a, "ld a, a", new ArgType[]{});
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
            opcodeTable.entries[0x36] = new OpcodeTableEntry(ld__hl__n, "ld (hl), n", new ArgType[]{ArgType.Byte});
            
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
                new OpcodeTableEntry(ld_b__ix_d_, "ld b, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[70] = 
                new OpcodeTableEntry(ld_b__iy_d_, "ld b, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[78] = 
                new OpcodeTableEntry(ld_c__ix_d_, "ld c, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[78] = 
                new OpcodeTableEntry(ld_c__iy_d_, "ld c, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[86] = 
                new OpcodeTableEntry(ld_d__ix_d_, "ld d, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[86] = 
                new OpcodeTableEntry(ld_d__iy_d_, "ld d, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[94] = 
                new OpcodeTableEntry(ld_e__ix_d_, "ld e, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[94] = 
                new OpcodeTableEntry(ld_e__iy_d_, "ld e, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[102] = 
                new OpcodeTableEntry(ld_h__ix_d_, "ld h, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[102] = 
                new OpcodeTableEntry(ld_h__iy_d_, "ld h, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[110] = 
                new OpcodeTableEntry(ld_l__ix_d_, "ld l, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[110] = 
                new OpcodeTableEntry(ld_l__iy_d_, "ld l, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[126] = 
                new OpcodeTableEntry(ld_a__ix_d_, "ld a, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[126] = 
                new OpcodeTableEntry(ld_a__iy_d_, "ld a, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[112] = 
                new OpcodeTableEntry(ld__ix_d__b, "ld (ix+{0}), b", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[112] = 
                new OpcodeTableEntry(ld__iy_d__b, "ld (iy+{0}), b", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[113] = 
                new OpcodeTableEntry(ld__ix_d__c, "ld (ix+{0}), c", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[113] = 
                new OpcodeTableEntry(ld__iy_d__c, "ld (iy+{0}), c", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[114] = 
                new OpcodeTableEntry(ld__ix_d__d, "ld (ix+{0}), d", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[114] = 
                new OpcodeTableEntry(ld__iy_d__d, "ld (iy+{0}), d", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[115] = 
                new OpcodeTableEntry(ld__ix_d__e, "ld (ix+{0}), e", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[115] = 
                new OpcodeTableEntry(ld__iy_d__e, "ld (iy+{0}), e", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[116] = 
                new OpcodeTableEntry(ld__ix_d__h, "ld (ix+{0}), h", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[116] = 
                new OpcodeTableEntry(ld__iy_d__h, "ld (iy+{0}), h", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[117] = 
                new OpcodeTableEntry(ld__ix_d__l, "ld (ix+{0}), l", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[117] = 
                new OpcodeTableEntry(ld__iy_d__l, "ld (iy+{0}), l", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[119] = 
                new OpcodeTableEntry(ld__ix_d__a, "ld (ix+{0}), a", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[119] = 
                new OpcodeTableEntry(ld__iy_d__a, "ld (iy+{0}), a", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0x36] =
                new OpcodeTableEntry(ld__ix_d__n, "ld (ix+{0}), {1}", new ArgType[]{ArgType.Offset, ArgType.Byte});
            opcodeTable.entries[253].nextTable.entries[0x36] =
                new OpcodeTableEntry(ld__iy_d__n, "ld (iy+{0}), {1}", new ArgType[]{ArgType.Offset, ArgType.Byte});

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
			opcodeTableDD.entries[0x86] = new OpcodeTableEntry(add_a__ix_d_, "add a, (ix+{0})", new ArgType[]{ArgType.Offset});
			opcodeTableFD.entries[0x86] = new OpcodeTableEntry(add_a__iy_d_, "add a, (iy+{0})", new ArgType[]{ArgType.Offset});
			opcodeTable.entries[0x8E] = new OpcodeTableEntry(adc_a__hl_, "adc a, (hl)", new ArgType[]{});
			opcodeTableDD.entries[0x8E] = new OpcodeTableEntry(adc_a__ix_d_, "adc a, (ix+{0})", new ArgType[]{ArgType.Offset});
			opcodeTableFD.entries[0x8E] = new OpcodeTableEntry(adc_a__iy_d_, "adc a, (iy+{0})", new ArgType[]{ArgType.Offset});
			opcodeTable.entries[0x96] = new OpcodeTableEntry(sub_a__hl_, "sub (hl)", new ArgType[]{});
			opcodeTableDD.entries[0x96] = new OpcodeTableEntry(sub_a__ix_d_, "sub (ix+{0})", new ArgType[]{ArgType.Offset});
			opcodeTableFD.entries[0x96] = new OpcodeTableEntry(sub_a__iy_d_, "sub (iy+{0})", new ArgType[]{ArgType.Offset});
			opcodeTable.entries[0x9E] = new OpcodeTableEntry(sbc_a__hl_, "sbc a, (hl)", new ArgType[]{});
			opcodeTableDD.entries[0x9E] = new OpcodeTableEntry(sbc_a__ix_d_, "sbc a, (ix+{0})", new ArgType[]{ArgType.Offset});
			opcodeTableFD.entries[0x9E] = new OpcodeTableEntry(sbc_a__iy_d_, "sbc a, (iy+{0})", new ArgType[]{ArgType.Offset});

			// ADD HL, BC/DE/HL/SP
			opcodeTable.entries[9] = new OpcodeTableEntry(add_hl_bc, "add hl, bc", new ArgType[]{});
			opcodeTableED.entries[74] = new OpcodeTableEntry(adc_hl_bc, "adc hl, bc", new ArgType[]{});
			opcodeTableED.entries[66] = new OpcodeTableEntry(sbc_hl_bc, "sbc hl, bc", new ArgType[]{});
			opcodeTable.entries[221].nextTable.entries[66] = 
				new OpcodeTableEntry(add_ix_bc, "add ix, bc", new ArgType[]{});
			opcodeTable.entries[253].nextTable.entries[66] = 
				new OpcodeTableEntry(add_iy_bc, "add iy, bc", new ArgType[]{});
			opcodeTable.entries[25] = new OpcodeTableEntry(add_hl_de, "add hl, de", new ArgType[]{});
			opcodeTableED.entries[90] = new OpcodeTableEntry(adc_hl_de, "adc hl, de", new ArgType[]{});
			opcodeTableED.entries[82] = new OpcodeTableEntry(sbc_hl_de, "sbc hl, de", new ArgType[]{});
			opcodeTable.entries[221].nextTable.entries[82] = 
				new OpcodeTableEntry(add_ix_de, "add ix, de", new ArgType[]{});
			opcodeTable.entries[253].nextTable.entries[82] = 
				new OpcodeTableEntry(add_iy_de, "add iy, de", new ArgType[]{});
			opcodeTable.entries[41] = new OpcodeTableEntry(add_hl_hl, "add hl, hl", new ArgType[]{});
			opcodeTableED.entries[106] = new OpcodeTableEntry(adc_hl_hl, "adc hl, hl", new ArgType[]{});
			opcodeTableED.entries[98] = new OpcodeTableEntry(sbc_hl_hl, "sbc hl, hl", new ArgType[]{});
			opcodeTable.entries[221].nextTable.entries[98] = 
				new OpcodeTableEntry(add_ix_ix, "add ix, ix", new ArgType[]{});
			opcodeTable.entries[253].nextTable.entries[98] = 
				new OpcodeTableEntry(add_iy_iy, "add iy, iy", new ArgType[]{});
			opcodeTable.entries[57] = new OpcodeTableEntry(add_hl_sp, "add hl, sp", new ArgType[]{});
			opcodeTableED.entries[122] = new OpcodeTableEntry(adc_hl_sp, "adc hl, sp", new ArgType[]{});
			opcodeTableED.entries[114] = new OpcodeTableEntry(sbc_hl_sp, "sbc hl, sp", new ArgType[]{});
			opcodeTable.entries[221].nextTable.entries[114] = 
				new OpcodeTableEntry(add_ix_sp, "add ix, sp", new ArgType[]{});
			opcodeTable.entries[253].nextTable.entries[114] = 
				new OpcodeTableEntry(add_iy_sp, "add iy, sp", new ArgType[]{});
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
                new OpcodeTableEntry(and__ix_d_, "and (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xB6] = 
                new OpcodeTableEntry(or__ix_d_, "or (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xAE] = 
                new OpcodeTableEntry(xor__ix_d_, "xor (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0xBE] = 
                new OpcodeTableEntry(cp__ix_d_, "cp (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0x34] = 
                new OpcodeTableEntry(inc__ix_d_, "inc (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[221].nextTable.entries[0x35] = 
                new OpcodeTableEntry(dec__ix_d_, "dec (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xA6] = 
                new OpcodeTableEntry(and__iy_d_, "and (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xB6] = 
                new OpcodeTableEntry(or__iy_d_, "or (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xAE] = 
                new OpcodeTableEntry(xor__iy_d_, "xor (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0xBE] = 
                new OpcodeTableEntry(cp__iy_d_, "cp (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0x34] = 
                new OpcodeTableEntry(inc__iy_d_, "inc (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTable.entries[253].nextTable.entries[0x35] = 
                new OpcodeTableEntry(dec__iy_d_, "dec (iy+{0})", new ArgType[]{ArgType.Offset});
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
            
            opcodeTable.entries[0x6F] = new OpcodeTableEntry(rld, "rld", new ArgType[]{});
            opcodeTable.entries[0x67] = new OpcodeTableEntry(rrd, "rrd", new ArgType[]{});
           
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
            
            opcodeTableDDCB.entries[0x06] = new OpcodeTableEntry(rlc__ix_d_, "rlc (ix+{0})", new ArgType[]{ArgType.Offset});       
            opcodeTableDDCB.entries[0x16] = new OpcodeTableEntry(rl__ix_d_, "rl (ix+{0})", new ArgType[]{ArgType.Offset});       
            opcodeTableDDCB.entries[0x0E] = new OpcodeTableEntry(rrc__ix_d_, "rrc (ix+{0})", new ArgType[]{ArgType.Offset});       
            opcodeTableDDCB.entries[0x1E] = new OpcodeTableEntry(rr__ix_d_, "rr (ix+{0})", new ArgType[]{ArgType.Offset});  

            opcodeTableFDCB.entries[0x06] = new OpcodeTableEntry(rlc__iy_d_, "rlc (iy+{0})", new ArgType[]{ArgType.Offset});       
            opcodeTableFDCB.entries[0x16] = new OpcodeTableEntry(rl__iy_d_, "rl (iy+{0})", new ArgType[]{ArgType.Offset});       
            opcodeTableFDCB.entries[0x0E] = new OpcodeTableEntry(rrc__iy_d_, "rrc (iy+{0})", new ArgType[]{ArgType.Offset});       
            opcodeTableFDCB.entries[0x1E] = new OpcodeTableEntry(rr__iy_d_, "rr (iy+{0})", new ArgType[]{ArgType.Offset});  
            
            opcodeTableCB.entries[0x26] = new OpcodeTableEntry(sla__hl_, "sla (hl)", new ArgType[]{});       
            opcodeTableCB.entries[0x2E] = new OpcodeTableEntry(sra__hl_, "sra (hl)", new ArgType[]{});       
            opcodeTableCB.entries[0x36] = new OpcodeTableEntry(sll__hl_, "sll (hl)", new ArgType[]{});       
            opcodeTableCB.entries[0x3E] = new OpcodeTableEntry(srl__hl_, "srl (hl)", new ArgType[]{});

            opcodeTableDDCB.entries[0x26] = new OpcodeTableEntry(sla__ix_d_, "sla (ix+{0})", new ArgType[]{ArgType.Offset});       
            opcodeTableDDCB.entries[0x2E] = new OpcodeTableEntry(sra__ix_d_, "sra (ix+{0})", new ArgType[]{ArgType.Offset});       
            opcodeTableDDCB.entries[0x36] = new OpcodeTableEntry(sll__ix_d_, "sll (ix+{0})", new ArgType[]{ArgType.Offset});       
            opcodeTableDDCB.entries[0x3E] = new OpcodeTableEntry(srl__ix_d_, "srl (ix+{0})", new ArgType[]{ArgType.Offset});
                 
            opcodeTableFDCB.entries[0x26] = new OpcodeTableEntry(sla__iy_d_, "sla (iy+{0})", new ArgType[]{ArgType.Offset});       
            opcodeTableFDCB.entries[0x2E] = new OpcodeTableEntry(sra__iy_d_, "sra (iy+{0})", new ArgType[]{ArgType.Offset});       
            opcodeTableFDCB.entries[0x36] = new OpcodeTableEntry(sll__iy_d_, "sll (iy+{0})", new ArgType[]{ArgType.Offset});       
            opcodeTableFDCB.entries[0x3E] = new OpcodeTableEntry(srl__iy_d_, "srl (iy+{0})", new ArgType[]{ArgType.Offset});

            // BIT test
                        
            opcodeTableCB.entries[64] = new OpcodeTableEntry(bit_0_b, "bit 0, b", new ArgType[]{});
            opcodeTableCB.entries[65] = new OpcodeTableEntry(bit_0_c, "bit 0, c", new ArgType[]{});
            opcodeTableCB.entries[66] = new OpcodeTableEntry(bit_0_d, "bit 0, d", new ArgType[]{});
            opcodeTableCB.entries[67] = new OpcodeTableEntry(bit_0_e, "bit 0, e", new ArgType[]{});
            opcodeTableCB.entries[68] = new OpcodeTableEntry(bit_0_h, "bit 0, h", new ArgType[]{});
            opcodeTableCB.entries[69] = new OpcodeTableEntry(bit_0_l, "bit 0, l", new ArgType[]{});
            opcodeTableCB.entries[71] = new OpcodeTableEntry(bit_0_a, "bit 0, a", new ArgType[]{});
            opcodeTableCB.entries[70] = new OpcodeTableEntry(bit_0__hl_, "bit 0, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[64] = new OpcodeTableEntry(bit_0__ix_d_, "bit 0, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[64] = new OpcodeTableEntry(bit_0__iy_d_, "bit 0, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[65] = new OpcodeTableEntry(bit_0__ix_d_, "bit 0, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[65] = new OpcodeTableEntry(bit_0__iy_d_, "bit 0, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[66] = new OpcodeTableEntry(bit_0__ix_d_, "bit 0, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[66] = new OpcodeTableEntry(bit_0__iy_d_, "bit 0, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[67] = new OpcodeTableEntry(bit_0__ix_d_, "bit 0, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[67] = new OpcodeTableEntry(bit_0__iy_d_, "bit 0, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[68] = new OpcodeTableEntry(bit_0__ix_d_, "bit 0, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[68] = new OpcodeTableEntry(bit_0__iy_d_, "bit 0, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[69] = new OpcodeTableEntry(bit_0__ix_d_, "bit 0, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[69] = new OpcodeTableEntry(bit_0__iy_d_, "bit 0, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[70] = new OpcodeTableEntry(bit_0__ix_d_, "bit 0, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[70] = new OpcodeTableEntry(bit_0__iy_d_, "bit 0, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[71] = new OpcodeTableEntry(bit_0__ix_d_, "bit 0, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[71] = new OpcodeTableEntry(bit_0__iy_d_, "bit 0, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[72] = new OpcodeTableEntry(bit_1_b, "bit 1, b", new ArgType[]{});
            opcodeTableCB.entries[73] = new OpcodeTableEntry(bit_1_c, "bit 1, c", new ArgType[]{});
            opcodeTableCB.entries[74] = new OpcodeTableEntry(bit_1_d, "bit 1, d", new ArgType[]{});
            opcodeTableCB.entries[75] = new OpcodeTableEntry(bit_1_e, "bit 1, e", new ArgType[]{});
            opcodeTableCB.entries[76] = new OpcodeTableEntry(bit_1_h, "bit 1, h", new ArgType[]{});
            opcodeTableCB.entries[77] = new OpcodeTableEntry(bit_1_l, "bit 1, l", new ArgType[]{});
            opcodeTableCB.entries[79] = new OpcodeTableEntry(bit_1_a, "bit 1, a", new ArgType[]{});
            opcodeTableCB.entries[78] = new OpcodeTableEntry(bit_1__hl_, "bit 1, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[72] = new OpcodeTableEntry(bit_1__ix_d_, "bit 1, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[72] = new OpcodeTableEntry(bit_1__iy_d_, "bit 1, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[73] = new OpcodeTableEntry(bit_1__ix_d_, "bit 1, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[73] = new OpcodeTableEntry(bit_1__iy_d_, "bit 1, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[74] = new OpcodeTableEntry(bit_1__ix_d_, "bit 1, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[74] = new OpcodeTableEntry(bit_1__iy_d_, "bit 1, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[75] = new OpcodeTableEntry(bit_1__ix_d_, "bit 1, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[75] = new OpcodeTableEntry(bit_1__iy_d_, "bit 1, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[76] = new OpcodeTableEntry(bit_1__ix_d_, "bit 1, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[76] = new OpcodeTableEntry(bit_1__iy_d_, "bit 1, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[77] = new OpcodeTableEntry(bit_1__ix_d_, "bit 1, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[77] = new OpcodeTableEntry(bit_1__iy_d_, "bit 1, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[78] = new OpcodeTableEntry(bit_1__ix_d_, "bit 1, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[78] = new OpcodeTableEntry(bit_1__iy_d_, "bit 1, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[79] = new OpcodeTableEntry(bit_1__ix_d_, "bit 1, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[79] = new OpcodeTableEntry(bit_1__iy_d_, "bit 1, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[80] = new OpcodeTableEntry(bit_2_b, "bit 2, b", new ArgType[]{});
            opcodeTableCB.entries[81] = new OpcodeTableEntry(bit_2_c, "bit 2, c", new ArgType[]{});
            opcodeTableCB.entries[82] = new OpcodeTableEntry(bit_2_d, "bit 2, d", new ArgType[]{});
            opcodeTableCB.entries[83] = new OpcodeTableEntry(bit_2_e, "bit 2, e", new ArgType[]{});
            opcodeTableCB.entries[84] = new OpcodeTableEntry(bit_2_h, "bit 2, h", new ArgType[]{});
            opcodeTableCB.entries[85] = new OpcodeTableEntry(bit_2_l, "bit 2, l", new ArgType[]{});
            opcodeTableCB.entries[87] = new OpcodeTableEntry(bit_2_a, "bit 2, a", new ArgType[]{});
            opcodeTableCB.entries[86] = new OpcodeTableEntry(bit_2__hl_, "bit 2, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[80] = new OpcodeTableEntry(bit_2__ix_d_, "bit 2, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[80] = new OpcodeTableEntry(bit_2__iy_d_, "bit 2, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[81] = new OpcodeTableEntry(bit_2__ix_d_, "bit 2, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[81] = new OpcodeTableEntry(bit_2__iy_d_, "bit 2, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[82] = new OpcodeTableEntry(bit_2__ix_d_, "bit 2, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[82] = new OpcodeTableEntry(bit_2__iy_d_, "bit 2, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[83] = new OpcodeTableEntry(bit_2__ix_d_, "bit 2, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[83] = new OpcodeTableEntry(bit_2__iy_d_, "bit 2, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[84] = new OpcodeTableEntry(bit_2__ix_d_, "bit 2, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[84] = new OpcodeTableEntry(bit_2__iy_d_, "bit 2, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[85] = new OpcodeTableEntry(bit_2__ix_d_, "bit 2, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[85] = new OpcodeTableEntry(bit_2__iy_d_, "bit 2, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[86] = new OpcodeTableEntry(bit_2__ix_d_, "bit 2, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[86] = new OpcodeTableEntry(bit_2__iy_d_, "bit 2, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[87] = new OpcodeTableEntry(bit_2__ix_d_, "bit 2, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[87] = new OpcodeTableEntry(bit_2__iy_d_, "bit 2, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[88] = new OpcodeTableEntry(bit_3_b, "bit 3, b", new ArgType[]{});
            opcodeTableCB.entries[89] = new OpcodeTableEntry(bit_3_c, "bit 3, c", new ArgType[]{});
            opcodeTableCB.entries[90] = new OpcodeTableEntry(bit_3_d, "bit 3, d", new ArgType[]{});
            opcodeTableCB.entries[91] = new OpcodeTableEntry(bit_3_e, "bit 3, e", new ArgType[]{});
            opcodeTableCB.entries[92] = new OpcodeTableEntry(bit_3_h, "bit 3, h", new ArgType[]{});
            opcodeTableCB.entries[93] = new OpcodeTableEntry(bit_3_l, "bit 3, l", new ArgType[]{});
            opcodeTableCB.entries[95] = new OpcodeTableEntry(bit_3_a, "bit 3, a", new ArgType[]{});
            opcodeTableCB.entries[94] = new OpcodeTableEntry(bit_3__hl_, "bit 3, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[88] = new OpcodeTableEntry(bit_3__ix_d_, "bit 3, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[88] = new OpcodeTableEntry(bit_3__iy_d_, "bit 3, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[89] = new OpcodeTableEntry(bit_3__ix_d_, "bit 3, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[89] = new OpcodeTableEntry(bit_3__iy_d_, "bit 3, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[90] = new OpcodeTableEntry(bit_3__ix_d_, "bit 3, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[90] = new OpcodeTableEntry(bit_3__iy_d_, "bit 3, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[91] = new OpcodeTableEntry(bit_3__ix_d_, "bit 3, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[91] = new OpcodeTableEntry(bit_3__iy_d_, "bit 3, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[92] = new OpcodeTableEntry(bit_3__ix_d_, "bit 3, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[92] = new OpcodeTableEntry(bit_3__iy_d_, "bit 3, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[93] = new OpcodeTableEntry(bit_3__ix_d_, "bit 3, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[93] = new OpcodeTableEntry(bit_3__iy_d_, "bit 3, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[94] = new OpcodeTableEntry(bit_3__ix_d_, "bit 3, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[94] = new OpcodeTableEntry(bit_3__iy_d_, "bit 3, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[95] = new OpcodeTableEntry(bit_3__ix_d_, "bit 3, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[95] = new OpcodeTableEntry(bit_3__iy_d_, "bit 3, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[96] = new OpcodeTableEntry(bit_4_b, "bit 4, b", new ArgType[]{});
            opcodeTableCB.entries[97] = new OpcodeTableEntry(bit_4_c, "bit 4, c", new ArgType[]{});
            opcodeTableCB.entries[98] = new OpcodeTableEntry(bit_4_d, "bit 4, d", new ArgType[]{});
            opcodeTableCB.entries[99] = new OpcodeTableEntry(bit_4_e, "bit 4, e", new ArgType[]{});
            opcodeTableCB.entries[100] = new OpcodeTableEntry(bit_4_h, "bit 4, h", new ArgType[]{});
            opcodeTableCB.entries[101] = new OpcodeTableEntry(bit_4_l, "bit 4, l", new ArgType[]{});
            opcodeTableCB.entries[103] = new OpcodeTableEntry(bit_4_a, "bit 4, a", new ArgType[]{});
            opcodeTableCB.entries[102] = new OpcodeTableEntry(bit_4__hl_, "bit 4, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[96] = new OpcodeTableEntry(bit_4__ix_d_, "bit 4, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[96] = new OpcodeTableEntry(bit_4__iy_d_, "bit 4, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[97] = new OpcodeTableEntry(bit_4__ix_d_, "bit 4, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[97] = new OpcodeTableEntry(bit_4__iy_d_, "bit 4, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[98] = new OpcodeTableEntry(bit_4__ix_d_, "bit 4, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[98] = new OpcodeTableEntry(bit_4__iy_d_, "bit 4, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[99] = new OpcodeTableEntry(bit_4__ix_d_, "bit 4, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[99] = new OpcodeTableEntry(bit_4__iy_d_, "bit 4, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[100] = new OpcodeTableEntry(bit_4__ix_d_, "bit 4, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[100] = new OpcodeTableEntry(bit_4__iy_d_, "bit 4, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[101] = new OpcodeTableEntry(bit_4__ix_d_, "bit 4, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[101] = new OpcodeTableEntry(bit_4__iy_d_, "bit 4, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[102] = new OpcodeTableEntry(bit_4__ix_d_, "bit 4, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[102] = new OpcodeTableEntry(bit_4__iy_d_, "bit 4, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[103] = new OpcodeTableEntry(bit_4__ix_d_, "bit 4, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[103] = new OpcodeTableEntry(bit_4__iy_d_, "bit 4, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[104] = new OpcodeTableEntry(bit_5_b, "bit 5, b", new ArgType[]{});
            opcodeTableCB.entries[105] = new OpcodeTableEntry(bit_5_c, "bit 5, c", new ArgType[]{});
            opcodeTableCB.entries[106] = new OpcodeTableEntry(bit_5_d, "bit 5, d", new ArgType[]{});
            opcodeTableCB.entries[107] = new OpcodeTableEntry(bit_5_e, "bit 5, e", new ArgType[]{});
            opcodeTableCB.entries[108] = new OpcodeTableEntry(bit_5_h, "bit 5, h", new ArgType[]{});
            opcodeTableCB.entries[109] = new OpcodeTableEntry(bit_5_l, "bit 5, l", new ArgType[]{});
            opcodeTableCB.entries[111] = new OpcodeTableEntry(bit_5_a, "bit 5, a", new ArgType[]{});
            opcodeTableCB.entries[110] = new OpcodeTableEntry(bit_5__hl_, "bit 5, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[104] = new OpcodeTableEntry(bit_5__ix_d_, "bit 5, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[104] = new OpcodeTableEntry(bit_5__iy_d_, "bit 5, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[105] = new OpcodeTableEntry(bit_5__ix_d_, "bit 5, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[105] = new OpcodeTableEntry(bit_5__iy_d_, "bit 5, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[106] = new OpcodeTableEntry(bit_5__ix_d_, "bit 5, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[106] = new OpcodeTableEntry(bit_5__iy_d_, "bit 5, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[107] = new OpcodeTableEntry(bit_5__ix_d_, "bit 5, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[107] = new OpcodeTableEntry(bit_5__iy_d_, "bit 5, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[108] = new OpcodeTableEntry(bit_5__ix_d_, "bit 5, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[108] = new OpcodeTableEntry(bit_5__iy_d_, "bit 5, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[109] = new OpcodeTableEntry(bit_5__ix_d_, "bit 5, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[109] = new OpcodeTableEntry(bit_5__iy_d_, "bit 5, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[110] = new OpcodeTableEntry(bit_5__ix_d_, "bit 5, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[110] = new OpcodeTableEntry(bit_5__iy_d_, "bit 5, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[111] = new OpcodeTableEntry(bit_5__ix_d_, "bit 5, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[111] = new OpcodeTableEntry(bit_5__iy_d_, "bit 5, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[112] = new OpcodeTableEntry(bit_6_b, "bit 6, b", new ArgType[]{});
            opcodeTableCB.entries[113] = new OpcodeTableEntry(bit_6_c, "bit 6, c", new ArgType[]{});
            opcodeTableCB.entries[114] = new OpcodeTableEntry(bit_6_d, "bit 6, d", new ArgType[]{});
            opcodeTableCB.entries[115] = new OpcodeTableEntry(bit_6_e, "bit 6, e", new ArgType[]{});
            opcodeTableCB.entries[116] = new OpcodeTableEntry(bit_6_h, "bit 6, h", new ArgType[]{});
            opcodeTableCB.entries[117] = new OpcodeTableEntry(bit_6_l, "bit 6, l", new ArgType[]{});
            opcodeTableCB.entries[119] = new OpcodeTableEntry(bit_6_a, "bit 6, a", new ArgType[]{});
            opcodeTableCB.entries[118] = new OpcodeTableEntry(bit_6__hl_, "bit 6, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[112] = new OpcodeTableEntry(bit_6__ix_d_, "bit 6, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[112] = new OpcodeTableEntry(bit_6__iy_d_, "bit 6, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[113] = new OpcodeTableEntry(bit_6__ix_d_, "bit 6, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[113] = new OpcodeTableEntry(bit_6__iy_d_, "bit 6, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[114] = new OpcodeTableEntry(bit_6__ix_d_, "bit 6, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[114] = new OpcodeTableEntry(bit_6__iy_d_, "bit 6, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[115] = new OpcodeTableEntry(bit_6__ix_d_, "bit 6, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[115] = new OpcodeTableEntry(bit_6__iy_d_, "bit 6, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[116] = new OpcodeTableEntry(bit_6__ix_d_, "bit 6, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[116] = new OpcodeTableEntry(bit_6__iy_d_, "bit 6, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[117] = new OpcodeTableEntry(bit_6__ix_d_, "bit 6, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[117] = new OpcodeTableEntry(bit_6__iy_d_, "bit 6, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[118] = new OpcodeTableEntry(bit_6__ix_d_, "bit 6, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[118] = new OpcodeTableEntry(bit_6__iy_d_, "bit 6, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[119] = new OpcodeTableEntry(bit_6__ix_d_, "bit 6, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[119] = new OpcodeTableEntry(bit_6__iy_d_, "bit 6, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[120] = new OpcodeTableEntry(bit_7_b, "bit 7, b", new ArgType[]{});
            opcodeTableCB.entries[121] = new OpcodeTableEntry(bit_7_c, "bit 7, c", new ArgType[]{});
            opcodeTableCB.entries[122] = new OpcodeTableEntry(bit_7_d, "bit 7, d", new ArgType[]{});
            opcodeTableCB.entries[123] = new OpcodeTableEntry(bit_7_e, "bit 7, e", new ArgType[]{});
            opcodeTableCB.entries[124] = new OpcodeTableEntry(bit_7_h, "bit 7, h", new ArgType[]{});
            opcodeTableCB.entries[125] = new OpcodeTableEntry(bit_7_l, "bit 7, l", new ArgType[]{});
            opcodeTableCB.entries[127] = new OpcodeTableEntry(bit_7_a, "bit 7, a", new ArgType[]{});
            opcodeTableCB.entries[126] = new OpcodeTableEntry(bit_7__hl_, "bit 7, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[120] = new OpcodeTableEntry(bit_7__ix_d_, "bit 7, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[120] = new OpcodeTableEntry(bit_7__iy_d_, "bit 7, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[121] = new OpcodeTableEntry(bit_7__ix_d_, "bit 7, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[121] = new OpcodeTableEntry(bit_7__iy_d_, "bit 7, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[122] = new OpcodeTableEntry(bit_7__ix_d_, "bit 7, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[122] = new OpcodeTableEntry(bit_7__iy_d_, "bit 7, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[123] = new OpcodeTableEntry(bit_7__ix_d_, "bit 7, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[123] = new OpcodeTableEntry(bit_7__iy_d_, "bit 7, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[124] = new OpcodeTableEntry(bit_7__ix_d_, "bit 7, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[124] = new OpcodeTableEntry(bit_7__iy_d_, "bit 7, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[125] = new OpcodeTableEntry(bit_7__ix_d_, "bit 7, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[125] = new OpcodeTableEntry(bit_7__iy_d_, "bit 7, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[126] = new OpcodeTableEntry(bit_7__ix_d_, "bit 7, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[126] = new OpcodeTableEntry(bit_7__iy_d_, "bit 7, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableDDCB.entries[127] = new OpcodeTableEntry(bit_7__ix_d_, "bit 7, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[127] = new OpcodeTableEntry(bit_7__iy_d_, "bit 7, (iy+{0})", new ArgType[]{ArgType.Offset});

            // SET / RES
            
            opcodeTableCB.entries[192] = new OpcodeTableEntry(set_0_b, "set 0, b", new ArgType[]{});
            opcodeTableCB.entries[193] = new OpcodeTableEntry(set_0_c, "set 0, c", new ArgType[]{});
            opcodeTableCB.entries[194] = new OpcodeTableEntry(set_0_d, "set 0, d", new ArgType[]{});
            opcodeTableCB.entries[195] = new OpcodeTableEntry(set_0_e, "set 0, e", new ArgType[]{});
            opcodeTableCB.entries[196] = new OpcodeTableEntry(set_0_h, "set 0, h", new ArgType[]{});
            opcodeTableCB.entries[197] = new OpcodeTableEntry(set_0_l, "set 0, l", new ArgType[]{});
            opcodeTableCB.entries[199] = new OpcodeTableEntry(set_0_a, "set 0, a", new ArgType[]{});
            opcodeTableCB.entries[198] = new OpcodeTableEntry(set_0__hl_, "set 0, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[198] = new OpcodeTableEntry(set_0__ix_d_, "set 0, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[198] = new OpcodeTableEntry(set_0__iy_d_, "set 0, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[200] = new OpcodeTableEntry(set_1_b, "set 1, b", new ArgType[]{});
            opcodeTableCB.entries[201] = new OpcodeTableEntry(set_1_c, "set 1, c", new ArgType[]{});
            opcodeTableCB.entries[202] = new OpcodeTableEntry(set_1_d, "set 1, d", new ArgType[]{});
            opcodeTableCB.entries[203] = new OpcodeTableEntry(set_1_e, "set 1, e", new ArgType[]{});
            opcodeTableCB.entries[204] = new OpcodeTableEntry(set_1_h, "set 1, h", new ArgType[]{});
            opcodeTableCB.entries[205] = new OpcodeTableEntry(set_1_l, "set 1, l", new ArgType[]{});
            opcodeTableCB.entries[207] = new OpcodeTableEntry(set_1_a, "set 1, a", new ArgType[]{});
            opcodeTableCB.entries[206] = new OpcodeTableEntry(set_1__hl_, "set 1, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[206] = new OpcodeTableEntry(set_1__ix_d_, "set 1, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[206] = new OpcodeTableEntry(set_1__iy_d_, "set 1, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[208] = new OpcodeTableEntry(set_2_b, "set 2, b", new ArgType[]{});
            opcodeTableCB.entries[209] = new OpcodeTableEntry(set_2_c, "set 2, c", new ArgType[]{});
            opcodeTableCB.entries[210] = new OpcodeTableEntry(set_2_d, "set 2, d", new ArgType[]{});
            opcodeTableCB.entries[211] = new OpcodeTableEntry(set_2_e, "set 2, e", new ArgType[]{});
            opcodeTableCB.entries[212] = new OpcodeTableEntry(set_2_h, "set 2, h", new ArgType[]{});
            opcodeTableCB.entries[213] = new OpcodeTableEntry(set_2_l, "set 2, l", new ArgType[]{});
            opcodeTableCB.entries[215] = new OpcodeTableEntry(set_2_a, "set 2, a", new ArgType[]{});
            opcodeTableCB.entries[214] = new OpcodeTableEntry(set_2__hl_, "set 2, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[214] = new OpcodeTableEntry(set_2__ix_d_, "set 2, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[214] = new OpcodeTableEntry(set_2__iy_d_, "set 2, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[216] = new OpcodeTableEntry(set_3_b, "set 3, b", new ArgType[]{});
            opcodeTableCB.entries[217] = new OpcodeTableEntry(set_3_c, "set 3, c", new ArgType[]{});
            opcodeTableCB.entries[218] = new OpcodeTableEntry(set_3_d, "set 3, d", new ArgType[]{});
            opcodeTableCB.entries[219] = new OpcodeTableEntry(set_3_e, "set 3, e", new ArgType[]{});
            opcodeTableCB.entries[220] = new OpcodeTableEntry(set_3_h, "set 3, h", new ArgType[]{});
            opcodeTableCB.entries[221] = new OpcodeTableEntry(set_3_l, "set 3, l", new ArgType[]{});
            opcodeTableCB.entries[223] = new OpcodeTableEntry(set_3_a, "set 3, a", new ArgType[]{});
            opcodeTableCB.entries[222] = new OpcodeTableEntry(set_3__hl_, "set 3, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[222] = new OpcodeTableEntry(set_3__ix_d_, "set 3, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[222] = new OpcodeTableEntry(set_3__iy_d_, "set 3, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[224] = new OpcodeTableEntry(set_4_b, "set 4, b", new ArgType[]{});
            opcodeTableCB.entries[225] = new OpcodeTableEntry(set_4_c, "set 4, c", new ArgType[]{});
            opcodeTableCB.entries[226] = new OpcodeTableEntry(set_4_d, "set 4, d", new ArgType[]{});
            opcodeTableCB.entries[227] = new OpcodeTableEntry(set_4_e, "set 4, e", new ArgType[]{});
            opcodeTableCB.entries[228] = new OpcodeTableEntry(set_4_h, "set 4, h", new ArgType[]{});
            opcodeTableCB.entries[229] = new OpcodeTableEntry(set_4_l, "set 4, l", new ArgType[]{});
            opcodeTableCB.entries[231] = new OpcodeTableEntry(set_4_a, "set 4, a", new ArgType[]{});
            opcodeTableCB.entries[230] = new OpcodeTableEntry(set_4__hl_, "set 4, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[230] = new OpcodeTableEntry(set_4__ix_d_, "set 4, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[230] = new OpcodeTableEntry(set_4__iy_d_, "set 4, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[232] = new OpcodeTableEntry(set_5_b, "set 5, b", new ArgType[]{});
            opcodeTableCB.entries[233] = new OpcodeTableEntry(set_5_c, "set 5, c", new ArgType[]{});
            opcodeTableCB.entries[234] = new OpcodeTableEntry(set_5_d, "set 5, d", new ArgType[]{});
            opcodeTableCB.entries[235] = new OpcodeTableEntry(set_5_e, "set 5, e", new ArgType[]{});
            opcodeTableCB.entries[236] = new OpcodeTableEntry(set_5_h, "set 5, h", new ArgType[]{});
            opcodeTableCB.entries[237] = new OpcodeTableEntry(set_5_l, "set 5, l", new ArgType[]{});
            opcodeTableCB.entries[239] = new OpcodeTableEntry(set_5_a, "set 5, a", new ArgType[]{});
            opcodeTableCB.entries[238] = new OpcodeTableEntry(set_5__hl_, "set 5, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[238] = new OpcodeTableEntry(set_5__ix_d_, "set 5, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[238] = new OpcodeTableEntry(set_5__iy_d_, "set 5, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[240] = new OpcodeTableEntry(set_6_b, "set 6, b", new ArgType[]{});
            opcodeTableCB.entries[241] = new OpcodeTableEntry(set_6_c, "set 6, c", new ArgType[]{});
            opcodeTableCB.entries[242] = new OpcodeTableEntry(set_6_d, "set 6, d", new ArgType[]{});
            opcodeTableCB.entries[243] = new OpcodeTableEntry(set_6_e, "set 6, e", new ArgType[]{});
            opcodeTableCB.entries[244] = new OpcodeTableEntry(set_6_h, "set 6, h", new ArgType[]{});
            opcodeTableCB.entries[245] = new OpcodeTableEntry(set_6_l, "set 6, l", new ArgType[]{});
            opcodeTableCB.entries[247] = new OpcodeTableEntry(set_6_a, "set 6, a", new ArgType[]{});
            opcodeTableCB.entries[246] = new OpcodeTableEntry(set_6__hl_, "set 6, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[246] = new OpcodeTableEntry(set_6__ix_d_, "set 6, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[246] = new OpcodeTableEntry(set_6__iy_d_, "set 6, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[248] = new OpcodeTableEntry(set_7_b, "set 7, b", new ArgType[]{});
            opcodeTableCB.entries[249] = new OpcodeTableEntry(set_7_c, "set 7, c", new ArgType[]{});
            opcodeTableCB.entries[250] = new OpcodeTableEntry(set_7_d, "set 7, d", new ArgType[]{});
            opcodeTableCB.entries[251] = new OpcodeTableEntry(set_7_e, "set 7, e", new ArgType[]{});
            opcodeTableCB.entries[252] = new OpcodeTableEntry(set_7_h, "set 7, h", new ArgType[]{});
            opcodeTableCB.entries[253] = new OpcodeTableEntry(set_7_l, "set 7, l", new ArgType[]{});
            opcodeTableCB.entries[255] = new OpcodeTableEntry(set_7_a, "set 7, a", new ArgType[]{});
            opcodeTableCB.entries[254] = new OpcodeTableEntry(set_7__hl_, "set 7, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[254] = new OpcodeTableEntry(set_7__ix_d_, "set 7, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[254] = new OpcodeTableEntry(set_7__iy_d_, "set 7, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[128] = new OpcodeTableEntry(res_0_b, "res 0, b", new ArgType[]{});
            opcodeTableCB.entries[129] = new OpcodeTableEntry(res_0_c, "res 0, c", new ArgType[]{});
            opcodeTableCB.entries[130] = new OpcodeTableEntry(res_0_d, "res 0, d", new ArgType[]{});
            opcodeTableCB.entries[131] = new OpcodeTableEntry(res_0_e, "res 0, e", new ArgType[]{});
            opcodeTableCB.entries[132] = new OpcodeTableEntry(res_0_h, "res 0, h", new ArgType[]{});
            opcodeTableCB.entries[133] = new OpcodeTableEntry(res_0_l, "res 0, l", new ArgType[]{});
            opcodeTableCB.entries[135] = new OpcodeTableEntry(res_0_a, "res 0, a", new ArgType[]{});
            opcodeTableCB.entries[134] = new OpcodeTableEntry(res_0__hl_, "res 0, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[134] = new OpcodeTableEntry(res_0__ix_d_, "res 0, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[134] = new OpcodeTableEntry(res_0__iy_d_, "res 0, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[136] = new OpcodeTableEntry(res_1_b, "res 1, b", new ArgType[]{});
            opcodeTableCB.entries[137] = new OpcodeTableEntry(res_1_c, "res 1, c", new ArgType[]{});
            opcodeTableCB.entries[138] = new OpcodeTableEntry(res_1_d, "res 1, d", new ArgType[]{});
            opcodeTableCB.entries[139] = new OpcodeTableEntry(res_1_e, "res 1, e", new ArgType[]{});
            opcodeTableCB.entries[140] = new OpcodeTableEntry(res_1_h, "res 1, h", new ArgType[]{});
            opcodeTableCB.entries[141] = new OpcodeTableEntry(res_1_l, "res 1, l", new ArgType[]{});
            opcodeTableCB.entries[143] = new OpcodeTableEntry(res_1_a, "res 1, a", new ArgType[]{});
            opcodeTableCB.entries[142] = new OpcodeTableEntry(res_1__hl_, "res 1, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[142] = new OpcodeTableEntry(res_1__ix_d_, "res 1, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[142] = new OpcodeTableEntry(res_1__iy_d_, "res 1, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[144] = new OpcodeTableEntry(res_2_b, "res 2, b", new ArgType[]{});
            opcodeTableCB.entries[145] = new OpcodeTableEntry(res_2_c, "res 2, c", new ArgType[]{});
            opcodeTableCB.entries[146] = new OpcodeTableEntry(res_2_d, "res 2, d", new ArgType[]{});
            opcodeTableCB.entries[147] = new OpcodeTableEntry(res_2_e, "res 2, e", new ArgType[]{});
            opcodeTableCB.entries[148] = new OpcodeTableEntry(res_2_h, "res 2, h", new ArgType[]{});
            opcodeTableCB.entries[149] = new OpcodeTableEntry(res_2_l, "res 2, l", new ArgType[]{});
            opcodeTableCB.entries[151] = new OpcodeTableEntry(res_2_a, "res 2, a", new ArgType[]{});
            opcodeTableCB.entries[150] = new OpcodeTableEntry(res_2__hl_, "res 2, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[150] = new OpcodeTableEntry(res_2__ix_d_, "res 2, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[150] = new OpcodeTableEntry(res_2__iy_d_, "res 2, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[152] = new OpcodeTableEntry(res_3_b, "res 3, b", new ArgType[]{});
            opcodeTableCB.entries[153] = new OpcodeTableEntry(res_3_c, "res 3, c", new ArgType[]{});
            opcodeTableCB.entries[154] = new OpcodeTableEntry(res_3_d, "res 3, d", new ArgType[]{});
            opcodeTableCB.entries[155] = new OpcodeTableEntry(res_3_e, "res 3, e", new ArgType[]{});
            opcodeTableCB.entries[156] = new OpcodeTableEntry(res_3_h, "res 3, h", new ArgType[]{});
            opcodeTableCB.entries[157] = new OpcodeTableEntry(res_3_l, "res 3, l", new ArgType[]{});
            opcodeTableCB.entries[159] = new OpcodeTableEntry(res_3_a, "res 3, a", new ArgType[]{});
            opcodeTableCB.entries[158] = new OpcodeTableEntry(res_3__hl_, "res 3, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[158] = new OpcodeTableEntry(res_3__ix_d_, "res 3, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[158] = new OpcodeTableEntry(res_3__iy_d_, "res 3, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[160] = new OpcodeTableEntry(res_4_b, "res 4, b", new ArgType[]{});
            opcodeTableCB.entries[161] = new OpcodeTableEntry(res_4_c, "res 4, c", new ArgType[]{});
            opcodeTableCB.entries[162] = new OpcodeTableEntry(res_4_d, "res 4, d", new ArgType[]{});
            opcodeTableCB.entries[163] = new OpcodeTableEntry(res_4_e, "res 4, e", new ArgType[]{});
            opcodeTableCB.entries[164] = new OpcodeTableEntry(res_4_h, "res 4, h", new ArgType[]{});
            opcodeTableCB.entries[165] = new OpcodeTableEntry(res_4_l, "res 4, l", new ArgType[]{});
            opcodeTableCB.entries[167] = new OpcodeTableEntry(res_4_a, "res 4, a", new ArgType[]{});
            opcodeTableCB.entries[166] = new OpcodeTableEntry(res_4__hl_, "res 4, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[166] = new OpcodeTableEntry(res_4__ix_d_, "res 4, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[166] = new OpcodeTableEntry(res_4__iy_d_, "res 4, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[168] = new OpcodeTableEntry(res_5_b, "res 5, b", new ArgType[]{});
            opcodeTableCB.entries[169] = new OpcodeTableEntry(res_5_c, "res 5, c", new ArgType[]{});
            opcodeTableCB.entries[170] = new OpcodeTableEntry(res_5_d, "res 5, d", new ArgType[]{});
            opcodeTableCB.entries[171] = new OpcodeTableEntry(res_5_e, "res 5, e", new ArgType[]{});
            opcodeTableCB.entries[172] = new OpcodeTableEntry(res_5_h, "res 5, h", new ArgType[]{});
            opcodeTableCB.entries[173] = new OpcodeTableEntry(res_5_l, "res 5, l", new ArgType[]{});
            opcodeTableCB.entries[175] = new OpcodeTableEntry(res_5_a, "res 5, a", new ArgType[]{});
            opcodeTableCB.entries[174] = new OpcodeTableEntry(res_5__hl_, "res 5, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[174] = new OpcodeTableEntry(res_5__ix_d_, "res 5, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[174] = new OpcodeTableEntry(res_5__iy_d_, "res 5, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[176] = new OpcodeTableEntry(res_6_b, "res 6, b", new ArgType[]{});
            opcodeTableCB.entries[177] = new OpcodeTableEntry(res_6_c, "res 6, c", new ArgType[]{});
            opcodeTableCB.entries[178] = new OpcodeTableEntry(res_6_d, "res 6, d", new ArgType[]{});
            opcodeTableCB.entries[179] = new OpcodeTableEntry(res_6_e, "res 6, e", new ArgType[]{});
            opcodeTableCB.entries[180] = new OpcodeTableEntry(res_6_h, "res 6, h", new ArgType[]{});
            opcodeTableCB.entries[181] = new OpcodeTableEntry(res_6_l, "res 6, l", new ArgType[]{});
            opcodeTableCB.entries[183] = new OpcodeTableEntry(res_6_a, "res 6, a", new ArgType[]{});
            opcodeTableCB.entries[182] = new OpcodeTableEntry(res_6__hl_, "res 6, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[182] = new OpcodeTableEntry(res_6__ix_d_, "res 6, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[182] = new OpcodeTableEntry(res_6__iy_d_, "res 6, (iy+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableCB.entries[184] = new OpcodeTableEntry(res_7_b, "res 7, b", new ArgType[]{});
            opcodeTableCB.entries[185] = new OpcodeTableEntry(res_7_c, "res 7, c", new ArgType[]{});
            opcodeTableCB.entries[186] = new OpcodeTableEntry(res_7_d, "res 7, d", new ArgType[]{});
            opcodeTableCB.entries[187] = new OpcodeTableEntry(res_7_e, "res 7, e", new ArgType[]{});
            opcodeTableCB.entries[188] = new OpcodeTableEntry(res_7_h, "res 7, h", new ArgType[]{});
            opcodeTableCB.entries[189] = new OpcodeTableEntry(res_7_l, "res 7, l", new ArgType[]{});
            opcodeTableCB.entries[191] = new OpcodeTableEntry(res_7_a, "res 7, a", new ArgType[]{});
            opcodeTableCB.entries[190] = new OpcodeTableEntry(res_7__hl_, "res 7, (hl)", new ArgType[]{});
            opcodeTableDDCB.entries[190] = new OpcodeTableEntry(res_7__ix_d_, "res 7, (ix+{0})", new ArgType[]{ArgType.Offset});
            opcodeTableFDCB.entries[190] = new OpcodeTableEntry(res_7__iy_d_, "res 7, (iy+{0})", new ArgType[]{ArgType.Offset});
                           
        }
        
        protected void nop() {
            // NOP
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

        protected void ld__hl__n() {
            Write8(r1.hl, Read8(pc++));
        }
        
        protected void ld_a__bc_() {
            r1.a = Read8(r1.bc);
        }
        
        protected void ld__bc__a() {
            Write8(r1.bc, r1.a);
        }
        protected void ld_a__de_() {
            r1.a = Read8(r1.de);
        }
        
        protected void ld__de__a() {
            Write8(r1.de, r1.a);
        }

        protected void ld_a__nn_() {
            r1.a = Read8(Read16(pc));
            pc += 2;
        }        
        
        protected void ld__nn__a() {
            Write8(Read16(pc), r1.a);
            pc += 2;
        }
        
        protected void ld_a_i() {
            tStates++;
            r1.a = i;
            AdjustFlags(r1.a);
            ResFlag(f_h | f_n);
            ValFlag(f_pv, iff2);
            ValFlag(f_s, (r1.a & 0x80) != 0);
            ValFlag(f_z, r1.a == 0);
        }
        
        protected void ld_i_a() {
            tStates++;
            i = r1.a;
        }
        protected void ld_a_r() {
            tStates++;
            r1.a = r;
            AdjustFlags(r1.a);
            ResFlag(f_h | f_n);
            ValFlag(f_pv, iff2);
            ValFlag(f_s, (r1.a & 0x80) != 0);
            ValFlag(f_z, r1.a == 0);
        }
        
        protected void ld_r_a() {
            tStates++;
            r = r1.a;
        }
        protected void ld_a__ix_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.a = Read8((ushort)(r1.ix + offset));
        }
        
        protected void ld__ix_d__a() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.ix + offset), r1.a);
        }
        
        protected void ld_a__iy_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.a = Read8((ushort)(r1.iy + offset));
        }
        
        protected void ld__iy_d__a() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.iy + offset), r1.a);
        }
        
        protected void ld_b__ix_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.b = Read8((ushort)(r1.ix + offset));
        }
        
        protected void ld__ix_d__b() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.ix + offset), r1.b);
        }
        
        protected void ld_b__iy_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.b = Read8((ushort)(r1.iy + offset));
        }
        
        protected void ld__iy_d__b() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.iy + offset), r1.b);
        }
        
        protected void ld_c__ix_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.c = Read8((ushort)(r1.ix + offset));
        }
        
        protected void ld__ix_d__c() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.ix + offset), r1.c);
        }
        
        protected void ld_c__iy_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.c = Read8((ushort)(r1.iy + offset));
        }
        
        protected void ld__iy_d__c() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.iy + offset), r1.c);
        }
        
        protected void ld_d__ix_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.d = Read8((ushort)(r1.ix + offset));
        }
        
        protected void ld__ix_d__d() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.ix + offset), r1.d);
        }
        
        protected void ld_d__iy_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.d = Read8((ushort)(r1.iy + offset));
        }
        
        protected void ld__iy_d__d() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.iy + offset), r1.d);
        }
        
        protected void ld_e__ix_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.e = Read8((ushort)(r1.ix + offset));
        }
        
        protected void ld__ix_d__e() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.ix + offset), r1.e);
        }
        
        protected void ld_e__iy_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.e = Read8((ushort)(r1.iy + offset));
        }
        
        protected void ld__iy_d__e() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.iy + offset), r1.e);
        }
        
        protected void ld_h__ix_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.h = Read8((ushort)(r1.ix + offset));
        }
        
        protected void ld__ix_d__h() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.ix + offset), r1.h);
        }
        
        protected void ld_h__iy_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.h = Read8((ushort)(r1.iy + offset));
        }
        
        protected void ld__iy_d__h() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.iy + offset), r1.h);
        }
        
        protected void ld_l__ix_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.l = Read8((ushort)(r1.ix + offset));
        }
        
        protected void ld__ix_d__l() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.ix + offset), r1.l);
        }
        
        protected void ld_l__iy_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            r1.l = Read8((ushort)(r1.iy + offset));
        }
        
        protected void ld__iy_d__l() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            Write8((ushort)(r1.iy + offset), r1.l);
        }
        
        protected void ld__ix_d__n() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var n = Read8(pc++);
            Write8((ushort)(r1.ix + offset), n);
        }
        
        protected void ld__iy_d__n() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var n = Read8(pc++);
            Write8((ushort)(r1.iy + offset), n);
        }
        
        protected void ld_bc_nn() {
            r1.bc = Read16(pc);
            pc += 2;
        }
        
        protected void ld_bc__nn_() {
            r1.bc = Read16(Read16(pc));
            pc += 2;
        }
        
        protected void ld__nn__bc() {
            var addr = Read16(pc);
            pc += 2;
            Write16(addr, r1.bc);
        }
        
        protected void ld_de_nn() {
            r1.de = Read16(pc);
            pc += 2;
        }
        
        protected void ld_de__nn_() {
            r1.de = Read16(Read16(pc));
            pc += 2;
        }
        
        protected void ld__nn__de() {
            var addr = Read16(pc);
            pc += 2;
            Write16(addr, r1.de);
        }
        
        protected void ld_hl_nn() {
            r1.hl = Read16(pc);
            pc += 2;
        }
        
        protected void ld_hl__nn_() {
            r1.hl = Read16(Read16(pc));
            pc += 2;
        }
        
        protected void ld__nn__hl() {
            var addr = Read16(pc);
            pc += 2;
            Write16(addr, r1.hl);
        }
        
        protected void ld_sp_nn() {
            r1.sp = Read16(pc);
            pc += 2;
        }
        
        protected void ld_sp__nn_() {
            r1.sp = Read16(Read16(pc));
            pc += 2;
        }
        
        protected void ld__nn__sp() {
            var addr = Read16(pc);
            pc += 2;
            Write16(addr, r1.sp);
        }
        
        protected void ld_ix_nn() {
            r1.ix = Read16(pc);
            pc += 2;
        }
        
        protected void ld_ix__nn_() {
            r1.ix = Read16(Read16(pc));
            pc += 2;
        }
        
        protected void ld__nn__ix() {
            var addr = Read16(pc);
            pc += 2;
            Write16(addr, r1.ix);
        }
        
        protected void ld_iy_nn() {
            r1.iy = Read16(pc);
            pc += 2;
        }
        
        protected void ld_iy__nn_() {
            r1.iy = Read16(Read16(pc));
            pc += 2;
        }
        
        protected void ld__nn__iy() {
            var addr = Read16(pc);
            pc += 2;
            Write16(addr, r1.iy);
        }
        
        protected void ld_sp_hl() {
            tStates += 2;
            r1.sp = r1.hl;
        }
        
        protected void ex__sp__hl() {
            tStates += 3;
            var _t = r1.hl;
            r1.hl = Read16(r1.sp);
            Write16(r1.sp, _t);
        }
        
        protected void ld_sp_ix() {
            tStates += 2;
            r1.sp = r1.ix;
        }
        
        protected void ex__sp__ix() {
            tStates += 3;
            var _t = r1.ix;
            r1.ix = Read16(r1.sp);
            Write16(r1.sp, _t);
        }
        
        protected void ld_sp_iy() {
            tStates += 2;
            r1.sp = r1.iy;
        }
        
        protected void ex__sp__iy() {
            tStates += 3;
            var _t = r1.iy;
            r1.iy = Read16(r1.sp);
            Write16(r1.sp, _t);
        }
        
        protected void push_af() {
            tStates++;
            DoPush(r1.af);
        }
        
        protected void pop_af() {
            r1.af = DoPop();
        }
        protected void push_bc() {
            tStates++;
            DoPush(r1.bc);
        }
        
        protected void pop_bc() {
            r1.bc = DoPop();
        }
        protected void push_de() {
            tStates++;
            DoPush(r1.de);
        }
        
        protected void pop_de() {
            r1.de = DoPop();
        }
        protected void push_hl() {
            tStates++;
            DoPush(r1.hl);
        }
        
        protected void pop_hl() {
            r1.hl = DoPop();
        }
        protected void push_ix() {
            tStates++;
            DoPush(r1.ix);
        }
        
        protected void pop_ix() {
            r1.ix = DoPop();
        }
        protected void push_iy() {
            tStates++;
            DoPush(r1.iy);
        }
        
        protected void pop_iy() {
            r1.iy = DoPop();
        }
        protected void ex_de_hl() {
            var _t = r1.de;
            r1.de = r1.hl;
            r1.hl = _t;
        }
        
        protected void ex_af_af_() {
            var _t = r1.af;
            r1.af = r2.af;
            r2.af = _t;
        }
        
        protected void exx() {
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
        
        protected void ldi() {
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
        
        protected void ldir() {
            ldi();
            if (r1.bc != 0) {
                tStates += 5;
                pc -= 2;
            }
        }

        protected void ldd() {
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
        
        protected void lddr() {
            ldd();
            if (r1.bc != 0) {
                tStates += 5;
                pc -= 2;
            }
        }
        
        protected void cpi() {
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
        
        protected void cpir() {
            cpi();
            if (r1.bc != 0 && !GetFlag(f_z)) {
                tStates += 5;
                pc -= 2;
            }
        }
        
        protected void cpd() {
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
        
        protected void cpdr() {
            cpd();
            if (r1.bc != 0 && !GetFlag(f_z)) {
                tStates += 5;
                pc -= 2;
            }
        }
        
        protected void adc_a_a() {
            r1.a = DoArithmetics(r1.a, hasCarry_adc, isSub_adc);
        }
        
        protected void adc_a_b() {
            r1.a = DoArithmetics(r1.b, hasCarry_adc, isSub_adc);
        }
        
        protected void adc_a_c() {
            r1.a = DoArithmetics(r1.c, hasCarry_adc, isSub_adc);
        }
        
        protected void adc_a_d() {
            r1.a = DoArithmetics(r1.d, hasCarry_adc, isSub_adc);
        }
        
        protected void adc_a_e() {
            r1.a = DoArithmetics(r1.e, hasCarry_adc, isSub_adc);
        }
        
        protected void adc_a_h() {
            r1.a = DoArithmetics(r1.h, hasCarry_adc, isSub_adc);
        }
        
        protected void adc_a_l() {
            r1.a = DoArithmetics(r1.l, hasCarry_adc, isSub_adc);
        }
        
        protected void adc_a_ixh() {
            r1.a = DoArithmetics(r1.ixh, hasCarry_adc, isSub_adc);
        }
        
        protected void adc_a_ixl() {
            r1.a = DoArithmetics(r1.ixl, hasCarry_adc, isSub_adc);
        }
        
        protected void adc_a_iyh() {
            r1.a = DoArithmetics(r1.iyh, hasCarry_adc, isSub_adc);
        }
        
        protected void adc_a_iyl() {
            r1.a = DoArithmetics(r1.iyl, hasCarry_adc, isSub_adc);
        }
        
        protected void adc_a_n() {
            r1.a = DoArithmetics(Read8(pc++), hasCarry_adc, isSub_adc);
        }

		protected void adc_a__hl_() {
			r1.a = DoArithmetics(Read8(r1.hl), hasCarry_adc, isSub_adc);
		}
		protected void adc_a__ix_d_() {
			tStates += 5;
			var offset = (SByte)Read8(pc++);
			r1.a = DoArithmetics(Read8((ushort)(r1.ix + offset)), hasCarry_adc, isSub_adc);
		}
		protected void adc_a__iy_d_() {
			tStates += 5;
			var offset = (SByte)Read8(pc++);
			r1.a = DoArithmetics(Read8((ushort)(r1.ix + offset)), hasCarry_adc, isSub_adc);
		}
        protected void sbc_a_a() {
            r1.a = DoArithmetics(r1.a, hasCarry_sbc, isSub_sbc);
        }
        
        protected void sbc_a_b() {
            r1.a = DoArithmetics(r1.b, hasCarry_sbc, isSub_sbc);
        }
        
        protected void sbc_a_c() {
            r1.a = DoArithmetics(r1.c, hasCarry_sbc, isSub_sbc);
        }
        
        protected void sbc_a_d() {
            r1.a = DoArithmetics(r1.d, hasCarry_sbc, isSub_sbc);
        }
        
        protected void sbc_a_e() {
            r1.a = DoArithmetics(r1.e, hasCarry_sbc, isSub_sbc);
        }
        
        protected void sbc_a_h() {
            r1.a = DoArithmetics(r1.h, hasCarry_sbc, isSub_sbc);
        }
        
        protected void sbc_a_l() {
            r1.a = DoArithmetics(r1.l, hasCarry_sbc, isSub_sbc);
        }
        
        protected void sbc_a_ixh() {
            r1.a = DoArithmetics(r1.ixh, hasCarry_sbc, isSub_sbc);
        }
        
        protected void sbc_a_ixl() {
            r1.a = DoArithmetics(r1.ixl, hasCarry_sbc, isSub_sbc);
        }
        
        protected void sbc_a_iyh() {
            r1.a = DoArithmetics(r1.iyh, hasCarry_sbc, isSub_sbc);
        }
        
        protected void sbc_a_iyl() {
            r1.a = DoArithmetics(r1.iyl, hasCarry_sbc, isSub_sbc);
        }
        
        protected void sbc_a_n() {
            r1.a = DoArithmetics(Read8(pc++), hasCarry_sbc, isSub_sbc);
        }

		protected void sbc_a__hl_() {
			r1.a = DoArithmetics(Read8(r1.hl), hasCarry_sbc, isSub_sbc);
		}
		protected void sbc_a__ix_d_() {
			tStates += 5;
			var offset = (SByte)Read8(pc++);
			r1.a = DoArithmetics(Read8((ushort)(r1.ix + offset)), hasCarry_sbc, isSub_sbc);
		}
		protected void sbc_a__iy_d_() {
			tStates += 5;
			var offset = (SByte)Read8(pc++);
			r1.a = DoArithmetics(Read8((ushort)(r1.ix + offset)), hasCarry_sbc, isSub_sbc);
		}
        protected void add_a_a() {
            r1.a = DoArithmetics(r1.a, hasCarry_add, isSub_add);
        }
        
        protected void add_a_b() {
            r1.a = DoArithmetics(r1.b, hasCarry_add, isSub_add);
        }
        
        protected void add_a_c() {
            r1.a = DoArithmetics(r1.c, hasCarry_add, isSub_add);
        }
        
        protected void add_a_d() {
            r1.a = DoArithmetics(r1.d, hasCarry_add, isSub_add);
        }
        
        protected void add_a_e() {
            r1.a = DoArithmetics(r1.e, hasCarry_add, isSub_add);
        }
        
        protected void add_a_h() {
            r1.a = DoArithmetics(r1.h, hasCarry_add, isSub_add);
        }
        
        protected void add_a_l() {
            r1.a = DoArithmetics(r1.l, hasCarry_add, isSub_add);
        }
        
        protected void add_a_ixh() {
            r1.a = DoArithmetics(r1.ixh, hasCarry_add, isSub_add);
        }
        
        protected void add_a_ixl() {
            r1.a = DoArithmetics(r1.ixl, hasCarry_add, isSub_add);
        }
        
        protected void add_a_iyh() {
            r1.a = DoArithmetics(r1.iyh, hasCarry_add, isSub_add);
        }
        
        protected void add_a_iyl() {
            r1.a = DoArithmetics(r1.iyl, hasCarry_add, isSub_add);
        }
        
        protected void add_a_n() {
            r1.a = DoArithmetics(Read8(pc++), hasCarry_add, isSub_add);
        }

		protected void add_a__hl_() {
			r1.a = DoArithmetics(Read8(r1.hl), hasCarry_add, isSub_add);
		}
		protected void add_a__ix_d_() {
			tStates += 5;
			var offset = (SByte)Read8(pc++);
			r1.a = DoArithmetics(Read8((ushort)(r1.ix + offset)), hasCarry_add, isSub_add);
		}
		protected void add_a__iy_d_() {
			tStates += 5;
			var offset = (SByte)Read8(pc++);
			r1.a = DoArithmetics(Read8((ushort)(r1.ix + offset)), hasCarry_add, isSub_add);
		}
        protected void sub_a_a() {
            r1.a = DoArithmetics(r1.a, hasCarry_sub, isSub_sub);
        }
        
        protected void sub_a_b() {
            r1.a = DoArithmetics(r1.b, hasCarry_sub, isSub_sub);
        }
        
        protected void sub_a_c() {
            r1.a = DoArithmetics(r1.c, hasCarry_sub, isSub_sub);
        }
        
        protected void sub_a_d() {
            r1.a = DoArithmetics(r1.d, hasCarry_sub, isSub_sub);
        }
        
        protected void sub_a_e() {
            r1.a = DoArithmetics(r1.e, hasCarry_sub, isSub_sub);
        }
        
        protected void sub_a_h() {
            r1.a = DoArithmetics(r1.h, hasCarry_sub, isSub_sub);
        }
        
        protected void sub_a_l() {
            r1.a = DoArithmetics(r1.l, hasCarry_sub, isSub_sub);
        }
        
        protected void sub_a_ixh() {
            r1.a = DoArithmetics(r1.ixh, hasCarry_sub, isSub_sub);
        }
        
        protected void sub_a_ixl() {
            r1.a = DoArithmetics(r1.ixl, hasCarry_sub, isSub_sub);
        }
        
        protected void sub_a_iyh() {
            r1.a = DoArithmetics(r1.iyh, hasCarry_sub, isSub_sub);
        }
        
        protected void sub_a_iyl() {
            r1.a = DoArithmetics(r1.iyl, hasCarry_sub, isSub_sub);
        }
        
        protected void sub_a_n() {
            r1.a = DoArithmetics(Read8(pc++), hasCarry_sub, isSub_sub);
        }

		protected void sub_a__hl_() {
			r1.a = DoArithmetics(Read8(r1.hl), hasCarry_sub, isSub_sub);
		}
		protected void sub_a__ix_d_() {
			tStates += 5;
			var offset = (SByte)Read8(pc++);
			r1.a = DoArithmetics(Read8((ushort)(r1.ix + offset)), hasCarry_sub, isSub_sub);
		}
		protected void sub_a__iy_d_() {
			tStates += 5;
			var offset = (SByte)Read8(pc++);
			r1.a = DoArithmetics(Read8((ushort)(r1.ix + offset)), hasCarry_sub, isSub_sub);
		}
		protected void add_hl_hl() {
			tStates += 7;
			r1.hl = DoAddWord(r1.hl, r1.hl,  hasCarry_add, isSub_add);
		}

		protected void add_hl_bc() {
			tStates += 7;
			r1.hl = DoAddWord(r1.hl, r1.bc,  hasCarry_add, isSub_add);
		}

		protected void add_hl_de() {
			tStates += 7;
			r1.hl = DoAddWord(r1.hl, r1.de,  hasCarry_add, isSub_add);
		}

		protected void add_hl_sp() {
			tStates += 7;
			r1.hl = DoAddWord(r1.hl, r1.sp,  hasCarry_add, isSub_add);
		}

		protected void adc_hl_hl() {
			tStates += 7;
			r1.hl = DoAddWord(r1.hl, r1.hl,  hasCarry_adc, isSub_adc);
		}

		protected void adc_hl_bc() {
			tStates += 7;
			r1.hl = DoAddWord(r1.hl, r1.bc,  hasCarry_adc, isSub_adc);
		}

		protected void adc_hl_de() {
			tStates += 7;
			r1.hl = DoAddWord(r1.hl, r1.de,  hasCarry_adc, isSub_adc);
		}

		protected void adc_hl_sp() {
			tStates += 7;
			r1.hl = DoAddWord(r1.hl, r1.sp,  hasCarry_adc, isSub_adc);
		}

		protected void sbc_hl_hl() {
			tStates += 7;
			r1.hl = DoAddWord(r1.hl, r1.hl,  hasCarry_sbc, isSub_sbc);
		}

		protected void sbc_hl_bc() {
			tStates += 7;
			r1.hl = DoAddWord(r1.hl, r1.bc,  hasCarry_sbc, isSub_sbc);
		}

		protected void sbc_hl_de() {
			tStates += 7;
			r1.hl = DoAddWord(r1.hl, r1.de,  hasCarry_sbc, isSub_sbc);
		}

		protected void sbc_hl_sp() {
			tStates += 7;
			r1.hl = DoAddWord(r1.hl, r1.sp,  hasCarry_sbc, isSub_sbc);
		}

		protected void add_ix_ix() {
			tStates += 7;
			r1.ix = DoAddWord(r1.ix, r1.ix,  false, false);
		}

		protected void add_ix_iy() {
			tStates += 7;
			r1.ix = DoAddWord(r1.ix, r1.iy,  false, false);
		}

		protected void add_ix_bc() {
			tStates += 7;
			r1.ix = DoAddWord(r1.ix, r1.bc,  false, false);
		}

		protected void add_ix_de() {
			tStates += 7;
			r1.ix = DoAddWord(r1.ix, r1.de,  false, false);
		}

		protected void add_ix_sp() {
			tStates += 7;
			r1.ix = DoAddWord(r1.ix, r1.sp,  false, false);
		}

		protected void add_iy_ix() {
			tStates += 7;
			r1.iy = DoAddWord(r1.iy, r1.ix,  false, false);
		}

		protected void add_iy_iy() {
			tStates += 7;
			r1.iy = DoAddWord(r1.iy, r1.iy,  false, false);
		}

		protected void add_iy_bc() {
			tStates += 7;
			r1.iy = DoAddWord(r1.iy, r1.bc,  false, false);
		}

		protected void add_iy_de() {
			tStates += 7;
			r1.iy = DoAddWord(r1.iy, r1.de,  false, false);
		}

		protected void add_iy_sp() {
			tStates += 7;
			r1.iy = DoAddWord(r1.iy, r1.sp,  false, false);
		}

		protected void and_a() {
			DoAND(r1.a);
		}
        
		protected void and_b() {
			DoAND(r1.b);
		}
        
		protected void and_c() {
			DoAND(r1.c);
		}
        
		protected void and_d() {
			DoAND(r1.d);
		}
        
		protected void and_e() {
			DoAND(r1.e);
		}
        
		protected void and_h() {
			DoAND(r1.h);
		}
        
		protected void and_l() {
			DoAND(r1.l);
		}
        
		protected void and_ixh() {
			DoAND(r1.ixh);
		}
        
		protected void and_ixl() {
			DoAND(r1.ixl);
		}
        
		protected void and_iyh() {
			DoAND(r1.iyh);
		}
        
		protected void and_iyl() {
			DoAND(r1.iyl);
		}
        
		protected void and_n() {
			DoAND(Read8(pc++));
		}

		protected void and__hl_() {
			DoAND(Read8(r1.hl));
		}
        
		protected void and__ix_d_() {
			tStates += 5;
			var offset = (SByte)Read8(pc++);
			DoAND(Read8((ushort)(r1.ix + offset)));
		}
        
		protected void and__iy_d_() {
			tStates += 5;
			var offset = (SByte)Read8(pc++);
			DoAND(Read8((ushort)(r1.iy + offset)));
		}
        
		protected void or_a() {
			DoOR(r1.a);
		}
        
		protected void or_b() {
			DoOR(r1.b);
		}
        
		protected void or_c() {
			DoOR(r1.c);
		}
        
		protected void or_d() {
			DoOR(r1.d);
		}
        
		protected void or_e() {
			DoOR(r1.e);
		}
        
		protected void or_h() {
			DoOR(r1.h);
		}
        
		protected void or_l() {
			DoOR(r1.l);
		}
        
		protected void or_ixh() {
			DoOR(r1.ixh);
		}
        
		protected void or_ixl() {
			DoOR(r1.ixl);
		}
        
		protected void or_iyh() {
			DoOR(r1.iyh);
		}
        
		protected void or_iyl() {
			DoOR(r1.iyl);
		}
        
		protected void or_n() {
			DoOR(Read8(pc++));
		}

		protected void or__hl_() {
			DoOR(Read8(r1.hl));
		}
        
		protected void or__ix_d_() {
			tStates += 5;
			var offset = (SByte)Read8(pc++);
			DoOR(Read8((ushort)(r1.ix + offset)));
		}
        
		protected void or__iy_d_() {
			tStates += 5;
			var offset = (SByte)Read8(pc++);
			DoOR(Read8((ushort)(r1.iy + offset)));
		}
        
		protected void xor_a() {
			DoXOR(r1.a);
		}
        
		protected void xor_b() {
			DoXOR(r1.b);
		}
        
		protected void xor_c() {
			DoXOR(r1.c);
		}
        
		protected void xor_d() {
			DoXOR(r1.d);
		}
        
		protected void xor_e() {
			DoXOR(r1.e);
		}
        
		protected void xor_h() {
			DoXOR(r1.h);
		}
        
		protected void xor_l() {
			DoXOR(r1.l);
		}
        
		protected void xor_ixh() {
			DoXOR(r1.ixh);
		}
        
		protected void xor_ixl() {
			DoXOR(r1.ixl);
		}
        
		protected void xor_iyh() {
			DoXOR(r1.iyh);
		}
        
		protected void xor_iyl() {
			DoXOR(r1.iyl);
		}
        
		protected void xor_n() {
			DoXOR(Read8(pc++));
		}

		protected void xor__hl_() {
			DoXOR(Read8(r1.hl));
		}
        
		protected void xor__ix_d_() {
			tStates += 5;
			var offset = (SByte)Read8(pc++);
			DoXOR(Read8((ushort)(r1.ix + offset)));
		}
        
		protected void xor__iy_d_() {
			tStates += 5;
			var offset = (SByte)Read8(pc++);
			DoXOR(Read8((ushort)(r1.iy + offset)));
		}
        
        protected void cp_a() {
            DoArithmetics(r1.a, false, true);
            AdjustFlags(r1.a);
        }
        
        protected void cp_b() {
            DoArithmetics(r1.b, false, true);
            AdjustFlags(r1.b);
        }
        
        protected void cp_c() {
            DoArithmetics(r1.c, false, true);
            AdjustFlags(r1.c);
        }
        
        protected void cp_d() {
            DoArithmetics(r1.d, false, true);
            AdjustFlags(r1.d);
        }
        
        protected void cp_e() {
            DoArithmetics(r1.e, false, true);
            AdjustFlags(r1.e);
        }
        
        protected void cp_h() {
            DoArithmetics(r1.h, false, true);
            AdjustFlags(r1.h);
        }
        
        protected void cp_l() {
            DoArithmetics(r1.l, false, true);
            AdjustFlags(r1.l);
        }
        
        protected void cp_ixh() {
            DoArithmetics(r1.ixh, false, true);
            AdjustFlags(r1.ixh);
        }
        
        protected void cp_ixl() {
            DoArithmetics(r1.ixl, false, true);
            AdjustFlags(r1.ixl);
        }
        
        protected void cp_iyh() {
            DoArithmetics(r1.iyh, false, true);
            AdjustFlags(r1.iyh);
        }
        
        protected void cp_iyl() {
            DoArithmetics(r1.iyl, false, true);
            AdjustFlags(r1.iyl);
        }
        
        protected void cp__hl_() {
            DoCPHL();
        }
        
        protected void cp_n() {
            var value = Read8(pc++);
            DoArithmetics(value, false, true);
            AdjustFlags(value);
        }
        
        protected void cp__ix_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            var value = Read8((ushort)(r1.ix + offset));
            DoArithmetics(value, false, true);
            AdjustFlags(value);
        }
        protected void cp__iy_d_() {
            tStates += 5;
            var offset = (SByte)Read8(pc++);
            var value = Read8((ushort)(r1.iy + offset));
            DoArithmetics(value, false, true);
            AdjustFlags(value);
        }

        protected void inc_a() {
            r1.a = DoIncDec(r1.a, isDec_inc);
        }
        
        protected void inc_b() {
            r1.b = DoIncDec(r1.b, isDec_inc);
        }
        
        protected void inc_c() {
            r1.c = DoIncDec(r1.c, isDec_inc);
        }
        
        protected void inc_d() {
            r1.d = DoIncDec(r1.d, isDec_inc);
        }
        
        protected void inc_e() {
            r1.e = DoIncDec(r1.e, isDec_inc);
        }
        
        protected void inc_h() {
            r1.h = DoIncDec(r1.h, isDec_inc);
        }
        
        protected void inc_l() {
            r1.l = DoIncDec(r1.l, isDec_inc);
        }
        
        protected void inc_ixh() {
            r1.ixh = DoIncDec(r1.ixh, isDec_inc);
        }
        
        protected void inc_ixl() {
            r1.ixl = DoIncDec(r1.ixl, isDec_inc);
        }
        
        protected void inc_iyh() {
            r1.iyh = DoIncDec(r1.iyh, isDec_inc);
        }
        
        protected void inc_iyl() {
            r1.iyl = DoIncDec(r1.iyl, isDec_inc);
        }
        
        protected void inc__hl_() {
            tStates++;
            var value = Read8(r1.hl);
            Write8(r1.hl, DoIncDec(value, isDec_inc));
        }
        protected void inc__ix_d_() {
            tStates += 6;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            var value = Read8(addr);
            Write8(addr, DoIncDec(value, isDec_inc));
        }
        
        protected void inc__iy_d_() {
            tStates += 6;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            var value = Read8(addr);
            Write8(addr, DoIncDec(value, isDec_inc));
        }
        
        protected void dec_a() {
            r1.a = DoIncDec(r1.a, isDec_dec);
        }
        
        protected void dec_b() {
            r1.b = DoIncDec(r1.b, isDec_dec);
        }
        
        protected void dec_c() {
            r1.c = DoIncDec(r1.c, isDec_dec);
        }
        
        protected void dec_d() {
            r1.d = DoIncDec(r1.d, isDec_dec);
        }
        
        protected void dec_e() {
            r1.e = DoIncDec(r1.e, isDec_dec);
        }
        
        protected void dec_h() {
            r1.h = DoIncDec(r1.h, isDec_dec);
        }
        
        protected void dec_l() {
            r1.l = DoIncDec(r1.l, isDec_dec);
        }
        
        protected void dec_ixh() {
            r1.ixh = DoIncDec(r1.ixh, isDec_dec);
        }
        
        protected void dec_ixl() {
            r1.ixl = DoIncDec(r1.ixl, isDec_dec);
        }
        
        protected void dec_iyh() {
            r1.iyh = DoIncDec(r1.iyh, isDec_dec);
        }
        
        protected void dec_iyl() {
            r1.iyl = DoIncDec(r1.iyl, isDec_dec);
        }
        
        protected void dec__hl_() {
            tStates++;
            var value = Read8(r1.hl);
            Write8(r1.hl, DoIncDec(value, isDec_dec));
        }
        protected void dec__ix_d_() {
            tStates += 6;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            var value = Read8(addr);
            Write8(addr, DoIncDec(value, isDec_dec));
        }
        
        protected void dec__iy_d_() {
            tStates += 6;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            var value = Read8(addr);
            Write8(addr, DoIncDec(value, isDec_dec));
        }
        
        protected void inc_hl() {
            tStates += 2;
            r1.hl++;
        }
        
        protected void dec_hl() {
            tStates += 2;
            r1.hl--;
        }
        
        protected void inc_sp() {
            tStates += 2;
            r1.sp++;
        }
        
        protected void dec_sp() {
            tStates += 2;
            r1.sp--;
        }
        
        protected void inc_de() {
            tStates += 2;
            r1.de++;
        }
        
        protected void dec_de() {
            tStates += 2;
            r1.de--;
        }
        
        protected void inc_bc() {
            tStates += 2;
            r1.bc++;
        }
        
        protected void dec_bc() {
            tStates += 2;
            r1.bc--;
        }
        
        protected void inc_ix() {
            tStates += 2;
            r1.ix++;
        }
        
        protected void dec_ix() {
            tStates += 2;
            r1.ix--;
        }
        
        protected void inc_iy() {
            tStates += 2;
            r1.iy++;
        }
        
        protected void dec_iy() {
            tStates += 2;
            r1.iy--;
        }
        

        protected void daa() {
            DoDAA();
        }
        
        protected void cpl() {
            r1.a = (byte)~r1.a;
            SetFlag(f_h | f_n);
            AdjustFlags(r1.a);
        }
        
        protected void neg() {
            var _t = r1.a;
            r1.a = 0;
            r1.a = DoArithmetics(_t, false, true);
            SetFlag(f_n);
        }
        
        protected void ccf() {
            ValFlag(f_c, !GetFlag(f_c));
            ResFlag(f_n);
            AdjustFlags(r1.a);
        }
        
        protected void scf() {
            SetFlag(f_c);
            ResFlag(f_h | f_n);
            AdjustFlags(r1.a);
        }
        
        protected void halt() {
            halted = true;
            pc--;
        }
        
        protected void di() {
            iff1 = false;
            iff2 = false;
            deferInt = true;
        }

        protected void ei() {
            iff1 = true;
            iff2 = true;
            deferInt = true;
        }
        protected void im_0() {
            im = 0;
        }
        
        protected void im_1() {
            im = 1;
        }
        
        protected void im_2() {
            im = 2;
        }
        

        // ROTATE AND SHIFT
        
        protected void rlca() {
            r1.a = DoRLC(r1.a, false);
        }
        
        protected void rlc_a() {
            r1.a = DoRLC(r1.a, false);
        }
        
        protected void rlc_b() {
            r1.b = DoRLC(r1.b, false);
        }
        
        protected void rlc_c() {
            r1.c = DoRLC(r1.c, false);
        }
        
        protected void rlc_d() {
            r1.d = DoRLC(r1.d, false);
        }
        
        protected void rlc_e() {
            r1.e = DoRLC(r1.e, false);
        }
        
        protected void rlc_h() {
            r1.h = DoRLC(r1.h, false);
        }
        
        protected void rlc_l() {
            r1.l = DoRLC(r1.l, false);
        }
        
        protected void rlc_ixh() {
            r1.ixh = DoRLC(r1.ixh, false);
        }
        
        protected void rlc_ixl() {
            r1.ixl = DoRLC(r1.ixl, false);
        }
        
        protected void rlc_iyh() {
            r1.iyh = DoRLC(r1.iyh, false);
        }
        
        protected void rlc_iyl() {
            r1.iyl = DoRLC(r1.iyl, false);
        }
        
        protected void rlc__hl_() {
            tStates++;
            Write8(r1.hl, DoRLC(Read8(r1.hl), true));
        }

        protected void rlc__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoRLC(Read8(addr), true));
        }
                
        protected void rlc__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoRLC(Read8(addr), true));
        }
                
        protected void rla() {
            r1.a = DoRL(r1.a, false);
        }
        
        protected void rl_a() {
            r1.a = DoRL(r1.a, false);
        }
        
        protected void rl_b() {
            r1.b = DoRL(r1.b, false);
        }
        
        protected void rl_c() {
            r1.c = DoRL(r1.c, false);
        }
        
        protected void rl_d() {
            r1.d = DoRL(r1.d, false);
        }
        
        protected void rl_e() {
            r1.e = DoRL(r1.e, false);
        }
        
        protected void rl_h() {
            r1.h = DoRL(r1.h, false);
        }
        
        protected void rl_l() {
            r1.l = DoRL(r1.l, false);
        }
        
        protected void rl_ixh() {
            r1.ixh = DoRL(r1.ixh, false);
        }
        
        protected void rl_ixl() {
            r1.ixl = DoRL(r1.ixl, false);
        }
        
        protected void rl_iyh() {
            r1.iyh = DoRL(r1.iyh, false);
        }
        
        protected void rl_iyl() {
            r1.iyl = DoRL(r1.iyl, false);
        }
        
        protected void rl__hl_() {
            tStates++;
            Write8(r1.hl, DoRL(Read8(r1.hl), true));
        }

        protected void rl__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoRL(Read8(addr), true));
        }
                
        protected void rl__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoRL(Read8(addr), true));
        }
                
        protected void rrca() {
            r1.a = DoRRC(r1.a, false);
        }
        
        protected void rrc_a() {
            r1.a = DoRRC(r1.a, false);
        }
        
        protected void rrc_b() {
            r1.b = DoRRC(r1.b, false);
        }
        
        protected void rrc_c() {
            r1.c = DoRRC(r1.c, false);
        }
        
        protected void rrc_d() {
            r1.d = DoRRC(r1.d, false);
        }
        
        protected void rrc_e() {
            r1.e = DoRRC(r1.e, false);
        }
        
        protected void rrc_h() {
            r1.h = DoRRC(r1.h, false);
        }
        
        protected void rrc_l() {
            r1.l = DoRRC(r1.l, false);
        }
        
        protected void rrc_ixh() {
            r1.ixh = DoRRC(r1.ixh, false);
        }
        
        protected void rrc_ixl() {
            r1.ixl = DoRRC(r1.ixl, false);
        }
        
        protected void rrc_iyh() {
            r1.iyh = DoRRC(r1.iyh, false);
        }
        
        protected void rrc_iyl() {
            r1.iyl = DoRRC(r1.iyl, false);
        }
        
        protected void rrc__hl_() {
            tStates++;
            Write8(r1.hl, DoRRC(Read8(r1.hl), true));
        }

        protected void rrc__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoRRC(Read8(addr), true));
        }
                
        protected void rrc__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoRRC(Read8(addr), true));
        }
                
        protected void rra() {
            r1.a = DoRR(r1.a, false);
        }
        
        protected void rr_a() {
            r1.a = DoRR(r1.a, false);
        }
        
        protected void rr_b() {
            r1.b = DoRR(r1.b, false);
        }
        
        protected void rr_c() {
            r1.c = DoRR(r1.c, false);
        }
        
        protected void rr_d() {
            r1.d = DoRR(r1.d, false);
        }
        
        protected void rr_e() {
            r1.e = DoRR(r1.e, false);
        }
        
        protected void rr_h() {
            r1.h = DoRR(r1.h, false);
        }
        
        protected void rr_l() {
            r1.l = DoRR(r1.l, false);
        }
        
        protected void rr_ixh() {
            r1.ixh = DoRR(r1.ixh, false);
        }
        
        protected void rr_ixl() {
            r1.ixl = DoRR(r1.ixl, false);
        }
        
        protected void rr_iyh() {
            r1.iyh = DoRR(r1.iyh, false);
        }
        
        protected void rr_iyl() {
            r1.iyl = DoRR(r1.iyl, false);
        }
        
        protected void rr__hl_() {
            tStates++;
            Write8(r1.hl, DoRR(Read8(r1.hl), true));
        }

        protected void rr__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoRR(Read8(addr), true));
        }
                
        protected void rr__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoRR(Read8(addr), true));
        }
                
        protected void sla_a() {
            r1.a = DoSL(r1.a, isArithmeticsA);
        }
        
        protected void sla_b() {
            r1.b = DoSL(r1.b, isArithmeticsA);
        }
        
        protected void sla_c() {
            r1.c = DoSL(r1.c, isArithmeticsA);
        }
        
        protected void sla_d() {
            r1.d = DoSL(r1.d, isArithmeticsA);
        }
        
        protected void sla_e() {
            r1.e = DoSL(r1.e, isArithmeticsA);
        }
        
        protected void sla_h() {
            r1.h = DoSL(r1.h, isArithmeticsA);
        }
        
        protected void sla_l() {
            r1.l = DoSL(r1.l, isArithmeticsA);
        }
        
        protected void sla_ixh() {
            r1.ixh = DoSL(r1.ixh, isArithmeticsA);
        }
        
        protected void sla_ixl() {
            r1.ixl = DoSL(r1.ixl, isArithmeticsA);
        }
        
        protected void sla_iyh() {
            r1.iyh = DoSL(r1.iyh, isArithmeticsA);
        }
        
        protected void sla_iyl() {
            r1.iyl = DoSL(r1.iyl, isArithmeticsA);
        }
        
        protected void sla__hl_() {
            tStates++;
            Write8(r1.hl, DoSL(Read8(r1.hl), isArithmeticsA));
        }

        protected void sla__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSL(Read8(addr), isArithmeticsA));
        }
                
        protected void sla__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSL(Read8(addr), isArithmeticsA));
        }
                
        protected void sll_a() {
            r1.a = DoSL(r1.a, isArithmeticsL);
        }
        
        protected void sll_b() {
            r1.b = DoSL(r1.b, isArithmeticsL);
        }
        
        protected void sll_c() {
            r1.c = DoSL(r1.c, isArithmeticsL);
        }
        
        protected void sll_d() {
            r1.d = DoSL(r1.d, isArithmeticsL);
        }
        
        protected void sll_e() {
            r1.e = DoSL(r1.e, isArithmeticsL);
        }
        
        protected void sll_h() {
            r1.h = DoSL(r1.h, isArithmeticsL);
        }
        
        protected void sll_l() {
            r1.l = DoSL(r1.l, isArithmeticsL);
        }
        
        protected void sll_ixh() {
            r1.ixh = DoSL(r1.ixh, isArithmeticsL);
        }
        
        protected void sll_ixl() {
            r1.ixl = DoSL(r1.ixl, isArithmeticsL);
        }
        
        protected void sll_iyh() {
            r1.iyh = DoSL(r1.iyh, isArithmeticsL);
        }
        
        protected void sll_iyl() {
            r1.iyl = DoSL(r1.iyl, isArithmeticsL);
        }
        
        protected void sll__hl_() {
            tStates++;
            Write8(r1.hl, DoSL(Read8(r1.hl), isArithmeticsL));
        }

        protected void sll__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSL(Read8(addr), isArithmeticsL));
        }
                
        protected void sll__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSL(Read8(addr), isArithmeticsL));
        }
                
        protected void sra_a() {
            r1.a = DoSR(r1.a, isArithmeticsA);
        }
        
        protected void sra_b() {
            r1.b = DoSR(r1.b, isArithmeticsA);
        }
        
        protected void sra_c() {
            r1.c = DoSR(r1.c, isArithmeticsA);
        }
        
        protected void sra_d() {
            r1.d = DoSR(r1.d, isArithmeticsA);
        }
        
        protected void sra_e() {
            r1.e = DoSR(r1.e, isArithmeticsA);
        }
        
        protected void sra_h() {
            r1.h = DoSR(r1.h, isArithmeticsA);
        }
        
        protected void sra_l() {
            r1.l = DoSR(r1.l, isArithmeticsA);
        }
        
        protected void sra_ixh() {
            r1.ixh = DoSR(r1.ixh, isArithmeticsA);
        }
        
        protected void sra_ixl() {
            r1.ixl = DoSR(r1.ixl, isArithmeticsA);
        }
        
        protected void sra_iyh() {
            r1.iyh = DoSR(r1.iyh, isArithmeticsA);
        }
        
        protected void sra_iyl() {
            r1.iyl = DoSR(r1.iyl, isArithmeticsA);
        }
        
        protected void sra__hl_() {
            tStates++;
            Write8(r1.hl, DoSR(Read8(r1.hl), isArithmeticsA));
        }

        protected void sra__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSR(Read8(addr), isArithmeticsA));
        }
                
        protected void sra__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSR(Read8(addr), isArithmeticsA));
        }
                
        protected void srl_a() {
            r1.a = DoSR(r1.a, isArithmeticsL);
        }
        
        protected void srl_b() {
            r1.b = DoSR(r1.b, isArithmeticsL);
        }
        
        protected void srl_c() {
            r1.c = DoSR(r1.c, isArithmeticsL);
        }
        
        protected void srl_d() {
            r1.d = DoSR(r1.d, isArithmeticsL);
        }
        
        protected void srl_e() {
            r1.e = DoSR(r1.e, isArithmeticsL);
        }
        
        protected void srl_h() {
            r1.h = DoSR(r1.h, isArithmeticsL);
        }
        
        protected void srl_l() {
            r1.l = DoSR(r1.l, isArithmeticsL);
        }
        
        protected void srl_ixh() {
            r1.ixh = DoSR(r1.ixh, isArithmeticsL);
        }
        
        protected void srl_ixl() {
            r1.ixl = DoSR(r1.ixl, isArithmeticsL);
        }
        
        protected void srl_iyh() {
            r1.iyh = DoSR(r1.iyh, isArithmeticsL);
        }
        
        protected void srl_iyl() {
            r1.iyl = DoSR(r1.iyl, isArithmeticsL);
        }
        
        protected void srl__hl_() {
            tStates++;
            Write8(r1.hl, DoSR(Read8(r1.hl), isArithmeticsL));
        }

        protected void srl__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSR(Read8(addr), isArithmeticsL));
        }
                
        protected void srl__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSR(Read8(addr), isArithmeticsL));
        }
                
        protected void rld() {
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
    
        protected void rrd() {
            tStates += 4;
            var ah = r1.a & 0x0F;
            var hl = Read8(r1.hl);
            r1.a = (byte)((r1.a & 0xF0) | (hl & 0x0F));
            hl = (byte)((hl >> 4) | (ah << 4));
            Write8(r1.hl, hl);
            ResFlag(f_h | f_n);
            AdjustFlagsSZP(r1.a);
        }
        
        protected void bit_0_a() {
            DoBitR(0, r1.a);
        }
        
        protected void bit_0_b() {
            DoBitR(0, r1.b);
        }
        
        protected void bit_0_c() {
            DoBitR(0, r1.c);
        }
        
        protected void bit_0_d() {
            DoBitR(0, r1.d);
        }
        
        protected void bit_0_e() {
            DoBitR(0, r1.e);
        }
        
        protected void bit_0_h() {
            DoBitR(0, r1.h);
        }
        
        protected void bit_0_l() {
            DoBitR(0, r1.l);
        }
        
        protected void bit_0__hl_() {
            tStates++;
            DoBitR(0, Read8(r1.hl));
        }
        
        protected void bit_0__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            DoBitIndexed(0, addr);
        }
        
        protected void bit_0__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            DoBitIndexed(0, addr);
        }
        
        protected void bit_1_a() {
            DoBitR(1, r1.a);
        }
        
        protected void bit_1_b() {
            DoBitR(1, r1.b);
        }
        
        protected void bit_1_c() {
            DoBitR(1, r1.c);
        }
        
        protected void bit_1_d() {
            DoBitR(1, r1.d);
        }
        
        protected void bit_1_e() {
            DoBitR(1, r1.e);
        }
        
        protected void bit_1_h() {
            DoBitR(1, r1.h);
        }
        
        protected void bit_1_l() {
            DoBitR(1, r1.l);
        }
        
        protected void bit_1__hl_() {
            tStates++;
            DoBitR(1, Read8(r1.hl));
        }
        
        protected void bit_1__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            DoBitIndexed(1, addr);
        }
        
        protected void bit_1__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            DoBitIndexed(1, addr);
        }
        
        protected void bit_2_a() {
            DoBitR(2, r1.a);
        }
        
        protected void bit_2_b() {
            DoBitR(2, r1.b);
        }
        
        protected void bit_2_c() {
            DoBitR(2, r1.c);
        }
        
        protected void bit_2_d() {
            DoBitR(2, r1.d);
        }
        
        protected void bit_2_e() {
            DoBitR(2, r1.e);
        }
        
        protected void bit_2_h() {
            DoBitR(2, r1.h);
        }
        
        protected void bit_2_l() {
            DoBitR(2, r1.l);
        }
        
        protected void bit_2__hl_() {
            tStates++;
            DoBitR(2, Read8(r1.hl));
        }
        
        protected void bit_2__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            DoBitIndexed(2, addr);
        }
        
        protected void bit_2__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            DoBitIndexed(2, addr);
        }
        
        protected void bit_3_a() {
            DoBitR(3, r1.a);
        }
        
        protected void bit_3_b() {
            DoBitR(3, r1.b);
        }
        
        protected void bit_3_c() {
            DoBitR(3, r1.c);
        }
        
        protected void bit_3_d() {
            DoBitR(3, r1.d);
        }
        
        protected void bit_3_e() {
            DoBitR(3, r1.e);
        }
        
        protected void bit_3_h() {
            DoBitR(3, r1.h);
        }
        
        protected void bit_3_l() {
            DoBitR(3, r1.l);
        }
        
        protected void bit_3__hl_() {
            tStates++;
            DoBitR(3, Read8(r1.hl));
        }
        
        protected void bit_3__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            DoBitIndexed(3, addr);
        }
        
        protected void bit_3__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            DoBitIndexed(3, addr);
        }
        
        protected void bit_4_a() {
            DoBitR(4, r1.a);
        }
        
        protected void bit_4_b() {
            DoBitR(4, r1.b);
        }
        
        protected void bit_4_c() {
            DoBitR(4, r1.c);
        }
        
        protected void bit_4_d() {
            DoBitR(4, r1.d);
        }
        
        protected void bit_4_e() {
            DoBitR(4, r1.e);
        }
        
        protected void bit_4_h() {
            DoBitR(4, r1.h);
        }
        
        protected void bit_4_l() {
            DoBitR(4, r1.l);
        }
        
        protected void bit_4__hl_() {
            tStates++;
            DoBitR(4, Read8(r1.hl));
        }
        
        protected void bit_4__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            DoBitIndexed(4, addr);
        }
        
        protected void bit_4__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            DoBitIndexed(4, addr);
        }
        
        protected void bit_5_a() {
            DoBitR(5, r1.a);
        }
        
        protected void bit_5_b() {
            DoBitR(5, r1.b);
        }
        
        protected void bit_5_c() {
            DoBitR(5, r1.c);
        }
        
        protected void bit_5_d() {
            DoBitR(5, r1.d);
        }
        
        protected void bit_5_e() {
            DoBitR(5, r1.e);
        }
        
        protected void bit_5_h() {
            DoBitR(5, r1.h);
        }
        
        protected void bit_5_l() {
            DoBitR(5, r1.l);
        }
        
        protected void bit_5__hl_() {
            tStates++;
            DoBitR(5, Read8(r1.hl));
        }
        
        protected void bit_5__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            DoBitIndexed(5, addr);
        }
        
        protected void bit_5__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            DoBitIndexed(5, addr);
        }
        
        protected void bit_6_a() {
            DoBitR(6, r1.a);
        }
        
        protected void bit_6_b() {
            DoBitR(6, r1.b);
        }
        
        protected void bit_6_c() {
            DoBitR(6, r1.c);
        }
        
        protected void bit_6_d() {
            DoBitR(6, r1.d);
        }
        
        protected void bit_6_e() {
            DoBitR(6, r1.e);
        }
        
        protected void bit_6_h() {
            DoBitR(6, r1.h);
        }
        
        protected void bit_6_l() {
            DoBitR(6, r1.l);
        }
        
        protected void bit_6__hl_() {
            tStates++;
            DoBitR(6, Read8(r1.hl));
        }
        
        protected void bit_6__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            DoBitIndexed(6, addr);
        }
        
        protected void bit_6__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            DoBitIndexed(6, addr);
        }
        
        protected void bit_7_a() {
            DoBitR(7, r1.a);
        }
        
        protected void bit_7_b() {
            DoBitR(7, r1.b);
        }
        
        protected void bit_7_c() {
            DoBitR(7, r1.c);
        }
        
        protected void bit_7_d() {
            DoBitR(7, r1.d);
        }
        
        protected void bit_7_e() {
            DoBitR(7, r1.e);
        }
        
        protected void bit_7_h() {
            DoBitR(7, r1.h);
        }
        
        protected void bit_7_l() {
            DoBitR(7, r1.l);
        }
        
        protected void bit_7__hl_() {
            tStates++;
            DoBitR(7, Read8(r1.hl));
        }
        
        protected void bit_7__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            DoBitIndexed(7, addr);
        }
        
        protected void bit_7__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            DoBitIndexed(7, addr);
        }
        

        // SET / RES
        
        protected void set_0_a() {
            r1.a = DoSetRes(bitStateSET, 0, r1.a);
        }
        
        protected void set_0_b() {
            r1.b = DoSetRes(bitStateSET, 0, r1.b);
        }
        
        protected void set_0_c() {
            r1.c = DoSetRes(bitStateSET, 0, r1.c);
        }
        
        protected void set_0_d() {
            r1.d = DoSetRes(bitStateSET, 0, r1.d);
        }
        
        protected void set_0_e() {
            r1.e = DoSetRes(bitStateSET, 0, r1.e);
        }
        
        protected void set_0_h() {
            r1.h = DoSetRes(bitStateSET, 0, r1.h);
        }
        
        protected void set_0_l() {
            r1.l = DoSetRes(bitStateSET, 0, r1.l);
        }
        
        protected void set_0__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateSET, 0, Read8(r1.hl)));
        }
        
        protected void set_0__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateSET, 0, Read8(addr)));
        }
        
        protected void set_0__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateSET, 0, Read8(addr)));
        }
        
        protected void set_1_a() {
            r1.a = DoSetRes(bitStateSET, 1, r1.a);
        }
        
        protected void set_1_b() {
            r1.b = DoSetRes(bitStateSET, 1, r1.b);
        }
        
        protected void set_1_c() {
            r1.c = DoSetRes(bitStateSET, 1, r1.c);
        }
        
        protected void set_1_d() {
            r1.d = DoSetRes(bitStateSET, 1, r1.d);
        }
        
        protected void set_1_e() {
            r1.e = DoSetRes(bitStateSET, 1, r1.e);
        }
        
        protected void set_1_h() {
            r1.h = DoSetRes(bitStateSET, 1, r1.h);
        }
        
        protected void set_1_l() {
            r1.l = DoSetRes(bitStateSET, 1, r1.l);
        }
        
        protected void set_1__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateSET, 1, Read8(r1.hl)));
        }
        
        protected void set_1__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateSET, 1, Read8(addr)));
        }
        
        protected void set_1__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateSET, 1, Read8(addr)));
        }
        
        protected void set_2_a() {
            r1.a = DoSetRes(bitStateSET, 2, r1.a);
        }
        
        protected void set_2_b() {
            r1.b = DoSetRes(bitStateSET, 2, r1.b);
        }
        
        protected void set_2_c() {
            r1.c = DoSetRes(bitStateSET, 2, r1.c);
        }
        
        protected void set_2_d() {
            r1.d = DoSetRes(bitStateSET, 2, r1.d);
        }
        
        protected void set_2_e() {
            r1.e = DoSetRes(bitStateSET, 2, r1.e);
        }
        
        protected void set_2_h() {
            r1.h = DoSetRes(bitStateSET, 2, r1.h);
        }
        
        protected void set_2_l() {
            r1.l = DoSetRes(bitStateSET, 2, r1.l);
        }
        
        protected void set_2__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateSET, 2, Read8(r1.hl)));
        }
        
        protected void set_2__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateSET, 2, Read8(addr)));
        }
        
        protected void set_2__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateSET, 2, Read8(addr)));
        }
        
        protected void set_3_a() {
            r1.a = DoSetRes(bitStateSET, 3, r1.a);
        }
        
        protected void set_3_b() {
            r1.b = DoSetRes(bitStateSET, 3, r1.b);
        }
        
        protected void set_3_c() {
            r1.c = DoSetRes(bitStateSET, 3, r1.c);
        }
        
        protected void set_3_d() {
            r1.d = DoSetRes(bitStateSET, 3, r1.d);
        }
        
        protected void set_3_e() {
            r1.e = DoSetRes(bitStateSET, 3, r1.e);
        }
        
        protected void set_3_h() {
            r1.h = DoSetRes(bitStateSET, 3, r1.h);
        }
        
        protected void set_3_l() {
            r1.l = DoSetRes(bitStateSET, 3, r1.l);
        }
        
        protected void set_3__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateSET, 3, Read8(r1.hl)));
        }
        
        protected void set_3__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateSET, 3, Read8(addr)));
        }
        
        protected void set_3__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateSET, 3, Read8(addr)));
        }
        
        protected void set_4_a() {
            r1.a = DoSetRes(bitStateSET, 4, r1.a);
        }
        
        protected void set_4_b() {
            r1.b = DoSetRes(bitStateSET, 4, r1.b);
        }
        
        protected void set_4_c() {
            r1.c = DoSetRes(bitStateSET, 4, r1.c);
        }
        
        protected void set_4_d() {
            r1.d = DoSetRes(bitStateSET, 4, r1.d);
        }
        
        protected void set_4_e() {
            r1.e = DoSetRes(bitStateSET, 4, r1.e);
        }
        
        protected void set_4_h() {
            r1.h = DoSetRes(bitStateSET, 4, r1.h);
        }
        
        protected void set_4_l() {
            r1.l = DoSetRes(bitStateSET, 4, r1.l);
        }
        
        protected void set_4__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateSET, 4, Read8(r1.hl)));
        }
        
        protected void set_4__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateSET, 4, Read8(addr)));
        }
        
        protected void set_4__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateSET, 4, Read8(addr)));
        }
        
        protected void set_5_a() {
            r1.a = DoSetRes(bitStateSET, 5, r1.a);
        }
        
        protected void set_5_b() {
            r1.b = DoSetRes(bitStateSET, 5, r1.b);
        }
        
        protected void set_5_c() {
            r1.c = DoSetRes(bitStateSET, 5, r1.c);
        }
        
        protected void set_5_d() {
            r1.d = DoSetRes(bitStateSET, 5, r1.d);
        }
        
        protected void set_5_e() {
            r1.e = DoSetRes(bitStateSET, 5, r1.e);
        }
        
        protected void set_5_h() {
            r1.h = DoSetRes(bitStateSET, 5, r1.h);
        }
        
        protected void set_5_l() {
            r1.l = DoSetRes(bitStateSET, 5, r1.l);
        }
        
        protected void set_5__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateSET, 5, Read8(r1.hl)));
        }
        
        protected void set_5__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateSET, 5, Read8(addr)));
        }
        
        protected void set_5__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateSET, 5, Read8(addr)));
        }
        
        protected void set_6_a() {
            r1.a = DoSetRes(bitStateSET, 6, r1.a);
        }
        
        protected void set_6_b() {
            r1.b = DoSetRes(bitStateSET, 6, r1.b);
        }
        
        protected void set_6_c() {
            r1.c = DoSetRes(bitStateSET, 6, r1.c);
        }
        
        protected void set_6_d() {
            r1.d = DoSetRes(bitStateSET, 6, r1.d);
        }
        
        protected void set_6_e() {
            r1.e = DoSetRes(bitStateSET, 6, r1.e);
        }
        
        protected void set_6_h() {
            r1.h = DoSetRes(bitStateSET, 6, r1.h);
        }
        
        protected void set_6_l() {
            r1.l = DoSetRes(bitStateSET, 6, r1.l);
        }
        
        protected void set_6__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateSET, 6, Read8(r1.hl)));
        }
        
        protected void set_6__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateSET, 6, Read8(addr)));
        }
        
        protected void set_6__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateSET, 6, Read8(addr)));
        }
        
        protected void set_7_a() {
            r1.a = DoSetRes(bitStateSET, 7, r1.a);
        }
        
        protected void set_7_b() {
            r1.b = DoSetRes(bitStateSET, 7, r1.b);
        }
        
        protected void set_7_c() {
            r1.c = DoSetRes(bitStateSET, 7, r1.c);
        }
        
        protected void set_7_d() {
            r1.d = DoSetRes(bitStateSET, 7, r1.d);
        }
        
        protected void set_7_e() {
            r1.e = DoSetRes(bitStateSET, 7, r1.e);
        }
        
        protected void set_7_h() {
            r1.h = DoSetRes(bitStateSET, 7, r1.h);
        }
        
        protected void set_7_l() {
            r1.l = DoSetRes(bitStateSET, 7, r1.l);
        }
        
        protected void set_7__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateSET, 7, Read8(r1.hl)));
        }
        
        protected void set_7__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateSET, 7, Read8(addr)));
        }
        
        protected void set_7__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateSET, 7, Read8(addr)));
        }
        
        protected void res_0_a() {
            r1.a = DoSetRes(bitStateRES, 0, r1.a);
        }
        
        protected void res_0_b() {
            r1.b = DoSetRes(bitStateRES, 0, r1.b);
        }
        
        protected void res_0_c() {
            r1.c = DoSetRes(bitStateRES, 0, r1.c);
        }
        
        protected void res_0_d() {
            r1.d = DoSetRes(bitStateRES, 0, r1.d);
        }
        
        protected void res_0_e() {
            r1.e = DoSetRes(bitStateRES, 0, r1.e);
        }
        
        protected void res_0_h() {
            r1.h = DoSetRes(bitStateRES, 0, r1.h);
        }
        
        protected void res_0_l() {
            r1.l = DoSetRes(bitStateRES, 0, r1.l);
        }
        
        protected void res_0__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateRES, 0, Read8(r1.hl)));
        }
        
        protected void res_0__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateRES, 0, Read8(addr)));
        }
        
        protected void res_0__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateRES, 0, Read8(addr)));
        }
        
        protected void res_1_a() {
            r1.a = DoSetRes(bitStateRES, 1, r1.a);
        }
        
        protected void res_1_b() {
            r1.b = DoSetRes(bitStateRES, 1, r1.b);
        }
        
        protected void res_1_c() {
            r1.c = DoSetRes(bitStateRES, 1, r1.c);
        }
        
        protected void res_1_d() {
            r1.d = DoSetRes(bitStateRES, 1, r1.d);
        }
        
        protected void res_1_e() {
            r1.e = DoSetRes(bitStateRES, 1, r1.e);
        }
        
        protected void res_1_h() {
            r1.h = DoSetRes(bitStateRES, 1, r1.h);
        }
        
        protected void res_1_l() {
            r1.l = DoSetRes(bitStateRES, 1, r1.l);
        }
        
        protected void res_1__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateRES, 1, Read8(r1.hl)));
        }
        
        protected void res_1__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateRES, 1, Read8(addr)));
        }
        
        protected void res_1__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateRES, 1, Read8(addr)));
        }
        
        protected void res_2_a() {
            r1.a = DoSetRes(bitStateRES, 2, r1.a);
        }
        
        protected void res_2_b() {
            r1.b = DoSetRes(bitStateRES, 2, r1.b);
        }
        
        protected void res_2_c() {
            r1.c = DoSetRes(bitStateRES, 2, r1.c);
        }
        
        protected void res_2_d() {
            r1.d = DoSetRes(bitStateRES, 2, r1.d);
        }
        
        protected void res_2_e() {
            r1.e = DoSetRes(bitStateRES, 2, r1.e);
        }
        
        protected void res_2_h() {
            r1.h = DoSetRes(bitStateRES, 2, r1.h);
        }
        
        protected void res_2_l() {
            r1.l = DoSetRes(bitStateRES, 2, r1.l);
        }
        
        protected void res_2__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateRES, 2, Read8(r1.hl)));
        }
        
        protected void res_2__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateRES, 2, Read8(addr)));
        }
        
        protected void res_2__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateRES, 2, Read8(addr)));
        }
        
        protected void res_3_a() {
            r1.a = DoSetRes(bitStateRES, 3, r1.a);
        }
        
        protected void res_3_b() {
            r1.b = DoSetRes(bitStateRES, 3, r1.b);
        }
        
        protected void res_3_c() {
            r1.c = DoSetRes(bitStateRES, 3, r1.c);
        }
        
        protected void res_3_d() {
            r1.d = DoSetRes(bitStateRES, 3, r1.d);
        }
        
        protected void res_3_e() {
            r1.e = DoSetRes(bitStateRES, 3, r1.e);
        }
        
        protected void res_3_h() {
            r1.h = DoSetRes(bitStateRES, 3, r1.h);
        }
        
        protected void res_3_l() {
            r1.l = DoSetRes(bitStateRES, 3, r1.l);
        }
        
        protected void res_3__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateRES, 3, Read8(r1.hl)));
        }
        
        protected void res_3__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateRES, 3, Read8(addr)));
        }
        
        protected void res_3__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateRES, 3, Read8(addr)));
        }
        
        protected void res_4_a() {
            r1.a = DoSetRes(bitStateRES, 4, r1.a);
        }
        
        protected void res_4_b() {
            r1.b = DoSetRes(bitStateRES, 4, r1.b);
        }
        
        protected void res_4_c() {
            r1.c = DoSetRes(bitStateRES, 4, r1.c);
        }
        
        protected void res_4_d() {
            r1.d = DoSetRes(bitStateRES, 4, r1.d);
        }
        
        protected void res_4_e() {
            r1.e = DoSetRes(bitStateRES, 4, r1.e);
        }
        
        protected void res_4_h() {
            r1.h = DoSetRes(bitStateRES, 4, r1.h);
        }
        
        protected void res_4_l() {
            r1.l = DoSetRes(bitStateRES, 4, r1.l);
        }
        
        protected void res_4__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateRES, 4, Read8(r1.hl)));
        }
        
        protected void res_4__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateRES, 4, Read8(addr)));
        }
        
        protected void res_4__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateRES, 4, Read8(addr)));
        }
        
        protected void res_5_a() {
            r1.a = DoSetRes(bitStateRES, 5, r1.a);
        }
        
        protected void res_5_b() {
            r1.b = DoSetRes(bitStateRES, 5, r1.b);
        }
        
        protected void res_5_c() {
            r1.c = DoSetRes(bitStateRES, 5, r1.c);
        }
        
        protected void res_5_d() {
            r1.d = DoSetRes(bitStateRES, 5, r1.d);
        }
        
        protected void res_5_e() {
            r1.e = DoSetRes(bitStateRES, 5, r1.e);
        }
        
        protected void res_5_h() {
            r1.h = DoSetRes(bitStateRES, 5, r1.h);
        }
        
        protected void res_5_l() {
            r1.l = DoSetRes(bitStateRES, 5, r1.l);
        }
        
        protected void res_5__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateRES, 5, Read8(r1.hl)));
        }
        
        protected void res_5__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateRES, 5, Read8(addr)));
        }
        
        protected void res_5__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateRES, 5, Read8(addr)));
        }
        
        protected void res_6_a() {
            r1.a = DoSetRes(bitStateRES, 6, r1.a);
        }
        
        protected void res_6_b() {
            r1.b = DoSetRes(bitStateRES, 6, r1.b);
        }
        
        protected void res_6_c() {
            r1.c = DoSetRes(bitStateRES, 6, r1.c);
        }
        
        protected void res_6_d() {
            r1.d = DoSetRes(bitStateRES, 6, r1.d);
        }
        
        protected void res_6_e() {
            r1.e = DoSetRes(bitStateRES, 6, r1.e);
        }
        
        protected void res_6_h() {
            r1.h = DoSetRes(bitStateRES, 6, r1.h);
        }
        
        protected void res_6_l() {
            r1.l = DoSetRes(bitStateRES, 6, r1.l);
        }
        
        protected void res_6__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateRES, 6, Read8(r1.hl)));
        }
        
        protected void res_6__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateRES, 6, Read8(addr)));
        }
        
        protected void res_6__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateRES, 6, Read8(addr)));
        }
        
        protected void res_7_a() {
            r1.a = DoSetRes(bitStateRES, 7, r1.a);
        }
        
        protected void res_7_b() {
            r1.b = DoSetRes(bitStateRES, 7, r1.b);
        }
        
        protected void res_7_c() {
            r1.c = DoSetRes(bitStateRES, 7, r1.c);
        }
        
        protected void res_7_d() {
            r1.d = DoSetRes(bitStateRES, 7, r1.d);
        }
        
        protected void res_7_e() {
            r1.e = DoSetRes(bitStateRES, 7, r1.e);
        }
        
        protected void res_7_h() {
            r1.h = DoSetRes(bitStateRES, 7, r1.h);
        }
        
        protected void res_7_l() {
            r1.l = DoSetRes(bitStateRES, 7, r1.l);
        }
        
        protected void res_7__hl_() {
            tStates++;
            Write8(r1.hl, DoSetRes(bitStateRES, 7, Read8(r1.hl)));
        }
        
        protected void res_7__ix_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.ix + offset);
            Write8(addr, DoSetRes(bitStateRES, 7, Read8(addr)));
        }
        
        protected void res_7__iy_d_() {
            tStates += 2;
            var offset = (SByte)Read8(pc++);
            var addr = (ushort)(r1.iy + offset);
            Write8(addr, DoSetRes(bitStateRES, 7, Read8(addr)));
        }
        

            
    }
}