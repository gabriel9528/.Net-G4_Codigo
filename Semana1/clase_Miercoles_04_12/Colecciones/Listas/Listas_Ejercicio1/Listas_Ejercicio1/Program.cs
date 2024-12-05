using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine("Suma de números pares: " + SumarPares(numeros));
    }

    static int SumarPares(List<int> lista)
    {
        return lista.Where(n => n % 2 == 0).Sum();
    }
}
