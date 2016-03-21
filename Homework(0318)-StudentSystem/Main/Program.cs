using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int no = 0;
            do
            {
                Console.Write("請輸入人數：");
            } while (!int.TryParse(Console.ReadLine(), out no));
            StudentSystem A = new StudentSystem();
            A.Peoson = no;//限制學生最多3人
            StudentSystem.run(A.Peoson);//執行
        }
    }
}