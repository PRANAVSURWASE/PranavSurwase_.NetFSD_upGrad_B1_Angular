namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new SavingAccount();
            acc.AccountNumber = 34532212;
            acc.Balance = 65453;

            acc.CalculateInterest();

            Console.WriteLine();

            SavingAccount sa = new SavingAccount();
            sa.AccountNumber = 5353322;
            sa.Balance = 12000;

            Console.WriteLine();

            CurrentAccount ca = new CurrentAccount();
            ca.AccountNumber = acc.AccountNumber;
            ca.Balance = acc.Balance;
        }
    }
}
