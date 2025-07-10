using System;

public class Fibonacci
{
    public static void Run()
    {
        Console.Write("Enter the number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int a = 0, b = 1, c;
        Console.Write("Fibonacci Series: ");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");
            c = a + b;
            a = b;
            b = c;
        }
        Console.WriteLine();
    }
}