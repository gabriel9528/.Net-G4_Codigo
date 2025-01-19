
using Ejercicio1_Singleton;

class Program
{
    static void Main(string[] args)
    {
        var capitales = new SingletonContainer();
        Console.WriteLine($"Los habitantes de Peru son: {capitales.GetPopulation("Lima")}");
        Console.ReadLine();
    }
}