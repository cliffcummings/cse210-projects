public class CyclingActivity : Activity
{
    public CyclingActivity(double distance, int minutes, string date) : base (distance, minutes, date)
    {
        _distance     = distance;
        _minutes      = minutes;
        _date         = date;
        _activityType = "Cycling";
    }

    public override double GetDistance()
    {
        return _distance;
    }
}