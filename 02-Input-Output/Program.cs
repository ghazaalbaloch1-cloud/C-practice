using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"Hello {name}, you are {age} years old.");

        // TODO: Ask for two numbers and print their sum, difference,
        // product and quotient.
    }
}
