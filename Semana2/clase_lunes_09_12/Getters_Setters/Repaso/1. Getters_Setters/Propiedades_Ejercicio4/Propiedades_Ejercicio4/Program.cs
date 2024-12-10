using System;

public class Temperatura
{
    private double celsius;

    public double Celsius
    {
        get { return celsius; }
        set { celsius = value; }
    }

    public double Fahrenheit
    {
        get { return (celsius * 9 / 5) + 32; }
    }
}

class Program
{
    static void Main()
    {
        Temperatura temp = new Temperatura();

        Console.Write("Ingrese la temperatura en Celsius: ");
        if (double.TryParse(Console.ReadLine(), out double celsius))
        {
            temp.Celsius = celsius;
            Console.WriteLine($"Celsius: {temp.Celsius}°C, Fahrenheit: {temp.Fahrenheit}°F");
        }
        else
        {
            Console.WriteLine("Entrada inválida. No se pudo calcular la temperatura.");
        }
    }
}
