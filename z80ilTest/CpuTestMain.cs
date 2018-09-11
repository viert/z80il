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
        public void Test41()
        {
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
            cpu.sp = 0x0000;
            cpu.pc = 0x0000;
            cpu.i = 0;
            cpu.r = 0;
            memory.Write8(0x0000, 0x41);
            memory.Write8(0x0000, 0x50);

            while (cpu.tStates < 4) {
                cpu.Execute();
            }

            Assert.AreEqual(0x0200, cpu.r1.af, "AF mismatch");
            Assert.AreEqual(0x9898, cpu.r1.bc, "BC mismatch");
            Assert.AreEqual(cpu.r1.de, 0x90D8, "r1.DE mismatch");
            Assert.AreEqual(cpu.r1.hl, 0xA169, "r1.HL mismatch");
            Assert.AreEqual(cpu.r2.af, 0x0000);
            Assert.AreEqual(cpu.r2.bc, 0x0000);
            Assert.AreEqual(cpu.r2.de, 0x0000);
            Assert.AreEqual(cpu.r2.hl, 0x0000);
            Assert.AreEqual(cpu.sp, 0x0000);
            Assert.AreEqual(cpu.r, 1);
            Assert.AreEqual(cpu.i, 0);
            Assert.AreEqual(cpu.tStates, 4);

        }
    }
}
