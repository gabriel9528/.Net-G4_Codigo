using System;

struct Coordenadas
{
    public int X { get; set; }
    public int Y { get; set; }

    public Coordenadas(int x, int y)
    {
        X = x;
        Y = y;
    }

    public double CalcularDistancia(Coordenadas otroPunto)
    {
        int deltaX = otroPunto.X - X;
        int deltaY = otroPunto.Y - Y;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }
}

class Program
{
    static void Main()
    {
        Coordenadas punto1 = new Coordenadas(3, 4);
        Coordenadas punto2 = new Coordenadas(7, 1);

        double distancia = punto1.CalcularDistancia(punto2);
        Console.WriteLine($"La distancia entre los puntos es: {distancia}");
    }
}
