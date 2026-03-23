namespace Assignment_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
{
    new Employee{ Id=1, Name="Ram", Department="IT", Salary=50000, JoiningDate=DateTime.Now.AddMonths(-2)},
    new Employee{ Id=2, Name="Shyam", Department="HR", Salary=40000, JoiningDate=DateTime.Now.AddMonths(-8)},
    new Employee{ Id=3, Name="Amit", Department="IT", Salary=70000, JoiningDate=DateTime.Now.AddMonths(-1)},
    new Employee{ Id=4, Name="Ravi", Department="HR", Salary=60000, JoiningDate=DateTime.Now.AddMonths(-3)}
};
            int totalEmployees = employees.Count();

            Console.WriteLine(totalEmployees);

            Console.WriteLine();

            var avgSalaryDept = employees
                    .GroupBy(e => e.Department)
                    .Select(g => new
                    {
                        Department = g.Key,
                        AvgSalary = g.Average(e => e.Salary)
                    });

            foreach (var item in avgSalaryDept)
            {
                Console.WriteLine($"Department: {item.Department}, Avg Salary: ₹{item.AvgSalary:F2}");
            }

            Console.WriteLine();

            var recent = employees
             .Where(e => e.JoiningDate >= DateTime.Now.AddMonths(-6));
            foreach (var item in recent)
            {

                Console.WriteLine(item);
            }

            Console.WriteLine();

            var highestPerDept = employees
                     .GroupBy(e => e.Department)
                     .Select(g => new
                     {
                         Department = g.Key,
                         Employee = g.OrderByDescending(e => e.Salary).First()
                     });

            foreach (var item in highestPerDept)
            {
                Console.WriteLine($"Department: {item.Department}");
                Console.WriteLine($"  Name: {item.Employee.Name}, Salary: ₹{item.Employee.Salary:F2}");
            }

            Console.WriteLine();

            var salaryStats = new
            {
                Min = employees.Min(e => e.Salary),
                Max = employees.Max(e => e.Salary),
                Avg = employees.Average(e => e.Salary)
            };
            Console.WriteLine($"Min Salary: ₹{salaryStats.Min:F2}");
            Console.WriteLine($"Max Salary: ₹{salaryStats.Max:F2}");
            Console.WriteLine($"Avg Salary: ₹{salaryStats.Avg:F2}");







        }
    }
}
