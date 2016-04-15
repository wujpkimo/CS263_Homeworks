using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    public class StudentDiscount : Discount
    {
        public override double Calculate
        {
            get
            {
                return 0.8;
            }

            //set
            //{
            //    base.Calculate = value;
            //}
        }
    }
}