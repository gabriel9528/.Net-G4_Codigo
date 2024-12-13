using System;

class Program
{
    static double CalcularAreaTriangulo(double baseTriangulo, double altura)
    {
        return (baseTriangulo * altura) / 2;
    }

    static void Main()
    {
        double area = CalcularAreaTriangulo(10, 5);
        Console.WriteLine("El área del triángulo es: " + area);
    }
}
