using System;

public class Rectangulo
{
    private double ancho;
    private double altura;

    public double Ancho
    {
        get { return ancho; }
        set { ancho = value > 0 ? value : 0; }
    }

    public double Altura
    {
        get { return altura; }
        set { altura = value > 0 ? value : 0; }
    }

    public double Area => Ancho * Altura;

    public double Perimetro => 2 * (Ancho + Altura);
}

public class Program
{
    public static void Main(string[] args)
    {
        Rectangulo rect = new Rectangulo();

        // Declaramos las variables afuera del bucle para que sean accesibles después
        double ancho;
        double altura;

        // Solicitar el ancho
        Console.Write("Ingrese el ancho del rectángulo: ");
        while (!double.TryParse(Console.ReadLine(), out ancho) || ancho <= 0)
        {
            Console.Write("Por favor, ingrese un valor válido para el ancho (mayor a 0): ");
        }
        rect.Ancho = ancho;

        // Solicitar la altura
        Console.Write("Ingrese la altura del rectángulo: ");
        while (!double.TryParse(Console.ReadLine(), out altura) || altura <= 0)
        {
            Console.Write("Por favor, ingrese un valor válido para la altura (mayor a 0): ");
        }
        rect.Altura = altura;

        // Mostrar el área y el perímetro
        Console.WriteLine($"Área: {rect.Area}, Perímetro: {rect.Perimetro}");
    }
}
