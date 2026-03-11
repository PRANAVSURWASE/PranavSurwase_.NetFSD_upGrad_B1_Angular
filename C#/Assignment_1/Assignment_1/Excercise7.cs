using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class Excercise7
    {
        public static  void Run()
        {
            Console.WriteLine("Excercise 7");

            Console.WriteLine("ENter Distance :");
            double dist = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Speed :");
            double speed = Convert.ToDouble(Console.ReadLine());

            double time = dist / speed;
            Console.WriteLine("Timme Taken : " + time);
        }
    }
}
