using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_11
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public DateTime JoiningDate { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Dept: {Department}, Salary: ₹{Salary:F2}, Joined: {JoiningDate:dd-MM-yyyy}";
        }


    }
}
