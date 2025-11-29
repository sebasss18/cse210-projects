using System.Diagnostics;
using System.Timers;

public class ListingActivity : Activity
{
    private int _count;
    List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description, int duration, List<string> prompts) : base(name, description, duration)
    {
        _prompts = prompts;
        _count = 0;
    }

    public void Run()
    {
        Console.Write("Get ready... ");
        ShowSpinner(3);
        Console.Clear();
        Console.WriteLine("\nList as many respones you can to the following prompt:\n");
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("\nYou may begin in: ");
        ShowCountDown(3);    
        Console.WriteLine();
        
        Stopwatch clock = new Stopwatch();
        clock.Start();

        while (clock.Elapsed.TotalSeconds < _duration)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count ++;
        }

        clock.Stop();

        Console.WriteLine($"You listed {_count} items!");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomPrompt = random.Next(0, _prompts.Count);
        return _prompts[randomPrompt];
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();

        return items;
    }
}