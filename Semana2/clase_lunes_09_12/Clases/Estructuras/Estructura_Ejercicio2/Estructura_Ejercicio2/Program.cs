
public struct Rectangulo
{
    //Propiedades
    public double Ancho { get; set; }
    public double Alto { get; set; }

    //Constructor
    public Rectangulo(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }

    //Metodo para calcular Area
    public double CalcularArea()
    {
        return Ancho * Alto;
    }

    //Metodo para calcular Perimetro
    public double CalcularPerimetro()
    {
        return (2*Ancho) + (2*Alto);
    }

}

//Uso de la estructura dentro del Main
public class Program
{
    static void Main(string[] args)
    {

        //Solicitar datos para crear la estrucutra de Rectangulo
        Console.WriteLine("Ingrese el ancho del rectangulo: ");
        double ancho;
        while(!double.TryParse(Console.ReadLine(), out ancho))
        {
            Console.WriteLine("Es necesario ingresar un valor permitido para el ancho del rectangulo");
        }

        Console.WriteLine("Ingrese el alto del rectangulo: ");
        double alto;
        while (!double.TryParse(Console.ReadLine(), out alto))
        {
            Console.WriteLine("Es necesario ingresar un valor permitido para el alto del rectangulo");
        }

        //Crear la unica instancia de la estructura Rectngulo
        Rectangulo rectangulo = new Rectangulo(ancho, alto);
        Console.WriteLine($"El area del rectangulo es: {rectangulo.CalcularArea()}");
        Console.WriteLine($"El perimetro del rectangulo es: {rectangulo.CalcularPerimetro()}");
    }
}