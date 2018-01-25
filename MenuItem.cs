using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomCafe
{
    class MenuItem
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

        private List<Product> productList = new List<Product>();

        public List<Product> ProductList
        {
            get { return productList; }
            set { productList = value; }
        }

        public MenuItem()
        {

        }

        public MenuItem(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public double GetTotalPrice()
        {
            return price;
        }

        public override string ToString()
        {
            return string.Format("{0}\n${1:0.00}", name, price);

        }
    }
}
