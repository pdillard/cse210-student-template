using System; 
using System.Collections.Generic;
using System.Linq; 

public class Verse
{
    private List<Word> _words;
    private Random _random = new Random();

    public Verse(string text)
    {
        _words = new List<Word>(); 
        string[] parts = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries); 

        foreach (string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        return string.Join(" ", displayWords);
    }

    public bool HideRandomWord()
    {
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        if (visibleWords.Count == 0)
        {
            return false; 
        }

        int indexToHide = _random.Next(visibleWords.Count);
        visibleWords[indexToHide].Hide();
        return true;
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}