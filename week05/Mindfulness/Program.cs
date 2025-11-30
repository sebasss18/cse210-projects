// For the creative part, I added basic error handling so the program doesnt crash when the user enters invalid input.

using System;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("\nHello World! This is the Mindfulness Project.");

    /* Reflecting Activity Lists*/

        // Prompts list
        List<string> prompts = new List<string>
        {
            "--- Think of a time when you stood up for someone else. ---",
            "--- Think of a time when you did something really difficult. ---",
            "--- Think of a time when you helped someone in need. ---",
            "--- Think of a time when you did something truly selfless. ---"
        };
        // Questions list
        List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    /* Listing Activity List */

        // Listing Prompts
        List<string> listingPrompts = new List<string>
        {
            "---Who are people that you appreciate?---",
            "---What are personal strengths of yours?---",
            "---Who are people that you have helped this week?---",
            "---When have you felt the Holy Ghost this month?---",
            "---Who are some of your personal heroes?---"
        };

        string opt = "";
        while (opt != "4")
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            opt = Console.ReadLine().ToLower();

            // Options
            try
            {
                if (opt == "1")
                {
                    Console.Clear();
                    BreathingActivity b = new BreathingActivity("Breathing Activity", "\nThis activity will help you to relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing\n", 0);
                    b.DisplayStartingMessage();
                    b.Run();
                    b.DisplayEndingMessage();
                    b.ShowSpinner(5);
                    Console.Clear();
                }

                else if (opt == "2")
                {
                    Console.Clear();
                    ReflectingActivity r = new ReflectingActivity("Reflecting Activity", "\nThis Activity will help you reflect on times in your life when you have shown strength and resilience. This will help you regconize the power you have and how you can use it in other aspects of your life.\n", 0, prompts, questions);
                    r.DisplayStartingMessage();
                    r.Run();
                    r.DisplayEndingMessage();
                    r.ShowSpinner(5);
                    Console.Clear();
                }

                else if (opt == "3")
                {
                    Console.Clear();
                    ListingActivity l = new ListingActivity("Listing Activity", "\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n", 0, listingPrompts);
                    l.DisplayStartingMessage();
                    l.Run();
                    l.DisplayEndingMessage();
                    l.ShowSpinner(5);
                    Console.Clear();
                }

                else if (opt == "4")
                {
                    Console.WriteLine("\nThank you for using the Mindfulness Program!\n");
                }

                else
                {
                    Console.WriteLine("\nYou must select a valid option.");
                }
            }

            catch (Exception)
            {
                Console.WriteLine("\nYou must write in seconds the amount of time you want the activity to be.");
            }

        }
    }
}