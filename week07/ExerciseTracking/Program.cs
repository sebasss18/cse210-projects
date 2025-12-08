using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("\nHello World! This is the ExerciseTracking Project.");

        Running r1 = new Running(9, 4.5, 30);
        Console.WriteLine();
        Console.WriteLine(r1.GetSummary());

        StationaryBicycles s1 = new StationaryBicycles(20, 10, 30);
        Console.WriteLine();
        Console.WriteLine(s1.GetSummary());

        SwimmingPool s2 = new SwimmingPool(40, 30);
        Console.WriteLine();
        Console.WriteLine(s2.GetSummary());
        Console.WriteLine();
    }
}