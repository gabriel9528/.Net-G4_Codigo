
using Ejercicio1_Singleton;

class Program
{
    static void Main(string[] args)
    {
        var capitales = SingletonContainer.Instance;
        var capitales2 = SingletonContainer.Instance;
        var capitales3 = SingletonContainer.Instance;
        Console.WriteLine($"Los habitantes de Peru son: {capitales.GetPopulation("Lima")}");
        Console.ReadLine();
    }
}