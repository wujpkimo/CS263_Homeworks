using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class customer
    {
        public string companyName;
        public custInfo custInfo;
        public finc finc;
    }

    internal class custInfo
    {
        public string phone;
        public string email;
        public string address;
    }

    internal class finc
    {
        public int cost;
        public string remark;
    }
}