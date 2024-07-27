public class LibraryUser : User
{
    public LibraryCard Card;

    public LibraryUser(string name)
    {
        Name = name;
    }

    public void BorrowBook(Book book, Library library)
    {
        library.Borrow(book);
    }
}
