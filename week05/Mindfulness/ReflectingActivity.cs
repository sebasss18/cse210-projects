using System.Security.Cryptography.X509Certificates;

public class ReflectingActivity : Activity
{
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        Console.Write("Get ready... ");
        ShowSpinner(3);
        Console.Clear();
        int elapsed = 0;
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        while (elapsed < _duration)
        {
            DisplayQuestion();
            ShowSpinner(10);
            elapsed += 10;
        }
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomPrompt = random.Next(0, _prompts.Count);
        return _prompts[randomPrompt];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomQuestion = random.Next(0, _questions.Count);
        return _questions[randomQuestion];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n{prompt}\n");
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.WriteLine($"\n{question}\n");
    }
}