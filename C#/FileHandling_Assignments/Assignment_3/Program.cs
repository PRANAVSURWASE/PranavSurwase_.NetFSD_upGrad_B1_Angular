namespace Assignment_3
{
    internal class Program
    {
        static void CreateFile()
        {
            try
            {
                Console.Write("Enter file name: ");
                string fileName = Console.ReadLine() + ".txt";

                if (!File.Exists(fileName))
                {
                    using (FileStream fs = new FileStream(fileName, FileMode.Create))
                    {
                        Console.WriteLine("File created successfully.");
                    }
                }
                else
                {
                    Console.WriteLine("File already exists.");
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access denied.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void WriteFile()
        {
            try
            {
                Console.Write("Enter file name: ");
                string fileName = Console.ReadLine() + ".txt";

                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    Console.WriteLine("Enter text (type 'END' to stop):");

                    while (true)
                    {
                        string line = Console.ReadLine();

                        if (line.ToUpper() == "END")
                            break;

                        sw.WriteLine(line);
                    }
                }

                Console.WriteLine("Data written successfully.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access denied.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

       
        static void AppendFile()
        {
            try
            {
                Console.Write("Enter file name: ");
                string fileName = Console.ReadLine() + ".txt";

                using (FileStream fs = new FileStream(fileName, FileMode.Append))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    Console.WriteLine("Enter text to append (type 'END' to stop):");

                    while (true)
                    {
                        string line = Console.ReadLine();

                        if (line.ToUpper() == "END")
                            break;

                        sw.WriteLine(line);
                    }
                }

                Console.WriteLine("Data appended successfully.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access denied.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

       
        static void ReadFile()
        {
            try
            {
                Console.Write("Enter file name: ");
                string fileName = Console.ReadLine() + ".txt";

                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                using (StreamReader sr = new StreamReader(fs))
                {
                    Console.WriteLine("\n--- File Content ---");
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access denied.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

     
        static void DeleteFile()
        {
            try
            {
                Console.Write("Enter file name: ");
                string fileName = Console.ReadLine() + ".txt";

                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                    Console.WriteLine("File deleted successfully.");
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access denied.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n==== Mini Notepad ====");
                Console.WriteLine("1. Create New File");
                Console.WriteLine("2. Write to File");
                Console.WriteLine("3. Read File");
                Console.WriteLine("4. Append Text");
                Console.WriteLine("5. Delete File");
                Console.WriteLine("6. Exit");

                Console.Write("Enter choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        CreateFile();
                        break;

                    case 2:
                        WriteFile();
                        break;

                    case 3:
                        ReadFile();
                        break;

                    case 4:
                        AppendFile();
                        break;

                    case 5:
                        DeleteFile();
                        break;

                    case 6:
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

    }
    }

