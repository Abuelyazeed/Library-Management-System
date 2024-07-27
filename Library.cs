public class Library
{
    private List<Book> Books = [];
    private List<Book> BorrowedBooks = [];

    public List<Book> Display()
    {
        return Books;
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
}
