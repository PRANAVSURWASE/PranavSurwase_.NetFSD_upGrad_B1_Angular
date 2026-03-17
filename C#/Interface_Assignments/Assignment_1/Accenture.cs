using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class Accenture: GovtRules
    {
        int empid;
        string name;
        string dept;
        string desg;
        double basicSalary;

        public Accenture(int empid,string name,string dept,string desg, double basicSalary)
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
        public string Desg { get { return desg; }  }
        public double BasicSalary { get { return basicSalary; } }

        public double EmployeePF(double basicSalary)
        {
            double employeePF = basicSalary * 0.12;
            double employerPF = basicSalary * 0.12;
            Console.WriteLine("Employee PF (12%) : " + employeePF);
            Console.WriteLine("Employer PF (12%) : " + employerPF);
            return employeePF;
        }

        public string LeaveDetails()
        {
            return "2 Casual Leave/month\n5 Sick Leave/year\n5 Privilege Leave/year";

        }
        public double gratuityAmount(float serviceCompleted,double basicSalary)
        {
            return 0;
        }


    }
}
