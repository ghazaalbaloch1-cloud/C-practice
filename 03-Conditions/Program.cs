using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine() ?? "0");

        if (number > 0)
            Console.WriteLine("Positive");
        else if (number < 0)
            Console.WriteLine("Negative");
        else
            Console.WriteLine("Zero");

        // TODO: Add a program that checks whether a number is even or odd.
        // TODO: Add a grade calculator using if/else or switch.
    }
}
