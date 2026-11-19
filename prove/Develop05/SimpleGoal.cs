public class SimpleGoal : Goal
{
    private bool _completed = false;
    public SimpleGoal(string title, string description, int points, bool completed = false) : base (title, description, points)
    {
        _completed = completed;
    }
    public override void Display()
    {
        string completed = " ";
        if (_completed)
        {
            completed = "x";
        }
        Console.WriteLine($"[{completed}] {GetTitle()}({GetDescription()})");
    }

    public override string GetSaveString()
    {
        return $"SimpleGoal;{GetTitle()};{GetDescription()};{GetPoints()};{_completed}";
    }

    public override int GoalFinish()
    {
        if (!_completed)
        {
            _completed = true;
            return GetPoints();
        }
        return 0;
    }
}
