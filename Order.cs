using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomCafe
{
    class Order
    {
        private int orderNo;

        public int OrderNo
        {
            get { return orderNo; }
            set { orderNo = value; }
        }

        private List<OrderItem> ItemList = new List<OrderItem>();

        public List<OrderItem> itemList
        {
            get { return ItemList; }
            set { ItemList = value; }
        }

        public Order()
        { }

        public void add (OrderItem oi)
        {
            ItemList.Add(oi);
        }

        public void Remove(int orderNo)
        {
            this.orderNo = orderNo;
        }

        public double GetTotalAmt()
        {
            return 0;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
