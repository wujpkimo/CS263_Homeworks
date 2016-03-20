using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Employee
    {
        private string name;

        public string Name
        {
            get
            { return this.name; }
            set
            { this.name = value; }
        }

        private int basesalary;
        private int benefit;
        private int salary;

        public int BaseSalary
        {
            get { return this.basesalary; }
            set
            {
                if (basesalary < 0)
                { this.basesalary = 0; }
                else if (basesalary > 30000)
                { basesalary = 30000; }
                else
                    this.basesalary = value;
            }
        }

        public int Benefit
        {
            get { return this.benefit; }
            set
            {
                if (this.benefit < 0)
                { this.benefit = 0; }
                else
                    this.benefit = value;
            }
        }

        public int TotalSalary
        {
            get
            {
                this.salary = this.BaseSalary + this.Benefit;
                return this.salary;
            }
        }

        //public SetEmployee(string name, int basesalary, int benefit)
        //{
        //    this.Name = name;
        //    this.salarys.BaseSalary = basesalary;
        //    this.salarys.Benefit = benefit;
        //}
    }
}