

namespace task
{
    class Book
    {

        string Author { get; set; }
        string Title { get; set; }

        string Isbn { get; set; }
        bool Avalibality { get; set; }
        

        
        public Book(string title = "none", string author = "none", string isbn = "none", bool avalibality = true)
        {

            Author = author;
            Title = title;
            Isbn = isbn;
            Avalibality = avalibality;
            
        }
    }

    class Library
    {
        public List<Book> Books { get; set; }

        public bool AddBook()
        {
            Books.Add(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
            Books.Add(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
            Books.Add(new Book("1984", "George Orwell", "9780451524935"));
            return true;
        }
        public bool Searchbook(string title)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if ("The Great Gatsby" == title)
                {
                    Console.WriteLine("is here");
                }
                else if ("To Kill a Mockingbird" == title)
                {
                    Console.WriteLine("is borrowd");
                }
                else
                {
                    Console.WriteLine("this is not at the library ");
                }
            } return true;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {


            // Adding books to the library
            

            // Searching 
            Book book = new Book("The Great Gatsby", "To Kill a Mockingbird", "1984");
            
            // Returning books
            
            

            Console.ReadLine();

        }

        
    }
}
