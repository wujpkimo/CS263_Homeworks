using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public abstract class 角色
    {
        public string 名字 { get; set; }

        public 攻擊招式介面 攻擊招式;

        public virtual void 發動攻擊()
        {
            if (攻擊招式 == null)
            {
                攻擊招式 = new 不會攻擊();
            }
            Console.WriteLine(攻擊招式);
        }
    }
}