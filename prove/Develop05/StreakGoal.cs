using System.Threading.Channels;

class StreakGoal : BaseGoal
{
    // To exceed the requirements I added another type of goal, the StreakGoal
    private int _totalCompletions;
    private int _streakLength;
    private int _longestStreak;
    private int _bonusPoints;
    public StreakGoal() : base ("StreakGoal")
    {
        _totalCompletions = 0;
        SetBonusPoints();
    }

    public StreakGoal(string name, string description, int points, bool complete, 
    int totalCompletions, int streakLength, int longestStreak, int bonusPoints) :
    base(name, description, points, complete, "StreakGoal")
    {
        _bonusPoints = bonusPoints;
        if (totalCompletions >= 0)
            _totalCompletions = totalCompletions;
        else
        {
            _totalCompletions = 0;
        }

        if (streakLength > 0)
        {
            _streakLength = streakLength;
        }
        else
        {
            _streakLength = 0;
        }
        if (longestStreak > 0)
        {
            _longestStreak = longestStreak;
        }
        else
        {
            _longestStreak = 0;
        }
        if (_streakLength > _longestStreak)
        {
            _longestStreak = _streakLength;
        }
    }

    private void SetBonusPoints()
    {
        Console.Write($"How many Bonus points per completion for maintaining your {base.GetName()} goal streak: ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override int RecordEvent()
    {
        ++_totalCompletions;
        Console.Write("Did you complete this goal yesterday (y/n)? ");
        bool streakBroken = Console.ReadLine().Trim().ToLower() == "n";
        if (streakBroken)
        {
            _streakLength = 0;
        }
        else if (!streakBroken)
        {
            ++_streakLength;
            if (_streakLength > _longestStreak){
                _longestStreak = _streakLength;
            }
        }
        return GetPoints() + (_bonusPoints * _streakLength);
    }

    public override string GetConsoleString()
    {
        return $"{base.GetConsoleString()} Streak Bonus: {_streakLength * _bonusPoints} -- Streak: {_streakLength} Longest: {_longestStreak} Total Completions: {_totalCompletions}";
    }

    public override string FormatGoalForSave()
    {
        return $"{base.FormatGoalForSave()},{_totalCompletions},{_streakLength},{_longestStreak},{_bonusPoints}";
    }

}