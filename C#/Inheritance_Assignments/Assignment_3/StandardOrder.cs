using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    internal class StandardOrder: order
    {
        public  override double CalculateShippingCost()
        {
            return 50;
        }
    }
}
