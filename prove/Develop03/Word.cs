class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
    public void Hide()
    {
        _isHidden = true;
    }

    public string GetWordString()
    {
        string returnString = "";
        if (_isHidden)
        {
            // for (int i = 0; i < _word.Length; i++)
            foreach(char c in _word)
            {
                returnString += "_";
            }
        }
        else
        {
            returnString = _word;
        }
        return returnString;
    }

    public void DisplayWord()
    {
        Console.Write($"{GetWordString()} ");
    }
}