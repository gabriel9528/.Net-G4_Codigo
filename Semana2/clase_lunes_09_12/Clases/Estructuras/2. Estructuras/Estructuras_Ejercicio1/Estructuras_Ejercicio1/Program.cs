using System;

public struct Punto
{
    // Propiedades
    public double X { get; set; }
    public double Y { get; set; }

    // Constructor
    public Punto(double x, double y)
    {
        X = x;
        Y = y;
    }

    // Método para mostrar las coordenadas
    public void MostrarCoordenadas()
    {
        Console.WriteLine($"Coordenadas: ({X}, {Y})");
    }
}

// Uso de la estructura Punto
public class Program
{
    public static void Main(string[] args)
    {
        // Solicitar coordenadas al usuario
        Console.Write("Ingrese la coordenada X: ");
        double x;
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("Por favor, ingrese un número válido para X: ");
        }

        Console.Write("Ingrese la coordenada Y: ");
        double y;
        while (!double.TryParse(Console.ReadLine(), out y))
        {
            Console.Write("Por favor, ingrese un número válido para Y: ");
        }

        // Crear el punto con las coordenadas ingresadas
        Punto punto = new Punto(x, y);
        punto.MostrarCoordenadas();
    }
}
