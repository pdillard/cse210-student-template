public class Word
{
    private string _text;
    private bool _visable;

    public Word(string text)
    {
        _text = text;
        _visable = true;
    }

    public void Hide()
    {
        _visable = false;
    }

    public bool IsHidden()
    {
        return !_visable;
    }

    public string GetDisplayText()
    {
        return _visable ? _text : "______"; 
    }
}