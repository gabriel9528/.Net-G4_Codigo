using System;

public struct Rectangulo
{
    // Propiedades
    public double Ancho { get; set; }
    public double Alto { get; set; }

    // Constructor
    public Rectangulo(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }

    // Método para calcular el área
    public double CalcularArea()
    {
        return Ancho * Alto;
    }

    // Método para calcular el perímetro
    public double CalcularPerimetro()
    {
        return 2 * (Ancho + Alto);
    }
}

// Uso de la estructura Rectangulo
public class Program
{
    public static void Main(string[] args)
    {
        // Solicitar ancho y alto al usuario
        Console.Write("Ingrese el ancho del rectángulo: ");
        double ancho;
        while (!double.TryParse(Console.ReadLine(), out ancho))
        {
            Console.Write("Por favor, ingrese un número válido para el ancho: ");
        }

        Console.Write("Ingrese el alto del rectángulo: ");
        double alto;
        while (!double.TryParse(Console.ReadLine(), out alto))
        {
            Console.Write("Por favor, ingrese un número válido para el alto: ");
        }

        // Crear el rectángulo con los valores ingresados
        Rectangulo rectangulo = new Rectangulo(ancho, alto);
        Console.WriteLine($"Área: {rectangulo.CalcularArea()}");
        Console.WriteLine($"Perímetro: {rectangulo.CalcularPerimetro()}");
    }
}
