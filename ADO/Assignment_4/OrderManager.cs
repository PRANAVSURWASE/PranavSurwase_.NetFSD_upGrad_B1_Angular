using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
namespace Assignment_4
{
    internal class OrderManager
    {
        private string connectionString;

        public OrderManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void PlaceOrder()
        {
            using (SqlConnection conn = new SqlConnection(connectionString)) 
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand orderCmd = new SqlCommand("Insert into Orders(CustomerName,TotalAmount) OUTPUT INSERTED.OrderId values(@Name,@Amount)",  conn, transaction);

                    orderCmd.Parameters.AddWithValue("@Name", "alex");
                    orderCmd.Parameters.AddWithValue("@Amount", 67000);

                    int orderId = (int)orderCmd.ExecuteScalar();

                    Console.WriteLine("Order Inserted with ID :" + orderId);

                    SqlCommand itemCmd = new SqlCommand("Insert into orderitems(orderID,ProductName,Quantity) values(@orderID,@Product,@Qty)",conn,transaction);
                    itemCmd.Parameters.AddWithValue("@OrderId",orderId);
                    itemCmd.Parameters.AddWithValue("@Product","Laptop");
                    itemCmd.Parameters.AddWithValue("@Qty", 1);

                    itemCmd.Parameters.Clear();

                    itemCmd.Parameters.AddWithValue("@OrderId",orderId);
                    itemCmd.Parameters.AddWithValue("@Product", "Moblie");
                    itemCmd.Parameters.AddWithValue("@Qty", 2);
                    itemCmd.ExecuteNonQuery();  

                    transaction.Commit();

                    Console.WriteLine("Traanscation Successful");





                }
                catch (Exception ex)
                {

                    transaction.Rollback();
                    Console.WriteLine("Transaction Failed ");
                    Console.WriteLine(ex.Message);
                        

                }
            }
        }

    }
}
