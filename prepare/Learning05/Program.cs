using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Square square = new Square(5, "Purple");
        Rectangle rectangle = new Rectangle(3,5, "Orange");
        Circle circle = new Circle(3, "Green");

        List<Shape> shapes = [square, rectangle, circle];

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Area: {shape.GetArea()} Color: {shape.GetColor()}");
        }
    }
}