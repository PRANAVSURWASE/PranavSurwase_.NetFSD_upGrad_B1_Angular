using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class BankAccount
    {
        public int AccountNumber;
        public string Name;
        public static double balance = 1000;
        public char transactionType;
        public double amount;

        public void Transaction(char type,double amt)
        {
            transactionType = type;
            amount = amt;
            if(transactionType=='d')
            {
                balance += amount;
                Console.WriteLine("Amount Deposited :" + amount);
                Console.WriteLine("Balance :" + balance);
            }
            else if(transactionType=='c')
            {
                if(balance-amount<500)
                {
                    throw new CheckBalanceException("Balance con not go below 500");
                }
                else
                {
                    balance -= amount;
                    Console.WriteLine("Amount Withdrawn :" + amount);
                    Console.WriteLine("Balance: " + balance);
                }
            }
        }
    }
}
