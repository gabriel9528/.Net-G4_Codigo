

public struct Punto
{
    //Propiedades de la estructura
    public double X { get; set; }
    public double Y { get; set; }


    public Punto(double x, double y)
    {
        X = x;
        Y = y;
    }

    //Metodo para mostrar las coordenadas
    public void MostrarCoordendas()
    {
        Console.WriteLine($"La coordenada es: {X} ; {Y}");
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        //Solicitar las coordenadas al usuario
        Console.WriteLine($"Ingrese la corrdenada X: ");
        double X;
        while(!double.TryParse(Console.ReadLine(), out X))
        {
            Console.WriteLine("Porfavor, ingrese una coordenada para el eje X valida");
        }

        Console.WriteLine($"Ingrese la corrdenada Y: ");
        double Y;
        while (!double.TryParse(Console.ReadLine(), out Y))
        {
            Console.WriteLine("Porfavor, ingrese una coordenada para el eje Y valida");
        }

        //Crear el punto en la estructura con las coordenadas ingresadas
        Punto punto = new Punto(X, Y);
        punto.MostrarCoordendas();
    }
}
