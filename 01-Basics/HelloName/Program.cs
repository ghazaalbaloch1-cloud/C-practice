using System;

namespace OOPLAB
{
    class Program
    {
        static void Main()
        {
            string name;

            Console.WriteLine("Enter Your Name:");
            name = Console.ReadLine() ?? "";

            Console.WriteLine("Welcome " + name);

            Console.ReadKey();
        }
    }
}