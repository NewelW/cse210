class ReflectionActivity : Activity
{
    public ReflectionActivity(string name, string description) : base(name, description)
    {
    }
    public void Run()
    {
        Console.Clear();
        ShowPrologue();

        Random random = new Random();
        List<string> initialPrompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless.",];
        string initialPrompt = initialPrompts[random.Next(0, initialPrompts.Count())];

        Console.WriteLine($"Prompt: {initialPrompt}\n\nStart Reflecting in 10 seconds!\n");
        ShowSpinner(10);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(getDuration());
        List<string> prompts = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
            ];
        prompts.Shuffle();

        int i = 0;
        while (DateTime.Now < futureTime)
        {
            if (i == prompts.Count())
            {
                prompts.Shuffle();
                i = 0;
            }
            Console.WriteLine($"{prompts[i]}");
            ShowSpinner(5);
            i++;
        }
        ShowEpilogue();
        return;
    }
}