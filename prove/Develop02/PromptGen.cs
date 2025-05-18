using System.Collections.Generic;
using System.IO;

public class Prompts
{
    List<string> _prompts = new List<string> {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something I learned about myself recently?",
            "What habits are helping me grow—and which ones are holding me back?",
            "When did I feel most confident this week, and why?",
            "How have I changed in the past year?",
            "What emotions have I felt most frequently this week?",
            "What is currently causing me stress, and what can I do about it?",
            "What makes me feel grounded when things are overwhelming?",
            "What do I need more of in my life right now?",
            "Three small things I'm grateful for today are:",
            "What went well today, and how did I contribute to it?",
            "Who in my life am I thankful for, and why?",
            "What is something beautiful I noticed today?",
            "What are three short-term goals I want to focus on?",
            "What did I accomplish this week that I'm proud of?",
            "What's one thing I can improve on tomorrow?",
            "Where do I see myself in six months, and what steps will get me there?",
            "Describe a perfect day from start to finish.",
            "If I could talk to my younger self, what would I say?",
            "Write a letter to your future self 10 years from now.",
            "What would life look like if I wasn't afraid?"
    };

    public string GetRandomPrompt()
    {
        Random r = new Random();
        int index = r.Next(_prompts.Count);
        string _randomString = _prompts[index];

        return _randomString;
    }
}