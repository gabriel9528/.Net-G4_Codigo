using PolimorfismoEstatico;

class Program
{
    static void Main()
    {
        Calculadora calculadora = new Calculadora();

        int resultadoEntero = calculadora.Suma(3, 4);
        double resultadoDouble = calculadora.Suma(3.5, 4.2);

        Console.WriteLine($"Resultado entero: {resultadoEntero}");
        Console.WriteLine($"Resultado double: {resultadoDouble}");
    }
}