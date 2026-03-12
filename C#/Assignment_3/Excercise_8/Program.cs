namespace Excercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PatientRecord.HospitalName = "Apollo Hospital ";
            PatientRecord PR1 = new PatientRecord(101,"Alex",67,"Fever");
            PatientRecord PR2 = new PatientRecord(102, "Jhon", 55, "Diebetes");
            PatientRecord PR3 = new PatientRecord(103, "David", 70, "Blood Pressure");

            PR1.DisplayPatientRecord();
            PR2.DisplayPatientRecord();
            PR3.DisplayPatientRecord();


        }
    }
}
