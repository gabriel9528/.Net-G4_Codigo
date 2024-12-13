using System;

public static class ConvertidorTemperatura
{
    // Método para convertir de Celsius a Fahrenheit
    public static double CelsiusAFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // Método para convertir de Fahrenheit a Celsius
    public static double FahrenheitACelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Selecciona una opción:");
        Console.WriteLine("1. Convertir de Celsius a Fahrenheit");
        Console.WriteLine("2. Convertir de Fahrenheit a Celsius");
        int opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            Console.Write("Ingresa la temperatura en Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = ConvertidorTemperatura.CelsiusAFahrenheit(celsius);
            Console.WriteLine($"La temperatura en Fahrenheit es: {fahrenheit:F2}");
        }
        else if (opcion == 2)
        {
            Console.Write("Ingresa la temperatura en Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = ConvertidorTemperatura.FahrenheitACelsius(fahrenheit);
            Console.WriteLine($"La temperatura en Celsius es: {celsius:F2}");
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }
    }
}
