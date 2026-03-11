using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class Excercise3
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 3");

            int sum = 0;

            for(int i=1;i<=5;i++)
            {
                Console.WriteLine("Enter Number " + i + ":");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
            double avg = sum / 5.0;

            Console.WriteLine("Sum :" + sum);
            Console.WriteLine("Average :" + avg);
        }

    }
}
