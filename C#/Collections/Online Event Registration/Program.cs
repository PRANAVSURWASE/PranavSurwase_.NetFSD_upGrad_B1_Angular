namespace Online_Event_Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> emails = new HashSet<string>();

            emails.Add("john@gmail.com");
            emails.Add("alice@gmail.com");
            emails.Add("bob@gmail.com");
            emails.Add("john@gmail.com");
            emails.Add("sara@gmail.com");
            emails.Add("rahul@gmail.com");
            emails.Add("priya@gmail.com");
            emails.Add("bob@gmail.com"); 
            emails.Add("amit@gmail.com");
            emails.Add("neha@gmail.com");

            Console.WriteLine("Display Unique Emails :");
            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }

            Console.WriteLine("Checking Specific email is registered ");
            string seachEmail = Console.ReadLine();
            if(emails.Contains(seachEmail))
            {
                Console.WriteLine("Email is Registered");
            }
            else
            {
                Console.WriteLine("Email  is not Registered ");
            }

            Console.WriteLine("Remove an Email ");
            string removeEmail = Console.ReadLine();
            if(emails.Contains(removeEmail))
            {
                emails.Remove(removeEmail);
                Console.WriteLine("Email Removed Successfully");
            }
            else
            {
                Console.WriteLine("Email not Found");
            }

            Console.WriteLine("\n Updated Email List ");
            foreach (string email in emails)
            {
                Console.WriteLine(email);

            }
                
        }
    }
}
