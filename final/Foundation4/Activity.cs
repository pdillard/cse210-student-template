using System;
using System.Collections.Generic;

abstract class Activity
{
    protected string _date;
    protected int _duration; // in minutes

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_duration} min): Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace {GetPace():F2} min per km";
    }
}
