using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class SavingAccount:Account
    {
        public  new  void CalculateInterest()
        {
            double interest = Balance * 0.05;

            Console.WriteLine("Saving Account interest calculation ");
            Console.WriteLine($"Account Number :{AccountNumber}");
            Console.WriteLine($"Balance :{Balance}");
            Console.WriteLine($"Interest :{interest}");
        }
    }
}
