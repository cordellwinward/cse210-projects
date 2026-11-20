using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Goals goals = new Goals();
        // Console.WriteLine("Hello Develop05 World!");
        // BaseGoal myGoal = new BaseGoal("BaseGoal");
        // Console.WriteLine(myGoal.GetConsoleString());

        // Console.WriteLine($"MainMenuTest: {mainMenuTest} GoalMenuTest {GoalMenuTest}");

        // SimpleGoal mySimpleGoal = new SimpleGoal();
        // Console.WriteLine(mySimpleGoal.GetConsoleString());
        // mySimpleGoal.MarkComplete();
        // Console.WriteLine(mySimpleGoal.GetConsoleString());
        bool program_running = true;
        while (program_running)
        {
        Console.WriteLine();
        goals.DisplayPoints();
        Console.WriteLine();
        int mainMenuChoice = menu.DisplayMainMenu();
        switch (mainMenuChoice)
            {
                case 1:
                {
                    // Create new goal
                    goals.CreateNewGoal();
                    break;
                }
                case 2:
                    {
                        // List Goals
                        goals.DisplayGoals();
                        break;
                    }
                case 3:
                    {
                        // Save Goals
                        
                        break;
                    }
                case 4:
                    {
                        // Load Goals

                        break;
                    }
                case 5:
                    {
                        // Record Event
                        goals.RecordEvent();
                        break;
                    }
                case 6:
                    {
                        // quit
                        program_running = false;
                        break;
                    }
            }
            
        }
    }
}