using Data;
using EncoderDecoder;
using System;
using System.IO;
using System.Text;
using Data;

namespace EncoderDecoder
{
    public class PersonDecoderText : IPersonDecode
    {
        public Encoding encoding;

        public PersonDecoderText() : this(PersonTextConst.DEFAULT_CHAR_ENCODER) { }

        public PersonDecoderText(string decodingDesc)
        {
            encoding = Encoding.GetEncoding(decodingDesc);
        }

        public Person Decode(Stream wire)
        {
            string Id,Name,IsMale;

            byte[] newline = encoding.GetBytes("\n");

            Id = encoding.GetString(Framer.NextToken(wire,newline));
            Name = encoding.GetString(Framer.NextToken(wire,newline));
            IsMale = encoding.GetString(Framer.NextToken(wire,newline));
           

            return new Person(int.Parse(Id),Name,bool.Parse(IsMale));
        }

        public Person Decode(byte[] packet)
        {
            Stream payload = new MemoryStream(packet,0,packet.Length,false);
            return Decode(payload);
        }
    }
}