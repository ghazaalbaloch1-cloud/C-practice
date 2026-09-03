using System;

class Program
{
    static void Main()
    {
        Console.WriteLine($"Square of 5 = {Square(5)}");
        Console.WriteLine($"Add(10, 20) = {Add(10, 20)}");

        // TODO: Create a method that checks whether a number is even.
        // TODO: Create a method that returns the largest of three numbers.
        // TODO: Create a method that calculates factorial of N.
    }

    static int Square(int number)
    {
        return number * number;
    }

    static int Add(int first, int second)
    {
        return first + second;
    }
}
