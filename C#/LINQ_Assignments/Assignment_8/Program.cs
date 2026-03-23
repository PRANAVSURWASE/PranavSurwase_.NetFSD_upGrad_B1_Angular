namespace Assignment_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
{
    new Student{ Id=1, Name="Ram", Class="10", Subject="Math", Marks=80 },
    new Student{ Id=2, Name="Shyam", Class="10", Subject="Math", Marks=70 },
    new Student{ Id=3, Name="Amit", Class="10", Subject="Science", Marks=90 },
    new Student{ Id=4, Name="Ravi", Class="9", Subject="Math", Marks=60 },
    new Student{ Id=5, Name="Kiran", Class="9", Subject="Science", Marks=75 }
};

            var multiGroup = students
                .GroupBy(s => s.Class)
                .Select(cg => new
                {
                    Class = cg.Key,
                    Subjects = cg.GroupBy(s=>s.Subject)

                });

            foreach (var cls in multiGroup)
            {
                Console.WriteLine($"Class: {cls.Class}");

                foreach (var sub in cls.Subjects)
                {
                    Console.WriteLine($"  Subject: {sub.Key}");

                    foreach (var student in sub)
                    {
                        Console.WriteLine($"    Name: {student.Name}, Marks: {student.Marks}");
                    }
                }
            }

            var avgMarks = students
               .GroupBy(s => new { s.Class, s.Subject })
               .Select(g => new
               {
                   g.Key.Class,
                   g.Key.Subject,
                   AvgMarks = g.Average(x => x.Marks)
               });

            foreach (var item in avgMarks)
            {
                Console.WriteLine($"Class: {item.Class}, Subject: {item.Subject}, Avg Marks: {item.AvgMarks}");
            }



        }

        
    }
}
