using System;

namespace EncoderDecoder
{
    public class PersonBinConst
    {
        public const string DEFAULT_CHAR_ENCODER = "ascii";
        public const int MAX_WIRE_LENGTH = 1024;
        public const int MAX_DESC_LEN = 255;
        public const byte IN_STOCK_FLAG = 1 << 0;
        public const byte DISCOUNT_FLAG = 1 << 7;
    }
}