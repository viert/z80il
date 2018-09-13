using Z80;
namespace z80ilTest
{
    public class FakePort : IPort
    {
        public void Write(ushort addr, byte value) {

        }

        public byte Read(ushort addr) {
            // This behaviour is needed by fuse cpu tests
            byte val = (byte)(addr >> 8);
            return val;
        }
    }
}
