using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class Staff
    {
        public int StaffId { get; set; }
        public string Name { get; set; }
        public double BaseSalary { get; set; }

        public virtual double CalculateSalary()
        {
            return BaseSalary;
        }

    }
}
