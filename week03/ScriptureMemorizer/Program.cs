// For the creative addition I added a random scripture selector so each run gives a different verse to memorize.

using System;
using System.ComponentModel.DataAnnotations;
using System.IO.Pipes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello World! This is the ScriptureMemorizer Project.\n");

        Reference reference1 = new Reference("John", 3, 16);
        Scripture scripture1 = new Scripture(reference1, "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");
        Reference reference2 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture2 = new Scripture(reference2, "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        Reference reference3 = new Reference("Philippians", 4, 13);
        Scripture scripture3 = new Scripture(reference3, "I can do all things through Christ which strengtheneth me.");
        Reference reference4 = new Reference("Psalm", 23, 1, 2);
        Scripture scripture4 = new Scripture(reference4, "The LORD is my shepherd; I shall not want. He maketh me to lie down in green pastures: he leadeth me beside the still waters.");

        List<Scripture> scriptures = new List<Scripture>()
        {
            scripture1,
            scripture2,
            scripture3,
            scripture4
        };

        Random random = new Random();
        int index = random.Next(0, scriptures.Count);
        Scripture scripture = scriptures[index];

        Console.WriteLine(scripture.GetDisplayText());

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            if (input.ToLower().StartsWith("q"))
            {
                Console.WriteLine("Closing program...");
                break;
            }
            scripture.HideRandomWords(3);
            
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll the words are now hidden!");
                Console.ReadLine();
                break;
            }
        }
    }
}