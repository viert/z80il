using Z80;
namespace z80ilTest
{
    public class SimpleMemory : IMemory
    {
        byte[] store;
        public SimpleMemory()
        {
            store = new byte[65536];
        }

        public byte Read8(ushort addr) {
            return store[addr];
        }

        public void Write8(ushort addr, byte value) {
            store[addr] = value;
        }
    }
}
