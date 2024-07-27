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
