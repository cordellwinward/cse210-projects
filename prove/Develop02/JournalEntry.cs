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
        List<string> prompts = [
            "How was your day?"
        ];
        _prompt = prompts[0];
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