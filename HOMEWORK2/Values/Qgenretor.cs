using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Values
{
    public class Qgenretor
    {
        public string Q;
        public string Q1;
        public string Q2;
        public string Q3;
        public string Q4;

        public void GetQ(string Q, string Q1, string Q2, string Q3, string Q4)
        {
            Random rnd = new Random();
            this.Q1 = rnd.Next(0, 10).ToString();
            this.Q2 = rnd.Next(0, 10).ToString();
            this.Q3 = rnd.Next(0, 10).ToString();
            this.Q4 = rnd.Next(0, 10).ToString();
            while (this.Q2 == this.Q1 || this.Q3 == this.Q1 || this.Q4 == this.Q1 || this.Q3 == this.Q2 || this.Q4 == this.Q2 || this.Q4 == this.Q3)
            {
                this.Q2 = rnd.Next(0, 10).ToString();
                this.Q3 = rnd.Next(0, 10).ToString();
                this.Q4 = rnd.Next(0, 10).ToString();
            }
            this.Q = this.Q1 + this.Q2 + this.Q3 + this.Q4;
        }
    }
}