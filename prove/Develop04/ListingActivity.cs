public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    private Random randGen = new Random();
    private int loadComplete = 0;

    public ListingActivity()
    {
        _name = "Listing";
        string s1 = "This activity will help you reflect on the good things in your life ";
        string s2 = "by having you list as many things as you can in a certain area.";
        _description = s1 + s2;
    }

    public void Run()
    {
        LoadPrompts();
        DisplayStartingMessage(_name, _description);
        Console.WriteLine($"running for {_duration} seconds");
        ShowReady(3);
        DisplayPrompt();
        DisplayEndingMessage(_name, _duration, 8);
    }

    public string GetRandomPrompt()
    {
        int i = randGen.Next(1,_prompts.Count());
        return _prompts[i];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("\nList as many reponses as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        ShowPrompt();
    }

    private void ShowPrompt()
    {
        _count = 0;
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            _count++;
            Console.Write("> ");
            string pause = Console.ReadLine();
        }

        Console.WriteLine($"You listed {_count} items!\n");

    }

    private void LoadPrompts()
    {
        if (loadComplete == 0)
        {
            _prompts.Add("Who are people that you appreciate?");
            _prompts.Add("What are personal strengths of yours?");
            _prompts.Add("Who are people that you have helped this week?");
            _prompts.Add("When have you felt the Holy Ghost this month?");
            _prompts.Add("Who are some of your personal heroes?");
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
}

// There are behaviors for each activity that are completely unique to that activity.
// For example, the ListActivity also needs to provide behaviors for:

//     Get a random prompt
//     Get a list of responses from the user
