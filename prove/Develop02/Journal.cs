using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void addEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries.");
            return;
        }

        foreach (var entry in _entries)
        {
            Console.WriteLine(entry.FormatEntry());
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        foreach (var line in File.ReadAllLines(filename))
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                DateTime date = DateTime.Parse(parts[0]);
                string prompt = parts[1];
                string response = parts[2];
                _entries.Add(new Entry(date, prompt, response));
            }
        }
    }
}