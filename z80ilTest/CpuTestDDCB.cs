using Microsoft.VisualStudio.TestTools.UnitTesting;
using Z80;

namespace z80ilTest
{
    [TestClass]
    public class CpuTestDDCB
    {
        readonly Cpu cpu;
        SimpleMemory memory;

        public CpuTestDDCB() {
            memory = new SimpleMemory();
            cpu = new Cpu(memory);
        }

        [TestMethod]
        public void TestDDCB00() {
            cpu.Reset();
            cpu.r1.af = 0x3C65;
            cpu.r1.bc = 0xF0E4;
            cpu.r1.de = 0x09D1;
            cpu.r1.hl = 0x646B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1DA1;
            cpu.r1.iy = 0xF08F;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x0D);
            memory.Write8(0x0003, 0x00);
            memory.Write8(0x1DAE, 0xA1);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3C01, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x43E4, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x09D1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x646B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1DA1, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xF08F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB01() {
            cpu.Reset();
            cpu.r1.af = 0xF68F;
            cpu.r1.bc = 0xE33B;
            cpu.r1.de = 0x2D4A;
            cpu.r1.hl = 0x7725;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x28FD;
            cpu.r1.iy = 0xF31B;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xB7);
            memory.Write8(0x0003, 0x01);
            memory.Write8(0x28B4, 0xE3);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF681, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE3C7, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2D4A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7725, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x28FD, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xF31B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB02() {
            cpu.Reset();
            cpu.r1.af = 0xE20C;
            cpu.r1.bc = 0x836E;
            cpu.r1.de = 0x513A;
            cpu.r1.hl = 0xF840;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC796;
            cpu.r1.iy = 0xAE9B;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x91);
            memory.Write8(0x0003, 0x02);
            memory.Write8(0xC727, 0x8D);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE20D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x836E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1B3A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF840, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC796, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xAE9B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB03() {
            cpu.Reset();
            cpu.r1.af = 0x6224;
            cpu.r1.bc = 0x3571;
            cpu.r1.de = 0xC519;
            cpu.r1.hl = 0x48DC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x041E;
            cpu.r1.iy = 0xC07B;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x48);
            memory.Write8(0x0003, 0x03);
            memory.Write8(0x0466, 0x78);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x62A4, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3571, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC5F0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x48DC, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x041E, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC07B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB04() {
            cpu.Reset();
            cpu.r1.af = 0xB310;
            cpu.r1.bc = 0xBFC4;
            cpu.r1.de = 0x64AF;
            cpu.r1.hl = 0xD622;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5949;
            cpu.r1.iy = 0xA989;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x48);
            memory.Write8(0x0003, 0x04);
            memory.Write8(0x5991, 0x68);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB380, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBFC4, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x64AF, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD022, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5949, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA989, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB05() {
            cpu.Reset();
            cpu.r1.af = 0x4954;
            cpu.r1.bc = 0xBB04;
            cpu.r1.de = 0x56EC;
            cpu.r1.hl = 0x9D58;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0077;
            cpu.r1.iy = 0x1349;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xFF);
            memory.Write8(0x0003, 0x05);
            memory.Write8(0x0076, 0x95);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x492D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBB04, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x56EC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9D2B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0077, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1349, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB06() {
            cpu.Reset();
            cpu.r1.af = 0x0CF4;
            cpu.r1.bc = 0xF636;
            cpu.r1.de = 0x90A6;
            cpu.r1.hl = 0x6117;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5421;
            cpu.r1.iy = 0x90EE;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x07);
            memory.Write8(0x0003, 0x06);
            memory.Write8(0x5428, 0x97);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0C29, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF636, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90A6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6117, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5421, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x90EE, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB07() {
            cpu.Reset();
            cpu.r1.af = 0x6F4D;
            cpu.r1.bc = 0x9CA3;
            cpu.r1.de = 0xBDF6;
            cpu.r1.hl = 0xED50;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9803;
            cpu.r1.iy = 0x55F9;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x42);
            memory.Write8(0x0003, 0x07);
            memory.Write8(0x9845, 0xAE);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5D09, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9CA3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xBDF6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xED50, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9803, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x55F9, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB08() {
            cpu.Reset();
            cpu.r1.af = 0x02F4;
            cpu.r1.bc = 0x1C66;
            cpu.r1.de = 0x6023;
            cpu.r1.hl = 0xAE06;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xEF40;
            cpu.r1.iy = 0xB006;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x0A);
            memory.Write8(0x0003, 0x08);
            memory.Write8(0xEF4A, 0xDA);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0228, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6D66, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6023, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAE06, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xEF40, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB006, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB09() {
            cpu.Reset();
            cpu.r1.af = 0x9825;
            cpu.r1.bc = 0x9258;
            cpu.r1.de = 0x54D5;
            cpu.r1.hl = 0x5E1E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9D0B;
            cpu.r1.iy = 0x6E58;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x3B);
            memory.Write8(0x0003, 0x09);
            memory.Write8(0x9D46, 0x6F);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x98A5, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x92B7, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x54D5, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5E1E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9D0B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6E58, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB0A() {
            cpu.Reset();
            cpu.r1.af = 0xD2DD;
            cpu.r1.bc = 0x6AAC;
            cpu.r1.de = 0xE789;
            cpu.r1.hl = 0x9293;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1FB4;
            cpu.r1.iy = 0x2498;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x83);
            memory.Write8(0x0003, 0x0A);
            memory.Write8(0x1F37, 0x78);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD22C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6AAC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3C89, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9293, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1FB4, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x2498, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB0B() {
            cpu.Reset();
            cpu.r1.af = 0xB82C;
            cpu.r1.bc = 0xB284;
            cpu.r1.de = 0x23F8;
            cpu.r1.hl = 0x7E7D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xCD09;
            cpu.r1.iy = 0x6A03;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xFA);
            memory.Write8(0x0003, 0x0B);
            memory.Write8(0xCD03, 0x92);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB808, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB284, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2349, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7E7D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xCD09, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6A03, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB0C() {
            cpu.Reset();
            cpu.r1.af = 0xDF8B;
            cpu.r1.bc = 0xB6CC;
            cpu.r1.de = 0xEE8D;
            cpu.r1.hl = 0x855A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xBF6B;
            cpu.r1.iy = 0x9B7D;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x79);
            memory.Write8(0x0003, 0x0C);
            memory.Write8(0xBFE4, 0x0D);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDF81, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB6CC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xEE8D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x865A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xBF6B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x9B7D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB0D() {
            cpu.Reset();
            cpu.r1.af = 0xBAE3;
            cpu.r1.bc = 0xCEEC;
            cpu.r1.de = 0xBBAA;
            cpu.r1.hl = 0xB65E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x88BD;
            cpu.r1.iy = 0x503E;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xE4);
            memory.Write8(0x0003, 0x0D);
            memory.Write8(0x88A1, 0x1F);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xBA89, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCEEC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xBBAA, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB68F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x88BD, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x503E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB0E() {
            cpu.Reset();
            cpu.r1.af = 0x1C36;
            cpu.r1.bc = 0x890B;
            cpu.r1.de = 0x7830;
            cpu.r1.hl = 0x060C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xFD49;
            cpu.r1.iy = 0x5D07;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xC6);
            memory.Write8(0x0003, 0x0E);
            memory.Write8(0xFD0F, 0xAD);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1C81, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x890B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7830, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x060C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xFD49, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5D07, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB0F() {
            cpu.Reset();
            cpu.r1.af = 0xF5A7;
            cpu.r1.bc = 0xFAD4;
            cpu.r1.de = 0xFA4B;
            cpu.r1.hl = 0x9C53;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7447;
            cpu.r1.iy = 0x2267;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x57);
            memory.Write8(0x0003, 0x0F);
            memory.Write8(0x749E, 0xF8);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7C28, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFAD4, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xFA4B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9C53, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7447, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x2267, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB10() {
            cpu.Reset();
            cpu.r1.af = 0xF3AF;
            cpu.r1.bc = 0xBA1F;
            cpu.r1.de = 0x5387;
            cpu.r1.hl = 0x926E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xBBA2;
            cpu.r1.iy = 0xCA47;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x4F);
            memory.Write8(0x0003, 0x10);
            memory.Write8(0xBBF1, 0x45);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF38C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8B1F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5387, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x926E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xBBA2, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xCA47, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB11() {
            cpu.Reset();
            cpu.r1.af = 0x2A69;
            cpu.r1.bc = 0xD604;
            cpu.r1.de = 0xA9AA;
            cpu.r1.hl = 0x5B52;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1809;
            cpu.r1.iy = 0xD275;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xEB);
            memory.Write8(0x0003, 0x11);
            memory.Write8(0x17F4, 0xD9);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2AA1, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD6B3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA9AA, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5B52, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1809, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD275, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB12() {
            cpu.Reset();
            cpu.r1.af = 0x9287;
            cpu.r1.bc = 0xC479;
            cpu.r1.de = 0x26D1;
            cpu.r1.hl = 0x10CE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC0FB;
            cpu.r1.iy = 0x2777;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xA6);
            memory.Write8(0x0003, 0x12);
            memory.Write8(0xC0A1, 0xE2);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9285, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC479, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC5D1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x10CE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC0FB, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x2777, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB13() {
            cpu.Reset();
            cpu.r1.af = 0xA507;
            cpu.r1.bc = 0x580A;
            cpu.r1.de = 0xA48F;
            cpu.r1.hl = 0x11CD;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5AC4;
            cpu.r1.iy = 0xCCC7;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xFF);
            memory.Write8(0x0003, 0x13);
            memory.Write8(0x5AC3, 0xA7);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA509, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x580A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA44F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x11CD, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5AC4, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xCCC7, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB14() {
            cpu.Reset();
            cpu.r1.af = 0x294B;
            cpu.r1.bc = 0x5B89;
            cpu.r1.de = 0x8467;
            cpu.r1.hl = 0x0430;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0977;
            cpu.r1.iy = 0xC4E8;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xDD);
            memory.Write8(0x0003, 0x14);
            memory.Write8(0x0954, 0x85);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2909, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5B89, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8467, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0B30, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0977, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC4E8, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB15() {
            cpu.Reset();
            cpu.r1.af = 0x1FD1;
            cpu.r1.bc = 0x6D53;
            cpu.r1.de = 0x5B7C;
            cpu.r1.hl = 0xA134;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xEDE9;
            cpu.r1.iy = 0xA85C;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x07);
            memory.Write8(0x0003, 0x15);
            memory.Write8(0xEDF0, 0x0E);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1F0C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6D53, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5B7C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA11D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xEDE9, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA85C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB16() {
            cpu.Reset();
            cpu.r1.af = 0xDA70;
            cpu.r1.bc = 0xA1E4;
            cpu.r1.de = 0x00B0;
            cpu.r1.hl = 0x92C8;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x16BE;
            cpu.r1.iy = 0x2C95;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x45);
            memory.Write8(0x0003, 0x16);
            memory.Write8(0x1703, 0x5B);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDAA0, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA1E4, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x00B0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x92C8, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x16BE, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x2C95, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB17() {
            cpu.Reset();
            cpu.r1.af = 0x3300;
            cpu.r1.bc = 0xCBD1;
            cpu.r1.de = 0x4E1A;
            cpu.r1.hl = 0xCD27;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB8C9;
            cpu.r1.iy = 0xE6D4;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x1C);
            memory.Write8(0x0003, 0x17);
            memory.Write8(0xB8E5, 0x7E);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFCAC, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCBD1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4E1A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCD27, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB8C9, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE6D4, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB18() {
            cpu.Reset();
            cpu.r1.af = 0xD980;
            cpu.r1.bc = 0x4EB5;
            cpu.r1.de = 0x9CF9;
            cpu.r1.hl = 0xB9F1;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xA189;
            cpu.r1.iy = 0xBD7C;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x0E);
            memory.Write8(0x0003, 0x18);
            memory.Write8(0xA197, 0x90);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD90C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x48B5, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9CF9, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB9F1, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xA189, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xBD7C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB19() {
            cpu.Reset();
            cpu.r1.af = 0x23B7;
            cpu.r1.bc = 0x595A;
            cpu.r1.de = 0xA756;
            cpu.r1.hl = 0xCF2E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xF0E7;
            cpu.r1.iy = 0x26E4;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xA3);
            memory.Write8(0x0003, 0x19);
            memory.Write8(0xF08A, 0x37);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2389, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x599B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA756, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCF2E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xF0E7, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x26E4, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB1A() {
            cpu.Reset();
            cpu.r1.af = 0x8B52;
            cpu.r1.bc = 0x7E45;
            cpu.r1.de = 0xBD0F;
            cpu.r1.hl = 0x37A6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xDE61;
            cpu.r1.iy = 0x9CD9;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xAC);
            memory.Write8(0x0003, 0x1A);
            memory.Write8(0xDE0D, 0xCC);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8B24, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7E45, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x660F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x37A6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xDE61, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x9CD9, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB1B() {
            cpu.Reset();
            cpu.r1.af = 0x5C79;
            cpu.r1.bc = 0x1414;
            cpu.r1.de = 0x811C;
            cpu.r1.hl = 0x5881;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB7C3;
            cpu.r1.iy = 0xD14F;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x05);
            memory.Write8(0x0003, 0x1B);
            memory.Write8(0xB7C8, 0x91);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5C89, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1414, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x81C8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5881, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB7C3, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD14F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB1C() {
            cpu.Reset();
            cpu.r1.af = 0xFAFC;
            cpu.r1.bc = 0x6277;
            cpu.r1.de = 0x8B67;
            cpu.r1.hl = 0xD423;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xFEF9;
            cpu.r1.iy = 0x4A66;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xFF);
            memory.Write8(0x0003, 0x1C);
            memory.Write8(0xFEF8, 0x61);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFA25, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6277, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8B67, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3023, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xFEF9, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4A66, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB1D() {
            cpu.Reset();
            cpu.r1.af = 0x76A5;
            cpu.r1.bc = 0x324E;
            cpu.r1.de = 0xE641;
            cpu.r1.hl = 0x58F9;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5B63;
            cpu.r1.iy = 0xE18B;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x3A);
            memory.Write8(0x0003, 0x1D);
            memory.Write8(0x5B9D, 0xF3);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x76AD, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x324E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE641, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x58F9, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5B63, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE18B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB1E() {
            cpu.Reset();
            cpu.r1.af = 0xC5D9;
            cpu.r1.bc = 0xCD58;
            cpu.r1.de = 0x8967;
            cpu.r1.hl = 0xF074;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x75B4;
            cpu.r1.iy = 0x693A;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xCE);
            memory.Write8(0x0003, 0x1E);
            memory.Write8(0x7582, 0x91);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC589, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCD58, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8967, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF074, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x75B4, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x693A, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB1F() {
            cpu.Reset();
            cpu.r1.af = 0xD28F;
            cpu.r1.bc = 0x7F6D;
            cpu.r1.de = 0x2058;
            cpu.r1.hl = 0x63E3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1D9B;
            cpu.r1.iy = 0xBABA;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xA8);
            memory.Write8(0x0003, 0x1F);
            memory.Write8(0x1D43, 0xB4);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDA88, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7F6D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2058, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x63E3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1D9B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xBABA, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB20() {
            cpu.Reset();
            cpu.r1.af = 0x4CE5;
            cpu.r1.bc = 0x739E;
            cpu.r1.de = 0xDC6C;
            cpu.r1.hl = 0x18F4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xDC39;
            cpu.r1.iy = 0x8B0C;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xE8);
            memory.Write8(0x0003, 0x20);
            memory.Write8(0xDC21, 0x0E);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4C08, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1C9E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDC6C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x18F4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xDC39, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8B0C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB21() {
            cpu.Reset();
            cpu.r1.af = 0xD29D;
            cpu.r1.bc = 0x66DD;
            cpu.r1.de = 0x23EF;
            cpu.r1.hl = 0x9096;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x3494;
            cpu.r1.iy = 0xB6C3;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x9E);
            memory.Write8(0x0003, 0x21);
            memory.Write8(0x3432, 0xF7);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD2AD, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x66EE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x23EF, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9096, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x3494, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB6C3, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB22() {
            cpu.Reset();
            cpu.r1.af = 0xFB5D;
            cpu.r1.bc = 0xE0D0;
            cpu.r1.de = 0x7C02;
            cpu.r1.hl = 0xB4B7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xBD3F;
            cpu.r1.iy = 0x385B;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x43);
            memory.Write8(0x0003, 0x22);
            memory.Write8(0xBD82, 0x9F);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFB29, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE0D0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3E02, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB4B7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xBD3F, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x385B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB23() {
            cpu.Reset();
            cpu.r1.af = 0xC359;
            cpu.r1.bc = 0x68B6;
            cpu.r1.de = 0xDA84;
            cpu.r1.hl = 0xB990;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x22DD;
            cpu.r1.iy = 0xBD27;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xC1);
            memory.Write8(0x0003, 0x23);
            memory.Write8(0x229E, 0xE0);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC385, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x68B6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDAC0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB990, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x22DD, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xBD27, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB24() {
            cpu.Reset();
            cpu.r1.af = 0xBAF5;
            cpu.r1.bc = 0x7B0B;
            cpu.r1.de = 0x560B;
            cpu.r1.hl = 0x7C33;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x31F1;
            cpu.r1.iy = 0xDDBD;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xE8);
            memory.Write8(0x0003, 0x24);
            memory.Write8(0x31D9, 0xC3);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xBA81, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7B0B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x560B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8633, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x31F1, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xDDBD, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB25() {
            cpu.Reset();
            cpu.r1.af = 0x43BB;
            cpu.r1.bc = 0xA21B;
            cpu.r1.de = 0x2347;
            cpu.r1.hl = 0xAE4A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xCC63;
            cpu.r1.iy = 0xFC94;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xC1);
            memory.Write8(0x0003, 0x25);
            memory.Write8(0xCC24, 0xEB);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4381, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA21B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2347, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAED6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xCC63, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xFC94, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB26() {
            cpu.Reset();
            cpu.r1.af = 0x2065;
            cpu.r1.bc = 0xFF37;
            cpu.r1.de = 0xE41F;
            cpu.r1.hl = 0x70E7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6528;
            cpu.r1.iy = 0xA0D5;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xF7);
            memory.Write8(0x0003, 0x26);
            memory.Write8(0x651F, 0x89);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2005, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFF37, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE41F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x70E7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6528, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA0D5, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB27() {
            cpu.Reset();
            cpu.r1.af = 0xA806;
            cpu.r1.bc = 0x5669;
            cpu.r1.de = 0x1BEE;
            cpu.r1.hl = 0xF62C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1F69;
            cpu.r1.iy = 0x3418;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xC3);
            memory.Write8(0x0003, 0x27);
            memory.Write8(0x1F2C, 0xAC);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5809, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5669, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1BEE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF62C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1F69, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x3418, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB28() {
            cpu.Reset();
            cpu.r1.af = 0x7AFD;
            cpu.r1.bc = 0x64B8;
            cpu.r1.de = 0x51F7;
            cpu.r1.hl = 0x7164;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x999B;
            cpu.r1.iy = 0x8857;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xB6);
            memory.Write8(0x0003, 0x28);
            memory.Write8(0x9951, 0x24);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7A04, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x12B8, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x51F7, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7164, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x999B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8857, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB29() {
            cpu.Reset();
            cpu.r1.af = 0x0404;
            cpu.r1.bc = 0xB794;
            cpu.r1.de = 0x323F;
            cpu.r1.hl = 0xFD34;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x20E7;
            cpu.r1.iy = 0xC753;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x9C);
            memory.Write8(0x0003, 0x29);
            memory.Write8(0x2083, 0x82);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0480, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB7C1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x323F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xFD34, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x20E7, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC753, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB2A() {
            cpu.Reset();
            cpu.r1.af = 0x4524;
            cpu.r1.bc = 0xAFDE;
            cpu.r1.de = 0x0C08;
            cpu.r1.hl = 0x75D7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9505;
            cpu.r1.iy = 0xB624;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xD8);
            memory.Write8(0x0003, 0x2A);
            memory.Write8(0x94DD, 0x7C);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4528, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAFDE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3E08, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x75D7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9505, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB624, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB2B() {
            cpu.Reset();
            cpu.r1.af = 0x8324;
            cpu.r1.bc = 0xE290;
            cpu.r1.de = 0x26BE;
            cpu.r1.hl = 0x7DDD;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB484;
            cpu.r1.iy = 0x571C;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xBD);
            memory.Write8(0x0003, 0x2B);
            memory.Write8(0xB441, 0x44);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8324, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE290, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2622, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7DDD, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB484, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x571C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB2C() {
            cpu.Reset();
            cpu.r1.af = 0xC688;
            cpu.r1.bc = 0x0C94;
            cpu.r1.de = 0x6E4B;
            cpu.r1.hl = 0x7DC7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xFE28;
            cpu.r1.iy = 0xDC80;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x2C);
            memory.Write8(0x0003, 0x2C);
            memory.Write8(0xFE54, 0x81);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC685, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0C94, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6E4B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC0C7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xFE28, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xDC80, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB2D() {
            cpu.Reset();
            cpu.r1.af = 0xCE28;
            cpu.r1.bc = 0xD2AE;
            cpu.r1.de = 0xC9BE;
            cpu.r1.hl = 0x4236;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB4ED;
            cpu.r1.iy = 0x6DE3;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x9B);
            memory.Write8(0x0003, 0x2D);
            memory.Write8(0xB488, 0x44);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCE24, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD2AE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC9BE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4222, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB4ED, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6DE3, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB2E() {
            cpu.Reset();
            cpu.r1.af = 0x50B0;
            cpu.r1.bc = 0xDE74;
            cpu.r1.de = 0xECA8;
            cpu.r1.hl = 0x83FF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x69D8;
            cpu.r1.iy = 0x75C7;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x3D);
            memory.Write8(0x0003, 0x2E);
            memory.Write8(0x6A15, 0x05);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5001, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xDE74, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xECA8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x83FF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x69D8, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x75C7, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB2F() {
            cpu.Reset();
            cpu.r1.af = 0xAEC6;
            cpu.r1.bc = 0x759B;
            cpu.r1.de = 0x3059;
            cpu.r1.hl = 0x01B9;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7A30;
            cpu.r1.iy = 0xDD56;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xD3);
            memory.Write8(0x0003, 0x2F);
            memory.Write8(0x7A03, 0xF2);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF9AC, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x759B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3059, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x01B9, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7A30, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xDD56, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB30() {
            cpu.Reset();
            cpu.r1.af = 0x3C89;
            cpu.r1.bc = 0x96AD;
            cpu.r1.de = 0x9CC7;
            cpu.r1.hl = 0xA68C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xEEE8;
            cpu.r1.iy = 0x5A80;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xDF);
            memory.Write8(0x0003, 0x30);
            memory.Write8(0xEEC7, 0x32);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3C24, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x65AD, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9CC7, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA68C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xEEE8, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5A80, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB31() {
            cpu.Reset();
            cpu.r1.af = 0xEBF5;
            cpu.r1.bc = 0x41E9;
            cpu.r1.de = 0x929B;
            cpu.r1.hl = 0x7D47;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xF22D;
            cpu.r1.iy = 0x8943;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x49);
            memory.Write8(0x0003, 0x31);
            memory.Write8(0xF276, 0xCD);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xEB89, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x419B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x929B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7D47, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xF22D, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8943, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB32() {
            cpu.Reset();
            cpu.r1.af = 0x9A1B;
            cpu.r1.bc = 0xAA64;
            cpu.r1.de = 0x4209;
            cpu.r1.hl = 0x01AD;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x579F;
            cpu.r1.iy = 0xEC4C;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xE0);
            memory.Write8(0x0003, 0x32);
            memory.Write8(0x577F, 0xE2);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9A85, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAA64, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC509, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x01AD, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x579F, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xEC4C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB33() {
            cpu.Reset();
            cpu.r1.af = 0xB8B1;
            cpu.r1.bc = 0xB854;
            cpu.r1.de = 0x524F;
            cpu.r1.hl = 0x9599;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xEFAC;
            cpu.r1.iy = 0xD9EC;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xC9);
            memory.Write8(0x0003, 0x33);
            memory.Write8(0xEF75, 0x0B);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB804, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB854, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5217, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9599, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xEFAC, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD9EC, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB34() {
            cpu.Reset();
            cpu.r1.af = 0xCD3C;
            cpu.r1.bc = 0x4432;
            cpu.r1.de = 0x20D4;
            cpu.r1.hl = 0x0B3E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xAB48;
            cpu.r1.iy = 0xC95F;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x49);
            memory.Write8(0x0003, 0x34);
            memory.Write8(0xAB91, 0xEF);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCD89, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4432, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x20D4, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDF3E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xAB48, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC95F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB35() {
            cpu.Reset();
            cpu.r1.af = 0xDEB1;
            cpu.r1.bc = 0xC6FC;
            cpu.r1.de = 0x696D;
            cpu.r1.hl = 0x150D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xEB1A;
            cpu.r1.iy = 0x4A12;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xB9);
            memory.Write8(0x0003, 0x35);
            memory.Write8(0xEAD3, 0x8F);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDE09, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC6FC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x696D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x151F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xEB1A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4A12, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB36() {
            cpu.Reset();
            cpu.r1.af = 0x3D81;
            cpu.r1.bc = 0x443B;
            cpu.r1.de = 0xFF21;
            cpu.r1.hl = 0x63E3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x132E;
            cpu.r1.iy = 0xFB39;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xB4);
            memory.Write8(0x0003, 0x36);
            memory.Write8(0x12E2, 0x02);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3D04, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x443B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xFF21, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x63E3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x132E, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xFB39, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB37() {
            cpu.Reset();
            cpu.r1.af = 0x72D9;
            cpu.r1.bc = 0xBFC9;
            cpu.r1.de = 0xA69A;
            cpu.r1.hl = 0xEC0B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5077;
            cpu.r1.iy = 0x4E3E;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xC6);
            memory.Write8(0x0003, 0x37);
            memory.Write8(0x503D, 0x3D);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7B2C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBFC9, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA69A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xEC0B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5077, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4E3E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB38() {
            cpu.Reset();
            cpu.r1.af = 0x3C64;
            cpu.r1.bc = 0xB1EE;
            cpu.r1.de = 0x38E1;
            cpu.r1.hl = 0xAE9F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xF695;
            cpu.r1.iy = 0x44B3;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x8E);
            memory.Write8(0x0003, 0x38);
            memory.Write8(0xF623, 0x5E);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3C28, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2FEE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x38E1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAE9F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xF695, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x44B3, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB39() {
            cpu.Reset();
            cpu.r1.af = 0x05D6;
            cpu.r1.bc = 0x9AAD;
            cpu.r1.de = 0xA2DB;
            cpu.r1.hl = 0xDF75;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xA895;
            cpu.r1.iy = 0xE243;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xDC);
            memory.Write8(0x0003, 0x39);
            memory.Write8(0xA871, 0x83);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0505, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9A41, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA2DB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDF75, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xA895, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE243, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB3A() {
            cpu.Reset();
            cpu.r1.af = 0x0E22;
            cpu.r1.bc = 0x0B9F;
            cpu.r1.de = 0x873B;
            cpu.r1.hl = 0xC01D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x2591;
            cpu.r1.iy = 0x49C3;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x0D);
            memory.Write8(0x0003, 0x3A);
            memory.Write8(0x259E, 0x89);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0E05, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0B9F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x443B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC01D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x2591, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x49C3, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB3B() {
            cpu.Reset();
            cpu.r1.af = 0x1BD9;
            cpu.r1.bc = 0xC795;
            cpu.r1.de = 0xD8AE;
            cpu.r1.hl = 0x7CCF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6FED;
            cpu.r1.iy = 0x09DC;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x20);
            memory.Write8(0x0003, 0x3B);
            memory.Write8(0x700D, 0xA9);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1B01, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC795, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD854, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7CCF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6FED, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x09DC, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB3C() {
            cpu.Reset();
            cpu.r1.af = 0xB651;
            cpu.r1.bc = 0xBDF7;
            cpu.r1.de = 0xFCA3;
            cpu.r1.hl = 0x7529;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xF53B;
            cpu.r1.iy = 0x018B;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xE1);
            memory.Write8(0x0003, 0x3C);
            memory.Write8(0xF51C, 0xD0);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB628, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBDF7, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xFCA3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6829, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xF53B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x018B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB3D() {
            cpu.Reset();
            cpu.r1.af = 0x2A2D;
            cpu.r1.bc = 0x6E6E;
            cpu.r1.de = 0xCFBD;
            cpu.r1.hl = 0x1DB5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0320;
            cpu.r1.iy = 0x6AB0;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xBE);
            memory.Write8(0x0003, 0x3D);
            memory.Write8(0x02DE, 0x58);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2A28, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6E6E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xCFBD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1D2C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0320, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6AB0, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB3E() {
            cpu.Reset();
            cpu.r1.af = 0x39B8;
            cpu.r1.bc = 0xB26E;
            cpu.r1.de = 0xB670;
            cpu.r1.hl = 0xB8A2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x784A;
            cpu.r1.iy = 0x7840;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x0A);
            memory.Write8(0x0003, 0x3E);
            memory.Write8(0x7854, 0x5D);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x392D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB26E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB670, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB8A2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x784A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7840, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB3F() {
            cpu.Reset();
            cpu.r1.af = 0x2A17;
            cpu.r1.bc = 0x429D;
            cpu.r1.de = 0xD8C0;
            cpu.r1.hl = 0xE069;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x3488;
            cpu.r1.iy = 0x7150;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x31);
            memory.Write8(0x0003, 0x3F);
            memory.Write8(0x34B9, 0x04);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x429D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD8C0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE069, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x3488, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7150, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB40() {
            cpu.Reset();
            cpu.r1.af = 0x119B;
            cpu.r1.bc = 0xF6BA;
            cpu.r1.de = 0x079E;
            cpu.r1.hl = 0x0E41;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x8C01;
            cpu.r1.iy = 0xCD21;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xBD);
            memory.Write8(0x0003, 0x40);
            memory.Write8(0x8BBE, 0xE7);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1119, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF6BA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x079E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0E41, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x8C01, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xCD21, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB41() {
            cpu.Reset();
            cpu.r1.af = 0x22B3;
            cpu.r1.bc = 0xC4B0;
            cpu.r1.de = 0x575B;
            cpu.r1.hl = 0x66B4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xCDCF;
            cpu.r1.iy = 0xA25C;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x52);
            memory.Write8(0x0003, 0x41);
            memory.Write8(0xCE21, 0x75);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2219, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC4B0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x575B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x66B4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xCDCF, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA25C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB42() {
            cpu.Reset();
            cpu.r1.af = 0xAF5E;
            cpu.r1.bc = 0x7720;
            cpu.r1.de = 0xAA95;
            cpu.r1.hl = 0x3B0A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xF03A;
            cpu.r1.iy = 0x856A;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x1E);
            memory.Write8(0x0003, 0x42);
            memory.Write8(0xF058, 0x90);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAF74, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7720, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xAA95, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3B0A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xF03A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x856A, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB43() {
            cpu.Reset();
            cpu.r1.af = 0x7FA6;
            cpu.r1.bc = 0xB699;
            cpu.r1.de = 0x5E71;
            cpu.r1.hl = 0x1827;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE8B6;
            cpu.r1.iy = 0x96A8;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xBC);
            memory.Write8(0x0003, 0x43);
            memory.Write8(0xE872, 0x6B);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7F38, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB699, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5E71, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1827, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE8B6, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x96A8, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB44() {
            cpu.Reset();
            cpu.r1.af = 0x5FAA;
            cpu.r1.bc = 0xDE05;
            cpu.r1.de = 0x12FD;
            cpu.r1.hl = 0xF73B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xEE0A;
            cpu.r1.iy = 0x6634;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xE8);
            memory.Write8(0x0003, 0x44);
            memory.Write8(0xEDF2, 0x62);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5F7C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xDE05, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x12FD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF73B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xEE0A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6634, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB45() {
            cpu.Reset();
            cpu.r1.af = 0xEAC7;
            cpu.r1.bc = 0x699C;
            cpu.r1.de = 0x47D3;
            cpu.r1.hl = 0x89C3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xA2BE;
            cpu.r1.iy = 0xD81E;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x02);
            memory.Write8(0x0003, 0x45);
            memory.Write8(0xA2C0, 0x55);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xEA31, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x699C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x47D3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x89C3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xA2BE, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD81E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB46() {
            cpu.Reset();
            cpu.r1.af = 0x60DE;
            cpu.r1.bc = 0xAC1D;
            cpu.r1.de = 0x4173;
            cpu.r1.hl = 0xF92A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xA39F;
            cpu.r1.iy = 0x12E5;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xE2);
            memory.Write8(0x0003, 0x46);
            memory.Write8(0xA381, 0xD5);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6030, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAC1D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4173, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF92A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xA39F, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x12E5, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB47() {
            cpu.Reset();
            cpu.r1.af = 0x1B1A;
            cpu.r1.bc = 0xF7C0;
            cpu.r1.de = 0x22F6;
            cpu.r1.hl = 0x5253;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5227;
            cpu.r1.iy = 0x919D;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x7A);
            memory.Write8(0x0003, 0x47);
            memory.Write8(0x52A1, 0x6A);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1B54, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF7C0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x22F6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5253, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5227, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x919D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB48() {
            cpu.Reset();
            cpu.r1.af = 0x721A;
            cpu.r1.bc = 0x4509;
            cpu.r1.de = 0xD68F;
            cpu.r1.hl = 0x3B3D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x2746;
            cpu.r1.iy = 0x7F97;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x13);
            memory.Write8(0x0003, 0x48);
            memory.Write8(0x2759, 0xA8);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7274, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4509, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD68F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3B3D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x2746, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7F97, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB49() {
            cpu.Reset();
            cpu.r1.af = 0x7FE9;
            cpu.r1.bc = 0xDA22;
            cpu.r1.de = 0xEA9C;
            cpu.r1.hl = 0xF480;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x41C6;
            cpu.r1.iy = 0x75A9;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x94);
            memory.Write8(0x0003, 0x49);
            memory.Write8(0x415A, 0x26);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7F11, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xDA22, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xEA9C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF480, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x41C6, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x75A9, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB4A() {
            cpu.Reset();
            cpu.r1.af = 0xF16D;
            cpu.r1.bc = 0xE6C3;
            cpu.r1.de = 0x5A42;
            cpu.r1.hl = 0x8B21;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xBFEB;
            cpu.r1.iy = 0xE383;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x3B);
            memory.Write8(0x0003, 0x4A);
            memory.Write8(0xC026, 0xB5);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF155, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE6C3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5A42, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8B21, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xBFEB, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE383, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB4B() {
            cpu.Reset();
            cpu.r1.af = 0x1050;
            cpu.r1.bc = 0x880A;
            cpu.r1.de = 0x52B2;
            cpu.r1.hl = 0xFB1B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC239;
            cpu.r1.iy = 0x6B40;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xB0);
            memory.Write8(0x0003, 0x4B);
            memory.Write8(0xC1E9, 0x18);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1054, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x880A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x52B2, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xFB1B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC239, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6B40, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB4C() {
            cpu.Reset();
            cpu.r1.af = 0x0538;
            cpu.r1.bc = 0xBC63;
            cpu.r1.de = 0xF081;
            cpu.r1.hl = 0x0A55;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x874C;
            cpu.r1.iy = 0x80A3;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x97);
            memory.Write8(0x0003, 0x4C);
            memory.Write8(0x86E3, 0x63);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0510, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBC63, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF081, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0A55, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x874C, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x80A3, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB4D() {
            cpu.Reset();
            cpu.r1.af = 0x7F8C;
            cpu.r1.bc = 0x32B4;
            cpu.r1.de = 0x03D5;
            cpu.r1.hl = 0xEF66;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7D2A;
            cpu.r1.iy = 0x03BC;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x15);
            memory.Write8(0x0003, 0x4D);
            memory.Write8(0x7D3F, 0x60);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7F7C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x32B4, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x03D5, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xEF66, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7D2A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x03BC, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB4E() {
            cpu.Reset();
            cpu.r1.af = 0x7C67;
            cpu.r1.bc = 0xFA92;
            cpu.r1.de = 0xB4D0;
            cpu.r1.hl = 0x9F23;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xEADE;
            cpu.r1.iy = 0x1785;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xB0);
            memory.Write8(0x0003, 0x4E);
            memory.Write8(0xEA8E, 0x3B);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7C39, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFA92, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB4D0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9F23, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xEADE, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1785, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB4F() {
            cpu.Reset();
            cpu.r1.af = 0x725C;
            cpu.r1.bc = 0x257B;
            cpu.r1.de = 0xDB73;
            cpu.r1.hl = 0x2478;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x88C0;
            cpu.r1.iy = 0xF151;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x8B);
            memory.Write8(0x0003, 0x4F);
            memory.Write8(0x884B, 0x4C);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x725C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x257B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDB73, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2478, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x88C0, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xF151, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB50() {
            cpu.Reset();
            cpu.r1.af = 0x35F4;
            cpu.r1.bc = 0x8E51;
            cpu.r1.de = 0x406C;
            cpu.r1.hl = 0x2E3C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xDAF2;
            cpu.r1.iy = 0x413C;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x12);
            memory.Write8(0x0003, 0x50);
            memory.Write8(0xDB04, 0x00);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x355C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8E51, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x406C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2E3C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xDAF2, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x413C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB51() {
            cpu.Reset();
            cpu.r1.af = 0xA630;
            cpu.r1.bc = 0xBA85;
            cpu.r1.de = 0xC88C;
            cpu.r1.hl = 0xE86C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x84B2;
            cpu.r1.iy = 0xCD8E;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x18);
            memory.Write8(0x0003, 0x51);
            memory.Write8(0x84CA, 0x1C);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA610, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBA85, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC88C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE86C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x84B2, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xCD8E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB52() {
            cpu.Reset();
            cpu.r1.af = 0xCB88;
            cpu.r1.bc = 0x1220;
            cpu.r1.de = 0x1103;
            cpu.r1.hl = 0xA868;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6156;
            cpu.r1.iy = 0xCFAC;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x42);
            memory.Write8(0x0003, 0x52);
            memory.Write8(0x6198, 0x53);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCB74, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1220, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1103, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA868, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6156, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xCFAC, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB53() {
            cpu.Reset();
            cpu.r1.af = 0x5EB3;
            cpu.r1.bc = 0x569E;
            cpu.r1.de = 0xF76D;
            cpu.r1.hl = 0x88C6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xAE45;
            cpu.r1.iy = 0x623E;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xE3);
            memory.Write8(0x0003, 0x53);
            memory.Write8(0xAE28, 0xD6);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5E39, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x569E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF76D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x88C6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xAE45, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x623E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB54() {
            cpu.Reset();
            cpu.r1.af = 0xC3C9;
            cpu.r1.bc = 0x76FE;
            cpu.r1.de = 0xF1FF;
            cpu.r1.hl = 0x416E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xEFD5;
            cpu.r1.iy = 0x7576;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x7D);
            memory.Write8(0x0003, 0x54);
            memory.Write8(0xF052, 0x5D);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC331, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x76FE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF1FF, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x416E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xEFD5, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7576, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB55() {
            cpu.Reset();
            cpu.r1.af = 0x7068;
            cpu.r1.bc = 0xDCD0;
            cpu.r1.de = 0x8345;
            cpu.r1.hl = 0xD498;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xF352;
            cpu.r1.iy = 0xA88B;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x88);
            memory.Write8(0x0003, 0x55);
            memory.Write8(0xF2DA, 0x03);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7074, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xDCD0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8345, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD498, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xF352, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA88B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB56() {
            cpu.Reset();
            cpu.r1.af = 0x9128;
            cpu.r1.bc = 0x2CB8;
            cpu.r1.de = 0x571C;
            cpu.r1.hl = 0xF4FD;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6D30;
            cpu.r1.iy = 0xAEC2;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x57);
            memory.Write8(0x0003, 0x56);
            memory.Write8(0x6D87, 0x61);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x917C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2CB8, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x571C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF4FD, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6D30, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xAEC2, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB57() {
            cpu.Reset();
            cpu.r1.af = 0x3CA7;
            cpu.r1.bc = 0x541A;
            cpu.r1.de = 0x027C;
            cpu.r1.hl = 0xC0B4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5833;
            cpu.r1.iy = 0x160A;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x06);
            memory.Write8(0x0003, 0x57);
            memory.Write8(0x5839, 0x1D);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3C19, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x541A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x027C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC0B4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5833, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x160A, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB58() {
            cpu.Reset();
            cpu.r1.af = 0xC650;
            cpu.r1.bc = 0xE1A8;
            cpu.r1.de = 0x9D6C;
            cpu.r1.hl = 0xBEC3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6A46;
            cpu.r1.iy = 0xB66C;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x83);
            memory.Write8(0x0003, 0x58);
            memory.Write8(0x69C9, 0x0F);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC638, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE1A8, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9D6C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xBEC3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6A46, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB66C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB59() {
            cpu.Reset();
            cpu.r1.af = 0xAD07;
            cpu.r1.bc = 0x9BDA;
            cpu.r1.de = 0xB7EE;
            cpu.r1.hl = 0x63C4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9195;
            cpu.r1.iy = 0x9703;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xDB);
            memory.Write8(0x0003, 0x59);
            memory.Write8(0x9170, 0x10);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAD55, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9BDA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB7EE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x63C4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9195, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x9703, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB5A() {
            cpu.Reset();
            cpu.r1.af = 0x80C0;
            cpu.r1.bc = 0x5105;
            cpu.r1.de = 0x36B0;
            cpu.r1.hl = 0xA37C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0DE0;
            cpu.r1.iy = 0xCE7F;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xD1);
            memory.Write8(0x0003, 0x5A);
            memory.Write8(0x0DB1, 0xBE);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8018, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5105, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x36B0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA37C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0DE0, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xCE7F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB5B() {
            cpu.Reset();
            cpu.r1.af = 0x2A8D;
            cpu.r1.bc = 0x083D;
            cpu.r1.de = 0x1409;
            cpu.r1.hl = 0x06BA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x62AD;
            cpu.r1.iy = 0xBAFF;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xD5);
            memory.Write8(0x0003, 0x5B);
            memory.Write8(0x6282, 0x67);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2A75, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x083D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1409, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x06BA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x62AD, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xBAFF, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB5C() {
            cpu.Reset();
            cpu.r1.af = 0x4CA4;
            cpu.r1.bc = 0xE502;
            cpu.r1.de = 0xD23C;
            cpu.r1.hl = 0x6DA8;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9DC6;
            cpu.r1.iy = 0x6F04;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x5C);
            memory.Write8(0x0003, 0x5C);
            memory.Write8(0x9E22, 0xC9);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4C18, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE502, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD23C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6DA8, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9DC6, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6F04, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB5D() {
            cpu.Reset();
            cpu.r1.af = 0x7E39;
            cpu.r1.bc = 0x511B;
            cpu.r1.de = 0x3CFA;
            cpu.r1.hl = 0x60D3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xD193;
            cpu.r1.iy = 0x3FE9;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xFF);
            memory.Write8(0x0003, 0x5D);
            memory.Write8(0xD192, 0x0D);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7E11, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x511B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3CFA, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x60D3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xD193, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x3FE9, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB5E() {
            cpu.Reset();
            cpu.r1.af = 0xCEF1;
            cpu.r1.bc = 0x0235;
            cpu.r1.de = 0xE2B1;
            cpu.r1.hl = 0x7A4C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xED14;
            cpu.r1.iy = 0xD0D6;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x62);
            memory.Write8(0x0003, 0x5E);
            memory.Write8(0xED76, 0xA7);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCE7D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0235, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE2B1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7A4C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xED14, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD0D6, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB5F() {
            cpu.Reset();
            cpu.r1.af = 0x094F;
            cpu.r1.bc = 0x20A8;
            cpu.r1.de = 0x52E1;
            cpu.r1.hl = 0xD783;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xDF46;
            cpu.r1.iy = 0xDA41;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x3F);
            memory.Write8(0x0003, 0x5F);
            memory.Write8(0xDF85, 0x9E);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0919, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x20A8, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x52E1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD783, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xDF46, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xDA41, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB60() {
            cpu.Reset();
            cpu.r1.af = 0x42CE;
            cpu.r1.bc = 0x0713;
            cpu.r1.de = 0xDC90;
            cpu.r1.hl = 0x2C89;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x32A2;
            cpu.r1.iy = 0xC4D4;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x65);
            memory.Write8(0x0003, 0x60);
            memory.Write8(0x3307, 0x2E);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4274, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0713, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDC90, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2C89, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x32A2, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC4D4, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB61() {
            cpu.Reset();
            cpu.r1.af = 0x1B36;
            cpu.r1.bc = 0x1403;
            cpu.r1.de = 0x8B9B;
            cpu.r1.hl = 0xC221;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x36CB;
            cpu.r1.iy = 0x93D4;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xA8);
            memory.Write8(0x0003, 0x61);
            memory.Write8(0x3673, 0xBC);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1B30, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1403, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8B9B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC221, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x36CB, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x93D4, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB62() {
            cpu.Reset();
            cpu.r1.af = 0x361B;
            cpu.r1.bc = 0x4055;
            cpu.r1.de = 0x650A;
            cpu.r1.hl = 0x3F98;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0ACC;
            cpu.r1.iy = 0xA102;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xD9);
            memory.Write8(0x0003, 0x62);
            memory.Write8(0x0AA5, 0xEA);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x365D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4055, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x650A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3F98, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0ACC, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA102, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB63() {
            cpu.Reset();
            cpu.r1.af = 0x6548;
            cpu.r1.bc = 0x08DF;
            cpu.r1.de = 0x3CEB;
            cpu.r1.hl = 0x6D24;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE679;
            cpu.r1.iy = 0xF98E;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x79);
            memory.Write8(0x0003, 0x63);
            memory.Write8(0xE6F2, 0x83);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6574, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x08DF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3CEB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6D24, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE679, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xF98E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB64() {
            cpu.Reset();
            cpu.r1.af = 0x3C22;
            cpu.r1.bc = 0xE2A7;
            cpu.r1.de = 0x6DA9;
            cpu.r1.hl = 0xC346;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xECFB;
            cpu.r1.iy = 0x85B6;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x71);
            memory.Write8(0x0003, 0x64);
            memory.Write8(0xED6C, 0x52);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3C38, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE2A7, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6DA9, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC346, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xECFB, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x85B6, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB65() {
            cpu.Reset();
            cpu.r1.af = 0x09BD;
            cpu.r1.bc = 0x0ABB;
            cpu.r1.de = 0x3AFA;
            cpu.r1.hl = 0x91F5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7779;
            cpu.r1.iy = 0xAEF5;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x67);
            memory.Write8(0x0003, 0x65);
            memory.Write8(0x77E0, 0xF5);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0931, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0ABB, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3AFA, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x91F5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7779, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xAEF5, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB66() {
            cpu.Reset();
            cpu.r1.af = 0xCCBC;
            cpu.r1.bc = 0xD301;
            cpu.r1.de = 0x9B66;
            cpu.r1.hl = 0x40FB;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xEE15;
            cpu.r1.iy = 0x0D23;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x63);
            memory.Write8(0x0003, 0x66);
            memory.Write8(0xEE78, 0x70);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCC38, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD301, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9B66, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x40FB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xEE15, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0D23, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB67() {
            cpu.Reset();
            cpu.r1.af = 0xECCB;
            cpu.r1.bc = 0x342F;
            cpu.r1.de = 0xBE3E;
            cpu.r1.hl = 0xA79B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xEEA1;
            cpu.r1.iy = 0xDFAE;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xD7);
            memory.Write8(0x0003, 0x67);
            memory.Write8(0xEE78, 0x06);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xEC7D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x342F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xBE3E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA79B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xEEA1, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xDFAE, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB68() {
            cpu.Reset();
            cpu.r1.af = 0x8E51;
            cpu.r1.bc = 0x0063;
            cpu.r1.de = 0x49AD;
            cpu.r1.hl = 0xB7D4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE968;
            cpu.r1.iy = 0x864E;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xB1);
            memory.Write8(0x0003, 0x68);
            memory.Write8(0xE919, 0x20);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8E39, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0063, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x49AD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB7D4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE968, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x864E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB69() {
            cpu.Reset();
            cpu.r1.af = 0x9F11;
            cpu.r1.bc = 0x42B5;
            cpu.r1.de = 0x74FE;
            cpu.r1.hl = 0x1116;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x33F4;
            cpu.r1.iy = 0x46C2;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xE8);
            memory.Write8(0x0003, 0x69);
            memory.Write8(0x33DC, 0x4F);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9F75, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x42B5, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x74FE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1116, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x33F4, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x46C2, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB6A() {
            cpu.Reset();
            cpu.r1.af = 0x4632;
            cpu.r1.bc = 0x0BD8;
            cpu.r1.de = 0x0018;
            cpu.r1.hl = 0x1AC3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x86B6;
            cpu.r1.iy = 0x1DD2;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x33);
            memory.Write8(0x0003, 0x6A);
            memory.Write8(0x86E9, 0x1C);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4654, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0BD8, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0018, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1AC3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x86B6, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1DD2, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB6B() {
            cpu.Reset();
            cpu.r1.af = 0x7A76;
            cpu.r1.bc = 0xF79F;
            cpu.r1.de = 0xA78E;
            cpu.r1.hl = 0xF867;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x187B;
            cpu.r1.iy = 0x0023;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x11);
            memory.Write8(0x0003, 0x6B);
            memory.Write8(0x188C, 0xBC);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7A18, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF79F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA78E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF867, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x187B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0023, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB6C() {
            cpu.Reset();
            cpu.r1.af = 0xDD91;
            cpu.r1.bc = 0x1F1E;
            cpu.r1.de = 0xC1E1;
            cpu.r1.hl = 0x0EA7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x3E21;
            cpu.r1.iy = 0xF544;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x5E);
            memory.Write8(0x0003, 0x6C);
            memory.Write8(0x3E7F, 0x2A);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDD39, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1F1E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC1E1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0EA7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x3E21, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xF544, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB6D() {
            cpu.Reset();
            cpu.r1.af = 0xDEBF;
            cpu.r1.bc = 0x9AE4;
            cpu.r1.de = 0xFD24;
            cpu.r1.hl = 0xB3C2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE314;
            cpu.r1.iy = 0xAD84;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xDD);
            memory.Write8(0x0003, 0x6D);
            memory.Write8(0xE2F1, 0x41);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDE75, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9AE4, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xFD24, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB3C2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE314, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xAD84, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB6E() {
            cpu.Reset();
            cpu.r1.af = 0xCA75;
            cpu.r1.bc = 0x9F16;
            cpu.r1.de = 0xC700;
            cpu.r1.hl = 0x1DCE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x3086;
            cpu.r1.iy = 0xD68E;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xB2);
            memory.Write8(0x0003, 0x6E);
            memory.Write8(0x3038, 0x3F);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCA31, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9F16, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC700, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1DCE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x3086, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD68E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB6F() {
            cpu.Reset();
            cpu.r1.af = 0xD4CD;
            cpu.r1.bc = 0x0B39;
            cpu.r1.de = 0x3E2E;
            cpu.r1.hl = 0xC06E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xFC1B;
            cpu.r1.iy = 0xD592;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xBE);
            memory.Write8(0x0003, 0x6F);
            memory.Write8(0xFBD9, 0x56);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD47D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0B39, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3E2E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC06E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xFC1B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD592, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB70() {
            cpu.Reset();
            cpu.r1.af = 0xF901;
            cpu.r1.bc = 0x09B8;
            cpu.r1.de = 0x43F8;
            cpu.r1.hl = 0x2A76;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x042C;
            cpu.r1.iy = 0x7F2D;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xB5);
            memory.Write8(0x0003, 0x70);
            memory.Write8(0x03E1, 0x74);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF911, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x09B8, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x43F8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2A76, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x042C, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7F2D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB71() {
            cpu.Reset();
            cpu.r1.af = 0xAC78;
            cpu.r1.bc = 0x36AD;
            cpu.r1.de = 0x34CB;
            cpu.r1.hl = 0xF950;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1B33;
            cpu.r1.iy = 0xAA23;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xF7);
            memory.Write8(0x0003, 0x71);
            memory.Write8(0x1B2A, 0x08);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAC5C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x36AD, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x34CB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF950, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1B33, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xAA23, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB72() {
            cpu.Reset();
            cpu.r1.af = 0xB1B3;
            cpu.r1.bc = 0xF1E4;
            cpu.r1.de = 0x9984;
            cpu.r1.hl = 0xC7FB;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xCE25;
            cpu.r1.iy = 0xC5B6;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x22);
            memory.Write8(0x0003, 0x72);
            memory.Write8(0xCE47, 0x08);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB15D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF1E4, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9984, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC7FB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xCE25, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC5B6, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB73() {
            cpu.Reset();
            cpu.r1.af = 0x21BA;
            cpu.r1.bc = 0x592D;
            cpu.r1.de = 0xF406;
            cpu.r1.hl = 0xE21F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6442;
            cpu.r1.iy = 0xCF58;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x12);
            memory.Write8(0x0003, 0x73);
            memory.Write8(0x6454, 0x3C);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2174, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x592D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF406, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE21F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6442, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xCF58, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB74() {
            cpu.Reset();
            cpu.r1.af = 0x6642;
            cpu.r1.bc = 0x64C1;
            cpu.r1.de = 0xDBE5;
            cpu.r1.hl = 0xEB48;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7DC1;
            cpu.r1.iy = 0xC1FB;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x08);
            memory.Write8(0x0003, 0x74);
            memory.Write8(0x7DC9, 0xBE);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x667C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x64C1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDBE5, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xEB48, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7DC1, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC1FB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB75() {
            cpu.Reset();
            cpu.r1.af = 0x8778;
            cpu.r1.bc = 0x580E;
            cpu.r1.de = 0x00DD;
            cpu.r1.hl = 0xF4C6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x60AD;
            cpu.r1.iy = 0x9B60;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x5B);
            memory.Write8(0x0003, 0x75);
            memory.Write8(0x6108, 0xCF);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8730, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x580E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x00DD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF4C6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x60AD, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x9B60, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB76() {
            cpu.Reset();
            cpu.r1.af = 0x65B8;
            cpu.r1.bc = 0x5CC2;
            cpu.r1.de = 0x3058;
            cpu.r1.hl = 0xE258;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7E8A;
            cpu.r1.iy = 0xB296;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x73);
            memory.Write8(0x0003, 0x76);
            memory.Write8(0x7EFD, 0x1E);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x657C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5CC2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3058, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE258, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7E8A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB296, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB77() {
            cpu.Reset();
            cpu.r1.af = 0xE3A8;
            cpu.r1.bc = 0x47A0;
            cpu.r1.de = 0xC510;
            cpu.r1.hl = 0xCF0A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0537;
            cpu.r1.iy = 0xB242;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x7F);
            memory.Write8(0x0003, 0x77);
            memory.Write8(0x05B6, 0x97);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE354, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x47A0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC510, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCF0A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0537, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB242, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB78() {
            cpu.Reset();
            cpu.r1.af = 0x424F;
            cpu.r1.bc = 0x24F6;
            cpu.r1.de = 0x1632;
            cpu.r1.hl = 0x8A4F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9397;
            cpu.r1.iy = 0x846C;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x70);
            memory.Write8(0x0003, 0x78);
            memory.Write8(0x9407, 0x76);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4255, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x24F6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1632, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8A4F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9397, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x846C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB79() {
            cpu.Reset();
            cpu.r1.af = 0xE6A0;
            cpu.r1.bc = 0xEEAA;
            cpu.r1.de = 0x41F7;
            cpu.r1.hl = 0x5DA2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x41DE;
            cpu.r1.iy = 0x4189;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xC3);
            memory.Write8(0x0003, 0x79);
            memory.Write8(0x41A1, 0xB8);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE690, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xEEAA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x41F7, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5DA2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x41DE, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4189, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB7A() {
            cpu.Reset();
            cpu.r1.af = 0xCABF;
            cpu.r1.bc = 0x56AA;
            cpu.r1.de = 0x6A06;
            cpu.r1.hl = 0x6CD7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0AA9;
            cpu.r1.iy = 0x9812;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x3F);
            memory.Write8(0x0003, 0x7A);
            memory.Write8(0x0AE8, 0xEB);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCA99, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x56AA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6A06, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6CD7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0AA9, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x9812, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB7B() {
            cpu.Reset();
            cpu.r1.af = 0xAE3F;
            cpu.r1.bc = 0x0227;
            cpu.r1.de = 0x721F;
            cpu.r1.hl = 0x52A1;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5040;
            cpu.r1.iy = 0xB98A;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x88);
            memory.Write8(0x0003, 0x7B);
            memory.Write8(0x4FC8, 0x22);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAE5D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0227, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x721F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x52A1, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5040, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB98A, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB7C() {
            cpu.Reset();
            cpu.r1.af = 0x8A80;
            cpu.r1.bc = 0xA2F1;
            cpu.r1.de = 0x239A;
            cpu.r1.hl = 0xD5CC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6883;
            cpu.r1.iy = 0xB050;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x9E);
            memory.Write8(0x0003, 0x7C);
            memory.Write8(0x6821, 0x3A);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8A7C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA2F1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x239A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD5CC, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6883, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB050, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB7D() {
            cpu.Reset();
            cpu.r1.af = 0xC37F;
            cpu.r1.bc = 0xCF33;
            cpu.r1.de = 0x1010;
            cpu.r1.hl = 0x98E6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB021;
            cpu.r1.iy = 0x0356;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x29);
            memory.Write8(0x0003, 0x7D);
            memory.Write8(0xB04A, 0x2C);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC375, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF33, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1010, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x98E6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB021, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0356, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB7E() {
            cpu.Reset();
            cpu.r1.af = 0x9A25;
            cpu.r1.bc = 0x2F6E;
            cpu.r1.de = 0x0D0D;
            cpu.r1.hl = 0xA83F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xCEF0;
            cpu.r1.iy = 0x8C15;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x4F);
            memory.Write8(0x0003, 0x7E);
            memory.Write8(0xCF3F, 0xF2);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9A99, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2F6E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0D0D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA83F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xCEF0, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8C15, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB7F() {
            cpu.Reset();
            cpu.r1.af = 0x53B9;
            cpu.r1.bc = 0x1F4E;
            cpu.r1.de = 0x4837;
            cpu.r1.hl = 0x21B6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5EC2;
            cpu.r1.iy = 0x80C3;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x75);
            memory.Write8(0x0003, 0x7F);
            memory.Write8(0x5F37, 0xA2);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5399, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1F4E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4837, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x21B6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5EC2, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x80C3, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB80() {
            cpu.Reset();
            cpu.r1.af = 0x6319;
            cpu.r1.bc = 0xBAF9;
            cpu.r1.de = 0xC84B;
            cpu.r1.hl = 0xBCF2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xACC5;
            cpu.r1.iy = 0xA4ED;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x70);
            memory.Write8(0x0003, 0x80);
            memory.Write8(0xAD35, 0x30);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6319, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x30F9, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC84B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xBCF2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xACC5, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA4ED, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB81() {
            cpu.Reset();
            cpu.r1.af = 0xFAE1;
            cpu.r1.bc = 0x5AE5;
            cpu.r1.de = 0x9502;
            cpu.r1.hl = 0xDC9B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xBDD3;
            cpu.r1.iy = 0x1A52;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x2A);
            memory.Write8(0x0003, 0x81);
            memory.Write8(0xBDFD, 0x24);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFAE1, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5A24, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9502, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDC9B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xBDD3, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1A52, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB82() {
            cpu.Reset();
            cpu.r1.af = 0xDAF6;
            cpu.r1.bc = 0x3260;
            cpu.r1.de = 0xF1AC;
            cpu.r1.hl = 0x1D47;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5E74;
            cpu.r1.iy = 0x35E2;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x9A);
            memory.Write8(0x0003, 0x82);
            memory.Write8(0x5E0E, 0x51);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDAF6, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3260, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x50AC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1D47, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5E74, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x35E2, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB83() {
            cpu.Reset();
            cpu.r1.af = 0x8E7C;
            cpu.r1.bc = 0x5586;
            cpu.r1.de = 0x8C92;
            cpu.r1.hl = 0xFB00;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x3441;
            cpu.r1.iy = 0xD365;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x0E);
            memory.Write8(0x0003, 0x83);
            memory.Write8(0x344F, 0x01);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8E7C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5586, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8C00, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xFB00, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x3441, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD365, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB84() {
            cpu.Reset();
            cpu.r1.af = 0xC1B3;
            cpu.r1.bc = 0x4874;
            cpu.r1.de = 0xC535;
            cpu.r1.hl = 0x0E1C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0123;
            cpu.r1.iy = 0xDD28;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x47);
            memory.Write8(0x0003, 0x84);
            memory.Write8(0x016A, 0xB0);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC1B3, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4874, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC535, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB01C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0123, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xDD28, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB85() {
            cpu.Reset();
            cpu.r1.af = 0x0928;
            cpu.r1.bc = 0xB0DB;
            cpu.r1.de = 0x4E07;
            cpu.r1.hl = 0xA7B7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0BA3;
            cpu.r1.iy = 0xC61C;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x6C);
            memory.Write8(0x0003, 0x85);
            memory.Write8(0x0C0F, 0xDE);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0928, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB0DB, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4E07, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA7DE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0BA3, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC61C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB86() {
            cpu.Reset();
            cpu.r1.af = 0x4515;
            cpu.r1.bc = 0xDE09;
            cpu.r1.de = 0x3CE7;
            cpu.r1.hl = 0x1FDE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x10C5;
            cpu.r1.iy = 0x33ED;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x5C);
            memory.Write8(0x0003, 0x86);
            memory.Write8(0x1121, 0x7C);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4515, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xDE09, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3CE7, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1FDE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x10C5, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x33ED, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB87() {
            cpu.Reset();
            cpu.r1.af = 0xD05E;
            cpu.r1.bc = 0xA733;
            cpu.r1.de = 0xD1DD;
            cpu.r1.hl = 0x1603;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xEDE6;
            cpu.r1.iy = 0xE5FB;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x02);
            memory.Write8(0x0003, 0x87);
            memory.Write8(0xEDE8, 0xC4);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC45E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA733, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD1DD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1603, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xEDE6, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE5FB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB88() {
            cpu.Reset();
            cpu.r1.af = 0xE4FA;
            cpu.r1.bc = 0x3325;
            cpu.r1.de = 0xC266;
            cpu.r1.hl = 0x1B13;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x878E;
            cpu.r1.iy = 0xE695;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x9B);
            memory.Write8(0x0003, 0x88);
            memory.Write8(0x8729, 0x7C);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE4FA, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7C25, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC266, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1B13, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x878E, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE695, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB89() {
            cpu.Reset();
            cpu.r1.af = 0x933B;
            cpu.r1.bc = 0x6FDD;
            cpu.r1.de = 0xA3A8;
            cpu.r1.hl = 0x2634;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x8F3E;
            cpu.r1.iy = 0x7727;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x2B);
            memory.Write8(0x0003, 0x89);
            memory.Write8(0x8F69, 0xCF);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x933B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6FCD, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA3A8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2634, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x8F3E, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7727, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB8A() {
            cpu.Reset();
            cpu.r1.af = 0x6759;
            cpu.r1.bc = 0xAD1E;
            cpu.r1.de = 0x5D71;
            cpu.r1.hl = 0xCE52;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x39A9;
            cpu.r1.iy = 0x38A0;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x0A);
            memory.Write8(0x0003, 0x8A);
            memory.Write8(0x39B3, 0xEA);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6759, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAD1E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE871, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCE52, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x39A9, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x38A0, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB8B() {
            cpu.Reset();
            cpu.r1.af = 0x3DA2;
            cpu.r1.bc = 0x1833;
            cpu.r1.de = 0x03C1;
            cpu.r1.hl = 0x07E9;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1685;
            cpu.r1.iy = 0xD790;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x62);
            memory.Write8(0x0003, 0x8B);
            memory.Write8(0x16E7, 0x8A);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3DA2, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1833, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0388, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x07E9, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1685, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD790, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB8C() {
            cpu.Reset();
            cpu.r1.af = 0xA625;
            cpu.r1.bc = 0xED31;
            cpu.r1.de = 0x3946;
            cpu.r1.hl = 0x32DC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC6A2;
            cpu.r1.iy = 0x7AD6;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xE8);
            memory.Write8(0x0003, 0x8C);
            memory.Write8(0xC68A, 0x3E);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA625, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xED31, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3946, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3CDC, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC6A2, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7AD6, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB8D() {
            cpu.Reset();
            cpu.r1.af = 0x016B;
            cpu.r1.bc = 0x5802;
            cpu.r1.de = 0xA683;
            cpu.r1.hl = 0x2549;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x22E6;
            cpu.r1.iy = 0x33BB;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xCC);
            memory.Write8(0x0003, 0x8D);
            memory.Write8(0x22B2, 0x9E);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x016B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5802, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA683, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x259C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x22E6, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x33BB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB8E() {
            cpu.Reset();
            cpu.r1.af = 0xF4F4;
            cpu.r1.bc = 0xF3A8;
            cpu.r1.de = 0x2843;
            cpu.r1.hl = 0x82CB;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xD2E8;
            cpu.r1.iy = 0xD367;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x0A);
            memory.Write8(0x0003, 0x8E);
            memory.Write8(0xD2F2, 0x03);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF4F4, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF3A8, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2843, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x82CB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xD2E8, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD367, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB8F() {
            cpu.Reset();
            cpu.r1.af = 0x6B1A;
            cpu.r1.bc = 0x8AE2;
            cpu.r1.de = 0x269B;
            cpu.r1.hl = 0xCB2F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x3FFE;
            cpu.r1.iy = 0x75DD;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x7B);
            memory.Write8(0x0003, 0x8F);
            memory.Write8(0x4079, 0x96);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x941A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8AE2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x269B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCB2F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x3FFE, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x75DD, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB90() {
            cpu.Reset();
            cpu.r1.af = 0xC167;
            cpu.r1.bc = 0x3DFC;
            cpu.r1.de = 0x42E7;
            cpu.r1.hl = 0x9E14;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB501;
            cpu.r1.iy = 0x84FE;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x04);
            memory.Write8(0x0003, 0x90);
            memory.Write8(0xB505, 0x46);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC167, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x42FC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x42E7, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9E14, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB501, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x84FE, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB91() {
            cpu.Reset();
            cpu.r1.af = 0xE85E;
            cpu.r1.bc = 0xCC89;
            cpu.r1.de = 0xD249;
            cpu.r1.hl = 0xEA3B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC987;
            cpu.r1.iy = 0xC4D1;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x11);
            memory.Write8(0x0003, 0x91);
            memory.Write8(0xC998, 0x83);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE85E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCC83, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD249, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xEA3B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC987, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC4D1, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB92() {
            cpu.Reset();
            cpu.r1.af = 0x28A3;
            cpu.r1.bc = 0x85FF;
            cpu.r1.de = 0xAB28;
            cpu.r1.hl = 0x47A5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9166;
            cpu.r1.iy = 0xE755;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x4B);
            memory.Write8(0x0003, 0x92);
            memory.Write8(0x91B1, 0xAA);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x28A3, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x85FF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xAA28, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x47A5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9166, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE755, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB93() {
            cpu.Reset();
            cpu.r1.af = 0x58AC;
            cpu.r1.bc = 0xC88B;
            cpu.r1.de = 0x6D24;
            cpu.r1.hl = 0xDBDD;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xAC2E;
            cpu.r1.iy = 0x5199;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x03);
            memory.Write8(0x0003, 0x93);
            memory.Write8(0xAC31, 0x93);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x58AC, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC88B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6D93, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDBDD, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xAC2E, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5199, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB94() {
            cpu.Reset();
            cpu.r1.af = 0xE38D;
            cpu.r1.bc = 0x35A5;
            cpu.r1.de = 0x8D07;
            cpu.r1.hl = 0xBFB8;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5E84;
            cpu.r1.iy = 0x5F24;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x11);
            memory.Write8(0x0003, 0x94);
            memory.Write8(0x5E95, 0xB7);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE38D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x35A5, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8D07, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB3B8, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5E84, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5F24, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB95() {
            cpu.Reset();
            cpu.r1.af = 0x41F4;
            cpu.r1.bc = 0x9536;
            cpu.r1.de = 0xDD7D;
            cpu.r1.hl = 0x4948;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xFB74;
            cpu.r1.iy = 0xF17D;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xE6);
            memory.Write8(0x0003, 0x95);
            memory.Write8(0xFB5A, 0xC6);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x41F4, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9536, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDD7D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x49C2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xFB74, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xF17D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB96() {
            cpu.Reset();
            cpu.r1.af = 0x4A9E;
            cpu.r1.bc = 0x42EF;
            cpu.r1.de = 0x32D7;
            cpu.r1.hl = 0x18CF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7A81;
            cpu.r1.iy = 0xBB1D;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xD5);
            memory.Write8(0x0003, 0x96);
            memory.Write8(0x7A56, 0xAE);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4A9E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x42EF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x32D7, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x18CF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7A81, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xBB1D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB97() {
            cpu.Reset();
            cpu.r1.af = 0x9AD3;
            cpu.r1.bc = 0x89F0;
            cpu.r1.de = 0x73C7;
            cpu.r1.hl = 0x0B1A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x847C;
            cpu.r1.iy = 0x4B86;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x92);
            memory.Write8(0x0003, 0x97);
            memory.Write8(0x840E, 0x23);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x23D3, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x89F0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x73C7, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0B1A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x847C, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4B86, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB98() {
            cpu.Reset();
            cpu.r1.af = 0x6E22;
            cpu.r1.bc = 0xB9FD;
            cpu.r1.de = 0x9FDC;
            cpu.r1.hl = 0x3AED;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x041E;
            cpu.r1.iy = 0xFD79;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xDC);
            memory.Write8(0x0003, 0x98);
            memory.Write8(0x03FA, 0x58);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6E22, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x50FD, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9FDC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3AED, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x041E, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xFD79, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB99() {
            cpu.Reset();
            cpu.r1.af = 0xA132;
            cpu.r1.bc = 0x3891;
            cpu.r1.de = 0x1515;
            cpu.r1.hl = 0x2830;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x09FD;
            cpu.r1.iy = 0x0473;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x6D);
            memory.Write8(0x0003, 0x99);
            memory.Write8(0x0A6A, 0xCE);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA132, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x38C6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1515, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2830, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x09FD, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0473, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB9A() {
            cpu.Reset();
            cpu.r1.af = 0x783D;
            cpu.r1.bc = 0x8F69;
            cpu.r1.de = 0x91C4;
            cpu.r1.hl = 0xE38F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x68A8;
            cpu.r1.iy = 0x391D;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x8A);
            memory.Write8(0x0003, 0x9A);
            memory.Write8(0x6832, 0xA8);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x783D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8F69, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA0C4, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE38F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x68A8, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x391D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB9B() {
            cpu.Reset();
            cpu.r1.af = 0x955A;
            cpu.r1.bc = 0xC7B0;
            cpu.r1.de = 0x53B3;
            cpu.r1.hl = 0xAEC6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x06EF;
            cpu.r1.iy = 0xE991;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x97);
            memory.Write8(0x0003, 0x9B);
            memory.Write8(0x0686, 0x62);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x955A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC7B0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5362, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAEC6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x06EF, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE991, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB9C() {
            cpu.Reset();
            cpu.r1.af = 0xAF69;
            cpu.r1.bc = 0xF896;
            cpu.r1.de = 0xE791;
            cpu.r1.hl = 0xA2EE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x847B;
            cpu.r1.iy = 0x59ED;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x54);
            memory.Write8(0x0003, 0x9C);
            memory.Write8(0x84CF, 0x1B);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAF69, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF896, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE791, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x13EE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x847B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x59ED, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB9D() {
            cpu.Reset();
            cpu.r1.af = 0x7D1E;
            cpu.r1.bc = 0x5009;
            cpu.r1.de = 0x1248;
            cpu.r1.hl = 0x380C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE920;
            cpu.r1.iy = 0x4FE6;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x0F);
            memory.Write8(0x0003, 0x9D);
            memory.Write8(0xE92F, 0xE8);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7D1E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5009, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1248, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x38E0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE920, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4FE6, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB9E() {
            cpu.Reset();
            cpu.r1.af = 0xC207;
            cpu.r1.bc = 0xB47C;
            cpu.r1.de = 0x0E16;
            cpu.r1.hl = 0xE17F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xD8BB;
            cpu.r1.iy = 0xBB99;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xB5);
            memory.Write8(0x0003, 0x9E);
            memory.Write8(0xD870, 0xEE);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC207, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB47C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0E16, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE17F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xD8BB, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xBB99, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCB9F() {
            cpu.Reset();
            cpu.r1.af = 0xC26B;
            cpu.r1.bc = 0x7537;
            cpu.r1.de = 0x46BB;
            cpu.r1.hl = 0x13C0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE63C;
            cpu.r1.iy = 0x1D98;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xB8);
            memory.Write8(0x0003, 0x9F);
            memory.Write8(0xE5F4, 0xA6);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA66B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7537, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x46BB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x13C0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE63C, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1D98, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBA0() {
            cpu.Reset();
            cpu.r1.af = 0x0BBE;
            cpu.r1.bc = 0x8500;
            cpu.r1.de = 0x8609;
            cpu.r1.hl = 0x5352;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xA2F0;
            cpu.r1.iy = 0xDA02;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x02);
            memory.Write8(0x0003, 0xA0);
            memory.Write8(0xA2F2, 0x39);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0BBE, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2900, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8609, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5352, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xA2F0, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xDA02, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBA1() {
            cpu.Reset();
            cpu.r1.af = 0xAD0A;
            cpu.r1.bc = 0xAA76;
            cpu.r1.de = 0x0F2D;
            cpu.r1.hl = 0x832C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x45BB;
            cpu.r1.iy = 0xA22D;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xF5);
            memory.Write8(0x0003, 0xA1);
            memory.Write8(0x45B0, 0xD2);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAD0A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAAC2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0F2D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x832C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x45BB, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA22D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBA2() {
            cpu.Reset();
            cpu.r1.af = 0xF586;
            cpu.r1.bc = 0x4A7D;
            cpu.r1.de = 0xA5AB;
            cpu.r1.hl = 0x26FC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x628B;
            cpu.r1.iy = 0x6C4D;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x0E);
            memory.Write8(0x0003, 0xA2);
            memory.Write8(0x6299, 0xA1);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF586, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4A7D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA1AB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x26FC, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x628B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6C4D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBA3() {
            cpu.Reset();
            cpu.r1.af = 0xDE5B;
            cpu.r1.bc = 0xA284;
            cpu.r1.de = 0xD40E;
            cpu.r1.hl = 0xC92D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x040D;
            cpu.r1.iy = 0x12C0;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x2E);
            memory.Write8(0x0003, 0xA3);
            memory.Write8(0x043B, 0x04);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDE5B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA284, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD404, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC92D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x040D, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x12C0, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBA4() {
            cpu.Reset();
            cpu.r1.af = 0xDFAA;
            cpu.r1.bc = 0xAE40;
            cpu.r1.de = 0x02C3;
            cpu.r1.hl = 0xE0B5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xFE4D;
            cpu.r1.iy = 0xFAA3;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x03);
            memory.Write8(0x0003, 0xA4);
            memory.Write8(0xFE50, 0x27);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDFAA, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAE40, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x02C3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x27B5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xFE4D, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xFAA3, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBA5() {
            cpu.Reset();
            cpu.r1.af = 0x1A15;
            cpu.r1.bc = 0x04CB;
            cpu.r1.de = 0x4352;
            cpu.r1.hl = 0xEE39;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7B27;
            cpu.r1.iy = 0x38A0;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xF6);
            memory.Write8(0x0003, 0xA5);
            memory.Write8(0x7B1D, 0x6B);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1A15, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x04CB, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4352, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xEE6B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7B27, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x38A0, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBA6() {
            cpu.Reset();
            cpu.r1.af = 0x5E46;
            cpu.r1.bc = 0xB98A;
            cpu.r1.de = 0xB822;
            cpu.r1.hl = 0x04CA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xAE1B;
            cpu.r1.iy = 0x8730;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x27);
            memory.Write8(0x0003, 0xA6);
            memory.Write8(0xAE42, 0x8F);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5E46, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB98A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB822, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x04CA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xAE1B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8730, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBA7() {
            cpu.Reset();
            cpu.r1.af = 0x0EED;
            cpu.r1.bc = 0x7B11;
            cpu.r1.de = 0x8CB0;
            cpu.r1.hl = 0xEB3D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5EC8;
            cpu.r1.iy = 0x97CF;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xF2);
            memory.Write8(0x0003, 0xA7);
            memory.Write8(0x5EBA, 0x87);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x87ED, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7B11, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8CB0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xEB3D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5EC8, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x97CF, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBA8() {
            cpu.Reset();
            cpu.r1.af = 0x5173;
            cpu.r1.bc = 0x3089;
            cpu.r1.de = 0x070D;
            cpu.r1.hl = 0xE8F9;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE84F;
            cpu.r1.iy = 0x55F0;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xD0);
            memory.Write8(0x0003, 0xA8);
            memory.Write8(0xE81F, 0x7E);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5173, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5E89, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x070D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE8F9, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE84F, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x55F0, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBA9() {
            cpu.Reset();
            cpu.r1.af = 0x4FB8;
            cpu.r1.bc = 0xCCB5;
            cpu.r1.de = 0x3E9A;
            cpu.r1.hl = 0x2673;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0FDD;
            cpu.r1.iy = 0xAEF2;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x9D);
            memory.Write8(0x0003, 0xA9);
            memory.Write8(0x0F7A, 0x1F);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4FB8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCC1F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3E9A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2673, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0FDD, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xAEF2, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBAA() {
            cpu.Reset();
            cpu.r1.af = 0xFE76;
            cpu.r1.bc = 0x6F96;
            cpu.r1.de = 0x3FEB;
            cpu.r1.hl = 0x0B21;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6747;
            cpu.r1.iy = 0x07BA;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x9F);
            memory.Write8(0x0003, 0xAA);
            memory.Write8(0x66E6, 0x50);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFE76, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6F96, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x50EB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0B21, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6747, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x07BA, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBAB() {
            cpu.Reset();
            cpu.r1.af = 0x2EB4;
            cpu.r1.bc = 0x36F1;
            cpu.r1.de = 0x8F44;
            cpu.r1.hl = 0x36AF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6682;
            cpu.r1.iy = 0x9D60;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x16);
            memory.Write8(0x0003, 0xAB);
            memory.Write8(0x6698, 0xEB);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2EB4, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x36F1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8FCB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x36AF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6682, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x9D60, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBAC() {
            cpu.Reset();
            cpu.r1.af = 0xAF32;
            cpu.r1.bc = 0x8CA8;
            cpu.r1.de = 0x6558;
            cpu.r1.hl = 0x06D9;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xA4DD;
            cpu.r1.iy = 0xCD1F;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xC4);
            memory.Write8(0x0003, 0xAC);
            memory.Write8(0xA4A1, 0x44);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAF32, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8CA8, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6558, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x44D9, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xA4DD, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xCD1F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBAD() {
            cpu.Reset();
            cpu.r1.af = 0xFCC9;
            cpu.r1.bc = 0x69A7;
            cpu.r1.de = 0x0EED;
            cpu.r1.hl = 0xEAB5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xEEF5;
            cpu.r1.iy = 0x3ED2;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x49);
            memory.Write8(0x0003, 0xAD);
            memory.Write8(0xEF3E, 0x76);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFCC9, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x69A7, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0EED, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xEA56, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xEEF5, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x3ED2, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBAE() {
            cpu.Reset();
            cpu.r1.af = 0x5F7A;
            cpu.r1.bc = 0x9C20;
            cpu.r1.de = 0xF013;
            cpu.r1.hl = 0xC4B7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB306;
            cpu.r1.iy = 0x15DD;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x6E);
            memory.Write8(0x0003, 0xAE);
            memory.Write8(0xB374, 0x5A);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5F7A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9C20, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF013, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC4B7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB306, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x15DD, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBAF() {
            cpu.Reset();
            cpu.r1.af = 0xB11E;
            cpu.r1.bc = 0x2583;
            cpu.r1.de = 0x51FA;
            cpu.r1.hl = 0xD427;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x3619;
            cpu.r1.iy = 0x9CEF;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xC2);
            memory.Write8(0x0003, 0xAF);
            memory.Write8(0x35DB, 0x15);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x151E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2583, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x51FA, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD427, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x3619, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x9CEF, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBB0() {
            cpu.Reset();
            cpu.r1.af = 0xF43E;
            cpu.r1.bc = 0xCE57;
            cpu.r1.de = 0x3BF3;
            cpu.r1.hl = 0x0933;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x58D7;
            cpu.r1.iy = 0xD89F;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x47);
            memory.Write8(0x0003, 0xB0);
            memory.Write8(0x591E, 0x1E);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF43E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1E57, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3BF3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0933, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x58D7, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD89F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBB1() {
            cpu.Reset();
            cpu.r1.af = 0x35EF;
            cpu.r1.bc = 0xBBBC;
            cpu.r1.de = 0xDB46;
            cpu.r1.hl = 0x046C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xADD2;
            cpu.r1.iy = 0x2B6E;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x86);
            memory.Write8(0x0003, 0xB1);
            memory.Write8(0xAD58, 0x46);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x35EF, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBB06, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDB46, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x046C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xADD2, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x2B6E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBB2() {
            cpu.Reset();
            cpu.r1.af = 0xC26C;
            cpu.r1.bc = 0xFD32;
            cpu.r1.de = 0x9B7F;
            cpu.r1.hl = 0xAB6C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE7D0;
            cpu.r1.iy = 0x501F;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x70);
            memory.Write8(0x0003, 0xB2);
            memory.Write8(0xE840, 0x48);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC26C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFD32, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x087F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAB6C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE7D0, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x501F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBB3() {
            cpu.Reset();
            cpu.r1.af = 0x36CA;
            cpu.r1.bc = 0xB434;
            cpu.r1.de = 0xE212;
            cpu.r1.hl = 0xF805;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x53FB;
            cpu.r1.iy = 0xB191;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xDE);
            memory.Write8(0x0003, 0xB3);
            memory.Write8(0x53D9, 0x06);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x36CA, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB434, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE206, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF805, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x53FB, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB191, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBB4() {
            cpu.Reset();
            cpu.r1.af = 0x0A1C;
            cpu.r1.bc = 0xAB67;
            cpu.r1.de = 0x9CA1;
            cpu.r1.hl = 0x2F98;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5066;
            cpu.r1.iy = 0x320C;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x6B);
            memory.Write8(0x0003, 0xB4);
            memory.Write8(0x50D1, 0xDD);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0A1C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAB67, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9CA1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9D98, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5066, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x320C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBB5() {
            cpu.Reset();
            cpu.r1.af = 0xFD6D;
            cpu.r1.bc = 0x51C9;
            cpu.r1.de = 0x16D6;
            cpu.r1.hl = 0x1373;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x146E;
            cpu.r1.iy = 0x2148;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xEC);
            memory.Write8(0x0003, 0xB5);
            memory.Write8(0x145A, 0xD6);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFD6D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x51C9, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x16D6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1396, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x146E, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x2148, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBB6() {
            cpu.Reset();
            cpu.r1.af = 0x1D0B;
            cpu.r1.bc = 0x04E8;
            cpu.r1.de = 0x109E;
            cpu.r1.hl = 0x1DDE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x8772;
            cpu.r1.iy = 0x8661;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x15);
            memory.Write8(0x0003, 0xB6);
            memory.Write8(0x8787, 0x8C);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1D0B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x04E8, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x109E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1DDE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x8772, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8661, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBB7() {
            cpu.Reset();
            cpu.r1.af = 0xF012;
            cpu.r1.bc = 0xB87E;
            cpu.r1.de = 0x65BA;
            cpu.r1.hl = 0xA5C8;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6120;
            cpu.r1.iy = 0x789D;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xD3);
            memory.Write8(0x0003, 0xB7);
            memory.Write8(0x60F3, 0x54);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1412, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB87E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x65BA, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA5C8, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6120, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x789D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBB8() {
            cpu.Reset();
            cpu.r1.af = 0x8EAE;
            cpu.r1.bc = 0x4A53;
            cpu.r1.de = 0xBFA1;
            cpu.r1.hl = 0x5E7E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0BF6;
            cpu.r1.iy = 0x1E35;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x13);
            memory.Write8(0x0003, 0xB8);
            memory.Write8(0x0C09, 0x87);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8EAE, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0753, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xBFA1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5E7E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0BF6, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1E35, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBB9() {
            cpu.Reset();
            cpu.r1.af = 0x5FB7;
            cpu.r1.bc = 0xA81E;
            cpu.r1.de = 0xE2D2;
            cpu.r1.hl = 0x4117;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0564;
            cpu.r1.iy = 0x48A1;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x56);
            memory.Write8(0x0003, 0xB9);
            memory.Write8(0x05BA, 0xC8);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5FB7, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA848, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE2D2, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4117, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0564, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x48A1, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBBA() {
            cpu.Reset();
            cpu.r1.af = 0x7F6A;
            cpu.r1.bc = 0x47FE;
            cpu.r1.de = 0xCE45;
            cpu.r1.hl = 0x75DE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xF5E0;
            cpu.r1.iy = 0x032C;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x86);
            memory.Write8(0x0003, 0xBA);
            memory.Write8(0xF566, 0x30);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7F6A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x47FE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3045, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x75DE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xF5E0, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x032C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBBB() {
            cpu.Reset();
            cpu.r1.af = 0xC7E3;
            cpu.r1.bc = 0xE49E;
            cpu.r1.de = 0x9EC5;
            cpu.r1.hl = 0x07E7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xBD31;
            cpu.r1.iy = 0x9D5F;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xEF);
            memory.Write8(0x0003, 0xBB);
            memory.Write8(0xBD20, 0xC9);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC7E3, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE49E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9E49, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x07E7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xBD31, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x9D5F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBBC() {
            cpu.Reset();
            cpu.r1.af = 0xB430;
            cpu.r1.bc = 0x7AC7;
            cpu.r1.de = 0xB45F;
            cpu.r1.hl = 0xFBF7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x638E;
            cpu.r1.iy = 0x3173;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xC0);
            memory.Write8(0x0003, 0xBC);
            memory.Write8(0x634E, 0x28);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB430, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7AC7, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB45F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x28F7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x638E, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x3173, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBBD() {
            cpu.Reset();
            cpu.r1.af = 0x4E71;
            cpu.r1.bc = 0x6FFA;
            cpu.r1.de = 0xA3F9;
            cpu.r1.hl = 0xA2E5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE3C4;
            cpu.r1.iy = 0x02D4;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xB9);
            memory.Write8(0x0003, 0xBD);
            memory.Write8(0xE37D, 0xDD);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4E71, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6FFA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA3F9, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA25D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE3C4, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x02D4, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBBE() {
            cpu.Reset();
            cpu.r1.af = 0x4AF8;
            cpu.r1.bc = 0x99A5;
            cpu.r1.de = 0xD6FD;
            cpu.r1.hl = 0x7A16;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x58D3;
            cpu.r1.iy = 0xCE54;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x4D);
            memory.Write8(0x0003, 0xBE);
            memory.Write8(0x5920, 0xE8);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4AF8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x99A5, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD6FD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7A16, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x58D3, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xCE54, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBBF() {
            cpu.Reset();
            cpu.r1.af = 0x6E31;
            cpu.r1.bc = 0x0320;
            cpu.r1.de = 0x134B;
            cpu.r1.hl = 0x77C3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1734;
            cpu.r1.iy = 0xBC2D;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x26);
            memory.Write8(0x0003, 0xBF);
            memory.Write8(0x175A, 0xE2);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6231, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0320, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x134B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x77C3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1734, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xBC2D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBC0() {
            cpu.Reset();
            cpu.r1.af = 0x75BE;
            cpu.r1.bc = 0x2B93;
            cpu.r1.de = 0x093D;
            cpu.r1.hl = 0x1128;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x792E;
            cpu.r1.iy = 0x31F7;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x00);
            memory.Write8(0x0003, 0xC0);
            memory.Write8(0x792E, 0x92);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x75BE, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9393, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x093D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1128, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x792E, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x31F7, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBC1() {
            cpu.Reset();
            cpu.r1.af = 0x313F;
            cpu.r1.bc = 0x8223;
            cpu.r1.de = 0x5FCC;
            cpu.r1.hl = 0x42C8;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xDCCC;
            cpu.r1.iy = 0xD87B;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xF7);
            memory.Write8(0x0003, 0xC1);
            memory.Write8(0xDCC3, 0x1C);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x313F, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x821D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5FCC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x42C8, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xDCCC, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD87B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBC2() {
            cpu.Reset();
            cpu.r1.af = 0xA7E3;
            cpu.r1.bc = 0xBF55;
            cpu.r1.de = 0xD27B;
            cpu.r1.hl = 0x0A9D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0CFA;
            cpu.r1.iy = 0xEA4E;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x85);
            memory.Write8(0x0003, 0xC2);
            memory.Write8(0x0C7F, 0x30);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA7E3, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBF55, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x317B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0A9D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0CFA, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xEA4E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBC3() {
            cpu.Reset();
            cpu.r1.af = 0xE076;
            cpu.r1.bc = 0x2760;
            cpu.r1.de = 0x1EEC;
            cpu.r1.hl = 0x9968;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5426;
            cpu.r1.iy = 0xA1A0;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x32);
            memory.Write8(0x0003, 0xC3);
            memory.Write8(0x5458, 0xDD);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE076, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2760, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1EDD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9968, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5426, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA1A0, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBC4() {
            cpu.Reset();
            cpu.r1.af = 0xA679;
            cpu.r1.bc = 0xCC05;
            cpu.r1.de = 0x3F4D;
            cpu.r1.hl = 0xC899;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7ACD;
            cpu.r1.iy = 0x48D7;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xAE);
            memory.Write8(0x0003, 0xC4);
            memory.Write8(0x7A7B, 0x27);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA679, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCC05, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3F4D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2799, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7ACD, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x48D7, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBC5() {
            cpu.Reset();
            cpu.r1.af = 0xDDFD;
            cpu.r1.bc = 0x64D4;
            cpu.r1.de = 0x2671;
            cpu.r1.hl = 0x35E7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xBA99;
            cpu.r1.iy = 0xBD98;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x9C);
            memory.Write8(0x0003, 0xC5);
            memory.Write8(0xBA35, 0x20);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDDFD, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x64D4, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2671, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3521, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xBA99, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xBD98, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBC6() {
            cpu.Reset();
            cpu.r1.af = 0xB324;
            cpu.r1.bc = 0xDC0C;
            cpu.r1.de = 0x1E35;
            cpu.r1.hl = 0x8CD5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xAB2C;
            cpu.r1.iy = 0xB6F3;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xC4);
            memory.Write8(0x0003, 0xC6);
            memory.Write8(0xAAF0, 0xB8);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB324, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xDC0C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1E35, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8CD5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xAB2C, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB6F3, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBC7() {
            cpu.Reset();
            cpu.r1.af = 0xA254;
            cpu.r1.bc = 0x9E56;
            cpu.r1.de = 0x6828;
            cpu.r1.hl = 0x3189;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x64CB;
            cpu.r1.iy = 0xDFAD;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xF8);
            memory.Write8(0x0003, 0xC7);
            memory.Write8(0x64C3, 0x94);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9554, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9E56, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6828, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3189, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x64CB, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xDFAD, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBC8() {
            cpu.Reset();
            cpu.r1.af = 0x8ACA;
            cpu.r1.bc = 0x139E;
            cpu.r1.de = 0xE652;
            cpu.r1.hl = 0x248B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6E7A;
            cpu.r1.iy = 0x189A;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x65);
            memory.Write8(0x0003, 0xC8);
            memory.Write8(0x6EDF, 0x8F);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8ACA, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8F9E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE652, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x248B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6E7A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x189A, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBC9() {
            cpu.Reset();
            cpu.r1.af = 0xF15F;
            cpu.r1.bc = 0x856E;
            cpu.r1.de = 0xA21F;
            cpu.r1.hl = 0x8A59;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB670;
            cpu.r1.iy = 0x4F79;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xFB);
            memory.Write8(0x0003, 0xC9);
            memory.Write8(0xB66B, 0xB9);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF15F, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x85BB, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA21F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8A59, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB670, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4F79, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBCA() {
            cpu.Reset();
            cpu.r1.af = 0xDFAB;
            cpu.r1.bc = 0xA031;
            cpu.r1.de = 0x1D78;
            cpu.r1.hl = 0xAD3A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xA887;
            cpu.r1.iy = 0x7334;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x8A);
            memory.Write8(0x0003, 0xCA);
            memory.Write8(0xA811, 0x7E);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDFAB, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA031, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7E78, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAD3A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xA887, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7334, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBCB() {
            cpu.Reset();
            cpu.r1.af = 0xEBD6;
            cpu.r1.bc = 0x376E;
            cpu.r1.de = 0xC346;
            cpu.r1.hl = 0xB10C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xA447;
            cpu.r1.iy = 0x31D6;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xA4);
            memory.Write8(0x0003, 0xCB);
            memory.Write8(0xA3EB, 0x73);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xEBD6, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x376E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC373, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB10C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xA447, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x31D6, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBCC() {
            cpu.Reset();
            cpu.r1.af = 0x0212;
            cpu.r1.bc = 0xDC46;
            cpu.r1.de = 0x8F41;
            cpu.r1.hl = 0x854E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1F5A;
            cpu.r1.iy = 0x07CA;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x65);
            memory.Write8(0x0003, 0xCC);
            memory.Write8(0x1FBF, 0x72);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0212, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xDC46, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8F41, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x724E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1F5A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x07CA, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBCD() {
            cpu.Reset();
            cpu.r1.af = 0x3344;
            cpu.r1.bc = 0xD73C;
            cpu.r1.de = 0xD6B8;
            cpu.r1.hl = 0x929D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5376;
            cpu.r1.iy = 0x6D3A;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xE9);
            memory.Write8(0x0003, 0xCD);
            memory.Write8(0x535F, 0x1C);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3344, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD73C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD6B8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x921E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5376, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6D3A, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBCE() {
            cpu.Reset();
            cpu.r1.af = 0x9E47;
            cpu.r1.bc = 0xFC93;
            cpu.r1.de = 0x9FFC;
            cpu.r1.hl = 0xAACE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0313;
            cpu.r1.iy = 0x7F66;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x85);
            memory.Write8(0x0003, 0xCE);
            memory.Write8(0x0298, 0x10);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9E47, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFC93, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9FFC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAACE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0313, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7F66, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBCF() {
            cpu.Reset();
            cpu.r1.af = 0x53E8;
            cpu.r1.bc = 0xD379;
            cpu.r1.de = 0x87D5;
            cpu.r1.hl = 0x10B0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC5D0;
            cpu.r1.iy = 0x4F7F;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xE2);
            memory.Write8(0x0003, 0xCF);
            memory.Write8(0xC5B2, 0xB5);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB7E8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD379, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x87D5, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x10B0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC5D0, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4F7F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBD0() {
            cpu.Reset();
            cpu.r1.af = 0x3278;
            cpu.r1.bc = 0x6114;
            cpu.r1.de = 0xD25D;
            cpu.r1.hl = 0x1CF8;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xAD43;
            cpu.r1.iy = 0x99FC;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x7F);
            memory.Write8(0x0003, 0xD0);
            memory.Write8(0xADC2, 0x51);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3278, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5514, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD25D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1CF8, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xAD43, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x99FC, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBD1() {
            cpu.Reset();
            cpu.r1.af = 0xC0B8;
            cpu.r1.bc = 0x371A;
            cpu.r1.de = 0x6472;
            cpu.r1.hl = 0xD92D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x10B2;
            cpu.r1.iy = 0x3074;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xA6);
            memory.Write8(0x0003, 0xD1);
            memory.Write8(0x1058, 0x2C);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC0B8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x372C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6472, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD92D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x10B2, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x3074, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBD2() {
            cpu.Reset();
            cpu.r1.af = 0x5BB6;
            cpu.r1.bc = 0xCAA8;
            cpu.r1.de = 0xE0DB;
            cpu.r1.hl = 0xAF84;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB9A1;
            cpu.r1.iy = 0x7B5F;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x9C);
            memory.Write8(0x0003, 0xD2);
            memory.Write8(0xB93D, 0x9C);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5BB6, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCAA8, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9CDB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAF84, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB9A1, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7B5F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBD3() {
            cpu.Reset();
            cpu.r1.af = 0xDB6A;
            cpu.r1.bc = 0x4FE2;
            cpu.r1.de = 0x9E52;
            cpu.r1.hl = 0xA034;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xDA36;
            cpu.r1.iy = 0x88A0;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xBD);
            memory.Write8(0x0003, 0xD3);
            memory.Write8(0xD9F3, 0x60);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDB6A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4FE2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9E64, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA034, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xDA36, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x88A0, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBD4() {
            cpu.Reset();
            cpu.r1.af = 0xCC1C;
            cpu.r1.bc = 0xB884;
            cpu.r1.de = 0x6AD2;
            cpu.r1.hl = 0x1621;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xEF26;
            cpu.r1.iy = 0x41DE;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x58);
            memory.Write8(0x0003, 0xD4);
            memory.Write8(0xEF7E, 0x5E);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCC1C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB884, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6AD2, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5E21, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xEF26, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x41DE, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBD5() {
            cpu.Reset();
            cpu.r1.af = 0xC41D;
            cpu.r1.bc = 0xC8B0;
            cpu.r1.de = 0xCACB;
            cpu.r1.hl = 0x7687;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x8DBC;
            cpu.r1.iy = 0xCC25;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x41);
            memory.Write8(0x0003, 0xD5);
            memory.Write8(0x8DFD, 0x71);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC41D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC8B0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xCACB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7675, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x8DBC, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xCC25, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBD6() {
            cpu.Reset();
            cpu.r1.af = 0x09EB;
            cpu.r1.bc = 0x769D;
            cpu.r1.de = 0x7E07;
            cpu.r1.hl = 0x51F9;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5F03;
            cpu.r1.iy = 0x6280;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xEA);
            memory.Write8(0x0003, 0xD6);
            memory.Write8(0x5EED, 0x73);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x09EB, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x769D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7E07, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x51F9, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5F03, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6280, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBD7() {
            cpu.Reset();
            cpu.r1.af = 0x241B;
            cpu.r1.bc = 0xEE10;
            cpu.r1.de = 0xC152;
            cpu.r1.hl = 0x2F6D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE725;
            cpu.r1.iy = 0xC0D7;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x80);
            memory.Write8(0x0003, 0xD7);
            memory.Write8(0xE6A5, 0x60);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x641B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xEE10, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC152, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2F6D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE725, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC0D7, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBD8() {
            cpu.Reset();
            cpu.r1.af = 0xE3DC;
            cpu.r1.bc = 0x1981;
            cpu.r1.de = 0xC97B;
            cpu.r1.hl = 0xCB42;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB30F;
            cpu.r1.iy = 0xB32A;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x4C);
            memory.Write8(0x0003, 0xD8);
            memory.Write8(0xB35B, 0x96);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE3DC, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9E81, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC97B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCB42, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB30F, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB32A, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBD9() {
            cpu.Reset();
            cpu.r1.af = 0xE9A0;
            cpu.r1.bc = 0xA7C7;
            cpu.r1.de = 0xA476;
            cpu.r1.hl = 0x6057;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x2642;
            cpu.r1.iy = 0x58A0;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x52);
            memory.Write8(0x0003, 0xD9);
            memory.Write8(0x2694, 0xEF);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE9A0, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA7EF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA476, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6057, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x2642, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x58A0, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBDA() {
            cpu.Reset();
            cpu.r1.af = 0x6787;
            cpu.r1.bc = 0x26A7;
            cpu.r1.de = 0xA194;
            cpu.r1.hl = 0x11D3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x2D76;
            cpu.r1.iy = 0x7F80;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xEA);
            memory.Write8(0x0003, 0xDA);
            memory.Write8(0x2D60, 0x82);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6787, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x26A7, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8A94, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x11D3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x2D76, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7F80, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBDB() {
            cpu.Reset();
            cpu.r1.af = 0xF986;
            cpu.r1.bc = 0x6A4B;
            cpu.r1.de = 0x6588;
            cpu.r1.hl = 0xD2C8;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x2B7D;
            cpu.r1.iy = 0x5847;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x4D);
            memory.Write8(0x0003, 0xDB);
            memory.Write8(0x2BCA, 0x10);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF986, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6A4B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6518, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD2C8, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x2B7D, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5847, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBDC() {
            cpu.Reset();
            cpu.r1.af = 0x4C9E;
            cpu.r1.bc = 0xD94D;
            cpu.r1.de = 0x9760;
            cpu.r1.hl = 0xB707;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7ED4;
            cpu.r1.iy = 0x5CC5;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xD3);
            memory.Write8(0x0003, 0xDC);
            memory.Write8(0x7EA7, 0x45);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4C9E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD94D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9760, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4D07, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7ED4, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5CC5, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBDD() {
            cpu.Reset();
            cpu.r1.af = 0x4B3B;
            cpu.r1.bc = 0xD351;
            cpu.r1.de = 0x9BE9;
            cpu.r1.hl = 0x2310;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x58C1;
            cpu.r1.iy = 0xE430;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x6F);
            memory.Write8(0x0003, 0xDD);
            memory.Write8(0x5930, 0x20);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4B3B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD351, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9BE9, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2328, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x58C1, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE430, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBDE() {
            cpu.Reset();
            cpu.r1.af = 0x3B62;
            cpu.r1.bc = 0xCA1E;
            cpu.r1.de = 0xA41A;
            cpu.r1.hl = 0x227A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x89D2;
            cpu.r1.iy = 0x7011;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x14);
            memory.Write8(0x0003, 0xDE);
            memory.Write8(0x89E6, 0x5E);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3B62, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCA1E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA41A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x227A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x89D2, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7011, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBDF() {
            cpu.Reset();
            cpu.r1.af = 0x4C8A;
            cpu.r1.bc = 0x5B42;
            cpu.r1.de = 0x50DD;
            cpu.r1.hl = 0x4BE0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xD227;
            cpu.r1.iy = 0x4913;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xEF);
            memory.Write8(0x0003, 0xDF);
            memory.Write8(0xD216, 0x72);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7A8A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5B42, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x50DD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4BE0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xD227, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4913, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBE0() {
            cpu.Reset();
            cpu.r1.af = 0x440A;
            cpu.r1.bc = 0x713D;
            cpu.r1.de = 0xACFC;
            cpu.r1.hl = 0xF762;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1C4B;
            cpu.r1.iy = 0xB6BA;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x62);
            memory.Write8(0x0003, 0xE0);
            memory.Write8(0x1CAD, 0x46);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x440A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x563D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xACFC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF762, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1C4B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB6BA, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBE1() {
            cpu.Reset();
            cpu.r1.af = 0xC219;
            cpu.r1.bc = 0xAA6B;
            cpu.r1.de = 0xDFBF;
            cpu.r1.hl = 0x6F10;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB931;
            cpu.r1.iy = 0xD3D6;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x2E);
            memory.Write8(0x0003, 0xE1);
            memory.Write8(0xB95F, 0x75);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC219, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAA75, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDFBF, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6F10, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB931, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD3D6, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBE2() {
            cpu.Reset();
            cpu.r1.af = 0x66D7;
            cpu.r1.bc = 0xABD0;
            cpu.r1.de = 0xCB48;
            cpu.r1.hl = 0x8054;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xEF50;
            cpu.r1.iy = 0x9997;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x85);
            memory.Write8(0x0003, 0xE2);
            memory.Write8(0xEED5, 0x72);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x66D7, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xABD0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7248, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8054, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xEF50, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x9997, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBE3() {
            cpu.Reset();
            cpu.r1.af = 0x7013;
            cpu.r1.bc = 0xE7ED;
            cpu.r1.de = 0x7E1C;
            cpu.r1.hl = 0x57FB;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7EC6;
            cpu.r1.iy = 0x75EB;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xF4);
            memory.Write8(0x0003, 0xE3);
            memory.Write8(0x7EBA, 0x34);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7013, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE7ED, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7E34, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x57FB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7EC6, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x75EB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBE4() {
            cpu.Reset();
            cpu.r1.af = 0x1108;
            cpu.r1.bc = 0x6E70;
            cpu.r1.de = 0xF0AF;
            cpu.r1.hl = 0x2F0C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x95C7;
            cpu.r1.iy = 0x6501;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xBF);
            memory.Write8(0x0003, 0xE4);
            memory.Write8(0x9586, 0x34);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1108, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6E70, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF0AF, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x340C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x95C7, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6501, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBE5() {
            cpu.Reset();
            cpu.r1.af = 0x57CC;
            cpu.r1.bc = 0x5511;
            cpu.r1.de = 0x2696;
            cpu.r1.hl = 0xB83D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6AB0;
            cpu.r1.iy = 0x0E90;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xF2);
            memory.Write8(0x0003, 0xE5);
            memory.Write8(0x6AA2, 0x2E);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x57CC, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5511, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2696, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB83E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6AB0, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0E90, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBE6() {
            cpu.Reset();
            cpu.r1.af = 0x207A;
            cpu.r1.bc = 0xA441;
            cpu.r1.de = 0x1E03;
            cpu.r1.hl = 0xAC60;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xD866;
            cpu.r1.iy = 0x5FDC;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x25);
            memory.Write8(0x0003, 0xE6);
            memory.Write8(0xD88B, 0x4C);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x207A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA441, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1E03, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAC60, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xD866, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5FDC, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBE7() {
            cpu.Reset();
            cpu.r1.af = 0xC3C5;
            cpu.r1.bc = 0x7FA9;
            cpu.r1.de = 0x4E07;
            cpu.r1.hl = 0xE02D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x2A1B;
            cpu.r1.iy = 0x55B7;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xF3);
            memory.Write8(0x0003, 0xE7);
            memory.Write8(0x2A0E, 0xEB);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFBC5, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7FA9, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4E07, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE02D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x2A1B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x55B7, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBE8() {
            cpu.Reset();
            cpu.r1.af = 0x6D1C;
            cpu.r1.bc = 0xA0C4;
            cpu.r1.de = 0x93F0;
            cpu.r1.hl = 0xA0B4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x4BDA;
            cpu.r1.iy = 0x7761;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xF2);
            memory.Write8(0x0003, 0xE8);
            memory.Write8(0x4BCC, 0xBA);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6D1C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBAC4, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x93F0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA0B4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x4BDA, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7761, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBE9() {
            cpu.Reset();
            cpu.r1.af = 0xEBE5;
            cpu.r1.bc = 0x0C2C;
            cpu.r1.de = 0x1A2A;
            cpu.r1.hl = 0x2720;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x72DD;
            cpu.r1.iy = 0xA354;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x8A);
            memory.Write8(0x0003, 0xE9);
            memory.Write8(0x7267, 0x0A);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xEBE5, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0C2A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1A2A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2720, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x72DD, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA354, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBEA() {
            cpu.Reset();
            cpu.r1.af = 0x42D2;
            cpu.r1.bc = 0xDA7A;
            cpu.r1.de = 0x757F;
            cpu.r1.hl = 0x6DA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xA7E9;
            cpu.r1.iy = 0xB933;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x04);
            memory.Write8(0x0003, 0xEA);
            memory.Write8(0xA7ED, 0x5F);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x42D2, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xDA7A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7F7F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6DA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xA7E9, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB933, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBEB() {
            cpu.Reset();
            cpu.r1.af = 0xE945;
            cpu.r1.bc = 0x10AA;
            cpu.r1.de = 0xF5F8;
            cpu.r1.hl = 0x7647;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x16DF;
            cpu.r1.iy = 0x93FB;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x24);
            memory.Write8(0x0003, 0xEB);
            memory.Write8(0x1703, 0xF3);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE945, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x10AA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF5F3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7647, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x16DF, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x93FB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBEC() {
            cpu.Reset();
            cpu.r1.af = 0x7180;
            cpu.r1.bc = 0xBC85;
            cpu.r1.de = 0x7DD3;
            cpu.r1.hl = 0xF467;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xDD88;
            cpu.r1.iy = 0x6A41;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x60);
            memory.Write8(0x0003, 0xEC);
            memory.Write8(0xDDE8, 0x00);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7180, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBC85, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7DD3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2067, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xDD88, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6A41, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBED() {
            cpu.Reset();
            cpu.r1.af = 0x6B2F;
            cpu.r1.bc = 0x9762;
            cpu.r1.de = 0x1F0A;
            cpu.r1.hl = 0xDB61;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xF772;
            cpu.r1.iy = 0x33E3;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xBE);
            memory.Write8(0x0003, 0xED);
            memory.Write8(0xF730, 0x6B);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6B2F, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9762, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1F0A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDB6B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xF772, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x33E3, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBEE() {
            cpu.Reset();
            cpu.r1.af = 0x79EA;
            cpu.r1.bc = 0xDC8A;
            cpu.r1.de = 0x7887;
            cpu.r1.hl = 0x3BAA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6C28;
            cpu.r1.iy = 0xABBC;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xDE);
            memory.Write8(0x0003, 0xEE);
            memory.Write8(0x6C06, 0xBD);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x79EA, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xDC8A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7887, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3BAA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6C28, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xABBC, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBEF() {
            cpu.Reset();
            cpu.r1.af = 0x46C3;
            cpu.r1.bc = 0x2FC2;
            cpu.r1.de = 0x8690;
            cpu.r1.hl = 0xA836;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xCC68;
            cpu.r1.iy = 0xA8CE;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x30);
            memory.Write8(0x0003, 0xEF);
            memory.Write8(0xCC98, 0x11);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x31C3, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2FC2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8690, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA836, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xCC68, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA8CE, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBF0() {
            cpu.Reset();
            cpu.r1.af = 0xB330;
            cpu.r1.bc = 0x4469;
            cpu.r1.de = 0x362B;
            cpu.r1.hl = 0xB515;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x13C0;
            cpu.r1.iy = 0x6479;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x2F);
            memory.Write8(0x0003, 0xF0);
            memory.Write8(0x13EF, 0xAD);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB330, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xED69, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x362B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB515, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x13C0, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6479, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBF1() {
            cpu.Reset();
            cpu.r1.af = 0x94C0;
            cpu.r1.bc = 0x9AB0;
            cpu.r1.de = 0xA0FD;
            cpu.r1.hl = 0x7C1D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x47BA;
            cpu.r1.iy = 0x8C81;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x40);
            memory.Write8(0x0003, 0xF1);
            memory.Write8(0x47FA, 0x78);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x94C0, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9A78, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA0FD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7C1D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x47BA, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8C81, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBF2() {
            cpu.Reset();
            cpu.r1.af = 0x5302;
            cpu.r1.bc = 0x9204;
            cpu.r1.de = 0x20EC;
            cpu.r1.hl = 0xD640;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC947;
            cpu.r1.iy = 0x4EF1;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x0F);
            memory.Write8(0x0003, 0xF2);
            memory.Write8(0xC956, 0x21);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5302, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9204, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x61EC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD640, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC947, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4EF1, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBF3() {
            cpu.Reset();
            cpu.r1.af = 0x9950;
            cpu.r1.bc = 0xA3D2;
            cpu.r1.de = 0x5058;
            cpu.r1.hl = 0x5CCC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1D96;
            cpu.r1.iy = 0x7C75;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x06);
            memory.Write8(0x0003, 0xF3);
            memory.Write8(0x1D9C, 0xE4);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9950, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA3D2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x50E4, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5CCC, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1D96, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7C75, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBF4() {
            cpu.Reset();
            cpu.r1.af = 0x3712;
            cpu.r1.bc = 0x1F99;
            cpu.r1.de = 0x4863;
            cpu.r1.hl = 0x47DE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1702;
            cpu.r1.iy = 0xC042;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x3B);
            memory.Write8(0x0003, 0xF4);
            memory.Write8(0x173D, 0xE1);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3712, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1F99, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4863, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE1DE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1702, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC042, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBF5() {
            cpu.Reset();
            cpu.r1.af = 0xD83F;
            cpu.r1.bc = 0x1EC9;
            cpu.r1.de = 0xD0DA;
            cpu.r1.hl = 0x4173;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xEB3F;
            cpu.r1.iy = 0x1EAD;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x64);
            memory.Write8(0x0003, 0xF5);
            memory.Write8(0xEBA3, 0xC5);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD83F, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1EC9, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD0DA, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x41C5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xEB3F, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1EAD, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBF6() {
            cpu.Reset();
            cpu.r1.af = 0x4D6C;
            cpu.r1.bc = 0x93AC;
            cpu.r1.de = 0x810D;
            cpu.r1.hl = 0xCFE1;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xDC5A;
            cpu.r1.iy = 0xC33C;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x7B);
            memory.Write8(0x0003, 0xF6);
            memory.Write8(0xDCD5, 0xA2);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4D6C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x93AC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x810D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCFE1, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xDC5A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC33C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBF7() {
            cpu.Reset();
            cpu.r1.af = 0xFE40;
            cpu.r1.bc = 0x7887;
            cpu.r1.de = 0xB9DE;
            cpu.r1.hl = 0xC013;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x301E;
            cpu.r1.iy = 0x9710;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xC3);
            memory.Write8(0x0003, 0xF7);
            memory.Write8(0x2FE1, 0xA9);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE940, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7887, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB9DE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC013, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x301E, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x9710, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBF8() {
            cpu.Reset();
            cpu.r1.af = 0x8278;
            cpu.r1.bc = 0x21A4;
            cpu.r1.de = 0x1E5C;
            cpu.r1.hl = 0x4952;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x427F;
            cpu.r1.iy = 0x41E1;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x59);
            memory.Write8(0x0003, 0xF8);
            memory.Write8(0x42D8, 0x28);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8278, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA8A4, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1E5C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4952, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x427F, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x41E1, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBF9() {
            cpu.Reset();
            cpu.r1.af = 0xB2DF;
            cpu.r1.bc = 0xE9B8;
            cpu.r1.de = 0x56C3;
            cpu.r1.hl = 0x16FF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xD88F;
            cpu.r1.iy = 0x0BAB;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x55);
            memory.Write8(0x0003, 0xF9);
            memory.Write8(0xD8E4, 0x14);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB2DF, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE994, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x56C3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x16FF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xD88F, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0BAB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBFA() {
            cpu.Reset();
            cpu.r1.af = 0x01F1;
            cpu.r1.bc = 0xBC0D;
            cpu.r1.de = 0xD476;
            cpu.r1.hl = 0x1510;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9420;
            cpu.r1.iy = 0x93A3;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x74);
            memory.Write8(0x0003, 0xFA);
            memory.Write8(0x9494, 0xFE);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x01F1, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBC0D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xFE76, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1510, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9420, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x93A3, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBFB() {
            cpu.Reset();
            cpu.r1.af = 0x709B;
            cpu.r1.bc = 0x14EB;
            cpu.r1.de = 0xEC1C;
            cpu.r1.hl = 0xB844;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x3453;
            cpu.r1.iy = 0xF2B0;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xAF);
            memory.Write8(0x0003, 0xFB);
            memory.Write8(0x3402, 0x02);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x709B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x14EB, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xEC82, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB844, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x3453, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xF2B0, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBFC() {
            cpu.Reset();
            cpu.r1.af = 0x6C89;
            cpu.r1.bc = 0xA96E;
            cpu.r1.de = 0xD27B;
            cpu.r1.hl = 0xD6A7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6139;
            cpu.r1.iy = 0xB4C1;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xA1);
            memory.Write8(0x0003, 0xFC);
            memory.Write8(0x60DA, 0x10);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6C89, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA96E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD27B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x90A7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6139, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB4C1, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBFD() {
            cpu.Reset();
            cpu.r1.af = 0xFB3F;
            cpu.r1.bc = 0x83F6;
            cpu.r1.de = 0x2094;
            cpu.r1.hl = 0x3349;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x3ED0;
            cpu.r1.iy = 0x6F0E;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x28);
            memory.Write8(0x0003, 0xFD);
            memory.Write8(0x3EF8, 0xC2);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFB3F, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x83F6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2094, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x33C2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x3ED0, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6F0E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBFE() {
            cpu.Reset();
            cpu.r1.af = 0xFC42;
            cpu.r1.bc = 0x50B7;
            cpu.r1.de = 0xE98D;
            cpu.r1.hl = 0x3E45;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x41B5;
            cpu.r1.iy = 0x3410;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xEC);
            memory.Write8(0x0003, 0xFE);
            memory.Write8(0x41A1, 0xA1);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFC42, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x50B7, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE98D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3E45, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x41B5, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x3410, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDCBFF() {
            cpu.Reset();
            cpu.r1.af = 0xE666;
            cpu.r1.bc = 0x94D2;
            cpu.r1.de = 0xAC90;
            cpu.r1.hl = 0x8F45;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0655;
            cpu.r1.iy = 0xBA29;
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xD3);
            memory.Write8(0x0003, 0xFF);
            memory.Write8(0x0628, 0x2B);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAB66, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x94D2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xAC90, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8F45, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0655, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xBA29, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }
    }
}