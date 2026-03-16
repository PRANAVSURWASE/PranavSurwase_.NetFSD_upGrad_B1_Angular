using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class LabTechnician:Staff
    {
        public double EquipmentAllowance { get; set; }

        public override double CalculateSalary()
        {
            return BaseSalary + EquipmentAllowance;
        }
    }
}
