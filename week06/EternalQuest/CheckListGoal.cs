public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _isComplete;
    public int Bonus => _bonus;

    public CheckListGoal(string name, string description, int points, int amountCompleted, int target, int bonus) : base(name,description,points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
        _isComplete = _amountCompleted >= target;
    }

    public override void RecordEvent()
    {
        _amountCompleted ++;
        if (_amountCompleted >= _target)
        {
            _isComplete = true;
            Console.WriteLine($"CheckList completed");
        }

    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description}) - Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
                return $"CheckListGoal:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}