using Assignment_5.Model;
using Assignment_5.Repository;

namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookRepository repo = new BookRepository();
            while(true)
            {
                Console.WriteLine("\nLibrary Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. View Books");
                Console.WriteLine("3. Update Book");
                Console.WriteLine("4. Delete Book");
                Console.WriteLine("5. Search Book");
                Console.WriteLine("6. Exit");

                int ch = int.Parse(Console.ReadLine());

                switch(ch)
                {
                    case 1:
                        Book b = new Book();
                        Console.WriteLine("Enter Title");
                        b.Title = Console.ReadLine();

                        Console.WriteLine("Author");
                        b.Author = Console.ReadLine();

                        Console.WriteLine("Price");
                        b.Price = decimal.Parse(Console.ReadLine());

                        repo.AddBook(b);
                        Console.WriteLine("Book Added !");
                       


                        break;

                    case 2:
                        var books = repo.GetBooks();
                        foreach(var item in books)
                        {
                            Console.WriteLine($"{item.BookId}  |  {item.Title} |  {item.Author} | {item.Price}");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter Id");
                        int id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Title");
                        string title = Console.ReadLine();

                        Console.WriteLine("New Author");
                        String author = Console.ReadLine();

                        Console.WriteLine("New Price ");
                        decimal price = decimal.Parse(Console.ReadLine());

                        repo.UpdateBook(id, title, author, price);
                        Console.WriteLine("Updated !!");


                        break;

                    case 4:
                        Console.WriteLine("Enter ID");
                        id = int.Parse(Console.ReadLine());

                        repo.DeleteBook(id);
                        Console.WriteLine("Deleted !");

                        
                        break;

                    case 5:
                        Console.WriteLine("Enter Name");
                        string name = Console.ReadLine();
                        var res = repo.SearchBook(name);
                        foreach( var i in res)
                        {
                            Console.WriteLine($"{i.BookId} | {i.Title} | {i.Author}  | {i.Price}");
                        }
                        break;

                    case 6:
                        Environment.Exit(0);
                        break;
                }

            }
        }
    }
}
