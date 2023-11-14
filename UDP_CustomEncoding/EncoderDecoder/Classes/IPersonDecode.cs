using System.IO;
using Data;

namespace EncoderDecoder
{

    public interface IPersonDecode
    {
        Person Decode(byte[] packet);
        Person Decode(Stream source);
    }
}