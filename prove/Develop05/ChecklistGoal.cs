public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        this.targetCount = targetCount;
        this.currentCount = 0;
        this.bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        if (currentCount < targetCount)
            currentCount++;
    }

    public override bool IsComplete() => currentCount >= targetCount;

    public override int GetPoints() => IsComplete() ? Points + bonusPoints : Points;

    public override string Display() => $"[ {currentCount}/{targetCount} ] {Name} ({Description})";

    public override string Serialize() => $"ChecklistGoal:{Name}|{Description}|{Points}|{currentCount}|{targetCount}|{bonusPoints}";
}