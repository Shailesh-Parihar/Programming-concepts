
public class GreetUser
{
    public static void Run()
    {
        Console.WriteLine("Enter your name:");
        string? name = Console.ReadLine();
        if (!string.IsNullOrEmpty(name))
            Console.WriteLine($"Hello, {name}!");
        else
            Console.WriteLine("Hello, stranger!");
    }
}