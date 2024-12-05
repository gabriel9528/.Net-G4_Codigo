using System;

class Program
{
    static bool EsPalindromo(string texto)
    {
        texto = texto.Replace(" ", "").ToLower();
        string textoReverso = new string(texto.Reverse().ToArray());
        return texto == textoReverso;
    }

    static void Main()
    {
        string palabra = "Anita lava la tina";
        Console.WriteLine($"¿Es palíndromo? {EsPalindromo(palabra)}");
    }
}
