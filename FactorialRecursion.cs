using System;

public class FactorialRecursion
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Factorial of {num} is {Factorial(num)}");
    }

    static long Factorial(int n)
    {
        if (n <= 1) return 1;
        return n * Factorial(n - 1);
    }
}