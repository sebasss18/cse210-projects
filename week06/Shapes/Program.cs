using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello World! This is the Shapes Project.\n");

        Square s = new Square("red", 5);

        Console.WriteLine();
        Console.WriteLine(s.GetColor());
        Console.WriteLine(s.GetArea());

        Rectangle r = new Rectangle("blue", 6, 9);

        Console.WriteLine();
        Console.WriteLine(r.GetColor());
        Console.WriteLine(r.GetArea());

        Circle c = new Circle("yellow", 8);

        Console.WriteLine();
        Console.WriteLine(c.GetColor());
        Console.WriteLine(c.GetArea());
    }
}