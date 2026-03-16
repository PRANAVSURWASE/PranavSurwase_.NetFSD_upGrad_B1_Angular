using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class CurrentAccount:Account
    {
        public new void CalculateInterest()
        {
            double interest = Balance * 0.02;

            Console.WriteLine("Current account interest Calculation");
            Console.WriteLine($"Account Number :{AccountNumber}");
            Console.WriteLine($"Balance :{Balance}");
            Console.WriteLine($"Interest:{interest}");

        }
        
    }
}
