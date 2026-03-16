using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{
    internal class SchoolStudent:Student
    {
        public SchoolStudent(int id,string name ,double marks):base(id,name,marks)
        {

        }
        public override void CalculateGrade()
        {
            if(Marks>40)
            {
                Console.WriteLine($"{Name} :Pass");
            }
            else
            {
                Console.WriteLine($"{Name} :Fail");
            }
        }


    }
}
