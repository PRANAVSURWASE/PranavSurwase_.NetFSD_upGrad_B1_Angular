namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student{Id=1,Name="Pranav",Age=23,Marks=80},
                new Student{ Id=2, Name="Shyam", Age=17, Marks=70 },
                new Student{ Id=3, Name="Amit", Age=22, Marks=90 },
                new Student{ Id=4, Name="Ravi", Age=25, Marks=60 },
                new Student{ Id=5, Name="Kiran", Age=19, Marks=85 }

            };

            var res1 = students.Where(n => n.Marks > 75);
            foreach(Student i in res1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            var res2 = students.Where(n => n.Age >= 18 && n.Age <= 25);
            foreach(Student i in res2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            var res3 = students.OrderByDescending(s => s.Marks);
            foreach(Student s in res3)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();

            var res4 = students.Select(s => new { s.Name, s.Marks });
            foreach( var s in res4)
            {
                Console.WriteLine($"Name : {s.Name} Marks :{s.Marks}");
            }

            
        }
    }
}
