using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int mcnumber = randomGenerator.Next(1, 100);

        int nguess;
        int attempts = 0;

        do
        {
            Console.Write("What is your guess? ");
            nguess = int.Parse(Console.ReadLine());
            attempts++;
            if (mcnumber > nguess)
            {
                Console.WriteLine("Higher");
            }

            else if (mcnumber < nguess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"Thats correct! You guessed in {attempts} attempts.");
            }
        } while (mcnumber != nguess);
    }
}