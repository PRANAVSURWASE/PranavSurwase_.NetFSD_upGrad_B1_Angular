namespace Assignment_2
{
    internal class Program
    {
        static string GetGrade(double avg)
        {
            if (avg >= 75) return "A";
            else if (avg >= 50) return "B";
            else if (avg >= 35) return "C";
            else return "Fail";
        }

        // Create Report
        static void CreateReport()
        {
            try
            {
                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Roll Number: ");
                string roll = Console.ReadLine();


                int m1 = ReadMarks("Enter Marks for Subject 1: ");
                int m2 = ReadMarks("Enter Marks for Subject 2: ");
                int m3 = ReadMarks("Enter Marks for Subject 3: ");

                int total = m1 + m2 + m3;
                double avg = total / 3.0;
                string grade = GetGrade(avg);

                string content =
                     $@"Student Name: {name}
                         Roll Number: {roll}
                         Marks: {m1}, {m2}, {m3}
                         Average: {avg:F2}
                         Grade: {grade}";

                string fileName = roll + ".txt";

                File.WriteAllText(fileName, content);

                Console.WriteLine("Report card generated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void ReadReport()
        {
            try
            {
                Console.Write("Enter Roll Number: ");
                string roll = Console.ReadLine();

                string fileName = roll + ".txt";

                if (!File.Exists(fileName))
                {
                    Console.WriteLine("Report not found.");
                    return;
                }

                string content = File.ReadAllText(fileName);

                Console.WriteLine("\n--- Student Report ---");
                Console.WriteLine(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        static int ReadMarks(string message)
        {
            int marks;

            while (true)
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out marks) && marks >= 0 && marks <= 100)
                {
                    return marks;
                }

                Console.WriteLine("Invalid marks! Enter value between 0 and 100.");
            }
        }
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n==== Student Report Card System ====");
                Console.WriteLine("1. Generate Report");
                Console.WriteLine("2. View Report");
                Console.WriteLine("3. Exit");

                Console.Write("Enter choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        CreateReport();
                        break;

                    case 2:
                        ReadReport();
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
