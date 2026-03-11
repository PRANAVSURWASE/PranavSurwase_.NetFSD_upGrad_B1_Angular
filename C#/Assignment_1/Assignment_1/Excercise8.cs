using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class Excercise8
    {
        public static void Run()
        {
            Console.WriteLine("Excercise 8 ");
            Console.WriteLine("Enter String ");
            String txt = Console.ReadLine();

            if(txt.Length>=3)
            {
                char ch = Char.ToLower(txt[2]);
                if(ch=='a'|| ch == 'e'|| ch == 'i' || ch=='o'||ch=='u')
                {
                    Console.WriteLine("Third Character is Vowel ");
                }
                else
                {
                    Console.WriteLine("Third Character is Consonant ");
                }
            }
            else
            {
                Console.WriteLine("String should contain at least 3 Characters");
            }
        }
    }

}
