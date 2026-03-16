using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Account
    {
        public double AccountNumber {  get; set; }
        public double Balance { get; set; }

        public void CalculateInterest()
        {
            Console.WriteLine("Base account Interest Calculations");
            Console.WriteLine($"AccountNumber: {AccountNumber}");
            Console.WriteLine($"Balance :{Balance}");
        }
    }
}
