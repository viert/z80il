using Microsoft.VisualStudio.TestTools.UnitTesting;
using Z80;

namespace z80ilTest
{
    [TestClass]
    public class CpuTestFD
    {
        readonly Cpu cpu;
        SimpleMemory memory;

        public CpuTestFD() {
            memory = new SimpleMemory();
            cpu = new Cpu(memory);
        }

        [TestMethod]
        public void TestFD09() {
            cpu.Reset();
            cpu.r1.af = 0x466A;
            cpu.r1.bc = 0xA623;
            cpu.r1.de = 0xBAB2;
            cpu.r1.hl = 0xD788;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC9E8;
            cpu.r1.iy = 0xF698;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x09);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4649, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA623, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xBAB2, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD788, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC9E8, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x9CBB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD19() {
            cpu.Reset();
            cpu.r1.af = 0xB3E5;
            cpu.r1.bc = 0x5336;
            cpu.r1.de = 0x76CB;
            cpu.r1.hl = 0x54E2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB9CE;
            cpu.r1.iy = 0x8624;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x19);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB3EC, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5336, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x76CB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x54E2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB9CE, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xFCEF, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD21() {
            cpu.Reset();
            cpu.r1.af = 0xC924;
            cpu.r1.bc = 0x5C83;
            cpu.r1.de = 0xE0E2;
            cpu.r1.hl = 0xEDDB;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6E9F;
            cpu.r1.iy = 0xBA55;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x21);
            memory.Write8(0x0002, 0x46);
            memory.Write8(0x0003, 0x47);

