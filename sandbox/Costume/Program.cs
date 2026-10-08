using System.ComponentModel;

namespace Costume;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        List<Costume> myCostumes = new List<Costume>();
        Costume detective = new Costume();
        detective._accessories = "Magnifying Glass";
        detective._footWare = "Boots";
        detective._headware = "Cap";
        detective._lowerGarment = "Slacks";
        detective._upperGarment = "Trenchcoat";
        myCostumes.Add(detective);

        Costume nurse = new Costume();
        nurse._accessories = "Needle";
        nurse._footWare = "Running Shoes";
        nurse._headware = "Hairnet";
        nurse._lowerGarment = "Scrubs";
        nurse._upperGarment = "Scrubs";
        myCostumes.Add(nurse);

        foreach (Costume costume in myCostumes)
        {
            costume.Output();
        }
    }
}
