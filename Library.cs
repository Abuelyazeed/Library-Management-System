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
    }

    public void Remove(Book book)
    {
        Books.Remove(book);
    }
}
