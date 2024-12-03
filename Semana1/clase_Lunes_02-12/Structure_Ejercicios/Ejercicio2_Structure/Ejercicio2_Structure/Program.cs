using Ejercicio2_Structure;
using System;

class Program
{
    static void Main()
    {
        Rectangulo rect = new Rectangulo(5, 3);

        Console.WriteLine($"Área del rectángulo: {rect.CalcularArea()}");
        Console.WriteLine($"Perímetro del rectángulo: {rect.CalcularPerimetro()}");
    }
}
