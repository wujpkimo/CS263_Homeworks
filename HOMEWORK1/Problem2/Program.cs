using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            customer GBT = new customer
            {
                companyName = "GBT",
                custInfo = new custInfo
                {
                    phone = "02-12314124",
                    email = "gbt@jj.com",
                    address = "Taipei ROC"
                },
                finc = new finc
                {
                    cost = 10000,
                    remark = "test remark"
                }
            };
            Console.WriteLine(GBT.companyName);
            Console.WriteLine(GBT.custInfo.phone);
            Console.WriteLine(GBT.custInfo.email);
            Console.WriteLine(GBT.custInfo.address);
            Console.WriteLine(GBT.finc.cost);
            Console.WriteLine(GBT.finc.remark);
        }
    }
}