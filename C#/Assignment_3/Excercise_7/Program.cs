namespace Excercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nurse n1 = new Nurse
            {
                NurseId = 301,
                NurseName = "Anita",
                Department = "Emergency"
            };

            Console.WriteLine("Nurse Id: " + n1.NurseId);
            Console.WriteLine("Nurse Name: " + n1.NurseName);
            Console.WriteLine("Department :" + n1.Department);


        }
    }
}
