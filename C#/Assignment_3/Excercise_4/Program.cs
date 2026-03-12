namespace Excercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Appointment a1 = new Appointment();
            a1.AppointmentId = 1;
            a1.PatientName = "Rahul";

            Console.WriteLine("Appointment Id :" + a1.AppointmentId);
            Console.WriteLine("Patient Name: " + a1.PatientName);
            Console.WriteLine("Doctor Name: " + a1.DoctorName);
            Console.WriteLine("Appointment Date: " + a1.AppointmentDate.ToShortDateString());
        }
    }
}
