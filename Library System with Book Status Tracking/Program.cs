namespace Library_System_with_Book_Status_Tracking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library();

            lib.AddBook(new Book("Math", "Ali", BookStatus.Available));
            lib.AddBook(new Book("Science", "Sara", BookStatus.CheckedOut));
            lib.AddBook(new Book("History", "Ahmed", BookStatus.Reserved));
            lib.AddBook(new Book("English", "Laila", BookStatus.Available));
            lib.AddBook(new Book("IT", "Khalid", BookStatus.CheckedOut));

            Console.WriteLine("Book info by title:");
            Book b = lib["IT"];
            if (b != null)
                b.ShowInfo();

            Console.WriteLine("\nChange status of English to CheckedOut:");
            lib.ChangeStatus("English", BookStatus.CheckedOut);

            Console.WriteLine("\nAvailable books:");
            lib.ShowBooksByStatus(BookStatus.Available);

            Console.WriteLine("\nCheckedOut books:");
            lib.ShowBooksByStatus(BookStatus.CheckedOut);
        }
    }
    enum BookStatus
    {
        Available,
        CheckedOut,
        Reserved
    }

    class Book
    {
        public string Title;
        public string Author;
        public BookStatus Status;

        public Book(string title, string author, BookStatus status)
        {
            Title = title;
            Author = author;
            Status = status;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Status: {Status}");
        }
    }

    class Library
    {
        List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book this[string title]
        {
            get
            {
                foreach (Book b in books)
                {
                    if (b.Title == title)
                        return b;
                }
                return null;
            }
        }

        public void ChangeStatus(string title, BookStatus newStatus)
        {
            Book book = this[title];
            if (book != null)
            {
                book.Status = newStatus;
            }
        }

        public void ShowBooksByStatus(BookStatus status)
        {
            foreach (Book b in books)
            {
                if (b.Status == status)
                {
                    b.ShowInfo();
                }
            }
        }
    }
    }
