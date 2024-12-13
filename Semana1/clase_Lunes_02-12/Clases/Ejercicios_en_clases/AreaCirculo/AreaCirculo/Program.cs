using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        //Area del circulo
        const double PI = 3.1416;
        //const double radio = 5.0;

        Console.WriteLine("Ingresa el radio del circulo: ");
        string radio = Console.ReadLine();

        double radioConvert = Convert.ToDouble(radio);
        /*ouble radioConvert1 = Double.Parse(radio);*/

        double area = 0;
        if(radioConvert > 0)
        {
            area = PI * radioConvert * radioConvert;
        }
        else
        {
            throw new Exception("No se puede convertir un string a double");
        }

        Console.WriteLine($"El area del circulo es: {area}");
        Console.ReadLine();
    }
}