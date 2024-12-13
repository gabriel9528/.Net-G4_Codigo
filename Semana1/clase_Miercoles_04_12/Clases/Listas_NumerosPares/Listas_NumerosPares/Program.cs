
class Program
{


    //static List<int> listaPares = new List<int>();
    static List<int> listaPares = new List<int>();
    static int suma = 0;
    static int obtenerListaPares(List<int> numbers)
    {
        
        foreach (int n in numbers)
        {
            if(n % 2 == 0)
            {
                listaPares.Add(n);
            }
        }

        int resultao  = CalcularNumerosLista(listaPares);
        return resultao;

    }

    static int CalcularNumerosLista(List<int> numbers)
    {
        
        foreach (int n in numbers)
        {
            suma += n;
        }

        return suma;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el tamaño de su lista: ");
        Console.WriteLine("******************************* ");
        Console.WriteLine("------------------------------- ");

        List<int> requestInt = new List<int>();

        string sizeString = Console.ReadLine();
        int sizeInt = 0;
        if(int.TryParse(sizeString, out int val))
        {
            sizeInt = val;
        }

        for(int i = 0;  i < sizeInt; i++)
        {
            Console.WriteLine("ingrese el numero de su lista: ");
            string sizeItem = Console.ReadLine();
            if (int.TryParse(sizeItem, out int val1))
            {
                requestInt.Add(val1);
            }
        }

        Console.WriteLine("******************************* ");
        Console.WriteLine("------------------------------- ");
        Console.WriteLine($"La suma de su lista es: {obtenerListaPares(requestInt)}");
    }
}