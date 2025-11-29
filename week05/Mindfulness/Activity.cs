using System.Security.Principal;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"{_description}");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();
    }   

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name}");
    }

    public void ShowSpinner(int seconds)
    {
        int i = 0;
        List<string> _spinAnimation = new List<string>();
        _spinAnimation.Add("|");
        _spinAnimation.Add("/");
        _spinAnimation.Add("-");
        _spinAnimation.Add("\\");
        _spinAnimation.Add("|");
        _spinAnimation.Add("/");
        _spinAnimation.Add("-");
        _spinAnimation.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(_spinAnimation[i]);
            Thread.Sleep(150);
            Console.Write("\b \b");

            i++;

            if (i >= _spinAnimation.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int second)
    {
        for (int i = second; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}