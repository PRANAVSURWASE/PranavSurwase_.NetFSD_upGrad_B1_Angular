using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Department { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"ID :{Id} Name :{Name} Department: {Department} Salary :{Salary} ";
        }
    }
}
