using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public double Marks { get; set; }

        public Student(int id,String name,double marks)
        {
            StudentId = id;
            Name = name;
            Marks = marks;

        }
        public virtual void CalculateGrade()
        {
            if(Marks>50)
            {
                Console.WriteLine($"{Name} :PASS");

            }
            else
            {
                Console.WriteLine($"{Name} :Fail");
            }
        }


    }
}
