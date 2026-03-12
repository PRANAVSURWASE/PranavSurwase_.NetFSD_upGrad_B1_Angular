namespace Excercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MedicalTest t1 = new MedicalTest(1, "Blood Test", 500);
            MedicalTest t2 = new MedicalTest(2, "X-Ray", 800);

            t1.Display();
            t2.Display();
        }
    }
}
