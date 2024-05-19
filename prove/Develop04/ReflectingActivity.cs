using System.Runtime.CompilerServices;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private Random _randGen = new Random();
    private int loadComplete = 0;

    public ReflectingActivity()
    {
        _name = "Reflecting";
        string s1 = "This activity will help you reflect on times in your ";
        string s2 = "life when you have shown strength and resilience. ";
        string s3 = "This will help you recognize the power you have and ";
        string s4 = "how you can use it in other aspects of you life.";
        _description = s1 + s2 + s3 + s4;
    }

    public void Run()
    {
        LoadPrompts();
        LoadQuestions();
        DisplayStartingMessage(_name, _description);
        Console.WriteLine($"running for {_duration} seconds");
        ShowReady(3);
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage(_name, _duration, 8);
    }

    private string GetRandomPrompt()
    {
        int i = _randGen.Next(1,_prompts.Count());
        return _prompts[i];
    }

    private string GetRandomQuestion()
    {
        int i = _randGen.Next(1,_questions.Count());
        return _questions[i];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
        Console.Write("When you have something in mind, ");
        PressEnterToContinue();
    }

    private void DisplayQuestions()
    {
        Console.WriteLine("> Now ponder on each of the following questions as they related to this experience:");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(15);
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    
    private void LoadPrompts()
    {
        if (loadComplete == 0)
        {
            _prompts.Add("Think of a time when you stood up for someone else.");
            _prompts.Add("Think of a time when you did something really difficult.");
            _prompts.Add("Think of a time when you helped someone in need.");
            _prompts.Add("Think of a time when you did something truly selfless.");
        }
    }    

    private void LoadQuestions()
    {
        if (loadComplete == 0)
        {
            _questions.Add("Why was this experience meaningful to you?");
            _questions.Add("Have you ever done anything like this before?");
            _questions.Add("How did you get started?");
            _questions.Add("How did you feel when it was complete?");
            _questions.Add("What made this time different than other times when you were not as successful?");
            _questions.Add("What is your favorite thing about this experience?");
            _questions.Add("What could you learn from this experience that applies to other situations?");
            _questions.Add("What did you learn about yourself through this experience?");
            _questions.Add("How can you keep this experience in mind in the future?");
            loadComplete = 1;
        }
    }
    
    // Called for debugging purposes only
    private void ShowAllPrompts()
    {
        foreach (string prompt in _prompts)
        {
            Console.WriteLine(prompt);
        }
    }
    
    // Called for debugging purposes only
    private void ShowAllQuestions()
    {
        foreach (string question in _questions)
        {
            Console.WriteLine(question);
        }
    }
}

