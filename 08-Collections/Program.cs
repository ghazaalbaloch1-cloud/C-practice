using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = new() { "Ali", "Sara", "Ahmed" };
        names.Add("Usman");

        foreach (string name in names)
            Console.WriteLine(name);

        // TODO: Find a name in the list.
        // TODO: Create a Dictionary<string, int> for student marks.
        // TODO: Count duplicate numbers using a Dictionary.
    }
}
