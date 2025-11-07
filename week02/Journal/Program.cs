using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello World! This is the Journal Project.\n");
        var journal = new Journal();
        journal.AddEntry();
        journal.DisplayAll();
    }
}