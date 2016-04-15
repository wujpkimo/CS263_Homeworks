using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public class 不會攻擊 : 攻擊招式介面
    {
        public void 攻擊()
        {
            Console.WriteLine("我還沒學會怎麼攻擊耶！");
        }
    }
}