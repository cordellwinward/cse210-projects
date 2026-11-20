using System.Diagnostics;
using System.IO;
using System.Windows.Markup;

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
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no recorded goals");
        }
        else if (_goals.Count > 0)
        {
            Console.WriteLine("Your goals are:");
            
            foreach (BaseGoal g in _goals)
            {
                Console.WriteLine(g.GetConsoleString());
            }
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
                    newGoal = new EternalGoal();
                    break;
                }
            case 3:
                {
                    // Checklist Goal
                    newGoal = new ChecklistGoal();
                    break;
                }
            case 4:
                {
                    // To exceed the requirements I added the StreakGoal class
                    // Streak Goal
                    newGoal = new StreakGoal();
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
            if (!_goals[goalAccomplished - 1].GetComplete()){
                int earned = _goals[goalAccomplished - 1].RecordEvent();
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

    public void WriteGoalsToFile()
    {
        Console.WriteLine("What would you like to call your save? (Do not include a file extension, i.e .txt)");
        string filename = $"{Console.ReadLine().Trim()}.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_points);
            foreach(BaseGoal g in _goals)
            {
                outputFile.WriteLine(g.FormatGoalForSave());
            }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What saved file would you like to load? (Do not include a file extension, i.e .txt)");
        string filename = $"{Console.ReadLine().Trim()}.txt";
        List<string> lines = new List<string>(System.IO.File.ReadAllLines(filename));
        _points = int.Parse(lines[0]);
        lines.RemoveAt(0);
        _goals.Clear();
        foreach (string line in lines)
        {
            string[] values = line.Split(",");
            string className = values[0].Trim();
            string name = values[1].Trim();
            string description = values[2].Trim();
            int points = int.Parse(values[3].Trim());
            bool complete = values[4].Trim().ToLower() == "true";
            switch (className)
            {
                case "SimpleGoal":
                {
                    _goals.Add(new SimpleGoal(name, description, points, complete));
                    break;
                }
                case "EternalGoal":
                {
                    int timesCompleted = int.Parse(values[5].Trim());
                    _goals.Add(new EternalGoal(name, description, points, complete, timesCompleted));
                    break;
                }
                case "ChecklistGoal":
                {
                    int timesCompleted = int.Parse(values[5].Trim());
                    int neededCompletions = int.Parse(values[6].Trim());
                    int bonusPoints = int.Parse(values[7].Trim());
                    _goals.Add(new ChecklistGoal(name, description, points, complete, timesCompleted, 
                        neededCompletions, bonusPoints));
                    break;
                }
                case "StreakGoal":
                {
                    int totalCompletions = int.Parse(values[5].Trim());
                    int Streak = int.Parse(values[6].Trim());
                    int LongestStreak = int.Parse(values[7].Trim());
                    int bonusPoints = int.Parse(values[8].Trim());
                    _goals.Add(new StreakGoal(name, description, points, complete, totalCompletions, 
                        Streak, LongestStreak, bonusPoints));
                    break;
                }
            }
        }
    }
}