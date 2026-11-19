public class GoalKeeper
{
    private string _filename = "";
    private int _currentPoints;
    private List<Goal> _goals = new List<Goal>();

    public GoalKeeper()
    {
        Load();
    }

    static string goalMenu = @"The Types of Goals are:
  1. Simple Goal
  2. Eternal Goal
  3. Checklist Goal";
    public void NewGoal()
    {
        Console.WriteLine(goalMenu);
        Console.WriteLine("Which type of goal would you like to create?");
        int goalResponse = int.Parse(Console.ReadLine());

        // Goal making process
        Console.WriteLine("What is the name of your goal?");
        string goalReseponse = Console.ReadLine();
        Console.WriteLine("What is the description of the goal?");
        string descriptionReseponse = Console.ReadLine();
        Console.WriteLine("How many points should this goal give on completion?");
        int pointsResponse = int.Parse(Console.ReadLine());
        if (goalResponse == 1)
        {
            SimpleGoal goal = new SimpleGoal(goalReseponse, descriptionReseponse, pointsResponse);
            _goals.Add(goal);
            return;
        }
        if (goalResponse == 2)
        {
            EternalGoal goal = new EternalGoal(goalReseponse, descriptionReseponse, pointsResponse);
            _goals.Add(goal);
            return;
        }
        if (goalResponse == 3)
        {
            Console.WriteLine("How many times would you like to complete this goal?");
            int completionGoal = int.Parse(Console.ReadLine());
            Console.WriteLine("How many extra points should this goal give on completion? (Default 1)");
            int extraPoints = int.Parse(Console.ReadLine());
            ChecklistGoal goal = new ChecklistGoal(goalReseponse, descriptionReseponse, pointsResponse, 0, completionGoal, extraPoints);
            _goals.Add(goal);
            return;
        }
        Console.WriteLine("You didn't enter a valid goal!");
        return;
    }
    public void RecordGoal()
    {
        DisplayGoals();
        Console.WriteLine("Which goal would you like to record?");
        int goalResponse = int.Parse(Console.ReadLine());
        if (goalResponse > _goals.Count())
        {
            Console.WriteLine("Invalid goal response");
            return;
        }
        _currentPoints += _goals[goalResponse].GoalFinish();
    }
    public void Save()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine($"No goals to save! Make one instead!");
            return;
        }

        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            string finalString = $"{_currentPoints}";
            foreach (Goal goal in _goals)
            {
                finalString += $"\n{goal.GetSaveString()}";
            }
            outputFile.Write(finalString);
            outputFile.Close();
        }
    }
    public void Load()
    {
        if (_filename == "")
        {
            Console.WriteLine("Load a filename below or enter a new filename to create a new goal list.\n(Please be exact and include the file extension)");
            Console.WriteLine($"Previous Goal Files: ");
            IEnumerable<string> txtFiles = Directory.EnumerateFiles(Directory.GetCurrentDirectory(), "*.txt");

            foreach (string currentFile in txtFiles)
            {
                Console.WriteLine(currentFile.Split("/").Last());
            }
            string filenameResponse = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + Console.ReadLine();
            if (txtFiles.Contains(filenameResponse))
            {
                _filename = filenameResponse;
            }
            else
            {
                Console.WriteLine($"Creating new file with filename: {filenameResponse}");
                _filename = filenameResponse;
                return;
            }
        }

        _goals = new List<Goal>();

        // If we just created the file, we already returned so we can just continue to load the file.
        string[] lines;
        try
        {
            lines = File.ReadAllLines(_filename);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File does not exist with filename: {_filename}, please before loading.");
            return;
        }
        foreach (string line in lines)
        {
            if (int.TryParse(line, out int points))
            {
                _currentPoints = points;
                continue;
            }
            string[] segments = line.Split(";");
            if (line.StartsWith("EternalGoal;"))
            {
                EternalGoal goal = new EternalGoal(segments[1], segments[2], int.Parse(segments[3]));
                _goals.Add(goal);
            }
            if (line.StartsWith("ChecklistGoal;"))
            {
                ChecklistGoal goal = new ChecklistGoal(segments[1], segments[2], int.Parse(segments[3]), int.Parse(segments[4]), int.Parse(segments[5]), int.Parse(segments[6]));
                _goals.Add(goal);
            }
            if (line.StartsWith("SimpleGoal;"))
            {
                SimpleGoal goal = new SimpleGoal(segments[1], segments[2], int.Parse(segments[3]), bool.Parse(segments[4]));
                _goals.Add(goal);
            }
        }
    }
    public void DisplayGoals()
    {
        Console.WriteLine($"Current Goals: ");
        int i = 0;
        foreach (Goal goal in _goals)
        {
            Console.Write($"{i}. ");
            goal.Display();
            i++;
        }
    }

    public int GetTotalPoints()
    {
        return _currentPoints;
    }
}