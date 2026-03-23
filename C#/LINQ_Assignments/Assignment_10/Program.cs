namespace Assignment_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
{
    new Employee{ Id=1, Name="Ram", Department="IT", Salary=50000 },
    new Employee{ Id=2, Name="Shyam", Department="HR", Salary=40000 },
    new Employee{ Id=3, Name="Amit", Department="IT", Salary=70000 },
    new Employee{ Id=4, Name="Ravi", Department="HR", Salary=60000 }
};

            var sorted = employees
             .OrderBy(e => e.Department)
             .ThenByDescending(e => e.Salary);

            foreach (Employee emp in sorted)
            {
                Console.WriteLine($"Dept: {emp.Department}, Name: {emp.Name}, Salary: ₹{emp.Salary:F2}");
            }



        

        }
    }
}
