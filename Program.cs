public class Program
{
    public static void Main(string[] args)
    {
        Library library = new Library();

        Console.WriteLine("Welcome to the library system!");
        Console.WriteLine("Are you a libarian or a regular user? (L/R)");
        var userType = Console.ReadLine().ToLower();

        if (userType == "l")
        {
            //librarioan logic
            Console.WriteLine($"Welcome librarian! Please enter your name.");
            string libarianName = Console.ReadLine();

            Librarian l1 = new Librarian(libarianName);

            Console.WriteLine($"Welcome {l1.Name}");
            while (true)
            {
                Console.WriteLine(
                    "Please choose to Add Book (A) / Remove Book (R) / Display Books (D)"
                );

                string choice = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "a":
                        Console.WriteLine("Enter book detail to add");
                        string bookName = Console.ReadLine();
                        string bookAuthor = Console.ReadLine();
                        int publishYear = Convert.ToInt32(Console.ReadLine());

                        //Object Initializer
                        Book book = new Book()
                        {
                            Title = bookName,
                            Author = bookAuthor,
                            Year = publishYear
                        };

                        l1.AddBook(book, library);
                        break;
                    case "r":
                        Console.WriteLine("Enter book details to remove");
                        bookName = Console.ReadLine();
                        bookAuthor = Console.ReadLine();
                        publishYear = Convert.ToInt32(Console.ReadLine());

                        //Object Initializer
                        book = new Book()
                        {
                            Title = bookName,
                            Author = bookAuthor,
                            Year = publishYear
                        };

                        l1.RemoveBook(book, library);
                        break;
                    case "d":
                        Console.WriteLine("The book list: ");

                        l1.DisplayBooks(library);
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        else if (userType == "r")
        {
            //user logic
            Console.WriteLine($"Welcome user! Please enter your name.");
            string userName = Console.ReadLine();

            LibraryUser u1 = new LibraryUser(userName);

            Console.WriteLine($"Welcome {u1.Name}");

            while (true)
            {
                Console.WriteLine("Please choose to Display Books (D) or Borrow Book (B)");

                string choice = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "d":
                        Console.WriteLine("The book list: ");

                        u1.DisplayBooks(library);
                        break;
                    case "b":
                        Console.WriteLine("Enter book details to borrow");
                        string bookName = Console.ReadLine();
                        string bookAuthor = Console.ReadLine();
                        int publishYear = Convert.ToInt32(Console.ReadLine());

                        //Object Initializer
                        Book book = new Book()
                        {
                            Title = bookName,
                            Author = bookAuthor,
                            Year = publishYear
                        };

                        u1.BorrowBook(book, library);
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid value (L or R)");
        }
    }
}
