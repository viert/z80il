namespace Z80
{
    public interface IMemory
    {
        byte Read8(ushort addr);
        void Write8(ushort addr, byte value);
    }
}
