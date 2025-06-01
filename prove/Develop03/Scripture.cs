using System.Collections.Generic;
using System.IO;
using System.Linq; 
using System; 

public class Scripture
{
    private string _reference;
    private List<Verse> _verses;
    private Random _random = new Random(); 

    public Scripture(string reference, List<string> verses)
    {
        _reference = reference;

        _verses = new List<Verse>();
        foreach (string verseText in verses)
        {
            Verse verseObj = new Verse(verseText);
            _verses.Add(verseObj);
        }
    }

    public Scripture(StreamReader reader)
    {
        _verses = new List<Verse>(); 
        _reference = reader.ReadLine().Trim(); 

        while (!reader.EndOfStream) 
        {
            string text = reader.ReadLine().Trim();
            if (!string.IsNullOrWhiteSpace(text)) 
            {
                _verses.Add(new Verse(text));
            }
        }
    }

    public string GetDisplayText()
    {
        string fullText = $"{_reference}\n";
        foreach (Verse verse in _verses)
        {
            fullText += verse.GetDisplayText() + "\n";
        }
        return fullText.Trim(); 
    }

    public void HideRandomWords(int count)
    {
        for (int i = 0; i < count; i++)
        {
            if (IsCompletelyHidden())
            {
                break;
            }

            List<Verse> versesWithVisibleWords = _verses.Where(v => !v.IsCompletelyHidden()).ToList();
            if (versesWithVisibleWords.Count > 0)
            {
                int verseIndex = _random.Next(versesWithVisibleWords.Count);
                versesWithVisibleWords[verseIndex].HideRandomWord();
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        return _verses.All(v => v.IsCompletelyHidden());
    }
}