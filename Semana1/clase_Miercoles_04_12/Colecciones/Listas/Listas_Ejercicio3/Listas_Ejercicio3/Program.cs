using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 3, 2 };
        Console.WriteLine("Cantidad de números únicos: " + ContarUnicos(numeros));
    }

    static int ContarUnicos(List<int> lista)
    {
        return lista.Distinct().Count();
    }
}


//class Program
//{
//    static void Main()
//    {
//        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 3, 2 };
//        Console.WriteLine("Cantidad de números únicos: " + ContarUnicos(numeros));
//    }

//    static int ContarUnicos(List<int> lista)
//    {
//        return lista.GroupBy(x => x)
//                    .Where(g => g.Count() == 1) // Filtra los elementos que aparecen una sola vez
//                    .Count();
//    }
//}