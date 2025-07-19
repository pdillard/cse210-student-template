class Swimming : Activity
{
    private int _laps; // each lap = 50 meters

    public Swimming(string date, int duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * 50 / 1000.0;
    public override double GetSpeed() => GetDistance() / (_duration / 60.0);
    public override double GetPace() => _duration / GetDistance();
}
