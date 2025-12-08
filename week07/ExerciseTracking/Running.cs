public class Running : Activity
{
    public Running(double speed, double distance, double minutes) : base(speed,distance,minutes)
    {
        
    }

    public override double GetDistanceKm()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (_minutes / 60);
    }

    public override double GetPace()
    {
        return _minutes / _distance;
    }
}