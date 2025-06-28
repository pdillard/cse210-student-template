public class EternalGoal : Goal
{
    private int count;

    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        count = 0;
    }

    public override void RecordEvent() => count++;

    public override bool IsComplete() => false;

    public override int GetPoints() => Points;

    public override string Display() => $"[∞] {Name} ({Description}) — Completed {count} times";

    public override string Serialize() => $"EternalGoal:{Name}|{Description}|{Points}|{count}";
}