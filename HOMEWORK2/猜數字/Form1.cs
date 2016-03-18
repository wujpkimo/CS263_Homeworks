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
        //Qn猜題次數，A為猜對位置數，B為猜對數字但位置錯誤
        public int Qn, A, B;

        public string[] QQ = new string[4];//題目
        public string[] AA = new string[4];//作答

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChkValue();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void CheckKeys(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // Enter is pressed - do something
                ChkValue();
            }
        }

        //檢核作答是否符合規則
        private void ChkValue()
        {
            int Ax1 = 1;
            bool Ax = int.TryParse(AnsText.Text, out Ax1);
            //Ax以布林式判定輸入值是否為INT
            if (AnsText.TextLength != 4 || Ax == false)
            {
                MessageBox.Show("請輸入四碼0-9的數字！！");
                AnsText.Text = "";
            }
            else
            {
                for (int index = 0; index < 4; index++)
                {
                    AA[index] = AnsText.Text.Substring(index, 1);
                }
                if (AA[0] == AA[1] || AA[0] == AA[2] || AA[0] == AA[3]
                    || AA[1] == AA[2] || AA[1] == AA[3] || AA[2] == AA[3])
                {
                    MessageBox.Show("四碼0-9的數字請不要重複！！");
                    AnsText.Text = "";
                }
                else
                {
                    ChkAns();
                }
            }
        }

        //檢核作答內容
        private void ChkAns()
        {
            A = 0; B = 0;
            Qn = Qn + 1;
            for (int index = 0; index < 4; index++)
            {
                if (AA[index] == QQ[index])
                { A = A + 1; }
                else
                {
                    for (int index1 = 0; index1 < 4; index1++)
                    {
                        if (AA[index] == QQ[index1])
                        { B = B + 1; }
                    }
                }
            }
            if (A == 4)
            {
                Summit.Enabled = false;
                Meg.Text = Qn + ". " + AnsText.Text + " " + A + "A" + B + "B\r\n" + Meg.Text;
                Meg.Text = "恭喜您在第" + Qn + "次猜中了！\r\n" + Meg.Text;
                Reset.Focus();
            }
            else
            {
                Meg.Text = Qn + ". " + AnsText.Text + " " + A + "A" + B + "B\r\n" + Meg.Text;
            }
            AnsText.Text = "";
        }

        //重置數字
        public void reset()
        {
            Qgenretor aQ = new Qgenretor
            { };
            Ans.Text = aQ.GetQ();
            for (int index = 0; index < 4; index++)
            {
                QQ[index] = Ans.Text.Substring(index, 1);
            }
            Summit.Enabled = true;
            AnsText.Text = "";
            Meg.Text = "";
            Qn = 0;
            AnsText.Focus();
        }
    }
}