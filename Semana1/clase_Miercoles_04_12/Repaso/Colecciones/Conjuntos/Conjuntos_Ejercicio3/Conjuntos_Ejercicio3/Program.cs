using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        HashSet<string> palabras = new HashSet<string>();

        Console.WriteLine("Ingrese palabras (escriba 'fin' para terminar):");
        while (true)
        {
            string palabra = Console.ReadLine().ToLower();
            if (palabra == "fin")
                break;
            palabras.Add(palabra);
        }

        Console.WriteLine("Palíndromos únicos encontrados:");
        foreach (var palabra in palabras)
        {
            if (EsPalindromo(palabra))
            {
                Console.WriteLine(palabra);
            }
        }
    }

    public static bool EsPalindromo(string palabra)
    {
        int izquierda = 0;
        int derecha = palabra.Length - 1;

        while (izquierda < derecha)
        {
            if (palabra[izquierda] != palabra[derecha])
                return false;
            izquierda++;
            derecha--;
        }
        return true;
    }
}
