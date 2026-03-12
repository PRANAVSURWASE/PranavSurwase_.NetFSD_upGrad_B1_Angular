using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    internal class Patient
    {
        public int PatientId;
        public string name;
        public int Age;
        public string Disease;

        class Program
        {
            static void Main(string[] args)
            {
                Patient p1 = new Patient();
                p1.PatientId = 101;
                p1.name = "Ravi Kumar";
                p1.Age = 50;
                p1.Disease = "Diabetes";

                Console.WriteLine("PatientId :" + p1.PatientId);
                Console.WriteLine("Patient Name :" + p1.name);
                Console.WriteLine("Age :" + p1.Age);
                Console.WriteLine("Disease :" + p1.Disease);

            }
        }
    }
}
