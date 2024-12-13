class Program
{
    static void Main(string[] args)
    {
        HashSet<string> nombres = new HashSet<string>();

        while (true)
        {
            Console.WriteLine("Ingrese un nombre (caso contrario colocar *fin*)");
            string name = Console.ReadLine();

            if(name.ToLower() == "fin")
            {
                break;
            }
            else
            {
                if (nombres.Add(name))
                {
                    Console.WriteLine($"{name} fue agregado correctamente");
                }
                else
                {
                    Console.WriteLine($"{name} ya fue agregado a la lista.");
                }
                
            }

        }

        Console.WriteLine("Nombres ingresados");
        foreach(string name in nombres)
        {
            Console.WriteLine(name);
        }

    }
}