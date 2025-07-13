using System;
using System.Collections.Generic;

class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public string GetCommentInfo()
    {
        return $"{_name}: {_text}";
    }
}