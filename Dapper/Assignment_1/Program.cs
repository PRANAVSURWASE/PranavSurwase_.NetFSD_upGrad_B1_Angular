using System;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using Dapper;

namespace Assignment_1
{
    public class Book
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public decimal Price { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public string? Language { get; set; }
        public DateTime PublishDate { get; set; }
    }

    internal class Program
    {
        private static string connectionString =
            "Data Source=PRANAV-LAPTOP\\SQLEXPRESS;" +
            "Initial Catalog=testdb;" +
            "Integrated Security=True;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True;";

        static void Main(string[] args)
        {
            new Program().Menu();
        }

        // ================= MENU =================
        private void Menu()
        {
            while (true)
            {
                Console.WriteLine("\n1.Add 2.Edit 3.Delete 4.GetById 5.GetByName 6.All 7.ByAuthor 8.ByLang 9.ByPublisher 10.Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBook(GetBookInput());
                        break;

                    case 2:
                        EditBook(GetBookInputWithId());
                        break;

                    case 3:
                        Console.Write("Enter Id: ");
                        DeleteBook(Convert.ToInt32(Console.ReadLine()));
                        break;

                    case 4:
                        Console.Write("Enter Id: ");
                        GetBookById(Convert.ToInt32(Console.ReadLine()));
                        break;

                    case 5:
                        Console.Write("Enter Title: ");
                        GetBookByName(Console.ReadLine());
                        break;

                    case 6:
                        GetAllBooks();
                        break;

                    case 7:
                        Console.Write("Enter Author: ");
                        GetAllBooksByAuthor(Console.ReadLine());
                        break;

                    case 8:
                        Console.Write("Enter Language: ");
                        GetAllBooksByLang(Console.ReadLine());
                        break;

                    case 9:
                        Console.Write("Enter Publisher: ");
                        GetAllBooksByPublisher(Console.ReadLine());
                        break;

                    case 10:
                        return;
                }
            }
        }

        // ================= INPUT =================
        private Book GetBookInput()
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Author: ");
            string author = Console.ReadLine();

            Console.Write("Publisher: ");
            string publisher = Console.ReadLine();

            Console.Write("Language: ");
            string language = Console.ReadLine();

            Console.Write("Publish Date (yyyy-mm-dd): ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());

            return new Book
            {
                Title = title,
                Price = price,
                Author = author,
                Publisher = publisher,
                Language = language,
                PublishDate = date
            };
        }

        private Book GetBookInputWithId()
        {
            Console.Write("BookId: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Book book = GetBookInput();
            book.BookId = id;

            return book;
        }

        // ================= ADD =================
        private void AddBook(Book book)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO Book 
                (Title, Price, Author, Publisher, Language, PublishDate)
                VALUES (@Title, @Price, @Author, @Publisher, @Language, @PublishDate)";

                db.Execute(sql, book);
                Console.WriteLine("Book added successfully.");
            }
        }

        // ================= EDIT =================
        private void EditBook(Book book)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE Book SET 
                Title=@Title, Price=@Price, Author=@Author,
                Publisher=@Publisher, Language=@Language, PublishDate=@PublishDate
                WHERE BookId=@BookId";

                int rows = db.Execute(sql, book);
                Console.WriteLine(rows > 0 ? "Updated successfully" : "Book not found");
            }
        }

        // ================= DELETE =================
        private void DeleteBook(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM Book WHERE BookId=@Id";
                int rows = db.Execute(sql, new { Id = id });

                Console.WriteLine(rows > 0 ? "Deleted successfully" : "Book not found");
            }
        }

        // ================= GET BY ID =================
        private void GetBookById(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var book = db.QuerySingleOrDefault<Book>(
                    "SELECT * FROM Book WHERE BookId=@Id", new { Id = id });

                if (book != null)
                    Print(book);
                else
                    Console.WriteLine("Book not found");
            }
        }

        // ================= GET BY NAME =================
        private void GetBookByName(string name)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var book = db.QuerySingleOrDefault<Book>(
                    "SELECT * FROM Book WHERE Title=@Title", new { Title = name });

                if (book != null)
                    Print(book);
                else
                    Console.WriteLine("Book not found");
            }
        }

        // ================= GET ALL =================
        private void GetAllBooks()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var books = db.Query<Book>("SELECT * FROM Book").ToList();
                foreach (var b in books) Print(b);
            }
        }

        // ================= FILTER =================
        private void GetAllBooksByAuthor(string author)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var books = db.Query<Book>(
                    "SELECT * FROM Book WHERE Author=@Author", new { Author = author });

                foreach (var b in books) Print(b);
            }
        }

        private void GetAllBooksByLang(string lang)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var books = db.Query<Book>(
                    "SELECT * FROM Book WHERE Language=@Lang", new { Lang = lang });

                foreach (var b in books) Print(b);
            }
        }

        private void GetAllBooksByPublisher(string publisher)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var books = db.Query<Book>(
                    "SELECT * FROM Book WHERE Publisher=@Publisher", new { Publisher = publisher });

                foreach (var b in books) Print(b);
            }
        }

        // ================= PRINT =================
        private void Print(Book b)
        {
            Console.WriteLine($"{b.BookId} | {b.Title} | {b.Author} | {b.Price} | {b.Language} | {b.Publisher} | {b.PublishDate.ToShortDateString()}");
        }
    }
}