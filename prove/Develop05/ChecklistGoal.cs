public class ChecklistGoal : Goal
{
    private int _timesCompleted = 0;
    private int _completionGoal = 0;
    private int _extraPoints = 0;
    public ChecklistGoal(string title, string description, int points, int timesCompleted, int completionGoal, int extraPoints) : base(title, description, points)
    {
        _timesCompleted = timesCompleted;
        _completionGoal = completionGoal;
        _extraPoints = extraPoints;
    }
    public override void Display()
    {
        Console.WriteLine($"[{_timesCompleted}/{_completionGoal}] {GetTitle()}({GetDescription()})");
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal;{GetTitle()};{GetDescription()};{GetPoints()};{_timesCompleted};{_completionGoal};{_extraPoints}";
    }

    public override int GoalFinish()
    {
        if (_timesCompleted+1 == _completionGoal)
        {
            _timesCompleted++;
            return GetPoints() + _extraPoints;
        }
        if (!(_timesCompleted >= _completionGoal))
        {
            _timesCompleted++;
            return GetPoints();
        }
        return 0; // TODO Fix up if we know we want to give points after done.
    }
}
