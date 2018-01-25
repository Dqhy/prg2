using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomCafe
{
    class Beverage : Product
    {
        private double tradeIn;

        public double TradeIn
        {
            get { return tradeIn; }
            set { tradeIn = value; }
        }

        public Beverage() { }

        public Beverage(string name, double price, double tradeIn) : base(name, price)
        {
            this.tradeIn = tradeIn;
        }

        public override double GetPrice()
        {
            return 0.0;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
