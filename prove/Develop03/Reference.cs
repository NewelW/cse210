class Reference
{
    private string _book;
    private int _chapter;
    private int _start;
    private int _end;

    public Reference(string book, int chapter)
    {
        _book = book;
        _chapter = chapter;
        _start = 0;
        _end = 0;
    }

    public Reference(string book, int chapter, int start, int end)
    {
        _book = book;
        _chapter = chapter;
        _start = start;
        _end = end;
    }

    public string GetDisplayString()
    {
        return $"{_book} {_chapter}:{_start}-{_end}";
    }
}