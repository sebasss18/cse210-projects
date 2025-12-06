using System.IO;
using System.Threading.Channels;
using System.Xml;
using System.Xml.Serialization;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    // Menu, the method that starts everything
    public void Start()
    {
        string opt = "";
        while (opt != "6")
        {
            // REMEMBER TO CHANGE THIS POINTS VALUE. <------
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            opt = Console.ReadLine().ToLower();

            try
            {
                if (opt == "1")
                {
                    CreateGoal();
                }

                else if (opt == "2")
                {
                    if (_goals.Count == 0)
                    {
                        Console.WriteLine("\nNo goals created yet.\n");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("The goals are: \n");
                        for (int i = 0; i < _goals.Count; i++)
                        {
                            string status = _goals[i].IsComplete() ? "X" : " ";
                            Console.WriteLine($"{i + 1}. [{status}] {_goals[i].GetDetailsString()}");
                        }
                    }
                }

                else if (opt == "3")
                {
                    Console.Write("What is the name for the goal file? ");
                    string filename = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(filename))
                    {
                        filename = "goals.txt";
                    }

                    SaveGoals(filename);
                    ShowSpinner(3);
                    Console.WriteLine($"\nGoals saved to {filename}.\n");
                    ShowSpinner(3);
                    Console.Clear();
                }

                else if (opt == "4")
                {
                    Console.Write("Enter the name of the goal file to load: ");
                    string filename = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(filename))
                    {
                        filename = "goals.txt";
                    }

                    if (!File.Exists(filename))
                    {
                        Console.WriteLine($"\nThe file '{filename}' does not exist.\n");
                    }
                    else if (File.Exists(filename))
                    {
                        ShowSpinner(3);
                        LoadGoals(filename);
                        Console.WriteLine($"\nGoals loaded from {filename} succesfully!\n");
                        ShowSpinner(3);
                        Console.Clear();
                    }
                }

                else if (opt == "5")
                {
                    if (_goals.Count == 0)
                    {
                        Console.WriteLine("\nNo goals created yet.\n");
                    }
                    else
                    {
                        RecordEvent();
                        Console.WriteLine($"Congratulations! Your score is now {_score}! ");
                        ShowSpinner(3);
                        Console.Clear();
                    }
                }

                else if (opt == "6")
                {
                    ShowSpinner(3);
                    Console.WriteLine("\nThank you for playing Eternal Quest!\n");
                }

                else
                {
                    Console.WriteLine("\nYou Must Select a valid option.\n");
                }
            }

            catch (Exception)
            {
                Console.WriteLine("You Must Select a valid option.");
            }
        }
    }

    // A method to display the score
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    // Types of goals to create
    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of Goal would you like to create? ");
        string typeOfGoal = Console.ReadLine();

        if (typeOfGoal == "1")
        {
            Console.Write("What is the name of your goal? ");
            string nameOfGoal = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string descOfGoal = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int pointsOfGoal = int.Parse(Console.ReadLine().Trim());

            ShowSpinner(3);
            Console.WriteLine("Goal saved succesfully!");
            ShowSpinner(3);
            Console.Clear();

            SimpleGoal sg = new SimpleGoal(nameOfGoal, descOfGoal, pointsOfGoal, false);
            _goals.Add(sg);
        }

        else if (typeOfGoal == "2")
        {
            Console.Write("What is the name of your goal? ");
            string nameOfGoal = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string descOfGoal = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int pointsOfGoal = int.Parse(Console.ReadLine().Trim());

            ShowSpinner(3);
            Console.WriteLine("Goal saved succesfully!");
            ShowSpinner(3);
            Console.Clear();

            EternalGoal eg = new EternalGoal(nameOfGoal, descOfGoal, pointsOfGoal);
            _goals.Add(eg);
        }

        else if (typeOfGoal == "3")
        {
            int amountCompleted = 0;
            Console.Write("What is the name of your goal? ");
            string nameOfGoal = Console.ReadLine().Trim();
            Console.Write("What is a short description of it? ");
            string descOfGoal = Console.ReadLine().Trim();
            Console.Write("What is the amount of points associated with this goal? ");
            int pointsOfGoal = int.Parse(Console.ReadLine().Trim());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine().Trim());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine().Trim());

            ShowSpinner(3);
            Console.WriteLine("Goal saved succesfully!");
            ShowSpinner(3);
            Console.Clear();

            CheckListGoal cg = new CheckListGoal(nameOfGoal, descOfGoal, pointsOfGoal, amountCompleted, target, bonus);
            _goals.Add(cg);
        }

        else
        {
            Console.WriteLine("You must select a type of goal.");
        }
    }

    // Record an event, in other words, mark if you finish a goal
    public void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine("Your current goals are:\n");
        for (int i = 0; i < _goals.Count; i++)
        {
            string status = _goals[i].IsComplete() ? "X" : " ";
            Console.WriteLine($"{i+1}. {_goals[i].GetDetailsString()} - {_goals[i].Points}");
        }

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice < 0 || choice >= _goals.Count)
        {
            Console.WriteLine("Invalid Choice.");
            return;
        }

        Goal selected = _goals[choice];
        int pointsEarned = 0;

        if (!selected.IsComplete())
        {
            pointsEarned = selected.Points;
            _score += selected.Points;
        }

        selected.RecordEvent();

        if (selected is CheckListGoal cg && cg.IsComplete())
        {
            _score += cg.Bonus;
            Console.WriteLine($"Bonus earned! +{cg.Bonus} points!");
        }

        Console.WriteLine($"You earned {pointsEarned} points!");
        ShowSpinner(3);
        Console.Clear();
    }

    // Save goals to a file
    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
        
    }

    // Load goals from a file
    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("The file does not exist.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        _goals = new List<Goal>();

        _score = int.Parse(lines[0]);

        for (int i = 1; i<lines.Length; i++)
        {
            string line = lines[i];

            string[] partsType = line.Split(":");
            string goalType = partsType[0].Trim();
            string[] parts = partsType[1].Split(",");

            for (int j = 0; j < parts.Length; j++)
            {
                parts[j] = parts[j].Trim();
            }

            if (goalType == "SimpleGoal")
            {
                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);
                bool isComplete = bool.Parse(parts[3]);

                SimpleGoal g = new SimpleGoal(name, description, points, isComplete);
                _goals.Add(g);
            }

            else if (goalType == "EternalGoal")
            {
                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);

                EternalGoal g = new EternalGoal(name, description, points);
                _goals.Add(g);
            }

            else if (goalType == "CheckListGoal")
            {
                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);
                int amountCompleted = int.Parse(parts[3]);
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);

                CheckListGoal g = new CheckListGoal(name, description, points, amountCompleted, target, bonus);
                _goals.Add(g);
            }
        }
    }

    // Animation, creative part    
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
}