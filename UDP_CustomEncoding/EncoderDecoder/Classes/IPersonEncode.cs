using Data;

namespace EncoderDecoder
{
    public interface IPersonEncode
    {
        byte[] Encode(Person item);
    }
}