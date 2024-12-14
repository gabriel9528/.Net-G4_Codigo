using PolimorfismoEstatico2;

class Program
{
    static void Main()
    {
        Vector vector1 = new Vector(1, 2);
        Vector vector2 = new Vector(3, 4);

        Vector VectorSuma = vector1 + vector2;

        Console.WriteLine($"Suma de vectores: ({VectorSuma.X}, {VectorSuma.Y})");
    }
}