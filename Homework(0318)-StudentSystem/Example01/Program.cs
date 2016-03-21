using ScoreCalculationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student student = new Student() { Name = "Resnick" };
            string name = string.Empty;
            int chinese = 0;
            int english = 0;
            int math = 0;
            Console.Write("請輸入姓名:");
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

            //if (!int.TryParse(Console.ReadLine(), out chinese))
            //{
            //    Console.WriteLine("輸入錯誤，請重新輸入");
            //}

            student = new Student(name, chinese, english, math);
            //student.grades[0].value = 1000;

            Console.WriteLine(student);
        }
    }
}