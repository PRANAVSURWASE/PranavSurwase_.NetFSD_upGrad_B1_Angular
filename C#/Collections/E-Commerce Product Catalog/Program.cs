namespace E_Commerce_Product_Catalog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id=1,Name="Laptop",Price=60000,Category="Electronics"},
                new Product{Id=2,Name="Mouse",Price=500,Category="Electronics"},
                new Product{Id=3,Name="Keyboard",Price=1200,Category="Electronics"},
                new Product{Id=4,Name="Headphones",Price=2000,Category="Electronics"},
                new Product{Id=5,Name="Smartphone",Price=25000,Category="Electronics"},
                new Product{Id=6,Name="Tablet",Price=15000,Category="Electronics"},
                new Product{Id=7,Name="Watch",Price=3000,Category="Accessories"},
                new Product{Id=8,Name="Bag",Price=800,Category="Accessories"},
                new Product{Id=9,Name="Shoes",Price=2500,Category="Fashion"},
                new Product{Id=10,Name="Printer",Price=7000,Category="Electronics"}
            };

            Console.WriteLine("All Products: ");
            foreach(var item in products)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nProducts with Price > 1000:");
            var product = products.FindAll(p => p.Price > 10000);
            foreach(var item in product)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nSorted by Price (Ascending):");
            var asc = products.OrderBy(p => p.Price);
            foreach(var item in asc)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nSorted by Price (descending):");
            var desc = products.OrderByDescending(p => p.Price);
            foreach(var item in desc)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("ENter Id to Remove ");
            int id = int.Parse(Console.ReadLine());

            var prodx = products.Find(p => p.Id == id);

            if(prodx !=null)
            {
                products.Remove(prodx);
                Console.WriteLine("Product Removed.. ");
            }
            else
            {
                Console.WriteLine("Product not Found");
            }

            Console.WriteLine("\nRemaining Products");
            foreach(var item in products)
            {
                Console.WriteLine(item);
            }




        }
    }
}
