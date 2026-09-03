using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "practice.txt";
        File.WriteAllText(path, "C# File Handling Practice");
        string content = File.ReadAllText(path);
        Console.WriteLine(content);

        // TODO: Append new lines to the file.
        // TODO: Check File.Exists before reading.
        // TODO: Create a simple notes file program.
    }
}
