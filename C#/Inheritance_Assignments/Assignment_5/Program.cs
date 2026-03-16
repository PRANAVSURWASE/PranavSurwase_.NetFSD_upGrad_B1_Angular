namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] student =
            {
                new SchoolStudent(1,"Rahul",45),
                new CollegeStudent(2,"Amit",55),
                new OnlineStudent(3,"Neha",56)
            };

            foreach(Student s in student)
            {
                s.CalculateGrade
                    ();
            }
            
        }
    }
}
