using System.Security.Cryptography;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private string _response;
    private string _goalResponse;
    private string _shortName;
    private string _description;
    private string _points;
    private int _cnt;
    private int _bonusValue;

    // Declare goal handles
    private SimpleGoal _simple;
    private EternalGoal _eternal;
    private ChecklistGoal _check;
    
    // GoalManager constructor clears the _score when called
    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        while (_response != "6")
        {
            // Console.Clear();
            DisplayPlayerInfo();   // Displays current score
            Console.WriteLine("Menu Options:");
        	Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write    ("Select a choice from the menu: ");
            _response = Console.ReadLine();

            switch (_response)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("QUITING ***\n");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points\n");
    }

    private void CreateGoal()
    {
            Console.WriteLine($"\nThe types of Goals are:");
        	Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
            Console.Write    ("Which type of goal would you like to create?: ");
            _goalResponse = Console.ReadLine();

            Console.Write("What is the name of your goal? ");
            _shortName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            _description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            _points = Console.ReadLine();
            
            switch (_goalResponse)
            {
                case "1":
                    _simple  = new SimpleGoal (_shortName, _description, _points); 
                    _goals.Add(_simple);
                    break;
                case "2":
                    _eternal  = new EternalGoal (_shortName, _description, _points); 
                    _goals.Add(_eternal);
                    break;
                case "3":
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    _cnt = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    _bonusValue = int.Parse(Console.ReadLine());
                    _check = new ChecklistGoal(_shortName, _description, _points, _cnt, _bonusValue);
                    _goals.Add(_check);
                    break;
            }            
    }
    
    public void ListGoalDetails()
    {
        int i = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal g in _goals)
        {
            string s = g.GetDetailsString();
            Console.WriteLine($"{i.ToString()}. {s}");
            i++;
        }
    }

    public void SaveGoals()
    {
        // Console.Write("What is the filename for the goal file? ");
        // string filename = Console.ReadLine();
        string filename = "goals.txt"; // TODO - for rapid debug
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score); // This is line #1 in the output file   
            foreach (Goal g in _goals)
            {
                string s = g.GetStringRepresentation();
                outputFile.WriteLine(s);
            }
        }
    }
    
    public void LoadGoals()
    {
        // Since we are loading goals from a file, we need re-initilize the _goals list
        _goals = new List<Goal>();

        // Console.Write("What is the filename for the goal file? ");
        // string filename = Console.ReadLine();
        string filename = "goals.txt"; // TODO - for rapid debug
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        // First line in the file is the current score - no splitting required
        _score = int.Parse(lines[0]);

        // Read the rest of the lines from the file and split them
        for (int i = 1; i < lines.Count(); i++)
        {
            string[] parts = lines[i].Split(":");

            // parts[0] is the goal type
            string goalType = parts[0];

            // Split parts[1] into  multiple fields.
            // Depending on the goal type, there will be:
            // SimpleGoal - 4 fields / EternalGoal 3 fields / ChecklistGoal 6 fields
            string[] fields = parts[1].Split(",");

            // Construct the appropriate goalType and then reference the correct number of fields
            switch (goalType)
            {
                // Fields are [0] name, [1] description, [2] points, [3] complete?
                case "SimpleGoal":
                    _simple = new SimpleGoal(fields[0], fields[1], fields[2]);
                    _simple.SetIsComplete(fields[3]);
                    _goals.Add(_simple);                    
                    break;
                    
                // Fields are [0] name, [1] description, [2] points
                case "EternalGoal":
                    _eternal = new EternalGoal(fields[0], fields[1], fields[2]);
                    _goals.Add(_eternal);                  
                    break;

                // Fields are [0] name, [1] description, [2] points, [3] amount completed, [4] target, [5] bonus
                case "ChecklistGoal":
                    _check = new ChecklistGoal(fields[0], fields[1], fields[2], int.Parse(fields[4]), int.Parse(fields[5]));
                    _check.SetAmountCompleted(int.Parse(fields[3]));
                    _goals.Add(_check);                    
                    break;
            }
        }
    }

    public void RecordEvent()
    {
        int goalNumber;
        ListGoalDetails();
        Console.Write("Which goal did you accomplish: ");
        goalNumber = int.Parse(Console.ReadLine());

        // Select a goal from the list and call RecordEvent for that goal type - polymorphism!
        _goals[goalNumber-1].RecordEvent();
        _score += _goals[goalNumber-1].GetPoints();
    }
}