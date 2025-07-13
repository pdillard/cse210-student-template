class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds\nComments ({GetCommentCount()}):");
        foreach (Comment c in _comments)
        {
            Console.WriteLine("  - " + c.GetCommentInfo());
        }
        Console.WriteLine();
    }
}