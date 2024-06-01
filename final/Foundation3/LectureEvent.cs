using System.Reflection;

public class LectureEvent : Event
{
    private string _speaker; // Lecture only
    private int _capacity;   // Lecture only

    public LectureEvent(string title, string description, string date, string time, string address, string speaker, int capacity) : base (title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    
    public override void DisplayFullDetails()
    {
        string standardDetails = GetStandardDetails();
        Console.WriteLine("*** LECTURE EVENT - FULL DETAILS ***");
        Console.WriteLine($"Event type : Lecture Event\nSpeaker    : {_speaker}\nCapacity   : {_capacity}\n{standardDetails}");
        PrintDashSeparator();
    }
    
    public override void DisplayShortDescription()
    {
        string eventString = "Event Title: " + GetTitle() + " - Date: " + GetDate();
        Console.WriteLine("*** LECTURE EVENT - SHORT DESCRIPTION ***");
        Console.WriteLine(eventString);
        PrintDashSeparator();
    }
}