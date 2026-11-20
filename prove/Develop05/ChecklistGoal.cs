class ChecklistGoal : BaseGoal
{
    private int _timesCompleted;
    private int _neededCompletions;
    private int _bonusPoints;

    public ChecklistGoal() : base("ChecklistGoal")
    {
        _timesCompleted = 0;
        SetNeededCompletions();
        SetBonusPoints();
    }
    
    public ChecklistGoal(string name, string description, int points, 
        bool complete, int timesCompleted, int neededCompletions, int bonusPoints) :
        base(name, description, points, complete, "ChecklistGoal")
    {
        _bonusPoints = bonusPoints;
        bool timesCompletedDefaultSet = false;
        bool neededCompletionsDefaultSet = false;
        if (timesCompleted >= 0)
        {
            _timesCompleted = timesCompleted;
        }
        else
        {
            _timesCompleted = 0;
            timesCompletedDefaultSet = true;
        }
        if (neededCompletions >= 1 && neededCompletions <= _timesCompleted)
        {
            _neededCompletions = neededCompletions;
        }
        else
        {
            _neededCompletions = timesCompleted + 1;
            timesCompletedDefaultSet = true;
        }
        if (complete == true && neededCompletions != timesCompleted)
        {
            if (!timesCompletedDefaultSet || neededCompletionsDefaultSet)
            {
                _neededCompletions = timesCompleted;
            }
            else
            {
                _timesCompleted = _neededCompletions;
            }
        }
    }

    private void SetBonusPoints()
    {
        Console.Write($"How many Bonus points for Completing your {base.GetName()} goal {_neededCompletions} times: ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    private void SetNeededCompletions()
    {
        Console.Write($"How many times do you need to complete {base.GetName()} goal: ");
        int neededCompletionsInput = int.Parse(Console.ReadLine());
        if (neededCompletionsInput > 0)
        {
            _neededCompletions = neededCompletionsInput;
        }
        else
        {
            Console.WriteLine("Needed completions defaulted to 1 because you every goal must be completed at least 1 time.");
        }
    }

    public override int RecordEvent()
    {
        ++_timesCompleted;
        if (_timesCompleted == _neededCompletions)
        {
            MarkComplete();
            return GetPoints() + _bonusPoints;
        }
        else
        {
            return GetPoints();
        }
    }

    public override string GetConsoleString()
    {
        return $"{base.GetConsoleString()} -- Currently Completed: {_timesCompleted}/{_neededCompletions}";
    }

}