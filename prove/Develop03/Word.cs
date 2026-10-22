class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = !_isHidden;
    }

    public string GetDisplayString(bool showFirstLetter)
    {
        if (int.TryParse(_text, out int ignored))
        {
            return $"{_text}";
        }

        if (showFirstLetter && _isHidden)
        {
            return $"{_text[0]}" + new string('_', _text.Length - 1);
        }

        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        return $"{_text}";
    }
}