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
}