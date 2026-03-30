namespace Assignment_2.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int Age { get; set;}
        public string Email { get; set; }

        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
