using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 12, 3, 20, 8, 15, 2 };
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

        Console.WriteLine("Even numbers:");
        foreach (int number in evenNumbers)
            Console.WriteLine(number);

        // TODO: Find numbers greater than 10.
        // TODO: Sort the numbers ascending and descending.
        // TODO: Calculate Sum, Average, Min and Max using LINQ.
    }
}
