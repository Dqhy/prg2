using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomCafe
{
    abstract class Product
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double price; 

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Product()
        {

        }

        public Product (string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public abstract double GetPrice();

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
