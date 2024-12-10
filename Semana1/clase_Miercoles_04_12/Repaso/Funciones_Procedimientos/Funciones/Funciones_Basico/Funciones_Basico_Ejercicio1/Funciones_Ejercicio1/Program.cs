using System;

class Program
{
    static double CalcularAreaCirculo(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    static void Main()
    {
        double radio = 5.0;
        double area = CalcularAreaCirculo(radio);
        Console.WriteLine($"El área del círculo con radio {radio} es: {area}");
    }
}
