using Microsoft.VisualStudio.TestTools.UnitTesting;
using Z80;

namespace z80ilTest
{
    [TestClass]
    public class CpuTestED
    {
        readonly Cpu cpu;
        SimpleMemory memory;

        public CpuTestED() {
            memory = new SimpleMemory();
            cpu = new Cpu(memory);
        }

        [TestMethod]
        public void TestED40() {
            cpu.Reset();
            cpu.r1.af = 0x83F9;
            cpu.r1.bc = 0x296B;
            cpu.r1.de = 0x7034;
            cpu.r1.hl = 0x1F2F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x40);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8329, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x296B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7034, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1F2F, cpu.r1.hl, "HL mismatch");
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
        public void TestED41() {
            cpu.Reset();
            cpu.r1.af = 0x29A2;
            cpu.r1.bc = 0x0881;
            cpu.r1.de = 0xD7DD;
            cpu.r1.hl = 0xFF4E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x41);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x29A2, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0881, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD7DD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xFF4E, cpu.r1.hl, "HL mismatch");
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
        public void TestED42() {
            cpu.Reset();
            cpu.r1.af = 0xCBD3;
            cpu.r1.bc = 0x1C8F;
            cpu.r1.de = 0xD456;
            cpu.r1.hl = 0x315E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x42);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCB12, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1C8F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD456, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x14CE, cpu.r1.hl, "HL mismatch");
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
        public void TestED43() {
            cpu.Reset();
            cpu.r1.af = 0xDA36;
            cpu.r1.bc = 0x2732;
            cpu.r1.de = 0x91CC;
            cpu.r1.hl = 0x9798;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5F73;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x43);
            memory.Write8(0x0002, 0xC6);
            memory.Write8(0x0003, 0x54);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDA36, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2732, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x91CC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9798, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5F73, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED44() {
            cpu.Reset();
            cpu.r1.af = 0xFE2B;
            cpu.r1.bc = 0x040F;
            cpu.r1.de = 0xDEB6;
            cpu.r1.hl = 0xAFC3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5CA8;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x44);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0213, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x040F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDEB6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAFC3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5CA8, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED45() {
            cpu.Reset();
            cpu.r1.af = 0x001D;
            cpu.r1.bc = 0x5B63;
            cpu.r1.de = 0xA586;
            cpu.r1.hl = 0x1451;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x3100;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x45);
            memory.Write8(0x3100, 0x1F);
            memory.Write8(0x3101, 0x22);

            while (cpu.tStates < 14) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x001D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5B63, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA586, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1451, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x3102, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(14UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED46() {
            cpu.Reset();
            cpu.r1.af = 0xB6EC;
            cpu.r1.bc = 0x8AFB;
            cpu.r1.de = 0xCE09;
            cpu.r1.hl = 0x70A1;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x8DEA;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x46);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB6EC, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8AFB, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xCE09, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x70A1, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x8DEA, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED47() {
            cpu.Reset();
            cpu.r1.af = 0x9A99;
            cpu.r1.bc = 0x9E5A;
            cpu.r1.de = 0x9913;
            cpu.r1.hl = 0xCACC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x47);

            while (cpu.tStates < 9) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9A99, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9E5A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9913, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCACC, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x009A, cpu.i, "I mismatch");
            Assert.AreEqual(9UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED48() {
            cpu.Reset();
            cpu.r1.af = 0xDBDD;
            cpu.r1.bc = 0x7D1B;
            cpu.r1.de = 0x141D;
            cpu.r1.hl = 0x5FB4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x48);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDB2D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7D7D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x141D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5FB4, cpu.r1.hl, "HL mismatch");
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
        public void TestED49() {
            cpu.Reset();
            cpu.r1.af = 0x07A5;
            cpu.r1.bc = 0x59EC;
            cpu.r1.de = 0xF459;
            cpu.r1.hl = 0x4316;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x49);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x07A5, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x59EC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF459, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4316, cpu.r1.hl, "HL mismatch");
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
        public void TestED4A() {
            cpu.Reset();
            cpu.r1.af = 0x5741;
            cpu.r1.bc = 0x24B5;
            cpu.r1.de = 0x83D2;
            cpu.r1.hl = 0x9AC8;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x4A);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x57A8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x24B5, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x83D2, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xBF7E, cpu.r1.hl, "HL mismatch");
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
        public void TestED4B() {
            cpu.Reset();
            cpu.r1.af = 0x650C;
            cpu.r1.bc = 0xD74D;
            cpu.r1.de = 0x0448;
            cpu.r1.hl = 0xA3B9;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0xB554;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x4B);
            memory.Write8(0x0002, 0x1A);
            memory.Write8(0x0003, 0xA4);
            memory.Write8(0xA41A, 0xF3);
            memory.Write8(0xA41B, 0xD4);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x650C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD4F3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0448, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA3B9, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0xB554, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED4C() {
            cpu.Reset();
            cpu.r1.af = 0x5682;
            cpu.r1.bc = 0x7DDE;
            cpu.r1.de = 0xB049;
            cpu.r1.hl = 0x939D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0xC7BB;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x4C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAABB, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7DDE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB049, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x939D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0xC7BB, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED4D() {
            cpu.Reset();
            cpu.r1.af = 0x1BED;
            cpu.r1.bc = 0xC358;
            cpu.r1.de = 0x5FD5;
            cpu.r1.hl = 0x6093;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x680E;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x4D);
            memory.Write8(0x680E, 0x03);
            memory.Write8(0x680F, 0x7C);

            while (cpu.tStates < 14) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1BED, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC358, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5FD5, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6093, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x6810, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(14UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED4E() {
            cpu.Reset();
            cpu.r1.af = 0x8E01;
            cpu.r1.bc = 0xE7C6;
            cpu.r1.de = 0x880F;
            cpu.r1.hl = 0xD2A2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x85DA;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x4E);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8E01, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE7C6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x880F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD2A2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x85DA, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED4F() {
            cpu.Reset();
            cpu.r1.af = 0x2AE3;
            cpu.r1.bc = 0xC115;
            cpu.r1.de = 0xEFF8;
            cpu.r1.hl = 0x9F6D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x4F);

            while (cpu.tStates < 9) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2AE3, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC115, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xEFF8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9F6D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x002A, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(9UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED50() {
            cpu.Reset();
            cpu.r1.af = 0x85AE;
            cpu.r1.bc = 0xBBCC;
            cpu.r1.de = 0xE2A8;
            cpu.r1.hl = 0xF219;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x50);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x85AC, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBBCC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xBBA8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF219, cpu.r1.hl, "HL mismatch");
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
        public void TestED51() {
            cpu.Reset();
            cpu.r1.af = 0x2C4C;
            cpu.r1.bc = 0xC0A4;
            cpu.r1.de = 0x5303;
            cpu.r1.hl = 0xBC25;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x51);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2C4C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC0A4, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5303, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xBC25, cpu.r1.hl, "HL mismatch");
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
        public void TestED52() {
            cpu.Reset();
            cpu.r1.af = 0xFC57;
            cpu.r1.bc = 0x1FC8;
            cpu.r1.de = 0x47B6;
            cpu.r1.hl = 0xDA7C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x52);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFC82, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1FC8, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x47B6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x92C5, cpu.r1.hl, "HL mismatch");
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
        public void TestED53() {
            cpu.Reset();
            cpu.r1.af = 0x1F88;
            cpu.r1.bc = 0x4692;
            cpu.r1.de = 0x5CB2;
            cpu.r1.hl = 0x4915;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x7D8C;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x53);
            memory.Write8(0x0002, 0xFF);
            memory.Write8(0x0003, 0x21);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1F88, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4692, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5CB2, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4915, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x7D8C, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED54() {
            cpu.Reset();
            cpu.r1.af = 0xADF9;
            cpu.r1.bc = 0x5661;
            cpu.r1.de = 0x547C;
            cpu.r1.hl = 0xC322;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0xD9EB;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x54);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5313, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5661, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x547C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC322, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0xD9EB, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED55() {
            cpu.Reset();
            cpu.r1.af = 0xB05B;
            cpu.r1.bc = 0x5E84;
            cpu.r1.de = 0xD6E9;
            cpu.r1.hl = 0xCB3E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0xD4B4;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x55);
            memory.Write8(0xD4B4, 0xEA);
            memory.Write8(0xD4B5, 0xC9);

            while (cpu.tStates < 14) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB05B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5E84, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD6E9, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCB3E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0xD4B6, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(14UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED56() {
            cpu.Reset();
            cpu.r1.af = 0x5CC0;
            cpu.r1.bc = 0x9100;
            cpu.r1.de = 0x356B;
            cpu.r1.hl = 0x4BFD;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x2C93;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x56);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5CC0, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9100, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x356B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4BFD, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x2C93, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED57() {
            cpu.Reset();
            cpu.r1.af = 0xBCFE;
            cpu.r1.bc = 0xDFC7;
            cpu.r1.de = 0xA621;
            cpu.r1.hl = 0x1022;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x1E;
            cpu.r = 0x17;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x57);

            while (cpu.tStates < 9) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1E08, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xDFC7, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA621, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1022, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0019, cpu.r, "R mismatch");
            Assert.AreEqual(0x001E, cpu.i, "I mismatch");
            Assert.AreEqual(9UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED58() {
            cpu.Reset();
            cpu.r1.af = 0xC9EE;
            cpu.r1.bc = 0x4091;
            cpu.r1.de = 0x9E46;
            cpu.r1.hl = 0x873A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x58);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC900, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4091, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9E40, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x873A, cpu.r1.hl, "HL mismatch");
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
        public void TestED59() {
            cpu.Reset();
            cpu.r1.af = 0x388A;
            cpu.r1.bc = 0xD512;
            cpu.r1.de = 0xECC5;
            cpu.r1.hl = 0x93AF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x59);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x388A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD512, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xECC5, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x93AF, cpu.r1.hl, "HL mismatch");
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
        public void TestED5A() {
            cpu.Reset();
            cpu.r1.af = 0xA41F;
            cpu.r1.bc = 0x751C;
            cpu.r1.de = 0x19CE;
            cpu.r1.hl = 0x0493;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x5A);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA408, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x751C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x19CE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1E62, cpu.r1.hl, "HL mismatch");
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
        public void TestED5B() {
            cpu.Reset();
            cpu.r1.af = 0x5DF1;
            cpu.r1.bc = 0x982E;
            cpu.r1.de = 0x002F;
            cpu.r1.hl = 0xADB9;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0xF398;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x5B);
            memory.Write8(0x0002, 0x04);
            memory.Write8(0x0003, 0x9F);
            memory.Write8(0x9F04, 0x84);
            memory.Write8(0x9F05, 0x4D);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5DF1, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x982E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4D84, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xADB9, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0xF398, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED5C() {
            cpu.Reset();
            cpu.r1.af = 0x11C3;
            cpu.r1.bc = 0xB86C;
            cpu.r1.de = 0x2042;
            cpu.r1.hl = 0xC958;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x93DC;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x5C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xEFBB, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB86C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2042, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC958, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x93DC, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED5D() {
            cpu.Reset();
            cpu.r1.af = 0x1152;
            cpu.r1.bc = 0x1D20;
            cpu.r1.de = 0x3F86;
            cpu.r1.hl = 0x64FC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5308;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x5D);
            memory.Write8(0x5308, 0x26);
            memory.Write8(0x5309, 0xE0);

            while (cpu.tStates < 14) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1152, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1D20, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3F86, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x64FC, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x530A, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(14UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED5E() {
            cpu.Reset();
            cpu.r1.af = 0x611A;
            cpu.r1.bc = 0xC8CF;
            cpu.r1.de = 0xF215;
            cpu.r1.hl = 0xD92B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x4D86;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x5E);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x611A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC8CF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF215, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD92B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x4D86, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED5F() {
            cpu.Reset();
            cpu.r1.af = 0x1BB5;
            cpu.r1.bc = 0xFC09;
            cpu.r1.de = 0x2DFA;
            cpu.r1.hl = 0xBAB9;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0xD7;
            cpu.r = 0xF3;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x5F);

            while (cpu.tStates < 9) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF5A1, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFC09, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2DFA, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xBAB9, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x00F5, cpu.r, "R mismatch");
            Assert.AreEqual(0x00D7, cpu.i, "I mismatch");
            Assert.AreEqual(9UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED60() {
            cpu.Reset();
            cpu.r1.af = 0x2C9C;
            cpu.r1.bc = 0x0DAE;
            cpu.r1.de = 0x621E;
            cpu.r1.hl = 0x2F66;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x60);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2C08, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0DAE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x621E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0D66, cpu.r1.hl, "HL mismatch");
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
        public void TestED61() {
            cpu.Reset();
            cpu.r1.af = 0xFFA8;
            cpu.r1.bc = 0x90CA;
            cpu.r1.de = 0x0340;
            cpu.r1.hl = 0xD847;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x61);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFFA8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x90CA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0340, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD847, cpu.r1.hl, "HL mismatch");
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
        public void TestED62() {
            cpu.Reset();
            cpu.r1.af = 0xA60B;
            cpu.r1.bc = 0xD9AA;
            cpu.r1.de = 0x6623;
            cpu.r1.hl = 0x0B1A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x62);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA6BB, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD9AA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6623, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xFFFF, cpu.r1.hl, "HL mismatch");
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
        public void TestED63() {
            cpu.Reset();
            cpu.r1.af = 0x5222;
            cpu.r1.bc = 0x88F9;
            cpu.r1.de = 0x9D9A;
            cpu.r1.hl = 0xE4D3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0xA2F0;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x63);
            memory.Write8(0x0002, 0x67);
            memory.Write8(0x0003, 0x65);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5222, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x88F9, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9D9A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE4D3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0xA2F0, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED64() {
            cpu.Reset();
            cpu.r1.af = 0x2127;
            cpu.r1.bc = 0xE425;
            cpu.r1.de = 0x66AC;
            cpu.r1.hl = 0xB2A3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x43F2;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x64);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDF9B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE425, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x66AC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB2A3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x43F2, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED65() {
            cpu.Reset();
            cpu.r1.af = 0x63D2;
            cpu.r1.bc = 0x1FA1;
            cpu.r1.de = 0x0788;
            cpu.r1.hl = 0x881C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0xF207;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x65);
            memory.Write8(0xF207, 0xEB);
            memory.Write8(0xF208, 0x0E);

            while (cpu.tStates < 14) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x63D2, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1FA1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0788, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x881C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0xF209, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(14UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED66() {
            cpu.Reset();
            cpu.r1.af = 0x4088;
            cpu.r1.bc = 0xA7E1;
            cpu.r1.de = 0x3FFD;
            cpu.r1.hl = 0x919B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0xD193;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x66);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4088, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA7E1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3FFD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x919B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0xD193, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED67() {
            cpu.Reset();
            cpu.r1.af = 0x3624;
            cpu.r1.bc = 0xB16A;
            cpu.r1.de = 0xA4DB;
            cpu.r1.hl = 0xB9DE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x67);
            memory.Write8(0xB9DE, 0x93);

            while (cpu.tStates < 18) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3324, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB16A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA4DB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB9DE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(18UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED68() {
            cpu.Reset();
            cpu.r1.af = 0x5316;
            cpu.r1.bc = 0x624B;
            cpu.r1.de = 0x7311;
            cpu.r1.hl = 0x3106;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x68);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5320, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x624B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7311, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3162, cpu.r1.hl, "HL mismatch");
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
        public void TestED69() {
            cpu.Reset();
            cpu.r1.af = 0xABD8;
            cpu.r1.bc = 0x8D2F;
            cpu.r1.de = 0x89C7;
            cpu.r1.hl = 0xC3D6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x69);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xABD8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8D2F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x89C7, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC3D6, cpu.r1.hl, "HL mismatch");
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
        public void TestED6A() {
            cpu.Reset();
            cpu.r1.af = 0xBB5A;
            cpu.r1.bc = 0x6FED;
            cpu.r1.de = 0x59BB;
            cpu.r1.hl = 0x4E40;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x6A);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xBB9C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6FED, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x59BB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9C80, cpu.r1.hl, "HL mismatch");
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
        public void TestED6B() {
            cpu.Reset();
            cpu.r1.af = 0x9E35;
            cpu.r1.bc = 0xD240;
            cpu.r1.de = 0x1998;
            cpu.r1.hl = 0xAB19;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x9275;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x6B);
            memory.Write8(0x0002, 0x98);
            memory.Write8(0x0003, 0x61);
            memory.Write8(0x6198, 0x3F);
            memory.Write8(0x6199, 0xBE);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9E35, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD240, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1998, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xBE3F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x9275, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED6C() {
            cpu.Reset();
            cpu.r1.af = 0x0FB1;
            cpu.r1.bc = 0x7D5B;
            cpu.r1.de = 0xCADB;
            cpu.r1.hl = 0x0893;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0xD983;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x6C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF1B3, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7D5B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xCADB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0893, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0xD983, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED6D() {
            cpu.Reset();
            cpu.r1.af = 0x3860;
            cpu.r1.bc = 0x42DA;
            cpu.r1.de = 0x5935;
            cpu.r1.hl = 0xDC10;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5CD3;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x6D);
            memory.Write8(0x5CD3, 0xA9);
            memory.Write8(0x5CD4, 0x73);

            while (cpu.tStates < 14) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3860, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x42DA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5935, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDC10, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5CD5, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(14UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED6E() {
            cpu.Reset();
            cpu.r1.af = 0x7752;
            cpu.r1.bc = 0xBEC3;
            cpu.r1.de = 0x0457;
            cpu.r1.hl = 0x8C95;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0xA787;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x6E);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7752, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBEC3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0457, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8C95, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0xA787, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED6F() {
            cpu.Reset();
            cpu.r1.af = 0x658B;
            cpu.r1.bc = 0x7A7A;
            cpu.r1.de = 0xECF0;
            cpu.r1.hl = 0x403C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x6F);
            memory.Write8(0x403C, 0xC4);

            while (cpu.tStates < 18) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6C2D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7A7A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xECF0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x403C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(18UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED70() {
            cpu.Reset();
            cpu.r1.af = 0xC6A1;
            cpu.r1.bc = 0xF7D6;
            cpu.r1.de = 0xA3CB;
            cpu.r1.hl = 0x288D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x70);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC6A1, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF7D6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA3CB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x288D, cpu.r1.hl, "HL mismatch");
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
        public void TestED71() {
            cpu.Reset();
            cpu.r1.af = 0xAFA0;
            cpu.r1.bc = 0x20B3;
            cpu.r1.de = 0x7B33;
            cpu.r1.hl = 0x4AC1;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x71);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAFA0, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x20B3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7B33, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4AC1, cpu.r1.hl, "HL mismatch");
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
        public void TestED72() {
            cpu.Reset();
            cpu.r1.af = 0x5FD9;
            cpu.r1.bc = 0x05CB;
            cpu.r1.de = 0x0C6C;
            cpu.r1.hl = 0xD18B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x53DB;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x72);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5F3E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x05CB, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0C6C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7DAF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x53DB, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED73() {
            cpu.Reset();
            cpu.r1.af = 0x41C4;
            cpu.r1.bc = 0x763A;
            cpu.r1.de = 0xECB0;
            cpu.r1.hl = 0xEE62;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0xAED5;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x73);
            memory.Write8(0x0002, 0x2A);
            memory.Write8(0x0003, 0x79);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x41C4, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x763A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xECB0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xEE62, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0xAED5, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED74() {
            cpu.Reset();
            cpu.r1.af = 0x4454;
            cpu.r1.bc = 0xF2D2;
            cpu.r1.de = 0x8340;
            cpu.r1.hl = 0x7E76;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0323;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x74);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xBCBB, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF2D2, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8340, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7E76, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0323, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED75() {
            cpu.Reset();
            cpu.r1.af = 0x7CA4;
            cpu.r1.bc = 0x1615;
            cpu.r1.de = 0x5D2A;
            cpu.r1.hl = 0xA95B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x7D00;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x75);
            memory.Write8(0x7D00, 0xFD);
            memory.Write8(0x7D01, 0x4F);

            while (cpu.tStates < 14) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7CA4, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1615, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5D2A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA95B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x7D02, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(14UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED76() {
            cpu.Reset();
            cpu.r1.af = 0xCABF;
            cpu.r1.bc = 0xFF9A;
            cpu.r1.de = 0xB98C;
            cpu.r1.hl = 0xA8E6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0xFE8E;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x76);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCABF, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFF9A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB98C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA8E6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0xFE8E, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED78() {
            cpu.Reset();
            cpu.r1.af = 0x58DD;
            cpu.r1.bc = 0xF206;
            cpu.r1.de = 0x2D6A;
            cpu.r1.hl = 0xAF16;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x78);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF2A1, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF206, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2D6A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAF16, cpu.r1.hl, "HL mismatch");
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
        public void TestED79() {
            cpu.Reset();
            cpu.r1.af = 0xE000;
            cpu.r1.bc = 0x4243;
            cpu.r1.de = 0x8F7F;
            cpu.r1.hl = 0xED90;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x79);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4243, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8F7F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xED90, cpu.r1.hl, "HL mismatch");
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
        public void TestED7A() {
            cpu.Reset();
            cpu.r1.af = 0x32FD;
            cpu.r1.bc = 0xD819;
            cpu.r1.de = 0xD873;
            cpu.r1.hl = 0x8DCF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5D22;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x7A);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x32B8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD819, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD873, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xEAF2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5D22, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED7B() {
            cpu.Reset();
            cpu.r1.af = 0x4F97;
            cpu.r1.bc = 0x24B7;
            cpu.r1.de = 0xE105;
            cpu.r1.hl = 0x1BF2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5E17;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x7B);
            memory.Write8(0x0002, 0x50);
            memory.Write8(0x0003, 0x8C);
            memory.Write8(0x8C50, 0xD8);
            memory.Write8(0x8C51, 0x48);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4F97, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x24B7, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE105, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1BF2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x48D8, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED7C() {
            cpu.Reset();
            cpu.r1.af = 0xD333;
            cpu.r1.bc = 0x29CA;
            cpu.r1.de = 0x9622;
            cpu.r1.hl = 0xB452;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0BE6;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x7C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2D3B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x29CA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9622, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB452, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0BE6, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED7D() {
            cpu.Reset();
            cpu.r1.af = 0xECB6;
            cpu.r1.bc = 0x073E;
            cpu.r1.de = 0xDC1E;
            cpu.r1.hl = 0x38D9;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x66F0;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x7D);
            memory.Write8(0x66F0, 0x4F);
            memory.Write8(0x66F1, 0xFB);

            while (cpu.tStates < 14) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xECB6, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x073E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDC1E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x38D9, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x66F2, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(14UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestED7E() {
            cpu.Reset();
            cpu.r1.af = 0xB246;
            cpu.r1.bc = 0x1A1A;
            cpu.r1.de = 0x933A;
            cpu.r1.hl = 0x4B8B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x2242;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0x7E);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB246, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1A1A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x933A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4B8B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x2242, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDA0() {
            cpu.Reset();
            cpu.r1.af = 0x1BC9;
            cpu.r1.bc = 0x3D11;
            cpu.r1.de = 0x95C1;
            cpu.r1.hl = 0xD097;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xA0);
            memory.Write8(0xD097, 0xB7);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1BE5, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3D10, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x95C2, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD098, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDA1() {
            cpu.Reset();
            cpu.r1.af = 0xECDB;
            cpu.r1.bc = 0x7666;
            cpu.r1.de = 0x537F;
            cpu.r1.hl = 0x3BC3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xA1);
            memory.Write8(0x3BC3, 0xB4);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xEC0F, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7665, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x537F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3BC4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDA2() {
            cpu.Reset();
            cpu.r1.af = 0x0121;
            cpu.r1.bc = 0x9A82;
            cpu.r1.de = 0x5BBD;
            cpu.r1.hl = 0x2666;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xA2);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x019F, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9982, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5BBD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2667, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDA2_01() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0200;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x8000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xA2);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0100, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8001, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDA2_02() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x569A;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x8000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xA2);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x559A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8001, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDA2_03() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0xABCC;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x8000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xA2);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x00BF, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAACC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8001, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDA3() {
            cpu.Reset();
            cpu.r1.af = 0x42C5;
            cpu.r1.bc = 0x6334;
            cpu.r1.de = 0x1E28;
            cpu.r1.hl = 0x32FA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xA3);
            memory.Write8(0x32FA, 0xB3);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4233, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6234, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1E28, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x32FB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDA3_01() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0100;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x01FF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xA3);
            memory.Write8(0x01FF, 0x00);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0044, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0200, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDA3_02() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0100;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0100;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xA3);
            memory.Write8(0x0100, 0x00);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0040, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0101, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDA3_03() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0100;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0107;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xA3);
            memory.Write8(0x0107, 0x00);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0044, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0108, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDA3_04() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0100;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x01FF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xA3);
            memory.Write8(0x01FF, 0x80);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0046, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0200, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDA3_05() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0100;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x01FD;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xA3);
            memory.Write8(0x01FD, 0x12);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0055, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x01FE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDA3_06() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0100;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x01FE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xA3);
            memory.Write8(0x01FE, 0x12);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0051, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x01FF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDA3_07() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0200;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x01FF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xA3);
            memory.Write8(0x01FF, 0x00);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0100, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0200, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDA3_08() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0800;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x01FE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xA3);
            memory.Write8(0x01FE, 0x00);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0004, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0700, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x01FF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDA3_09() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x8100;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x01FF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xA3);
            memory.Write8(0x01FF, 0x00);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0080, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0200, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDA3_10() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x8200;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x01FF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xA3);
            memory.Write8(0x01FF, 0x00);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0084, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8100, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0200, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDA3_11() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0xA900;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x01FF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xA3);
            memory.Write8(0x01FF, 0x00);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x00A8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA800, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0200, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDA8() {
            cpu.Reset();
            cpu.r1.af = 0x2A8E;
            cpu.r1.bc = 0x1607;
            cpu.r1.de = 0x5938;
            cpu.r1.hl = 0x12E8;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xA8);
            memory.Write8(0x12E8, 0xD8);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2AA4, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1606, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5937, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x12E7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDA9() {
            cpu.Reset();
            cpu.r1.af = 0x1495;
            cpu.r1.bc = 0xFB42;
            cpu.r1.de = 0x0466;
            cpu.r1.hl = 0x0DBE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xA9);
            memory.Write8(0x0DBE, 0x89);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x14BF, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFB41, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0466, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0DBD, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDAA() {
            cpu.Reset();
            cpu.r1.af = 0x2042;
            cpu.r1.bc = 0xD791;
            cpu.r1.de = 0xA912;
            cpu.r1.hl = 0xA533;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xAA);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2097, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD691, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA912, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA532, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDAA_01() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0101;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x8000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xAA);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0040, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0001, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7FFF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDAA_02() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x56AA;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x8000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xAA);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x55AA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7FFF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDAA_03() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0xABCC;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x8000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xAA);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x00BF, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAACC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7FFF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDAB() {
            cpu.Reset();
            cpu.r1.af = 0x0037;
            cpu.r1.bc = 0xF334;
            cpu.r1.de = 0xD3E1;
            cpu.r1.hl = 0x199F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xAB);
            memory.Write8(0x199F, 0x49);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x00A4, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF234, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD3E1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x199E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDAB_01() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x5800;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x007A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xAB);
            memory.Write8(0x007A, 0x7F);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5700, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0079, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDAB_02() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0xAB00;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x00F1;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xAB);
            memory.Write8(0x00F1, 0xCD);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x00BF, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAA00, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x00F0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDB0() {
            cpu.Reset();
            cpu.r1.af = 0x1045;
            cpu.r1.bc = 0x0010;
            cpu.r1.de = 0xAAD8;
            cpu.r1.hl = 0x558E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xB0);
            memory.Write8(0x558E, 0x53);
            memory.Write8(0x558F, 0x94);
            memory.Write8(0x5590, 0x30);
            memory.Write8(0x5591, 0x05);
            memory.Write8(0x5592, 0x44);
            memory.Write8(0x5593, 0x24);
            memory.Write8(0x5594, 0x22);
            memory.Write8(0x5595, 0xB9);
            memory.Write8(0x5596, 0xE9);
            memory.Write8(0x5597, 0x77);
            memory.Write8(0x5598, 0x23);
            memory.Write8(0x5599, 0x71);
            memory.Write8(0x559A, 0xE2);
            memory.Write8(0x559B, 0x5C);
            memory.Write8(0x559C, 0xFB);
            memory.Write8(0x559D, 0x49);

            while (cpu.tStates < 331) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1049, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xAAE8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x559E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0020, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(331UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDB1() {
            cpu.Reset();
            cpu.r1.af = 0xF4DD;
            cpu.r1.bc = 0x0008;
            cpu.r1.de = 0xE4E0;
            cpu.r1.hl = 0x9825;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xB1);
            memory.Write8(0x9825, 0x50);
            memory.Write8(0x9826, 0xE5);
            memory.Write8(0x9827, 0x41);
            memory.Write8(0x9828, 0xF4);
            memory.Write8(0x9829, 0x01);
            memory.Write8(0x982A, 0x9F);
            memory.Write8(0x982B, 0x11);
            memory.Write8(0x982C, 0x85);

            while (cpu.tStates < 79) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF447, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0004, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE4E0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9829, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0008, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(79UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDB2() {
            cpu.Reset();
            cpu.r1.af = 0x8A34;
            cpu.r1.bc = 0x0A40;
            cpu.r1.de = 0xD98C;
            cpu.r1.hl = 0x37CE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xB2);

            while (cpu.tStates < 205) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8A40, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0040, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD98C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x37D8, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0014, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(205UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDB3() {
            cpu.Reset();
            cpu.r1.af = 0x34AB;
            cpu.r1.bc = 0x03E0;
            cpu.r1.de = 0x41B9;
            cpu.r1.hl = 0x1D7C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xB3);
            memory.Write8(0x1D7C, 0x9D);
            memory.Write8(0x1D7D, 0x24);
            memory.Write8(0x1D7E, 0xAA);

            while (cpu.tStates < 58) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3453, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x00E0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x41B9, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1D7F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0006, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(58UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDB8() {
            cpu.Reset();
            cpu.r1.af = 0xE553;
            cpu.r1.bc = 0x0008;
            cpu.r1.de = 0x68E8;
            cpu.r1.hl = 0x4DCF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xB8);
            memory.Write8(0x4DC8, 0x29);
            memory.Write8(0x4DC9, 0x85);
            memory.Write8(0x4DCA, 0xA7);
            memory.Write8(0x4DCB, 0xC3);
            memory.Write8(0x4DCC, 0x55);
            memory.Write8(0x4DCD, 0x74);
            memory.Write8(0x4DCE, 0x23);
            memory.Write8(0x4DCF, 0x0A);

            while (cpu.tStates < 163) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE569, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x68E0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4DC7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0010, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(163UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDB9() {
            cpu.Reset();
            cpu.r1.af = 0xFFCD;
            cpu.r1.bc = 0x0008;
            cpu.r1.de = 0xA171;
            cpu.r1.hl = 0xC749;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xB9);
            memory.Write8(0xC742, 0xC6);
            memory.Write8(0xC743, 0x09);
            memory.Write8(0xC744, 0x85);
            memory.Write8(0xC745, 0xEC);
            memory.Write8(0xC746, 0x5A);
            memory.Write8(0xC747, 0x01);
            memory.Write8(0xC748, 0x4E);
            memory.Write8(0xC749, 0x6C);

            while (cpu.tStates < 163) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFF0B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA171, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC741, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0010, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(163UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDBA() {
            cpu.Reset();
            cpu.r1.af = 0x2567;
            cpu.r1.bc = 0x069F;
            cpu.r1.de = 0xD40D;
            cpu.r1.hl = 0x6B55;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xBA);

            while (cpu.tStates < 121) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2540, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x009F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD40D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6B4F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x000C, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(121UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEDBB() {
            cpu.Reset();
            cpu.r1.af = 0x09C4;
            cpu.r1.bc = 0x043B;
            cpu.r1.de = 0xBE49;
            cpu.r1.hl = 0x1DD0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xED);
            memory.Write8(0x0001, 0xBB);
            memory.Write8(0x1DCD, 0xF9);
            memory.Write8(0x1DCE, 0x71);
            memory.Write8(0x1DCF, 0xC5);
            memory.Write8(0x1DD0, 0xB6);

            while (cpu.tStates < 79) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0957, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x003B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xBE49, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1DCC, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0008, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(79UL, cpu.tStates, "tStates mismatch");
        }
    }
}