namespace Assignment_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>()
{
    new Order{ Id=1, CustomerName="Ram", OrderDate=DateTime.Now.AddDays(-10), TotalAmount=2000 },
    new Order{ Id=2, CustomerName="Shyam", OrderDate=DateTime.Now.AddDays(-40), TotalAmount=5000 },
    new Order{ Id=3, CustomerName="Ram", OrderDate=DateTime.Now.AddDays(-5), TotalAmount=3000 },
    new Order{ Id=4, CustomerName="Amit", OrderDate=DateTime.Now.AddDays(-2), TotalAmount=7000 }
};

            var recentOrders = orders
                   .Where(o => o.OrderDate >= DateTime.Now.AddDays(-30));
            foreach(var order in recentOrders)
            {
                Console.WriteLine(order);
            }

            Console.WriteLine();

            var monthlySales = orders
                   .GroupBy(o => new { o.OrderDate.Year, o.OrderDate.Month })
                   .Select(g => new
                   {
                       g.Key.Year,
                       g.Key.Month,
                       TotalSales = g.Sum(o => o.TotalAmount)
                   });

            foreach (var item in monthlySales)
            {
                Console.WriteLine($"Year: {item.Year}, Month: {item.Month}, Total Sales: {item.TotalSales}");
            }

            Console.WriteLine();

            var topCustomers = orders
                   .GroupBy(o => o.CustomerName)
                   .Select(g => new
                   {
                       Customer = g.Key,
                       Total = g.Sum(x => x.TotalAmount)
                   })
                   .OrderByDescending(x => x.Total)
                   .Take(5);

            foreach (var item in topCustomers)
            {
                Console.WriteLine($"Customer: {item.Customer}, Total Purchase: ₹{item.Total:F2}");
            }

            Console.WriteLine();
            var highestPerMonth = orders
                      .GroupBy(o => new { o.OrderDate.Year, o.OrderDate.Month })
                      .Select(g => new
                      {
                          g.Key.Year,
                          g.Key.Month,
                          MaxOrder = g.Max(o => o.TotalAmount)
                      });

            foreach (var item in highestPerMonth)
            {
                string monthName = new DateTime(item.Year, item.Month, 1).ToString("MMMM");

                Console.WriteLine($"Year: {item.Year}, Month: {monthName}, Highest Order: ₹{item.MaxOrder:F2}");
            }


        }
    }
}
