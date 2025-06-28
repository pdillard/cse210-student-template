public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalPoints = 0;

    public void AddGoal(Goal goal) => goals.Add(goal);

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            goals[index].RecordEvent();
            totalPoints += goals[index].GetPoints();
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Display()}");
        }
    }

    public void SaveToFile(string filename)
    {
        File.WriteAllLines(filename, goals.Select(g => g.Serialize()));
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename)) return;
        string[] lines = File.ReadAllLines(filename);
        goals.Clear();
        foreach (var line in lines)
        {
            var parts = line.Split(':');
            var type = parts[0];
            var data = parts[1].Split('|');
            switch (type)
            {
                case "SimpleGoal":
                    goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2])));
                    break;
                case "EternalGoal":
                    goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                    break;
                case "ChecklistGoal":
                    var cg = new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[4]), int.Parse(data[5]));
                    for (int i = 0; i < int.Parse(data[3]); i++) cg.RecordEvent();
                    goals.Add(cg);
                    break;
            }
        }
    }

    public int GetTotalPoints() => totalPoints;
}