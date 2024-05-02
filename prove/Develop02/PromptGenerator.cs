using System;
using System.IO;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    public Random rand = new Random();

    // The PromptGenerator has a void method to set the initial prompts.
    // More can be added to this list if desired.
    public void SetPrompts()
    {
        _prompts.Add("Who was the most interesting person I interacted with today? ");
        _prompts.Add("What was the best part of my day? ");
        _prompts.Add("How did I see the hand of the Lord in my life today? ");
        _prompts.Add("What was the strongest emotion I felt today? ");
        _prompts.Add("If I had one thing I could do over today, what would it be? ");
        _prompts.Add("What work have you done as a part of your personal development goals? ");  // Team added prompt
        _prompts.Add("What fun things happened today? ");                                        // Team added prompt
    }

    // Extra method for debugging purposes - shows the current prompts that are available.
    public void ShowPrompts()
    {
        Console.WriteLine("\n===== Current list of stored prompts is shown below =====");
        foreach (string p in _prompts)
        {
            Console.WriteLine(p);
        }
            Console.WriteLine("===== End of prompts list =====\n\n");
    }

    public string GetRandomPrompt()
    {
        int r = rand.Next(_prompts.Count);
        return _prompts[r];
    }
}