using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    public class Ticket
    {
        public double Price { set; get; }

        public double Qty { set; get; }

        public double DiscountCate { set; get; }

        public double Discount { set; get; }

        public double StandPrice
        {
            get { return 250; }
            set { }
        }

        private double sumPrice;

        public double SumPrice
        {
            set
            {
                this.sumPrice = this.Price * this.Qty;
            }
            get
            {
                return this.sumPrice;
            }
        }

        public Ticket()
        {
        }

        public Ticket(double discountCate, double qty, double discount)
        {
            this.DiscountCate = discountCate;
            this.Qty = qty;
            this.Discount = discount;
            this.Price = this.StandPrice * Discount;
            this.sumPrice = this.Price * Qty;
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += string.Format("票券類型:{0}, 折扣:{1}%\r\n",
                this.DiscountCate, this.Discount * 100);
            result += string.Format("張數:{0},單價:{1},小計:{2}\r\n",
                this.Qty, this.Price, this.sumPrice);
            return result;
        }
    }
}