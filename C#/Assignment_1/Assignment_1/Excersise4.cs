using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class Excersise4
    {
        public static void Run()
        {
            Console.WriteLine("Excercise 4 ");
            Console.WriteLine("Enter Number :");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num %2==0)
            {
                Console.WriteLine("Even ");
            }
            else
            {
                Console.WriteLine("Odd ");
            }
        }
    }
}
