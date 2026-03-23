namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 10, 15, 20, 25, 30 };

            var even = numbers.Where(n => n % 2 == 0);
            foreach(var i in even)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine();

            var greater = numbers.Where(n => n > 15);
            foreach(var i in greater)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            var squares = numbers.Select(n => n * n);
            foreach( var i in squares)
            {
                Console.WriteLine(i);


            }
            Console.WriteLine();

            int count = numbers.Count(n => n % 5 == 0);
            Console.WriteLine(count);
        




           

        }
    }
}
