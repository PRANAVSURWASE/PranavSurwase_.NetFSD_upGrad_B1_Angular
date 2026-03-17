namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TotalSales ts = new TotalSales();

            Console.WriteLine("Daily Sales :Rs." + ts.DailySales());
            Console.WriteLine("Monthly Sales :Rs."+ts.MonthlySales());
            Console.WriteLine("Yearly Sales :Rs." + ts.YearlySales());
        }
    }
}
