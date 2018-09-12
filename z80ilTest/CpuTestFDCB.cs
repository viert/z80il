using Microsoft.VisualStudio.TestTools.UnitTesting;
using Z80;

namespace z80ilTest
{
    [TestClass]
    public class CpuTestFDCB
    {
        readonly Cpu cpu;
        SimpleMemory memory;

        public CpuTestFDCB() {
            memory = new SimpleMemory();
            cpu = new Cpu(memory);
        }

        [TestMethod]
        public void TestFDCB00() {
            cpu.Reset();
            cpu.r1.af = 0x85AC;
            cpu.r1.bc = 0x46D0;
            cpu.r1.de = 0xA135;
            cpu.r1.hl = 0x20C5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB8DE;
            cpu.r1.iy = 0x2776;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x0B);
            memory.Write8(0x0003, 0x00);
            memory.Write8(0x2781, 0x50);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x85A4, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA0D0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA135, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x20C5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB8DE, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x2776, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB01() {
            cpu.Reset();
            cpu.r1.af = 0x577C;
            cpu.r1.bc = 0x2B76;
            cpu.r1.de = 0x3576;
            cpu.r1.hl = 0x280A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xAE22;
            cpu.r1.iy = 0x5C35;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xC8);
            memory.Write8(0x0003, 0x01);
            memory.Write8(0x5BFD, 0xCB);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5781, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2B97, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3576, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x280A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xAE22, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5C35, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB02() {
            cpu.Reset();
            cpu.r1.af = 0xDC23;
            cpu.r1.bc = 0x2B37;
            cpu.r1.de = 0x83C8;
            cpu.r1.hl = 0x5DD9;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB2D2;
            cpu.r1.iy = 0x3DF2;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x14);
            memory.Write8(0x0003, 0x02);
            memory.Write8(0x3E06, 0x58);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDCA0, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2B37, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB0C8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5DD9, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB2D2, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x3DF2, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB03() {
            cpu.Reset();
            cpu.r1.af = 0x57EE;
            cpu.r1.bc = 0xC179;
            cpu.r1.de = 0xB2B6;
            cpu.r1.hl = 0x7058;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x3F2E;
            cpu.r1.iy = 0x57E7;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x3A);
            memory.Write8(0x0003, 0x03);
            memory.Write8(0x5821, 0x1A);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5720, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC179, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB234, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7058, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x3F2E, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x57E7, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB04() {
            cpu.Reset();
            cpu.r1.af = 0xED18;
            cpu.r1.bc = 0x3F03;
            cpu.r1.de = 0x3327;
            cpu.r1.hl = 0xF35A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xCBF2;
            cpu.r1.iy = 0x5071;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x67);
            memory.Write8(0x0003, 0x04);
            memory.Write8(0x50D8, 0x92);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xED21, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3F03, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3327, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x255A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xCBF2, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5071, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB05() {
            cpu.Reset();
            cpu.r1.af = 0x7A39;
            cpu.r1.bc = 0x0858;
            cpu.r1.de = 0xDB6C;
            cpu.r1.hl = 0xDBE0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x157A;
            cpu.r1.iy = 0xB25B;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x1E);
            memory.Write8(0x0003, 0x05);
            memory.Write8(0xB279, 0x66);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7A8C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0858, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDB6C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDBCC, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x157A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB25B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB06() {
            cpu.Reset();
            cpu.r1.af = 0xF285;
            cpu.r1.bc = 0x89A2;
            cpu.r1.de = 0xE78F;
            cpu.r1.hl = 0xEF74;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x140D;
            cpu.r1.iy = 0xFF27;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x72);
            memory.Write8(0x0003, 0x06);
            memory.Write8(0xFF99, 0xF1);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF2A1, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x89A2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE78F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xEF74, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x140D, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xFF27, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB07() {
            cpu.Reset();
            cpu.r1.af = 0x8CCE;
            cpu.r1.bc = 0xF3A7;
            cpu.r1.de = 0x3A6E;
            cpu.r1.hl = 0x8F0A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x8423;
            cpu.r1.iy = 0x07EB;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x24);
            memory.Write8(0x0003, 0x07);
            memory.Write8(0x080F, 0xAE);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5D09, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF3A7, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3A6E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8F0A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x8423, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x07EB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB08() {
            cpu.Reset();
            cpu.r1.af = 0xA611;
            cpu.r1.bc = 0xE8EC;
            cpu.r1.de = 0xC958;
            cpu.r1.hl = 0x7BDA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x194D;
            cpu.r1.iy = 0x6137;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x25);
            memory.Write8(0x0003, 0x08);
            memory.Write8(0x615C, 0x83);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA681, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC1EC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC958, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7BDA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x194D, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6137, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB09() {
            cpu.Reset();
            cpu.r1.af = 0x54B1;
            cpu.r1.bc = 0xFA1A;
            cpu.r1.de = 0x84E8;
            cpu.r1.hl = 0x4FA5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1AD3;
            cpu.r1.iy = 0x19DA;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xA0);
            memory.Write8(0x0003, 0x09);
            memory.Write8(0x197A, 0x27);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5485, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFA93, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x84E8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4FA5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1AD3, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x19DA, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB0A() {
            cpu.Reset();
            cpu.r1.af = 0xB3EF;
            cpu.r1.bc = 0xA2BB;
            cpu.r1.de = 0xE5D6;
            cpu.r1.hl = 0x9617;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xF946;
            cpu.r1.iy = 0xEEF6;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xE1);
            memory.Write8(0x0003, 0x0A);
            memory.Write8(0xEED7, 0x19);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB389, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA2BB, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8CD6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9617, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xF946, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xEEF6, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB0B() {
            cpu.Reset();
            cpu.r1.af = 0xAE10;
            cpu.r1.bc = 0x8C4E;
            cpu.r1.de = 0xE159;
            cpu.r1.hl = 0x1C54;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE108;
            cpu.r1.iy = 0xC68F;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x0C);
            memory.Write8(0x0003, 0x0B);
            memory.Write8(0xC69B, 0xF2);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAE28, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8C4E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE179, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1C54, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE108, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC68F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB0C() {
            cpu.Reset();
            cpu.r1.af = 0x8719;
            cpu.r1.bc = 0x6B16;
            cpu.r1.de = 0x4C3B;
            cpu.r1.hl = 0x180A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x175A;
            cpu.r1.iy = 0x8C9D;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xD7);
            memory.Write8(0x0003, 0x0C);
            memory.Write8(0x8C74, 0xAE);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8700, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6B16, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4C3B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x570A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x175A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8C9D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB0D() {
            cpu.Reset();
            cpu.r1.af = 0x1204;
            cpu.r1.bc = 0xE0CB;
            cpu.r1.de = 0x3AB1;
            cpu.r1.hl = 0x2416;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1DE4;
            cpu.r1.iy = 0xFE2D;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x11);
            memory.Write8(0x0003, 0x0D);
            memory.Write8(0xFE3E, 0x1B);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x128D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE0CB, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3AB1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x248D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1DE4, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xFE2D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB0E() {
            cpu.Reset();
            cpu.r1.af = 0x8DA4;
            cpu.r1.bc = 0x8F91;
            cpu.r1.de = 0xFC5A;
            cpu.r1.hl = 0x5E2C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB2F2;
            cpu.r1.iy = 0xF223;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x0C);
            memory.Write8(0x0003, 0x0E);
            memory.Write8(0xF22F, 0xF7);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8DA9, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8F91, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xFC5A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5E2C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB2F2, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xF223, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB0F() {
            cpu.Reset();
            cpu.r1.af = 0xFBB0;
            cpu.r1.bc = 0x2AC9;
            cpu.r1.de = 0xEC6B;
            cpu.r1.hl = 0x6511;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC93A;
            cpu.r1.iy = 0xCE38;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x15);
            memory.Write8(0x0003, 0x0F);
            memory.Write8(0xCE4D, 0x44);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2224, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2AC9, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xEC6B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6511, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC93A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xCE38, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB10() {
            cpu.Reset();
            cpu.r1.af = 0x259D;
            cpu.r1.bc = 0x3852;
            cpu.r1.de = 0x590D;
            cpu.r1.hl = 0xAC66;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x144F;
            cpu.r1.iy = 0x42A2;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x7A);
            memory.Write8(0x0003, 0x10);
            memory.Write8(0x431C, 0x1C);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x252C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3952, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x590D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAC66, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x144F, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x42A2, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB11() {
            cpu.Reset();
            cpu.r1.af = 0xBC60;
            cpu.r1.bc = 0x61C1;
            cpu.r1.de = 0xF5F8;
            cpu.r1.hl = 0xAF24;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x4019;
            cpu.r1.iy = 0x9C90;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x7B);
            memory.Write8(0x0003, 0x11);
            memory.Write8(0x9D0B, 0x5E);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xBCA8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x61BC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF5F8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAF24, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x4019, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x9C90, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB12() {
            cpu.Reset();
            cpu.r1.af = 0x4E45;
            cpu.r1.bc = 0x3A25;
            cpu.r1.de = 0x3417;
            cpu.r1.hl = 0xBCC7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0D7E;
            cpu.r1.iy = 0x8537;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x61);
            memory.Write8(0x0003, 0x12);
            memory.Write8(0x8598, 0xA7);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4E09, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3A25, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4F17, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xBCC7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0D7E, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8537, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB13() {
            cpu.Reset();
            cpu.r1.af = 0xB224;
            cpu.r1.bc = 0xB79B;
            cpu.r1.de = 0x84F1;
            cpu.r1.hl = 0xFF7D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x414C;
            cpu.r1.iy = 0xE798;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xB3);
            memory.Write8(0x0003, 0x13);
            memory.Write8(0xE74B, 0xB3);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB225, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB79B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8466, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xFF7D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x414C, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE798, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB14() {
            cpu.Reset();
            cpu.r1.af = 0xABBB;
            cpu.r1.bc = 0x451A;
            cpu.r1.de = 0xFC65;
            cpu.r1.hl = 0x14A1;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0F4D;
            cpu.r1.iy = 0xD93C;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xC4);
            memory.Write8(0x0003, 0x14);
            memory.Write8(0xD900, 0x06);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAB08, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x451A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xFC65, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0DA1, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0F4D, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD93C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB15() {
            cpu.Reset();
            cpu.r1.af = 0x2864;
            cpu.r1.bc = 0x9532;
            cpu.r1.de = 0x8631;
            cpu.r1.hl = 0x751C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE327;
            cpu.r1.iy = 0x2D7B;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x17);
            memory.Write8(0x0003, 0x15);
            memory.Write8(0x2D92, 0x12);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2824, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9532, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8631, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7524, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE327, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x2D7B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB16() {
            cpu.Reset();
            cpu.r1.af = 0x0C3C;
            cpu.r1.bc = 0xDCD7;
            cpu.r1.de = 0xADCC;
            cpu.r1.hl = 0x196D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x87E2;
            cpu.r1.iy = 0xF0B4;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x23);
            memory.Write8(0x0003, 0x16);
            memory.Write8(0xF0D7, 0x89);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0C05, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xDCD7, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xADCC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x196D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x87E2, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xF0B4, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB17() {
            cpu.Reset();
            cpu.r1.af = 0xAF5B;
            cpu.r1.bc = 0xD016;
            cpu.r1.de = 0x066E;
            cpu.r1.hl = 0x6638;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5E92;
            cpu.r1.iy = 0x2013;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x8A);
            memory.Write8(0x0003, 0x17);
            memory.Write8(0x1F9D, 0xB8);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7125, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD016, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x066E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6638, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5E92, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x2013, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB18() {
            cpu.Reset();
            cpu.r1.af = 0x23F3;
            cpu.r1.bc = 0x4517;
            cpu.r1.de = 0x16E0;
            cpu.r1.hl = 0x6894;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB908;
            cpu.r1.iy = 0x3216;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xC0);
            memory.Write8(0x0003, 0x18);
            memory.Write8(0x31D6, 0xFA);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x23A8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFD17, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x16E0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6894, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB908, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x3216, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB19() {
            cpu.Reset();
            cpu.r1.af = 0x11ED;
            cpu.r1.bc = 0xC2B8;
            cpu.r1.de = 0xA9F3;
            cpu.r1.hl = 0x2014;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6DB0;
            cpu.r1.iy = 0x4D2E;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xA2);
            memory.Write8(0x0003, 0x19);
            memory.Write8(0x4CD0, 0x4B);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x11A5, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC2A5, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA9F3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2014, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6DB0, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4D2E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB1A() {
            cpu.Reset();
            cpu.r1.af = 0xBC5C;
            cpu.r1.bc = 0x6168;
            cpu.r1.de = 0xE541;
            cpu.r1.hl = 0xB630;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0207;
            cpu.r1.iy = 0x40D3;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x78);
            memory.Write8(0x0003, 0x1A);
            memory.Write8(0x414B, 0x44);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xBC24, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6168, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2241, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB630, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0207, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x40D3, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB1B() {
            cpu.Reset();
            cpu.r1.af = 0x7A28;
            cpu.r1.bc = 0x1286;
            cpu.r1.de = 0xFE50;
            cpu.r1.hl = 0xC42D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE290;
            cpu.r1.iy = 0x71B0;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x16);
            memory.Write8(0x0003, 0x1B);
            memory.Write8(0x71C6, 0xB8);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7A0C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1286, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xFE5C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC42D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE290, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x71B0, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB1C() {
            cpu.Reset();
            cpu.r1.af = 0x932B;
            cpu.r1.bc = 0x097B;
            cpu.r1.de = 0x6928;
            cpu.r1.hl = 0x83A3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xFF2D;
            cpu.r1.iy = 0xDF62;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x86);
            memory.Write8(0x0003, 0x1C);
            memory.Write8(0xDEE8, 0x8F);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9381, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x097B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6928, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC7A3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xFF2D, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xDF62, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB1D() {
            cpu.Reset();
            cpu.r1.af = 0x97B1;
            cpu.r1.bc = 0x2B30;
            cpu.r1.de = 0x2645;
            cpu.r1.hl = 0x04EF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x186A;
            cpu.r1.iy = 0xD667;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x27);
            memory.Write8(0x0003, 0x1D);
            memory.Write8(0xD68E, 0xB7);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x978D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2B30, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2645, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x04DB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x186A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD667, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB1E() {
            cpu.Reset();
            cpu.r1.af = 0x2F39;
            cpu.r1.bc = 0x2470;
            cpu.r1.de = 0xB521;
            cpu.r1.hl = 0x6CA3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1066;
            cpu.r1.iy = 0xDA38;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x3A);
            memory.Write8(0x0003, 0x1E);
            memory.Write8(0xDA72, 0x25);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2F81, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2470, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB521, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6CA3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1066, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xDA38, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB1F() {
            cpu.Reset();
            cpu.r1.af = 0x4CDD;
            cpu.r1.bc = 0x49A3;
            cpu.r1.de = 0xDA18;
            cpu.r1.hl = 0x3AFD;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xA4F1;
            cpu.r1.iy = 0x2095;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x7B);
            memory.Write8(0x0003, 0x1F);
            memory.Write8(0x2110, 0x04);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8284, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x49A3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDA18, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3AFD, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xA4F1, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x2095, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB20() {
            cpu.Reset();
            cpu.r1.af = 0x3D74;
            cpu.r1.bc = 0x3A8F;
            cpu.r1.de = 0x206F;
            cpu.r1.hl = 0x8894;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xDDAB;
            cpu.r1.iy = 0xDA25;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x7A);
            memory.Write8(0x0003, 0x20);
            memory.Write8(0xDA9F, 0x89);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3D05, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x128F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x206F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8894, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xDDAB, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xDA25, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB21() {
            cpu.Reset();
            cpu.r1.af = 0x1674;
            cpu.r1.bc = 0x6025;
            cpu.r1.de = 0x641A;
            cpu.r1.hl = 0x6598;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x473B;
            cpu.r1.iy = 0xDE36;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x7B);
            memory.Write8(0x0003, 0x21);
            memory.Write8(0xDEB1, 0x23);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1600, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6046, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x641A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6598, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x473B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xDE36, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB22() {
            cpu.Reset();
            cpu.r1.af = 0xADA9;
            cpu.r1.bc = 0xEFB2;
            cpu.r1.de = 0x6F03;
            cpu.r1.hl = 0xE732;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC11D;
            cpu.r1.iy = 0x8926;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x9A);
            memory.Write8(0x0003, 0x22);
            memory.Write8(0x88C0, 0xD4);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xADA9, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xEFB2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA803, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE732, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC11D, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8926, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB23() {
            cpu.Reset();
            cpu.r1.af = 0x21E9;
            cpu.r1.bc = 0xD678;
            cpu.r1.de = 0xA71B;
            cpu.r1.hl = 0x25D7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x4CA8;
            cpu.r1.iy = 0x5255;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xF5);
            memory.Write8(0x0003, 0x23);
            memory.Write8(0x524A, 0x65);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x218C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD678, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA7CA, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x25D7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x4CA8, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5255, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB24() {
            cpu.Reset();
            cpu.r1.af = 0x1C51;
            cpu.r1.bc = 0xDA3E;
            cpu.r1.de = 0xCC7C;
            cpu.r1.hl = 0xCB19;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x572C;
            cpu.r1.iy = 0xAFFE;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xB4);
            memory.Write8(0x0003, 0x24);
            memory.Write8(0xAFB2, 0x7E);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1CAC, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xDA3E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xCC7C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xFC19, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x572C, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xAFFE, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB25() {
            cpu.Reset();
            cpu.r1.af = 0x954E;
            cpu.r1.bc = 0x097C;
            cpu.r1.de = 0xA341;
            cpu.r1.hl = 0x89E0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x435D;
            cpu.r1.iy = 0x23E9;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xA6);
            memory.Write8(0x0003, 0x25);
            memory.Write8(0x238F, 0x26);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9508, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x097C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA341, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x894C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x435D, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x23E9, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB26() {
            cpu.Reset();
            cpu.r1.af = 0x5844;
            cpu.r1.bc = 0x0E19;
            cpu.r1.de = 0xD277;
            cpu.r1.hl = 0xBF7F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6504;
            cpu.r1.iy = 0xD4E4;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xBD);
            memory.Write8(0x0003, 0x26);
            memory.Write8(0xD4A1, 0xBF);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x582D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0E19, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD277, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xBF7F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6504, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD4E4, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB27() {
            cpu.Reset();
            cpu.r1.af = 0x8E0D;
            cpu.r1.bc = 0x8C06;
            cpu.r1.de = 0x2C4C;
            cpu.r1.hl = 0xD7C8;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9239;
            cpu.r1.iy = 0x8D42;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x59);
            memory.Write8(0x0003, 0x27);
            memory.Write8(0x8D9B, 0xA7);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4E0D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8C06, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2C4C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD7C8, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9239, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8D42, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB28() {
            cpu.Reset();
            cpu.r1.af = 0x4122;
            cpu.r1.bc = 0xAF9B;
            cpu.r1.de = 0x7745;
            cpu.r1.hl = 0x76F5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xA1BB;
            cpu.r1.iy = 0xAB43;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x83);
            memory.Write8(0x0003, 0x28);
            memory.Write8(0xAAC6, 0x5D);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x412D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2E9B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7745, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x76F5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xA1BB, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xAB43, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB29() {
            cpu.Reset();
            cpu.r1.af = 0x0B21;
            cpu.r1.bc = 0xAFFD;
            cpu.r1.de = 0xFEA6;
            cpu.r1.hl = 0x9478;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x32BB;
            cpu.r1.iy = 0x0343;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x7D);
            memory.Write8(0x0003, 0x29);
            memory.Write8(0x03C0, 0x84);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0B80, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAFC2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xFEA6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9478, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x32BB, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0343, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB2A() {
            cpu.Reset();
            cpu.r1.af = 0xF236;
            cpu.r1.bc = 0x8C31;
            cpu.r1.de = 0x5932;
            cpu.r1.hl = 0x7FEB;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7DB7;
            cpu.r1.iy = 0xABE7;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xF9);
            memory.Write8(0x0003, 0x2A);
            memory.Write8(0xABE0, 0xDD);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF2AD, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8C31, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xEE32, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7FEB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7DB7, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xABE7, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB2B() {
            cpu.Reset();
            cpu.r1.af = 0x2450;
            cpu.r1.bc = 0x6945;
            cpu.r1.de = 0xDCFC;
            cpu.r1.hl = 0xD643;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5BE1;
            cpu.r1.iy = 0x4A94;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x4B);
            memory.Write8(0x0003, 0x2B);
            memory.Write8(0x4ADF, 0x49);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2425, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6945, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDC24, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD643, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5BE1, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4A94, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB2C() {
            cpu.Reset();
            cpu.r1.af = 0x117F;
            cpu.r1.bc = 0xB32B;
            cpu.r1.de = 0xE530;
            cpu.r1.hl = 0x255A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x2416;
            cpu.r1.iy = 0xCCD1;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xE6);
            memory.Write8(0x0003, 0x2C);
            memory.Write8(0xCCB7, 0x3C);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x110C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB32B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE530, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1E5A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x2416, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xCCD1, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB2D() {
            cpu.Reset();
            cpu.r1.af = 0xD0C3;
            cpu.r1.bc = 0x344B;
            cpu.r1.de = 0x1BB0;
            cpu.r1.hl = 0x3EAB;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xFE11;
            cpu.r1.iy = 0xE4E6;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x5F);
            memory.Write8(0x0003, 0x2D);
            memory.Write8(0xE545, 0x78);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD02C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x344B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1BB0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3E3C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xFE11, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE4E6, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB2E() {
            cpu.Reset();
            cpu.r1.af = 0xF4EE;
            cpu.r1.bc = 0xB832;
            cpu.r1.de = 0x4B7F;
            cpu.r1.hl = 0xE2B7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9386;
            cpu.r1.iy = 0x42FD;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x06);
            memory.Write8(0x0003, 0x2E);
            memory.Write8(0x4303, 0xAD);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF481, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB832, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4B7F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE2B7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9386, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x42FD, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB2F() {
            cpu.Reset();
            cpu.r1.af = 0xFF86;
            cpu.r1.bc = 0xF2C2;
            cpu.r1.de = 0x9F2F;
            cpu.r1.hl = 0xC946;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5FE0;
            cpu.r1.iy = 0x16B8;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x29);
            memory.Write8(0x0003, 0x2F);
            memory.Write8(0x16E1, 0x18);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0C0C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF2C2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9F2F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC946, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5FE0, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x16B8, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB30() {
            cpu.Reset();
            cpu.r1.af = 0xACF6;
            cpu.r1.bc = 0xE832;
            cpu.r1.de = 0xF9ED;
            cpu.r1.hl = 0xCABC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xFABD;
            cpu.r1.iy = 0xD646;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x1B);
            memory.Write8(0x0003, 0x30);
            memory.Write8(0xD661, 0xA5);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAC0D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4B32, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF9ED, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCABC, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xFABD, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD646, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB31() {
            cpu.Reset();
            cpu.r1.af = 0x2B96;
            cpu.r1.bc = 0x5134;
            cpu.r1.de = 0x83A7;
            cpu.r1.hl = 0x7EEE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7750;
            cpu.r1.iy = 0xBFE0;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xF0);
            memory.Write8(0x0003, 0x31);
            memory.Write8(0xBFD0, 0xF1);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2BA1, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x51E3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x83A7, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7EEE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7750, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xBFE0, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB32() {
            cpu.Reset();
            cpu.r1.af = 0xB2BC;
            cpu.r1.bc = 0xA4B1;
            cpu.r1.de = 0xB685;
            cpu.r1.hl = 0xF66E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xA9A1;
            cpu.r1.iy = 0x5ADE;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xC5);
            memory.Write8(0x0003, 0x32);
            memory.Write8(0x5AA3, 0x59);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB2A0, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA4B1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB385, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF66E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xA9A1, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5ADE, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB33() {
            cpu.Reset();
            cpu.r1.af = 0x9C6D;
            cpu.r1.bc = 0x2C90;
            cpu.r1.de = 0xD0A9;
            cpu.r1.hl = 0x2BE3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x2691;
            cpu.r1.iy = 0x1964;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x7F);
            memory.Write8(0x0003, 0x33);
            memory.Write8(0x19E3, 0xDA);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9CA1, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2C90, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD0B5, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2BE3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x2691, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1964, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB34() {
            cpu.Reset();
            cpu.r1.af = 0x6029;
            cpu.r1.bc = 0xFBCD;
            cpu.r1.de = 0x5348;
            cpu.r1.hl = 0xF947;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5338;
            cpu.r1.iy = 0x5696;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xD2);
            memory.Write8(0x0003, 0x34);
            memory.Write8(0x5668, 0xD4);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x60AD, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFBCD, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5348, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA947, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5338, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5696, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB35() {
            cpu.Reset();
            cpu.r1.af = 0x96A9;
            cpu.r1.bc = 0x21C6;
            cpu.r1.de = 0x4CB6;
            cpu.r1.hl = 0xB40B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x673A;
            cpu.r1.iy = 0x00F8;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x71);
            memory.Write8(0x0003, 0x35);
            memory.Write8(0x0169, 0x0B);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9604, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x21C6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4CB6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB417, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x673A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x00F8, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB36() {
            cpu.Reset();
            cpu.r1.af = 0xDC6F;
            cpu.r1.bc = 0x0892;
            cpu.r1.de = 0x3CC7;
            cpu.r1.hl = 0x1494;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x8598;
            cpu.r1.iy = 0x1ADE;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xDA);
            memory.Write8(0x0003, 0x36);
            memory.Write8(0x1AB8, 0x3C);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDC28, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0892, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3CC7, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1494, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x8598, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1ADE, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB37() {
            cpu.Reset();
            cpu.r1.af = 0xD2B3;
            cpu.r1.bc = 0x4524;
            cpu.r1.de = 0x208F;
            cpu.r1.hl = 0x076F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xAD10;
            cpu.r1.iy = 0xE7EC;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xCB);
            memory.Write8(0x0003, 0x37);
            memory.Write8(0xE7B7, 0x9F);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3F2D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4524, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x208F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x076F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xAD10, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE7EC, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB38() {
            cpu.Reset();
            cpu.r1.af = 0x4F07;
            cpu.r1.bc = 0x0050;
            cpu.r1.de = 0x40C6;
            cpu.r1.hl = 0x4FB7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xF37E;
            cpu.r1.iy = 0xD096;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x8E);
            memory.Write8(0x0003, 0x38);
            memory.Write8(0xD024, 0x0D);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4F05, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0650, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x40C6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4FB7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xF37E, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD096, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB39() {
            cpu.Reset();
            cpu.r1.af = 0xBCC2;
            cpu.r1.bc = 0xF5B5;
            cpu.r1.de = 0x8DEE;
            cpu.r1.hl = 0xE514;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x48BC;
            cpu.r1.iy = 0xF433;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x7F);
            memory.Write8(0x0003, 0x39);
            memory.Write8(0xF4B2, 0xF5);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xBC29, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF57A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8DEE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE514, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x48BC, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xF433, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB3A() {
            cpu.Reset();
            cpu.r1.af = 0xD012;
            cpu.r1.bc = 0x2EF5;
            cpu.r1.de = 0x2910;
            cpu.r1.hl = 0x9CA5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB155;
            cpu.r1.iy = 0xCB03;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x1D);
            memory.Write8(0x0003, 0x3A);
            memory.Write8(0xCB20, 0xA8);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2EF5, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5410, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9CA5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB155, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xCB03, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB3B() {
            cpu.Reset();
            cpu.r1.af = 0x503D;
            cpu.r1.bc = 0xA85B;
            cpu.r1.de = 0xCFBB;
            cpu.r1.hl = 0xDE8C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9C5B;
            cpu.r1.iy = 0xD263;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x05);
            memory.Write8(0x0003, 0x3B);
            memory.Write8(0xD268, 0xB2);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x500C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA85B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xCF59, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDE8C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9C5B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD263, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB3C() {
            cpu.Reset();
            cpu.r1.af = 0x97F0;
            cpu.r1.bc = 0x4456;
            cpu.r1.de = 0x0B52;
            cpu.r1.hl = 0xFDAD;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6D2A;
            cpu.r1.iy = 0xA80F;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xAE);
            memory.Write8(0x0003, 0x3C);
            memory.Write8(0xA7BD, 0x96);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x970C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4456, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0B52, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4BAD, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6D2A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA80F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB3D() {
            cpu.Reset();
            cpu.r1.af = 0x7D44;
            cpu.r1.bc = 0x9303;
            cpu.r1.de = 0xE12B;
            cpu.r1.hl = 0xBFF6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x4C0F;
            cpu.r1.iy = 0xE52A;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x13);
            memory.Write8(0x0003, 0x3D);
            memory.Write8(0xE53D, 0xFB);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7D2D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9303, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE12B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xBF7D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x4C0F, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE52A, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB3E() {
            cpu.Reset();
            cpu.r1.af = 0x0D95;
            cpu.r1.bc = 0x3E02;
            cpu.r1.de = 0x8F74;
            cpu.r1.hl = 0x0F82;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x85DF;
            cpu.r1.iy = 0xB2D1;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x2E);
            memory.Write8(0x0003, 0x3E);
            memory.Write8(0xB2FF, 0x50);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0D2C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3E02, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8F74, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0F82, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x85DF, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB2D1, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB3F() {
            cpu.Reset();
            cpu.r1.af = 0x89E3;
            cpu.r1.bc = 0x12F6;
            cpu.r1.de = 0x426C;
            cpu.r1.hl = 0x52D4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xD9F7;
            cpu.r1.iy = 0xC1AC;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x21);
            memory.Write8(0x0003, 0x3F);
            memory.Write8(0xC1CD, 0x78);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3C2C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x12F6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x426C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x52D4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xD9F7, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC1AC, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB40() {
            cpu.Reset();
            cpu.r1.af = 0x5408;
            cpu.r1.bc = 0x2C34;
            cpu.r1.de = 0x6784;
            cpu.r1.hl = 0xB376;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x8FF9;
            cpu.r1.iy = 0x4195;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x3B);
            memory.Write8(0x0003, 0x40);
            memory.Write8(0x41D0, 0x0D);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5410, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2C34, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6784, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB376, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x8FF9, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4195, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB41() {
            cpu.Reset();
            cpu.r1.af = 0x8C35;
            cpu.r1.bc = 0x5A58;
            cpu.r1.de = 0xB71C;
            cpu.r1.hl = 0x6777;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xDECA;
            cpu.r1.iy = 0x03CB;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xCC);
            memory.Write8(0x0003, 0x41);
            memory.Write8(0x0397, 0xE9);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8C11, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5A58, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB71C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6777, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xDECA, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x03CB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB42() {
            cpu.Reset();
            cpu.r1.af = 0x5535;
            cpu.r1.bc = 0x9C29;
            cpu.r1.de = 0x2FEB;
            cpu.r1.hl = 0x97FF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7F17;
            cpu.r1.iy = 0x9F56;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x01);
            memory.Write8(0x0003, 0x42);
            memory.Write8(0x9F57, 0xA8);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x555D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9C29, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2FEB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x97FF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7F17, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x9F56, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB43() {
            cpu.Reset();
            cpu.r1.af = 0xB404;
            cpu.r1.bc = 0xE58C;
            cpu.r1.de = 0xE62E;
            cpu.r1.hl = 0x2A32;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7130;
            cpu.r1.iy = 0x1FD1;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x08);
            memory.Write8(0x0003, 0x43);
            memory.Write8(0x1FD9, 0xAA);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB45C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE58C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE62E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2A32, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7130, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1FD1, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB44() {
            cpu.Reset();
            cpu.r1.af = 0xA954;
            cpu.r1.bc = 0x68F4;
            cpu.r1.de = 0x9FA4;
            cpu.r1.hl = 0x7F66;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0209;
            cpu.r1.iy = 0xF4F3;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x03);
            memory.Write8(0x0003, 0x44);
            memory.Write8(0xF4F6, 0x89);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA930, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x68F4, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9FA4, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7F66, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0209, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xF4F3, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB45() {
            cpu.Reset();
            cpu.r1.af = 0x73E5;
            cpu.r1.bc = 0x8DDE;
            cpu.r1.de = 0x5E4F;
            cpu.r1.hl = 0x84A7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x4E24;
            cpu.r1.iy = 0x93ED;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x8D);
            memory.Write8(0x0003, 0x45);
            memory.Write8(0x937A, 0x8D);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7311, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8DDE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5E4F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x84A7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x4E24, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x93ED, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB46() {
            cpu.Reset();
            cpu.r1.af = 0x0E5A;
            cpu.r1.bc = 0xB1F9;
            cpu.r1.de = 0x475F;
            cpu.r1.hl = 0xEBFC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7765;
            cpu.r1.iy = 0x63B1;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x8C);
            memory.Write8(0x0003, 0x46);
            memory.Write8(0x633D, 0xFE);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0E74, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB1F9, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x475F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xEBFC, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7765, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x63B1, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB47() {
            cpu.Reset();
            cpu.r1.af = 0x9B3D;
            cpu.r1.bc = 0x7F38;
            cpu.r1.de = 0x0753;
            cpu.r1.hl = 0xD5E7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB9C3;
            cpu.r1.iy = 0x6E0E;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x96);
            memory.Write8(0x0003, 0x47);
            memory.Write8(0x6DA4, 0xD6);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9B7D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7F38, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0753, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD5E7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB9C3, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6E0E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB48() {
            cpu.Reset();
            cpu.r1.af = 0x7D94;
            cpu.r1.bc = 0x50A9;
            cpu.r1.de = 0x2511;
            cpu.r1.hl = 0x8F9F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB612;
            cpu.r1.iy = 0xABA9;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x44);
            memory.Write8(0x0003, 0x48);
            memory.Write8(0xABED, 0xB0);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7D7C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x50A9, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2511, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8F9F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB612, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xABA9, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB49() {
            cpu.Reset();
            cpu.r1.af = 0x691E;
            cpu.r1.bc = 0x3A39;
            cpu.r1.de = 0xB834;
            cpu.r1.hl = 0x74B6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0EB7;
            cpu.r1.iy = 0x3E21;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x4E);
            memory.Write8(0x0003, 0x49);
            memory.Write8(0x3E6F, 0xA9);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x697C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3A39, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB834, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x74B6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0EB7, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x3E21, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB4A() {
            cpu.Reset();
            cpu.r1.af = 0x31E3;
            cpu.r1.bc = 0x68E0;
            cpu.r1.de = 0xFE2F;
            cpu.r1.hl = 0xA2C4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xAC96;
            cpu.r1.iy = 0xE7DB;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x52);
            memory.Write8(0x0003, 0x4A);
            memory.Write8(0xE82D, 0xDA);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3139, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x68E0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xFE2F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA2C4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xAC96, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE7DB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB4B() {
            cpu.Reset();
            cpu.r1.af = 0x09A1;
            cpu.r1.bc = 0x2453;
            cpu.r1.de = 0x9186;
            cpu.r1.hl = 0xA32A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x71AF;
            cpu.r1.iy = 0x883F;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xEA);
            memory.Write8(0x0003, 0x4B);
            memory.Write8(0x8829, 0x4E);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0919, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2453, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9186, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA32A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x71AF, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x883F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB4C() {
            cpu.Reset();
            cpu.r1.af = 0x4A52;
            cpu.r1.bc = 0x1E5B;
            cpu.r1.de = 0xBE2E;
            cpu.r1.hl = 0x3EE4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xAF79;
            cpu.r1.iy = 0x7F22;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xEE);
            memory.Write8(0x0003, 0x4C);
            memory.Write8(0x7F10, 0x70);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4A7C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1E5B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xBE2E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3EE4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xAF79, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7F22, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB4D() {
            cpu.Reset();
            cpu.r1.af = 0x9F87;
            cpu.r1.bc = 0x6C8F;
            cpu.r1.de = 0x34F4;
            cpu.r1.hl = 0x5A79;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xD3CC;
            cpu.r1.iy = 0xA770;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x29);
            memory.Write8(0x0003, 0x4D);
            memory.Write8(0xA799, 0x78);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9F75, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6C8F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x34F4, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5A79, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xD3CC, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA770, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB4E() {
            cpu.Reset();
            cpu.r1.af = 0x30CB;
            cpu.r1.bc = 0x5626;
            cpu.r1.de = 0x52BC;
            cpu.r1.hl = 0x5503;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x303B;
            cpu.r1.iy = 0xE1C8;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x20);
            memory.Write8(0x0003, 0x4E);
            memory.Write8(0xE1E8, 0xAA);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3031, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5626, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x52BC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5503, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x303B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE1C8, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB4F() {
            cpu.Reset();
            cpu.r1.af = 0x6088;
            cpu.r1.bc = 0xE079;
            cpu.r1.de = 0x7152;
            cpu.r1.hl = 0x671F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x8C22;
            cpu.r1.iy = 0x1CF8;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x9D);
            memory.Write8(0x0003, 0x4F);
            memory.Write8(0x1C95, 0x18);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x605C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE079, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7152, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x671F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x8C22, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1CF8, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB50() {
            cpu.Reset();
            cpu.r1.af = 0x8CDE;
            cpu.r1.bc = 0x1409;
            cpu.r1.de = 0x6D69;
            cpu.r1.hl = 0xE5B2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x4A0C;
            cpu.r1.iy = 0xC75F;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x6B);
            memory.Write8(0x0003, 0x50);
            memory.Write8(0xC7CA, 0xFE);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8C10, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1409, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6D69, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE5B2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x4A0C, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC75F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB51() {
            cpu.Reset();
            cpu.r1.af = 0x8F59;
            cpu.r1.bc = 0x40CB;
            cpu.r1.de = 0x9543;
            cpu.r1.hl = 0x9B3A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1942;
            cpu.r1.iy = 0x3495;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x86);
            memory.Write8(0x0003, 0x51);
            memory.Write8(0x341B, 0x13);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8F75, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x40CB, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9543, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9B3A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1942, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x3495, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB52() {
            cpu.Reset();
            cpu.r1.af = 0x8905;
            cpu.r1.bc = 0x3E41;
            cpu.r1.de = 0x7AB4;
            cpu.r1.hl = 0x37F6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xF82D;
            cpu.r1.iy = 0x8B0D;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xE6);
            memory.Write8(0x0003, 0x52);
            memory.Write8(0x8AF3, 0x87);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8919, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3E41, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7AB4, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x37F6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xF82D, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8B0D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB53() {
            cpu.Reset();
            cpu.r1.af = 0xEFDE;
            cpu.r1.bc = 0xE345;
            cpu.r1.de = 0x09A3;
            cpu.r1.hl = 0xF0B2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC378;
            cpu.r1.iy = 0x7EE1;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xD1);
            memory.Write8(0x0003, 0x53);
            memory.Write8(0x7EB2, 0xE4);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xEF38, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE345, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x09A3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF0B2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC378, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7EE1, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB54() {
            cpu.Reset();
            cpu.r1.af = 0x72A6;
            cpu.r1.bc = 0xCB82;
            cpu.r1.de = 0xD966;
            cpu.r1.hl = 0x2FC6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x3C00;
            cpu.r1.iy = 0x5B6B;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x08);
            memory.Write8(0x0003, 0x54);
            memory.Write8(0x5B73, 0x07);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7218, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCB82, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD966, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2FC6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x3C00, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5B6B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB55() {
            cpu.Reset();
            cpu.r1.af = 0x855C;
            cpu.r1.bc = 0xC23B;
            cpu.r1.de = 0x6AAB;
            cpu.r1.hl = 0x9B00;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xFE93;
            cpu.r1.iy = 0xB4B2;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x54);
            memory.Write8(0x0003, 0x55);
            memory.Write8(0xB506, 0x46);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8530, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC23B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6AAB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9B00, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xFE93, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB4B2, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB56() {
            cpu.Reset();
            cpu.r1.af = 0xF5AD;
            cpu.r1.bc = 0xF9F6;
            cpu.r1.de = 0x1E8C;
            cpu.r1.hl = 0x9E08;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x716A;
            cpu.r1.iy = 0x6932;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x6F);
            memory.Write8(0x0003, 0x56);
            memory.Write8(0x69A1, 0xDF);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF539, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF9F6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1E8C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9E08, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x716A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6932, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB57() {
            cpu.Reset();
            cpu.r1.af = 0x37D7;
            cpu.r1.bc = 0xB7DC;
            cpu.r1.de = 0xBE1C;
            cpu.r1.hl = 0x38EA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5E82;
            cpu.r1.iy = 0xA3BB;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x3C);
            memory.Write8(0x0003, 0x57);
            memory.Write8(0xA3F7, 0x6C);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3731, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB7DC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xBE1C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x38EA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5E82, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA3BB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB58() {
            cpu.Reset();
            cpu.r1.af = 0x752C;
            cpu.r1.bc = 0x7296;
            cpu.r1.de = 0x3EA5;
            cpu.r1.hl = 0x1143;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xD7CC;
            cpu.r1.iy = 0x1E94;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x4E);
            memory.Write8(0x0003, 0x58);
            memory.Write8(0x1EE2, 0xF6);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x755C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7296, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3EA5, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1143, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xD7CC, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1E94, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB59() {
            cpu.Reset();
            cpu.r1.af = 0x8056;
            cpu.r1.bc = 0xBF2A;
            cpu.r1.de = 0x1809;
            cpu.r1.hl = 0xED31;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xFE2B;
            cpu.r1.iy = 0xFAD3;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x2E);
            memory.Write8(0x0003, 0x59);
            memory.Write8(0xFB01, 0x6F);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8038, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBF2A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1809, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xED31, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xFE2B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xFAD3, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB5A() {
            cpu.Reset();
            cpu.r1.af = 0xCC74;
            cpu.r1.bc = 0xA108;
            cpu.r1.de = 0x65D4;
            cpu.r1.hl = 0x6F66;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0008;
            cpu.r1.iy = 0x7BB8;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x88);
            memory.Write8(0x0003, 0x5A);
            memory.Write8(0x7B40, 0x6E);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCC38, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA108, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x65D4, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6F66, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0008, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7BB8, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB5B() {
            cpu.Reset();
            cpu.r1.af = 0x5CF1;
            cpu.r1.bc = 0xB3BD;
            cpu.r1.de = 0x25BD;
            cpu.r1.hl = 0x98CF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x2BA1;
            cpu.r1.iy = 0x315C;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xE7);
            memory.Write8(0x0003, 0x5B);
            memory.Write8(0x3143, 0xB1);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5C75, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB3BD, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x25BD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x98CF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x2BA1, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x315C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB5C() {
            cpu.Reset();
            cpu.r1.af = 0xB3E0;
            cpu.r1.bc = 0xD43D;
            cpu.r1.de = 0xD9C0;
            cpu.r1.hl = 0xB04D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x21A9;
            cpu.r1.iy = 0x543E;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x74);
            memory.Write8(0x0003, 0x5C);
            memory.Write8(0x54B2, 0xE3);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB354, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD43D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD9C0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB04D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x21A9, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x543E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB5D() {
            cpu.Reset();
            cpu.r1.af = 0x9F49;
            cpu.r1.bc = 0x43DD;
            cpu.r1.de = 0xCCB3;
            cpu.r1.hl = 0x085A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xF130;
            cpu.r1.iy = 0x3B84;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xDC);
            memory.Write8(0x0003, 0x5D);
            memory.Write8(0x3B60, 0xEF);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9F39, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x43DD, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xCCB3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x085A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xF130, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x3B84, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB5E() {
            cpu.Reset();
            cpu.r1.af = 0x6F89;
            cpu.r1.bc = 0xEFF5;
            cpu.r1.de = 0x993B;
            cpu.r1.hl = 0x22B5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0F30;
            cpu.r1.iy = 0xE165;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xE2);
            memory.Write8(0x0003, 0x5E);
            memory.Write8(0xE147, 0x17);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6F75, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xEFF5, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x993B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x22B5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0F30, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE165, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB5F() {
            cpu.Reset();
            cpu.r1.af = 0xD72A;
            cpu.r1.bc = 0xA57A;
            cpu.r1.de = 0xACA6;
            cpu.r1.hl = 0x667E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5C33;
            cpu.r1.iy = 0xF81B;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xAB);
            memory.Write8(0x0003, 0x5F);
            memory.Write8(0xF7C6, 0xE2);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD774, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA57A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xACA6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x667E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5C33, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xF81B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB60() {
            cpu.Reset();
            cpu.r1.af = 0x15E9;
            cpu.r1.bc = 0x8D30;
            cpu.r1.de = 0x43F4;
            cpu.r1.hl = 0xC65E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1E34;
            cpu.r1.iy = 0x8C44;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x85);
            memory.Write8(0x0003, 0x60);
            memory.Write8(0x8BC9, 0xB9);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1519, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8D30, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x43F4, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC65E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1E34, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8C44, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB61() {
            cpu.Reset();
            cpu.r1.af = 0x7BD1;
            cpu.r1.bc = 0xD421;
            cpu.r1.de = 0x5570;
            cpu.r1.hl = 0xCB85;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x32EC;
            cpu.r1.iy = 0x92E4;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xBE);
            memory.Write8(0x0003, 0x61);
            memory.Write8(0x92A2, 0x28);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7B55, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD421, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5570, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCB85, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x32EC, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x92E4, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB62() {
            cpu.Reset();
            cpu.r1.af = 0xBA2F;
            cpu.r1.bc = 0x4FBB;
            cpu.r1.de = 0x67A7;
            cpu.r1.hl = 0xC5DB;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x470B;
            cpu.r1.iy = 0x7EB1;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x9D);
            memory.Write8(0x0003, 0x62);
            memory.Write8(0x7E4E, 0x1A);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xBA39, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4FBB, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x67A7, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC5DB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x470B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7EB1, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB63() {
            cpu.Reset();
            cpu.r1.af = 0xC0A1;
            cpu.r1.bc = 0x2CC2;
            cpu.r1.de = 0xCE12;
            cpu.r1.hl = 0xE77C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x71C5;
            cpu.r1.iy = 0x1713;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xF4);
            memory.Write8(0x0003, 0x63);
            memory.Write8(0x1707, 0x3B);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC011, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2CC2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xCE12, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE77C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x71C5, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1713, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB64() {
            cpu.Reset();
            cpu.r1.af = 0x0C1F;
            cpu.r1.bc = 0x7847;
            cpu.r1.de = 0x2494;
            cpu.r1.hl = 0x71EB;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x315C;
            cpu.r1.iy = 0xB336;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x35);
            memory.Write8(0x0003, 0x64);
            memory.Write8(0xB36B, 0x8C);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0C75, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7847, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2494, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x71EB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x315C, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB336, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB65() {
            cpu.Reset();
            cpu.r1.af = 0x5245;
            cpu.r1.bc = 0xA82D;
            cpu.r1.de = 0x1112;
            cpu.r1.hl = 0x8F09;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x672A;
            cpu.r1.iy = 0x89F4;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x37);
            memory.Write8(0x0003, 0x65);
            memory.Write8(0x8A2B, 0x08);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x525D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA82D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1112, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8F09, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x672A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x89F4, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB66() {
            cpu.Reset();
            cpu.r1.af = 0x583F;
            cpu.r1.bc = 0xC13E;
            cpu.r1.de = 0xB136;
            cpu.r1.hl = 0x6BC5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x3EF9;
            cpu.r1.iy = 0x6948;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x9D);
            memory.Write8(0x0003, 0x66);
            memory.Write8(0x68E5, 0x90);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5839, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC13E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB136, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6BC5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x3EF9, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6948, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB67() {
            cpu.Reset();
            cpu.r1.af = 0x31B6;
            cpu.r1.bc = 0x0F7D;
            cpu.r1.de = 0x48B5;
            cpu.r1.hl = 0xCC5F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x2103;
            cpu.r1.iy = 0x6572;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xCB);
            memory.Write8(0x0003, 0x67);
            memory.Write8(0x653D, 0x15);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3130, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F7D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x48B5, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCC5F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x2103, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6572, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB68() {
            cpu.Reset();
            cpu.r1.af = 0xE330;
            cpu.r1.bc = 0x39FB;
            cpu.r1.de = 0xA03A;
            cpu.r1.hl = 0x59BC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE04A;
            cpu.r1.iy = 0x03BE;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xCA);
            memory.Write8(0x0003, 0x68);
            memory.Write8(0x0388, 0x83);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE354, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x39FB, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA03A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x59BC, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE04A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x03BE, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB69() {
            cpu.Reset();
            cpu.r1.af = 0x1896;
            cpu.r1.bc = 0x5BC2;
            cpu.r1.de = 0xD4D9;
            cpu.r1.hl = 0x4E8A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x3716;
            cpu.r1.iy = 0xA603;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xE2);
            memory.Write8(0x0003, 0x69);
            memory.Write8(0xA5E5, 0x01);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1874, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5BC2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD4D9, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4E8A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x3716, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA603, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB6A() {
            cpu.Reset();
            cpu.r1.af = 0x5BC9;
            cpu.r1.bc = 0x0099;
            cpu.r1.de = 0x34F8;
            cpu.r1.hl = 0x3E96;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xF251;
            cpu.r1.iy = 0x93BE;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xAE);
            memory.Write8(0x0003, 0x6A);
            memory.Write8(0x936C, 0x33);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5B11, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0099, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x34F8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3E96, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xF251, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x93BE, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB6B() {
            cpu.Reset();
            cpu.r1.af = 0xBBE5;
            cpu.r1.bc = 0x9E6C;
            cpu.r1.de = 0xABD1;
            cpu.r1.hl = 0x515F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x73DB;
            cpu.r1.iy = 0xAA2F;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x1F);
            memory.Write8(0x0003, 0x6B);
            memory.Write8(0xAA4E, 0x7C);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xBB39, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9E6C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xABD1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x515F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x73DB, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xAA2F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB6C() {
            cpu.Reset();
            cpu.r1.af = 0x144B;
            cpu.r1.bc = 0x3AF2;
            cpu.r1.de = 0x8F80;
            cpu.r1.hl = 0x7BE5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC379;
            cpu.r1.iy = 0x86BA;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x0D);
            memory.Write8(0x0003, 0x6C);
            memory.Write8(0x86C7, 0x25);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1411, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3AF2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8F80, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7BE5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC379, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x86BA, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB6D() {
            cpu.Reset();
            cpu.r1.af = 0x6392;
            cpu.r1.bc = 0xD077;
            cpu.r1.de = 0x668D;
            cpu.r1.hl = 0x6E4A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB0A8;
            cpu.r1.iy = 0x62C8;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xF0);
            memory.Write8(0x0003, 0x6D);
            memory.Write8(0x62B8, 0xE3);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6330, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD077, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x668D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6E4A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB0A8, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x62C8, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB6E() {
            cpu.Reset();
            cpu.r1.af = 0x2DA0;
            cpu.r1.bc = 0xF872;
            cpu.r1.de = 0x692D;
            cpu.r1.hl = 0x92C4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x36B5;
            cpu.r1.iy = 0x4210;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x93);
            memory.Write8(0x0003, 0x6E);
            memory.Write8(0x41A3, 0x1E);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2D54, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF872, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x692D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x92C4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x36B5, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4210, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB6F() {
            cpu.Reset();
            cpu.r1.af = 0xDF7B;
            cpu.r1.bc = 0xC7AA;
            cpu.r1.de = 0x9002;
            cpu.r1.hl = 0x86B8;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1347;
            cpu.r1.iy = 0x004E;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x20);
            memory.Write8(0x0003, 0x6F);
            memory.Write8(0x006E, 0x37);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDF11, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC7AA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9002, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x86B8, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1347, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x004E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB70() {
            cpu.Reset();
            cpu.r1.af = 0x6EA9;
            cpu.r1.bc = 0x018D;
            cpu.r1.de = 0x5075;
            cpu.r1.hl = 0xCF4E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xCD2B;
            cpu.r1.iy = 0x3E68;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xD9);
            memory.Write8(0x0003, 0x70);
            memory.Write8(0x3E41, 0xC9);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6E39, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x018D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5075, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCF4E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xCD2B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x3E68, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB71() {
            cpu.Reset();
            cpu.r1.af = 0x1B48;
            cpu.r1.bc = 0xE3AF;
            cpu.r1.de = 0x94D5;
            cpu.r1.hl = 0x0996;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xCAD5;
            cpu.r1.iy = 0x999A;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x27);
            memory.Write8(0x0003, 0x71);
            memory.Write8(0x99C1, 0x3E);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1B5C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE3AF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x94D5, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0996, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xCAD5, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x999A, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB72() {
            cpu.Reset();
            cpu.r1.af = 0xE83B;
            cpu.r1.bc = 0x26B1;
            cpu.r1.de = 0x8608;
            cpu.r1.hl = 0xF3CB;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6323;
            cpu.r1.iy = 0xFD31;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x98);
            memory.Write8(0x0003, 0x72);
            memory.Write8(0xFCC9, 0x4F);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE839, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x26B1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8608, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF3CB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6323, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xFD31, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB73() {
            cpu.Reset();
            cpu.r1.af = 0x101B;
            cpu.r1.bc = 0x446C;
            cpu.r1.de = 0xC2F9;
            cpu.r1.hl = 0xB9B1;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0820;
            cpu.r1.iy = 0xF5D8;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x7A);
            memory.Write8(0x0003, 0x73);
            memory.Write8(0xF652, 0x31);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1075, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x446C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC2F9, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB9B1, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0820, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xF5D8, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB74() {
            cpu.Reset();
            cpu.r1.af = 0x6847;
            cpu.r1.bc = 0x38C2;
            cpu.r1.de = 0x0EA4;
            cpu.r1.hl = 0x0825;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xD255;
            cpu.r1.iy = 0x5E4A;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x4B);
            memory.Write8(0x0003, 0x74);
            memory.Write8(0x5E95, 0xFE);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6819, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x38C2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0EA4, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0825, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xD255, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5E4A, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB75() {
            cpu.Reset();
            cpu.r1.af = 0x56F2;
            cpu.r1.bc = 0xC034;
            cpu.r1.de = 0x6E11;
            cpu.r1.hl = 0xD35E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE702;
            cpu.r1.iy = 0x60BE;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x57);
            memory.Write8(0x0003, 0x75);
            memory.Write8(0x6115, 0x21);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5674, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC034, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6E11, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD35E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE702, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x60BE, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB76() {
            cpu.Reset();
            cpu.r1.af = 0x7375;
            cpu.r1.bc = 0xCAFF;
            cpu.r1.de = 0xDD80;
            cpu.r1.hl = 0xC8ED;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7E39;
            cpu.r1.iy = 0x6623;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x53);
            memory.Write8(0x0003, 0x76);
            memory.Write8(0x6676, 0x3A);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7375, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCAFF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDD80, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC8ED, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7E39, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6623, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB77() {
            cpu.Reset();
            cpu.r1.af = 0xAB10;
            cpu.r1.bc = 0x983E;
            cpu.r1.de = 0x0BDC;
            cpu.r1.hl = 0x3B46;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xAE51;
            cpu.r1.iy = 0x8841;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x02);
            memory.Write8(0x0003, 0x77);
            memory.Write8(0x8843, 0xD8);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAB18, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x983E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0BDC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3B46, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xAE51, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8841, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB78() {
            cpu.Reset();
            cpu.r1.af = 0x2765;
            cpu.r1.bc = 0xCE2F;
            cpu.r1.de = 0x4824;
            cpu.r1.hl = 0x6930;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xAE69;
            cpu.r1.iy = 0xFECB;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x7D);
            memory.Write8(0x0003, 0x78);
            memory.Write8(0xFF48, 0xEC);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x27B9, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCE2F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4824, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6930, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xAE69, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xFECB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB79() {
            cpu.Reset();
            cpu.r1.af = 0xB428;
            cpu.r1.bc = 0x6355;
            cpu.r1.de = 0x7896;
            cpu.r1.hl = 0x8A7C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9090;
            cpu.r1.iy = 0x1CAE;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x23);
            memory.Write8(0x0003, 0x79);
            memory.Write8(0x1CD1, 0x87);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB498, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6355, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7896, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8A7C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9090, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1CAE, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB7A() {
            cpu.Reset();
            cpu.r1.af = 0x59F4;
            cpu.r1.bc = 0xCA21;
            cpu.r1.de = 0x1482;
            cpu.r1.hl = 0x3FAE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC6C9;
            cpu.r1.iy = 0xD923;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x42);
            memory.Write8(0x0003, 0x7A);
            memory.Write8(0xD965, 0xB3);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5998, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCA21, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1482, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3FAE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC6C9, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD923, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB7B() {
            cpu.Reset();
            cpu.r1.af = 0x6314;
            cpu.r1.bc = 0x0240;
            cpu.r1.de = 0x5EFA;
            cpu.r1.hl = 0x5E7B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x3E50;
            cpu.r1.iy = 0x0A83;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x17);
            memory.Write8(0x0003, 0x7B);
            memory.Write8(0x0A9A, 0xBD);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6398, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0240, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5EFA, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5E7B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x3E50, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0A83, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB7C() {
            cpu.Reset();
            cpu.r1.af = 0x22A6;
            cpu.r1.bc = 0xAFF4;
            cpu.r1.de = 0xB89B;
            cpu.r1.hl = 0x4DCA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0AC2;
            cpu.r1.iy = 0xD371;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xF1);
            memory.Write8(0x0003, 0x7C);
            memory.Write8(0xD362, 0x1B);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2254, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAFF4, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB89B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4DCA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0AC2, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD371, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB7D() {
            cpu.Reset();
            cpu.r1.af = 0x1C95;
            cpu.r1.bc = 0xD615;
            cpu.r1.de = 0x825A;
            cpu.r1.hl = 0x5E64;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x32FB;
            cpu.r1.iy = 0xAC3B;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x9F);
            memory.Write8(0x0003, 0x7D);
            memory.Write8(0xABDA, 0x8A);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1CB9, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD615, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x825A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5E64, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x32FB, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xAC3B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB7E() {
            cpu.Reset();
            cpu.r1.af = 0x503C;
            cpu.r1.bc = 0x8DFE;
            cpu.r1.de = 0x1019;
            cpu.r1.hl = 0x6778;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xF7DF;
            cpu.r1.iy = 0x9484;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x40);
            memory.Write8(0x0003, 0x7E);
            memory.Write8(0x94C4, 0x9E);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5090, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8DFE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1019, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6778, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xF7DF, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x9484, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB7F() {
            cpu.Reset();
            cpu.r1.af = 0x1B07;
            cpu.r1.bc = 0x9EC3;
            cpu.r1.de = 0x14BE;
            cpu.r1.hl = 0x5EBE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1178;
            cpu.r1.iy = 0xCE69;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xA2);
            memory.Write8(0x0003, 0x7F);
            memory.Write8(0xCE0B, 0x47);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1B5D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9EC3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x14BE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5EBE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1178, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xCE69, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB80() {
            cpu.Reset();
            cpu.r1.af = 0xE196;
            cpu.r1.bc = 0x72EA;
            cpu.r1.de = 0x507E;
            cpu.r1.hl = 0x6457;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xAB75;
            cpu.r1.iy = 0x920D;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x8B);
            memory.Write8(0x0003, 0x80);
            memory.Write8(0x9198, 0xA9);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE196, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA8EA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x507E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6457, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xAB75, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x920D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB81() {
            cpu.Reset();
            cpu.r1.af = 0x3D3D;
            cpu.r1.bc = 0xB255;
            cpu.r1.de = 0x8759;
            cpu.r1.hl = 0x0CB0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE078;
            cpu.r1.iy = 0x82A5;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x55);
            memory.Write8(0x0003, 0x81);
            memory.Write8(0x82FA, 0xFA);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3D3D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB2FA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8759, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0CB0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE078, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x82A5, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB82() {
            cpu.Reset();
            cpu.r1.af = 0x4E10;
            cpu.r1.bc = 0x5D8D;
            cpu.r1.de = 0x27A0;
            cpu.r1.hl = 0xFFFF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xEE0A;
            cpu.r1.iy = 0x5DD8;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x9C);
            memory.Write8(0x0003, 0x82);
            memory.Write8(0x5D74, 0x9D);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4E10, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5D8D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9CA0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xFFFF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xEE0A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5DD8, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB83() {
            cpu.Reset();
            cpu.r1.af = 0x3C7F;
            cpu.r1.bc = 0xFD81;
            cpu.r1.de = 0x47FB;
            cpu.r1.hl = 0x9F12;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xCBF9;
            cpu.r1.iy = 0x374A;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x28);
            memory.Write8(0x0003, 0x83);
            memory.Write8(0x3772, 0xD5);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3C7F, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFD81, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x47D4, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9F12, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xCBF9, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x374A, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB84() {
            cpu.Reset();
            cpu.r1.af = 0x6872;
            cpu.r1.bc = 0x81B1;
            cpu.r1.de = 0x1E7A;
            cpu.r1.hl = 0xE37E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9B4C;
            cpu.r1.iy = 0xF1C3;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xAA);
            memory.Write8(0x0003, 0x84);
            memory.Write8(0xF16D, 0xEA);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6872, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x81B1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1E7A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xEA7E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9B4C, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xF1C3, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB85() {
            cpu.Reset();
            cpu.r1.af = 0x25B3;
            cpu.r1.bc = 0x5694;
            cpu.r1.de = 0x57CD;
            cpu.r1.hl = 0xF34D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x8ED2;
            cpu.r1.iy = 0x0433;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x6C);
            memory.Write8(0x0003, 0x85);
            memory.Write8(0x049F, 0xE0);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x25B3, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5694, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x57CD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF3E0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x8ED2, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0433, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB86() {
            cpu.Reset();
            cpu.r1.af = 0x152B;
            cpu.r1.bc = 0x8CE1;
            cpu.r1.de = 0x818D;
            cpu.r1.hl = 0x40F2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9B7A;
            cpu.r1.iy = 0x2A50;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x7E);
            memory.Write8(0x0003, 0x86);
            memory.Write8(0x2ACE, 0x36);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x152B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8CE1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x818D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x40F2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9B7A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x2A50, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB87() {
            cpu.Reset();
            cpu.r1.af = 0xFE1D;
            cpu.r1.bc = 0x5353;
            cpu.r1.de = 0x618D;
            cpu.r1.hl = 0x3266;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1A53;
            cpu.r1.iy = 0x246A;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x59);
            memory.Write8(0x0003, 0x87);
            memory.Write8(0x24C3, 0x65);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x641D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5353, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x618D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3266, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1A53, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x246A, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB88() {
            cpu.Reset();
            cpu.r1.af = 0x7D14;
            cpu.r1.bc = 0xA0EC;
            cpu.r1.de = 0x1E47;
            cpu.r1.hl = 0x76E1;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x3871;
            cpu.r1.iy = 0xC60D;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xD4);
            memory.Write8(0x0003, 0x88);
            memory.Write8(0xC5E1, 0xD6);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7D14, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD4EC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1E47, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x76E1, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x3871, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC60D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB89() {
            cpu.Reset();
            cpu.r1.af = 0x86C3;
            cpu.r1.bc = 0x50A6;
            cpu.r1.de = 0x8592;
            cpu.r1.hl = 0xD6CA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x947B;
            cpu.r1.iy = 0x0A01;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xC3);
            memory.Write8(0x0003, 0x89);
            memory.Write8(0x09C4, 0xB0);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x86C3, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x50B0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8592, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD6CA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x947B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0A01, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB8A() {
            cpu.Reset();
            cpu.r1.af = 0x599C;
            cpu.r1.bc = 0x961A;
            cpu.r1.de = 0x55F9;
            cpu.r1.hl = 0x8470;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xD2A5;
            cpu.r1.iy = 0xD4D2;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xF9);
            memory.Write8(0x0003, 0x8A);
            memory.Write8(0xD4CB, 0xD8);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x599C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x961A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD8F9, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8470, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xD2A5, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD4D2, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB8B() {
            cpu.Reset();
            cpu.r1.af = 0x2715;
            cpu.r1.bc = 0xA209;
            cpu.r1.de = 0xAB47;
            cpu.r1.hl = 0x3EAC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xF352;
            cpu.r1.iy = 0xC71E;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xED);
            memory.Write8(0x0003, 0x8B);
            memory.Write8(0xC70B, 0xDC);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2715, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA209, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xABDC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3EAC, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xF352, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC71E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB8C() {
            cpu.Reset();
            cpu.r1.af = 0x2818;
            cpu.r1.bc = 0x4259;
            cpu.r1.de = 0xA9B0;
            cpu.r1.hl = 0xE7A0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6471;
            cpu.r1.iy = 0xA202;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x97);
            memory.Write8(0x0003, 0x8C);
            memory.Write8(0xA199, 0x67);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2818, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4259, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA9B0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x65A0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6471, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA202, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB8D() {
            cpu.Reset();
            cpu.r1.af = 0x14E3;
            cpu.r1.bc = 0xC330;
            cpu.r1.de = 0x9AA2;
            cpu.r1.hl = 0x8418;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0D4F;
            cpu.r1.iy = 0x5669;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xC9);
            memory.Write8(0x0003, 0x8D);
            memory.Write8(0x5632, 0x9A);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x14E3, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC330, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9AA2, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8498, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0D4F, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5669, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB8E() {
            cpu.Reset();
            cpu.r1.af = 0xCB79;
            cpu.r1.bc = 0x0FFF;
            cpu.r1.de = 0xB244;
            cpu.r1.hl = 0xC902;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6246;
            cpu.r1.iy = 0x4C81;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xC2);
            memory.Write8(0x0003, 0x8E);
            memory.Write8(0x4C43, 0x7F);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCB79, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0FFF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB244, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC902, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6246, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4C81, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB8F() {
            cpu.Reset();
            cpu.r1.af = 0x66B4;
            cpu.r1.bc = 0x5FBB;
            cpu.r1.de = 0x6C9B;
            cpu.r1.hl = 0xD0E3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xAC5A;
            cpu.r1.iy = 0x6B51;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xD4);
            memory.Write8(0x0003, 0x8F);
            memory.Write8(0x6B25, 0x59);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x59B4, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5FBB, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6C9B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD0E3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xAC5A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6B51, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB90() {
            cpu.Reset();
            cpu.r1.af = 0x1305;
            cpu.r1.bc = 0x1CE1;
            cpu.r1.de = 0xD627;
            cpu.r1.hl = 0x7402;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB470;
            cpu.r1.iy = 0xD7F5;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xFD);
            memory.Write8(0x0003, 0x90);
            memory.Write8(0xD7F2, 0x70);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1305, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x70E1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD627, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7402, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB470, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD7F5, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB91() {
            cpu.Reset();
            cpu.r1.af = 0x10DF;
            cpu.r1.bc = 0xC48F;
            cpu.r1.de = 0x0213;
            cpu.r1.hl = 0xFC7E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xBFAB;
            cpu.r1.iy = 0x47D2;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xBF);
            memory.Write8(0x0003, 0x91);
            memory.Write8(0x4791, 0x0E);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x10DF, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC40A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0213, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xFC7E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xBFAB, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x47D2, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB92() {
            cpu.Reset();
            cpu.r1.af = 0x6A11;
            cpu.r1.bc = 0xF89E;
            cpu.r1.de = 0xF49D;
            cpu.r1.hl = 0xC115;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xBC5D;
            cpu.r1.iy = 0x313A;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x0B);
            memory.Write8(0x0003, 0x92);
            memory.Write8(0x3145, 0xF6);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6A11, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF89E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF29D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC115, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xBC5D, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x313A, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB93() {
            cpu.Reset();
            cpu.r1.af = 0x61E5;
            cpu.r1.bc = 0xCC2C;
            cpu.r1.de = 0x959A;
            cpu.r1.hl = 0xB52B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xFA64;
            cpu.r1.iy = 0x2940;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x52);
            memory.Write8(0x0003, 0x93);
            memory.Write8(0x2992, 0x38);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x61E5, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCC2C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9538, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB52B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xFA64, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x2940, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB94() {
            cpu.Reset();
            cpu.r1.af = 0x31B4;
            cpu.r1.bc = 0x3E5A;
            cpu.r1.de = 0xFB3D;
            cpu.r1.hl = 0xAB83;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xA801;
            cpu.r1.iy = 0xFE1C;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x95);
            memory.Write8(0x0003, 0x94);
            memory.Write8(0xFDB1, 0x48);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x31B4, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3E5A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xFB3D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4883, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xA801, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xFE1C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB95() {
            cpu.Reset();
            cpu.r1.af = 0x337E;
            cpu.r1.bc = 0x63A7;
            cpu.r1.de = 0x2918;
            cpu.r1.hl = 0xED6B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB12C;
            cpu.r1.iy = 0xE776;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x90);
            memory.Write8(0x0003, 0x95);
            memory.Write8(0xE706, 0xEB);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x337E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x63A7, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2918, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xEDEB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB12C, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE776, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB96() {
            cpu.Reset();
            cpu.r1.af = 0x5D99;
            cpu.r1.bc = 0xD9EC;
            cpu.r1.de = 0xB6D0;
            cpu.r1.hl = 0x5ED5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5D9D;
            cpu.r1.iy = 0xE6CF;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x9E);
            memory.Write8(0x0003, 0x96);
            memory.Write8(0xE66D, 0xFC);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5D99, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD9EC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB6D0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5ED5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5D9D, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE6CF, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB97() {
            cpu.Reset();
            cpu.r1.af = 0xCCB6;
            cpu.r1.bc = 0x8406;
            cpu.r1.de = 0x72C6;
            cpu.r1.hl = 0x1BA7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6DCA;
            cpu.r1.iy = 0x187F;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x64);
            memory.Write8(0x0003, 0x97);
            memory.Write8(0x18E3, 0x9D);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x99B6, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8406, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x72C6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1BA7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6DCA, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x187F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB98() {
            cpu.Reset();
            cpu.r1.af = 0x0495;
            cpu.r1.bc = 0x312F;
            cpu.r1.de = 0x8000;
            cpu.r1.hl = 0xB749;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE9CB;
            cpu.r1.iy = 0x43B8;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xDA);
            memory.Write8(0x0003, 0x98);
            memory.Write8(0x4392, 0x15);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0495, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x152F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB749, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE9CB, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x43B8, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB99() {
            cpu.Reset();
            cpu.r1.af = 0x2824;
            cpu.r1.bc = 0xA485;
            cpu.r1.de = 0xA30B;
            cpu.r1.hl = 0xB286;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x10B0;
            cpu.r1.iy = 0xD86C;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x78);
            memory.Write8(0x0003, 0x99);
            memory.Write8(0xD8E4, 0xB5);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2824, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA4B5, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA30B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB286, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x10B0, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD86C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB9A() {
            cpu.Reset();
            cpu.r1.af = 0xB0CC;
            cpu.r1.bc = 0xC40C;
            cpu.r1.de = 0xDC1A;
            cpu.r1.hl = 0x014A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x2FF9;
            cpu.r1.iy = 0xD717;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x9C);
            memory.Write8(0x0003, 0x9A);
            memory.Write8(0xD6B3, 0x9D);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB0CC, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC40C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x951A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x014A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x2FF9, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD717, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB9B() {
            cpu.Reset();
            cpu.r1.af = 0xD092;
            cpu.r1.bc = 0xA6C2;
            cpu.r1.de = 0x7900;
            cpu.r1.hl = 0x5448;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xFAB0;
            cpu.r1.iy = 0xCB1E;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x83);
            memory.Write8(0x0003, 0x9B);
            memory.Write8(0xCAA1, 0x95);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD092, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA6C2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7995, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5448, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xFAB0, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xCB1E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB9C() {
            cpu.Reset();
            cpu.r1.af = 0xB58D;
            cpu.r1.bc = 0x1ED1;
            cpu.r1.de = 0xE93B;
            cpu.r1.hl = 0x9E0C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5605;
            cpu.r1.iy = 0x03B3;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x1E);
            memory.Write8(0x0003, 0x9C);
            memory.Write8(0x03D1, 0x78);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB58D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1ED1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE93B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x700C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5605, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x03B3, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB9D() {
            cpu.Reset();
            cpu.r1.af = 0xC7E9;
            cpu.r1.bc = 0x18D3;
            cpu.r1.de = 0x8EED;
            cpu.r1.hl = 0xBD7D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9A7F;
            cpu.r1.iy = 0xC087;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xE6);
            memory.Write8(0x0003, 0x9D);
            memory.Write8(0xC06D, 0x53);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC7E9, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x18D3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8EED, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xBD53, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9A7F, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC087, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB9E() {
            cpu.Reset();
            cpu.r1.af = 0x81C7;
            cpu.r1.bc = 0x71DF;
            cpu.r1.de = 0x45D5;
            cpu.r1.hl = 0x0CA7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x648F;
            cpu.r1.iy = 0x41BD;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xEB);
            memory.Write8(0x0003, 0x9E);
            memory.Write8(0x41A8, 0x61);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x81C7, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x71DF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x45D5, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0CA7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x648F, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x41BD, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCB9F() {
            cpu.Reset();
            cpu.r1.af = 0xEBF5;
            cpu.r1.bc = 0xDC9F;
            cpu.r1.de = 0xD490;
            cpu.r1.hl = 0x15BE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0E12;
            cpu.r1.iy = 0x9D49;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x50);
            memory.Write8(0x0003, 0x9F);
            memory.Write8(0x9D99, 0x89);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x81F5, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xDC9F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD490, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x15BE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0E12, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x9D49, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBA0() {
            cpu.Reset();
            cpu.r1.af = 0x8CCB;
            cpu.r1.bc = 0x0057;
            cpu.r1.de = 0xBC19;
            cpu.r1.hl = 0xE543;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x8C5D;
            cpu.r1.iy = 0xD68D;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x76);
            memory.Write8(0x0003, 0xA0);
            memory.Write8(0xD703, 0xD4);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8CCB, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC457, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xBC19, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE543, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x8C5D, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD68D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBA1() {
            cpu.Reset();
            cpu.r1.af = 0xEEE6;
            cpu.r1.bc = 0x6DA4;
            cpu.r1.de = 0x3A20;
            cpu.r1.hl = 0x8BBA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1DE7;
            cpu.r1.iy = 0x66C8;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x31);
            memory.Write8(0x0003, 0xA1);
            memory.Write8(0x66F9, 0xEC);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xEEE6, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6DEC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3A20, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8BBA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1DE7, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x66C8, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBA2() {
            cpu.Reset();
            cpu.r1.af = 0x3F89;
            cpu.r1.bc = 0x5120;
            cpu.r1.de = 0x0BD1;
            cpu.r1.hl = 0xE669;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x2993;
            cpu.r1.iy = 0x04BF;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x0E);
            memory.Write8(0x0003, 0xA2);
            memory.Write8(0x04CD, 0x47);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3F89, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5120, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x47D1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE669, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x2993, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x04BF, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBA3() {
            cpu.Reset();
            cpu.r1.af = 0x4439;
            cpu.r1.bc = 0x6B8B;
            cpu.r1.de = 0x6178;
            cpu.r1.hl = 0x1246;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x4CDB;
            cpu.r1.iy = 0xAD77;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x05);
            memory.Write8(0x0003, 0xA3);
            memory.Write8(0xAD7C, 0x59);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4439, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6B8B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6149, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1246, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x4CDB, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xAD77, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBA4() {
            cpu.Reset();
            cpu.r1.af = 0x3385;
            cpu.r1.bc = 0x261E;
            cpu.r1.de = 0xA487;
            cpu.r1.hl = 0xB3BD;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x4B8F;
            cpu.r1.iy = 0xC0CD;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x66);
            memory.Write8(0x0003, 0xA4);
            memory.Write8(0xC133, 0xC5);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3385, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x261E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA487, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC5BD, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x4B8F, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC0CD, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBA5() {
            cpu.Reset();
            cpu.r1.af = 0x6E70;
            cpu.r1.bc = 0xB7ED;
            cpu.r1.de = 0x22CD;
            cpu.r1.hl = 0xAEDC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x46DE;
            cpu.r1.iy = 0xF1A1;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xA0);
            memory.Write8(0x0003, 0xA5);
            memory.Write8(0xF141, 0x44);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6E70, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB7ED, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x22CD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAE44, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x46DE, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xF1A1, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBA6() {
            cpu.Reset();
            cpu.r1.af = 0x814B;
            cpu.r1.bc = 0x6408;
            cpu.r1.de = 0x3DCB;
            cpu.r1.hl = 0x971F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5716;
            cpu.r1.iy = 0x93F3;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x76);
            memory.Write8(0x0003, 0xA6);
            memory.Write8(0x9469, 0xBC);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x814B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6408, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3DCB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x971F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5716, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x93F3, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBA7() {
            cpu.Reset();
            cpu.r1.af = 0xA4C2;
            cpu.r1.bc = 0x679E;
            cpu.r1.de = 0xC313;
            cpu.r1.hl = 0x61DF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x67E6;
            cpu.r1.iy = 0x79C4;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x66);
            memory.Write8(0x0003, 0xA7);
            memory.Write8(0x7A2A, 0x2E);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2EC2, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x679E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC313, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x61DF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x67E6, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x79C4, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBA8() {
            cpu.Reset();
            cpu.r1.af = 0x537C;
            cpu.r1.bc = 0x1FED;
            cpu.r1.de = 0x6CBB;
            cpu.r1.hl = 0xBD26;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC638;
            cpu.r1.iy = 0x0D46;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xA9);
            memory.Write8(0x0003, 0xA8);
            memory.Write8(0x0CEF, 0xB7);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x537C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x97ED, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6CBB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xBD26, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC638, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0D46, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBA9() {
            cpu.Reset();
            cpu.r1.af = 0xBA5A;
            cpu.r1.bc = 0x3076;
            cpu.r1.de = 0xCDD7;
            cpu.r1.hl = 0x298D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x59AB;
            cpu.r1.iy = 0x0F54;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x2B);
            memory.Write8(0x0003, 0xA9);
            memory.Write8(0x0F7F, 0x8F);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xBA5A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x308F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xCDD7, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x298D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x59AB, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0F54, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBAA() {
            cpu.Reset();
            cpu.r1.af = 0x406A;
            cpu.r1.bc = 0x2ED6;
            cpu.r1.de = 0xFA8C;
            cpu.r1.hl = 0xC633;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x87CB;
            cpu.r1.iy = 0xB3D1;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x0B);
            memory.Write8(0x0003, 0xAA);
            memory.Write8(0xB3DC, 0x3A);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x406A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2ED6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1A8C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC633, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x87CB, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB3D1, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBAB() {
            cpu.Reset();
            cpu.r1.af = 0xDA61;
            cpu.r1.bc = 0x0521;
            cpu.r1.de = 0xA123;
            cpu.r1.hl = 0xC7FA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB71A;
            cpu.r1.iy = 0x8ECE;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xA9);
            memory.Write8(0x0003, 0xAB);
            memory.Write8(0x8E77, 0x1F);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDA61, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0521, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA11F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC7FA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB71A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8ECE, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBAC() {
            cpu.Reset();
            cpu.r1.af = 0x34A3;
            cpu.r1.bc = 0x81CE;
            cpu.r1.de = 0x07D6;
            cpu.r1.hl = 0xF3A4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x430B;
            cpu.r1.iy = 0x0525;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x23);
            memory.Write8(0x0003, 0xAC);
            memory.Write8(0x0548, 0x9C);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x34A3, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x81CE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x07D6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9CA4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x430B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0525, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBAD() {
            cpu.Reset();
            cpu.r1.af = 0x5010;
            cpu.r1.bc = 0x918E;
            cpu.r1.de = 0xDDBC;
            cpu.r1.hl = 0x4F89;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x88C5;
            cpu.r1.iy = 0x948F;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x4E);
            memory.Write8(0x0003, 0xAD);
            memory.Write8(0x94DD, 0x37);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5010, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x918E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDDBC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4F17, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x88C5, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x948F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBAE() {
            cpu.Reset();
            cpu.r1.af = 0xEC0D;
            cpu.r1.bc = 0xB57E;
            cpu.r1.de = 0x18C6;
            cpu.r1.hl = 0x7B01;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xBAC6;
            cpu.r1.iy = 0x0C1D;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x0C);
            memory.Write8(0x0003, 0xAE);
            memory.Write8(0x0C29, 0xA9);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xEC0D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB57E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x18C6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7B01, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xBAC6, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0C1D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBAF() {
            cpu.Reset();
            cpu.r1.af = 0xB322;
            cpu.r1.bc = 0x6731;
            cpu.r1.de = 0xDAAD;
            cpu.r1.hl = 0x8D38;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xDD8F;
            cpu.r1.iy = 0x26EB;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x0D);
            memory.Write8(0x0003, 0xAF);
            memory.Write8(0x26F8, 0x44);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4422, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6731, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDAAD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8D38, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xDD8F, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x26EB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBB0() {
            cpu.Reset();
            cpu.r1.af = 0xB984;
            cpu.r1.bc = 0x796C;
            cpu.r1.de = 0x44B1;
            cpu.r1.hl = 0xFEF9;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x4069;
            cpu.r1.iy = 0xA0CB;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x5A);
            memory.Write8(0x0003, 0xB0);
            memory.Write8(0xA125, 0x76);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB984, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x366C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x44B1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xFEF9, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x4069, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA0CB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBB1() {
            cpu.Reset();
            cpu.r1.af = 0x59C3;
            cpu.r1.bc = 0xAB13;
            cpu.r1.de = 0x42EE;
            cpu.r1.hl = 0xB764;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x8F7F;
            cpu.r1.iy = 0xF398;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x82);
            memory.Write8(0x0003, 0xB1);
            memory.Write8(0xF31A, 0x79);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x59C3, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAB39, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x42EE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB764, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x8F7F, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xF398, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBB2() {
            cpu.Reset();
            cpu.r1.af = 0xF310;
            cpu.r1.bc = 0xCEEC;
            cpu.r1.de = 0xBBFB;
            cpu.r1.hl = 0x3569;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x4A6F;
            cpu.r1.iy = 0x33F9;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x23);
            memory.Write8(0x0003, 0xB2);
            memory.Write8(0x341C, 0x7B);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF310, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCEEC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3BFB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3569, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x4A6F, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x33F9, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBB3() {
            cpu.Reset();
            cpu.r1.af = 0x9C05;
            cpu.r1.bc = 0x0F92;
            cpu.r1.de = 0xBD3B;
            cpu.r1.hl = 0x553D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC75E;
            cpu.r1.iy = 0x51D2;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x6C);
            memory.Write8(0x0003, 0xB3);
            memory.Write8(0x523E, 0x37);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9C05, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F92, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xBD37, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x553D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC75E, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x51D2, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBB4() {
            cpu.Reset();
            cpu.r1.af = 0x3E55;
            cpu.r1.bc = 0x1338;
            cpu.r1.de = 0x638D;
            cpu.r1.hl = 0x353C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x44AD;
            cpu.r1.iy = 0x4D17;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xC5);
            memory.Write8(0x0003, 0xB4);
            memory.Write8(0x4CDC, 0xE9);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3E55, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1338, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x638D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA93C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x44AD, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4D17, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBB5() {
            cpu.Reset();
            cpu.r1.af = 0x2F3A;
            cpu.r1.bc = 0xB709;
            cpu.r1.de = 0x4167;
            cpu.r1.hl = 0x57BE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB543;
            cpu.r1.iy = 0x8EDD;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x50);
            memory.Write8(0x0003, 0xB5);
            memory.Write8(0x8F2D, 0x0F);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2F3A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB709, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4167, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x570F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB543, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8EDD, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBB6() {
            cpu.Reset();
            cpu.r1.af = 0xA887;
            cpu.r1.bc = 0x519B;
            cpu.r1.de = 0xC91B;
            cpu.r1.hl = 0xCC91;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xA416;
            cpu.r1.iy = 0x1E16;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x3A);
            memory.Write8(0x0003, 0xB6);
            memory.Write8(0x1E50, 0x13);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA887, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x519B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC91B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCC91, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xA416, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1E16, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBB7() {
            cpu.Reset();
            cpu.r1.af = 0x1335;
            cpu.r1.bc = 0xA599;
            cpu.r1.de = 0x9FBF;
            cpu.r1.hl = 0xC111;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x8BC5;
            cpu.r1.iy = 0x00A9;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xC0);
            memory.Write8(0x0003, 0xB7);
            memory.Write8(0x0069, 0x38);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3835, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA599, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9FBF, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC111, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x8BC5, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x00A9, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBB8() {
            cpu.Reset();
            cpu.r1.af = 0xD146;
            cpu.r1.bc = 0x1138;
            cpu.r1.de = 0x1A45;
            cpu.r1.hl = 0x8259;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6A03;
            cpu.r1.iy = 0xD087;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x31);
            memory.Write8(0x0003, 0xB8);
            memory.Write8(0xD0B8, 0x17);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD146, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1738, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1A45, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8259, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6A03, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD087, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBB9() {
            cpu.Reset();
            cpu.r1.af = 0x757B;
            cpu.r1.bc = 0x0B9E;
            cpu.r1.de = 0x767B;
            cpu.r1.hl = 0x2AD1;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1498;
            cpu.r1.iy = 0xB84E;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x3B);
            memory.Write8(0x0003, 0xB9);
            memory.Write8(0xB889, 0xB4);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x757B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0B34, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x767B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2AD1, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1498, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB84E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBBA() {
            cpu.Reset();
            cpu.r1.af = 0x43EF;
            cpu.r1.bc = 0x1C58;
            cpu.r1.de = 0xDDA3;
            cpu.r1.hl = 0x4519;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB67B;
            cpu.r1.iy = 0x383F;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x38);
            memory.Write8(0x0003, 0xBA);
            memory.Write8(0x3877, 0xD6);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x43EF, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1C58, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x56A3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4519, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB67B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x383F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBBB() {
            cpu.Reset();
            cpu.r1.af = 0xDCCB;
            cpu.r1.bc = 0x7AB3;
            cpu.r1.de = 0x7615;
            cpu.r1.hl = 0x4161;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x2942;
            cpu.r1.iy = 0xE2FE;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x07);
            memory.Write8(0x0003, 0xBB);
            memory.Write8(0xE305, 0x6E);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDCCB, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7AB3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x766E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4161, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x2942, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE2FE, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBBC() {
            cpu.Reset();
            cpu.r1.af = 0x0E07;
            cpu.r1.bc = 0x34F5;
            cpu.r1.de = 0x0995;
            cpu.r1.hl = 0xCC42;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9D42;
            cpu.r1.iy = 0xAF0C;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xF8);
            memory.Write8(0x0003, 0xBC);
            memory.Write8(0xAF04, 0xCF);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0E07, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x34F5, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0995, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4F42, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9D42, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xAF0C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBBD() {
            cpu.Reset();
            cpu.r1.af = 0x30EF;
            cpu.r1.bc = 0xE60C;
            cpu.r1.de = 0x9BF0;
            cpu.r1.hl = 0xA1BF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xBD1C;
            cpu.r1.iy = 0xDF0D;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xAA);
            memory.Write8(0x0003, 0xBD);
            memory.Write8(0xDEB7, 0x8D);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x30EF, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE60C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9BF0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA10D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xBD1C, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xDF0D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBBE() {
            cpu.Reset();
            cpu.r1.af = 0x1133;
            cpu.r1.bc = 0xBEF6;
            cpu.r1.de = 0x5059;
            cpu.r1.hl = 0x1089;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xD558;
            cpu.r1.iy = 0x3D0F;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xC8);
            memory.Write8(0x0003, 0xBE);
            memory.Write8(0x3CD7, 0xA1);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1133, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBEF6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5059, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1089, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xD558, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x3D0F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBBF() {
            cpu.Reset();
            cpu.r1.af = 0x83D6;
            cpu.r1.bc = 0xC893;
            cpu.r1.de = 0x8DB8;
            cpu.r1.hl = 0x716B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0956;
            cpu.r1.iy = 0xBDE7;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xFD);
            memory.Write8(0x0003, 0xBF);
            memory.Write8(0xBDE4, 0xAC);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2CD6, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC893, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8DB8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x716B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0956, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xBDE7, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBC0() {
            cpu.Reset();
            cpu.r1.af = 0x3666;
            cpu.r1.bc = 0x676C;
            cpu.r1.de = 0x35E5;
            cpu.r1.hl = 0xDB0A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xEA93;
            cpu.r1.iy = 0x2B31;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x0A);
            memory.Write8(0x0003, 0xC0);
            memory.Write8(0x2B3B, 0xEC);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3666, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xED6C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x35E5, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDB0A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xEA93, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x2B31, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBC1() {
            cpu.Reset();
            cpu.r1.af = 0x3902;
            cpu.r1.bc = 0xD498;
            cpu.r1.de = 0xAF62;
            cpu.r1.hl = 0x9821;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x48B8;
            cpu.r1.iy = 0xBD67;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x87);
            memory.Write8(0x0003, 0xC1);
            memory.Write8(0xBCEE, 0xEE);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3902, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD4EF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xAF62, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9821, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x48B8, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xBD67, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBC2() {
            cpu.Reset();
            cpu.r1.af = 0xAD26;
            cpu.r1.bc = 0x5A6D;
            cpu.r1.de = 0x6762;
            cpu.r1.hl = 0x16C9;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x495A;
            cpu.r1.iy = 0x5B2C;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x8D);
            memory.Write8(0x0003, 0xC2);
            memory.Write8(0x5AB9, 0xC2);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAD26, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5A6D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC362, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x16C9, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x495A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5B2C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBC3() {
            cpu.Reset();
            cpu.r1.af = 0x3E6C;
            cpu.r1.bc = 0x9A74;
            cpu.r1.de = 0xA2EE;
            cpu.r1.hl = 0x9838;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xEAFA;
            cpu.r1.iy = 0xE666;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x5A);
            memory.Write8(0x0003, 0xC3);
            memory.Write8(0xE6C0, 0x4F);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3E6C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9A74, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA24F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9838, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xEAFA, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE666, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBC4() {
            cpu.Reset();
            cpu.r1.af = 0xBF68;
            cpu.r1.bc = 0xD00B;
            cpu.r1.de = 0x5283;
            cpu.r1.hl = 0x51C2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x517C;
            cpu.r1.iy = 0x5D10;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x89);
            memory.Write8(0x0003, 0xC4);
            memory.Write8(0x5C99, 0x61);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xBF68, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD00B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5283, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x61C2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x517C, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5D10, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBC5() {
            cpu.Reset();
            cpu.r1.af = 0x127B;
            cpu.r1.bc = 0xDB6A;
            cpu.r1.de = 0x00B9;
            cpu.r1.hl = 0x5138;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x98F6;
            cpu.r1.iy = 0x02BB;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xA9);
            memory.Write8(0x0003, 0xC5);
            memory.Write8(0x0264, 0xCD);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x127B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xDB6A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x00B9, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x51CD, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x98F6, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x02BB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBC6() {
            cpu.Reset();
            cpu.r1.af = 0x35DA;
            cpu.r1.bc = 0x98C2;
            cpu.r1.de = 0x3F57;
            cpu.r1.hl = 0x44A4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x2771;
            cpu.r1.iy = 0x76C4;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xEE);
            memory.Write8(0x0003, 0xC6);
            memory.Write8(0x76B2, 0x82);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x35DA, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x98C2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3F57, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x44A4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x2771, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x76C4, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBC7() {
            cpu.Reset();
            cpu.r1.af = 0x763F;
            cpu.r1.bc = 0xB86F;
            cpu.r1.de = 0x12D3;
            cpu.r1.hl = 0x7E2D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xD870;
            cpu.r1.iy = 0xF30B;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x9E);
            memory.Write8(0x0003, 0xC7);
            memory.Write8(0xF2A9, 0xD7);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD73F, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB86F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x12D3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7E2D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xD870, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xF30B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBC8() {
            cpu.Reset();
            cpu.r1.af = 0x1F81;
            cpu.r1.bc = 0xC7C0;
            cpu.r1.de = 0x85DA;
            cpu.r1.hl = 0x3CDD;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xD854;
            cpu.r1.iy = 0xC412;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x10);
            memory.Write8(0x0003, 0xC8);
            memory.Write8(0xC422, 0xE9);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1F81, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xEBC0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x85DA, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3CDD, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xD854, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC412, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBC9() {
            cpu.Reset();
            cpu.r1.af = 0xED19;
            cpu.r1.bc = 0x3F88;
            cpu.r1.de = 0x1370;
            cpu.r1.hl = 0xE084;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x4FDD;
            cpu.r1.iy = 0x8B42;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x61);
            memory.Write8(0x0003, 0xC9);
            memory.Write8(0x8BA3, 0xB7);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xED19, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3FB7, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1370, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE084, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x4FDD, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8B42, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBCA() {
            cpu.Reset();
            cpu.r1.af = 0xC7E5;
            cpu.r1.bc = 0x233B;
            cpu.r1.de = 0x2312;
            cpu.r1.hl = 0xF7F9;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE417;
            cpu.r1.iy = 0x5190;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x1A);
            memory.Write8(0x0003, 0xCA);
            memory.Write8(0x51AA, 0x90);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC7E5, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x233B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9212, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF7F9, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE417, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5190, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBCB() {
            cpu.Reset();
            cpu.r1.af = 0xBDBA;
            cpu.r1.bc = 0xA964;
            cpu.r1.de = 0xEA38;
            cpu.r1.hl = 0x9422;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xFCA3;
            cpu.r1.iy = 0x9A72;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x5E);
            memory.Write8(0x0003, 0xCB);
            memory.Write8(0x9AD0, 0x70);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xBDBA, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA964, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xEA72, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9422, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xFCA3, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x9A72, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBCC() {
            cpu.Reset();
            cpu.r1.af = 0x0F4F;
            cpu.r1.bc = 0x0261;
            cpu.r1.de = 0x21B0;
            cpu.r1.hl = 0x2097;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x575D;
            cpu.r1.iy = 0x14F9;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x2D);
            memory.Write8(0x0003, 0xCC);
            memory.Write8(0x1526, 0x4E);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0F4F, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0261, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x21B0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4E97, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x575D, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x14F9, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBCD() {
            cpu.Reset();
            cpu.r1.af = 0x1B79;
            cpu.r1.bc = 0x8F9F;
            cpu.r1.de = 0x31BF;
            cpu.r1.hl = 0x9CA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7ECB;
            cpu.r1.iy = 0xBBE9;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xA1);
            memory.Write8(0x0003, 0xCD);
            memory.Write8(0xBB8A, 0x66);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1B79, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8F9F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x31BF, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9C66, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7ECB, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xBBE9, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBCE() {
            cpu.Reset();
            cpu.r1.af = 0x8E13;
            cpu.r1.bc = 0x968E;
            cpu.r1.de = 0x1784;
            cpu.r1.hl = 0x0A0A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1E87;
            cpu.r1.iy = 0xB8A2;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x36);
            memory.Write8(0x0003, 0xCE);
            memory.Write8(0xB8D8, 0x45);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8E13, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x968E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1784, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0A0A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1E87, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB8A2, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBCF() {
            cpu.Reset();
            cpu.r1.af = 0x8D0A;
            cpu.r1.bc = 0xA073;
            cpu.r1.de = 0xC4BA;
            cpu.r1.hl = 0x5B69;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x3B47;
            cpu.r1.iy = 0xC29C;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x70);
            memory.Write8(0x0003, 0xCF);
            memory.Write8(0xC30C, 0x7A);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7A0A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA073, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC4BA, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5B69, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x3B47, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC29C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBD0() {
            cpu.Reset();
            cpu.r1.af = 0xE2BB;
            cpu.r1.bc = 0x8635;
            cpu.r1.de = 0x650C;
            cpu.r1.hl = 0x689A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1294;
            cpu.r1.iy = 0x3BEB;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xBC);
            memory.Write8(0x0003, 0xD0);
            memory.Write8(0x3BA7, 0x20);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE2BB, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2435, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x650C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x689A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1294, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x3BEB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBD1() {
            cpu.Reset();
            cpu.r1.af = 0x5DF8;
            cpu.r1.bc = 0xF701;
            cpu.r1.de = 0x9494;
            cpu.r1.hl = 0x4967;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xAD00;
            cpu.r1.iy = 0x8C65;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x11);
            memory.Write8(0x0003, 0xD1);
            memory.Write8(0x8C76, 0xB9);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5DF8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF7BD, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9494, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4967, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xAD00, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8C65, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBD2() {
            cpu.Reset();
            cpu.r1.af = 0x9876;
            cpu.r1.bc = 0x4BD9;
            cpu.r1.de = 0x3148;
            cpu.r1.hl = 0x665A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7EAC;
            cpu.r1.iy = 0xC051;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xFB);
            memory.Write8(0x0003, 0xD2);
            memory.Write8(0xC04C, 0x51);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9876, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4BD9, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5548, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x665A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7EAC, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC051, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBD3() {
            cpu.Reset();
            cpu.r1.af = 0x8F90;
            cpu.r1.bc = 0xBACD;
            cpu.r1.de = 0xE87A;
            cpu.r1.hl = 0x538F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xFE5A;
            cpu.r1.iy = 0x0A87;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x3E);
            memory.Write8(0x0003, 0xD3);
            memory.Write8(0x0AC5, 0xE0);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8F90, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBACD, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE8E4, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x538F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xFE5A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0A87, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBD4() {
            cpu.Reset();
            cpu.r1.af = 0x15E2;
            cpu.r1.bc = 0x1820;
            cpu.r1.de = 0x5588;
            cpu.r1.hl = 0xE67F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7193;
            cpu.r1.iy = 0x9478;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x36);
            memory.Write8(0x0003, 0xD4);
            memory.Write8(0x94AE, 0x7D);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x15E2, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1820, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5588, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7D7F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7193, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x9478, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBD5() {
            cpu.Reset();
            cpu.r1.af = 0x1409;
            cpu.r1.bc = 0x6535;
            cpu.r1.de = 0xC371;
            cpu.r1.hl = 0xABE2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x2E10;
            cpu.r1.iy = 0x8608;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x48);
            memory.Write8(0x0003, 0xD5);
            memory.Write8(0x8650, 0x98);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1409, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6535, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC371, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAB9C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x2E10, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8608, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBD6() {
            cpu.Reset();
            cpu.r1.af = 0x7801;
            cpu.r1.bc = 0x78B6;
            cpu.r1.de = 0xD191;
            cpu.r1.hl = 0x054A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x2065;
            cpu.r1.iy = 0x6AA3;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xC9);
            memory.Write8(0x0003, 0xD6);
            memory.Write8(0x6A6C, 0x7C);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7801, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x78B6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD191, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x054A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x2065, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6AA3, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBD7() {
            cpu.Reset();
            cpu.r1.af = 0x1B6A;
            cpu.r1.bc = 0x266E;
            cpu.r1.de = 0x387F;
            cpu.r1.hl = 0x7FCB;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1941;
            cpu.r1.iy = 0x36AB;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xBE);
            memory.Write8(0x0003, 0xD7);
            memory.Write8(0x3669, 0x95);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x956A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x266E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x387F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7FCB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1941, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x36AB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBD8() {
            cpu.Reset();
            cpu.r1.af = 0x7B1B;
            cpu.r1.bc = 0xA191;
            cpu.r1.de = 0xEFEE;
            cpu.r1.hl = 0x55B9;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xF789;
            cpu.r1.iy = 0x43F8;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xBC);
            memory.Write8(0x0003, 0xD8);
            memory.Write8(0x43B4, 0xD8);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7B1B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD891, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xEFEE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x55B9, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xF789, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x43F8, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBD9() {
            cpu.Reset();
            cpu.r1.af = 0x0FAF;
            cpu.r1.bc = 0x4EDA;
            cpu.r1.de = 0xC556;
            cpu.r1.hl = 0x6ED3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x3FC3;
            cpu.r1.iy = 0x0A66;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x16);
            memory.Write8(0x0003, 0xD9);
            memory.Write8(0x0A7C, 0xF4);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0FAF, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4EFC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC556, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6ED3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x3FC3, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0A66, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBDA() {
            cpu.Reset();
            cpu.r1.af = 0x9EA1;
            cpu.r1.bc = 0x8186;
            cpu.r1.de = 0xC045;
            cpu.r1.hl = 0xD6E0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x34D3;
            cpu.r1.iy = 0xD0F0;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xE8);
            memory.Write8(0x0003, 0xDA);
            memory.Write8(0xD0D8, 0x6B);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9EA1, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8186, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6B45, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD6E0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x34D3, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD0F0, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBDB() {
            cpu.Reset();
            cpu.r1.af = 0x5EE0;
            cpu.r1.bc = 0xBDEA;
            cpu.r1.de = 0xD00E;
            cpu.r1.hl = 0x513F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x690A;
            cpu.r1.iy = 0x8C29;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x7A);
            memory.Write8(0x0003, 0xDB);
            memory.Write8(0x8CA3, 0x15);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5EE0, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBDEA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD01D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x513F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x690A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8C29, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBDC() {
            cpu.Reset();
            cpu.r1.af = 0x5CFA;
            cpu.r1.bc = 0x2E2B;
            cpu.r1.de = 0x1D17;
            cpu.r1.hl = 0xDBF6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xA4F2;
            cpu.r1.iy = 0x593A;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x64);
            memory.Write8(0x0003, 0xDC);
            memory.Write8(0x599E, 0x15);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5CFA, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2E2B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1D17, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1DF6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xA4F2, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x593A, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBDD() {
            cpu.Reset();
            cpu.r1.af = 0x8773;
            cpu.r1.bc = 0x70A6;
            cpu.r1.de = 0x83CE;
            cpu.r1.hl = 0x52B8;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x35DA;
            cpu.r1.iy = 0x1D94;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x75);
            memory.Write8(0x0003, 0xDD);
            memory.Write8(0x1E09, 0x28);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8773, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x70A6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x83CE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5228, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x35DA, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1D94, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBDE() {
            cpu.Reset();
            cpu.r1.af = 0x8310;
            cpu.r1.bc = 0xFA01;
            cpu.r1.de = 0x6C69;
            cpu.r1.hl = 0x252A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5291;
            cpu.r1.iy = 0xC9E0;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x17);
            memory.Write8(0x0003, 0xDE);
            memory.Write8(0xC9F7, 0x41);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8310, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFA01, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6C69, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x252A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5291, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC9E0, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBDF() {
            cpu.Reset();
            cpu.r1.af = 0x780D;
            cpu.r1.bc = 0xA722;
            cpu.r1.de = 0xE78E;
            cpu.r1.hl = 0x50BA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9D67;
            cpu.r1.iy = 0xEAC3;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x93);
            memory.Write8(0x0003, 0xDF);
            memory.Write8(0xEA56, 0xEF);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xEF0D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA722, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE78E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x50BA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9D67, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xEAC3, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBE0() {
            cpu.Reset();
            cpu.r1.af = 0x10EF;
            cpu.r1.bc = 0x4101;
            cpu.r1.de = 0x2CA5;
            cpu.r1.hl = 0xF752;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x4747;
            cpu.r1.iy = 0x1507;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x56);
            memory.Write8(0x0003, 0xE0);
            memory.Write8(0x155D, 0xB9);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x10EF, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB901, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2CA5, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF752, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x4747, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1507, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBE1() {
            cpu.Reset();
            cpu.r1.af = 0xE4CB;
            cpu.r1.bc = 0x6F72;
            cpu.r1.de = 0x1C11;
            cpu.r1.hl = 0x1426;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x189B;
            cpu.r1.iy = 0x0E0D;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xD1);
            memory.Write8(0x0003, 0xE1);
            memory.Write8(0x0DDE, 0x16);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE4CB, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6F16, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1C11, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1426, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x189B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0E0D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBE2() {
            cpu.Reset();
            cpu.r1.af = 0x11A9;
            cpu.r1.bc = 0xBAE8;
            cpu.r1.de = 0x938B;
            cpu.r1.hl = 0xBAC4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xD8ED;
            cpu.r1.iy = 0xE49C;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x50);
            memory.Write8(0x0003, 0xE2);
            memory.Write8(0xE4EC, 0xC2);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x11A9, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBAE8, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD28B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xBAC4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xD8ED, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE49C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBE3() {
            cpu.Reset();
            cpu.r1.af = 0x8832;
            cpu.r1.bc = 0x952B;
            cpu.r1.de = 0x02B2;
            cpu.r1.hl = 0x26EF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xFB55;
            cpu.r1.iy = 0xADA8;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xCA);
            memory.Write8(0x0003, 0xE3);
            memory.Write8(0xAD72, 0xBA);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8832, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x952B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x02BA, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x26EF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xFB55, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xADA8, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBE4() {
            cpu.Reset();
            cpu.r1.af = 0x3989;
            cpu.r1.bc = 0x4142;
            cpu.r1.de = 0x89E2;
            cpu.r1.hl = 0x785B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0BF7;
            cpu.r1.iy = 0x5474;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x62);
            memory.Write8(0x0003, 0xE4);
            memory.Write8(0x54D6, 0x7B);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3989, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4142, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x89E2, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7B5B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0BF7, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5474, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBE5() {
            cpu.Reset();
            cpu.r1.af = 0xE5C5;
            cpu.r1.bc = 0xB86D;
            cpu.r1.de = 0x41BB;
            cpu.r1.hl = 0x315E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1A78;
            cpu.r1.iy = 0xA52D;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xDA);
            memory.Write8(0x0003, 0xE5);
            memory.Write8(0xA507, 0x4C);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE5C5, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB86D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x41BB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x315C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1A78, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA52D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBE6() {
            cpu.Reset();
            cpu.r1.af = 0xFD89;
            cpu.r1.bc = 0xD888;
            cpu.r1.de = 0x1E2F;
            cpu.r1.hl = 0xDDF5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x42F5;
            cpu.r1.iy = 0x8B06;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x76);
            memory.Write8(0x0003, 0xE6);
            memory.Write8(0x8B7C, 0x45);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFD89, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD888, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1E2F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDDF5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x42F5, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8B06, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBE7() {
            cpu.Reset();
            cpu.r1.af = 0x2025;
            cpu.r1.bc = 0xD3E9;
            cpu.r1.de = 0xD4B6;
            cpu.r1.hl = 0xAA30;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x88BD;
            cpu.r1.iy = 0xB597;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x11);
            memory.Write8(0x0003, 0xE7);
            memory.Write8(0xB5A8, 0xA6);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB625, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD3E9, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD4B6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAA30, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x88BD, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB597, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBE8() {
            cpu.Reset();
            cpu.r1.af = 0x514D;
            cpu.r1.bc = 0xC2AB;
            cpu.r1.de = 0x37B5;
            cpu.r1.hl = 0x57DE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xA4EC;
            cpu.r1.iy = 0x0A77;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xED);
            memory.Write8(0x0003, 0xE8);
            memory.Write8(0x0A64, 0xD0);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x514D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF0AB, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x37B5, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x57DE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xA4EC, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0A77, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBE9() {
            cpu.Reset();
            cpu.r1.af = 0x974E;
            cpu.r1.bc = 0xD28E;
            cpu.r1.de = 0xD5CB;
            cpu.r1.hl = 0x6BD4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x158A;
            cpu.r1.iy = 0xA84E;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x35);
            memory.Write8(0x0003, 0xE9);
            memory.Write8(0xA883, 0x2F);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x974E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD22F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD5CB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6BD4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x158A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA84E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBEA() {
            cpu.Reset();
            cpu.r1.af = 0x3EF4;
            cpu.r1.bc = 0x3FC6;
            cpu.r1.de = 0x4A44;
            cpu.r1.hl = 0xE9A4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC877;
            cpu.r1.iy = 0x7593;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x93);
            memory.Write8(0x0003, 0xEA);
            memory.Write8(0x7526, 0x1B);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3EF4, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3FC6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3B44, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE9A4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC877, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7593, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBEB() {
            cpu.Reset();
            cpu.r1.af = 0x798F;
            cpu.r1.bc = 0x5E9B;
            cpu.r1.de = 0x940E;
            cpu.r1.hl = 0x2E52;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xD6AD;
            cpu.r1.iy = 0x2411;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xD0);
            memory.Write8(0x0003, 0xEB);
            memory.Write8(0x23E1, 0x47);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x798F, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5E9B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9467, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2E52, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xD6AD, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x2411, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBEC() {
            cpu.Reset();
            cpu.r1.af = 0x38A4;
            cpu.r1.bc = 0x07C0;
            cpu.r1.de = 0x6CEE;
            cpu.r1.hl = 0xE715;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xF160;
            cpu.r1.iy = 0xD2EB;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xF3);
            memory.Write8(0x0003, 0xEC);
            memory.Write8(0xD2DE, 0x49);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x38A4, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x07C0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6CEE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6915, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xF160, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD2EB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBED() {
            cpu.Reset();
            cpu.r1.af = 0xE0BC;
            cpu.r1.bc = 0x70C1;
            cpu.r1.de = 0xDE35;
            cpu.r1.hl = 0x81C5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xD57F;
            cpu.r1.iy = 0x0EAB;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x58);
            memory.Write8(0x0003, 0xED);
            memory.Write8(0x0F03, 0x10);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE0BC, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x70C1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDE35, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8130, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xD57F, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0EAB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBEE() {
            cpu.Reset();
            cpu.r1.af = 0x5FCB;
            cpu.r1.bc = 0x9007;
            cpu.r1.de = 0x1736;
            cpu.r1.hl = 0xACA8;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x4BAB;
            cpu.r1.iy = 0x42BC;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x02);
            memory.Write8(0x0003, 0xEE);
            memory.Write8(0x42BE, 0xD0);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5FCB, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9007, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1736, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xACA8, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x4BAB, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x42BC, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBEF() {
            cpu.Reset();
            cpu.r1.af = 0x4EE3;
            cpu.r1.bc = 0xD344;
            cpu.r1.de = 0xCB5B;
            cpu.r1.hl = 0xAEB5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xDE5F;
            cpu.r1.iy = 0x2272;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x58);
            memory.Write8(0x0003, 0xEF);
            memory.Write8(0x22CA, 0x09);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x29E3, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD344, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xCB5B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAEB5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xDE5F, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x2272, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBF0() {
            cpu.Reset();
            cpu.r1.af = 0x1080;
            cpu.r1.bc = 0xB270;
            cpu.r1.de = 0x1B5B;
            cpu.r1.hl = 0xA9B7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE89D;
            cpu.r1.iy = 0xEE9E;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x45);
            memory.Write8(0x0003, 0xF0);
            memory.Write8(0xEEE3, 0x2C);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1080, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6C70, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1B5B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA9B7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE89D, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xEE9E, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBF1() {
            cpu.Reset();
            cpu.r1.af = 0x1702;
            cpu.r1.bc = 0xC43B;
            cpu.r1.de = 0xD138;
            cpu.r1.hl = 0x316F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x8067;
            cpu.r1.iy = 0x4783;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x2F);
            memory.Write8(0x0003, 0xF1);
            memory.Write8(0x47B2, 0xDC);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1702, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC4DC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD138, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x316F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x8067, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4783, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBF2() {
            cpu.Reset();
            cpu.r1.af = 0x732A;
            cpu.r1.bc = 0x4CD1;
            cpu.r1.de = 0x77FE;
            cpu.r1.hl = 0x4814;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x42F1;
            cpu.r1.iy = 0xEA97;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x2C);
            memory.Write8(0x0003, 0xF2);
            memory.Write8(0xEAC3, 0x5E);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x732A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4CD1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5EFE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4814, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x42F1, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xEA97, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBF3() {
            cpu.Reset();
            cpu.r1.af = 0x6B97;
            cpu.r1.bc = 0x59D3;
            cpu.r1.de = 0xF546;
            cpu.r1.hl = 0x7530;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6670;
            cpu.r1.iy = 0x7D90;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x38);
            memory.Write8(0x0003, 0xF3);
            memory.Write8(0x7DC8, 0x0C);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6B97, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x59D3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF54C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7530, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6670, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7D90, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBF4() {
            cpu.Reset();
            cpu.r1.af = 0x7AF0;
            cpu.r1.bc = 0xA81F;
            cpu.r1.de = 0x5D3A;
            cpu.r1.hl = 0x799B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE12B;
            cpu.r1.iy = 0x309C;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xD0);
            memory.Write8(0x0003, 0xF4);
            memory.Write8(0x306C, 0x0E);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7AF0, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA81F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5D3A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4E9B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE12B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x309C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBF5() {
            cpu.Reset();
            cpu.r1.af = 0x1370;
            cpu.r1.bc = 0xF6B2;
            cpu.r1.de = 0xAAA2;
            cpu.r1.hl = 0x7F0A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC9F6;
            cpu.r1.iy = 0x6B1F;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x55);
            memory.Write8(0x0003, 0xF5);
            memory.Write8(0x6B74, 0xF8);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1370, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF6B2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xAAA2, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7FF8, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC9F6, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6B1F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBF6() {
            cpu.Reset();
            cpu.r1.af = 0x7C43;
            cpu.r1.bc = 0xFCD1;
            cpu.r1.de = 0x34BD;
            cpu.r1.hl = 0xF4AB;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xEF33;
            cpu.r1.iy = 0xC61A;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x56);
            memory.Write8(0x0003, 0xF6);
            memory.Write8(0xC670, 0x5D);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7C43, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFCD1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x34BD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF4AB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xEF33, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC61A, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBF7() {
            cpu.Reset();
            cpu.r1.af = 0xE6DA;
            cpu.r1.bc = 0x231A;
            cpu.r1.de = 0x7BB1;
            cpu.r1.hl = 0x800D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE37E;
            cpu.r1.iy = 0x5789;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x9E);
            memory.Write8(0x0003, 0xF7);
            memory.Write8(0x5727, 0x66);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x66DA, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x231A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7BB1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x800D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE37E, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5789, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBF8() {
            cpu.Reset();
            cpu.r1.af = 0xFA29;
            cpu.r1.bc = 0xEE74;
            cpu.r1.de = 0xD7C4;
            cpu.r1.hl = 0xAFAF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x512C;
            cpu.r1.iy = 0xDE7A;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x54);
            memory.Write8(0x0003, 0xF8);
            memory.Write8(0xDECE, 0x7A);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFA29, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFA74, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD7C4, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAFAF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x512C, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xDE7A, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBF9() {
            cpu.Reset();
            cpu.r1.af = 0x4662;
            cpu.r1.bc = 0xA71B;
            cpu.r1.de = 0x5065;
            cpu.r1.hl = 0xED06;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x279E;
            cpu.r1.iy = 0x99E3;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x30);
            memory.Write8(0x0003, 0xF9);
            memory.Write8(0x9A13, 0xC6);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4662, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA7C6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5065, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xED06, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x279E, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x99E3, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBFA() {
            cpu.Reset();
            cpu.r1.af = 0x9426;
            cpu.r1.bc = 0x53EC;
            cpu.r1.de = 0x5016;
            cpu.r1.hl = 0x6C99;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x8B99;
            cpu.r1.iy = 0xBD79;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x09);
            memory.Write8(0x0003, 0xFA);
            memory.Write8(0xBD82, 0xF4);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9426, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x53EC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF416, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6C99, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x8B99, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xBD79, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBFB() {
            cpu.Reset();
            cpu.r1.af = 0x5343;
            cpu.r1.bc = 0xB212;
            cpu.r1.de = 0x09CA;
            cpu.r1.hl = 0xE3C6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xCD2B;
            cpu.r1.iy = 0xF875;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xBA);
            memory.Write8(0x0003, 0xFB);
            memory.Write8(0xF82F, 0xED);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5343, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB212, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x09ED, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE3C6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xCD2B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xF875, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBFC() {
            cpu.Reset();
            cpu.r1.af = 0x0965;
            cpu.r1.bc = 0x4392;
            cpu.r1.de = 0xCA25;
            cpu.r1.hl = 0x2BAA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xF023;
            cpu.r1.iy = 0x6623;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x56);
            memory.Write8(0x0003, 0xFC);
            memory.Write8(0x6679, 0x65);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0965, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4392, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xCA25, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE5AA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xF023, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6623, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBFD() {
            cpu.Reset();
            cpu.r1.af = 0x1751;
            cpu.r1.bc = 0x233C;
            cpu.r1.de = 0x6214;
            cpu.r1.hl = 0xD119;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC415;
            cpu.r1.iy = 0x5D2B;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x25);
            memory.Write8(0x0003, 0xFD);
            memory.Write8(0x5D50, 0x27);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1751, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x233C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6214, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD1A7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC415, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5D2B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBFE() {
            cpu.Reset();
            cpu.r1.af = 0xB4CF;
            cpu.r1.bc = 0x5639;
            cpu.r1.de = 0x677B;
            cpu.r1.hl = 0x0CA2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xDDC5;
            cpu.r1.iy = 0x4E4F;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x88);
            memory.Write8(0x0003, 0xFE);
            memory.Write8(0x4DD7, 0x4A);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB4CF, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5639, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x677B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0CA2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xDDC5, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4E4F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFDCBFF() {
            cpu.Reset();
            cpu.r1.af = 0xF151;
            cpu.r1.bc = 0x13DA;
            cpu.r1.de = 0x7C56;
            cpu.r1.hl = 0xF025;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x2B36;
            cpu.r1.iy = 0x2AED;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0xE4);
            memory.Write8(0x0003, 0xFF);
            memory.Write8(0x2AD1, 0x97);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9751, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x13DA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7C56, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF025, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x2B36, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x2AED, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }
    }
}