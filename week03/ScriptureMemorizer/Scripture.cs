using System.ComponentModel.DataAnnotations;

public class Scripture
{
    private Reference _reference;
    private Random _random;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _random = new Random();
        string[] parts = text.Split(" ");
        foreach (string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
    }
    public string GetDisplayText()
    {
        string text = "";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} - {text.Trim()}";
    }

    public void HideRandomWords(int numberToHide)
    {
        int remaining = _words.Count(word => !word.IsHidden());
        if (remaining == 0)
        {
            return;
        }

        numberToHide = Math.Min(numberToHide, remaining);
            
        int count = 0;
        while (count < numberToHide)
        {
            int index = _random.Next(0, _words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                count++;
            }
            else
            {
                
            }
        }
    }
    public bool IsCompletelyHidden()
    {
        foreach ( Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}