namespace Costume;

class Costume
{
    public string _headware;
    public string _upperGarment;
    public string _lowerGarment;
    public string _footWare;
    public string _accessories;

    public void Output()
    {
        Console.WriteLine($"Costume Pieces:");
        Console.WriteLine($"head: {_headware}");
        Console.WriteLine($"torso: {_upperGarment}");
        Console.WriteLine($"legs: {_lowerGarment}");
        Console.WriteLine($"feet: {_footWare}");
        Console.WriteLine($"other: {_accessories}");
    }
}