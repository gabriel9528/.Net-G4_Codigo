using System;

public class Geometria
{
    // Método estático para calcular el área de un círculo
    public static double CalcularAreaCirculo(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Ingresa el radio del círculo: ");
        double radio = double.Parse(Console.ReadLine());

        // Uso del método estático
        double area = Geometria.CalcularAreaCirculo(radio);
        Console.WriteLine($"El área del círculo con radio {radio} es: {area:F2}");
    }
}
