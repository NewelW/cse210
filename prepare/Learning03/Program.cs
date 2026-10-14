using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Console.WriteLine($"{fraction.GetFractionString()}");
        Fraction fraction2 = new Fraction(6);
        Console.WriteLine($"{fraction2.GetFractionString()}");
        Fraction fraction3 = new Fraction(6,7);
        Console.WriteLine($"{fraction3.GetFractionString()}");

        Fraction fraction4 = new Fraction();
        Console.WriteLine($"{fraction4.GetFractionString()}\n{fraction4.GetDecimalValue()}");
        fraction4.SetTop(5);
        Console.WriteLine($"{fraction4.GetFractionString()}\n{fraction4.GetDecimalValue()}");
        fraction4.SetTop(3);
        fraction4.SetBottom(4);
        Console.WriteLine($"{fraction4.GetFractionString()}\n{fraction4.GetDecimalValue()}");
        fraction4.SetTop(1);
        fraction4.SetBottom(3);
        Console.WriteLine($"{fraction4.GetFractionString()}\n{fraction4.GetDecimalValue()}");

        Random random = new Random();
        for (int i = 0; i<50; i++)
        {
            fraction4.SetTop(random.Next());
            fraction4.SetBottom(random.Next());
            Console.WriteLine($"Fraction: {i+1} String: {fraction4.GetFractionString()} Number: {fraction4.GetDecimalValue()}");
        }
    }
}