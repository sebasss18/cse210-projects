public class SwimmingPool : Activity
{
    private double _laps;

    public SwimmingPool(double minutes, double laps) : base(0,0,minutes)
    {
        _laps = laps;
    }
    public override double GetDistanceKm()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistanceKm() / (_minutes / 60);
    }

    public override double GetPace()
    {
        return _minutes / GetDistanceKm();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming in the lap pool ({_minutes} min) - Distance {GetDistanceKm()} Km, Speed {GetSpeed()}Kph, Pace: {GetPace()} min per km";
    }
}