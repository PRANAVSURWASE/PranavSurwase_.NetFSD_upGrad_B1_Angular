namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int availableTickets = 15;
            int bookedTicket;

            Console.WriteLine("Do you want to  Book Tickets ? ");
            string choice = Console.ReadLine(); 

            if(choice.ToLower() =="yes")
            {
                Console.WriteLine("How many Tickets Do you want to Book ?");
                bookedTicket = Convert.ToInt32(Console.ReadLine());

                try
                {
                    if(bookedTicket>availableTickets)
                    {
                        throw new Exception("Tickets not available");
                    }
                    else
                    {
                        availableTickets -= bookedTicket;
                        Console.WriteLine("Tickets Booked SuceessFully... ");
                        Console.WriteLine("Remaining Tickets :" + availableTickets);
                    }

                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);


                }

            }
            else
            {
                Console.WriteLine("Thank you....");
            }

        }
    }
}
