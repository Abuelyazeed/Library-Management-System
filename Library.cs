public class Library
{
    private List<Book> Books = [];
    private List<Book> BorrowedBooks = [];

    public void Display()
    {
        foreach (var book in Books)
        {
            Console.WriteLine(book.Title);
        }
    }

    public void Add(Book book)
    {
        Books.Add(book);
        Console.WriteLine("Book added successfully");
    }

    public void Remove(Book book)
    {
        if (Books.Contains(book))
        {
            Books.Remove(book);
            Console.WriteLine("Book removed successfully");
        }
        else
        {
            Console.WriteLine("The book you entered is not available");
        }
    }

    public void Borrow(Book book)
    {
        if (Books.Contains(book))
        {
            BorrowedBooks.Add(book);
            Console.WriteLine("Book borrowed successfully");
        }
        else
        {
            Console.WriteLine("The book you entered is not available");
        }
    }
}
