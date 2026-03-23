using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9
{
    internal class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Customer: {CustomerName}, Date: {OrderDate.ToShortDateString()}, Amount: {TotalAmount}";
        }



    }
}
