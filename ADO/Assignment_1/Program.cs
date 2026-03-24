using Assignment_1.Models;
using Assignment_1.Repository;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentRepository repo = new StudentRepository();

            while (true)
            {
                Console.WriteLine("\nStudent Management System");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Update Student Grade");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Enter your Choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Student s = new Student();
                        Console.Write("Name: ");
                        s.Name = Console.ReadLine();

                        Console.Write("Age: ");
                        s.Age = int.Parse(Console.ReadLine());

                        Console.Write("Grade: ");
                        s.Grade = Console.ReadLine();

                        repo.AddStudent(s);
                        Console.WriteLine("Student Added!");
                        break;

                    case 2:
                        var students = repo.GetStudents();
                        foreach (var st in students)
                        {
                            Console.WriteLine($"{st.Id} | {st.Name} | {st.Age} | {st.Grade}");
                        }
                        break;

                    case 3:
                        Console.Write("Enter Id: ");
                        int id = int.Parse(Console.ReadLine());

                        Console.Write("New Grade: ");
                        string grade = Console.ReadLine();

                        repo.UpdateStudent(id, grade);
                        Console.WriteLine("Updated!");
                        break;

                    case 4:
                        Console.Write("Enter Id: ");
                        id = int.Parse(Console.ReadLine());

                        repo.DeleteStudent(id);
                        Console.WriteLine("Deleted!");
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
            }
        }
    }
}
