class EternalGoal : BaseGoal
{
    private int _timesCompleted;
    public EternalGoal() : base ("EternalGoal")
    {
        _timesCompleted = 0;
    }

    public EternalGoal(string name, string description, int points, bool complete, int timesCompleted) :
    base(name, description, points, complete, "EternalGoal")
    {
        if (timesCompleted >= 0)
            _timesCompleted = timesCompleted;
        else
        {
            _timesCompleted = 0;
        }
    }

    public override int RecordEvent()
    {
        ++_timesCompleted;
        return GetPoints();
    }

    public override string GetConsoleString()
    {
        return $"{base.GetConsoleString()} -- Times Completed: {_timesCompleted}";
    }
}