

using PolimorfismoEstatico_SobrecargaOperadores;

class Program
{
    static void Main(string[] args)
    {
        Vector vectorA = new Vector(5, 8);
        Vector vectorB = new Vector(2, 3);

        Vector resultado = vectorA + vectorB;

        Console.WriteLine($"{resultado.X}, {resultado.Y}");
    }
}