using System;
using System.IO;
using System.Text;
using System.Net;
using Data;

namespace EncoderDecoder
{

    public class PersonDecoderBin : PersonDecoderText
    {
        public new Encoding encoding;

        public PersonDecoderBin() : this(PersonBinConst.DEFAULT_CHAR_ENCODER)
        {

        }

        public PersonDecoderBin(string encodedString)
        {
            encoding = Encoding.GetEncoding(encodedString);
        }

        public new String Decode(Stream wire)
        {
            BinaryReader src = new BinaryReader(new BufferedStream(wire));


            int id = IPAddress.NetworkToHostOrder(src.ReadInt32());

            int stringLength = src.Read();

            if (stringLength == -1)
                throw new EndOfStreamException();

            byte[] stringBuf = new byte[stringLength];
            src.Read(stringBuf, 0, stringLength);

            string name = encoding.GetString(stringBuf);

            return id + " " + name;
        }

        public new string Decode(byte[] packet)
        {
            Stream payload = new MemoryStream(packet, 0, packet.Length, false);
            return Decode(payload);
        }
    }
}