            while (cpu.tStates < 14) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC924, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5C83, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE0E2, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xEDDB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6E9F, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4746, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(14UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD22() {
            cpu.Reset();
            cpu.r1.af = 0x1235;
            cpu.r1.bc = 0xF0B6;
            cpu.r1.de = 0xB74C;
            cpu.r1.hl = 0xCC9F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x8B00;
            cpu.r1.iy = 0x81E4;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x22);
            memory.Write8(0x0002, 0x9A);
            memory.Write8(0x0003, 0xE2);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1235, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF0B6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB74C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCC9F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x8B00, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x81E4, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD23() {
            cpu.Reset();
            cpu.r1.af = 0x69F2;
            cpu.r1.bc = 0xC1D3;
            cpu.r1.de = 0x0F6F;
            cpu.r1.hl = 0x2169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE39E;
            cpu.r1.iy = 0x2605;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x23);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x69F2, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC1D3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0F6F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE39E, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x2606, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD24() {
            cpu.Reset();
            cpu.r1.af = 0x5554;
            cpu.r1.bc = 0x9684;
            cpu.r1.de = 0xD36A;
            cpu.r1.hl = 0xDAC3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7803;
            cpu.r1.iy = 0x6434;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x24);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5520, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9684, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD36A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDAC3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7803, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6534, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD25() {
            cpu.Reset();
            cpu.r1.af = 0xCD0B;
            cpu.r1.bc = 0xB5E4;
            cpu.r1.de = 0xA754;
            cpu.r1.hl = 0x9526;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x3DCB;
            cpu.r1.iy = 0x03B2;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x25);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCD03, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB5E4, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA754, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9526, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x3DCB, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x02B2, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD26() {
            cpu.Reset();
            cpu.r1.af = 0x2452;
            cpu.r1.bc = 0x300B;
            cpu.r1.de = 0xB4A1;
            cpu.r1.hl = 0x929D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC259;
            cpu.r1.iy = 0x3F30;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x26);
            memory.Write8(0x0002, 0x77);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2452, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x300B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB4A1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x929D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC259, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7730, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD29() {
            cpu.Reset();
            cpu.r1.af = 0x5812;
            cpu.r1.bc = 0x49D0;
            cpu.r1.de = 0xEC95;
            cpu.r1.hl = 0x011C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xEC6C;
            cpu.r1.iy = 0x594C;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x29);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5830, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x49D0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xEC95, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x011C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xEC6C, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB298, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD2A() {
            cpu.Reset();
            cpu.r1.af = 0x0F82;
            cpu.r1.bc = 0x3198;
            cpu.r1.de = 0x87E3;
            cpu.r1.hl = 0x7C1C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1BB4;
            cpu.r1.iy = 0xEB1A;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x2A);
            memory.Write8(0x0002, 0x91);
            memory.Write8(0x0003, 0xF9);
            memory.Write8(0xF991, 0x92);
            memory.Write8(0xF992, 0xBF);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0F82, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3198, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x87E3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7C1C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1BB4, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xBF92, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD2B() {
            cpu.Reset();
            cpu.r1.af = 0xAB27;
            cpu.r1.bc = 0x942F;
            cpu.r1.de = 0x82FA;
            cpu.r1.hl = 0x6F2F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9438;
            cpu.r1.iy = 0xEBBC;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x2B);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAB27, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x942F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x82FA, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6F2F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9438, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xEBBB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD2C() {
            cpu.Reset();
            cpu.r1.af = 0x665D;
            cpu.r1.bc = 0x0AB1;
            cpu.r1.de = 0x5656;
            cpu.r1.hl = 0xE5A9;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5FB9;
            cpu.r1.iy = 0x4DF7;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x2C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x66A9, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0AB1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5656, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE5A9, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5FB9, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4DF8, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD2D() {
            cpu.Reset();
            cpu.r1.af = 0x32FB;
            cpu.r1.bc = 0xF78A;
            cpu.r1.de = 0xB906;
            cpu.r1.hl = 0x31D0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC72A;
            cpu.r1.iy = 0xE91C;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x2D);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x320B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF78A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB906, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x31D0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC72A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE91B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD2E() {
            cpu.Reset();
            cpu.r1.af = 0x2114;
            cpu.r1.bc = 0x4923;
            cpu.r1.de = 0x6E65;
            cpu.r1.hl = 0x006C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xDA39;
            cpu.r1.iy = 0xC0CB;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x2E);
            memory.Write8(0x0002, 0x49);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2114, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4923, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6E65, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x006C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xDA39, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC049, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD34() {
            cpu.Reset();
            cpu.r1.af = 0xD56A;
            cpu.r1.bc = 0x6F24;
            cpu.r1.de = 0x7DF7;
            cpu.r1.hl = 0x74F0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x365A;
            cpu.r1.iy = 0xEFC4;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x34);
            memory.Write8(0x0002, 0xB8);
            memory.Write8(0xEF7C, 0xE0);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD5A0, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6F24, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7DF7, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x74F0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x365A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xEFC4, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD35() {
            cpu.Reset();
            cpu.r1.af = 0x8CDA;
            cpu.r1.bc = 0x35D8;
            cpu.r1.de = 0x7C1A;
            cpu.r1.hl = 0x1C0A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x62BB;
            cpu.r1.iy = 0xAEC6;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x35);
            memory.Write8(0x0002, 0xAB);
            memory.Write8(0xAE71, 0xA6);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8CA2, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x35D8, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7C1A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1C0A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x62BB, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xAEC6, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD36() {
            cpu.Reset();
            cpu.r1.af = 0xE0F9;
            cpu.r1.bc = 0xAE1F;
            cpu.r1.de = 0x4AEF;
            cpu.r1.hl = 0xC9D5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC0DB;
            cpu.r1.iy = 0xBDD4;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x36);
            memory.Write8(0x0002, 0x81);
            memory.Write8(0x0003, 0xC5);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE0F9, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAE1F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4AEF, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC9D5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC0DB, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xBDD4, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD39() {
            cpu.Reset();
            cpu.r1.af = 0x2603;
            cpu.r1.bc = 0x726F;
            cpu.r1.de = 0x9C7F;
            cpu.r1.hl = 0xCD46;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xDC45;
            cpu.r1.iy = 0x54D5;
            cpu.r1.sp = 0xDC57;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x39);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2631, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x726F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9C7F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCD46, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xDC45, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x312C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0xDC57, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD44() {
            cpu.Reset();
            cpu.r1.af = 0x0E58;
            cpu.r1.bc = 0x7192;
            cpu.r1.de = 0x3580;
            cpu.r1.hl = 0x9BE4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1B79;
            cpu.r1.iy = 0x685E;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x44);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0E58, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6892, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3580, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9BE4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1B79, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x685E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD45() {
            cpu.Reset();
            cpu.r1.af = 0x6555;
            cpu.r1.bc = 0xA488;
            cpu.r1.de = 0x5AE8;
            cpu.r1.hl = 0xC948;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xD7B8;
            cpu.r1.iy = 0xA177;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x45);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6555, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7788, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5AE8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC948, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xD7B8, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA177, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD46() {
            cpu.Reset();
            cpu.r1.af = 0x87F3;
            cpu.r1.bc = 0x17D5;
            cpu.r1.de = 0x5EEA;
            cpu.r1.hl = 0x830B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xDCEE;
            cpu.r1.iy = 0x3AFC;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x46);
            memory.Write8(0x0002, 0x4D);
            memory.Write8(0x3B49, 0xC9);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x87F3, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC9D5, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5EEA, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x830B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xDCEE, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x3AFC, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD4C() {
            cpu.Reset();
            cpu.r1.af = 0x7E6B;
            cpu.r1.bc = 0xBD4B;
            cpu.r1.de = 0x24B6;
            cpu.r1.hl = 0xFF94;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x862D;
            cpu.r1.iy = 0x01D0;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x4C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7E6B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBD01, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x24B6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xFF94, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x862D, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x01D0, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD4D() {
            cpu.Reset();
            cpu.r1.af = 0x50CF;
            cpu.r1.bc = 0xE3FE;
            cpu.r1.de = 0x998E;
            cpu.r1.hl = 0xDBA2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC4F5;
            cpu.r1.iy = 0xC7C9;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x4D);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x50CF, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE3C9, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x998E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDBA2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC4F5, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC7C9, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD4E() {
            cpu.Reset();
            cpu.r1.af = 0x2C0F;
            cpu.r1.bc = 0x69D7;
            cpu.r1.de = 0x748A;
            cpu.r1.hl = 0x9290;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x904F;
            cpu.r1.iy = 0xBB9A;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x4E);
            memory.Write8(0x0002, 0x67);
            memory.Write8(0xBC01, 0x9D);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2C0F, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x699D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x748A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9290, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x904F, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xBB9A, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD54() {
            cpu.Reset();
            cpu.r1.af = 0xD7F9;
            cpu.r1.bc = 0xF65B;
            cpu.r1.de = 0xB001;
            cpu.r1.hl = 0xD4C4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x4B8E;
            cpu.r1.iy = 0xD437;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x54);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD7F9, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF65B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD401, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD4C4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x4B8E, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD437, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD55() {
            cpu.Reset();
            cpu.r1.af = 0xAB98;
            cpu.r1.bc = 0xFDAB;
            cpu.r1.de = 0x254A;
            cpu.r1.hl = 0x010E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x126B;
            cpu.r1.iy = 0x13A9;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x55);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAB98, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFDAB, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA94A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x010E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x126B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x13A9, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD56() {
            cpu.Reset();
            cpu.r1.af = 0xD3E8;
            cpu.r1.bc = 0xDF10;
            cpu.r1.de = 0x5442;
            cpu.r1.hl = 0xB641;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xA5A0;
            cpu.r1.iy = 0xFDA2;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x56);
            memory.Write8(0x0002, 0xCE);
            memory.Write8(0xFD70, 0x78);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD3E8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xDF10, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7842, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB641, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xA5A0, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xFDA2, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD5C() {
            cpu.Reset();
            cpu.r1.af = 0x11D5;
            cpu.r1.bc = 0xC489;
            cpu.r1.de = 0xE220;
            cpu.r1.hl = 0x434E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x3244;
            cpu.r1.iy = 0xD8BB;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x5C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x11D5, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC489, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE2D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x434E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x3244, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD8BB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD5D() {
            cpu.Reset();
            cpu.r1.af = 0xE945;
            cpu.r1.bc = 0xDBAE;
            cpu.r1.de = 0x32EA;
            cpu.r1.hl = 0x4F7E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xFA56;
            cpu.r1.iy = 0x074E;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x5D);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE945, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xDBAE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x324E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4F7E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xFA56, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x074E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD5E() {
            cpu.Reset();
            cpu.r1.af = 0x6F3B;
            cpu.r1.bc = 0xE9DC;
            cpu.r1.de = 0x7A06;
            cpu.r1.hl = 0x14F3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xEC76;
            cpu.r1.iy = 0x8AAA;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x5E);
            memory.Write8(0x0002, 0xC6);
            memory.Write8(0x8A70, 0x8C);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6F3B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE9DC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7A8C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x14F3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xEC76, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8AAA, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD60() {
            cpu.Reset();
            cpu.r1.af = 0x8579;
            cpu.r1.bc = 0x005D;
            cpu.r1.de = 0xD9EE;
            cpu.r1.hl = 0xFAEE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x382D;
            cpu.r1.iy = 0x2F95;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x60);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8579, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x005D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD9EE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xFAEE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x382D, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0095, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD61() {
            cpu.Reset();
            cpu.r1.af = 0x5682;
            cpu.r1.bc = 0xDBC3;
            cpu.r1.de = 0xB495;
            cpu.r1.hl = 0x9799;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x85B2;
            cpu.r1.iy = 0x3C1E;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x61);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5682, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xDBC3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB495, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9799, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x85B2, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC31E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD62() {
            cpu.Reset();
            cpu.r1.af = 0x906B;
            cpu.r1.bc = 0xF52E;
            cpu.r1.de = 0xF3D8;
            cpu.r1.hl = 0x1E8C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xDDBA;
            cpu.r1.iy = 0x9A02;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x62);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x906B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF52E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF3D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1E8C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xDDBA, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xF302, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD63() {
            cpu.Reset();
            cpu.r1.af = 0x9D59;
            cpu.r1.bc = 0xBEB9;
            cpu.r1.de = 0xD826;
            cpu.r1.hl = 0x0EAA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x4290;
            cpu.r1.iy = 0xA4B9;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x63);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9D59, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBEB9, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD826, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0EAA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x4290, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x26B9, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD64() {
            cpu.Reset();
            cpu.r1.af = 0x7B0E;
            cpu.r1.bc = 0xE394;
            cpu.r1.de = 0x8A25;
            cpu.r1.hl = 0xCDDF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9784;
            cpu.r1.iy = 0x2116;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x64);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7B0E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE394, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8A25, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCDDF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9784, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x2116, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD65() {
            cpu.Reset();
            cpu.r1.af = 0xB827;
            cpu.r1.bc = 0xEB4F;
            cpu.r1.de = 0xF666;
            cpu.r1.hl = 0xC52A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6206;
            cpu.r1.iy = 0x831F;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x65);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB827, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xEB4F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF666, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC52A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6206, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1F1F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD66() {
            cpu.Reset();
            cpu.r1.af = 0x9129;
            cpu.r1.bc = 0xE4EE;
            cpu.r1.de = 0xE3A3;
            cpu.r1.hl = 0x86CA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x4D93;
            cpu.r1.iy = 0x5B24;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x66);
            memory.Write8(0x0002, 0x80);
            memory.Write8(0x5AA4, 0x77);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9129, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE4EE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE3A3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x77CA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x4D93, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5B24, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD67() {
            cpu.Reset();
            cpu.r1.af = 0xDB7A;
            cpu.r1.bc = 0xB40B;
            cpu.r1.de = 0x7B58;
            cpu.r1.hl = 0x49FD;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x266F;
            cpu.r1.iy = 0x9E7B;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x67);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDB7A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB40B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7B58, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x49FD, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x266F, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xDB7B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD68() {
            cpu.Reset();
            cpu.r1.af = 0x4D1D;
            cpu.r1.bc = 0x4FD9;
            cpu.r1.de = 0x783E;
            cpu.r1.hl = 0x0745;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0C3D;
            cpu.r1.iy = 0x82B5;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x68);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4D1D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4FD9, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x783E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0745, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0C3D, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x824F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD69() {
            cpu.Reset();
            cpu.r1.af = 0x1589;
            cpu.r1.bc = 0x5CEB;
            cpu.r1.de = 0xB5DB;
            cpu.r1.hl = 0x922A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x3C3A;
            cpu.r1.iy = 0xDC98;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x69);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1589, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5CEB, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB5DB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x922A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x3C3A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xDCEB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD6A() {
            cpu.Reset();
            cpu.r1.af = 0x607A;
            cpu.r1.bc = 0xE035;
            cpu.r1.de = 0x5BB9;
            cpu.r1.hl = 0xDAC0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xFC04;
            cpu.r1.iy = 0xB5B7;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x6A);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x607A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE035, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5BB9, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDAC0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xFC04, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB55B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD6B() {
            cpu.Reset();
            cpu.r1.af = 0xDB2A;
            cpu.r1.bc = 0xE244;
            cpu.r1.de = 0x1182;
            cpu.r1.hl = 0x096F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x198E;
            cpu.r1.iy = 0x91A6;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x6B);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDB2A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE244, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1182, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x096F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x198E, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x9182, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD6C() {
            cpu.Reset();
            cpu.r1.af = 0xA0BE;
            cpu.r1.bc = 0x34EF;
            cpu.r1.de = 0x8FCD;
            cpu.r1.hl = 0x40A7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x4481;
            cpu.r1.iy = 0xC215;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x6C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA0BE, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x34EF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8FCD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x40A7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x4481, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC2C2, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD6D() {
            cpu.Reset();
            cpu.r1.af = 0xFDFC;
            cpu.r1.bc = 0x727A;
            cpu.r1.de = 0xB839;
            cpu.r1.hl = 0x50A6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE782;
            cpu.r1.iy = 0x02E5;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x6D);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFDFC, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x727A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB839, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x50A6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE782, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x02E5, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD6E() {
            cpu.Reset();
            cpu.r1.af = 0xCFD4;
            cpu.r1.bc = 0x6EF1;
            cpu.r1.de = 0xC07D;
            cpu.r1.hl = 0xEB96;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB0F9;
            cpu.r1.iy = 0xB0A3;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x6E);
            memory.Write8(0x0002, 0x78);
            memory.Write8(0xB11B, 0xF8);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCFD4, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6EF1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC07D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xEBF8, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB0F9, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB0A3, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD6F() {
            cpu.Reset();
            cpu.r1.af = 0x8E1D;
            cpu.r1.bc = 0xA138;
            cpu.r1.de = 0xF20A;
            cpu.r1.hl = 0x298E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB600;
            cpu.r1.iy = 0x0CF7;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x6F);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8E1D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA138, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF20A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x298E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB600, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0C8E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD70() {
            cpu.Reset();
            cpu.r1.af = 0x2677;
            cpu.r1.bc = 0x33C5;
            cpu.r1.de = 0xC0DC;
            cpu.r1.hl = 0x262F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xD3DC;
            cpu.r1.iy = 0x23A1;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x70);
            memory.Write8(0x0002, 0x53);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2677, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x33C5, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC0DC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x262F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xD3DC, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x23A1, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD71() {
            cpu.Reset();
            cpu.r1.af = 0x892E;
            cpu.r1.bc = 0x04AE;
            cpu.r1.de = 0xD67F;
            cpu.r1.hl = 0x81EC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7757;
            cpu.r1.iy = 0xBFAB;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x71);
            memory.Write8(0x0002, 0xB4);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x892E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x04AE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD67F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x81EC, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7757, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xBFAB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD72() {
            cpu.Reset();
            cpu.r1.af = 0xD2DC;
            cpu.r1.bc = 0xC23C;
            cpu.r1.de = 0xDD54;
            cpu.r1.hl = 0x6559;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB32B;
            cpu.r1.iy = 0x7C80;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x72);
            memory.Write8(0x0002, 0xE3);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD2DC, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC23C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDD54, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6559, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB32B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7C80, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD73() {
            cpu.Reset();
            cpu.r1.af = 0x49EF;
            cpu.r1.bc = 0xBFF2;
            cpu.r1.de = 0x8409;
            cpu.r1.hl = 0x02DD;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xAF95;
            cpu.r1.iy = 0x8762;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x73);
            memory.Write8(0x0002, 0x17);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x49EF, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBFF2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8409, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x02DD, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xAF95, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8762, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD74() {
            cpu.Reset();
            cpu.r1.af = 0x9479;
            cpu.r1.bc = 0x9817;
            cpu.r1.de = 0xFA2E;
            cpu.r1.hl = 0x1FE0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xA395;
            cpu.r1.iy = 0x92DB;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x74);
            memory.Write8(0x0002, 0xF6);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9479, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9817, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xFA2E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1FE0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xA395, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x92DB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD75() {
            cpu.Reset();
            cpu.r1.af = 0xC8D6;
            cpu.r1.bc = 0x6AA4;
            cpu.r1.de = 0x180E;
            cpu.r1.hl = 0xE37B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x02CF;
            cpu.r1.iy = 0x1724;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x75);
            memory.Write8(0x0002, 0xAB);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC8D6, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6AA4, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x180E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE37B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x02CF, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1724, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD77() {
            cpu.Reset();
            cpu.r1.af = 0x6F9E;
            cpu.r1.bc = 0x7475;
            cpu.r1.de = 0x78AD;
            cpu.r1.hl = 0x2B8C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC6B7;
            cpu.r1.iy = 0x6B4D;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x77);
            memory.Write8(0x0002, 0xF7);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6F9E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7475, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x78AD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2B8C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC6B7, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6B4D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD7C() {
            cpu.Reset();
            cpu.r1.af = 0xF228;
            cpu.r1.bc = 0x93FC;
            cpu.r1.de = 0xA3D4;
            cpu.r1.hl = 0xDC9E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x21AC;
            cpu.r1.iy = 0xC617;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x7C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC628, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x93FC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA3D4, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDC9E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x21AC, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC617, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD7D() {
            cpu.Reset();
            cpu.r1.af = 0x93E5;
            cpu.r1.bc = 0x3CBE;
            cpu.r1.de = 0x02C3;
            cpu.r1.hl = 0x26C2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xCA81;
            cpu.r1.iy = 0x92B9;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x7D);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB9E5, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3CBE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x02C3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x26C2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xCA81, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x92B9, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD7E() {
            cpu.Reset();
            cpu.r1.af = 0x1596;
            cpu.r1.bc = 0xDABA;
            cpu.r1.de = 0x147B;
            cpu.r1.hl = 0xF362;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7110;
            cpu.r1.iy = 0xD45F;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x7E);
            memory.Write8(0x0002, 0xE4);
            memory.Write8(0xD443, 0xAA);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAA96, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xDABA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x147B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF362, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7110, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD45F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD84() {
            cpu.Reset();
            cpu.r1.af = 0xBFBA;
            cpu.r1.bc = 0x7CAE;
            cpu.r1.de = 0xC4DA;
            cpu.r1.hl = 0x7AEE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x43EE;
            cpu.r1.iy = 0xC08E;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x84);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7F2D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7CAE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC4DA, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7AEE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x43EE, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC08E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD85() {
            cpu.Reset();
            cpu.r1.af = 0x52DD;
            cpu.r1.bc = 0x1DEA;
            cpu.r1.de = 0x324F;
            cpu.r1.hl = 0x84E7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE7A8;
            cpu.r1.iy = 0xF799;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x85);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xEBA8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1DEA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x324F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x84E7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE7A8, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xF799, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD86() {
            cpu.Reset();
            cpu.r1.af = 0xFC9C;
            cpu.r1.bc = 0xB882;
            cpu.r1.de = 0x43F9;
            cpu.r1.hl = 0x3E15;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9781;
            cpu.r1.iy = 0x8B33;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x86);
            memory.Write8(0x0002, 0xCE);
            memory.Write8(0x8B01, 0xE1);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDD89, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB882, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x43F9, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3E15, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9781, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8B33, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD8C() {
            cpu.Reset();
            cpu.r1.af = 0xFD9C;
            cpu.r1.bc = 0x42B1;
            cpu.r1.de = 0x5E8A;
            cpu.r1.hl = 0x081C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xCB58;
            cpu.r1.iy = 0x3B4E;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x8C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3839, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x42B1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5E8A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x081C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xCB58, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x3B4E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD8D() {
            cpu.Reset();
            cpu.r1.af = 0x9301;
            cpu.r1.bc = 0x7750;
            cpu.r1.de = 0x8AD6;
            cpu.r1.hl = 0x295C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x695C;
            cpu.r1.iy = 0x99FB;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x8D);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8F89, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7750, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8AD6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x295C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x695C, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x99FB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD8E() {
            cpu.Reset();
            cpu.r1.af = 0x41EE;
            cpu.r1.bc = 0x398F;
            cpu.r1.de = 0xF6DC;
            cpu.r1.hl = 0x06F3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xF34A;
            cpu.r1.iy = 0x1AA2;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x8E);
            memory.Write8(0x0002, 0x78);
            memory.Write8(0x1B1A, 0xC0);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0101, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x398F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF6DC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x06F3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xF34A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1AA2, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD94() {
            cpu.Reset();
            cpu.r1.af = 0x0431;
            cpu.r1.bc = 0xD255;
            cpu.r1.de = 0xB9D6;
            cpu.r1.hl = 0x20BB;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1E6A;
            cpu.r1.iy = 0xD5EF;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x94);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2F3B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD255, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB9D6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x20BB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1E6A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD5EF, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD95() {
            cpu.Reset();
            cpu.r1.af = 0x8B5D;
            cpu.r1.bc = 0xB455;
            cpu.r1.de = 0x2388;
            cpu.r1.hl = 0xEC1E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7637;
            cpu.r1.iy = 0xCB97;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x95);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF4A3, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB455, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2388, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xEC1E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7637, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xCB97, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD96() {
            cpu.Reset();
            cpu.r1.af = 0xA0C6;
            cpu.r1.bc = 0x22AC;
            cpu.r1.de = 0x0413;
            cpu.r1.hl = 0x4B13;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB44E;
            cpu.r1.iy = 0xC08B;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x96);
            memory.Write8(0x0002, 0x55);
            memory.Write8(0xC0E0, 0x7B);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2536, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x22AC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0413, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4B13, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB44E, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC08B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD9C() {
            cpu.Reset();
            cpu.r1.af = 0xA44A;
            cpu.r1.bc = 0x3ECF;
            cpu.r1.de = 0xCED3;
            cpu.r1.hl = 0x66EC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x4BFF;
            cpu.r1.iy = 0xB133;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x9C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF3A3, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3ECF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xCED3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x66EC, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x4BFF, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB133, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD9D() {
            cpu.Reset();
            cpu.r1.af = 0x06C0;
            cpu.r1.bc = 0x8BD0;
            cpu.r1.de = 0x131B;
            cpu.r1.hl = 0x3094;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xAFC3;
            cpu.r1.iy = 0x7409;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x9D);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFDBB, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8BD0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x131B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3094, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xAFC3, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7409, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFD9E() {
            cpu.Reset();
            cpu.r1.af = 0xB983;
            cpu.r1.bc = 0x981F;
            cpu.r1.de = 0xBB8E;
            cpu.r1.hl = 0xD6D5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5C3B;
            cpu.r1.iy = 0xF66C;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x9E);
            memory.Write8(0x0002, 0xF9);
            memory.Write8(0xF665, 0xF3);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC583, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x981F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xBB8E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD6D5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5C3B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xF66C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDA4() {
            cpu.Reset();
            cpu.r1.af = 0xB079;
            cpu.r1.bc = 0x79C0;
            cpu.r1.de = 0x2C7C;
            cpu.r1.hl = 0x3E06;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7399;
            cpu.r1.iy = 0x037A;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xA4);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0054, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x79C0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2C7C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3E06, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7399, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x037A, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDA5() {
            cpu.Reset();
            cpu.r1.af = 0x01D2;
            cpu.r1.bc = 0x654D;
            cpu.r1.de = 0x9653;
            cpu.r1.hl = 0x2B33;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x61A4;
            cpu.r1.iy = 0x8F88;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xA5);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0054, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x654D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9653, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2B33, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x61A4, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8F88, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDA6() {
            cpu.Reset();
            cpu.r1.af = 0xDDB8;
            cpu.r1.bc = 0x40BB;
            cpu.r1.de = 0x3742;
            cpu.r1.hl = 0x6FF1;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xAD28;
            cpu.r1.iy = 0x659B;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xA6);
            memory.Write8(0x0002, 0x53);
            memory.Write8(0x65EE, 0x95);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9594, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x40BB, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3742, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6FF1, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xAD28, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x659B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDAC() {
            cpu.Reset();
            cpu.r1.af = 0x7A43;
            cpu.r1.bc = 0x72E3;
            cpu.r1.de = 0xDD4D;
            cpu.r1.hl = 0x1B62;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x4753;
            cpu.r1.iy = 0x5D63;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xAC);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2724, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x72E3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDD4D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1B62, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x4753, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5D63, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDAD() {
            cpu.Reset();
            cpu.r1.af = 0x7D8E;
            cpu.r1.bc = 0x2573;
            cpu.r1.de = 0x19CC;
            cpu.r1.hl = 0x78FB;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5248;
            cpu.r1.iy = 0x8391;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xAD);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xECA8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2573, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x19CC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x78FB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5248, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8391, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDAE() {
            cpu.Reset();
            cpu.r1.af = 0xA0DA;
            cpu.r1.bc = 0xBC27;
            cpu.r1.de = 0x257B;
            cpu.r1.hl = 0x5489;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xFA59;
            cpu.r1.iy = 0x81F8;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xAE);
            memory.Write8(0x0002, 0x09);
            memory.Write8(0x8201, 0xCB);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6B28, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBC27, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x257B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5489, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xFA59, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x81F8, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDB4() {
            cpu.Reset();
            cpu.r1.af = 0x4F95;
            cpu.r1.bc = 0x3461;
            cpu.r1.de = 0xF173;
            cpu.r1.hl = 0x8AD3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC1A2;
            cpu.r1.iy = 0x8265;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xB4);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCF8C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3461, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF173, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8AD3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC1A2, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8265, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDB5() {
            cpu.Reset();
            cpu.r1.af = 0x17F6;
            cpu.r1.bc = 0xE6EA;
            cpu.r1.de = 0xF919;
            cpu.r1.hl = 0x327C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x4299;
            cpu.r1.iy = 0x9733;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xB5);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3720, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE6EA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF919, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x327C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x4299, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x9733, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDB6() {
            cpu.Reset();
            cpu.r1.af = 0xDB37;
            cpu.r1.bc = 0x3509;
            cpu.r1.de = 0xD6CA;
            cpu.r1.hl = 0xB16A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xA099;
            cpu.r1.iy = 0xDF6D;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xB6);
            memory.Write8(0x0002, 0x4B);
            memory.Write8(0xDFB8, 0x64);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFFAC, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3509, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD6CA, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB16A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xA099, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xDF6D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDBC() {
            cpu.Reset();
            cpu.r1.af = 0xB4FC;
            cpu.r1.bc = 0x9302;
            cpu.r1.de = 0xE35D;
            cpu.r1.hl = 0x31BC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5C12;
            cpu.r1.iy = 0x1C92;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xBC);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB49A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9302, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE35D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x31BC, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5C12, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1C92, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDBD() {
            cpu.Reset();
            cpu.r1.af = 0x391C;
            cpu.r1.bc = 0x7B82;
            cpu.r1.de = 0xDFEB;
            cpu.r1.hl = 0x03EE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xBE7B;
            cpu.r1.iy = 0xB30F;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xBD);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x391A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7B82, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDFEB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x03EE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xBE7B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB30F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDBE() {
            cpu.Reset();
            cpu.r1.af = 0x0970;
            cpu.r1.bc = 0x0B31;
            cpu.r1.de = 0xF4AD;
            cpu.r1.hl = 0x9D4C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB95A;
            cpu.r1.iy = 0xA96B;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xBE);
            memory.Write8(0x0002, 0x6B);
            memory.Write8(0xA9D6, 0xC0);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0903, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0B31, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF4AD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9D4C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB95A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA96B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDE1() {
            cpu.Reset();
            cpu.r1.af = 0x828E;
            cpu.r1.bc = 0x078B;
            cpu.r1.de = 0x1E35;
            cpu.r1.hl = 0x8F1C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x4827;
            cpu.r1.iy = 0xB742;
            cpu.r1.sp = 0x716E;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xE1);
            memory.Write8(0x716E, 0xD5);
            memory.Write8(0x716F, 0x92);

            while (cpu.tStates < 14) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x828E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x078B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1E35, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8F1C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x4827, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x92D5, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x7170, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(14UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDE3() {
            cpu.Reset();
            cpu.r1.af = 0x4298;
            cpu.r1.bc = 0xC805;
            cpu.r1.de = 0x6030;
            cpu.r1.hl = 0x4292;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x473B;
            cpu.r1.iy = 0x9510;
            cpu.r1.sp = 0x1A38;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xE3);
            memory.Write8(0x1A38, 0xE0);
            memory.Write8(0x1A39, 0x0F);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4298, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC805, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6030, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4292, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x473B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0FE0, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x1A38, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDE5() {
            cpu.Reset();
            cpu.r1.af = 0xD139;
            cpu.r1.bc = 0xAA0D;
            cpu.r1.de = 0xBF2B;
            cpu.r1.hl = 0x2A56;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE138;
            cpu.r1.iy = 0xD4DA;
            cpu.r1.sp = 0xA8E1;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xE5);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD139, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAA0D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xBF2B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2A56, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE138, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD4DA, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0xA8DF, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDE9() {
            cpu.Reset();
            cpu.r1.af = 0xC14F;
            cpu.r1.bc = 0x2EB6;
            cpu.r1.de = 0xEDF0;
            cpu.r1.hl = 0x27CF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x09EE;
            cpu.r1.iy = 0xA2A4;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xE9);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC14F, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2EB6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xEDF0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x27CF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x09EE, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA2A4, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDF9() {
            cpu.Reset();
            cpu.r1.af = 0xC260;
            cpu.r1.bc = 0x992E;
            cpu.r1.de = 0xD544;
            cpu.r1.hl = 0x67FB;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xBA5E;
            cpu.r1.iy = 0x3596;
            cpu.r1.sp = 0x353F;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xF9);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC260, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x992E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD544, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x67FB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xBA5E, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x3596, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x3596, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }
    }
}