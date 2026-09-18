using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        int gradePercentage = int.Parse(Console.ReadLine());
        string letterGrade = "";
        string positiveOrMinus = "";
        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (gradePercentage % 10 >= 7 && !((gradePercentage >= 90) || (gradePercentage < 60)))
        {
            positiveOrMinus = "+";
        }
        else if (gradePercentage % 10 < 3 && !(gradePercentage < 60))
        {
            positiveOrMinus = "-";
        }
        else
        {
            positiveOrMinus = "";
        }
        Console.WriteLine($"You get an {letterGrade}{positiveOrMinus}!");
        if (gradePercentage >= 70)
        {
            Console.WriteLine($"Congrats! You have passed the class!");
        }
        else
        {
            Console.WriteLine($"Try again next time! You have not passed the class!");
        }
    }
}