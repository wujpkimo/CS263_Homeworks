using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Values;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int index = 1; index <= 1000; index++)
            {
                Qgenretor Q = new Qgenretor
                {
                    Q1 = rnd.Next(0, 10).ToString(),
                    Q2 = rnd.Next(0, 10).ToString(),
                    Q3 = rnd.Next(0, 10).ToString(),
                    Q4 = rnd.Next(0, 10).ToString()
                };
                while (Q.Q2 == Q.Q1 || Q.Q3 == Q.Q1 || Q.Q4 == Q.Q1 || Q.Q3 == Q.Q2 || Q.Q4 == Q.Q2 || Q.Q4 == Q.Q3)
                {
                    Q.Q2 = rnd.Next(0, 10).ToString();
                    Q.Q3 = rnd.Next(0, 10).ToString();
                    Q.Q4 = rnd.Next(0, 10).ToString();
                }
                if (Q.Q2 == Q.Q1 || Q.Q3 == Q.Q1 || Q.Q4 == Q.Q1 || Q.Q3 == Q.Q2 || Q.Q4 == Q.Q2 || Q.Q4 == Q.Q3)
                {
                    Console.WriteLine("issue");
                }
                Console.WriteLine(Q.Q1 + Q.Q2 + Q.Q3 + Q.Q4);
            }
        }
    }
}