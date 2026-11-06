using System.Reflection.PortableExecutable;

class BaseActivity
{
    // COMPLETE
    private int _duration;
    private DateTime _endTime;
    private string _activityName;
    private string _description;

    public BaseActivity(string activityName, string activityDescription)
    {
        _duration = 30; // Replace with call to ObtainDuration
        _activityName = activityName; // Replace with parameter in constructor
        _description = activityDescription;
    }

    protected void StartTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    protected bool HasTimerExpired()
    {
        return DateTime.Now > _endTime;
    }
    private void GetTimerLength()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine().Trim());
    }

    protected void StartActivity()
    {
        Console.Clear();
        Console.WriteLine(
        $"""
        Welcome to the {_activityName}.

        {_description}

        """
        );
        GetTimerLength();
    }

    protected void EndActivity()
    {
        RunSpinnerMessage((
            $"""
            Well Done!

            You have completed another {_duration} seconds of the {_activityName}
            """
            ), 5);
    }


    protected void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        for (int i = seconds; i>0; i--)
        {
            // Console.Clear();
            string written = $"{message} {i}";
            Console.Write($"{written}");
            Thread.Sleep(1000);
            foreach (char c in written)
            {
                Console.Write("\b");
            }
            foreach (char c in written)
            {
                Console.Write(" ");
            }
            foreach (char c in written)
            {
                Console.Write("\b");
            }
        }
        Console.WriteLine($"{message}");
        Console.CursorVisible = true;
    }

    protected void RunSpinnerMessage(string message, int seconds)
    {
        Console.WriteLine(message);
        DisplaySpinner(seconds);
    }
    protected void DisplaySpinner(int seconds)
    {
        Console.CursorVisible= false;
        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(seconds);
        string spinnerCharacters = "\\|/—";
        int index = 0;
        while(DateTime.Now < endTime)
        {
            Console.Write($"{spinnerCharacters[index++ % spinnerCharacters.Length]}");
            Thread.Sleep(200);
            Console.Write("\b");
        }
        Console.Write("\b  ");
        Console.CursorVisible= true;
    }

    
}