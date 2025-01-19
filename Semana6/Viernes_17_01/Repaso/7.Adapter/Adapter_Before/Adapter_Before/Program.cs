using Adapter_Before;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(new JsonConverter().GetJson());
        Console.ReadLine();
    }
}