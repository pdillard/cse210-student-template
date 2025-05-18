using System.Collections.Generic;
using System.IO;

public class Entry
{

    public DateTime _date;
    public string _prompt;
    public string _response;


    public Entry(DateTime date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public string FormatEntry()
    {
        return $"{_date.ToShortDateString()} | Prompt: {_prompt}\nResponse: {_response}\n";
    }
}