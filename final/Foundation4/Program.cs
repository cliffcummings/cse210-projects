using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        RunningActivity  running;
        CyclingActivity  cycling;
        SwimmingActivity swimming;

        //--------------------------------------------------------
        // Add all activities
        //--------------------------------------------------------
        running = new RunningActivity(3, 30, "03 Nov 2022");
        AddActivity(running);

        cycling = new CyclingActivity(10, 35, "05 May 2024");
        AddActivity(cycling);

        swimming = new SwimmingActivity(40, 41, "01 Jun 2024");
        AddActivity(swimming);

        //--------------------------------------------------------
        // Display Activities
        //--------------------------------------------------------
        Console.Clear();
        Console.WriteLine("\n*** Beginning of Activity List ***");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine("*** End of Activity List ***\n");
        //--------------------------------------------------------

        void AddActivity (Activity activity)
        {
            activities.Add(activity);
        }
    }
}