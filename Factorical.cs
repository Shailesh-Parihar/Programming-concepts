using System;

public class Factorial
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        long fact = 1;
        for (int i = 1; i <= num; i++)
            fact *= i;
        Console.WriteLine($"Factorial of {num} is {fact}");
    }
}