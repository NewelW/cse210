class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
    }

    private void BreatheIn()
    {
        Console.WriteLine($"Breath in...");
        int secondsLeft = 5;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(secondsLeft + 1);

        while (DateTime.Now < futureTime)
        {
            Console.Write(secondsLeft);
            secondsLeft--;
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        return;
    }
    private void BreatheOut()
    {
        Console.WriteLine($"Breath out...");
        int secondsLeft = 5;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(secondsLeft + 1);

        while (DateTime.Now < futureTime)
        {
            Console.Write(secondsLeft);
            secondsLeft--;
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        return;
    }
    public void Run()
    {
        Console.Clear();
        ShowPrologue();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(getDuration());

        while (DateTime.Now < futureTime)
        {
            BreatheIn();
            BreatheOut();
        }
        ShowEpilogue();
        return;
    }
}