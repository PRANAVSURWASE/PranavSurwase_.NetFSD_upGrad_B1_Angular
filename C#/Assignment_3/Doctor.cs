using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    internal class Doctor
    {
        public int DoctorId;
        public string DoctorName;
        public string Specialization;
        public double ConsultationFee;
    

}
    class Program
    {
        static void main()
        {
            Doctor d1 = new Doctor();
            d1.DoctorId = 200;
            d1.DoctorName = "Dr.Sharma";
            d1.Specialization = "Cardiologist";
            d1.ConsultationFee = 1000;

            Doctor d2 = new Doctor();
            d2.DoctorId = 200;
            d2.DoctorName = "Dr.Verma";
            d2.Specialization = "Darmatologist";
            d2.ConsultationFee = 500;

            Console.WriteLine("Doctor Id: " + d1.DoctorId);
            Console.WriteLine("Doctor Name: " + d1.DoctorName);
            Console.WriteLine("Specialization: " + d1.Specialization);
            Console.WriteLine("Consultation Fee: " + d1.ConsultationFee);

            Console.WriteLine();

            Console.WriteLine("Doctor Id: " + d2.DoctorId);
            Console.WriteLine("Doctor Name: " + d2.DoctorName);
            Console.WriteLine("Specialization: " + d2.Specialization);
            Console.WriteLine("Consultation Fee: " + d2.ConsultationFee);

        }
    }
}
