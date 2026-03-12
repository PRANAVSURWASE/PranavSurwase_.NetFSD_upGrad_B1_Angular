namespace Excercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor d1 = new Doctor();
            d1.DoctorId = 201;
            d1.DoctorName = "Dr. Sharma";
            d1.Specialization = "Cardiologist";
            d1.ConsultationFee = 500;

            Doctor d2 = new Doctor();
            d2.DoctorId = 202;
            d2.DoctorName = "Dr. Mehta";
            d2.Specialization = "Dermatologist";
            d2.ConsultationFee = 400;

            
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
