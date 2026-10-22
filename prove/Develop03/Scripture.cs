class Scripture
{
    private List<Word> _words;
    // TODO -- Add scripture Reference

    public Scripture(string book_name, int chapter, int verse, string scripture_text)
    {
        // todo
        _words = ConvertToWordList(scripture_text);
    }
    public Scripture(string book_name, int chapter, int startVerse, int endVerse, string scripture_text)
    {
     // todo   
    }
    // - Add constructor for ScriptureReference

    private List<Word> ConvertToWordList(string scripture_text)
    {
        List<Word> tempWordList = new List<Word>();
        string[] tempWords = scripture_text.Split(" ");
        foreach(string w in tempWords)
        {
            Word tempWord = new Word(w);
            tempWordList.Add(tempWord);
        }
        return tempWordList;
    }
    public void ShowScripture()
    {
        foreach(Word word in _words)
        {
            word.DisplayWord();
            
        }
    }
}
