public class RunningActivity : Activity
{
    public RunningActivity(double distance, int minutes, string date) : base (distance, minutes, date)
    {
        _distance     = distance;
        _minutes      = minutes;
        _date         = date;
        _activityType = "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }
}