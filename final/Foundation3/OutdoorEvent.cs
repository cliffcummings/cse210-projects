public class OutdoorEvent : Event
{
    private string _weather; // Outdoor only

    public OutdoorEvent(string title, string description, string date, string time, string address, string weather) : base (title, description, date, time, address)
    {
        _weather = weather;
    }
    
    public override void DisplayFullDetails()
    {
        string standardDetails = GetStandardDetails();
        Console.WriteLine("*** OUTDOOR EVENT - FULL DETAILS ***");
        Console.WriteLine($"Event type : Outdoor Event\nWeather Conditions: {_weather}\n{standardDetails}");
        PrintDashSeparator();
    }
    
    public override void DisplayShortDescription()
    {
        string eventString = "Event Title: " + GetTitle() + " - Date: " + GetDate();
        Console.WriteLine("*** OUTDOOR EVENT - SHORT DESCRIPTION ***");
        Console.WriteLine(eventString);
        PrintDashSeparator();
    }
}