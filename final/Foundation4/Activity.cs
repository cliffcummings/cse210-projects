public abstract class Activity
{
    protected double _distance;
    protected double _speed;
    protected double _pace;
    protected string _date;
    protected int    _minutes;
    protected string _activityType;

    public Activity(double distance, int minutes, string date)
    {
        _distance = distance;
        _minutes  = minutes;
        _date     = date;
    }

    // Not required in other derived Activity classes
    public string GetSummary()
    {
        _speed    = GetSpeed();
        _pace     = GetPace();
        _distance = GetDistance();

        string speed = _speed.ToString($"F1");
        string pace = _pace.ToString($"F1");
        string distance = _distance.ToString($"F1");
        string minutes = _minutes.ToString();
        
        string summaryString = $"{_date} {_activityType} ({minutes} min)- Distance ";
        summaryString += $"{distance} miles, Speed: {speed} mph. Pace: {pace} min per mile";
        return summaryString;
    }

    public abstract double GetDistance();

    protected double GetSpeed()
    {
        return 60 * GetDistance() / _minutes;
    }

    protected double GetPace()
    {
        return 60 / GetSpeed();
    }
}