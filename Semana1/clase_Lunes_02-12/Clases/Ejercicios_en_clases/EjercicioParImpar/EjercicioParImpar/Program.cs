class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el numero:");
        string numero = Console.ReadLine();
        if (!string.IsNullOrEmpty(numero))
        {
            if(int.TryParse(numero, out int val))
            {
                val = int.Parse(numero);
                if(val % 2 == 0)
                {
                    Console.WriteLine("numero par");
                }
                else
                {
                    Console.WriteLine("numero impar");
                }
            }
        }
        else
        {
            Console.WriteLine("NO se puede convertir el numero");
        }
    }
}