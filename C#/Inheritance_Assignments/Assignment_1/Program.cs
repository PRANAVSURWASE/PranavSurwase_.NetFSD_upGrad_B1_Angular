namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor d = new Doctor();
            d.StaffId = 1;
            d.Name = "Dr.Smit";
            d.BaseSalary = 78000;
            d.ConsultationFee = 1300;

            Nurse n  = new Nurse();
            n.StaffId = 2;
            n.Name = "Mary";
            n.BaseSalary = 34000;
            n.NightShiftAllowance = 5000;

            LabTechnician lt = new LabTechnician();
            lt.StaffId = 3;
            lt.Name = "Jhon";
            lt.BaseSalary = 30000;
            lt.EquipmentAllowance = 8000;

            Staff[] staffList = { d, n, lt };

            foreach(Staff staff in staffList)
            {
                Console.WriteLine($"Staff Name :{staff.Name}");
                Console.WriteLine($"Total Salary:{staff.CalculateSalary()}");
                Console.WriteLine();

            }


        }
    }
}
