using System.Dynamic;

class ReflectingActivity : BaseActivity
{
    List<string> _scenarios;
    List<string> _questions;
    HashSet<int> _usedQuestions = new HashSet<int>();
    public ReflectingActivity(string activityName, string activityDescription) 
    : base(activityName, activityDescription)
    {
        _scenarios = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        ];
        _questions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep thi3s experience in mind in the future?"
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
            Consider the following prompt:

            --- {GenerateRandomScenarios()} ---

            When you have something in mind, press enter to continue.
            """
        );
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        RunCountDownMessage("You may begin in:", 5);
        AskQuestions();
    }
    private string GenerateRandomScenarios()
    {
        Random random = new Random();
        return _scenarios[random.Next(0, _scenarios.Count)];
    }
    private string GenerateRandomQuestion()
    {
        // Here I exceeded the requirements by making is such that questions are never repeated until all questions are used.
        if (_usedQuestions.Count == _questions.Count())
            _usedQuestions.Clear();
        Random random = new Random();
        int randomIndex;
        do
        {
            randomIndex = random.Next(0, _questions.Count);
        }
        while (_usedQuestions.Contains(randomIndex));
        _usedQuestions.Add(randomIndex);
        return _questions[randomIndex];
    }
    private void AskQuestions()
    {
        Console.Clear();
        StartTimer();
        while (!HasTimerExpired())
        {
            Console.Write($"> {GenerateRandomQuestion()} ");
            DisplaySpinner(6);
            Console.Write("\n");
        }
        Console.WriteLine("\n");
        EndActivity();
    }
}