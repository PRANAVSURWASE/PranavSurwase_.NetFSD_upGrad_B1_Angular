namespace Assignment_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Chair");
            Console.WriteLine("2.Cot");
            Console.WriteLine("Enter choice ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if(choice ==1)
            {
                Chair c = new Chair();
                c.getData();
                c.showData();
            }
            else if(choice ==2)
            {
                Cot c = new Cot();
                c.getData();
                c.showData();
            }
            else
            {
                Console.WriteLine("Invalid Choice..");

            }
            
        }
    }
}
