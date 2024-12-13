using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        HashSet<int> conjunto1 = new HashSet<int>();
        HashSet<int> conjunto2 = new HashSet<int>();

        Console.WriteLine("Ingrese números para el primer conjunto (escriba -1 para terminar):");
        while (true)
        {
            int numero = int.Parse(Console.ReadLine());
            if (numero == -1)
                break;
            conjunto1.Add(numero);
        }

        Console.WriteLine("Ingrese números para el segundo conjunto (escriba -1 para terminar):");
        while (true)
        {
            int numero = int.Parse(Console.ReadLine());
            if (numero == -1)
                break;
            conjunto2.Add(numero);
        }

        // Intersección de los conjuntos
        HashSet<int> interseccion = new HashSet<int>(conjunto1);
        interseccion.IntersectWith(conjunto2);
        Console.WriteLine("Números en ambos conjuntos (Intersección):");
        foreach (var num in interseccion)
        {
            Console.WriteLine(num);
        }

        // Unión de los conjuntos
        HashSet<int> union = new HashSet<int>(conjunto1);
        union.UnionWith(conjunto2);
        Console.WriteLine("Todos los números únicos (Unión):");
        foreach (var num in union)
        {
            Console.WriteLine(num);
        }
    }
}
