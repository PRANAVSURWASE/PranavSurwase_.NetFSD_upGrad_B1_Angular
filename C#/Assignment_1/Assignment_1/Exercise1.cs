using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class Exercise1
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 1");

            Console.WriteLine("Enter First Number ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ENter Second Line ");
            double num2 = Convert.ToDouble(Console.ReadLine());


            double res = num1 / num2;
            Console.WriteLine("Result :" + res);
        }
    }
}
