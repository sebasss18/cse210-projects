public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        int elapsed = 0;
        Console.WriteLine("Get ready... ");
        ShowSpinner(3);
        while (elapsed < _duration)
        {
            Console.Clear();
            Console.Write("\nBreath in... ");
            ShowCountDown(4);
            elapsed += 4;
            Console.Write("\nBreath out... ");
            ShowCountDown(6);
            elapsed +=6;
            if (elapsed >= _duration) break;
        }
    }
}