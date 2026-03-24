using Microsoft.Data.SqlClient;
using System.Data;

namespace Assignment_3
{
    internal class Program
    {
        static string connectionString = "Data Source=PRANAV-LAPTOP\\SQLEXPRESS;Initial Catalog=Student_Db;Integrated Security=True;Trust Server Certificate=True";
        static SqlDataAdapter adapter;
        static DataSet ds;

        static void Main(string[] args)
        {
            LoadData();

            while (true)
            {
                Console.WriteLine("\nProduct Inventory System");
                Console.WriteLine("1. Show Products");
                Console.WriteLine("2. Add Product");
                Console.WriteLine("3. Update Price");
                Console.WriteLine("4. Delete Product");
                Console.WriteLine("5. Save Changes");
                Console.WriteLine("6. Exit");

                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Display();
                        break;
                    case 2:
                        AddProduct();
                        break;
                    case 3:
                        UpdateProduct();
                        break;
                    case 4:
                        DeleteProduct();
                        break;
                    case 5:
                        SaveChange();
                        break;
                    case 6:
                        return;
                }
            }
        
            static void LoadData()
            {
                SqlConnection conn = new SqlConnection(connectionString);
                adapter = new SqlDataAdapter("Select * from Products", conn);

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                
                ds = new DataSet();
                adapter.Fill(ds, "Products");

            }

            static void Display()
            {
                DataTable table = ds.Tables["Products"];
                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine($"{row["ProductId"]}  | {row["ProductName"]} | {row["Price"]} | {row["Stock"]}");
                }

            }

            static void AddProduct()
            {
                DataTable table = ds.Tables["Products"];

                DataRow newRow = table.NewRow();

                Console.Write("Product Name: ");
                newRow["ProductName"] = Console.ReadLine();

                Console.Write("Price: ");
                newRow["Price"] = decimal.Parse(Console.ReadLine());

                Console.Write("Stock: ");
                newRow["Stock"] = int.Parse(Console.ReadLine());

                table.Rows.Add(newRow);

                Console.WriteLine("Product added (offline)");

            }

            static void UpdateProduct()
            {
                DataTable table = ds.Tables["Products"];

                Console.Write("Enter ProductId: ");
                int id = int.Parse(Console.ReadLine());

                foreach (DataRow row in table.Rows)
                {
                    if (row["ProductId"] != DBNull.Value &&
     Convert.ToInt32(row["ProductId"]) == id)
                    {
                        Console.Write("New Price: ");
                        row["Price"] = decimal.Parse(Console.ReadLine());
                        break;
                    }
                }

                Console.WriteLine("Updated (offline)");
            }

            static void DeleteProduct()
            {
                DataTable table = ds.Tables["Products"];

                Console.WriteLine("Enter ProductId");
                int id = int.Parse(Console.ReadLine());
                foreach(DataRow row in table.Rows)
                {
                    if ((int)row["ProductId"] ==id)
                    {
                        row.Delete();
                        break;
                    }
                }
                Console.WriteLine("Product Deleted SuccessFully");

            }
            static void SaveChange()
            {
                adapter.Update(ds,"Products");
                Console.WriteLine("Changes saved to Database");
            }





        }
    }
}
