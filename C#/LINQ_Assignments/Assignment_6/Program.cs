namespace Assignment_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 2, 4, 5, 3, 6 };

            var unique = numbers.Distinct();
            foreach(int i in unique)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            var duplicates = numbers.
                GroupBy(n => n)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key);
            foreach(int i in duplicates)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            var CountOcc = numbers
               .GroupBy(n => n)
               .Select(g => new
               {
                   Number = g.Key,
                   Count = g.Count()

               });

            foreach(var i in  CountOcc)
            {
                Console.WriteLine($"{i.Number} {i.Count} ");
            }



        }
    }
}
