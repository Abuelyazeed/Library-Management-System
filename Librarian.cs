public class Librarian : User
{
    public int EmployeeNumber { get; set; }

    public Librarian(string name)
    {
        Name = name;
    }

    public void AddBook(Book newBook) { }

    public void RemoveBook(Book newBook) { }
}
