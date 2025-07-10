using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose a program:");
        Console.WriteLine("1. Greet User");
        Console.WriteLine("2. Add Two Numbers");
        Console.Write("Enter choice: ");
        string? choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                GreetUser.Run();
                break;
            case "2":
                AddTwoNumbers.Run();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}