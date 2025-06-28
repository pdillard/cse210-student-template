public class SimpleGoal : Goal
{
    private bool isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        isComplete = false;
    }

    public override void RecordEvent() => isComplete = true;

    public override bool IsComplete() => isComplete;

    public override int GetPoints() => isComplete ? Points : 0;

    public override string Display() => $"[ {(isComplete ? "X" : " ")} ] {Name} ({Description})";

    public override string Serialize() => $"SimpleGoal:{Name}|{Description}|{Points}|{isComplete}";
}