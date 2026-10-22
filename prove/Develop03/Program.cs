using System;

class Program
{
    static void Main(string[] args)
    {
        string rawScripture = @"4 And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.

5 And by the power of the Holy Ghost ye may know the truth of all things.

Moroni 10:4–5

https://www.churchofjesuschrist.org/study/scriptures/bofm/moro/10?lang=eng&id=p4-p5#p4";

        string menu = "\nPress enter to continue or type 'first' to enable/disable first letters or type 'quit' to finish:";

        Console.Clear();
        Scripture scripture = new Scripture(rawScripture, false);
        scripture.DisplayScripture();

        string response;
        do
        {
            Console.WriteLine(menu);
            response = Console.ReadLine();
            if (response == "first")
            {
                Console.Clear();
                scripture.ToggleHideFirstLetter();
                scripture.DisplayScripture();
            } else if (scripture.FullyHidden()){
                response = "quit";
            }
            else // Handle all other input
            {
                Console.Clear();
                scripture.HideRandomWords();
                scripture.DisplayScripture();
            }
        } while (response != "quit");
    }
}