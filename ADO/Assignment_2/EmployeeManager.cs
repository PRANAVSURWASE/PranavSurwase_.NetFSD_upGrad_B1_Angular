using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;
namespace Assignment_2
{
    internal class EmployeeManager
    {
        private string connectionString;
        public EmployeeManager(string connStr)
        {
            connectionString = connStr;
        }
        public void InsertEmployee(string name,decimal salary,string dept)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("InsertEmployee", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Salary", salary);
                cmd.Parameters.AddWithValue("@Department", dept);
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee Inserted");
            }
        }

        public void GetEmployeesByDepartment(string dept)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetEmployeesByDepartment", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Department", dept);
                SqlDataAdapter ds = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ds.Fill(dt);
                foreach(DataRow row in dt.Rows)
                {
                    Console.WriteLine($"{row["EmpId"]} {row["Name"]} {row["Salary"]} {row["Department"]}");
                }
            }
        }

        public void UpdateSalary(int empId,decimal salary)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UpdateEmployeeSalary",conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmpId", empId);
                cmd.Parameters.AddWithValue("@Salary", salary);

                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Salary Updated ");
            }
        }

        public void DeleteEmployee(int empId)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Delete from Employees where empId = @EmpId ",conn);
                cmd.Parameters.AddWithValue("@EmpId", empId);

                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("EMployee Deleted");
            }
        }



        
    }
}
