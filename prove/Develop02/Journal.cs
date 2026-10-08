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
        
    }
    public void ReadFromFile(string filename)
    {
        
    }
}