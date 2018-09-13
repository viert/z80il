namespace Z80
{
    public interface IPort
    {
        byte Read(ushort addr);
        void Write(ushort addr, byte value);
    }
}
