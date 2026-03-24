using System;
using System.Collections.Generic;
using System.Text;
using Assignment_1.Models;
using Microsoft.Data.SqlClient;

namespace Assignment_1.Repository
{
    internal class StudentRepository
    {
        string connectionString = "Data Source=PRANAV-LAPTOP\\SQLEXPRESS;Initial Catalog=Student_db;Integrated Security=True;Trust Server Certificate=True";
     

        public void AddStudent(Models.Student student)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString)) 
                {
                    string qry = "Insert into Students(Name,Age,Grade) values(@Name,@Age,@Grade)";
                    using (SqlCommand cmd = new SqlCommand(qry, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", student.Name);
                        cmd.Parameters.AddWithValue("@Age", student.Age);
                        cmd.Parameters.AddWithValue("@Grade", student.Grade);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
           
           
        }

        public List<Student> GetStudents()
        {
            List<Student>list = new List<Student>();
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                string qry = "Select * from Students";
                using(SqlCommand cmd = new SqlCommand(qry,conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        list.Add(new Student
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Age = Convert.ToInt32(reader["Age"]),
                            Grade = reader["Grade"].ToString()

                        });
                    }
                }
            }
            return list;
        }

        public void UpdateStudent(int id ,string grade)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string qry = "update Students set grade = @Grade where Id= @Id";
                using (SqlCommand cmd = new SqlCommand(qry, conn))
                {
                    cmd.Parameters.AddWithValue("@Grade", grade);
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();

                }

            }
            
        }
        public void DeleteStudent(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string qry = "Delete from students where Id =@Id";
                using (SqlCommand cmd = new SqlCommand(qry, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();

                }
            }
        }
    }
}
