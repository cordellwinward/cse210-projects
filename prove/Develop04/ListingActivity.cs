class ListingActivity : BaseActivity
{
    private List<string> _prompts;
    public ListingActivity(string activityName, string activityDescription) 
    : base(activityName, activityDescription)
    {
        _prompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];
    }

    public void RunActivity()
    {
        StartActivity();
        Console.Clear();
        RunSpinnerMessage("Get Ready...", 3);
        Console.WriteLine("\n");
        Console.WriteLine(
            $"""
            List as many responses as you can to the following prompt:
            --- {GenerateRandomPrompt()} ---
            """
        );
        RunCountDownMessage("You may begin in:", 5);
        StartTimer();
        int thingsListed = 0;
        while (!HasTimerExpired())
        {
            Console.Write("> ");
            Console.ReadLine();
            thingsListed++;
        }
        Console.WriteLine($"You listed {thingsListed} items!\n");
        EndActivity();
    }

    private string GenerateRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(0, _prompts.Count)];
    }
    
}