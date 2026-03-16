using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Assignment_3
{
    internal class InternationalOrder:order
    {
        public override double CalculateShippingCost()
        {
            return 500;
        }    
       
    }
}
