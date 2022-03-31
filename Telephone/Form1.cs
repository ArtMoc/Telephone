using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone
{
    public partial class Form1 : Form
    {
        Caller caller;
        int RUB = 200;
        public Form1()
        {
            InitializeComponent();
            caller = new Mobile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RUB-=caller.Call(Convert.ToInt32(textBox1.Text));
            label1.Text = "Финансы: " + RUB.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            caller = new Mobile();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            caller = new Skype();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            caller = new Stationary();
        }
    }
}
