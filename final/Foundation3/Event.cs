public abstract class Event
{
    string _title;
    string _description;
    string _date;
    string _time;
    string _address;

    //-----------------------------------
    //*** Derivative class attributes ***
    // string _speaker; // Lecture only
    // int _capacity;   // Lecture only
    // string _email;   // Reception only
    // string _weather; // Outdoor only
    //-----------------------------------

    public Event(string title, string description, string date, string time, string address)
    {
        _title       = title;
        _description = description;
        _date        = date;
        _time        = time;
        _address     = address;
    }

    protected string GetStandardDetails()
    {
        return $"Event title: {_title}\nDescription: {_description}\nDate       : {_date}\nTime       : {_time}\n{_address}";
    }
    public void DisplayStandardDetails(string type)
    {
        Console.WriteLine($"****** {type} EVENT DETAILS ******");   
        Console.WriteLine(GetStandardDetails());
        PrintDashSeparator();
    }

    public abstract void DisplayFullDetails();

    public abstract void DisplayShortDescription();

    protected string GetTitle()
    {
        return _title;
    }

    protected string GetDate()
    {
        return _date;
    }
        
    protected void PrintDashSeparator()
    {
        Console.WriteLine("------------------------------------------------");   
    }
}