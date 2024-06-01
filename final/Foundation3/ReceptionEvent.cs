public class ReceptionEvent : Event
{
    private string _email; // Reception only

    public ReceptionEvent(string title, string description, string date, string time, string address, string email) : base (title, description, date, time, address)
    {
        _email = email;
    }

    public override void DisplayFullDetails()
    {
        string standardDetails = GetStandardDetails();
        Console.WriteLine("*** RECEPTION EVENT - FULL DETAILS ***");
        Console.WriteLine($"Event type : Reception Event\nEmail      : {_email}\n{standardDetails}");
        PrintDashSeparator();
    }

    public override void DisplayShortDescription()
    {
        string eventString = "Event Title: " + GetTitle() + " - Date: " + GetDate();
        Console.WriteLine("*** RECEPTION EVENT - SHORT DESCRIPTION ***");
        Console.WriteLine(eventString);
        PrintDashSeparator();
    }
}