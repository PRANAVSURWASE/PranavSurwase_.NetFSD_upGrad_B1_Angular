using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class Excercise5
    {
        public static void Run()
        {
            Console.WriteLine("Excercise 5");

            Console.WriteLine("Enter first Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2)
            {
                Console.WriteLine("Highest Number :" + num1);
            }
            else
            {
                Console.WriteLine("Highest Number is " + num2);
            }
        }
    }
}
