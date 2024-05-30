using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int    _length;   // Length of video in seconds
    private List<Comment> _comments = new List<Comment>();

    // Video class constructor - pass in name, author and length in seconds
    public Video (string title, string author, int length)
    {
        _title  = title;
        _author = author;
        _length = length;
    }

    public void AddComment (string name, string text)
    {
        Comment txt = new Comment(name, text);
        _comments.Add(txt);
    }
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"\nVideo:  {_title}.");
        Console.WriteLine($"Author: {_author}.");
        Console.WriteLine($"Length: {_length} seconds.");
        Console.WriteLine($"*** {_comments.Count()} Comments ***");
        foreach (Comment cmt in _comments)
        {
            Console.WriteLine($"{cmt.GetName()}: {cmt.GetComment()}");
        }
    }
}