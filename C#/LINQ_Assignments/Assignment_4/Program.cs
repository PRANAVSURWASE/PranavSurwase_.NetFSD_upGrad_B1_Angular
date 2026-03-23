namespace Assignment_4
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
    new Employee{ Id=4, Name="Ravi", Department="Sales", Salary=45000 },
    new Employee{ Id=5, Name="Kiran", Department="HR", Salary=60000 }
};

            var itEmp = employees.Where(e => e.Department == "IT");
            foreach (Employee emp in itEmp)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine();

            var HighestSal = employees.OrderByDescending(emp=>emp.Salary).First();
            Console.WriteLine(HighestSal);

            Console.WriteLine();

            double avgSal = employees.Average(e => e.Salary);
            Console.WriteLine(avgSal);

            var grouped = employees.GroupBy(e=>e.Salary);
            foreach(var group in  grouped)
            {
                Console.WriteLine(group.Key);
                foreach(var emp in group)
                {
                    Console.WriteLine(emp.Name);
                }
            }
            Console.WriteLine() ;

            var deptCount = employees
                .GroupBy(e => e.Department)
                .Select(g => new { Dept = g.Key, Count = g.Count() });

            foreach (var d in deptCount)
            {
                Console.WriteLine($"{d.Dept} : {d.Count}");
            }


        }
    }
}
