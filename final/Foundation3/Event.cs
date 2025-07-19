using System;

class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string EventTitle, string Description, string Date, string Time, Address Address)
    {
        _eventTitle = EventTitle;
        _description = Description;
        _date = Date;
        _time = Time;
        _address = Address;
    }

    public virtual string StandardDetails()
    {
        return $"Title: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}";
    }
    public virtual string FullDetails()
    {
        return StandardDetails();
    }
    public virtual string ShortDetails()
    {
        return $"Title: {_eventTitle}\nDate: {_date}";
    }
}