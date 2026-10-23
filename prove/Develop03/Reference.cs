class Reference
{
    private string _book;
    private int _chapter;
    private int[] _verse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = [verse];
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = [startVerse, endVerse];
    }
    public string Format()
    {
        if (_verse.Length == 1)
        {
            return $"{_book} {_chapter}:{_verse[0]}";
        }
        else {
            return $"{_book} {_chapter}:{_verse[0]}-{_verse[1]}";
        }
    }

    public void Display()
    {
        Console.WriteLine(Format());
    }
}

