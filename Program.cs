using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose a program:");
        Console.WriteLine("1. Greet User");
        Console.WriteLine("2. Add Two Numbers");     
        Console.WriteLine("3. Even or Odd");
        Console.WriteLine("4. Factorial");
        Console.WriteLine("5. Factorial (Recursion)");
        Console.WriteLine("6. Fibonacci");

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
           case "3":
               EvenOdd.Run();
               break;
           case "4":
               Factorial.Run();
               break;
           case "5":
               FactorialRecursion.Run();
               break;
           case "6":
               Fibonacci.Run();
               break;        
    default:
        Console.WriteLine("Invalid choice.");
        break;
}
    }
}