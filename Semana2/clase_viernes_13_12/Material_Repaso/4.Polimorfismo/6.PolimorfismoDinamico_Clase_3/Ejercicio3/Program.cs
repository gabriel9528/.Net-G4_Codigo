using Ejercicio3;

class Program
{
    static void Main(string[] args)
    {
        Forma[] formas = new Forma[3];
        formas[0] = new Circulo(5);
        formas[1] = new Rectangulo(4, 6);
        formas[2] = new Triangulo(3, 4);

        foreach (Forma forma in formas)
        {
            Console.WriteLine($"Área: {forma.Area()}");

            try
            {
                Console.WriteLine($"Perímetro: {forma.Perimetro()}");
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("Perímetro no disponible para esta forma.");
            }
            Console.WriteLine();
        }
    }
}