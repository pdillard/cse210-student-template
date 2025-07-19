using System;

class Receptions : Event
{
    private string _rsvpEmail;

    public Receptions(string EventTitle, string Description, string Date, string Time, Address Address, string RSVPEmail) : base(EventTitle, Description, Date, Time, Address)
    {
        _rsvpEmail = RSVPEmail;
    }

    public string GetFullDetails()
    {
        return $"Event Type: Reception\n" + base.FullDetails() + $"\nRSVP Email: {_rsvpEmail}";
    }

    public string GetShortDetails()
    {
        return $"Event Type: Reception\n" + base.ShortDetails();
    }

}