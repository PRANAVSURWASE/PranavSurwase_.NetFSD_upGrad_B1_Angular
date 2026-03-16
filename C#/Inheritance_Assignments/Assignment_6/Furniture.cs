using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6
{
    internal class Furniture
    {
        public int OrderId;
        public string OrderDate;
        public string FurnitureType;
        public int Qty;
        public double TotalAmt;
        public string PaymentMode;

        public virtual void getData()
        {
            Console.WriteLine("Enter Order ID: ");
            OrderId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Order Date :");
            OrderDate = Console.ReadLine();

            Console.WriteLine("Enter Furniture Type ");
            FurnitureType = Console.ReadLine();

            Console.WriteLine("Enter Quantity ");
            Qty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Payment mode ");
            PaymentMode = Console.ReadLine();
        }

        public virtual void showData()
        {
            Console.WriteLine("Order Id: " + OrderId);
            Console.WriteLine("Order Date: " + OrderDate);
            Console.WriteLine("Furniture Type: " + FurnitureType);
            Console.WriteLine("Quantity: " + Qty);
            Console.WriteLine("Payment Mode: " + PaymentMode);

        }

    }
}
