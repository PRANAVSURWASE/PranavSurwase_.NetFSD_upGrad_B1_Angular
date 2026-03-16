using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class Nurse:Staff
    {
        public double NightShiftAllowance { get; set; }

        public override double CalculateSalary()
        {
            return BaseSalary + NightShiftAllowance;
        }
    }
}
