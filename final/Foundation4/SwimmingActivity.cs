public class SwimmingActivity : Activity
{
    double _laps;

    // For the SwimmingActivity, the user enters distance in LAPS and GetDistance returns the equivalent
    // distance. 
    // Distance is equal to #Laps * 50 m/Lap * 1 km/1000 m * 0.62 mile/km = miles (Laps, m, km units all cancel)
    public SwimmingActivity(double distance, int minutes, string date) : base (distance, minutes, date)
    {
        _laps         = distance;  // distance is entered as # of Laps
        _minutes      = minutes;
        _date         = date;
        _activityType = "Swimming";
    }

    // Distance is equal to #Laps * 50 m/Lap * 1 km/1000 m * 0.62 mile/km = miles (Laps, m, km units all cancel)
    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000 * 0.62;
        return distance;
    }
}