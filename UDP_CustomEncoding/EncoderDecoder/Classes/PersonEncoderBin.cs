using System;
using System.IO;
using System.Text;
using System.Net;
using Data;

namespace EncoderDecoder
{

    public class PersonBinEncoder : PersonEncoderText
    {
        public new Encoding encoding;

        public PersonBinEncoder() : this(PersonBinConst.DEFAULT_CHAR_ENCODER)
        {

        }

        public PersonBinEncoder(string encodedString)
        {
            encoding = Encoding.GetEncoding(encodedString);
        }

        public byte[] encode(Person p)
        {
            MemoryStream mem = new MemoryStream();
            BinaryWriter output = new BinaryWriter(new BufferedStream(mem));
            output.Write(IPAddress.HostToNetworkOrder(p.Id));

            output.Flush();
            return mem.ToArray();
        }
    }
}