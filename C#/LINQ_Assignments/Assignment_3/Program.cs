namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Ravi", "Kiran", "Amit", "Raj", "Anil" };

            var startsWithA = names.Where(n => n.StartsWith("A"));

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            var sorted = names.OrderBy(n => n);
            foreach (var name in sorted)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
            var upper = names.Select(n => n.ToUpper());
            foreach(var name in upper)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            var laonNames = names.Where(n => n.Length > 4);
            foreach (var i in laonNames)
            {
                Console.WriteLine(i);
                
            }



        }
    }
}
