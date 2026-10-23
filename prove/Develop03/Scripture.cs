using System.Globalization;

class Scripture
{
    private List<Word> _words;
    private Reference _reference;
    private HashSet<int> _hiddenWords = new HashSet<int>();

    public Scripture(string book_name, int chapter, int verse, string scripture_text)
    {
        // todo
        _reference = new Reference(book_name, chapter, verse);
        _words = ConvertToWordList(scripture_text);
    }
    public Scripture(string book_name, int chapter, int startVerse, int endVerse, string scripture_text)
    {
        _reference = new Reference(book_name, chapter, startVerse, endVerse);
        _words = ConvertToWordList(scripture_text);
    }
    public Scripture(Reference scripture_reference, string scripture_text)
    {
        _reference = scripture_reference;
        _words = ConvertToWordList(scripture_text);
    }

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
        _reference.Display();
        foreach(Word word in _words)
        {
            word.DisplayWord();
            
        }
        Console.Write("\n");
    }

    public bool HideWords()
    // I made it so that it always hides five words no matter how many are already hidden
    {
        // Returns True if all words are hidden
        Random random = new Random();
        for (int i = 5; i > 0; i -= 1)
        {
            if (_hiddenWords.Count == _words.Count)
            {
                break;
            }
                
            bool wordIsHidden = false;
            do
            {
                int tempRandom = random.Next(0, _words.Count);
                if (!_hiddenWords.Contains(tempRandom))
                {
                    _hiddenWords.Add(tempRandom);
                    _words[tempRandom].Hide();
                    wordIsHidden = true;
                }
            }
            while (wordIsHidden == false);

        }

        return _words.Count == _hiddenWords.Count;
        
    }

}
