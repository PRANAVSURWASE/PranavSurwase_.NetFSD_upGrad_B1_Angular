namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();
            try
            {
                acc.Transaction('c', 600);

            }catch(CheckBalanceException ex)
            {
                Console.WriteLine(ex.Message);

            }
            
        }
    }
}
