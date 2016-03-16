using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Values;

namespace 猜數字
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Qgenretor aQ = new Qgenretor
            { };
            aQ.GetQ("0", "0", "0", "0", "0");
            Ans.Text = aQ.Q;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Qgenretor aQ = new Qgenretor
            { };
            aQ.GetQ("0", "0", "0", "0", "0");
            Ans.Text = aQ.Q;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // Enter is pressed - do something
                if (textBox1.Text == Ans.Text)
                {
                    Summit.Enabled = false;
                    Meg.Text = "恭喜您，猜中了！";
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}