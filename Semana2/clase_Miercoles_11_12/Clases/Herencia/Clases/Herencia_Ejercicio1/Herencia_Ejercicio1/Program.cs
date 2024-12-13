

using Herencia_Ejercicio1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ejericio 1:");
        Suma suma = new Suma();
        suma.Valor1 = 20;
        suma.Valor2 = 15;
        suma.Operar();
        Console.WriteLine($"La suma de {suma.Valor1} + {suma.Valor2} es: {suma.Resultado}");

        Console.WriteLine("*****************************************************************");

        Resta resta = new Resta();
        resta.Valor1 = 20;
        resta.Valor2 = 15;
        resta.Operar();
        Console.WriteLine($"La resta de {resta.Valor1} - {resta.Valor2} es: {resta.Resultado}");
    }
}