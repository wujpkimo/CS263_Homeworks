using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    public class ChildrenDiscount : Discount
    {
        public override double Calculate
        {
            get
            {
                return 0.3;
            }
        }
    }
}