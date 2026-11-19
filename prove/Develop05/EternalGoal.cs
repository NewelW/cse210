public class EternalGoal : Goal
{
    public EternalGoal(string title, string description, int points) : base (title, description, points)
    {
        
    }
    public override void Display()
    {
        Console.WriteLine($"♻️  {GetTitle()}({GetDescription()})");
    }

    public override string GetSaveString()
    {
        return $"EternalGoal;{GetTitle()};{GetDescription()};{GetPoints()};";
    }

    public override int GoalFinish()
    {
        return GetPoints();
    }
}
