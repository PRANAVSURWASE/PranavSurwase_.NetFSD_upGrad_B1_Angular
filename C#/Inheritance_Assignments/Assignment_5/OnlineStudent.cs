using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{
    internal class OnlineStudent:Student
    {
        public OnlineStudent(int id ,string name,double marks):base(id,name,marks)
        {

        }
        public override void CalculateGrade()
        {
            if (Marks > 60)
                Console.WriteLine($"{Name} :Pass");
            else
                Console.WriteLine($"{Name} : Fail");
        }
    }
}
