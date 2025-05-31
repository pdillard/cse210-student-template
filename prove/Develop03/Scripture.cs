public class Scripture
{
    private string _reference;
    private List<Verse> _verses;

    public Scripture(string reference, List<string> verses)
    {
        _reference = reference;

        _verses = new List<Verse>();
        foreach (string verse in verses)
        {
            Verse verseObj = new Verse(verse);
            _verses.Add(verseObj);
        }
    }

    public Scripture(StreamReader reader)
    {
        _reference = reader.ReadLine().Trim();

        while (reader.EndOfStream)
        {
            string text = reader.ReadLine().Trim();
            _verses.Add(new Verse(text));
        }
    }
}