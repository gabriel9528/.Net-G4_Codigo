using System;
using System.Collections.Generic;

class Program
{
    static int CalcularMayor(List<int> numeros)
    {
        int mayor = numeros[0];
        foreach (int numero in numeros)
        {
            if (numero > mayor)
            {
                mayor = numero;
            }
        }
        return mayor;
    }

    static void Main()
    {
        List<int> numeros = new List<int>();
        Console.WriteLine("Ingrese números (o escriba 'fin' para terminar):");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "fin")
                break;

            if (int.TryParse(input, out int numero))
            {
                numeros.Add(numero);
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }
        }

        int mayor = CalcularMayor(numeros);
        Console.WriteLine("El mayor número es: " + mayor);
    }
}
