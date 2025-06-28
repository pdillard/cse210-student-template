public class Program
{
    public static void Main()
    {
        GoalManager manager = new GoalManager();
        while (true)
        {
            Console.WriteLine($"\nYou have {manager.GetTotalPoints()} points.\n");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("   1. Create Goal\n   2. List Goals\n   3. Record Event\n   4. Save\n   5. Load\n   6. Quit");
            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("The types of Goals are: ");
                    Console.WriteLine("   1. Simple Goal\n   2. Eternal Goal\n   3. Checklist Goal");
                    Console.Write("Choose goal type: ");
                    string type = Console.ReadLine();
                    Console.Write("Name of your Goal: ");
                    string name = Console.ReadLine();
                    Console.Write("Short Description of Goal: ");
                    string desc = Console.ReadLine();
                    Console.Write("Number of Points with this Goal: ");
                    int pts = int.Parse(Console.ReadLine());

                    if (type == "1")
                        manager.AddGoal(new SimpleGoal(name, desc, pts));
                    else if (type == "2")
                        manager.AddGoal(new EternalGoal(name, desc, pts));
                    else if (type == "3")
                    {
                        Console.Write("Target Count: ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("Bonus Points: ");
                        int bonus = int.Parse(Console.ReadLine());
                        manager.AddGoal(new ChecklistGoal(name, desc, pts, target, bonus));
                    }
                    break;
                case "2":
                    manager.DisplayGoals();
                    break;
                case "3":
                    manager.DisplayGoals();
                    Console.Write("Which goal to record?: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(index);
                    break;
                case "4":
                    Console.Write("Filename to save: ");
                    manager.SaveToFile(Console.ReadLine());
                    break;
                case "5":
                    Console.Write("Filename to load: ");
                    manager.LoadFromFile(Console.ReadLine());
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.\n");
                    break;
            }
        }
    }
}