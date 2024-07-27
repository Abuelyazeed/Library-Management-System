public class Program
{
    public static void Main(string[] args)
    {
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

            Console.WriteLine(
                "Please choose to Add Book (A) / Remove Book (R) / Display Books (D)"
            );
        }
        else if (userType == "u")
        {
            //user logic
        }
        else
        {
            Console.WriteLine("Please enter a valid value (L or R)");
        }
    }
}
