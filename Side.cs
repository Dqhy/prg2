using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomCafe
{
    class Side : Product
    {
        public Side()
        {

        }

        public Side (string name, double price) : base (name, price)
        {
     
        }

        public override double GetPrice()
        {
            return Price;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
