using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class Excercise6
    {
        public static void Run()
        {
            Console.WriteLine("Excercise 6");

            Console.WriteLine("Enter Length & width of Rectangle : ");
            int len = Convert.ToInt32(Console.ReadLine());
            int Width = Convert.ToInt32(Console.ReadLine());

            int areaReactangle = len * Width;

            Console.WriteLine("Area Of Rectangle :" + areaReactangle);

            Console.WriteLine("Enter Side of Square :");
            double side = Convert.ToDouble(Console.ReadLine());

            double squareArea  = side * side;
            Console.WriteLine("Area of Square :" + squareArea);
        }
    }
}
