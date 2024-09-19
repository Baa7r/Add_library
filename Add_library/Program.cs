using System.Collections.Immutable;
using System.Security.Cryptography.X509Certificates;
using static System.Reflection.Metadata.BlobBuilder;

namespace library
{

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; }

        // Constructor to initialize a book object
        public Book(string title, string author, string isbn, bool isAvailable = true)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsAvailable = isAvailable;
        }

    }

    public class Library
    {
        public List<Book> Books { get; set; }

        // Constructor of library book 
        public Library()
        {
            Books = new List<Book>();
        }

        // Method to add a new book to the library
        public void AddBook(Book newBook)
        {
            Books.Add(newBook);
            Console.WriteLine($"Added new book: {newBook.Title} , {newBook.Author} , {newBook.ISBN}");
        }


        public void BorrowBook(Book newBook)
        {


            Console.WriteLine($" congratulation you borrow book: {newBook.Title} now ");

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Library library = new Library();

            // Adding books to the library
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
            library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

            library.BorrowBook(new Book("1984", "George Orwell", "9780451524935"));

        }
    }
}
