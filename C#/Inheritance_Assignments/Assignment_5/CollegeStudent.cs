using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{
    internal class CollegeStudent:Student
    {
        public CollegeStudent(int id,string name,double marks):base(id,name,marks)
        {

        }
        public override void CalculateGrade()
        {
            if (Marks > 50)
                Console.WriteLine($"{Name} :Pass");
            else
                Console.WriteLine($"{Name} :Fail");
        }

    }
}
