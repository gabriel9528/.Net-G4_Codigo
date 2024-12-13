using System;

public struct Cilindro
{
    // Propiedades
    public double Radio { get; set; }
    public double Altura { get; set; }

    // Constructor
    public Cilindro(double radio, double altura)
    {
        Radio = radio;
        Altura = altura;
    }

    // Método para calcular el volumen
    public double CalcularVolumen()
    {
        return Math.PI * Math.Pow(Radio, 2) * Altura;
    }

    // Método para calcular el área superficial
    public double CalcularAreaSuperficial()
    {
        return 2 * Math.PI * Radio * (Radio + Altura);
    }
}

// Uso de la estructura Cilindro
public class Program
{
    public static void Main(string[] args)
    {
        // Solicitar el radio y la altura al usuario
        Console.Write("Ingrese el radio del cilindro: ");
        double radio;
        while (!double.TryParse(Console.ReadLine(), out radio) || radio <= 0)
        {
            Console.Write("Por favor, ingrese un número válido y positivo para el radio: ");
        }

        Console.Write("Ingrese la altura del cilindro: ");
        double altura;
        while (!double.TryParse(Console.ReadLine(), out altura) || altura <= 0)
        {
            Console.Write("Por favor, ingrese un número válido y positivo para la altura: ");
        }

        // Crear el cilindro con los valores ingresados
        Cilindro cilindro = new Cilindro(radio, altura);
        Console.WriteLine($"Volumen: {cilindro.CalcularVolumen():F2}");
        Console.WriteLine($"Área Superficial: {cilindro.CalcularAreaSuperficial():F2}");
    }
}
