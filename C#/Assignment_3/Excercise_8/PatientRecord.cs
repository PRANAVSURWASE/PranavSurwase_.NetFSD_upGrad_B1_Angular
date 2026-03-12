using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise_8
{
    internal class PatientRecord
    {
        public static string HospitalName;
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int age { get; set; }
        public string Disease { get; set; }

        public PatientRecord(int PatientId,String PatientName,int age,String Disease)
        {
            this.PatientId = PatientId;
            this.PatientName = PatientName;
            this.age = age;
            this.Disease = Disease;

        }

        public void DisplayPatientRecord()
        {
            Console.WriteLine("Hospital Name: " + HospitalName);
            Console.WriteLine("Patient Id :" + PatientId);
            Console.WriteLine("PatientName :" + PatientName);
            Console.WriteLine("Age :" + age);
            Console.WriteLine("Disease :" + Disease);

            Console.WriteLine();

        }


    }
}
