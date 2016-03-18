using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Values
{
    public class Qgenretor
    {
        public string[] Q = new string[4];
        public string QA;

        public string GetQ()
        {
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                this.Q[i] = rnd.Next(0, 10).ToString();
            }
            while (this.Q[0] == this.Q[1] || this.Q[0] == this.Q[2] ||
                this.Q[0] == this.Q[3] || this.Q[1] == this.Q[2] || this.Q[1] == this.Q[3] || this.Q[2] == this.Q[3])
            {
                for (int i = 0; i < 4; i++)
                {
                    this.Q[i] = rnd.Next(0, 10).ToString();
                }
            }
            this.QA = this.Q[0] + this.Q[1] + this.Q[2] + this.Q[3];
            return this.QA;
        }
    }
}