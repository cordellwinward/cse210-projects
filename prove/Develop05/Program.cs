using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        BaseGoal myGoal = new BaseGoal("BaseGoal");
        Console.WriteLine(myGoal.GetConsoleString());
    }
}