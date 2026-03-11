using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class Exercise2
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 2 ");
            Console.WriteLine("Enter Distance in Kilometers ");
            double km = Convert.ToDouble(Console.ReadLine());

            double meter = km * 1000;
            Console.WriteLine("Distance  in Meters :"+meter);
        }
    }
}
