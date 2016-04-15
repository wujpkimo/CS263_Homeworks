using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public abstract class 武器 : 攻擊招式介面
    {
        public virtual void 攻擊()
        {
            throw new NotImplementedException();
        }
    }
}