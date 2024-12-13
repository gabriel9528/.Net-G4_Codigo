

class Program
{
    static double CalcularAreaCirculo(double radio)
    {
        double item = Math.PI* Math.Pow(radio, 2);
        return item;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Escriba el area del circulo: ");
        string radioString = Console.ReadLine();

        double radioResult = 0;

        if(double.TryParse(radioString, out var result))
        {
            radioResult = result;
        }

        double area = CalcularAreaCirculo(radioResult);

        Console.WriteLine($"El area del circulo es: {area}");
    }
}