using Microsoft.VisualStudio.TestTools.UnitTesting;
using Z80;

namespace z80ilTest
{
    [TestClass]
    public class CpuTestDisassemble
    {
        readonly Cpu cpu;
        SimpleMemory memory;
        FakePort port;
        string result;

        public CpuTestDisassemble()
        {
            memory = new SimpleMemory();
            port = new FakePort();
            cpu = new Cpu(memory, port);
        }

        [TestMethod]
        public void DisasmLDDEFFFF()
        {
            cpu.Reset();
            memory.Write8(0x0000, 0x11); // LD DE, nn
            memory.Write8(0x0001, 0xFF);
            memory.Write8(0x0002, 0xFF);
            ushort next = cpu.Disassemble(0x0000, out result);
            Assert.AreEqual(0x0003, next, "The next op addr must be 0x0003");
            Assert.AreEqual("ld de, $FFFF", result, "Disassembly string mismatch");
        }

        [TestMethod]
        public void DisasmINC_IYd()
        {
            cpu.Reset();
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0x34);
            memory.Write8(0x0002, 0xFC);
            ushort next = cpu.Disassemble(0x0000, out result);
            Assert.AreEqual(0x0003, next, "The next op addr must be 0x0003");
            Assert.AreEqual("inc (iy-4)", result, "Disassembly string mismatch");
        }

        [TestMethod]
        public void DisasmSet1IYd()
        {
            memory.Write8(0x0000, 0xFD);
            memory.Write8(0x0001, 0xCB);
            memory.Write8(0x0002, 0x01);
            memory.Write8(0x0003, 0xCE);
            ushort next = cpu.Disassemble(0x0000, out result);
            Assert.AreEqual(0x0004, next, "The next op addr must be 0x0004");
            Assert.AreEqual("set 1, (iy+1)", result, "Disassembly string mismatch");
        }

    }
}
