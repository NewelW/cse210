class Scripture
{
    private List<Word> _words;
    private List<int> _randomIndexList;
    private int _randomIndex = 0;
    private Reference _reference;
    private bool _showFirstLetter;

    public Scripture(string scriptureReference, bool showFirstLetter)
    {
        List<string> scriptureList = new List<string>(scriptureReference.Split("\n"));

        scriptureList.RemoveAt(scriptureList.Count - 1);
        scriptureList.RemoveAll(str => str == "");
        string[] fullRefs = scriptureList[^1].Replace(":", " ").Replace("–", " ").Split(" ");
        Reference reference = new Reference(fullRefs[0], int.Parse(fullRefs[1]), int.Parse(fullRefs[2]), int.Parse(fullRefs[3]));
        scriptureList.RemoveAt(scriptureList.Count - 1);

        List<Word> words = new List<Word>();

        foreach (string str in scriptureList)
        {
            foreach (string wordSplit in str.Split(" "))
            {
                Word word = new Word(wordSplit);
                words.Add(word);
            }
        }

        _reference = reference;
        _words = words;
        Random random = new Random();
        _randomIndexList = new List<int>(Enumerable.Range(0, words.Count()).Shuffle());
        _showFirstLetter = showFirstLetter;
    }

    public void DisplayScripture()
    {
        string scriptureOutput = "";
        foreach (Word word in _words)
        {
            if (int.TryParse(word.GetDisplayString(_showFirstLetter), out int ignored))
            {
                scriptureOutput += $"\n\n";
            }
            scriptureOutput += $"{word.GetDisplayString(_showFirstLetter)} ";
        }
        Console.WriteLine($"{_reference.GetDisplayString()}{scriptureOutput}");
    }
    public void HideRandomWords()
    {
        for (int i = 0; i < 3; i++)
        {
            if (_randomIndexList.Count() >= _randomIndex + 1)
            {
                _words[_randomIndexList[_randomIndex]].Hide();
                _randomIndex++;
            }
        }
    }

    public void ToggleHideFirstLetter()
    {
        _showFirstLetter = !_showFirstLetter;
    }
    public bool FullyHidden()
    {
        if (_randomIndex >= _words.Count())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}