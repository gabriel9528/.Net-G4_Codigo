using System;

class Program
{
    static int ContarVocales(string texto)
    {
        int contador = 0;
        foreach (char c in texto.ToLower())
        {
            if ("aeiou".Contains(c)) contador++;
        }
        return contador;
    }

    static void Main()
    {
        string texto = "Hola Mundo";
        int cantidadVocales = ContarVocales(texto);
        Console.WriteLine("Cantidad de vocales: " + cantidadVocales);
    }
}
