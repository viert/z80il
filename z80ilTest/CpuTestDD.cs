using Microsoft.VisualStudio.TestTools.UnitTesting;
using Z80;

namespace z80ilTest
{
    [TestClass]
    public class CpuTestDD
    {
        readonly Cpu cpu;
        SimpleMemory memory;
        FakePort port;

        public CpuTestDD() {
            memory = new SimpleMemory();
            port = new FakePort();
            cpu = new Cpu(memory, port);
        }

        [TestMethod]
        public void TestDD00() {
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
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x00);
            memory.Write8(0x0002, 0x00);

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
            Assert.AreEqual(0x0003, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(12UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD09() {
            cpu.Reset();
            cpu.r1.af = 0x0D05;
            cpu.r1.bc = 0x1426;
            cpu.r1.de = 0x53CE;
            cpu.r1.hl = 0x41E3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9EC0;
            cpu.r1.iy = 0x5C89;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x09);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0D34, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1426, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x53CE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x41E3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB2E6, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5C89, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD19() {
            cpu.Reset();
            cpu.r1.af = 0x1911;
            cpu.r1.bc = 0x0E0B;
            cpu.r1.de = 0x2724;
            cpu.r1.hl = 0xBE62;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x824F;
            cpu.r1.iy = 0x760B;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x19);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x1928, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0E0B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2724, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xBE62, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xA973, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x760B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD21() {
            cpu.Reset();
            cpu.r1.af = 0xC935;
            cpu.r1.bc = 0x4353;
            cpu.r1.de = 0xBD22;
            cpu.r1.hl = 0x94D5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xDADE;
            cpu.r1.iy = 0xAAD6;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x21);
            memory.Write8(0x0002, 0xF2);
            memory.Write8(0x0003, 0x7C);

            while (cpu.tStates < 14) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC935, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4353, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xBD22, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x94D5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7CF2, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xAAD6, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(14UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD22() {
            cpu.Reset();
            cpu.r1.af = 0x5B1D;
            cpu.r1.bc = 0x45A1;
            cpu.r1.de = 0x6DE8;
            cpu.r1.hl = 0x39D3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xEBE7;
            cpu.r1.iy = 0x05B0;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x22);
            memory.Write8(0x0002, 0x4F);
            memory.Write8(0x0003, 0xAD);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5B1D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x45A1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6DE8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x39D3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xEBE7, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x05B0, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD23() {
            cpu.Reset();
            cpu.r1.af = 0x9095;
            cpu.r1.bc = 0xAC3C;
            cpu.r1.de = 0x4D90;
            cpu.r1.hl = 0x379B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xD50B;
            cpu.r1.iy = 0xA157;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x23);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9095, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAC3C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4D90, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x379B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xD50C, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA157, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD24() {
            cpu.Reset();
            cpu.r1.af = 0x0698;
            cpu.r1.bc = 0xDCD0;
            cpu.r1.de = 0xA31B;
            cpu.r1.hl = 0xD527;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x8CDA;
            cpu.r1.iy = 0xB096;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x24);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0688, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xDCD0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA31B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD527, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x8DDA, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB096, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD25() {
            cpu.Reset();
            cpu.r1.af = 0x5ACC;
            cpu.r1.bc = 0x206B;
            cpu.r1.de = 0xED10;
            cpu.r1.hl = 0x6EAB;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xBB3C;
            cpu.r1.iy = 0x5EBD;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x25);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5AAA, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x206B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xED10, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x6EAB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xBA3C, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5EBD, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD26() {
            cpu.Reset();
            cpu.r1.af = 0x9522;
            cpu.r1.bc = 0xEDE0;
            cpu.r1.de = 0xA352;
            cpu.r1.hl = 0xADEA;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5F40;
            cpu.r1.iy = 0x82E1;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x26);
            memory.Write8(0x0002, 0xAD);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9522, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xEDE0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA352, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xADEA, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xAD40, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x82E1, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD29() {
            cpu.Reset();
            cpu.r1.af = 0xAC80;
            cpu.r1.bc = 0x0F0E;
            cpu.r1.de = 0x72C8;
            cpu.r1.hl = 0x1F2A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5195;
            cpu.r1.iy = 0x7D8A;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x29);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xACA0, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0F0E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x72C8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1F2A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xA32A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7D8A, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD2A() {
            cpu.Reset();
            cpu.r1.af = 0x3D36;
            cpu.r1.bc = 0xB24E;
            cpu.r1.de = 0xBDBC;
            cpu.r1.hl = 0xCA4E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xBA65;
            cpu.r1.iy = 0xE7CE;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x2A);
            memory.Write8(0x0002, 0xBC);
            memory.Write8(0x0003, 0x40);
            memory.Write8(0x40BC, 0xB5);
            memory.Write8(0x40BD, 0x30);

            while (cpu.tStates < 20) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3D36, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB24E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xBDBC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCA4E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x30B5, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE7CE, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(20UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD2B() {
            cpu.Reset();
            cpu.r1.af = 0xAD4B;
            cpu.r1.bc = 0xD5E6;
            cpu.r1.de = 0x9377;
            cpu.r1.hl = 0xF132;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7A17;
            cpu.r1.iy = 0x2188;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x2B);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAD4B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD5E6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x9377, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF132, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7A16, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x2188, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD2C() {
            cpu.Reset();
            cpu.r1.af = 0x8838;
            cpu.r1.bc = 0xF2F3;
            cpu.r1.de = 0xD277;
            cpu.r1.hl = 0x9153;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC62F;
            cpu.r1.iy = 0xB002;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x2C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8830, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF2F3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD277, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9153, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC630, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB002, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD2D() {
            cpu.Reset();
            cpu.r1.af = 0x39BC;
            cpu.r1.bc = 0xB23C;
            cpu.r1.de = 0x6E11;
            cpu.r1.hl = 0x5A49;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0267;
            cpu.r1.iy = 0xAB03;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x2D);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3922, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB23C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6E11, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5A49, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0266, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xAB03, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD2E() {
            cpu.Reset();
            cpu.r1.af = 0x9ACA;
            cpu.r1.bc = 0xA04A;
            cpu.r1.de = 0xB49F;
            cpu.r1.hl = 0xA4A6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xBD90;
            cpu.r1.iy = 0x38A1;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x2E);
            memory.Write8(0x0002, 0x1C);

            while (cpu.tStates < 11) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9ACA, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA04A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB49F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA4A6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xBD1C, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x38A1, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(11UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD34() {
            cpu.Reset();
            cpu.r1.af = 0x8304;
            cpu.r1.bc = 0xD1FC;
            cpu.r1.de = 0xB80B;
            cpu.r1.hl = 0x8082;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xDEA9;
            cpu.r1.iy = 0x6FD8;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x34);
            memory.Write8(0x0002, 0xE6);
            memory.Write8(0xDE8F, 0x57);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8308, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD1FC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB80B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8082, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xDEA9, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x6FD8, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD35() {
            cpu.Reset();
            cpu.r1.af = 0x8681;
            cpu.r1.bc = 0x4641;
            cpu.r1.de = 0x1EF6;
            cpu.r1.hl = 0x10AB;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC733;
            cpu.r1.iy = 0x8EC4;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x35);
            memory.Write8(0x0002, 0x60);
            memory.Write8(0xC793, 0xF7);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x86A3, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x4641, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x1EF6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x10AB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC733, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8EC4, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD36() {
            cpu.Reset();
            cpu.r1.af = 0x76DC;
            cpu.r1.bc = 0x2530;
            cpu.r1.de = 0x5158;
            cpu.r1.hl = 0x877D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB5C6;
            cpu.r1.iy = 0x8D3C;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x36);
            memory.Write8(0x0002, 0x35);
            memory.Write8(0x0003, 0xB5);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x76DC, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2530, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5158, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x877D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB5C6, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8D3C, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD39() {
            cpu.Reset();
            cpu.r1.af = 0x875B;
            cpu.r1.bc = 0xA334;
            cpu.r1.de = 0xD79D;
            cpu.r1.hl = 0x59E4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB11A;
            cpu.r1.iy = 0x4C88;
            cpu.r1.sp = 0xFA4A;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x39);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8769, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA334, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD79D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x59E4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xAB64, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4C88, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0xFA4A, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD44() {
            cpu.Reset();
            cpu.r1.af = 0xB37E;
            cpu.r1.bc = 0xCBB0;
            cpu.r1.de = 0x36E8;
            cpu.r1.hl = 0x3F45;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x2702;
            cpu.r1.iy = 0xB3B9;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x44);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xB37E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x27B0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x36E8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3F45, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x2702, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB3B9, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD45() {
            cpu.Reset();
            cpu.r1.af = 0x4E10;
            cpu.r1.bc = 0x5C6D;
            cpu.r1.de = 0xD11D;
            cpu.r1.hl = 0x1736;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7298;
            cpu.r1.iy = 0x2D10;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x45);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4E10, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x986D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD11D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1736, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7298, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x2D10, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD46() {
            cpu.Reset();
            cpu.r1.af = 0xC758;
            cpu.r1.bc = 0xBF29;
            cpu.r1.de = 0x66F2;
            cpu.r1.hl = 0x29EF;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5CC7;
            cpu.r1.iy = 0x407D;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x46);
            memory.Write8(0x0002, 0x68);
            memory.Write8(0x5D2F, 0x8D);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC758, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8D29, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x66F2, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x29EF, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5CC7, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x407D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD4C() {
            cpu.Reset();
            cpu.r1.af = 0xE15C;
            cpu.r1.bc = 0x75EC;
            cpu.r1.de = 0x7531;
            cpu.r1.hl = 0xAE9E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x3ED8;
            cpu.r1.iy = 0x03B7;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x4C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE15C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x753E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7531, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xAE9E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x3ED8, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x03B7, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD4D() {
            cpu.Reset();
            cpu.r1.af = 0x469E;
            cpu.r1.bc = 0x7864;
            cpu.r1.de = 0x6A5A;
            cpu.r1.hl = 0x00E2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xA1AA;
            cpu.r1.iy = 0x0D6F;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x4D);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x469E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x78AA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6A5A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x00E2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xA1AA, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0D6F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD4E() {
            cpu.Reset();
            cpu.r1.af = 0x7BF7;
            cpu.r1.bc = 0x6605;
            cpu.r1.de = 0x8D55;
            cpu.r1.hl = 0xDEF2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xD94B;
            cpu.r1.iy = 0x17FB;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x4E);
            memory.Write8(0x0002, 0x2E);
            memory.Write8(0xD979, 0x76);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7BF7, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6676, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8D55, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDEF2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xD94B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x17FB, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD54() {
            cpu.Reset();
            cpu.r1.af = 0x8376;
            cpu.r1.bc = 0x0D13;
            cpu.r1.de = 0xC767;
            cpu.r1.hl = 0x3119;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x4B6D;
            cpu.r1.iy = 0x030B;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x54);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8376, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0D13, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4B67, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3119, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x4B6D, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x030B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD55() {
            cpu.Reset();
            cpu.r1.af = 0xFF78;
            cpu.r1.bc = 0x85E3;
            cpu.r1.de = 0x566B;
            cpu.r1.hl = 0x8F3A;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xD7D7;
            cpu.r1.iy = 0x4E0B;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x55);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xFF78, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x85E3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD76B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8F3A, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xD7D7, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4E0B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD56() {
            cpu.Reset();
            cpu.r1.af = 0x97B3;
            cpu.r1.bc = 0xB617;
            cpu.r1.de = 0xBB50;
            cpu.r1.hl = 0x81D1;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xA306;
            cpu.r1.iy = 0x7A49;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x56);
            memory.Write8(0x0002, 0xF4);
            memory.Write8(0xA2FA, 0xDE);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x97B3, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB617, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDE50, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x81D1, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xA306, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7A49, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD5C() {
            cpu.Reset();
            cpu.r1.af = 0xAF82;
            cpu.r1.bc = 0x24BF;
            cpu.r1.de = 0x2793;
            cpu.r1.hl = 0xF925;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xF9A3;
            cpu.r1.iy = 0x0B82;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x5C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAF82, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x24BF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x27F9, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF925, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xF9A3, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0B82, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD5D() {
            cpu.Reset();
            cpu.r1.af = 0x36CB;
            cpu.r1.bc = 0x97A9;
            cpu.r1.de = 0x400D;
            cpu.r1.hl = 0x30FE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x3340;
            cpu.r1.iy = 0xB3ED;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x5D);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x36CB, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x97A9, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4040, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x30FE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x3340, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB3ED, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD5E() {
            cpu.Reset();
            cpu.r1.af = 0xA220;
            cpu.r1.bc = 0x389D;
            cpu.r1.de = 0x2FF8;
            cpu.r1.hl = 0x368C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x8D32;
            cpu.r1.iy = 0x3512;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x5E);
            memory.Write8(0x0002, 0x8F);
            memory.Write8(0x8CC1, 0xCE);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA220, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x389D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2FCE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x368C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x8D32, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x3512, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD60() {
            cpu.Reset();
            cpu.r1.af = 0x2392;
            cpu.r1.bc = 0x7F6A;
            cpu.r1.de = 0x3DC0;
            cpu.r1.hl = 0xCEFB;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x44A0;
            cpu.r1.iy = 0xC424;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x60);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2392, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7F6A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3DC0, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCEFB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7FA0, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC424, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD61() {
            cpu.Reset();
            cpu.r1.af = 0x76ED;
            cpu.r1.bc = 0x268C;
            cpu.r1.de = 0xD5C8;
            cpu.r1.hl = 0xBAB0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB650;
            cpu.r1.iy = 0x0A93;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x61);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x76ED, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x268C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD5C8, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xBAB0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x8C50, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0A93, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD62() {
            cpu.Reset();
            cpu.r1.af = 0x4C6F;
            cpu.r1.bc = 0xB482;
            cpu.r1.de = 0xFEF4;
            cpu.r1.hl = 0x62E7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6E25;
            cpu.r1.iy = 0x9655;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x62);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4C6F, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB482, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xFEF4, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x62E7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xFE25, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x9655, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD63() {
            cpu.Reset();
            cpu.r1.af = 0x6E9A;
            cpu.r1.bc = 0x5499;
            cpu.r1.de = 0x3C8F;
            cpu.r1.hl = 0x1F64;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xBF35;
            cpu.r1.iy = 0x0DF7;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x63);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6E9A, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x5499, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3C8F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x1F64, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x8F35, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0DF7, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD64() {
            cpu.Reset();
            cpu.r1.af = 0x47F6;
            cpu.r1.bc = 0x1B7A;
            cpu.r1.de = 0xA55E;
            cpu.r1.hl = 0x2FC2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xEFC7;
            cpu.r1.iy = 0xACA0;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x64);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x47F6, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1B7A, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA55E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2FC2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xEFC7, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xACA0, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD65() {
            cpu.Reset();
            cpu.r1.af = 0xD786;
            cpu.r1.bc = 0x7D1D;
            cpu.r1.de = 0xB659;
            cpu.r1.hl = 0x77E8;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x58FA;
            cpu.r1.iy = 0x006D;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x65);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD786, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7D1D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB659, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x77E8, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xFAFA, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x006D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD66() {
            cpu.Reset();
            cpu.r1.af = 0x84C2;
            cpu.r1.bc = 0x79B1;
            cpu.r1.de = 0xCA4A;
            cpu.r1.hl = 0xAAA0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xCE5D;
            cpu.r1.iy = 0xDD2D;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x66);
            memory.Write8(0x0002, 0xB5);
            memory.Write8(0xCE12, 0x03);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x84C2, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x79B1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xCA4A, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x03A0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xCE5D, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xDD2D, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD67() {
            cpu.Reset();
            cpu.r1.af = 0x967C;
            cpu.r1.bc = 0x511E;
            cpu.r1.de = 0x336D;
            cpu.r1.hl = 0x40F6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x66E7;
            cpu.r1.iy = 0x5BE2;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x67);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x967C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x511E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x336D, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x40F6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x96E7, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5BE2, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD68() {
            cpu.Reset();
            cpu.r1.af = 0x4A9D;
            cpu.r1.bc = 0xEFA8;
            cpu.r1.de = 0xFEBD;
            cpu.r1.hl = 0x07E4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5FD8;
            cpu.r1.iy = 0xB23F;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x68);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4A9D, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xEFA8, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xFEBD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x07E4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5FEF, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB23F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD69() {
            cpu.Reset();
            cpu.r1.af = 0x6466;
            cpu.r1.bc = 0x2142;
            cpu.r1.de = 0x2523;
            cpu.r1.hl = 0x82B3;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x6479;
            cpu.r1.iy = 0x04A7;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x69);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6466, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2142, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2523, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x82B3, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x6442, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x04A7, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD6A() {
            cpu.Reset();
            cpu.r1.af = 0x401F;
            cpu.r1.bc = 0x61F1;
            cpu.r1.de = 0x4B08;
            cpu.r1.hl = 0xFA88;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC37F;
            cpu.r1.iy = 0xD8F6;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x6A);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x401F, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x61F1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4B08, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xFA88, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC34B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD8F6, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD6B() {
            cpu.Reset();
            cpu.r1.af = 0x6DC7;
            cpu.r1.bc = 0xE2AE;
            cpu.r1.de = 0x40BD;
            cpu.r1.hl = 0xF3C0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x2290;
            cpu.r1.iy = 0x2749;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x6B);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6DC7, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE2AE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x40BD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF3C0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x22BD, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x2749, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD6C() {
            cpu.Reset();
            cpu.r1.af = 0x3939;
            cpu.r1.bc = 0x90DA;
            cpu.r1.de = 0x62DC;
            cpu.r1.hl = 0x7C31;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x412F;
            cpu.r1.iy = 0x7211;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x6C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3939, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x90DA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x62DC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x7C31, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x4141, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7211, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD6D() {
            cpu.Reset();
            cpu.r1.af = 0x3964;
            cpu.r1.bc = 0xFF3F;
            cpu.r1.de = 0x23D4;
            cpu.r1.hl = 0xC7C7;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9B70;
            cpu.r1.iy = 0x20C6;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x6D);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x3964, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFF3F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x23D4, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xC7C7, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9B70, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x20C6, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD6E() {
            cpu.Reset();
            cpu.r1.af = 0x223F;
            cpu.r1.bc = 0xF661;
            cpu.r1.de = 0xB61C;
            cpu.r1.hl = 0x0F53;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC648;
            cpu.r1.iy = 0xFAE8;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x6E);
            memory.Write8(0x0002, 0x2C);
            memory.Write8(0xC674, 0x6B);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x223F, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF661, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB61C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0F6B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC648, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xFAE8, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD6F() {
            cpu.Reset();
            cpu.r1.af = 0x6E84;
            cpu.r1.bc = 0x9CD4;
            cpu.r1.de = 0xA293;
            cpu.r1.hl = 0x647D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0D0B;
            cpu.r1.iy = 0x4A56;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x6F);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x6E84, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9CD4, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA293, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x647D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0D6E, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4A56, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD70() {
            cpu.Reset();
            cpu.r1.af = 0xD09F;
            cpu.r1.bc = 0xFE00;
            cpu.r1.de = 0x231E;
            cpu.r1.hl = 0x31EC;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x05FA;
            cpu.r1.iy = 0xEA92;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x70);
            memory.Write8(0x0002, 0xF6);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD09F, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFE00, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x231E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x31EC, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x05FA, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xEA92, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD71() {
            cpu.Reset();
            cpu.r1.af = 0xEBEE;
            cpu.r1.bc = 0x151C;
            cpu.r1.de = 0x05C7;
            cpu.r1.hl = 0xEE08;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x3722;
            cpu.r1.iy = 0x2EC6;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x71);
            memory.Write8(0x0002, 0x23);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xEBEE, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x151C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x05C7, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xEE08, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x3722, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x2EC6, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD72() {
            cpu.Reset();
            cpu.r1.af = 0x80C9;
            cpu.r1.bc = 0xAC1E;
            cpu.r1.de = 0x63BD;
            cpu.r1.hl = 0x828B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x8DFF;
            cpu.r1.iy = 0x94EF;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x72);
            memory.Write8(0x0002, 0x93);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x80C9, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAC1E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x63BD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x828B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x8DFF, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x94EF, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD73() {
            cpu.Reset();
            cpu.r1.af = 0x8F3E;
            cpu.r1.bc = 0xB5A3;
            cpu.r1.de = 0x07DE;
            cpu.r1.hl = 0x0B0C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x79C6;
            cpu.r1.iy = 0xAE79;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x73);
            memory.Write8(0x0002, 0x57);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8F3E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB5A3, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x07DE, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0B0C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x79C6, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xAE79, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD74() {
            cpu.Reset();
            cpu.r1.af = 0x4AE0;
            cpu.r1.bc = 0x49C5;
            cpu.r1.de = 0x3DEB;
            cpu.r1.hl = 0x0125;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5910;
            cpu.r1.iy = 0x429A;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x74);
            memory.Write8(0x0002, 0xB9);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4AE0, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x49C5, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x3DEB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0125, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x5910, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x429A, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD75() {
            cpu.Reset();
            cpu.r1.af = 0x5772;
            cpu.r1.bc = 0xE833;
            cpu.r1.de = 0xB63E;
            cpu.r1.hl = 0x734F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xAE4C;
            cpu.r1.iy = 0xE8C2;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x75);
            memory.Write8(0x0002, 0x30);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5772, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xE833, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB63E, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x734F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xAE4C, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE8C2, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD77() {
            cpu.Reset();
            cpu.r1.af = 0xDC56;
            cpu.r1.bc = 0xD893;
            cpu.r1.de = 0x4116;
            cpu.r1.hl = 0xF2D2;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xA181;
            cpu.r1.iy = 0x3157;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x77);
            memory.Write8(0x0002, 0x8C);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDC56, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD893, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4116, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF2D2, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xA181, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x3157, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD7C() {
            cpu.Reset();
            cpu.r1.af = 0x7558;
            cpu.r1.bc = 0x7705;
            cpu.r1.de = 0xAC92;
            cpu.r1.hl = 0xA6A1;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x8CDE;
            cpu.r1.iy = 0x7507;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x7C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8C58, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x7705, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xAC92, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xA6A1, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x8CDE, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7507, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD7D() {
            cpu.Reset();
            cpu.r1.af = 0x6C18;
            cpu.r1.bc = 0x93FB;
            cpu.r1.de = 0x6BDD;
            cpu.r1.hl = 0x3A10;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xD7CB;
            cpu.r1.iy = 0xC0F6;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x7D);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCB18, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x93FB, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6BDD, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3A10, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xD7CB, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xC0F6, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD7E() {
            cpu.Reset();
            cpu.r1.af = 0x6A66;
            cpu.r1.bc = 0x1F77;
            cpu.r1.de = 0x6220;
            cpu.r1.hl = 0x0C40;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x1CF4;
            cpu.r1.iy = 0x1A1F;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x7E);
            memory.Write8(0x0002, 0xBC);
            memory.Write8(0x1CB0, 0x57);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5766, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1F77, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6220, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0C40, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x1CF4, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1A1F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD84() {
            cpu.Reset();
            cpu.r1.af = 0x2E47;
            cpu.r1.bc = 0x1DE8;
            cpu.r1.de = 0xB8B9;
            cpu.r1.hl = 0x78A6;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9F1D;
            cpu.r1.iy = 0xB11F;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x84);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCD98, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1DE8, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB8B9, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x78A6, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9F1D, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB11F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD85() {
            cpu.Reset();
            cpu.r1.af = 0xB27A;
            cpu.r1.bc = 0xB1FF;
            cpu.r1.de = 0x8D7B;
            cpu.r1.hl = 0x40C0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB513;
            cpu.r1.iy = 0x0688;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x85);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC580, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xB1FF, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x8D7B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x40C0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB513, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x0688, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD86() {
            cpu.Reset();
            cpu.r1.af = 0x4EFA;
            cpu.r1.bc = 0xD085;
            cpu.r1.de = 0x5BAC;
            cpu.r1.hl = 0xE364;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB5B5;
            cpu.r1.iy = 0xFE3A;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x86);
            memory.Write8(0x0002, 0xC1);
            memory.Write8(0xB576, 0x5B);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xA9BC, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xD085, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5BAC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE364, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB5B5, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xFE3A, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD8C() {
            cpu.Reset();
            cpu.r1.af = 0xBC63;
            cpu.r1.bc = 0x8FDC;
            cpu.r1.de = 0xEA8F;
            cpu.r1.hl = 0x9734;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0EB3;
            cpu.r1.iy = 0x1B54;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x8C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xCB98, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x8FDC, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xEA8F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9734, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0EB3, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1B54, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD8D() {
            cpu.Reset();
            cpu.r1.af = 0xB61F;
            cpu.r1.bc = 0x1C81;
            cpu.r1.de = 0xB6FB;
            cpu.r1.hl = 0xD6E5;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x09BE;
            cpu.r1.iy = 0xA736;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x8D);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7535, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x1C81, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xB6FB, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD6E5, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x09BE, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA736, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD8E() {
            cpu.Reset();
            cpu.r1.af = 0x4ED4;
            cpu.r1.bc = 0x182D;
            cpu.r1.de = 0xAB17;
            cpu.r1.hl = 0x94AE;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xBB97;
            cpu.r1.iy = 0x87DA;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x8E);
            memory.Write8(0x0002, 0x25);
            memory.Write8(0xBBBC, 0x32);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8094, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x182D, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xAB17, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x94AE, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xBB97, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x87DA, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD94() {
            cpu.Reset();
            cpu.r1.af = 0x7EF1;
            cpu.r1.bc = 0x9EFE;
            cpu.r1.de = 0x6EA1;
            cpu.r1.hl = 0xFC55;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0A09;
            cpu.r1.iy = 0x89C5;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x94);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7422, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9EFE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x6EA1, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xFC55, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0A09, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x89C5, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD95() {
            cpu.Reset();
            cpu.r1.af = 0x2920;
            cpu.r1.bc = 0x59AB;
            cpu.r1.de = 0x428C;
            cpu.r1.hl = 0x3A94;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x44FD;
            cpu.r1.iy = 0xF243;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x95);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x2C3B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x59AB, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x428C, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3A94, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x44FD, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xF243, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD96() {
            cpu.Reset();
            cpu.r1.af = 0x9B76;
            cpu.r1.bc = 0x461F;
            cpu.r1.de = 0xCED7;
            cpu.r1.hl = 0xDB3F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x2C66;
            cpu.r1.iy = 0x9DBF;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x96);
            memory.Write8(0x0002, 0x5F);
            memory.Write8(0x2CC5, 0x49);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5206, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x461F, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xCED7, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDB3F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x2C66, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x9DBF, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD9C() {
            cpu.Reset();
            cpu.r1.af = 0xFAF4;
            cpu.r1.bc = 0x670E;
            cpu.r1.de = 0xAFCC;
            cpu.r1.hl = 0x8B34;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x285F;
            cpu.r1.iy = 0x1CAA;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x9C);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xD282, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x670E, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xAFCC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x8B34, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x285F, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1CAA, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD9D() {
            cpu.Reset();
            cpu.r1.af = 0xF827;
            cpu.r1.bc = 0x0CDB;
            cpu.r1.de = 0xDF32;
            cpu.r1.hl = 0xD0E4;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9B12;
            cpu.r1.iy = 0x7D07;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x9D);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xE5A2, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x0CDB, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xDF32, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD0E4, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9B12, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x7D07, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDD9E() {
            cpu.Reset();
            cpu.r1.af = 0x938E;
            cpu.r1.bc = 0xF9C5;
            cpu.r1.de = 0xCBC4;
            cpu.r1.hl = 0xCA21;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB4CC;
            cpu.r1.iy = 0x46FA;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0x9E);
            memory.Write8(0x0002, 0x14);
            memory.Write8(0xB4E0, 0xB5);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDE9B, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xF9C5, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xCBC4, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xCA21, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB4CC, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x46FA, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDA4() {
            cpu.Reset();
            cpu.r1.af = 0x52F5;
            cpu.r1.bc = 0xBA53;
            cpu.r1.de = 0xACFC;
            cpu.r1.hl = 0x9481;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x2F8B;
            cpu.r1.iy = 0xEDF6;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xA4);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0210, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBA53, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xACFC, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x9481, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x2F8B, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xEDF6, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDA5() {
            cpu.Reset();
            cpu.r1.af = 0xBAAF;
            cpu.r1.bc = 0xA675;
            cpu.r1.de = 0xD757;
            cpu.r1.hl = 0xF1DB;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xFDEF;
            cpu.r1.iy = 0xD8CE;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xA5);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xAABC, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xA675, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xD757, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xF1DB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xFDEF, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD8CE, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDA6() {
            cpu.Reset();
            cpu.r1.af = 0x1DA4;
            cpu.r1.bc = 0x20C4;
            cpu.r1.de = 0xEBC3;
            cpu.r1.hl = 0xDA8D;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x7E95;
            cpu.r1.iy = 0x5E8A;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xA6);
            memory.Write8(0x0002, 0x41);
            memory.Write8(0x7ED6, 0xC7);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x0514, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x20C4, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xEBC3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xDA8D, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x7E95, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x5E8A, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDAC() {
            cpu.Reset();
            cpu.r1.af = 0xEF15;
            cpu.r1.bc = 0x2A7C;
            cpu.r1.de = 0x17E5;
            cpu.r1.hl = 0x3F6E;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xAFFA;
            cpu.r1.iy = 0xA0B5;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xAC);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4000, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x2A7C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x17E5, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3F6E, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xAFFA, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA0B5, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDAD() {
            cpu.Reset();
            cpu.r1.af = 0xBA2E;
            cpu.r1.bc = 0x6BA1;
            cpu.r1.de = 0xEF1B;
            cpu.r1.hl = 0x5713;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xBA38;
            cpu.r1.iy = 0xA708;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xAD);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8284, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6BA1, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xEF1B, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5713, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xBA38, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA708, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDAE() {
            cpu.Reset();
            cpu.r1.af = 0x8009;
            cpu.r1.bc = 0x3AD6;
            cpu.r1.de = 0xA721;
            cpu.r1.hl = 0x2100;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xE909;
            cpu.r1.iy = 0x87B4;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xAE);
            memory.Write8(0x0002, 0x72);
            memory.Write8(0xE97B, 0xC3);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x4300, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x3AD6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA721, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x2100, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xE909, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x87B4, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDB4() {
            cpu.Reset();
            cpu.r1.af = 0x1CCD;
            cpu.r1.bc = 0x29AA;
            cpu.r1.de = 0x2E82;
            cpu.r1.hl = 0x4DC8;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9C04;
            cpu.r1.iy = 0x8BE3;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xB4);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x9C8C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x29AA, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2E82, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x4DC8, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9C04, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8BE3, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDB5() {
            cpu.Reset();
            cpu.r1.af = 0x46B4;
            cpu.r1.bc = 0xFC93;
            cpu.r1.de = 0x7A06;
            cpu.r1.hl = 0x0518;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x0AC5;
            cpu.r1.iy = 0x4150;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xB5);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xC780, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xFC93, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7A06, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0518, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x0AC5, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4150, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDB6() {
            cpu.Reset();
            cpu.r1.af = 0x5017;
            cpu.r1.bc = 0xAB81;
            cpu.r1.de = 0x4287;
            cpu.r1.hl = 0x5EE1;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xC66F;
            cpu.r1.iy = 0xD6CC;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xB6);
            memory.Write8(0x0002, 0x31);
            memory.Write8(0xC6A0, 0x1C);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x5C0C, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAB81, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x4287, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x5EE1, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xC66F, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xD6CC, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDBC() {
            cpu.Reset();
            cpu.r1.af = 0x53E0;
            cpu.r1.bc = 0xAA98;
            cpu.r1.de = 0xF7D7;
            cpu.r1.hl = 0xFA0C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xBE7A;
            cpu.r1.iy = 0xA41F;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xBC);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x53BF, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xAA98, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF7D7, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xFA0C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xBE7A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA41F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDBD() {
            cpu.Reset();
            cpu.r1.af = 0xDC83;
            cpu.r1.bc = 0x80CE;
            cpu.r1.de = 0x5D2F;
            cpu.r1.hl = 0xE999;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xBB41;
            cpu.r1.iy = 0xA24F;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xBD);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0xDC82, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x80CE, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x5D2F, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xE999, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xBB41, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xA24F, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDBE() {
            cpu.Reset();
            cpu.r1.af = 0x9838;
            cpu.r1.bc = 0xBFD5;
            cpu.r1.de = 0xA299;
            cpu.r1.hl = 0xD34B;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x9332;
            cpu.r1.iy = 0xB1D5;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xBE);
            memory.Write8(0x0002, 0x48);
            memory.Write8(0x937A, 0x5B);

            while (cpu.tStates < 19) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x981E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0xBFD5, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xA299, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0xD34B, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x9332, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xB1D5, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(19UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDE1() {
            cpu.Reset();
            cpu.r1.af = 0x8A15;
            cpu.r1.bc = 0x6BF0;
            cpu.r1.de = 0x0106;
            cpu.r1.hl = 0x3DD0;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x5DA4;
            cpu.r1.iy = 0x8716;
            cpu.r1.sp = 0x595F;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xE1);
            memory.Write8(0x595F, 0x9A);
            memory.Write8(0x5960, 0x09);

            while (cpu.tStates < 14) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8A15, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x6BF0, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x0106, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3DD0, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x099A, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x8716, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x5961, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(14UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDE3() {
            cpu.Reset();
            cpu.r1.af = 0x068E;
            cpu.r1.bc = 0x58E6;
            cpu.r1.de = 0x2713;
            cpu.r1.hl = 0x500F;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xBE05;
            cpu.r1.iy = 0x4308;
            cpu.r1.sp = 0x57BD;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xE3);
            memory.Write8(0x57BD, 0x15);
            memory.Write8(0x57BE, 0x3F);

            while (cpu.tStates < 23) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x068E, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x58E6, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x2713, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x500F, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x3F15, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x4308, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x57BD, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(23UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDE5() {
            cpu.Reset();
            cpu.r1.af = 0x7462;
            cpu.r1.bc = 0x9B6C;
            cpu.r1.de = 0xBFE5;
            cpu.r1.hl = 0x0330;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xB282;
            cpu.r1.iy = 0xE272;
            cpu.r1.sp = 0x0761;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xE5);

            while (cpu.tStates < 15) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x7462, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9B6C, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xBFE5, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x0330, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xB282, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0xE272, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x075F, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(15UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDE9() {
            cpu.Reset();
            cpu.r1.af = 0x75A7;
            cpu.r1.bc = 0x139B;
            cpu.r1.de = 0xF9A3;
            cpu.r1.hl = 0x94BB;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0x64F0;
            cpu.r1.iy = 0x3433;
            cpu.r1.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xE9);

            while (cpu.tStates < 8) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x75A7, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x139B, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0xF9A3, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x94BB, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0x64F0, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x3433, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0x0000, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(8UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDF9() {
            cpu.Reset();
            cpu.r1.af = 0x8709;
            cpu.r1.bc = 0x15DD;
            cpu.r1.de = 0x7FA6;
            cpu.r1.hl = 0x3C5C;
            cpu.r2.af = 0x0000;
            cpu.r2.bc = 0x0000;
            cpu.r2.de = 0x0000;
            cpu.r2.hl = 0x0000;
            cpu.r1.ix = 0xD3A7;
            cpu.r1.iy = 0x1D7B;
            cpu.r1.sp = 0xF67C;
            cpu.pc = 0x0000;
            cpu.i = 0x00;
            cpu.r = 0x00;
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xF9);

            while (cpu.tStates < 10) {
                cpu.Execute();
            }
  
            Assert.AreEqual(0x8709, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x15DD, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(0x7FA6, cpu.r1.de, "DE mismatch");
            Assert.AreEqual(0x3C5C, cpu.r1.hl, "HL mismatch");
            Assert.AreEqual(0x0000, cpu.r2.af, "AF' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.bc, "BC' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.de, "DE' mismatch");
            Assert.AreEqual(0x0000, cpu.r2.hl, "HL' mismatch");
            Assert.AreEqual(0xD3A7, cpu.r1.ix, "IX mismatch");
            Assert.AreEqual(0x1D7B, cpu.r1.iy, "IY mismatch");
            Assert.AreEqual(0xD3A7, cpu.r1.sp, "SP mismatch");
            Assert.AreEqual(0x0002, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(10UL, cpu.tStates, "tStates mismatch");
        }

        [TestMethod]
        public void TestDDFD00() {
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
            memory.Write8(0x0000, 0xDD);
            memory.Write8(0x0001, 0xFD);
            memory.Write8(0x0002, 0x00);
            memory.Write8(0x0003, 0x00);

            while (cpu.tStates < 16) {
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
            Assert.AreEqual(0x0004, cpu.r, "R mismatch");
            Assert.AreEqual(0x0000, cpu.i, "I mismatch");
            Assert.AreEqual(16UL, cpu.tStates, "tStates mismatch");
        }
    }
}