using System.Collections.Generic;
public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "What is something that make you smile today?",
        "What is something you are gratefull for?",
        "What are some of your goals?",
        "What's one thing you learn today?",
        "How did you show kindness today?",
        "Who made your day better today?"
    };

    private Random _randomPrompt = new Random();

    public string GetRandomPrompt()
    {
        if (_prompts == null || _prompts.Count == 0) return string.Empty;
        int index = _randomPrompt.Next(_prompts.Count);
        return _prompts[index];
    }
}