class Program
{
    static bool EsPalindromo(string texto)
    {
        texto = texto.Replace(" ", "");
        string textReverse = new string(texto.Reverse().ToArray());

        return texto == textReverse; 

    }

    static void Main(string[] args)
    {
        string paindromo = "radar";
        Console.WriteLine($"¿Es palindromo? {EsPalindromo (paindromo)}");
    }
}