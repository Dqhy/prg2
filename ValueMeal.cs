using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomCafe
{
    class ValueMeal : Product
    {
        private DateTime startTime;

        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        private DateTime endTime;

        public DateTime EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }

        public ValueMeal() { }

        public ValueMeal(string name, double price, DateTime startTime, DateTime endTime) : base(name, price)
        {
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public override double GetPrice()
        {
            return this.Price;
        }

        public bool IsAvailable()
        {
            DateTime Now = DateTime.Now;
            if ((this.startTime >= Now) && (Now <= this.endTime))
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
