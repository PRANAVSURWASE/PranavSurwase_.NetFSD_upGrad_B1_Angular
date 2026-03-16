using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    internal class order
    {
        public int OrderId { get; set; }
        public double OrderAmount { get; set; }

        public virtual double CalculateShippingCost()
        {
            return 50;
        }
    }
}
