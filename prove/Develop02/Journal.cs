class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _filename = "";
    public List<string> _prompts = [
        "How are you feeling today?",
        "What things did you eat today?",
        "Who did you talk with?",
        "What went well today?",
        "How could you improve from today?",
        "Where did you go today?",
        "Write something interesting that happened today!",
    ];

    public void AddEntry()
    {
        Random random = new Random();
        string randomPrompt = _prompts[random.Next(0, _prompts.Count())];

        DateTime now = DateTime.Now;

        Console.WriteLine($"The date is now: {now}");
        Console.WriteLine($"{randomPrompt}");
        string response = Console.ReadLine();

        Entry entry = new Entry
        {
            _date = now.ToString(),
            _response = response,
            _prompt = randomPrompt
        };
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine($"No entries to Display! Make one instead!");
            return;
        }
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public Journal LoadJournal()
    {
        // https://learn.microsoft.com/en-us/dotnet/api/system.io.directory.enumeratefiles?view=net-10.0
        Console.WriteLine($"Valid Files to: ");
        IEnumerable<string> txtFiles = Directory.EnumerateFiles(Directory.GetCurrentDirectory(), "*.txt");

        foreach (string currentFile in txtFiles)
        {
            Console.WriteLine(currentFile.Split("/").Last());
        }

        Console.WriteLine($"\nPlease input the filename: ");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);

        Journal journal = new Journal
        {
            _filename = filename,
        };

        foreach (string line in lines)
        {
            string[] parts = line.Split(" | ");
            Entry entry = new Entry
            {
                _date = parts[0],
                _prompt = parts[1],
                _response = parts[2],
            };
            journal._entries.Add(entry);
        }
        return journal;
    }

    public void SaveJournal()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine($"No entries to save! Make one instead!");
            return;
        }
        string filename;
        if (_filename == "")
        {
            Console.WriteLine($"Please input a Journal name: ");
            string middleFilename = Console.ReadLine();
            filename = $"Journal-{middleFilename}.txt";
        }
        else
        {
            filename = _filename;
        }



        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry.SaveOutput()}");
            }
        }
        _filename = filename;
    }
}