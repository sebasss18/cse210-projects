public class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;

    List<Comment> comments = new List<Comment>();

    Video (string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
    }
}