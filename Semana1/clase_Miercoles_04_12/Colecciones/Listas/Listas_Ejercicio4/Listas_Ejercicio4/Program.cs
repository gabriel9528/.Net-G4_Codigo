using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 4, 2, 9, 3, 2, 9, 5 };
        List<int> resultado = OrdenarYEliminarDuplicados(numeros);
        Console.WriteLine("Lista ordenada sin duplicados: " + string.Join(", ", resultado));
    }

    static List<int> OrdenarYEliminarDuplicados(List<int> lista)
    {
        return lista.Distinct().OrderByDescending(n => n).ToList();
    }
}
