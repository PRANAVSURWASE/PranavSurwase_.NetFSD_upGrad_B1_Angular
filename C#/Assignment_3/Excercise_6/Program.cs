namespace Excercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Billing b1 = new Billing();

            b1.PatientName = "Ramesh";
            b1.ConsultationFee = 500;
            b1.TestCharges = 1000;

            b1.CalculateTotalBill();
        }
    }
}
