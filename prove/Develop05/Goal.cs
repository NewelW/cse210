public abstract class Goal
{
    private string _title = "";
    private string _description = "";
    private int _points = 0;

    protected Goal(string title, string description, int points)
    {
        _title = title.Replace(";", "");
        _description = description.Replace(";", "");
        _points = points;
    }

    public abstract void Display();
    public abstract string GetSaveString();
    public abstract int GoalFinish();

    protected string GetTitle()
    {
        return _title;
    }
    protected string GetDescription()
    {
        return _description;
    }
    protected int GetPoints()
    {
        return _points;
    }
}
