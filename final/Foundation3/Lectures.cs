using System;

class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string EventTitle, string Description, string Date, string Time, Address Address, string speaker, int capacity) : base(EventTitle, Description, Date, Time, Address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetFullDetails()
    {
        return $"Event Type: Lecture\n" + base.FullDetails() + $"\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

    public string GetShortDetails()
    {
        return $"Event Type: Lecutre\n" + base.ShortDetails();
    }

}

