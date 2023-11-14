using System;
using System.IO;
using System.Text;
using Data;

namespace EncoderDecoder
{
    public class PersonEncoderText : IPersonEncode
    {
        public Encoding encoding;

        public PersonEncoderText() : this(PersonTextConst.DEFAULT_CHAR_ENCODER) { }

        public PersonEncoderText(string encodingDesc)
        {
            encoding = Encoding.GetEncoding(encodingDesc);
        }

        public byte[] Encode(Person person)
        {
            string encodedString = person.Id + "\n";
            encodedString += person.Name + "\n";
            encodedString += person.IsMale + "\n";
           
            if(encodedString.Length > PersonTextConst.MAX_WIRE_LENGTH)
            throw new IOException("Encoded length too long");

            byte[] buff = encoding.GetBytes(encodedString);

            return buff;
        }
    }
}