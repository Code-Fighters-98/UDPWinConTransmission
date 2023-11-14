using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            radioButton1.Checked = false;
        }

    }
}
