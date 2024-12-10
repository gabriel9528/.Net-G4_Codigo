using System.Globalization;

class Program
{
    
    static void Main(string[] args)
    {
        int[] numbers = new int[10];
        //Recorrer el areglo e imprimir
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 1;
        }

        //Imprimir por consola
        Console.WriteLine("Los elementos que contiene min lista son: ");
        for(int i = 0;i < numbers.Length; i++)
        {
            Console.WriteLine($"Elemento con indice {i}, tiene un valor -> {numbers[i]}");
        };

        Console.WriteLine($"El tamaño de mi lista es: {numbers.Length}");

    }
}