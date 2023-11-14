using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;

namespace UDP_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label6.Text = string.Empty;
            label7.Text = string.Empty;
            label8.Text = string.Empty;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            radioButton1.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text.ToString());
            string name = textBox2.Text.ToString();
            bool isMale = radioButton1.Checked;

            Person person = new Person(id, name, isMale);
            

        }

        /*
            if (args.Length < 2 || args.Length > 3)
                throw new ArgumentException("Parameters : <Server> <Message> [<Port>]");

            string server = args[0];
            string message = args[1];
            int port = args.Length == 3 ? int.Parse(args[2]) : 7;

            byte[] FIFOBytePacket = Encoding.ASCII.GetBytes(args[1]);
            UdpClient udpClient = null!;

            try
            {
                udpClient = new UdpClient();

                udpClient.Send(FIFOBytePacket, FIFOBytePacket.Length, server, port);
                System.Console.WriteLine($"Sent {FIFOBytePacket.Length} bytes to the server...");
                IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] bytes = udpClient.Receive(ref iPEndPoint);
                Console.WriteLine("Recieved {0} bytes from {1} : {2}",bytes.Length,iPEndPoint,Encoding.ASCII.GetString(bytes,0,bytes.Length));
            }
            catch (SocketException se)
            {
                Console.WriteLine(se.ErrorCode + " : " + se.Message);
                Environment.Exit(se.ErrorCode);
            }
            finally
            {
                udpClient?.Close();
            }
            Console.Read();
         */


    }
}
