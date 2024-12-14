
using PolimorfismoEstatico_Ejercicio1;

class Program
{
    static void Main()
    {
        Calculadora calculadora = new Calculadora();

        int sumaInt = calculadora.Suma(5, 6);
        double sumaDouble = calculadora.Suma(10.5, 20.90);

        Console.WriteLine($"Resultado suma de enteros: {sumaInt}");
        Console.WriteLine($"Resultado suma de double: {sumaDouble}");

    }
}