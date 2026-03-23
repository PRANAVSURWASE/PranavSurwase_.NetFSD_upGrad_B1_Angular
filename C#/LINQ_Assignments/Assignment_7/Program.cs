namespace Assignment_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
{
    new Product{ Id=1, Name="Laptop", Category="Electronics", Price=70000, Stock=5 },
    new Product{ Id=2, Name="Phone", Category="Electronics", Price=30000, Stock=15 },
    new Product{ Id=3, Name="Shirt", Category="Clothing", Price=1500, Stock=8 },
    new Product{ Id=4, Name="Jeans", Category="Clothing", Price=2500, Stock=20 },
    new Product{ Id=5, Name="TV", Category="Electronics", Price=50000, Stock=2 }
};

            var lowStock = products.Where(s => s.Stock < 10);
            foreach(var product in lowStock)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine();

            var top3 = products.OrderByDescending(p => p.Price).Take(3);
            foreach(var i in top3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            var group = products.GroupBy(p => p.Category);
            foreach(var i in group)
            {
                Console.WriteLine("Category :"+i.Key);
                foreach(var p in i )
                {
                    Console.WriteLine($"  {p.Name} - {p.Price} - Stock: {p.Stock}");

                }
            }

            Console.WriteLine();

            var stockPerCategory = products.
                GroupBy(p => p.Category)
                .Select(g => new
                {
                    Category=g.Key,
                    TotalStock = g.Sum(p=>p.Stock)

                });

            Console.WriteLine();

            bool isOutOfStock = products.Any(p => p.Stock == 0);




        }
    }
}
