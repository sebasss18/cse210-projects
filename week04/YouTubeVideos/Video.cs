public class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;

    List<Comment> _comments = new List<Comment>();

    public Video (string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        int totalComments = 0;
        foreach (Comment comment in _comments)
        {
            totalComments++;
        }
        return totalComments;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _lengthSeconds;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
    
}