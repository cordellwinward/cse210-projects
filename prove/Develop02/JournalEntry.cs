using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;


    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt},");
        Console.WriteLine($"{_response}");
    }


    public void CreateJournalEntry()
    {
        _date = DateTime.Now.ToString();
        // To exceed the requirements I added the option for the user to write there own prompt for the day
        string custom_prompt;
        do{
            Console.Write("Would you like to write your own prompt for today's entry? (yes/no) ");
            custom_prompt = Console.ReadLine().ToLower();
            if (custom_prompt!= "yes" && custom_prompt != "no")
            {
                Console.WriteLine("That is an invalid response. Please enter 'yes' or 'no'.");
            }
        }
        while(custom_prompt!= "yes" && custom_prompt != "no");
        if (custom_prompt == "yes")
            {
                Console.WriteLine("Please enter your custom prompt for today:");
                _prompt = Console.ReadLine();
            }
        else if (custom_prompt == "no" )
        {
            List<string> prompts = [
                "How was my day?",
                "What was the best thing that happened today?",
                "What would I do different today if I could?",
                "What is something unexpected that happened today?",
                "Where did the Lord help me today?"
            ];
            Random random = new Random();
            _prompt = prompts[random.Next(0, prompts.Count())];
        }
        Console.WriteLine($"{_prompt}: ");
        _response = Console.ReadLine();
    }

    public void CreateJournalEntryFromFile(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public string CreateFileSystemString()
    {
        return $"{_date}#{_prompt}#{_response}";
    }
}