namespace Assignment_2.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int studentId {  get; set; }

        public Student Student { get; set; }
    }
}
