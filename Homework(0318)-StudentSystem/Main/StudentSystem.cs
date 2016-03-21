using ScoreCalculationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class StudentSystem
    {
        private int peoson;

        public int Peoson
        {
            get { return peoson; }
            set
            {
                if (value < 0)
                {
                    peoson = 0;
                }
                else if (value > 3)
                {
                    peoson = 3;
                }
                else
                { peoson = value; }
            }
        }

        public static void run(int number)
        {
            Student[] student = new Student[number];
            number = number - 1;
            string name = string.Empty;
            int chinese = 0;
            int english = 0;
            int math = 0;
            for (int index = 0; index <= number; index++)
            {
                Console.Write("請輸入學生{0}姓名:", index + 1);
                name = Console.ReadLine();

                do
                {
                    Console.Write("請輸入國文成績:");
                } while (!int.TryParse(Console.ReadLine(), out chinese));

                do
                {
                    Console.Write("請輸入英文成績:");
                } while (!int.TryParse(Console.ReadLine(), out english));

                do
                {
                    Console.Write("請輸入數學成績:");
                } while (!int.TryParse(Console.ReadLine(), out math));

                student[index] = new Student(name, chinese, english, math);
            }
            Console.WriteLine("您總共輸入了{0}筆學生資料！", number);
            Console.WriteLine("資料如下…");
            for (int index = 0; index <= number; index++)
            {
                Console.Write("第{0}筆學生資料:", index + 1);
                Console.WriteLine(student[index]);
            }
        }
    }
}