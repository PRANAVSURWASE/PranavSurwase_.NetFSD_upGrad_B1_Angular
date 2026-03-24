using System;
using System.Collections.Generic;
using System.Text;
using Assignment_5.Model;
using Microsoft.Data.SqlClient;

namespace Assignment_5.Repository
{
    internal class BookRepository
    {
        string connectionString = "Data Source=PRANAV-LAPTOP\\SQLEXPRESS;Initial Catalog=Student_Db;Integrated Security=True;Trust Server Certificate=True";
        public void AddBook(Book book)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string qry = "Insert into Books(Title ,Author,Price) values (@Title,@Author,@Price)";
                using (SqlCommand cmd = new SqlCommand(qry,conn))
                {
                    cmd.Parameters.AddWithValue("@Title", book.Title);
                    cmd.Parameters.AddWithValue("@Author", book.Author);
                    cmd.Parameters.AddWithValue("@Price", book.Price);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            
        }
        public List<Book> GetBooks()
        {
            List<Book> list = new List<Book>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string qry = "Select * from Books";
                using (SqlCommand cmd = new SqlCommand(qry,conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        list.Add(new Book
                        {
                            BookId = Convert.ToInt32(reader["BookId"]),
                            Title = reader["Title"].ToString(),
                            Author = reader["Author"].ToString(),
                            Price= Convert.ToDecimal(reader["Price"])


                        });

                    }
                }
            }
            return list;

        }
        public void UpdateBook(int id,string title,string author,decimal price)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string qry = "Update Books set Title = @Title, Author=@Author, Price=@Price where BookId=@BookId";

                using(SqlCommand cmd = new SqlCommand(qry,conn))
                {
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Author", author);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@BookId", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();


                }
            }
        }

        public void DeleteBook(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string qry = "Delete from Books where BookId =@Id";
                using(SqlCommand cmd = new SqlCommand(qry,conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Book> SearchBook(string name)
        {
            List<Book> list = new List<Book>();
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                string qry = "Select * from Books where Title Like @Name";
                using (SqlCommand cmd = new SqlCommand(qry, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", "%" + name + "%");
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        list.Add(new Book
                        {
                            BookId = Convert.ToInt32(reader["BookId"]),
                            Title = reader["Title"].ToString(),
                            Author = reader["Author"].ToString(),
                            Price = Convert.ToDecimal(reader["Price"])
                        });
                    }
                }
            }
            return list;
        }


    }
}
