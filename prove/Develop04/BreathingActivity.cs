class BreathingActivity : BaseActivity
{
    public BreathingActivity(string activityName, string activityDescription) 
    : base(activityName, activityDescription)
    {
        
    }
    public void RunActivity()
    {
        StartActivity();
        Console.Clear();
        RunSpinnerMessage("Get Ready...", 3);
        Console.WriteLine("\n");
        StartTimer();
        while (!HasTimerExpired())
        {
            RunCountDownMessage("Breath in...", 4);
            RunCountDownMessage("Breath Out...", 6);
            Console.WriteLine("");
        }
        EndActivity();
    }
}