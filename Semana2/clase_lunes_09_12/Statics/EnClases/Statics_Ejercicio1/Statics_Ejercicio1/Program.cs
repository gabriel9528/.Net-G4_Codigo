
public static class Geometria
{
    //static List<string> lista1 = new List<string>();
    public static double CalcularAreaCirculo(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el radio del circulo: ");
        double radio = double.Parse(Console.ReadLine());

        //Uso del metodo estatico
        double area = Geometria.CalcularAreaCirculo(radio);
        Console.WriteLine($"El area del circulo es: {area}");
    }
}
