namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TCS t = new TCS(101, "Vaibhav", "IT", "Developer", 50000);
            Console.WriteLine("------ TCS Employee Details ------");
            Console.WriteLine("EmpId: " + t.EmpId);
            Console.WriteLine("Name: " + t.Name);
            Console.WriteLine("Department: " + t.Dept);
            Console.WriteLine("Designation: " + t.Desg);
            Console.WriteLine("Basic Salary: " + t.BasicSalary);

            Console.WriteLine("\nPF Details:");
            t.EmployeePF(t.BasicSalary);

            Console.WriteLine("\nLeave Details:");
            Console.WriteLine(t.LeaveDetails());

            Console.WriteLine("\nGratuity Amount: " + t.gratuityAmount(7, t.BasicSalary));

            Console.WriteLine();

            Accenture a = new Accenture(102, "Rahul", "HR", "Manager", 60000);

            Console.WriteLine("------ Accenture Employee Details ------");
            Console.WriteLine("EmpId: " + a.EmpId);
            Console.WriteLine("Name: " + a.Name);
            Console.WriteLine("Department: " + a.Dept);
            Console.WriteLine("Designation: " + a.Desg);
            Console.WriteLine("Basic Salary: " + a.BasicSalary);

            Console.WriteLine("\nPF Details:");
            a.EmployeePF(a.BasicSalary);

            Console.WriteLine("\nLeave Details:");
            Console.WriteLine(a.LeaveDetails());

            Console.WriteLine("\nGratuity Amount: " + a.gratuityAmount(10, a.BasicSalary));


        }
    }
}
