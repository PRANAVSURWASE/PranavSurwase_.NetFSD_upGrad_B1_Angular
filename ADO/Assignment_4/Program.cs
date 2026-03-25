namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ConnectionString = "Data Source=PRANAV-LAPTOP\\SQLEXPRESS;Initial Catalog=student_DB;Integrated Security=True;TrustServerCertificate=True";

            OrderManager manager = new OrderManager(ConnectionString);
            manager.PlaceOrder();
            
        }
    }
}
