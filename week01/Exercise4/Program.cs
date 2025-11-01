using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        int userNumber = -1;
        List<int> numbers = new List<int>();

        Console.WriteLine("\nEnter a list of numbers, type 0 when finished.");

        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }


        float average = ((float)sum) / numbers.Count;


        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"\nThe sum of all the numbers is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max number is: {max}");

        Console.WriteLine("The Full List is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}