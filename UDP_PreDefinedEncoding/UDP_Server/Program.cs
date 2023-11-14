using Data;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Text.Json;

namespace UDP_Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //enter port number or set 7 as default
            if (args.Length > 1)
                throw new ArgumentException("Parameters : [<Port>]");
            int port = args.Length == 1 ? int.Parse(args[0]) : 7;

            UdpClient server = null!;
            try
            {
                server = new UdpClient(port);
                IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 0); //listen to any ip address and any port number

                while (true)
                {

                    byte[] bytesRecieved = server.Receive(ref iPEndPoint); //Thread waits for recieving data

                    //Decoding to Person
                    string personJsRecieved = Encoding.Default.GetString(bytesRecieved, 0, bytesRecieved.Length);
                    Person personRecieved = JsonSerializer.Deserialize<Person>(personJsRecieved)!;

                    personRecieved.Name += " : data recieved";

                    //Serialize
                    string personJsSent = JsonSerializer.Serialize<Person>(personRecieved);

                    //Encode Again
                    byte[] bytesSent = Encoding.Default.GetBytes(personJsSent);
                    Console.WriteLine("Handling Client at " + iPEndPoint + "...");

                    //Sent modified data back to client 
                    server.Send(bytesSent, bytesSent.Length, iPEndPoint);
                    System.Console.WriteLine("echoed {0} bytes to {1} : {2}", bytesSent.Length, iPEndPoint, Encoding.Default.GetString(bytesSent));

                }
            }
            catch (SocketException se)
            {
                Console.WriteLine(se.ErrorCode + " : " + se.Message);
                Environment.Exit(se.ErrorCode);
            }
            finally
            {
                server?.Close();
            }
        }
    }
}