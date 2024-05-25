public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;
    private int totalPoints;

    public Goal(string name, string description, string points)
    {
        _shortName   = name;
        _description = description;
        _points      = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    // Return the details of a goal that could be shown in a list
    public virtual string GetDetailsString()
    {
        string checkBox;
        if (IsComplete())
        {
            checkBox = "[X]";
        }
        else
        {
            checkBox = "[ ]";
        }
        string detailsString = $"{checkBox} {_shortName} ({_description})";
        return detailsString;
    }

    // Provide all details of a goal that is easy to save to a file
    public abstract string GetStringRepresentation();

    public int GetPoints()
    {
        return totalPoints;
    }

    protected void CongratsMessage(int points, int bonus)
    {
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        if (bonus > 0)
        {
            Console.WriteLine($"Congratulations! You have also earned {bonus} bonus points!");
        }
        totalPoints = points + bonus;
    }
}