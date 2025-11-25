using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello World! This is the Homework Project.\n");

        MathAssignment a2 = new MathAssignment("Ana Retes", "Algebra", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Juan Gabriel", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}