using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine($"You entered {number}.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid integer.");
        }

        // TODO: Handle DivideByZeroException.
        // TODO: Build a safe calculator using try/catch.
    }
}
