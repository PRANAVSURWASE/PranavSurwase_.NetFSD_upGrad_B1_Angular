namespace Hospital_Patient_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Patient> patients = new Queue<Patient>();
            patients.Enqueue(new Patient{ Id=1,Name="Rahul",Disease="Fever"});
            patients.Enqueue(new Patient { Id = 2, Name = "Sneha", Disease = "Cold" });
            patients.Enqueue(new Patient { Id = 3, Name = "Amit", Disease = "Headache" });
            patients.Enqueue(new Patient { Id = 4, Name = "Priya", Disease = "Cough" });
            patients.Enqueue(new Patient { Id = 5, Name = "Rohit", Disease = "Stomach Pain" });

            Console.WriteLine("All Patient in Queue");
            foreach(var p in patients)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("\nServing Patient");
            for(int i=0;i<2;i++)
            {
                if (patients.Count > 0)
                {
                    Console.WriteLine("Served: " + patients.Dequeue());
                }
            }

            if(patients.Count > 0)
            {
                Console.WriteLine("\nNext Patient " + patients.Peek());
            }

            Console.WriteLine("Show Remaining Patients");
            foreach(var p in patients)
            {
                Console.WriteLine(p);
            }

        }
    }
}
