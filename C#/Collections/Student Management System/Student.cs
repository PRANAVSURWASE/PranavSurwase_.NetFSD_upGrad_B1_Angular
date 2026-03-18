using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management_System
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}, Name:{Name}, Marks:{Marks}";
        }
    }
}
