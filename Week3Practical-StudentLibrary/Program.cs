using Week3Practical_StudentLibrary;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please Work");
        Student student1 = new Student();
        Student student2 = new Student("John Doe", 18);
        student1.Display();
        Console.WriteLine(student1.GetOlder());
        student2.Display();
        Console.WriteLine(student2.GetOlder());
    }
}