
using Ejercicio3_Before;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        var areaCalculator = new AreaCalculator();

        var shapes = new List<object>
        {
            new Rectangulo { Width = 4, Height = 5 },
            new Circulo { Radius = 3 },
            new Rectangulo { Width = 6, Height = 7 },
            new Circulo { Radius = 2 }
        };

        string areas = areaCalculator.Area(shapes);
        Console.WriteLine(areas);
    }
}