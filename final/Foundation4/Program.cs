using System;
using System.Collections.Generic;
using FitnessApp;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("05 Dec 2022", 30, 3.0);
        activities.Add(running);

        Swimming swimming = new Swimming("07 Dec 2022", 30, 10);
        activities.Add(swimming);

        Cycling bicycles = new Cycling("09 Dec 2024", 30, 15.0);
        activities.Add(bicycles);

        foreach (Activity activity in activities)
        {
            activity.DisplaySummary();
        }
    }
}