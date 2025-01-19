
using Singleton_Before;

class Program
{
    static void Main(string[] args)
    {
        var capitales = new SingletonContainer();
        Console.WriteLine($"Los habitanes de Peru son: { capitales.GetPopulation("Lima")}");
        Console.ReadLine();
    }
}