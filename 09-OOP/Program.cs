using System;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Introduce()
    {
        Console.WriteLine($"My name is {Name} and I am {Age} years old.");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student("YourName", 20);
        student.Introduce();

        // TODO: Create a Car class with properties and methods.
        // TODO: Practice constructor overloading.
        // TODO: Add private fields and public properties for encapsulation.
    }
}
