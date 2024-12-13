

public struct Punto
{
    //Propiedades
    public double X { get; set; }
    public double Y { get; set; }


    //Constructor
    public Punto(double x, double y)
    {
        X = x;
        Y = y;
    }

    //Metodo para mostrar coordenadas

    public void MostrarCoordenadas()
    {
        Console.WriteLine($"Coordenadas: X: {X}; Y: {Y}");
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        //Solicitar las coordenadas al usuario
        Console.WriteLine("Ingrese las coordenada X: ");
        double X;
        while(!double.TryParse(Console.ReadLine(), out X))
        {
            Console.WriteLine("Por favor, ingrese una coordenada valida para el eje X.");
        }

        Console.WriteLine("Ingrese las coordenada Y: ");
        double Y;
        while (!double.TryParse(Console.ReadLine(), out Y))
        {
            Console.WriteLine("Por favor, ingrese una coordenada valida para el eje Y.");
        }

        //Crear la unica instancia de nuestra estructura
        Punto punto1 = new Punto(X, Y);
        punto1.MostrarCoordenadas();
    }
}
