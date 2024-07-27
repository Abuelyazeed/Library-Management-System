public abstract class User
{
    public string Name { get; set; }

    public void DisplayBooks(Library library)
    {
        library.Display();
    }
}
