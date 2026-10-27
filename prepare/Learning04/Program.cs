using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Bob Jorge", "Calculus");
        Console.WriteLine(assignment.GetSummary());
        MathAssignment mathAssignment = new MathAssignment("Bob Jorge", "Calculus", "Section 5.4", "Problems 6-7");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        WritingAssignment writingAssignment = new WritingAssignment("Jane Billy", "Fantasy 101", "Trickster characters in history.");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}