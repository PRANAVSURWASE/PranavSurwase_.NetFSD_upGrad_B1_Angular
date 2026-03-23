using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6
{
    internal class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public double Amount { get; set; }

        public override string ToString()
        {
            return $"Id :{Id} Name:{CustomerId} Amount:{Amount}";
        }

    }
}
