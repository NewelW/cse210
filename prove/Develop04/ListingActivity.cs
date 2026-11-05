class ListingActivity : Activity
{
    public ListingActivity(string name, string description) : base(name, description)
    {
    }
    public void Run()
    {
        Console.Clear();
        ShowPrologue();

        Random random = new Random();
        List<string> initialPrompts = ["Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
            ];
        string initialPrompt = initialPrompts[random.Next(0, initialPrompts.Count())];

        Console.WriteLine($"Prompt: {initialPrompt}\n\nStart listing in 10 seconds!\n");
        ShowSpinner(10);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(getDuration());

        int x = 0;
        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            x++;
        }
        Console.WriteLine($"You listed {x} items!");
        ShowEpilogue();
        return;
    }
}