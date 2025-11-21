public class Comment
{
    private string _name;
    private string _textComment;

    public Comment (string name, string textComment)
    {
        _name = name;
        _textComment = textComment;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetText()
    {
        return _textComment;
    }
}