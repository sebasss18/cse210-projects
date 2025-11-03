public class Job
{
    public string _Company;
    public string _JobTitle;
    public int _Start;
    public int _End;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_JobTitle} ({_Company}) {_Start}-{_End}");
    }
}
