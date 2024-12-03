using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce la temperatura en Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"La temperatura en Fahrenheit es: {fahrenheit}");
    }
}
