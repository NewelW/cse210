using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int number = -1;
        List<int> numbers = new List<int>();
        while (number != 0)
        {
            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        int sum = 0;
        int largestNumber = 0;
        foreach (int num in numbers)
        {
            sum = sum + num;
            if (num > largestNumber)
            {
                largestNumber = num;
            }
        }
        double average = (double)sum/numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}