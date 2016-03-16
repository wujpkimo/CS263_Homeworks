using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 剪刀石頭布
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            People P1 = new People
            {
                H = rnd.Next(0, 3)
            };
            People P2 = new People
            { H = rnd.Next(0, 3) };

            if (P1.H == P2.H)
            {
                P1.Result = P2.Result = "平手";
            }
            else if ((P1.H == 0 && P2.H == 1) ||
                     (P1.H == 1 && P2.H == 2) ||
                     (P1.H == 2 && P2.H == 0))
            {
                P1.Result = "輸";
                P2.Result = "贏";
            }
            else if ((P1.H == 0 && P2.H == 2) ||
                     (P1.H == 1 && P2.H == 0) ||
                     (P1.H == 2 && P2.H == 1))
            {
                P1.Result = "贏";
                P2.Result = "輸";
            }
            Console.WriteLine("P1出{0}:{1}\n", P1.ToQ(), P1.Result);
            Console.WriteLine("P2出{0}:{1}\n", P2.ToQ(), P2.Result);
        }
    }
}