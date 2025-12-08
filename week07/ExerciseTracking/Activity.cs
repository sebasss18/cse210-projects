using System;
public abstract class Activity
{
    protected double _speed; 
    protected double _distance;
    protected double _minutes;
    
    public string GetDate()
    {
        DateTime date = DateTime.Now;
        return date.ToString();
    }

    public Activity(double speed, double distance, double minutes)
    {
        _speed = speed;
        _distance = distance;
        _minutes = minutes;
    }

    public abstract double GetDistanceKm();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public abstract string GetSummary();
}