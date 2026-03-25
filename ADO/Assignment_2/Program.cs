namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=PRANAV-LAPTOP\\SQLEXPRESS;Initial Catalog=Student_db;Integrated Security=True;TrustServerCertificate=True;";
            EmployeeManager empManager = new EmployeeManager(connectionString);

            /* empManager.InsertEmployee("Alice", 34000, "IT");*/
            //empManager.InsertEmployee("Bob", 27560, "IT");
           // empManager.InsertEmployee("Vaibhav", 23000, "HR");

     /*       Console.WriteLine("Employees in IT ");
            empManager.GetEmployeesByDepartment("HR");*/

            Console.WriteLine("Updated Salary");
            empManager.UpdateSalary(4,30000);


            Console.WriteLine("Enter Employee ID  to Delete ");
            int empId = Convert.ToInt32(Console.ReadLine());

            empManager.DeleteEmployee(empId);






        }
    }
}
