public class StationaryBicycles : Activity
{
    public StationaryBicycles(double speed, double distance, double minutes) : base(speed,distance,minutes)
    {
        
    }
    public override double GetDistanceKm()
    {
        return _speed * (_minutes / 60);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return _minutes / GetDistanceKm();
    }
}