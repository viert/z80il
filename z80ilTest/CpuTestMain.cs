using Microsoft.VisualStudio.TestTools.UnitTesting;
using Z80;

namespace z80ilTest
{
    [TestClass]
    public class CpuTestMain
    {
        readonly Cpu cpu;
        SimpleMemory memory;

        public CpuTestMain() {
            memory = new SimpleMemory();
            cpu = new Cpu(memory);
        }

        [TestMethod]
        public void Test10() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0800;
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
            memory.Write8(0x0000, 0x00);
            memory.Write8(0x0001, 0x10);
            memory.Write8(0x0002, 0xFD);
            memory.Write8(0x0003, 0x0C);

            while (cpu.tStates < 135) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0001, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0011, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(135UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test11() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
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
            memory.Write8(0x0000, 0x11);
            memory.Write8(0x0001, 0x9A);
            memory.Write8(0x0002, 0xBC);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xBC9A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test12() {
            cpu.Reset();
            cpu.r1.af = 0x5600;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x8000;
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
            memory.Write8(0x0000, 0x12);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5600, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test13() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0xDEF0;
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
            memory.Write8(0x0000, 0x13);

            while (cpu.tStates < 6) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDEF1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(6UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test14() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x2700;
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
            memory.Write8(0x0000, 0x14);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0028, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2800, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test15() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x1000;
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
            memory.Write8(0x0000, 0x15);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x001A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0F00, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test16() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
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
            memory.Write8(0x0000, 0x16);
            memory.Write8(0x0001, 0x12);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1200, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test17() {
            cpu.Reset();
            cpu.r1.af = 0x0801;
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
            memory.Write8(0x0000, 0x17);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1100, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test18() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
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
            memory.Write8(0x0000, 0x18);
            memory.Write8(0x0001, 0x40);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(12UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test19() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x3456;
            cpu.r1.hl = 0x789A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x19);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0028, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3456, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xACF0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test21() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
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
            memory.Write8(0x0000, 0x21);
            memory.Write8(0x0001, 0x28);
            memory.Write8(0x0002, 0xED);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xED28, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test22() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0xC64C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x22);
            memory.Write8(0x0001, 0xB0);
            memory.Write8(0x0002, 0xC3);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC64C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test23() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x9C4E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x23);

            while (cpu.tStates < 6) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9C4F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(6UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test24() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x7200;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x24);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0020, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7300, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test25() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0xA500;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x25);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x00A2, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA400, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test26() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
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
            memory.Write8(0x0000, 0x26);
            memory.Write8(0x0001, 0x3A);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3A00, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test27() {
            cpu.Reset();
            cpu.r1.af = 0x1F00;
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
            memory.Write8(0x0000, 0x27);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2530, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test29() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0xCDFA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x29);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0019, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9BF4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test31() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
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
            memory.Write8(0x0000, 0x31);
            memory.Write8(0x0001, 0xD4);
            memory.Write8(0x0002, 0x61);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x61D4, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test32() {
            cpu.Reset();
            cpu.r1.af = 0x0E00;
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
            memory.Write8(0x0000, 0x32);
            memory.Write8(0x0001, 0xAC);
            memory.Write8(0x0002, 0xAD);

            while (cpu.tStates < 13) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0E00, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(13UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test33() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0xA55A;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x33);

            while (cpu.tStates < 6) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0xA55B, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(6UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test34() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0xFE1D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x34);
            memory.Write8(0xFE1D, 0xFD);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x00A8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xFE1D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test35() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x470C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x35);
            memory.Write8(0x470C, 0x82);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0082, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x470C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test36() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x7D29;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x36);
            memory.Write8(0x0001, 0x7C);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7D29, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test37() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
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
            memory.Write8(0x0000, 0x37);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0001, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test39() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x1AEF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0xC534;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x29);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0030, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x35DE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0xC534, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test40() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x40);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test41() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x41);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9898, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test42() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x42);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9098, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test43() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x43);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD898, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test44() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x44);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA198, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test45() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x45);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6998, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test46() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x46);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5098, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test47() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x47);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0298, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test48() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x48);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCFCF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test49() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x49);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test50() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x50);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xCFD8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test51() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x51);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x98D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test52() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x52);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test53() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x53);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD8D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test54() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x54);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA1D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test55() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x55);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x69D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test56() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x56);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x50D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test57() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x57);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x02D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test58() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x58);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90CF, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test59() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x59);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9098, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test60() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x60);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCF69, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test61() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x61);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9869, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test62() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x62);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9069, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test63() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x63);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD869, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test64() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x64);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test65() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x65);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6969, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test66() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x66);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5069, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test67() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x67);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0269, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test68() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x68);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA1CF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test69() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x69);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA198, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test70() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x70);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test71() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x71);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test72() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x72);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test73() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x73);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test74() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x74);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test75() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x75);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test76() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x76);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test77() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x77);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test78() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x78);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCF00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test79() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x79);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9800, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test80() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x80);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0411, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test81() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x81);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3031, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test82() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x82);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1501, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test83() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x83);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0211, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test84() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x84);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD191, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test85() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x85);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9B89, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test86() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x86);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3E29, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test87() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x87);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xEAA9, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test88() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x88);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0411, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test89() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x89);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3031, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test90() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x90);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE6B2, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test91() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x91);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xBABA, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test92() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x92);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD582, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test93() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x93);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE8BA, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test94() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x94);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x191A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test95() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x95);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4F1A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test96() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x96);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xACBA, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test97() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x97);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0042, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test98() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x98);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE6B2, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test99() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x99);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xBABA, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test00() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
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
            memory.Write8(0x0000, 0x00);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test01() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
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
            memory.Write8(0x0000, 0x01);
            memory.Write8(0x0001, 0x12);
            memory.Write8(0x0002, 0x34);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3412, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test02() {
            cpu.Reset();
            cpu.r1.af = 0x5600;
            cpu.r1.bc = 0x0001;
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
            memory.Write8(0x0000, 0x02);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5600, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0001, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test03() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x789A;
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
            memory.Write8(0x0000, 0x03);

            while (cpu.tStates < 6) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x789B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(6UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test04() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0xFF00;
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
            memory.Write8(0x0000, 0x04);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0050, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test05() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
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
            memory.Write8(0x0000, 0x05);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x00BA, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFF00, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test06() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
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
            memory.Write8(0x0000, 0x06);
            memory.Write8(0x0001, 0xBC);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBC00, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test07() {
            cpu.Reset();
            cpu.r1.af = 0x8800;
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
            memory.Write8(0x0000, 0x07);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1101, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test08() {
            cpu.Reset();
            cpu.r1.af = 0xDEF0;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x1234;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x08);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1234, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0xDEF0, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test09() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x5678;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x9ABC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x09);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0030, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5678, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF134, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test0A() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0001;
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
            memory.Write8(0x0000, 0x0A);
            memory.Write8(0x0001, 0xDE);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDE00, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0001, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test0B() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
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
            memory.Write8(0x0000, 0x0B);

            while (cpu.tStates < 6) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFFFF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(6UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test0C() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x007F;
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
            memory.Write8(0x0000, 0x0C);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0094, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0080, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test0D() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0080;
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
            memory.Write8(0x0000, 0x0D);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x003E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x007F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test0E() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
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
            memory.Write8(0x0000, 0x0E);
            memory.Write8(0x0001, 0xF0);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x00F0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test0F() {
            cpu.Reset();
            cpu.r1.af = 0x4100;
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
            memory.Write8(0x0000, 0x0F);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA021, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test1A() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x8000;
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
            memory.Write8(0x0000, 0x1A);
            memory.Write8(0x8000, 0x13);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1300, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test1B() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0xE5D4;
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
            memory.Write8(0x0000, 0x1B);

            while (cpu.tStates < 6) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE5D3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(6UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test1C() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x00AA;
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
            memory.Write8(0x0000, 0x1C);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x00A8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x00AB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test1D() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x00AA;
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
            memory.Write8(0x0000, 0x1D);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x00AA, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x00A9, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test1E() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
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
            memory.Write8(0x0000, 0x1E);
            memory.Write8(0x0001, 0xEF);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x00EF, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test1F() {
            cpu.Reset();
            cpu.r1.af = 0x01C4;
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
            memory.Write8(0x0000, 0x1F);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x00C5, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test20_1() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
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
            memory.Write8(0x0000, 0x20);
            memory.Write8(0x0001, 0x40);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(12UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test20_2() {
            cpu.Reset();
            cpu.r1.af = 0x0040;
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
            memory.Write8(0x0000, 0x20);
            memory.Write8(0x0001, 0x40);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0040, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test27_1() {
            cpu.Reset();
            cpu.r1.af = 0x9A02;
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
            memory.Write8(0x0000, 0x27);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3423, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test28_1() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
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
            memory.Write8(0x0000, 0x28);
            memory.Write8(0x0001, 0x8E);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test28_2() {
            cpu.Reset();
            cpu.r1.af = 0x0040;
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
            memory.Write8(0x0000, 0x28);
            memory.Write8(0x0001, 0x8E);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0040, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(12UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test2A() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
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
            memory.Write8(0x0000, 0x2A);
            memory.Write8(0x0001, 0x45);
            memory.Write8(0x0002, 0xAC);
            memory.Write8(0xAC45, 0xC4);
            memory.Write8(0xAC46, 0xDE);

            while (cpu.tStates < 16) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDEC4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test2B() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x9E66;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x2B);

            while (cpu.tStates < 6) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9E65, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(6UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test2C() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0026;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x2C);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0020, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0027, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test2D() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0032;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x2D);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0022, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0031, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test2E() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
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
            memory.Write8(0x0000, 0x2E);
            memory.Write8(0x0001, 0x18);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0018, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test2F() {
            cpu.Reset();
            cpu.r1.af = 0x8900;
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
            memory.Write8(0x0000, 0x2F);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7632, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test30_1() {
            cpu.Reset();
            cpu.r1.af = 0x0036;
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
            memory.Write8(0x0000, 0x30);
            memory.Write8(0x0001, 0x50);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0036, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(12UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test30_2() {
            cpu.Reset();
            cpu.r1.af = 0x0037;
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
            memory.Write8(0x0000, 0x30);
            memory.Write8(0x0001, 0x50);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0037, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test37_1() {
            cpu.Reset();
            cpu.r1.af = 0x00FF;
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
            memory.Write8(0x0000, 0x37);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x00C5, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test37_2() {
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
            memory.Write8(0x0000, 0x37);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFF29, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test37_3() {
            cpu.Reset();
            cpu.r1.af = 0xFFFF;
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
            memory.Write8(0x0000, 0x37);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFFED, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test38_1() {
            cpu.Reset();
            cpu.r1.af = 0x00B2;
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
            memory.Write8(0x0000, 0x38);
            memory.Write8(0x0001, 0x66);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x00B2, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test38_2() {
            cpu.Reset();
            cpu.r1.af = 0x00B3;
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
            memory.Write8(0x0000, 0x38);
            memory.Write8(0x0001, 0x66);

            while (cpu.tStates < 12) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x00B3, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(12UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test3A() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
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
            memory.Write8(0x0000, 0x3A);
            memory.Write8(0x0001, 0x52);
            memory.Write8(0x0002, 0x99);
            memory.Write8(0x9952, 0x28);

            while (cpu.tStates < 13) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2800, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(13UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test3B() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x9D36;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x3B);

            while (cpu.tStates < 6) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x9D35, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(6UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test3C() {
            cpu.Reset();
            cpu.r1.af = 0xCF00;
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
            memory.Write8(0x0000, 0x3C);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD090, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test3D() {
            cpu.Reset();
            cpu.r1.af = 0xEA00;
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
            memory.Write8(0x0000, 0x3D);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE9AA, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test3E() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
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
            memory.Write8(0x0000, 0x3E);
            memory.Write8(0x0001, 0xD6);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD600, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test3F() {
            cpu.Reset();
            cpu.r1.af = 0x005B;
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
            memory.Write8(0x0000, 0x3F);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0050, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test4A() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x4A);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF90, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test4B() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x4B);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCFD8, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test4C() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x4C);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCFA1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test4D() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x4D);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF69, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test4E() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x4E);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF50, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test4F() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x4F);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF02, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test5A() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x5A);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9090, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test5B() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x5B);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test5C() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x5C);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90A1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test5D() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x5D);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9069, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test5E() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x5E);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9050, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test5F() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x5F);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9002, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test6A() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x6A);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA190, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test6B() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x6B);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA1D8, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test6C() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x6C);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA1A1, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test6D() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x6D);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test6E() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x6E);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA150, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test6F() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x6F);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA102, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test7A() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x7A);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test7B() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x7B);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD800, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test7C() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x7C);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA100, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test7D() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x7D);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6900, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test7E() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x7E);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test7F() {
            cpu.Reset();
            cpu.r1.af = 0x0200;
            cpu.r1.bc = 0xCF98;
            cpu.r1.de = 0x90D8;
            cpu.r1.hl = 0xA169;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x7F);
            memory.Write8(0xA169, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xCF98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x90D8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA169, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test8A() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x8A);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1501, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test8B() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x8B);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0211, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test8C() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x8C);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD191, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test8D() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x8D);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9B89, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test8E() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x8E);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3E29, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test8F() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x8F);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xEAA9, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test9A() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x9A);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD582, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test9B() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x9B);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE8BA, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test9C() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x9C);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x191A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test9D() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x9D);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4F1A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test9E() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x9E);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xACBA, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void Test9F() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0x9F);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0042, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestA0() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xA0);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0514, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestA1() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xA1);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3130, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestA2() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xA2);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2030, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestA3() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xA3);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0514, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestA4() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xA4);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD494, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestA5() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xA5);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA4B0, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestA6() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xA6);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4114, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestA7() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xA7);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF5B4, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestA8() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xA8);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFAAC, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestA9() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xA9);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCE88, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestAA() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xAA);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD580, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestAB() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xAB);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF8A8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestAC() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xAC);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2928, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestAD() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xAD);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5304, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestAE() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xAE);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xBCA8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestAF() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xAF);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0044, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestB0() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xB0);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFFAC, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestB1() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xB1);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFFAC, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestB2() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xB2);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF5A4, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestB3() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xB3);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFDA8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestB4() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xB4);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFDA8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestB5() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xB5);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF7A0, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestB6() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xB6);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFDA8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestB7() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xB7);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF5A4, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestB8() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xB8);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF59A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestB9() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xB9);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF5BA, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestBA() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xBA);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF5A2, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestBB() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xBB);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF59A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestBC() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xBC);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF51A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestBD() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xBD);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF532, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestBE() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xBE);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF59A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestBF() {
            cpu.Reset();
            cpu.r1.af = 0xF500;
            cpu.r1.bc = 0x0F3B;
            cpu.r1.de = 0x200D;
            cpu.r1.hl = 0xDCA6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xBF);
            memory.Write8(0xDCA6, 0x49);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xF562, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F3B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x200D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDCA6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestC0_1() {
            cpu.Reset();
            cpu.r1.af = 0x0098;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x43F7;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xC0);
            memory.Write8(0x43F7, 0xE9);
            memory.Write8(0x43F8, 0xAF);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0098, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x43F9, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestC0_2() {
            cpu.Reset();
            cpu.r1.af = 0x00D8;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x43F7;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xC0);
            memory.Write8(0x43F7, 0xE9);
            memory.Write8(0x43F8, 0xAF);

            while (cpu.tStates < 5) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x00D8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x43F7, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(5UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestC1() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x4143;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xC1);
            memory.Write8(0x4143, 0xCE);
            memory.Write8(0x4144, 0xE8);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE8CE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x4145, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestC2_1() {
            cpu.Reset();
            cpu.r1.af = 0x0087;
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
            memory.Write8(0x0000, 0xC2);
            memory.Write8(0x0001, 0x1B);
            memory.Write8(0x0002, 0xE1);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0087, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestC2_2() {
            cpu.Reset();
            cpu.r1.af = 0x00C7;
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
            memory.Write8(0x0000, 0xC2);
            memory.Write8(0x0001, 0x1B);
            memory.Write8(0x0002, 0xE1);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x00C7, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestC3() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
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
            memory.Write8(0x0000, 0xC3);
            memory.Write8(0x0001, 0xED);
            memory.Write8(0x0002, 0x7C);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestC4_1() {
            cpu.Reset();
            cpu.r1.af = 0x000E;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5698;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xC4);
            memory.Write8(0x0001, 0x61);
            memory.Write8(0x0002, 0x9C);

            while (cpu.tStates < 17) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x000E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5696, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(17UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestC4_2() {
            cpu.Reset();
            cpu.r1.af = 0x004E;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5698;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xC4);
            memory.Write8(0x0001, 0x61);
            memory.Write8(0x0002, 0x9C);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x004E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5698, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestC5() {
            cpu.Reset();
            cpu.r1.af = 0x53E3;
            cpu.r1.bc = 0x1459;
            cpu.r1.de = 0x775F;
            cpu.r1.hl = 0x1A2F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0xEC12;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xC5);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x53E3, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1459, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x775F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1A2F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0xEC10, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestC6() {
            cpu.Reset();
            cpu.r1.af = 0xCA00;
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
            memory.Write8(0x0000, 0xC6);
            memory.Write8(0x0001, 0x6F);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3939, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestC7() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5507;
            cpu.pc = 0x6D33;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x6D33, 0xC7);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5505, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestC8_1() {
            cpu.Reset();
            cpu.r1.af = 0x0098;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x43F7;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xC8);
            memory.Write8(0x43F7, 0xE9);
            memory.Write8(0x43F8, 0xAF);

            while (cpu.tStates < 5) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0098, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x43F7, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(5UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestC8_2() {
            cpu.Reset();
            cpu.r1.af = 0x00D8;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x43F7;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xC8);
            memory.Write8(0x43F7, 0xE9);
            memory.Write8(0x43F8, 0xAF);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x00D8, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x43F9, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestC9() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x887E;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xC9);
            memory.Write8(0x887E, 0x36);
            memory.Write8(0x887F, 0x11);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x8880, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCA_1() {
            cpu.Reset();
            cpu.r1.af = 0x0087;
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
            memory.Write8(0x0000, 0xCA);
            memory.Write8(0x0001, 0x1B);
            memory.Write8(0x0002, 0xE1);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0087, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCA_2() {
            cpu.Reset();
            cpu.r1.af = 0x00C7;
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
            memory.Write8(0x0000, 0xCA);
            memory.Write8(0x0001, 0x1B);
            memory.Write8(0x0002, 0xE1);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x00C7, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCC_1() {
            cpu.Reset();
            cpu.r1.af = 0x004E;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5698;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCC);
            memory.Write8(0x0001, 0x61);
            memory.Write8(0x0002, 0x9C);

            while (cpu.tStates < 17) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x004E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5696, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(17UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCC_2() {
            cpu.Reset();
            cpu.r1.af = 0x000E;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5698;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCC);
            memory.Write8(0x0001, 0x61);
            memory.Write8(0x0002, 0x9C);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x000E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5698, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCD() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0xB07D;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xCD);
            memory.Write8(0x0001, 0x5D);
            memory.Write8(0x0002, 0x3A);

            while (cpu.tStates < 17) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0xB07B, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(17UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCE() {
            cpu.Reset();
            cpu.r1.af = 0x60F5;
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
            memory.Write8(0x0000, 0xCE);
            memory.Write8(0x0001, 0xB2);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1301, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestCF() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5507;
            cpu.pc = 0x6D33;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x6D33, 0xCF);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5505, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestD0_1() {
            cpu.Reset();
            cpu.r1.af = 0x0098;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x43F7;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xD0);
            memory.Write8(0x43F7, 0xE9);
            memory.Write8(0x43F8, 0xAF);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0098, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x43F9, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestD0_2() {
            cpu.Reset();
            cpu.r1.af = 0x0099;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x43F7;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xD0);
            memory.Write8(0x43F7, 0xE9);
            memory.Write8(0x43F8, 0xAF);

            while (cpu.tStates < 5) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0099, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x43F7, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(5UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestD1() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x4143;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xD1);
            memory.Write8(0x4143, 0xCE);
            memory.Write8(0x4144, 0xE8);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xE8CE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x4145, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestD2_1() {
            cpu.Reset();
            cpu.r1.af = 0x0086;
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
            memory.Write8(0x0000, 0xD2);
            memory.Write8(0x0001, 0x1B);
            memory.Write8(0x0002, 0xE1);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0086, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestD2_2() {
            cpu.Reset();
            cpu.r1.af = 0x0087;
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
            memory.Write8(0x0000, 0xD2);
            memory.Write8(0x0001, 0x1B);
            memory.Write8(0x0002, 0xE1);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0087, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestD3_1() {
            cpu.Reset();
            cpu.r1.af = 0xA200;
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
            memory.Write8(0x0000, 0xD3);
            memory.Write8(0x0001, 0xED);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA200, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestD3_2() {
            cpu.Reset();
            cpu.r1.af = 0x4200;
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
            memory.Write8(0x0000, 0xD3);
            memory.Write8(0x0001, 0xEC);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4200, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestD3_3() {
            cpu.Reset();
            cpu.r1.af = 0x4200;
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
            memory.Write8(0x0000, 0xD3);
            memory.Write8(0x0001, 0xED);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4200, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestD3() {
            cpu.Reset();
            cpu.r1.af = 0xA200;
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
            memory.Write8(0x0000, 0xD3);
            memory.Write8(0x0001, 0xEC);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA200, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestD4_1() {
            cpu.Reset();
            cpu.r1.af = 0x000E;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5698;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xD4);
            memory.Write8(0x0001, 0x61);
            memory.Write8(0x0002, 0x9C);

            while (cpu.tStates < 17) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x000E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5696, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(17UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestD4_2() {
            cpu.Reset();
            cpu.r1.af = 0x000F;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5698;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xD4);
            memory.Write8(0x0001, 0x61);
            memory.Write8(0x0002, 0x9C);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x000F, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5698, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestD5() {
            cpu.Reset();
            cpu.r1.af = 0x53E3;
            cpu.r1.bc = 0x1459;
            cpu.r1.de = 0x775F;
            cpu.r1.hl = 0x1A2F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0xEC12;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xD5);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x53E3, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1459, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x775F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1A2F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0xEC10, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestD6() {
            cpu.Reset();
            cpu.r1.af = 0x3900;
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
            memory.Write8(0x0000, 0xD6);
            memory.Write8(0x0001, 0xDF);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5A1B, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestD7() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5507;
            cpu.pc = 0x6D33;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x6D33, 0xD7);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5505, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestD8_1() {
            cpu.Reset();
            cpu.r1.af = 0x0098;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x43F7;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xD8);
            memory.Write8(0x43F7, 0xE9);
            memory.Write8(0x43F8, 0xAF);

            while (cpu.tStates < 5) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0098, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x43F7, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(5UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestD8_2() {
            cpu.Reset();
            cpu.r1.af = 0x0099;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x43F7;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xD8);
            memory.Write8(0x43F7, 0xE9);
            memory.Write8(0x43F8, 0xAF);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0099, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x43F9, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestD9() {
            cpu.Reset();
            cpu.r1.af = 0x4D94;
            cpu.r1.bc = 0xE07A;
            cpu.r1.de = 0xE35B;
            cpu.r1.hl = 0x9D64;
            cpu.r2.af = 0x1A64;
            cpu.r2.bc = 0xC930;
            cpu.r2.de = 0x3D01;
            cpu.r2.hl = 0x7D02;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xD9);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4D94, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xC930, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3D01, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7D02, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x1A64, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0xE07A, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0xE35B, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x9D64, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDA_1() {
            cpu.Reset();
            cpu.r1.af = 0x0087;
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
            memory.Write8(0x0000, 0xDA);
            memory.Write8(0x0001, 0x1B);
            memory.Write8(0x0002, 0xE1);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0087, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDA_2() {
            cpu.Reset();
            cpu.r1.af = 0x0086;
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
            memory.Write8(0x0000, 0xDA);
            memory.Write8(0x0001, 0x1B);
            memory.Write8(0x0002, 0xE1);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0086, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDB_1() {
            cpu.Reset();
            cpu.r1.af = 0xC100;
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
            memory.Write8(0x0000, 0xDB);
            memory.Write8(0x0001, 0xE3);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC100, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDB_2() {
            cpu.Reset();
            cpu.r1.af = 0x7100;
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
            memory.Write8(0x0000, 0xDB);
            memory.Write8(0x0001, 0xE2);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7100, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDB_3() {
            cpu.Reset();
            cpu.r1.af = 0x7100;
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
            memory.Write8(0x0000, 0xDB);
            memory.Write8(0x0001, 0xE3);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7100, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDB() {
            cpu.Reset();
            cpu.r1.af = 0xC100;
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
            memory.Write8(0x0000, 0xDB);
            memory.Write8(0x0001, 0xE2);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC100, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDC_1() {
            cpu.Reset();
            cpu.r1.af = 0x000F;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5698;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDC);
            memory.Write8(0x0001, 0x61);
            memory.Write8(0x0002, 0x9C);

            while (cpu.tStates < 17) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x000F, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5696, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(17UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDC_2() {
            cpu.Reset();
            cpu.r1.af = 0x000E;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5698;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDC);
            memory.Write8(0x0001, 0x61);
            memory.Write8(0x0002, 0x9C);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x000E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5698, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDE() {
            cpu.Reset();
            cpu.r1.af = 0xE78D;
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
            memory.Write8(0x0000, 0xDE);
            memory.Write8(0x0001, 0xA1);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4502, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDF() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5507;
            cpu.pc = 0x6D33;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x6D33, 0xDF);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5505, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestE0_1() {
            cpu.Reset();
            cpu.r1.af = 0x0098;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x43F7;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xE0);
            memory.Write8(0x43F7, 0xE9);
            memory.Write8(0x43F8, 0xAF);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0098, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x43F9, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestE0_2() {
            cpu.Reset();
            cpu.r1.af = 0x009C;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x43F7;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xE0);
            memory.Write8(0x43F7, 0xE9);
            memory.Write8(0x43F8, 0xAF);

            while (cpu.tStates < 5) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x009C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x43F7, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(5UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestE1() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x4143;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xE1);
            memory.Write8(0x4143, 0xCE);
            memory.Write8(0x4144, 0xE8);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE8CE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x4145, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestE2_1() {
            cpu.Reset();
            cpu.r1.af = 0x0083;
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
            memory.Write8(0x0000, 0xE2);
            memory.Write8(0x0001, 0x1B);
            memory.Write8(0x0002, 0xE1);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0083, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestE2_2() {
            cpu.Reset();
            cpu.r1.af = 0x0087;
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
            memory.Write8(0x0000, 0xE2);
            memory.Write8(0x0001, 0x1B);
            memory.Write8(0x0002, 0xE1);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0087, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestE3() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x4D22;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0373;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xE3);
            memory.Write8(0x0373, 0x8E);
            memory.Write8(0x0374, 0xE1);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE18E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0373, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestE4_1() {
            cpu.Reset();
            cpu.r1.af = 0x000A;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5698;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xE4);
            memory.Write8(0x0001, 0x61);
            memory.Write8(0x0002, 0x9C);

            while (cpu.tStates < 17) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x000A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5696, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(17UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestE4_2() {
            cpu.Reset();
            cpu.r1.af = 0x000E;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5698;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xE4);
            memory.Write8(0x0001, 0x61);
            memory.Write8(0x0002, 0x9C);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x000E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5698, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestE5() {
            cpu.Reset();
            cpu.r1.af = 0x53E3;
            cpu.r1.bc = 0x1459;
            cpu.r1.de = 0x775F;
            cpu.r1.hl = 0x1A2F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0xEC12;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xE5);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x53E3, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1459, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x775F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1A2F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0xEC10, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestE6() {
            cpu.Reset();
            cpu.r1.af = 0x7500;
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
            memory.Write8(0x0000, 0xE6);
            memory.Write8(0x0001, 0x49);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4114, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestE7() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5507;
            cpu.pc = 0x6D33;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x6D33, 0xE7);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5505, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestE8_1() {
            cpu.Reset();
            cpu.r1.af = 0x0098;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x43F7;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xE8);
            memory.Write8(0x43F7, 0xE9);
            memory.Write8(0x43F8, 0xAF);

            while (cpu.tStates < 5) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0098, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x43F7, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(5UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestE8_2() {
            cpu.Reset();
            cpu.r1.af = 0x009C;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x43F7;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xE8);
            memory.Write8(0x43F7, 0xE9);
            memory.Write8(0x43F8, 0xAF);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x009C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x43F9, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestE9() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0xCABA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xE9);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCABA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEA_1() {
            cpu.Reset();
            cpu.r1.af = 0x0087;
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
            memory.Write8(0x0000, 0xEA);
            memory.Write8(0x0001, 0x1B);
            memory.Write8(0x0002, 0xE1);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0087, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEA_2() {
            cpu.Reset();
            cpu.r1.af = 0x0083;
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
            memory.Write8(0x0000, 0xEA);
            memory.Write8(0x0001, 0x1B);
            memory.Write8(0x0002, 0xE1);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0083, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEB() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0xB879;
            cpu.r1.hl = 0x942E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xEB);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x942E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xB879, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEC_1() {
            cpu.Reset();
            cpu.r1.af = 0x000E;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5698;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xEC);
            memory.Write8(0x0001, 0x61);
            memory.Write8(0x0002, 0x9C);

            while (cpu.tStates < 17) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x000E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5696, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(17UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEC_2() {
            cpu.Reset();
            cpu.r1.af = 0x000A;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5698;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xEC);
            memory.Write8(0x0001, 0x61);
            memory.Write8(0x0002, 0x9C);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x000A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5698, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEE() {
            cpu.Reset();
            cpu.r1.af = 0x3E00;
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
            memory.Write8(0x0000, 0xEE);
            memory.Write8(0x0001, 0xD0);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xEEAC, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestEF() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5507;
            cpu.pc = 0x6D33;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x6D33, 0xEF);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5505, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestF0_1() {
            cpu.Reset();
            cpu.r1.af = 0x0018;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x43F7;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xF0);
            memory.Write8(0x43F7, 0xE9);
            memory.Write8(0x43F8, 0xAF);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0018, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x43F9, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestF0_2() {
            cpu.Reset();
            cpu.r1.af = 0x0098;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x43F7;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xF0);
            memory.Write8(0x43F7, 0xE9);
            memory.Write8(0x43F8, 0xAF);

            while (cpu.tStates < 5) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0098, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x43F7, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(5UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestF1() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x4143;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xF1);
            memory.Write8(0x4143, 0xCE);
            memory.Write8(0x4144, 0xE8);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE8CE, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x4145, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestF2_1() {
            cpu.Reset();
            cpu.r1.af = 0x0007;
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
            memory.Write8(0x0000, 0xF2);
            memory.Write8(0x0001, 0x1B);
            memory.Write8(0x0002, 0xE1);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0007, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestF2_2() {
            cpu.Reset();
            cpu.r1.af = 0x0087;
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
            memory.Write8(0x0000, 0xF2);
            memory.Write8(0x0001, 0x1B);
            memory.Write8(0x0002, 0xE1);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0087, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestF3() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
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
            memory.Write8(0x0000, 0xF3);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestF4_1() {
            cpu.Reset();
            cpu.r1.af = 0x000E;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5698;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xF4);
            memory.Write8(0x0001, 0x61);
            memory.Write8(0x0002, 0x9C);

            while (cpu.tStates < 17) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x000E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5696, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(17UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestF4_2() {
            cpu.Reset();
            cpu.r1.af = 0x008E;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5698;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xF4);
            memory.Write8(0x0001, 0x61);
            memory.Write8(0x0002, 0x9C);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x008E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5698, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestF5() {
            cpu.Reset();
            cpu.r1.af = 0x53E3;
            cpu.r1.bc = 0x1459;
            cpu.r1.de = 0x775F;
            cpu.r1.hl = 0x1A2F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0xEC12;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xF5);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x53E3, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1459, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x775F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1A2F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0xEC10, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestF6() {
            cpu.Reset();
            cpu.r1.af = 0x0600;
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
            memory.Write8(0x0000, 0xF6);
            memory.Write8(0x0001, 0xA7);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA7A0, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestF7() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5507;
            cpu.pc = 0x6D33;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x6D33, 0xF7);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5505, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestF8_1() {
            cpu.Reset();
            cpu.r1.af = 0x0018;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x43F7;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xF8);
            memory.Write8(0x43F7, 0xE9);
            memory.Write8(0x43F8, 0xAF);

            while (cpu.tStates < 5) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0018, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x43F7, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(5UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestF8_2() {
            cpu.Reset();
            cpu.r1.af = 0x0098;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x43F7;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xF8);
            memory.Write8(0x43F7, 0xE9);
            memory.Write8(0x43F8, 0xAF);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0098, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x43F9, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestF9() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0xCE32;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xF9);

            while (cpu.tStates < 6) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCE32, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0xCE32, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(6UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFA_1() {
            cpu.Reset();
            cpu.r1.af = 0x0087;
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
            memory.Write8(0x0000, 0xFA);
            memory.Write8(0x0001, 0x1B);
            memory.Write8(0x0002, 0xE1);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0087, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFA_2() {
            cpu.Reset();
            cpu.r1.af = 0x0007;
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
            memory.Write8(0x0000, 0xFA);
            memory.Write8(0x0001, 0x1B);
            memory.Write8(0x0002, 0xE1);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0007, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFB() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
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
            memory.Write8(0x0000, 0xFB);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(4UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFC_1() {
            cpu.Reset();
            cpu.r1.af = 0x008E;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5698;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFC);
            memory.Write8(0x0001, 0x61);
            memory.Write8(0x0002, 0x9C);

            while (cpu.tStates < 17) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x008E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5696, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(17UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFC_2() {
            cpu.Reset();
            cpu.r1.af = 0x000E;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5698;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xFC);
            memory.Write8(0x0001, 0x61);
            memory.Write8(0x0002, 0x9C);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x000E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5698, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFE() {
            cpu.Reset();
            cpu.r1.af = 0x6900;
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
            memory.Write8(0x0000, 0xFE);
            memory.Write8(0x0001, 0x82);

            while (cpu.tStates < 7) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6987, cpu.r1.af, "AF mismatch");
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
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(7UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestFF() {
            cpu.Reset();
            cpu.r1.af = 0x0000;
            cpu.r1.bc = 0x0000;
            cpu.r1.de = 0x0000;
            cpu.r1.hl = 0x0000;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0000;
            cpu.r1.iy = 0x0000;
            cpu.r1.sp = 0x5507;
            cpu.pc = 0x6D33;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x6D33, 0xFF);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0000, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0000, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0000, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0000, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0000, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5505, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0001, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }
    }
}