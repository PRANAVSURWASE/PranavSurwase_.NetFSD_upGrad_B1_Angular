namespace Student_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, Student> students = new Dictionary<int, Student>();
            students.Add(1, new Student { Id = 1, Name = "Rahul", Marks = 80 });
            students.Add(2, new Student { Id = 2, Name = "Amit", Marks = 65 });
            students.Add(3, new Student { Id = 3, Name = "Sneha", Marks = 90 });
            students.Add(4, new Student { Id = 4, Name = "Priya", Marks = 70 });
            students.Add(5, new Student { Id = 5, Name = "Rohit", Marks = 85 });

            Console.WriteLine("Display All Students :");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nEnter student Id to search:");
            int id = int.Parse(Console.ReadLine());

            if (students.ContainsKey(id))
            {
                Console.WriteLine("Student Found:");
                Console.WriteLine(students[id]);

            }
            else
            {
                Console.WriteLine("Student not found");
            }

            Console.WriteLine("\nEnter Id to update marks:");
            int updateId = int.Parse(Console.ReadLine());

            if(students.ContainsKey(updateId))
            {
                Console.WriteLine("Enter New Marks");
                int marks = int.Parse(Console.ReadLine());
                students[updateId].Marks = marks;

                Console.WriteLine("Marks Updated");


            }
            else
            {
                Console.WriteLine("Student not Found ");

            }
            Console.WriteLine("\nStudents scoring above 75:");
            foreach(var student in students)
            {
                if(student.Value.Marks>75)
                {
                    Console.WriteLine(student.Value);
                }
            }
        }

        }
}
