using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 剪刀石頭布
{
    internal class People
    {
        public int H;
        public string Q;
        public string Result;

        public string ToQ()
        {
            switch (this.H)
            {
                case 0:
                    this.Q = "剪刀";
                    break;

                case 1:
                    this.Q = "石頭";
                    break;

                case 2:
                    this.Q = "布";
                    break;
            }
            return this.Q;
        }
    }
}