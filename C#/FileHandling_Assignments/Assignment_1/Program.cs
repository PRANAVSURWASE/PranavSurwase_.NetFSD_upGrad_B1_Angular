using System.IO;
using System.Collections.Generic;
using System;

namespace Assignment_1
{
    internal class Program
    {
        static string filePath = "employee_log.txt";

        static void AddLogin()
        {
            try
            {
                Console.WriteLine("Enter Employee Id:");
                string id = Console.ReadLine();

                Console.Write("Enter Name :");
                string name = Console.ReadLine();

                string loginTime = DateTime.Now.ToString("dd-MM-yyyy HH:mm");

                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine($"{id} | {name} | {loginTime} | -");

                }
                Console.WriteLine("Login recorded successfully.");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }
            finally
            {
                Console.WriteLine("AddLogin operation completed.\n");
            }
        }

        static void ViewLogs()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("No logs found.");
                    return;
                }

                using (StreamReader sr = new StreamReader(filePath))
                {
                    Console.WriteLine("\n--- Employee Logs ---");
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("ViewLogs operation completed.\n");
            }
        }
        static void UpdateLogout()
        {
            try
            {
                Console.Write("Enter Employee Id: ");
                string id = Console.ReadLine();

                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File not found.");
                    return;
                }

                string[] lines = File.ReadAllLines(filePath);
                List<string> updatedLines = new List<string>();
                bool updated = false;

                foreach (var line in lines)
                {
                    string[] parts = line.Split('|');

                    if (parts.Length == 4 && parts[0].Trim() == id && parts[3].Trim() == "-")
                    {
                        string logoutTime = DateTime.Now.ToString("dd-MM-yyyy HH:mm");

                        updatedLines.Add($"{parts[0].Trim()} | {parts[1].Trim()} | {parts[2].Trim()} | {logoutTime}");
                        updated = true;
                    }
                    else
                    {
                        updatedLines.Add(line);
                    }
                }

                File.WriteAllLines(filePath, updatedLines);

                if (updated)
                    Console.WriteLine("Logout updated successfully.");
                else
                    Console.WriteLine("No active login found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("UpdateLogout operation completed.\n");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("====Employee Log System=======");
                Console.WriteLine("1,Add Login");
                Console.WriteLine("2.Update Logout");
                Console.WriteLine("3.View Logs");
                Console.WriteLine("4.Exit");

                Console.Write("Enter choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddLogin();
                        break;

                    case 2:
                        UpdateLogout();
                        break;
                       
                        break;

                    case 3:
                        ViewLogs();
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            }
        }
    }
}

