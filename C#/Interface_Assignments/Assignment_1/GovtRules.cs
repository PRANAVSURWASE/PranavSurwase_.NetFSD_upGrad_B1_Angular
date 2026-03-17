using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal interface GovtRules
    {
        double EmployeePF(double basicSalary);
        string LeaveDetails();
        double gratuityAmount(float serviceCompleted, double basicSalary);
    }
}
