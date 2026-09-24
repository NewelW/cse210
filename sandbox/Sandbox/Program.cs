using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        // for (int i = 1; i<10; i += 2)
        // {
            // Console.WriteLine($"Test: {i}");
        // }
        IList<string> test = [];
        test.Add("Test!");
        Console.WriteLine($"Test: {test[0]} {test.Count()}");
    }

    static double Tenth(int amount)
    {
        return 0.1*amount;
    }
}