using System;
using System.Net;
using Data;
using System.Xml.Serialization;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Net.Sockets;

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

            try
            {
                //Data Input Checking 
                if (!(textBox1.Text.Length > 0 && textBox2.Text.Length > 0))
                    throw new ArgumentException("Text Boxes Are Empty");

                int port = textBox3.Text.Length > 0 ?
                     int.Parse(textBox3.Text) : 7;

                if (!(port < IPEndPoint.MaxPort && port > IPEndPoint.MinPort))
                    throw new ArgumentException("Port Range [0-65535]");

                textBox3.Text = port.ToString();

                int id = int.Parse(textBox1.Text);
                string name = textBox2.Text;
                bool isMale = radioButton1.Checked;

                //Object initialized based on data input
                Person personSent = new Person(id, name, isMale);


                string personJSSent = JsonSerializer.Serialize<Person>(personSent);
                byte[] packetSend = Encoding.Default.GetBytes(personJSSent); //could use UTF8 or other inputing based on user input


                UdpClient udpClient = null!;

                try
                {

                    udpClient = new UdpClient();
                    udpClient.Send(packetSend, packetSend.Length, "127.0.0.1", port); //data sent


                    IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 0); //get from any ip and port
                    byte[] packetReceived = udpClient.Receive(ref iPEndPoint); //data received
                                                                               //
                    string personJSReceived = Encoding.Default.GetString(packetReceived, 0, packetReceived.Length); //Decode

                    //Deserialize
                    Person personRecieved = JsonSerializer.Deserialize<Person>(personJSReceived)!;


                    label6.Text = personRecieved.Id.ToString();
                    label7.Text = personRecieved.Name;
                    label8.Text = personRecieved.IsMale.ToString();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}