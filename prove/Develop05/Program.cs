using System;

class Program
{
    static string menu = @"
Menu Options:
  1. Create New Goal
  2. List Goals
  3. Save Goals
  4. Load Goals
  5. Record Event
  6. Quit
Select a choice from the menu:";
    static void Main(string[] args)
    {
        GoalKeeper goalKeeper = new GoalKeeper();
        Console.WriteLine($"\nTotal points: {goalKeeper.GetTotalPoints()}\n" + menu);
        string response = Console.ReadLine();
        while (response != "6")
        {
            if (response == "1")
            {
                goalKeeper.NewGoal();
            }
            else if (response == "2")
            {
                goalKeeper.DisplayGoals();
            }
            else if (response == "3")
            {
                goalKeeper.Save();
            }
            else if (response == "4")
            {
                goalKeeper.Load();
            }
            else if (response == "5")
            {
                goalKeeper.RecordGoal();
            }
            Console.WriteLine($"\nTotal points: {goalKeeper.GetTotalPoints()}\n" + menu);
            response = Console.ReadLine();
        }
    }
}