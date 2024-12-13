using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { -1, 2, -3, 4, -5, 6 };
        EliminarNegativos(numeros);
        Console.WriteLine("Lista sin negativos: " + string.Join(", ", numeros));
    }

    static void EliminarNegativos(List<int> lista)
    {
        lista.RemoveAll(n => n < 0);
    }
}
