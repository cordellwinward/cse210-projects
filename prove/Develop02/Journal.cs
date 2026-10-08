class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();

    public void CreateJournalEntry()
    {
     JournalEntry newEntry = new JournalEntry(); 
     newEntry.CreateJournalEntry();
     _entries.Add(newEntry);
    }
    public void DisplayJournal()
    {
        foreach(JournalEntry entry in _entries)
        {
            entry.DisplayJournalEntry();
        }
    }
    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        { 
            foreach(JournalEntry entry in _entries)
            {
                outputFile.WriteLine(entry.CreateFileSystemString());
                }
                }

    }
    public void ReadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("#");
            string date = parts[0];
            string question = parts[1];
            string entryText = parts[2];
            JournalEntry entry = new JournalEntry();
            entry.CreateJournalEntryFromFile(date, question, entryText);
            _entries.Add(entry);
            }

    }
}