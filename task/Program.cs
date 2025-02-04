

using System.Transactions;

namespace task
{
    class Book
    {
        internal bool avalibality;

        string Author { get; set; }
        string Title { get; set; }

        string Isbn { get; set; }
        bool Avalibality { get; set; }
        

        
        public Book(string title , string author  , string isbn , bool avalibality )
        {

            Author = author;
            Title = title;
            Isbn = isbn;
            Avalibality = avalibality;
            
        }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
        }
    }

    class Library
    {
        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }

        public void AddBook(string title, string author, string isbn)
        {

            Books.Add(new Book(title, author, isbn));
        }

        public string SearchBook(string title1, string title2, string title3) 
        {
            Books.Add(new Book(title1, title2, title3));
            for (int i = 0; i < Books.Count; i++) {
                
            }

        }
        public void BorrowBook(string title)
        {
            Book book = SearchBook(title);
            if (book != null)
            {
                if (book.avalibality)
                    Console.WriteLine($"{title} is borrow");
                else
                    Console.WriteLine($"{title} is not herer");
            }
           
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

            // Searching
            library.SearchBook("The Great Gatsby", "To Kill a Mockingbird", "1984");

            // borrow books
            library.BorrowBook("The Great Gatsby");


            Console.ReadLine();

        }

        
    }
}
