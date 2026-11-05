class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    protected int getDuration()
    {
        return _duration;
    }
    protected void ShowPrologue()
    {
        Console.WriteLine($"Welcome to: {_name}\n\n{_description}\n\nHow long in seconds would you like this session to be?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine($"Starting Session in 5 seconds!\n");
        ShowSpinner(5);
        return;
    }
    protected void ShowSpinner(int s)
    {
        char[] spinner = ['-', '\\', '|', '/'];
        int spinnerCounter = 0;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(s);

        while (DateTime.Now < futureTime)
        {
            if (spinnerCounter == spinner.Length)
            {
                spinnerCounter = 0;
            }
            Console.Write(spinner[spinnerCounter]);
            spinnerCounter++;
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        return;
    }
    protected void ShowEpilogue()
    {
        Console.WriteLine($"Congrats on completeing: {_name} for {_duration} seconds!\nReturning in 5 seconds.\n");
        ShowSpinner(5);
        return;
    }
}