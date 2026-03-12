namespace Excercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hospital.HospitalName = "City Care Hospital";
            Hospital.HospitalAddress = "Mumbai";

            Hospital h1 = new Hospital();
            Hospital h2 = new Hospital();
            Hospital h3 = new Hospital();

            h1.patientName = "Ravi";
            h2.patientName = "Amit";
            h3.patientName = "Suresh";

            Console.WriteLine("Hospital :" + Hospital.HospitalName);
            Console.WriteLine("Address :" + Hospital.HospitalAddress);
            Console.WriteLine("Patient :" + h1.patientName);

            Console.WriteLine("Hospital :" + Hospital.HospitalName);
            Console.WriteLine("Address :" + Hospital.HospitalAddress);
            Console.WriteLine("Patient :" + h2.patientName);

            Console.WriteLine("Hospital :" + Hospital.HospitalName);
            Console.WriteLine("Address :" + Hospital.HospitalAddress);
            Console.WriteLine("Patient :" + h3.patientName);


        }
    }
}
