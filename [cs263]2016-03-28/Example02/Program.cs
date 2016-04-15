using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            人類 魯夫 = new 人類();
            魯夫.發動攻擊();
            魯夫.撿到惡魔果實(new 橡膠果實());
            魯夫.發動攻擊();
            魯夫.撿到惡魔果實(null);
            魯夫.發動攻擊();

            人類 索隆 = new 人類();
            索隆.攻擊招式 = new 三刀流龍捲風();
            索隆.發動攻擊();
        }
    }
}