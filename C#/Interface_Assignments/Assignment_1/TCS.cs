using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class TCS
    {
        int empid;
        string name;
        string dept;
        string desg;
        double basicSalary;

        public TCS(int empid, string name, string dept, string desg, double basicSalary)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
        }

        public int EmpId { get { return empid; } }
        public string Name { get { return name; } }
        public string Dept { get { return dept; } }
        public string Desg { get { return desg; } }
        public double BasicSalary { get { return basicSalary; } }

        public double EmployeePF(double basicSalary)
        {
            double employeePF = basicSalary * 0.12;
            double employerPF = basicSalary * 0.08333;
            double pension = basicSalary * 0.0367;

            Console.WriteLine("Employee PF (12%) :" + employeePF);
            Console.WriteLine("Employer PF (8.33) :" +employerPF);
            Console.WriteLine("Pension Fund (3.67) :" + pension);

            return employeePF;

        }
        public string LeaveDetails()
        {
            return "1.Casual Leave/Month\n12 Sick Leave/year\n10 Privilege Leave/year";

        }
        public double gratuityAmount(float serviceCompleted,double basicSalary)
        {
            if(serviceCompleted>20)
            {
                return 3 * basicSalary;
            }
            else if(serviceCompleted>10)
            {
                return 2 * basicSalary;
            }
            else if(serviceCompleted>5)
            {
                return basicSalary;
            }
            return 0;
        }
    }
}
