using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomCafe
{
    class OrderItem
    {
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

 
        private MenuItem item;

        public MenuItem Item
        {
            get { return item; }
            set { item = value; }
        }

        public OrderItem() { }


        public OrderItem(MenuItem item)
        {
            this.item = item;
        }

        public void AddQty()
        {

        }

        public bool RemoveQty()
        {
            return true;
        }

        public double GetItemTotalAmt()
        {
            return 0.00;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
