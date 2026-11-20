using System.Diagnostics;

class Goals
{
    private List<BaseGoal> _goals;
    private int _points;

    public Goals()
    {
        _goals = [];
        _points = 0;
    }

    public void DisplayGoals()
    {
        foreach (BaseGoal g in _goals)
        {
            Console.WriteLine(g.GetConsoleString());
        }
    }

    public void DisplayPoints()
    {
        Console.WriteLine($"You have {_points} points");
    }

    public void CreateNewGoal()
    {
        Menu menu = new Menu();
        int goalType = menu.DisplayGoalTypeMenu();
        BaseGoal newGoal = null;
        switch(goalType){
            case 1:
                {
                    // Simple Goal
                    newGoal = new SimpleGoal();
                    break;
                }
            case 2:
                {
                    // Eternal Goal
                    break;
                }
            case 3:
                {
                    // Checklist Goal
                    break;
                }
            
        }
        if (newGoal != null)
            _goals.Add(newGoal);
    }

    public void RecordEvent()
    {
        int goalNumber = 0;
        foreach (BaseGoal g in _goals)
        {
            Console.WriteLine($"{++ goalNumber}. {g.GetName()}");
        }
        Console.Write("Which goal did you accomplish? ");
        try
        {
            int goalAccomplished = int.Parse(Console.ReadLine());
            if (goalAccomplished < 0 || goalAccomplished > goalNumber)
            {
                throw new FormatException("Goal value does not exist");
            }
            if (!_goals[goalNumber - 1].GetComplete()){
                int earned = _goals[goalNumber - 1].RecordEvent();
                _points += earned;
                Console.WriteLine(
                    $"""
                    Congratulations! You have earned {earned} points!
                    You now have {_points} points.
                    """
                );
            }
            else
                {
                    Console.WriteLine("You may not record an event on a complete goal.");
                }
            
        }
        catch (FormatException)
        {
            Console.WriteLine("Event was not recorded. No goal number matching your input exists");
        }
    }
}