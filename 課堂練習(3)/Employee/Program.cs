using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string TmpName = string.Empty;
            int TmpBS;
            int TmpBF;
            Employee Employees = new Employee();
            Console.Write("請輸入姓名：");
            TmpName = Console.ReadLine();
            do
            {
                Console.Write("請輸入底薪：");
            } while (!int.TryParse(Console.ReadLine(), out TmpBS));
            do
            {
                Console.Write("請輸入獎金：");
            } while (!int.TryParse(Console.ReadLine(), out TmpBF));

            Employees.Name = TmpName;
            Employees.BaseSalary = TmpBS;
            Employees.Benefit = TmpBF;

            Console.WriteLine("{0}的薪資為：{1}", Employees.Name, Employees.TotalSalary);

            Employee[] employees1;
            employees1 = new Employee[3]
            {
                new Employee {Name= "Resnick", BaseSalary = 22000, Benefit = 0 },
                new Employee {Name= "Jason", BaseSalary = 18000, Benefit = 3000 },
                new Employee {Name= "Kyle ", BaseSalary = 21000, Benefit = 10000 }
            };
            Console.WriteLine("{0}的薪資為：{1}", employees1[0].Name, employees1[0].TotalSalary);
            Console.WriteLine("{0}的薪資為：{1}", employees1[1].Name, employees1[1].TotalSalary);
            Console.WriteLine("{0}的薪資為：{1}", employees1[2].Name, employees1[2].TotalSalary);
        }
    }
}