
using Data;
using EncoderDecoder;
using System.Net.Sockets;
using System.Net;

namespace Udp_Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 1)
                throw new ArgumentException("Parameters: <Port>");

            int port = args.Length == 1 ? int.Parse(args[0]) : 7;

            UdpClient udpClient = new UdpClient(port);
            byte[] packet = new byte[PersonTextConst.MAX_WIRE_LENGTH];
            IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Any, port);
            packet = udpClient.Receive(ref remoteIpEndPoint);
            PersonDecoderText decoderText = new PersonDecoderText();

            Person p = decoderText.Decode(packet);
            System.Console.WriteLine(p);

            udpClient.Close();
            Console.Read();
        }
    }
}