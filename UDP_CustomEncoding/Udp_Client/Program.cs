using System.Net.Sockets;
using Data;
using EncoderDecoder;

namespace Udp_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string server = "127.0.0.1";
            int port = args.Length == 1 ? int.Parse(args[1]) : 7;
            Person p = new Person(12, "Emil",false);


            UdpClient client = new UdpClient();
            IPersonEncode encoder = new PersonEncoderText();
            byte[] codedPerson = encoder.Encode(p);

            client.Send(codedPerson, codedPerson.Length, server, port);

            client.Close(); Console.Read();

        }
    }
}