class Program
{
    static int ContarVocales(string texto)
    {
        int contador = 0;

        foreach(char c in texto)
        {
            if ("aeiou".Contains(c))
            {
                contador++;
            }
        }
        return contador;
    }

    static void Main(string[] args)
    {
        string texto_1 = "HOLA";
        int result = ContarVocales(texto_1);

        Console.WriteLine($"La cantidad de vocales de nuestro text: {texto_1} es: {result}");
    }
}