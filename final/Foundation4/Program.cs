using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("2025-08-01", 30, 5.0),
            new Cycling("2025-08-02", 45, 20.0),
            new Swimming("2025-08-03", 40, 30)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
