using Microsoft.VisualStudio.TestTools.UnitTesting;
using Z80;

namespace z80ilTest
{
    [TestClass]
    public class CpuTestCB
    {
        readonly Cpu cpu;
        SimpleMemory memory;
        FakePort port;

        public CpuTestCB() {
            memory = new SimpleMemory();
            port = new FakePort();
            cpu = new Cpu(memory, port);
        }

        [TestMethod]
        public void TestCB00() {
            cpu.Reset();
            cpu.r1.af = 0xDA00;
            cpu.r1.bc = 0xE479;
            cpu.r1.de = 0x552E;
            cpu.r1.hl = 0xA806;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x00);
            memory.Write8(0xA806, 0x76);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDA8D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC979, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x552E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA806, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB01() {
            cpu.Reset();
            cpu.r1.af = 0x1000;
            cpu.r1.bc = 0xB379;
            cpu.r1.de = 0xB480;
            cpu.r1.hl = 0xEF65;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x01);
            memory.Write8(0xEF65, 0xFB);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x10A0, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB3F2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB480, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xEF65, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB02() {
            cpu.Reset();
            cpu.r1.af = 0x2E00;
            cpu.r1.bc = 0x9ADF;
            cpu.r1.de = 0xAE6E;
            cpu.r1.hl = 0xA7F2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x02);
            memory.Write8(0xA7F2, 0x4A);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2E09, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9ADF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5D6E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA7F2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB03() {
            cpu.Reset();
            cpu.r1.af = 0x6800;
            cpu.r1.bc = 0x9995;
            cpu.r1.de = 0xDE3F;
            cpu.r1.hl = 0xCA71;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x03);
            memory.Write8(0xCA71, 0xE7);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x682C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9995, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDE7E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCA71, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB04() {
            cpu.Reset();
            cpu.r1.af = 0x8C00;
            cpu.r1.bc = 0xBEEA;
            cpu.r1.de = 0x0CE4;
            cpu.r1.hl = 0x67B0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x04);
            memory.Write8(0x67B0, 0xCD);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8C88, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBEEA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0CE4, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCEB0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB05() {
            cpu.Reset();
            cpu.r1.af = 0x3600;
            cpu.r1.bc = 0xE19F;
            cpu.r1.de = 0x78C9;
            cpu.r1.hl = 0xCB32;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x05);
            memory.Write8(0xCB32, 0x1B);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3620, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE19F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x78C9, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCB64, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB06() {
            cpu.Reset();
            cpu.r1.af = 0x8A00;
            cpu.r1.bc = 0xDB02;
            cpu.r1.de = 0x8FB1;
            cpu.r1.hl = 0x5B04;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x06);
            memory.Write8(0x5B04, 0xD4);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8AAD, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xDB02, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8FB1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5B04, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB07() {
            cpu.Reset();
            cpu.r1.af = 0x6D00;
            cpu.r1.bc = 0x19CF;
            cpu.r1.de = 0x7259;
            cpu.r1.hl = 0xDCAA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x07);
            memory.Write8(0xDCAA, 0x8D);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDA88, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x19CF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7259, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCAA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB08() {
            cpu.Reset();
            cpu.r1.af = 0x8000;
            cpu.r1.bc = 0xCDB5;
            cpu.r1.de = 0x818E;
            cpu.r1.hl = 0x2EE2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x08);
            memory.Write8(0x2EE2, 0x53);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x80A1, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE6B5, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x818E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2EE2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB09() {
            cpu.Reset();
            cpu.r1.af = 0x1800;
            cpu.r1.bc = 0x125C;
            cpu.r1.de = 0xDD97;
            cpu.r1.hl = 0x59C6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x09);
            memory.Write8(0x59C6, 0x9E);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x182C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x122E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDD97, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x59C6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB0A() {
            cpu.Reset();
            cpu.r1.af = 0x1200;
            cpu.r1.bc = 0x3BA1;
            cpu.r1.de = 0x7724;
            cpu.r1.hl = 0x63AD;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x0A);
            memory.Write8(0x63AD, 0x96);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x12AD, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3BA1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xBB24, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x63AD, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB0B() {
            cpu.Reset();
            cpu.r1.af = 0x7600;
            cpu.r1.bc = 0x2ABF;
            cpu.r1.de = 0xB626;
            cpu.r1.hl = 0x0289;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x0B);
            memory.Write8(0x0289, 0x37);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7600, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2ABF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB613, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0289, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB0C() {
            cpu.Reset();
            cpu.r1.af = 0x0E00;
            cpu.r1.bc = 0x6FC5;
            cpu.r1.de = 0x2F12;
            cpu.r1.hl = 0x34D9;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x0C);
            memory.Write8(0x34D9, 0x50);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0E08, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6FC5, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2F12, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1AD9, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB0D() {
            cpu.Reset();
            cpu.r1.af = 0x6300;
            cpu.r1.bc = 0x95A3;
            cpu.r1.de = 0xFCD2;
            cpu.r1.hl = 0x519A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x0D);
            memory.Write8(0x519A, 0x7A);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x630C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x95A3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xFCD2, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x514D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB0E() {
            cpu.Reset();
            cpu.r1.af = 0xFC00;
            cpu.r1.bc = 0xADF9;
            cpu.r1.de = 0x4925;
            cpu.r1.hl = 0x543E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x0E);
            memory.Write8(0x543E, 0xD2);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFC2C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xADF9, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4925, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x543E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB0F() {
            cpu.Reset();
            cpu.r1.af = 0xC300;
            cpu.r1.bc = 0x18F3;
            cpu.r1.de = 0x41B8;
            cpu.r1.hl = 0x070B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x0F);
            memory.Write8(0x070B, 0x86);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE1A5, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x18F3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x41B8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x070B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB10() {
            cpu.Reset();
            cpu.r1.af = 0xF800;
            cpu.r1.bc = 0xDC25;
            cpu.r1.de = 0x33B3;
            cpu.r1.hl = 0x0D74;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x10);
            memory.Write8(0x0D74, 0x3D);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF8AD, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB825, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x33B3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0D74, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB11() {
            cpu.Reset();
            cpu.r1.af = 0x6500;
            cpu.r1.bc = 0xE25C;
            cpu.r1.de = 0x4B8A;
            cpu.r1.hl = 0xED42;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x11);
            memory.Write8(0xED42, 0xB7);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x65AC, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE2B8, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4B8A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xED42, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB12() {
            cpu.Reset();
            cpu.r1.af = 0x7700;
            cpu.r1.bc = 0x1384;
            cpu.r1.de = 0x0F50;
            cpu.r1.hl = 0x29C6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x12);
            memory.Write8(0x29C6, 0x88);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x770C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1384, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1E50, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x29C6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB13() {
            cpu.Reset();
            cpu.r1.af = 0xCE00;
            cpu.r1.bc = 0x9F17;
            cpu.r1.de = 0xE128;
            cpu.r1.hl = 0x3ED7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x13);
            memory.Write8(0x3ED7, 0xEA);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCE04, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9F17, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE150, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3ED7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB14() {
            cpu.Reset();
            cpu.r1.af = 0xB200;
            cpu.r1.bc = 0x541A;
            cpu.r1.de = 0x60C7;
            cpu.r1.hl = 0x7C9A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x14);
            memory.Write8(0x7C9A, 0x0F);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB2A8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x541A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x60C7, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF89A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB15() {
            cpu.Reset();
            cpu.r1.af = 0x2D00;
            cpu.r1.bc = 0xC1DF;
            cpu.r1.de = 0x6EAB;
            cpu.r1.hl = 0x03E2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x15);
            memory.Write8(0x03E2, 0xBC);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2D81, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC1DF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6EAB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x03C4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB16() {
            cpu.Reset();
            cpu.r1.af = 0x3600;
            cpu.r1.bc = 0x3B53;
            cpu.r1.de = 0x1A4A;
            cpu.r1.hl = 0x684E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x16);
            memory.Write8(0x684E, 0xC3);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3681, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3B53, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1A4A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x684E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB17() {
            cpu.Reset();
            cpu.r1.af = 0x5400;
            cpu.r1.bc = 0xD090;
            cpu.r1.de = 0xF60D;
            cpu.r1.hl = 0x0FA2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x17);
            memory.Write8(0x0FA2, 0x23);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA8A8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD090, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF60D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0FA2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB18() {
            cpu.Reset();
            cpu.r1.af = 0x8600;
            cpu.r1.bc = 0xC658;
            cpu.r1.de = 0x755F;
            cpu.r1.hl = 0x9596;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x18);
            memory.Write8(0x9596, 0xB6);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8624, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6358, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x755F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9596, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB19() {
            cpu.Reset();
            cpu.r1.af = 0x9600;
            cpu.r1.bc = 0xBEB3;
            cpu.r1.de = 0x7C22;
            cpu.r1.hl = 0x71C8;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x19);
            memory.Write8(0x71C8, 0x85);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x960D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBE59, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7C22, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x71C8, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB1A() {
            cpu.Reset();
            cpu.r1.af = 0x3900;
            cpu.r1.bc = 0x882F;
            cpu.r1.de = 0x543B;
            cpu.r1.hl = 0x5279;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x1A);
            memory.Write8(0x5279, 0x26);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3928, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x882F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2A3B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5279, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB1B() {
            cpu.Reset();
            cpu.r1.af = 0x9E00;
            cpu.r1.bc = 0xB338;
            cpu.r1.de = 0x876C;
            cpu.r1.hl = 0xE8B4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x1B);
            memory.Write8(0xE8B4, 0xB9);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9E24, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB338, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8736, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE8B4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB1C() {
            cpu.Reset();
            cpu.r1.af = 0x4B00;
            cpu.r1.bc = 0xB555;
            cpu.r1.de = 0x238F;
            cpu.r1.hl = 0x311D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x1C);
            memory.Write8(0x311D, 0x11);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4B0D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB555, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x238F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x181D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB1D() {
            cpu.Reset();
            cpu.r1.af = 0x2100;
            cpu.r1.bc = 0x3D7E;
            cpu.r1.de = 0x5E39;
            cpu.r1.hl = 0xE451;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x1D);
            memory.Write8(0xE451, 0x47);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x212D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3D7E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5E39, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE428, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB1E() {
            cpu.Reset();
            cpu.r1.af = 0x5E00;
            cpu.r1.bc = 0x66B9;
            cpu.r1.de = 0x80DC;
            cpu.r1.hl = 0x00EF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x1E);
            memory.Write8(0x00EF, 0x91);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5E0D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x66B9, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x80DC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x00EF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB1F() {
            cpu.Reset();
            cpu.r1.af = 0xED00;
            cpu.r1.bc = 0xB838;
            cpu.r1.de = 0x8E18;
            cpu.r1.hl = 0xACE7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x1F);
            memory.Write8(0xACE7, 0x82);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7621, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB838, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8E18, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xACE7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB20() {
            cpu.Reset();
            cpu.r1.af = 0xC700;
            cpu.r1.bc = 0x0497;
            cpu.r1.de = 0xD72B;
            cpu.r1.hl = 0xCCB6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x20);
            memory.Write8(0xCCB6, 0x1A);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC708, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0897, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD72B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCCB6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB21() {
            cpu.Reset();
            cpu.r1.af = 0x2200;
            cpu.r1.bc = 0x5CF4;
            cpu.r1.de = 0x938E;
            cpu.r1.hl = 0x37A8;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x21);
            memory.Write8(0x37A8, 0xDD);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x22AD, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5CE8, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x938E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x37A8, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB22() {
            cpu.Reset();
            cpu.r1.af = 0x8500;
            cpu.r1.bc = 0x0950;
            cpu.r1.de = 0xE7E8;
            cpu.r1.hl = 0x0641;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x22);
            memory.Write8(0x0641, 0x4D);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8589, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0950, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xCEE8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0641, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB23() {
            cpu.Reset();
            cpu.r1.af = 0x2100;
            cpu.r1.bc = 0x2A7C;
            cpu.r1.de = 0x37D0;
            cpu.r1.hl = 0xAA59;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x23);
            memory.Write8(0xAA59, 0xC1);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x21A5, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2A7C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x37A0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAA59, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB24() {
            cpu.Reset();
            cpu.r1.af = 0xFB00;
            cpu.r1.bc = 0xB9DE;
            cpu.r1.de = 0x7014;
            cpu.r1.hl = 0x84B6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x24);
            memory.Write8(0x84B6, 0x80);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFB09, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB9DE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7014, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x08B6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB25() {
            cpu.Reset();
            cpu.r1.af = 0x1500;
            cpu.r1.bc = 0x6BBC;
            cpu.r1.de = 0x894E;
            cpu.r1.hl = 0x85BC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x25);
            memory.Write8(0x85BC, 0xEF);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x152D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6BBC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x894E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8578, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB26() {
            cpu.Reset();
            cpu.r1.af = 0x0A00;
            cpu.r1.bc = 0x372E;
            cpu.r1.de = 0xE315;
            cpu.r1.hl = 0x283A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x26);
            memory.Write8(0x283A, 0xEE);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0A89, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x372E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE315, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x283A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB27() {
            cpu.Reset();
            cpu.r1.af = 0xBF00;
            cpu.r1.bc = 0xBDBA;
            cpu.r1.de = 0x67AB;
            cpu.r1.hl = 0x5EA2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x27);
            memory.Write8(0x5EA2, 0xBD);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7E2D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBDBA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x67AB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5EA2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB28() {
            cpu.Reset();
            cpu.r1.af = 0xC000;
            cpu.r1.bc = 0x0435;
            cpu.r1.de = 0x3E0F;
            cpu.r1.hl = 0x021B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x28);
            memory.Write8(0x021B, 0x90);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0235, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3E0F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x021B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB29() {
            cpu.Reset();
            cpu.r1.af = 0x0600;
            cpu.r1.bc = 0xF142;
            cpu.r1.de = 0x6ADA;
            cpu.r1.hl = 0xC306;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x29);
            memory.Write8(0xC306, 0x5C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0624, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF121, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6ADA, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC306, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB2A() {
            cpu.Reset();
            cpu.r1.af = 0x3000;
            cpu.r1.bc = 0xEC3A;
            cpu.r1.de = 0x7F7D;
            cpu.r1.hl = 0x3473;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x2A);
            memory.Write8(0x3473, 0x34);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x302D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xEC3A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3F7D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3473, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB2B() {
            cpu.Reset();
            cpu.r1.af = 0xE000;
            cpu.r1.bc = 0xCCF0;
            cpu.r1.de = 0xBBDA;
            cpu.r1.hl = 0xB78A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x2B);
            memory.Write8(0xB78A, 0xAB);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE0AC, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCCF0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xBBED, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB78A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB2C() {
            cpu.Reset();
            cpu.r1.af = 0x5B00;
            cpu.r1.bc = 0x25C0;
            cpu.r1.de = 0x996D;
            cpu.r1.hl = 0x1E7B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x2C);
            memory.Write8(0x1E7B, 0x2C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5B0C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x25C0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x996D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0F7B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB2D() {
            cpu.Reset();
            cpu.r1.af = 0x5E00;
            cpu.r1.bc = 0xC51B;
            cpu.r1.de = 0x58E3;
            cpu.r1.hl = 0x78EA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x2D);
            memory.Write8(0x78EA, 0x85);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5EA4, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC51B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x58E3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x78F5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB2E() {
            cpu.Reset();
            cpu.r1.af = 0x3900;
            cpu.r1.bc = 0xA2CD;
            cpu.r1.de = 0x0629;
            cpu.r1.hl = 0x24BF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x2E);
            memory.Write8(0x24BF, 0xB5);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3989, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA2CD, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0629, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x24BF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB2F() {
            cpu.Reset();
            cpu.r1.af = 0xAA00;
            cpu.r1.bc = 0xA194;
            cpu.r1.de = 0xD0E3;
            cpu.r1.hl = 0x5C65;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x2F);
            memory.Write8(0x5C65, 0xC9);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD580, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA194, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD0E3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5C65, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB30() {
            cpu.Reset();
            cpu.r1.af = 0xCD00;
            cpu.r1.bc = 0x7A81;
            cpu.r1.de = 0xD67B;
            cpu.r1.hl = 0x656B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x30);
            memory.Write8(0x656B, 0x32);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCDA4, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF581, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD67B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x656B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB31() {
            cpu.Reset();
            cpu.r1.af = 0x2800;
            cpu.r1.bc = 0xE7FA;
            cpu.r1.de = 0x6D8C;
            cpu.r1.hl = 0x75A4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x31);
            memory.Write8(0x75A4, 0x0C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x28A5, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE7F5, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6D8C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x75A4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB32() {
            cpu.Reset();
            cpu.r1.af = 0x1300;
            cpu.r1.bc = 0x3F36;
            cpu.r1.de = 0xF608;
            cpu.r1.hl = 0x5E56;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x32);
            memory.Write8(0x5E56, 0x8D);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x13AD, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3F36, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xED08, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5E56, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB33() {
            cpu.Reset();
            cpu.r1.af = 0xD500;
            cpu.r1.bc = 0x9720;
            cpu.r1.de = 0x7644;
            cpu.r1.hl = 0x038F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x33);
            memory.Write8(0x038F, 0xBA);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD588, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9720, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7689, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x038F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB34() {
            cpu.Reset();
            cpu.r1.af = 0x1200;
            cpu.r1.bc = 0x77F6;
            cpu.r1.de = 0x0206;
            cpu.r1.hl = 0xFB38;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x34);
            memory.Write8(0xFB38, 0x07);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x12A1, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x77F6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0206, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF738, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB35() {
            cpu.Reset();
            cpu.r1.af = 0x3C00;
            cpu.r1.bc = 0xFD68;
            cpu.r1.de = 0xEA91;
            cpu.r1.hl = 0x7861;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x35);
            memory.Write8(0x7861, 0x72);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3C84, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFD68, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xEA91, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x78C3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB36() {
            cpu.Reset();
            cpu.r1.af = 0x8A00;
            cpu.r1.bc = 0x1185;
            cpu.r1.de = 0x1DDE;
            cpu.r1.hl = 0x6D38;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x36);
            memory.Write8(0x6D38, 0xF1);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8AA1, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1185, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1DDE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6D38, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB37() {
            cpu.Reset();
            cpu.r1.af = 0x4300;
            cpu.r1.bc = 0xD7BC;
            cpu.r1.de = 0x9133;
            cpu.r1.hl = 0x6E56;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x37);
            memory.Write8(0x6E56, 0xF8);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8784, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD7BC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9133, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6E56, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB38() {
            cpu.Reset();
            cpu.r1.af = 0xDF00;
            cpu.r1.bc = 0x7C1B;
            cpu.r1.de = 0x9F9F;
            cpu.r1.hl = 0x4FF2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x38);
            memory.Write8(0x4FF2, 0xAA);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDF28, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3E1B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9F9F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4FF2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB39() {
            cpu.Reset();
            cpu.r1.af = 0x6600;
            cpu.r1.bc = 0xB702;
            cpu.r1.de = 0x14F5;
            cpu.r1.hl = 0x3C17;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x39);
            memory.Write8(0x3C17, 0x61);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6600, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB701, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x14F5, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3C17, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB3A() {
            cpu.Reset();
            cpu.r1.af = 0xD100;
            cpu.r1.bc = 0x5C5F;
            cpu.r1.de = 0xE42E;
            cpu.r1.hl = 0xF1B1;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x3A);
            memory.Write8(0xF1B1, 0x6E);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD124, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5C5F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x722E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF1B1, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB3B() {
            cpu.Reset();
            cpu.r1.af = 0xB200;
            cpu.r1.bc = 0x38C8;
            cpu.r1.de = 0xA560;
            cpu.r1.hl = 0x7419;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x3B);
            memory.Write8(0x7419, 0x11);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB224, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x38C8, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA530, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7419, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB3C() {
            cpu.Reset();
            cpu.r1.af = 0x7800;
            cpu.r1.bc = 0xCFAE;
            cpu.r1.de = 0x66D8;
            cpu.r1.hl = 0x2AD8;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x3C);
            memory.Write8(0x2AD8, 0x8D);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7800, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCFAE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x66D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x15D8, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB3D() {
            cpu.Reset();
            cpu.r1.af = 0xE600;
            cpu.r1.bc = 0xDCDA;
            cpu.r1.de = 0x06AA;
            cpu.r1.hl = 0x46CD;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x3D);
            memory.Write8(0x46CD, 0xF9);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE625, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xDCDA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x06AA, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4666, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB3E() {
            cpu.Reset();
            cpu.r1.af = 0xA900;
            cpu.r1.bc = 0x6A34;
            cpu.r1.de = 0xE8D0;
            cpu.r1.hl = 0xA96C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x3E);
            memory.Write8(0xA96C, 0xA0);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA904, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6A34, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE8D0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA96C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB3F() {
            cpu.Reset();
            cpu.r1.af = 0xF100;
            cpu.r1.bc = 0xCEEA;
            cpu.r1.de = 0x721E;
            cpu.r1.hl = 0x77F0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x3F);
            memory.Write8(0x77F0, 0x7C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x782D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCEEA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x721E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x77F0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB40() {
            cpu.Reset();
            cpu.r1.af = 0x9E00;
            cpu.r1.bc = 0xBCB2;
            cpu.r1.de = 0xEFAA;
            cpu.r1.hl = 0x505F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x40);
            memory.Write8(0x505F, 0x59);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9E7C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBCB2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xEFAA, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x505F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB41() {
            cpu.Reset();
            cpu.r1.af = 0x9E00;
            cpu.r1.bc = 0x1B43;
            cpu.r1.de = 0x954E;
            cpu.r1.hl = 0x7BE9;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x41);
            memory.Write8(0x7BE9, 0xF7);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9E10, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1B43, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x954E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7BE9, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB42() {
            cpu.Reset();
            cpu.r1.af = 0xF200;
            cpu.r1.bc = 0xDD12;
            cpu.r1.de = 0x7D4F;
            cpu.r1.hl = 0x551F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x42);
            memory.Write8(0x551F, 0xC9);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF238, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xDD12, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7D4F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x551F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB43() {
            cpu.Reset();
            cpu.r1.af = 0xAD00;
            cpu.r1.bc = 0xC3B3;
            cpu.r1.de = 0xF1D0;
            cpu.r1.hl = 0xBAB4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x43);
            memory.Write8(0xBAB4, 0x76);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAD54, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC3B3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF1D0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xBAB4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB44() {
            cpu.Reset();
            cpu.r1.af = 0xB700;
            cpu.r1.bc = 0xC829;
            cpu.r1.de = 0x27E3;
            cpu.r1.hl = 0x5B92;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x44);
            memory.Write8(0x5B92, 0x78);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB718, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC829, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x27E3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5B92, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB45() {
            cpu.Reset();
            cpu.r1.af = 0x7700;
            cpu.r1.bc = 0x68EE;
            cpu.r1.de = 0x0C77;
            cpu.r1.hl = 0x409B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x45);
            memory.Write8(0x409B, 0x64);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7718, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x68EE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0C77, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x409B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB46() {
            cpu.Reset();
            cpu.r1.af = 0x7200;
            cpu.r1.bc = 0x7AE3;
            cpu.r1.de = 0xA11E;
            cpu.r1.hl = 0x6131;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x46);
            memory.Write8(0x6131, 0xD5);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7210, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7AE3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA11E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6131, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(12UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB47_1() {
            cpu.Reset();
            cpu.r1.af = 0xFF00;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x47);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFF38, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB47() {
            cpu.Reset();
            cpu.r1.af = 0x1000;
            cpu.r1.bc = 0xD8CA;
            cpu.r1.de = 0xE2C4;
            cpu.r1.hl = 0x8A8C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x47);
            memory.Write8(0x8A8C, 0x0E);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1054, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD8CA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE2C4, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8A8C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB48() {
            cpu.Reset();
            cpu.r1.af = 0xA900;
            cpu.r1.bc = 0x6264;
            cpu.r1.de = 0xE833;
            cpu.r1.hl = 0x6DE0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x48);
            memory.Write8(0x6DE0, 0x8C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA930, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6264, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE833, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6DE0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB49() {
            cpu.Reset();
            cpu.r1.af = 0x6C00;
            cpu.r1.bc = 0xD0F7;
            cpu.r1.de = 0x1DB7;
            cpu.r1.hl = 0xA040;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x49);
            memory.Write8(0xA040, 0x5F);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6C30, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD0F7, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1DB7, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA040, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB4A() {
            cpu.Reset();
            cpu.r1.af = 0x4F00;
            cpu.r1.bc = 0xF04C;
            cpu.r1.de = 0x5B29;
            cpu.r1.hl = 0x77A4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x4A);
            memory.Write8(0x77A4, 0x96);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4F18, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF04C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5B29, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x77A4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB4B() {
            cpu.Reset();
            cpu.r1.af = 0x5500;
            cpu.r1.bc = 0x9848;
            cpu.r1.de = 0x095F;
            cpu.r1.hl = 0x40CA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x4B);
            memory.Write8(0x40CA, 0x8A);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5518, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9848, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x095F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x40CA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB4C() {
            cpu.Reset();
            cpu.r1.af = 0x8800;
            cpu.r1.bc = 0x0521;
            cpu.r1.de = 0xBF31;
            cpu.r1.hl = 0x6D5D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x4C);
            memory.Write8(0x6D5D, 0xE7);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x887C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0521, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xBF31, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6D5D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB4D() {
            cpu.Reset();
            cpu.r1.af = 0xF900;
            cpu.r1.bc = 0x27D0;
            cpu.r1.de = 0x0F7E;
            cpu.r1.hl = 0x158D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x4D);
            memory.Write8(0x158D, 0xE0);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF95C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x27D0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0F7E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x158D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB4E() {
            cpu.Reset();
            cpu.r1.af = 0x2600;
            cpu.r1.bc = 0x9207;
            cpu.r1.de = 0x459A;
            cpu.r1.hl = 0xADA3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x4E);
            memory.Write8(0xADA3, 0x5B);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2618, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9207, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x459A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xADA3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(12UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB4F_1() {
            cpu.Reset();
            cpu.r1.af = 0xFF00;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x4F);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFF38, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB4F() {
            cpu.Reset();
            cpu.r1.af = 0x1700;
            cpu.r1.bc = 0x2DC1;
            cpu.r1.de = 0xACA2;
            cpu.r1.hl = 0x0BCC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x4F);
            memory.Write8(0x0BCC, 0xA3);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1710, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2DC1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xACA2, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0BCC, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB50() {
            cpu.Reset();
            cpu.r1.af = 0x2300;
            cpu.r1.bc = 0x2749;
            cpu.r1.de = 0x1012;
            cpu.r1.hl = 0x84D2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x50);
            memory.Write8(0x84D2, 0x6A);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2330, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2749, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1012, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x84D2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB51() {
            cpu.Reset();
            cpu.r1.af = 0x2200;
            cpu.r1.bc = 0xB7DB;
            cpu.r1.de = 0xE19D;
            cpu.r1.hl = 0xAAFC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x51);
            memory.Write8(0xAAFC, 0xA6);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x225C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB7DB, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE19D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAAFC, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB52() {
            cpu.Reset();
            cpu.r1.af = 0x8B00;
            cpu.r1.bc = 0xFF7A;
            cpu.r1.de = 0xB0FF;
            cpu.r1.hl = 0xAC44;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x52);
            memory.Write8(0xAC44, 0x00);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8B74, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFF7A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB0FF, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAC44, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB53() {
            cpu.Reset();
            cpu.r1.af = 0x6000;
            cpu.r1.bc = 0x31A1;
            cpu.r1.de = 0xA4F4;
            cpu.r1.hl = 0x7C75;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x53);
            memory.Write8(0x7C75, 0xAB);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6030, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x31A1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA4F4, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7C75, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB54() {
            cpu.Reset();
            cpu.r1.af = 0x3800;
            cpu.r1.bc = 0x7CCC;
            cpu.r1.de = 0x89CC;
            cpu.r1.hl = 0x1999;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x54);
            memory.Write8(0x1999, 0x98);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x385C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7CCC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x89CC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1999, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB55() {
            cpu.Reset();
            cpu.r1.af = 0xF900;
            cpu.r1.bc = 0x1F79;
            cpu.r1.de = 0x19CD;
            cpu.r1.hl = 0xFB4B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x55);
            memory.Write8(0xFB4B, 0x0B);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF95C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1F79, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x19CD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xFB4B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB56() {
            cpu.Reset();
            cpu.r1.af = 0x1500;
            cpu.r1.bc = 0x2BFE;
            cpu.r1.de = 0xE3B5;
            cpu.r1.hl = 0xBBF9;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x56);
            memory.Write8(0xBBF9, 0x10);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1554, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2BFE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE3B5, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xBBF9, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(12UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB57_1() {
            cpu.Reset();
            cpu.r1.af = 0xFF00;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x57);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFF38, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB57() {
            cpu.Reset();
            cpu.r1.af = 0x6600;
            cpu.r1.bc = 0xAF32;
            cpu.r1.de = 0x532A;
            cpu.r1.hl = 0xDA50;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x57);
            memory.Write8(0xDA50, 0x30);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6630, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAF32, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x532A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDA50, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB58() {
            cpu.Reset();
            cpu.r1.af = 0x5000;
            cpu.r1.bc = 0x1AEE;
            cpu.r1.de = 0x2E47;
            cpu.r1.hl = 0x1479;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x58);
            memory.Write8(0x1479, 0xA0);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5018, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1AEE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2E47, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1479, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB59() {
            cpu.Reset();
            cpu.r1.af = 0x7200;
            cpu.r1.bc = 0x5E68;
            cpu.r1.de = 0xFF28;
            cpu.r1.hl = 0x2075;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x59);
            memory.Write8(0x2075, 0xC1);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7238, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5E68, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xFF28, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2075, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB5A() {
            cpu.Reset();
            cpu.r1.af = 0xEB00;
            cpu.r1.bc = 0xFEA7;
            cpu.r1.de = 0x17D1;
            cpu.r1.hl = 0xD99B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x5A);
            memory.Write8(0xD99B, 0xE8);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xEB54, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFEA7, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x17D1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD99B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB5B() {
            cpu.Reset();
            cpu.r1.af = 0x6B00;
            cpu.r1.bc = 0x6F2C;
            cpu.r1.de = 0x3FE3;
            cpu.r1.hl = 0x1691;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x5B);
            memory.Write8(0x1691, 0xC7);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6B74, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6F2C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3FE3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1691, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB5C() {
            cpu.Reset();
            cpu.r1.af = 0x3300;
            cpu.r1.bc = 0xA7E7;
            cpu.r1.de = 0x2077;
            cpu.r1.hl = 0x13E9;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x5C);
            memory.Write8(0x13E9, 0xAE);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3354, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA7E7, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2077, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x13E9, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB5D() {
            cpu.Reset();
            cpu.r1.af = 0xC100;
            cpu.r1.bc = 0xAFCC;
            cpu.r1.de = 0xC8B1;
            cpu.r1.hl = 0xEE49;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x5D);
            memory.Write8(0xEE49, 0xA6);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC118, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAFCC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC8B1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xEE49, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB5E() {
            cpu.Reset();
            cpu.r1.af = 0x3000;
            cpu.r1.bc = 0xAD43;
            cpu.r1.de = 0x16C1;
            cpu.r1.hl = 0x349A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x5E);
            memory.Write8(0x349A, 0x3C);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3038, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAD43, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x16C1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x349A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(12UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB5F_1() {
            cpu.Reset();
            cpu.r1.af = 0xFF00;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x5F);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFF38, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB5F() {
            cpu.Reset();
            cpu.r1.af = 0x8C00;
            cpu.r1.bc = 0x1B67;
            cpu.r1.de = 0x2314;
            cpu.r1.hl = 0x6133;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x5F);
            memory.Write8(0x6133, 0x90);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8C18, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1B67, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2314, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6133, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB60() {
            cpu.Reset();
            cpu.r1.af = 0x9900;
            cpu.r1.bc = 0x34B5;
            cpu.r1.de = 0x0FD8;
            cpu.r1.hl = 0x5273;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x60);
            memory.Write8(0x5273, 0x0A);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9930, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x34B5, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0FD8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5273, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB61() {
            cpu.Reset();
            cpu.r1.af = 0xD100;
            cpu.r1.bc = 0x219F;
            cpu.r1.de = 0x3BB4;
            cpu.r1.hl = 0x7C44;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x61);
            memory.Write8(0x7C44, 0x77);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD118, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x219F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3BB4, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7C44, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB62() {
            cpu.Reset();
            cpu.r1.af = 0xAF00;
            cpu.r1.bc = 0xBDF8;
            cpu.r1.de = 0xC536;
            cpu.r1.hl = 0x8CC5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x62);
            memory.Write8(0x8CC5, 0xAF);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAF54, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBDF8, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC536, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8CC5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB63() {
            cpu.Reset();
            cpu.r1.af = 0x2A00;
            cpu.r1.bc = 0x5E16;
            cpu.r1.de = 0xF627;
            cpu.r1.hl = 0x84CA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x63);
            memory.Write8(0x84CA, 0xE6);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2A74, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5E16, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF627, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x84CA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB64() {
            cpu.Reset();
            cpu.r1.af = 0xA900;
            cpu.r1.bc = 0xA365;
            cpu.r1.de = 0xC00B;
            cpu.r1.hl = 0xEA94;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x64);
            memory.Write8(0xEA94, 0x0C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA97C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA365, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC00B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xEA94, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB65() {
            cpu.Reset();
            cpu.r1.af = 0x1800;
            cpu.r1.bc = 0x8D58;
            cpu.r1.de = 0x4256;
            cpu.r1.hl = 0x427A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x65);
            memory.Write8(0x427A, 0xEE);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1838, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8D58, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4256, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x427A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB66() {
            cpu.Reset();
            cpu.r1.af = 0x4C00;
            cpu.r1.bc = 0x3EF7;
            cpu.r1.de = 0xE544;
            cpu.r1.hl = 0xA44F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x66);
            memory.Write8(0xA44F, 0xD2);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4C10, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3EF7, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE544, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA44F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(12UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB67_1() {
            cpu.Reset();
            cpu.r1.af = 0xFF00;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x67);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFF38, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB67() {
            cpu.Reset();
            cpu.r1.af = 0x8600;
            cpu.r1.bc = 0x5E92;
            cpu.r1.de = 0x2986;
            cpu.r1.hl = 0x394D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x67);
            memory.Write8(0x394D, 0x10);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8654, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5E92, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2986, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x394D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB68() {
            cpu.Reset();
            cpu.r1.af = 0xD700;
            cpu.r1.bc = 0x0F6A;
            cpu.r1.de = 0x18A6;
            cpu.r1.hl = 0xDDD2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x68);
            memory.Write8(0xDDD2, 0x16);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD75C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F6A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x18A6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDDD2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB69() {
            cpu.Reset();
            cpu.r1.af = 0xDA00;
            cpu.r1.bc = 0x691B;
            cpu.r1.de = 0x7C79;
            cpu.r1.hl = 0x1DBA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x69);
            memory.Write8(0x1DBA, 0x8A);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDA5C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x691B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7C79, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1DBA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB6A() {
            cpu.Reset();
            cpu.r1.af = 0x2200;
            cpu.r1.bc = 0x13E8;
            cpu.r1.de = 0x86D4;
            cpu.r1.hl = 0x4E09;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x6A);
            memory.Write8(0x4E09, 0xD5);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2254, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x13E8, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x86D4, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4E09, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB6B() {
            cpu.Reset();
            cpu.r1.af = 0xAF00;
            cpu.r1.bc = 0x5123;
            cpu.r1.de = 0x7635;
            cpu.r1.hl = 0x1CA9;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x6B);
            memory.Write8(0x1CA9, 0x86);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAF30, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5123, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7635, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1CA9, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB6C() {
            cpu.Reset();
            cpu.r1.af = 0x4300;
            cpu.r1.bc = 0xFAA6;
            cpu.r1.de = 0xABC2;
            cpu.r1.hl = 0x5605;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x6C);
            memory.Write8(0x5605, 0x2B);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4354, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFAA6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xABC2, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5605, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB6D() {
            cpu.Reset();
            cpu.r1.af = 0x7F00;
            cpu.r1.bc = 0xF099;
            cpu.r1.de = 0xD435;
            cpu.r1.hl = 0xD9AD;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x6D);
            memory.Write8(0xD9AD, 0x4E);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7F38, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF099, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD435, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD9AD, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB6E() {
            cpu.Reset();
            cpu.r1.af = 0x4A00;
            cpu.r1.bc = 0x08C9;
            cpu.r1.de = 0x8177;
            cpu.r1.hl = 0xD8BA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x6E);
            memory.Write8(0xD8BA, 0x31);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4A30, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x08C9, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8177, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD8BA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(12UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB6F_1() {
            cpu.Reset();
            cpu.r1.af = 0xFF00;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x6F);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFF38, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB6F() {
            cpu.Reset();
            cpu.r1.af = 0xA100;
            cpu.r1.bc = 0x8C80;
            cpu.r1.de = 0x4678;
            cpu.r1.hl = 0x4D34;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x6F);
            memory.Write8(0x4D34, 0x78);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA130, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8C80, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4678, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4D34, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB70() {
            cpu.Reset();
            cpu.r1.af = 0x1900;
            cpu.r1.bc = 0x958A;
            cpu.r1.de = 0x5DAB;
            cpu.r1.hl = 0xF913;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x70);
            memory.Write8(0xF913, 0xCF);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1954, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x958A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5DAB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF913, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB71() {
            cpu.Reset();
            cpu.r1.af = 0x3D00;
            cpu.r1.bc = 0x095E;
            cpu.r1.de = 0xD6DF;
            cpu.r1.hl = 0x42FE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x71);
            memory.Write8(0x42FE, 0x24);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3D18, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x095E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD6DF, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x42FE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB72() {
            cpu.Reset();
            cpu.r1.af = 0xA500;
            cpu.r1.bc = 0xC0BF;
            cpu.r1.de = 0x4C8D;
            cpu.r1.hl = 0xAD11;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x72);
            memory.Write8(0xAD11, 0x3B);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA518, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC0BF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4C8D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAD11, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB73() {
            cpu.Reset();
            cpu.r1.af = 0xF200;
            cpu.r1.bc = 0x49A6;
            cpu.r1.de = 0xB279;
            cpu.r1.hl = 0x2ECC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x73);
            memory.Write8(0x2ECC, 0xE0);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF238, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x49A6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB279, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2ECC, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB74() {
            cpu.Reset();
            cpu.r1.af = 0x0500;
            cpu.r1.bc = 0x445E;
            cpu.r1.de = 0x05E9;
            cpu.r1.hl = 0x983D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x74);
            memory.Write8(0x983D, 0xFA);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x055C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x445E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x05E9, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x983D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB75() {
            cpu.Reset();
            cpu.r1.af = 0x6B00;
            cpu.r1.bc = 0x83C6;
            cpu.r1.de = 0x635A;
            cpu.r1.hl = 0xD18D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x75);
            memory.Write8(0xD18D, 0x11);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6B5C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x83C6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x635A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD18D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB76() {
            cpu.Reset();
            cpu.r1.af = 0xF800;
            cpu.r1.bc = 0x3057;
            cpu.r1.de = 0x3629;
            cpu.r1.hl = 0xBC71;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x76);
            memory.Write8(0xBC71, 0x18);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF85C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3057, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3629, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xBC71, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(12UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB77_1() {
            cpu.Reset();
            cpu.r1.af = 0xFF00;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x77);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFF38, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB77() {
            cpu.Reset();
            cpu.r1.af = 0x9200;
            cpu.r1.bc = 0xD6F8;
            cpu.r1.de = 0x5100;
            cpu.r1.hl = 0x736D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x77);
            memory.Write8(0x736D, 0x36);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9254, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD6F8, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5100, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x736D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB78() {
            cpu.Reset();
            cpu.r1.af = 0x7200;
            cpu.r1.bc = 0x1CF8;
            cpu.r1.de = 0x8D2B;
            cpu.r1.hl = 0xC76A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x78);
            memory.Write8(0xC76A, 0x1F);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x725C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1CF8, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8D2B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC76A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB79() {
            cpu.Reset();
            cpu.r1.af = 0xA800;
            cpu.r1.bc = 0x809E;
            cpu.r1.de = 0x1124;
            cpu.r1.hl = 0x39E8;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x79);
            memory.Write8(0x39E8, 0x98);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA898, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x809E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1124, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x39E8, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB7A() {
            cpu.Reset();
            cpu.r1.af = 0x5800;
            cpu.r1.bc = 0x7D24;
            cpu.r1.de = 0x63E1;
            cpu.r1.hl = 0xD9AF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x7A);
            memory.Write8(0xD9AF, 0xED);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5874, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7D24, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x63E1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD9AF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB7B() {
            cpu.Reset();
            cpu.r1.af = 0x0300;
            cpu.r1.bc = 0x50AB;
            cpu.r1.de = 0x05BD;
            cpu.r1.hl = 0x6BD0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x7B);
            memory.Write8(0x6BD0, 0xA5);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x03B8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x50AB, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x05BD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6BD0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB7C() {
            cpu.Reset();
            cpu.r1.af = 0xAD00;
            cpu.r1.bc = 0xF77B;
            cpu.r1.de = 0x55AE;
            cpu.r1.hl = 0x063B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x7C);
            memory.Write8(0x063B, 0x34);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAD54, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF77B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x55AE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x063B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB7D() {
            cpu.Reset();
            cpu.r1.af = 0x8200;
            cpu.r1.bc = 0xB792;
            cpu.r1.de = 0x38CB;
            cpu.r1.hl = 0x5F9B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x7D);
            memory.Write8(0x5F9B, 0x97);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8298, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB792, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x38CB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5F9B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB7E() {
            cpu.Reset();
            cpu.r1.af = 0x4200;
            cpu.r1.bc = 0x3B91;
            cpu.r1.de = 0xF59C;
            cpu.r1.hl = 0xA25E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x7E);
            memory.Write8(0xA25E, 0xD7);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4290, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3B91, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF59C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA25E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(12UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB7F_1() {
            cpu.Reset();
            cpu.r1.af = 0xFF00;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x7F);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFFB8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB7F() {
            cpu.Reset();
            cpu.r1.af = 0x6A00;
            cpu.r1.bc = 0x84EC;
            cpu.r1.de = 0xCF4E;
            cpu.r1.hl = 0x185B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x7F);
            memory.Write8(0x185B, 0xF1);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6A7C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x84EC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xCF4E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x185B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB80() {
            cpu.Reset();
            cpu.r1.af = 0x8F00;
            cpu.r1.bc = 0x702F;
            cpu.r1.de = 0x17BD;
            cpu.r1.hl = 0xA706;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x80);
            memory.Write8(0xA706, 0x0A);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8F00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x702F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x17BD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA706, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB81() {
            cpu.Reset();
            cpu.r1.af = 0xAE00;
            cpu.r1.bc = 0x947F;
            cpu.r1.de = 0x7153;
            cpu.r1.hl = 0x6616;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x81);
            memory.Write8(0x6616, 0x74);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAE00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x947E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7153, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6616, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB82() {
            cpu.Reset();
            cpu.r1.af = 0x8100;
            cpu.r1.bc = 0xBED2;
            cpu.r1.de = 0xC719;
            cpu.r1.hl = 0x4572;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x82);
            memory.Write8(0x4572, 0x2F);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8100, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBED2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC619, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4572, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB83() {
            cpu.Reset();
            cpu.r1.af = 0xE600;
            cpu.r1.bc = 0x63A2;
            cpu.r1.de = 0xCCF7;
            cpu.r1.hl = 0xAE9A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x83);
            memory.Write8(0xAE9A, 0x16);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE600, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x63A2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xCCF6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAE9A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB84() {
            cpu.Reset();
            cpu.r1.af = 0xCE00;
            cpu.r1.bc = 0xE0CC;
            cpu.r1.de = 0xD305;
            cpu.r1.hl = 0xD6C0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x84);
            memory.Write8(0xD6C0, 0x72);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCE00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE0CC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD305, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD6C0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB85() {
            cpu.Reset();
            cpu.r1.af = 0xF300;
            cpu.r1.bc = 0xED79;
            cpu.r1.de = 0x9DB7;
            cpu.r1.hl = 0xDDA0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x85);
            memory.Write8(0xDDA0, 0x8A);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF300, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xED79, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9DB7, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDDA0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB86() {
            cpu.Reset();
            cpu.r1.af = 0x2A00;
            cpu.r1.bc = 0xB0B9;
            cpu.r1.de = 0x9426;
            cpu.r1.hl = 0x1B48;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x86);
            memory.Write8(0x1B48, 0x62);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2A00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB0B9, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9426, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1B48, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB87() {
            cpu.Reset();
            cpu.r1.af = 0x1100;
            cpu.r1.bc = 0x86DC;
            cpu.r1.de = 0x1798;
            cpu.r1.hl = 0xDFC5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x87);
            memory.Write8(0xDFC5, 0xDE);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x86DC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1798, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDFC5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB88() {
            cpu.Reset();
            cpu.r1.af = 0xE300;
            cpu.r1.bc = 0x8A21;
            cpu.r1.de = 0xE33E;
            cpu.r1.hl = 0x674D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x88);
            memory.Write8(0x674D, 0x5F);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE300, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8821, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE33E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x674D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB89() {
            cpu.Reset();
            cpu.r1.af = 0x6000;
            cpu.r1.bc = 0xD186;
            cpu.r1.de = 0xC5B6;
            cpu.r1.hl = 0x1BD7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x89);
            memory.Write8(0x1BD7, 0xF2);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD184, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC5B6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1BD7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB8A() {
            cpu.Reset();
            cpu.r1.af = 0x3E00;
            cpu.r1.bc = 0x5FCD;
            cpu.r1.de = 0x0B38;
            cpu.r1.hl = 0xB98E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x8A);
            memory.Write8(0xB98E, 0x2F);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3E00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5FCD, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0938, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB98E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB8B() {
            cpu.Reset();
            cpu.r1.af = 0x6500;
            cpu.r1.bc = 0x040E;
            cpu.r1.de = 0x103F;
            cpu.r1.hl = 0x4A07;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x8B);
            memory.Write8(0x4A07, 0x3F);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6500, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x040E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x103D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4A07, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB8C() {
            cpu.Reset();
            cpu.r1.af = 0xF800;
            cpu.r1.bc = 0x6D27;
            cpu.r1.de = 0x9BDF;
            cpu.r1.hl = 0xDAEF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x8C);
            memory.Write8(0xDAEF, 0x0C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF800, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6D27, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9BDF, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD8EF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB8D() {
            cpu.Reset();
            cpu.r1.af = 0x3E00;
            cpu.r1.bc = 0x5469;
            cpu.r1.de = 0x2C28;
            cpu.r1.hl = 0xBD72;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x8D);
            memory.Write8(0xBD72, 0x13);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3E00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5469, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2C28, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xBD70, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB8E() {
            cpu.Reset();
            cpu.r1.af = 0x1F00;
            cpu.r1.bc = 0x140B;
            cpu.r1.de = 0xB492;
            cpu.r1.hl = 0x63A7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x8E);
            memory.Write8(0x63A7, 0xD4);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1F00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x140B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB492, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x63A7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB8F() {
            cpu.Reset();
            cpu.r1.af = 0x2500;
            cpu.r1.bc = 0xC522;
            cpu.r1.de = 0xCA46;
            cpu.r1.hl = 0x1C1A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x8F);
            memory.Write8(0x1C1A, 0x37);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2500, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC522, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xCA46, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1C1A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB90() {
            cpu.Reset();
            cpu.r1.af = 0x5700;
            cpu.r1.bc = 0x595C;
            cpu.r1.de = 0x4F0A;
            cpu.r1.hl = 0xC73C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x90);
            memory.Write8(0xC73C, 0xA2);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5700, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x595C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4F0A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC73C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB91() {
            cpu.Reset();
            cpu.r1.af = 0x5E00;
            cpu.r1.bc = 0x8F26;
            cpu.r1.de = 0xA735;
            cpu.r1.hl = 0x97E0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x91);
            memory.Write8(0x97E0, 0x5E);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5E00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8F22, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA735, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x97E0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB92() {
            cpu.Reset();
            cpu.r1.af = 0x3300;
            cpu.r1.bc = 0x7D9F;
            cpu.r1.de = 0x87D0;
            cpu.r1.hl = 0x83D0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x92);
            memory.Write8(0x83D0, 0x2B);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3300, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7D9F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x83D0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x83D0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB93() {
            cpu.Reset();
            cpu.r1.af = 0xC200;
            cpu.r1.bc = 0x4E05;
            cpu.r1.de = 0xB3F8;
            cpu.r1.hl = 0x2234;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x93);
            memory.Write8(0x2234, 0xA0);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4E05, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB3F8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2234, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB94() {
            cpu.Reset();
            cpu.r1.af = 0xEE00;
            cpu.r1.bc = 0x8F4B;
            cpu.r1.de = 0x2831;
            cpu.r1.hl = 0xD6A6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x94);
            memory.Write8(0xD6A6, 0xD0);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xEE00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8F4B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2831, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD2A6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB95() {
            cpu.Reset();
            cpu.r1.af = 0x3C00;
            cpu.r1.bc = 0x6AF2;
            cpu.r1.de = 0xB25D;
            cpu.r1.hl = 0x36FF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x95);
            memory.Write8(0x36FF, 0xCD);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3C00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6AF2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB25D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x36FB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB96() {
            cpu.Reset();
            cpu.r1.af = 0x7600;
            cpu.r1.bc = 0xB027;
            cpu.r1.de = 0xD0A5;
            cpu.r1.hl = 0x3324;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x96);
            memory.Write8(0x3324, 0x21);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7600, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB027, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD0A5, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3324, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB97() {
            cpu.Reset();
            cpu.r1.af = 0x1600;
            cpu.r1.bc = 0xAD09;
            cpu.r1.de = 0x7902;
            cpu.r1.hl = 0x97BC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x97);
            memory.Write8(0x97BC, 0x75);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAD09, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7902, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x97BC, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB98() {
            cpu.Reset();
            cpu.r1.af = 0x3400;
            cpu.r1.bc = 0xB61C;
            cpu.r1.de = 0x771D;
            cpu.r1.hl = 0x5D5E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x98);
            memory.Write8(0x5D5E, 0xA4);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3400, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB61C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x771D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5D5E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB99() {
            cpu.Reset();
            cpu.r1.af = 0x5100;
            cpu.r1.bc = 0x65BE;
            cpu.r1.de = 0x1359;
            cpu.r1.hl = 0x8BEC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x99);
            memory.Write8(0x8BEC, 0x0B);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5100, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x65B6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1359, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8BEC, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB9A() {
            cpu.Reset();
            cpu.r1.af = 0x6400;
            cpu.r1.bc = 0x976D;
            cpu.r1.de = 0x4C25;
            cpu.r1.hl = 0xDCB2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x9A);
            memory.Write8(0xDCB2, 0x09);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6400, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x976D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4425, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCB2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB9B() {
            cpu.Reset();
            cpu.r1.af = 0xA100;
            cpu.r1.bc = 0xB58A;
            cpu.r1.de = 0xD264;
            cpu.r1.hl = 0x2BD6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x9B);
            memory.Write8(0x2BD6, 0xD3);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA100, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB58A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD264, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2BD6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB9C() {
            cpu.Reset();
            cpu.r1.af = 0xD800;
            cpu.r1.bc = 0x63D6;
            cpu.r1.de = 0xAC7B;
            cpu.r1.hl = 0xC7A0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x9C);
            memory.Write8(0xC7A0, 0x75);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD800, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x63D6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xAC7B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC7A0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB9D() {
            cpu.Reset();
            cpu.r1.af = 0x0D00;
            cpu.r1.bc = 0xD840;
            cpu.r1.de = 0x0810;
            cpu.r1.hl = 0x0800;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x9D);
            memory.Write8(0x0800, 0xCD);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0D00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD840, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0810, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0800, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB9E() {
            cpu.Reset();
            cpu.r1.af = 0x3B00;
            cpu.r1.bc = 0xEBBF;
            cpu.r1.de = 0x9434;
            cpu.r1.hl = 0x3A65;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x9E);
            memory.Write8(0x3A65, 0x2A);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3B00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xEBBF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9434, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3A65, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCB9F() {
            cpu.Reset();
            cpu.r1.af = 0xB200;
            cpu.r1.bc = 0xD1DE;
            cpu.r1.de = 0xF991;
            cpu.r1.hl = 0x72F6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0x9F);
            memory.Write8(0x72F6, 0x72);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD1DE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF991, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x72F6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBA0() {
            cpu.Reset();
            cpu.r1.af = 0xFA00;
            cpu.r1.bc = 0xD669;
            cpu.r1.de = 0x71E1;
            cpu.r1.hl = 0xC80D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xA0);
            memory.Write8(0xC80D, 0xC0);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFA00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC669, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x71E1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC80D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBA1() {
            cpu.Reset();
            cpu.r1.af = 0x8200;
            cpu.r1.bc = 0x75E4;
            cpu.r1.de = 0xA0DE;
            cpu.r1.hl = 0xD0BA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xA1);
            memory.Write8(0xD0BA, 0xBD);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x75E4, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA0DE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD0BA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBA2() {
            cpu.Reset();
            cpu.r1.af = 0xDD00;
            cpu.r1.bc = 0x2B0D;
            cpu.r1.de = 0x5554;
            cpu.r1.hl = 0x6FC0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xA2);
            memory.Write8(0x6FC0, 0x61);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDD00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2B0D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4554, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6FC0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBA3() {
            cpu.Reset();
            cpu.r1.af = 0x2200;
            cpu.r1.bc = 0x2F0D;
            cpu.r1.de = 0x4D2C;
            cpu.r1.hl = 0x6666;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xA3);
            memory.Write8(0x6666, 0x8E);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2F0D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4D2C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6666, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBA4() {
            cpu.Reset();
            cpu.r1.af = 0xD600;
            cpu.r1.bc = 0xD8ED;
            cpu.r1.de = 0x9CD4;
            cpu.r1.hl = 0x8BB1;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xA4);
            memory.Write8(0x8BB1, 0xBB);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD600, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD8ED, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9CD4, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8BB1, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBA5() {
            cpu.Reset();
            cpu.r1.af = 0xB400;
            cpu.r1.bc = 0xB393;
            cpu.r1.de = 0x3E42;
            cpu.r1.hl = 0x88CA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xA5);
            memory.Write8(0x88CA, 0x4F);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB400, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB393, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3E42, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x88CA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBA6() {
            cpu.Reset();
            cpu.r1.af = 0x0A00;
            cpu.r1.bc = 0x4C34;
            cpu.r1.de = 0xF5A7;
            cpu.r1.hl = 0xE70D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xA6);
            memory.Write8(0xE70D, 0x27);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0A00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4C34, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF5A7, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE70D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBA7() {
            cpu.Reset();
            cpu.r1.af = 0x4500;
            cpu.r1.bc = 0xAF61;
            cpu.r1.de = 0x569A;
            cpu.r1.hl = 0xC77B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xA7);
            memory.Write8(0xC77B, 0xFF);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4500, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAF61, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x569A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC77B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBA8() {
            cpu.Reset();
            cpu.r1.af = 0x6400;
            cpu.r1.bc = 0xF269;
            cpu.r1.de = 0xBAE4;
            cpu.r1.hl = 0xC9E7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xA8);
            memory.Write8(0xC9E7, 0x46);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6400, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD269, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xBAE4, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC9E7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBA9() {
            cpu.Reset();
            cpu.r1.af = 0xE400;
            cpu.r1.bc = 0x7AD4;
            cpu.r1.de = 0xBF0A;
            cpu.r1.hl = 0xCE0B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xA9);
            memory.Write8(0xCE0B, 0x39);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE400, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7AD4, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xBF0A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCE0B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBAA() {
            cpu.Reset();
            cpu.r1.af = 0xCD00;
            cpu.r1.bc = 0xD249;
            cpu.r1.de = 0x4159;
            cpu.r1.hl = 0xFED5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xAA);
            memory.Write8(0xFED5, 0xB0);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCD00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD249, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4159, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xFED5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBAB() {
            cpu.Reset();
            cpu.r1.af = 0xAC00;
            cpu.r1.bc = 0x939A;
            cpu.r1.de = 0x5D9B;
            cpu.r1.hl = 0x0812;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xAB);
            memory.Write8(0x0812, 0xF2);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAC00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x939A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5D9B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0812, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBAC() {
            cpu.Reset();
            cpu.r1.af = 0x2400;
            cpu.r1.bc = 0x8A7D;
            cpu.r1.de = 0x2CAC;
            cpu.r1.hl = 0xFFAA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xAC);
            memory.Write8(0xFFAA, 0x09);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2400, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8A7D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2CAC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDFAA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBAD() {
            cpu.Reset();
            cpu.r1.af = 0x6F00;
            cpu.r1.bc = 0x5FFB;
            cpu.r1.de = 0x2360;
            cpu.r1.hl = 0xAE15;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xAD);
            memory.Write8(0xAE15, 0x30);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6F00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5FFB, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2360, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAE15, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBAE() {
            cpu.Reset();
            cpu.r1.af = 0x5A00;
            cpu.r1.bc = 0xAA17;
            cpu.r1.de = 0x12F3;
            cpu.r1.hl = 0x190E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xAE);
            memory.Write8(0x190E, 0x66);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5A00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAA17, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x12F3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x190E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBAF() {
            cpu.Reset();
            cpu.r1.af = 0xFC00;
            cpu.r1.bc = 0xBB3F;
            cpu.r1.de = 0x8BB6;
            cpu.r1.hl = 0x5877;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xAF);
            memory.Write8(0x5877, 0x62);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDC00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBB3F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8BB6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5877, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBB0() {
            cpu.Reset();
            cpu.r1.af = 0xB900;
            cpu.r1.bc = 0x7A79;
            cpu.r1.de = 0x1AAA;
            cpu.r1.hl = 0xC3BA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xB0);
            memory.Write8(0xC3BA, 0x4C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB900, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3A79, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1AAA, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC3BA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBB1() {
            cpu.Reset();
            cpu.r1.af = 0x4900;
            cpu.r1.bc = 0x63E4;
            cpu.r1.de = 0xA544;
            cpu.r1.hl = 0x1190;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xB1);
            memory.Write8(0x1190, 0xE3);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4900, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x63A4, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA544, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1190, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBB2() {
            cpu.Reset();
            cpu.r1.af = 0x4D00;
            cpu.r1.bc = 0x2B03;
            cpu.r1.de = 0x6B23;
            cpu.r1.hl = 0x6FF5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xB2);
            memory.Write8(0x6FF5, 0x04);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4D00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2B03, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2B23, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6FF5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBB3() {
            cpu.Reset();
            cpu.r1.af = 0x8700;
            cpu.r1.bc = 0x857A;
            cpu.r1.de = 0xE98B;
            cpu.r1.hl = 0x5CB1;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xB3);
            memory.Write8(0x5CB1, 0x43);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8700, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x857A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE98B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5CB1, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBB4() {
            cpu.Reset();
            cpu.r1.af = 0x2B00;
            cpu.r1.bc = 0xB73E;
            cpu.r1.de = 0x79C9;
            cpu.r1.hl = 0xE1BB;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xB4);
            memory.Write8(0xE1BB, 0x78);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2B00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB73E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x79C9, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA1BB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBB5() {
            cpu.Reset();
            cpu.r1.af = 0x9B00;
            cpu.r1.bc = 0xD879;
            cpu.r1.de = 0x2EC9;
            cpu.r1.hl = 0x4BBA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xB5);
            memory.Write8(0x4BBA, 0x70);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9B00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD879, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2EC9, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4BBA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBB6() {
            cpu.Reset();
            cpu.r1.af = 0x8600;
            cpu.r1.bc = 0x89BF;
            cpu.r1.de = 0xDE4A;
            cpu.r1.hl = 0x4FAB;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xB6);
            memory.Write8(0x4FAB, 0xA5);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8600, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x89BF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDE4A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4FAB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBB7() {
            cpu.Reset();
            cpu.r1.af = 0x2200;
            cpu.r1.bc = 0xFB8A;
            cpu.r1.de = 0x3D6E;
            cpu.r1.hl = 0xD4A2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xB7);
            memory.Write8(0xD4A2, 0xF2);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFB8A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3D6E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD4A2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBB8() {
            cpu.Reset();
            cpu.r1.af = 0xD000;
            cpu.r1.bc = 0x37C6;
            cpu.r1.de = 0x225A;
            cpu.r1.hl = 0xD249;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xB8);
            memory.Write8(0xD249, 0xC4);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x37C6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x225A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD249, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBB9() {
            cpu.Reset();
            cpu.r1.af = 0xA500;
            cpu.r1.bc = 0x1B4A;
            cpu.r1.de = 0xD584;
            cpu.r1.hl = 0x5DEE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xB9);
            memory.Write8(0x5DEE, 0xCC);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA500, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1B4A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD584, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5DEE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBBA() {
            cpu.Reset();
            cpu.r1.af = 0x6300;
            cpu.r1.bc = 0xA5FE;
            cpu.r1.de = 0xF42B;
            cpu.r1.hl = 0x34C9;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xBA);
            memory.Write8(0x34C9, 0xBC);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6300, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA5FE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x742B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x34C9, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBBB() {
            cpu.Reset();
            cpu.r1.af = 0x1200;
            cpu.r1.bc = 0xF661;
            cpu.r1.de = 0xAA4F;
            cpu.r1.hl = 0xCB30;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xBB);
            memory.Write8(0xCB30, 0xF4);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF661, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xAA4F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCB30, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBBC() {
            cpu.Reset();
            cpu.r1.af = 0x9800;
            cpu.r1.bc = 0xADC3;
            cpu.r1.de = 0x0B29;
            cpu.r1.hl = 0x7B6E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xBC);
            memory.Write8(0x7B6E, 0x45);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9800, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xADC3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0B29, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7B6E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBBD() {
            cpu.Reset();
            cpu.r1.af = 0xD600;
            cpu.r1.bc = 0xA6E1;
            cpu.r1.de = 0x8813;
            cpu.r1.hl = 0x10B8;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xBD);
            memory.Write8(0x10B8, 0x35);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD600, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA6E1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8813, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1038, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBBE() {
            cpu.Reset();
            cpu.r1.af = 0xCA00;
            cpu.r1.bc = 0xFF64;
            cpu.r1.de = 0x1218;
            cpu.r1.hl = 0x77D5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xBE);
            memory.Write8(0x77D5, 0xEA);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCA00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFF64, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1218, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x77D5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBBF() {
            cpu.Reset();
            cpu.r1.af = 0x6800;
            cpu.r1.bc = 0x4845;
            cpu.r1.de = 0x690A;
            cpu.r1.hl = 0x15DE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xBF);
            memory.Write8(0x15DE, 0x1D);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6800, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4845, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x690A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x15DE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBC0() {
            cpu.Reset();
            cpu.r1.af = 0xE300;
            cpu.r1.bc = 0xEF71;
            cpu.r1.de = 0xBFFB;
            cpu.r1.hl = 0xB3A1;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xC0);
            memory.Write8(0xB3A1, 0x5C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE300, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xEF71, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xBFFB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB3A1, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBC1() {
            cpu.Reset();
            cpu.r1.af = 0x3200;
            cpu.r1.bc = 0x32A1;
            cpu.r1.de = 0x59AB;
            cpu.r1.hl = 0x3343;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xC1);
            memory.Write8(0x3343, 0xAA);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x32A1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x59AB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3343, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBC2() {
            cpu.Reset();
            cpu.r1.af = 0xC700;
            cpu.r1.bc = 0xB159;
            cpu.r1.de = 0xC023;
            cpu.r1.hl = 0xE1F3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xC2);
            memory.Write8(0xE1F3, 0x14);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC700, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB159, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC123, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE1F3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBC3() {
            cpu.Reset();
            cpu.r1.af = 0x0400;
            cpu.r1.bc = 0xB463;
            cpu.r1.de = 0xC211;
            cpu.r1.hl = 0x8F3A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xC3);
            memory.Write8(0x8F3A, 0x81);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0400, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB463, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xC211, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8F3A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBC4() {
            cpu.Reset();
            cpu.r1.af = 0x7E00;
            cpu.r1.bc = 0x545A;
            cpu.r1.de = 0x6ECF;
            cpu.r1.hl = 0x5876;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xC4);
            memory.Write8(0x5876, 0x9D);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7E00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x545A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6ECF, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5976, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBC5() {
            cpu.Reset();
            cpu.r1.af = 0x4000;
            cpu.r1.bc = 0xC617;
            cpu.r1.de = 0x079C;
            cpu.r1.hl = 0x4107;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xC5);
            memory.Write8(0x4107, 0xCC);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC617, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x079C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4107, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBC6() {
            cpu.Reset();
            cpu.r1.af = 0xB800;
            cpu.r1.bc = 0x0373;
            cpu.r1.de = 0xB807;
            cpu.r1.hl = 0xF0BE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xC6);
            memory.Write8(0xF0BE, 0x9C);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB800, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0373, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB807, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF0BE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBC7() {
            cpu.Reset();
            cpu.r1.af = 0x7700;
            cpu.r1.bc = 0x3681;
            cpu.r1.de = 0x9B55;
            cpu.r1.hl = 0x583F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xC7);
            memory.Write8(0x583F, 0x58);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7700, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3681, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9B55, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x583F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBC8() {
            cpu.Reset();
            cpu.r1.af = 0x7D00;
            cpu.r1.bc = 0xA772;
            cpu.r1.de = 0x8682;
            cpu.r1.hl = 0x7CF3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xC8);
            memory.Write8(0x7CF3, 0x75);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7D00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA772, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8682, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7CF3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBC9() {
            cpu.Reset();
            cpu.r1.af = 0x0B00;
            cpu.r1.bc = 0x67EE;
            cpu.r1.de = 0x30E0;
            cpu.r1.hl = 0x72DB;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xC9);
            memory.Write8(0x72DB, 0x87);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0B00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x67EE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x30E0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x72DB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBCA() {
            cpu.Reset();
            cpu.r1.af = 0x9C00;
            cpu.r1.bc = 0x9517;
            cpu.r1.de = 0xCFBB;
            cpu.r1.hl = 0xFBC7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xCA);
            memory.Write8(0xFBC7, 0x1A);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9C00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9517, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xCFBB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xFBC7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBCB() {
            cpu.Reset();
            cpu.r1.af = 0xE800;
            cpu.r1.bc = 0x0F3D;
            cpu.r1.de = 0x336F;
            cpu.r1.hl = 0xF70D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0xF70D, 0xA1);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE800, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x336F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF70D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBCC() {
            cpu.Reset();
            cpu.r1.af = 0xFB00;
            cpu.r1.bc = 0x7981;
            cpu.r1.de = 0x0BBB;
            cpu.r1.hl = 0x18FD;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xCC);
            memory.Write8(0x18FD, 0xFE);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFB00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7981, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0BBB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1AFD, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBCD() {
            cpu.Reset();
            cpu.r1.af = 0x5500;
            cpu.r1.bc = 0x5E78;
            cpu.r1.de = 0xBF34;
            cpu.r1.hl = 0x2602;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xCD);
            memory.Write8(0x2602, 0x2D);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5500, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5E78, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xBF34, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2602, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBCE() {
            cpu.Reset();
            cpu.r1.af = 0xD500;
            cpu.r1.bc = 0xA111;
            cpu.r1.de = 0xCB2A;
            cpu.r1.hl = 0x8EC6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xCE);
            memory.Write8(0x8EC6, 0xBF);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD500, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA111, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xCB2A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8EC6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBCF() {
            cpu.Reset();
            cpu.r1.af = 0xA200;
            cpu.r1.bc = 0x6BAF;
            cpu.r1.de = 0x98B2;
            cpu.r1.hl = 0x98A0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xCF);
            memory.Write8(0x98A0, 0xD4);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6BAF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x98B2, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x98A0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBD0() {
            cpu.Reset();
            cpu.r1.af = 0x2300;
            cpu.r1.bc = 0x7BCB;
            cpu.r1.de = 0x02E7;
            cpu.r1.hl = 0x1724;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xD0);
            memory.Write8(0x1724, 0x30);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2300, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7FCB, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x02E7, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1724, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBD1() {
            cpu.Reset();
            cpu.r1.af = 0x5300;
            cpu.r1.bc = 0x581F;
            cpu.r1.de = 0xB775;
            cpu.r1.hl = 0x47F4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xD1);
            memory.Write8(0x47F4, 0xC7);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5300, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x581F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB775, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x47F4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBD2() {
            cpu.Reset();
            cpu.r1.af = 0x6900;
            cpu.r1.bc = 0xC147;
            cpu.r1.de = 0xB79C;
            cpu.r1.hl = 0x7528;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xD2);
            memory.Write8(0x7528, 0x4F);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6900, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC147, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB79C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7528, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBD3() {
            cpu.Reset();
            cpu.r1.af = 0xAE00;
            cpu.r1.bc = 0xBBC4;
            cpu.r1.de = 0xCE52;
            cpu.r1.hl = 0x5FBA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xD3);
            memory.Write8(0x5FBA, 0x3A);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAE00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBBC4, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xCE56, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5FBA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBD4() {
            cpu.Reset();
            cpu.r1.af = 0xD800;
            cpu.r1.bc = 0x6E1E;
            cpu.r1.de = 0xAF6F;
            cpu.r1.hl = 0xBF2E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xD4);
            memory.Write8(0xBF2E, 0x71);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD800, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6E1E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xAF6F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xBF2E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBD5() {
            cpu.Reset();
            cpu.r1.af = 0x8400;
            cpu.r1.bc = 0xA19A;
            cpu.r1.de = 0xD2FD;
            cpu.r1.hl = 0x8A77;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xD5);
            memory.Write8(0x8A77, 0x52);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8400, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA19A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD2FD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8A77, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBD6() {
            cpu.Reset();
            cpu.r1.af = 0xA900;
            cpu.r1.bc = 0xF5F3;
            cpu.r1.de = 0x2180;
            cpu.r1.hl = 0x6029;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xD6);
            memory.Write8(0x6029, 0xB7);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA900, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF5F3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2180, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6029, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBD7() {
            cpu.Reset();
            cpu.r1.af = 0xB100;
            cpu.r1.bc = 0xC008;
            cpu.r1.de = 0x8425;
            cpu.r1.hl = 0x290A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xD7);
            memory.Write8(0x290A, 0x42);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB500, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC008, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8425, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x290A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBD8() {
            cpu.Reset();
            cpu.r1.af = 0x8B00;
            cpu.r1.bc = 0x09C4;
            cpu.r1.de = 0xDDF3;
            cpu.r1.hl = 0x6D7E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xD8);
            memory.Write8(0x6D7E, 0x6E);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8B00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x09C4, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDDF3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6D7E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBD9() {
            cpu.Reset();
            cpu.r1.af = 0x3E00;
            cpu.r1.bc = 0x3E36;
            cpu.r1.de = 0x30EC;
            cpu.r1.hl = 0xEFC6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xD9);
            memory.Write8(0xEFC6, 0x5B);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3E00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3E3E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x30EC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xEFC6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBDA() {
            cpu.Reset();
            cpu.r1.af = 0xD000;
            cpu.r1.bc = 0x3E8F;
            cpu.r1.de = 0x28FE;
            cpu.r1.hl = 0x1C87;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xDA);
            memory.Write8(0x1C87, 0xB9);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3E8F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x28FE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1C87, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBDB() {
            cpu.Reset();
            cpu.r1.af = 0x1200;
            cpu.r1.bc = 0x977A;
            cpu.r1.de = 0x8C49;
            cpu.r1.hl = 0xBC48;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xDB);
            memory.Write8(0xBC48, 0xEF);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x977A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8C49, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xBC48, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBDC() {
            cpu.Reset();
            cpu.r1.af = 0x8D00;
            cpu.r1.bc = 0x05DE;
            cpu.r1.de = 0xF8D3;
            cpu.r1.hl = 0xB125;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xDC);
            memory.Write8(0xB125, 0x0E);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8D00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x05DE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF8D3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB925, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBDD() {
            cpu.Reset();
            cpu.r1.af = 0xC300;
            cpu.r1.bc = 0x08A9;
            cpu.r1.de = 0x2BC8;
            cpu.r1.hl = 0x5B9F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xDD);
            memory.Write8(0x5B9F, 0x94);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC300, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x08A9, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2BC8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5B9F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBDE() {
            cpu.Reset();
            cpu.r1.af = 0x1900;
            cpu.r1.bc = 0x900F;
            cpu.r1.de = 0xD572;
            cpu.r1.hl = 0xBA03;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xDE);
            memory.Write8(0xBA03, 0x93);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1900, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x900F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD572, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xBA03, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBDF() {
            cpu.Reset();
            cpu.r1.af = 0x6700;
            cpu.r1.bc = 0x2745;
            cpu.r1.de = 0x7E3D;
            cpu.r1.hl = 0x0FA1;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xDF);
            memory.Write8(0x0FA1, 0xC5);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6F00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2745, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7E3D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0FA1, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBE0() {
            cpu.Reset();
            cpu.r1.af = 0x3E00;
            cpu.r1.bc = 0xD633;
            cpu.r1.de = 0x9897;
            cpu.r1.hl = 0x3744;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xE0);
            memory.Write8(0x3744, 0x54);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3E00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD633, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9897, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3744, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBE1() {
            cpu.Reset();
            cpu.r1.af = 0x7D00;
            cpu.r1.bc = 0x50A6;
            cpu.r1.de = 0x0136;
            cpu.r1.hl = 0x5334;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xE1);
            memory.Write8(0x5334, 0x85);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7D00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x50B6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0136, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5334, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBE2() {
            cpu.Reset();
            cpu.r1.af = 0xD400;
            cpu.r1.bc = 0x6B45;
            cpu.r1.de = 0xA192;
            cpu.r1.hl = 0x3A4C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xE2);
            memory.Write8(0x3A4C, 0x47);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD400, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6B45, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB192, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3A4C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBE3() {
            cpu.Reset();
            cpu.r1.af = 0x3B00;
            cpu.r1.bc = 0xD29C;
            cpu.r1.de = 0x05E0;
            cpu.r1.hl = 0x2E78;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xE3);
            memory.Write8(0x2E78, 0x48);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3B00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD29C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x05F0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2E78, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBE4() {
            cpu.Reset();
            cpu.r1.af = 0x1E00;
            cpu.r1.bc = 0x7D5E;
            cpu.r1.de = 0x846D;
            cpu.r1.hl = 0x0978;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xE4);
            memory.Write8(0x0978, 0x84);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1E00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7D5E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x846D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1978, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBE5() {
            cpu.Reset();
            cpu.r1.af = 0xCA00;
            cpu.r1.bc = 0xDF0D;
            cpu.r1.de = 0xD588;
            cpu.r1.hl = 0xB48F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xE5);
            memory.Write8(0xB48F, 0xCF);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCA00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xDF0D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD588, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB49F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBE6() {
            cpu.Reset();
            cpu.r1.af = 0xB300;
            cpu.r1.bc = 0x52C2;
            cpu.r1.de = 0xDBFE;
            cpu.r1.hl = 0x9F9B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xE6);
            memory.Write8(0x9F9B, 0xF6);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB300, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x52C2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDBFE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9F9B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBE7() {
            cpu.Reset();
            cpu.r1.af = 0x8E00;
            cpu.r1.bc = 0xCF02;
            cpu.r1.de = 0x67EF;
            cpu.r1.hl = 0xF2E0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xE7);
            memory.Write8(0xF2E0, 0xCF);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9E00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF02, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x67EF, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF2E0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBE8() {
            cpu.Reset();
            cpu.r1.af = 0x7100;
            cpu.r1.bc = 0xBB18;
            cpu.r1.de = 0x66EC;
            cpu.r1.hl = 0x4A05;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xE8);
            memory.Write8(0x4A05, 0xE6);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7100, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBB18, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x66EC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4A05, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBE9() {
            cpu.Reset();
            cpu.r1.af = 0x5700;
            cpu.r1.bc = 0x2897;
            cpu.r1.de = 0x8F2F;
            cpu.r1.hl = 0xA4D0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xE9);
            memory.Write8(0xA4D0, 0xB2);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5700, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x28B7, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8F2F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA4D0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBEA() {
            cpu.Reset();
            cpu.r1.af = 0xEC00;
            cpu.r1.bc = 0x304A;
            cpu.r1.de = 0x60A1;
            cpu.r1.hl = 0xF32A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xEA);
            memory.Write8(0xF32A, 0x9C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xEC00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x304A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x60A1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF32A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBEB() {
            cpu.Reset();
            cpu.r1.af = 0xF000;
            cpu.r1.bc = 0x532B;
            cpu.r1.de = 0xA1BE;
            cpu.r1.hl = 0x1A1A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xEB);
            memory.Write8(0x1A1A, 0x21);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x532B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA1BE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1A1A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBEC() {
            cpu.Reset();
            cpu.r1.af = 0xF200;
            cpu.r1.bc = 0xF0F3;
            cpu.r1.de = 0xA816;
            cpu.r1.hl = 0xBA08;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xEC);
            memory.Write8(0xBA08, 0x82);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF0F3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA816, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xBA08, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBED() {
            cpu.Reset();
            cpu.r1.af = 0x1300;
            cpu.r1.bc = 0x5127;
            cpu.r1.de = 0xADAB;
            cpu.r1.hl = 0x2DEC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xED);
            memory.Write8(0x2DEC, 0xCB);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1300, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5127, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xADAB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2DEC, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBEE() {
            cpu.Reset();
            cpu.r1.af = 0x9000;
            cpu.r1.bc = 0xB273;
            cpu.r1.de = 0x50AE;
            cpu.r1.hl = 0xE90D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xEE);
            memory.Write8(0xE90D, 0xF1);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB273, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x50AE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE90D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBEF() {
            cpu.Reset();
            cpu.r1.af = 0x2500;
            cpu.r1.bc = 0x4281;
            cpu.r1.de = 0xF0D4;
            cpu.r1.hl = 0x2C39;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xEF);
            memory.Write8(0x2C39, 0xC8);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2500, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4281, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF0D4, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2C39, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBF0() {
            cpu.Reset();
            cpu.r1.af = 0xFB00;
            cpu.r1.bc = 0x5802;
            cpu.r1.de = 0x0C27;
            cpu.r1.hl = 0x6FF5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xF0);
            memory.Write8(0x6FF5, 0xF6);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFB00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5802, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0C27, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6FF5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBF1() {
            cpu.Reset();
            cpu.r1.af = 0x5500;
            cpu.r1.bc = 0xA103;
            cpu.r1.de = 0x3FF5;
            cpu.r1.hl = 0x5E1C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xF1);
            memory.Write8(0x5E1C, 0x37);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5500, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA143, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3FF5, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5E1C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBF2() {
            cpu.Reset();
            cpu.r1.af = 0xF000;
            cpu.r1.bc = 0x625A;
            cpu.r1.de = 0xAF82;
            cpu.r1.hl = 0x9819;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xF2);
            memory.Write8(0x9819, 0xE4);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x625A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xEF82, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9819, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBF3() {
            cpu.Reset();
            cpu.r1.af = 0x8600;
            cpu.r1.bc = 0xD7BD;
            cpu.r1.de = 0x5D86;
            cpu.r1.hl = 0x263F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xF3);
            memory.Write8(0x263F, 0xA1);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8600, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD7BD, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5DC6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x263F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBF4() {
            cpu.Reset();
            cpu.r1.af = 0x9400;
            cpu.r1.bc = 0x0243;
            cpu.r1.de = 0x9EC1;
            cpu.r1.hl = 0x75D9;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xF4);
            memory.Write8(0x75D9, 0x3F);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9400, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0243, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9EC1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x75D9, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBF5() {
            cpu.Reset();
            cpu.r1.af = 0xCE00;
            cpu.r1.bc = 0x2D42;
            cpu.r1.de = 0x5E6A;
            cpu.r1.hl = 0x47E6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xF5);
            memory.Write8(0x47E6, 0xCE);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCE00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2D42, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5E6A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x47E6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBF6() {
            cpu.Reset();
            cpu.r1.af = 0x7B00;
            cpu.r1.bc = 0xC2D7;
            cpu.r1.de = 0x4492;
            cpu.r1.hl = 0xA9BC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xF6);
            memory.Write8(0xA9BC, 0xB1);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7B00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC2D7, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4492, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA9BC, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBF7() {
            cpu.Reset();
            cpu.r1.af = 0x6D00;
            cpu.r1.bc = 0xABAF;
            cpu.r1.de = 0x5B5D;
            cpu.r1.hl = 0x188C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xF7);
            memory.Write8(0x188C, 0x6C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6D00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xABAF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5B5D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x188C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBF8() {
            cpu.Reset();
            cpu.r1.af = 0xC600;
            cpu.r1.bc = 0xB812;
            cpu.r1.de = 0xA037;
            cpu.r1.hl = 0xD2B0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xF8);
            memory.Write8(0xD2B0, 0xCB);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC600, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB812, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA037, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD2B0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBF9() {
            cpu.Reset();
            cpu.r1.af = 0xEF00;
            cpu.r1.bc = 0xC5F2;
            cpu.r1.de = 0x77A8;
            cpu.r1.hl = 0x0730;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xF9);
            memory.Write8(0x0730, 0xAE);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xEF00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC5F2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x77A8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0730, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBFA() {
            cpu.Reset();
            cpu.r1.af = 0x8700;
            cpu.r1.bc = 0x1581;
            cpu.r1.de = 0x63E3;
            cpu.r1.hl = 0xED03;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xFA);
            memory.Write8(0xED03, 0x27);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8700, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1581, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE3E3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xED03, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBFB() {
            cpu.Reset();
            cpu.r1.af = 0xA300;
            cpu.r1.bc = 0x7D27;
            cpu.r1.de = 0x97C3;
            cpu.r1.hl = 0xD1AE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xFB);
            memory.Write8(0xD1AE, 0xF2);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA300, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7D27, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x97C3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD1AE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBFC() {
            cpu.Reset();
            cpu.r1.af = 0xEC00;
            cpu.r1.bc = 0x060A;
            cpu.r1.de = 0x3EF6;
            cpu.r1.hl = 0x500F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xFC);
            memory.Write8(0x500F, 0x94);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xEC00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x060A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3EF6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD00F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBFD() {
            cpu.Reset();
            cpu.r1.af = 0x1100;
            cpu.r1.bc = 0x231A;
            cpu.r1.de = 0x8563;
            cpu.r1.hl = 0x28C5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xFD);
            memory.Write8(0x28C5, 0xAB);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1100, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x231A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8563, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x28C5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBFE() {
            cpu.Reset();
            cpu.r1.af = 0x5300;
            cpu.r1.bc = 0x4948;
            cpu.r1.de = 0x89DD;
            cpu.r1.hl = 0x3A24;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xFE);
            memory.Write8(0x3A24, 0xC3);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5300, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4948, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x89DD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3A24, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCBFF() {
            cpu.Reset();
            cpu.r1.af = 0x7900;
            cpu.r1.bc = 0x799B;
            cpu.r1.de = 0x6CF7;
            cpu.r1.hl = 0xE3F2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCB);
            memory.Write8(0x0001, 0xFF);
            memory.Write8(0xE3F2, 0x25);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF900, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x799B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6CF7, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE3F2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }
    }
}