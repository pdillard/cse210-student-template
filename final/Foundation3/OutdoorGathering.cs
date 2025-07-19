using System;

class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string EventTitle, string Description, string Date, string Time, Address Address, string Weather) : base(EventTitle, Description, Date, Time, Address)
    {
        _weather = Weather;
    }

    public string GetFullDetails()
    {
        return $"Event Type: Outdoor Gathering\n" + base.FullDetails() + $"\nWeather: ";
    }

    public string GetShortDetails()
    {
        return $"Event Type: Outdoor Gathering\n" + base.ShortDetails();
    }

}