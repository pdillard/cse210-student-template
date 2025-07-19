using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("100 College Ave", "Rexburg", "ID", "USA");
        Event lecture = new Lecture("CSE Conference", "Programming with C#", "2025-08-01", "10:00 AM", lectureAddress, "Dr. Smith", 100);

        Address receptionAddress = new Address("500 Event Blvd", "Boise", "ID", "USA");
        Event reception = new Receptions("Networking Night", "Meet industry professionals", "2025-08-05", "6:00 PM", receptionAddress, "rsvp@events.com");

        Address outdoorAddress = new Address("200 Park Lane", "Seattle", "WA", "USA");
        Event outdoor = new OutdoorGathering("Summer Festival", "Enjoy live music and food", "2025-08-10", "2:00 PM", outdoorAddress, "Sunny, 75°F");

        List<Event> events = new List<Event> { lecture, reception, outdoor };

        foreach (Event e in events)
        {
            {
            Console.WriteLine("--- Standard Details ---");
            Console.WriteLine(e.StandardDetails());
            Console.WriteLine("\n--- Full Details ---");
            Console.WriteLine(e.FullDetails());
            Console.WriteLine("\n--- Short Description ---");
            Console.WriteLine(e.ShortDetails());
            Console.WriteLine("\n============================\n");
        }
        } 
    }
}