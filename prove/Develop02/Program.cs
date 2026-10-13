using System;

class Program
{
    static string menu = @"
Please Select one of the options:
1. Write
2. Display
3. Save
4. Load
5. Quit";
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string response;
        do
        {
            Console.WriteLine(menu);
            response = Console.ReadLine();
            if (response == "1") // Write
            {
                journal.AddEntry();
            }
            else if (response == "2") // Display
            {
                journal.DisplayEntries();
            }
            else if (response == "3") // Save
            {
                journal.SaveJournal();
            }
            else if (response == "4") // Load & Display
            {
                journal = journal.LoadJournal();
                journal.DisplayEntries();
            }
            else if (response == "5") // Load & Display
            {
                continue;
            }
            else // Handle all other input
            {
                response = "0";
            }
        } while (response != "5");
    }
}