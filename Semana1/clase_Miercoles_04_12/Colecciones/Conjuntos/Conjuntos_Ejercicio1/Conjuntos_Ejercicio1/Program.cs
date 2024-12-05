using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        HashSet<string> nombres = new HashSet<string>();

        while (true)
        {
            Console.Write("Ingrese un nombre (o 'fin' para terminar): ");
            string nombre = Console.ReadLine();

            if (nombre.ToLower() == "fin")
                break;

            if (nombres.Add(nombre))
                Console.WriteLine($"{nombre} agregado.");
            else
                Console.WriteLine($"{nombre} ya está en el conjunto y no se agregará de nuevo.");
        }

        Console.WriteLine("Nombres únicos ingresados:");
        foreach (var nombre in nombres)
        {
            Console.WriteLine(nombre);
        }
    }
}
