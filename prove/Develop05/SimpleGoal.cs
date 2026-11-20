class SimpleGoal : BaseGoal
{
    public SimpleGoal(string name, string description, int points, bool complete) :
    base(name, description, points, complete, "SimpleGoal")
    {
    }
    public SimpleGoal() : base("SimpleGoal")
    {   
    }

    public override int RecordEvent()
    {
        MarkComplete();
        return GetPoints();
    }
}