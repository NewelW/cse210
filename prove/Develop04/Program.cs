using System;

class Program
{
    static void Main(string[] args)
    {
        string menu = @"Menu Options:
  1. Start Breathing Activity
  2. Start Reflection Activity
  3. Start Listing Activity
  4. Quit
Select a choice from the menu:";

        Console.Clear();
        Console.WriteLine(menu);
        string response = Console.ReadLine();
        while (response != "4")
        {
            Console.Clear();
            if (response == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mirnd and focus on your breathing.");
                breathingActivity.Run();
            }
            else if (response == "2")
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflectionActivity.Run();
            }
            else if (response == "3")
            {
                ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listingActivity.Run();
            }
            Console.Clear();
            Console.WriteLine(menu);
            response = Console.ReadLine();
        }
    }
}