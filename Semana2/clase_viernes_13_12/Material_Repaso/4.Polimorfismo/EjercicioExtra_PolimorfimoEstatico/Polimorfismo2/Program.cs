using Polimorfismo2;

class Program
{
    static void Main(string[] args)
    {
        List<Paquete> paquetes = new List<Paquete>
        {
            new PaqueteNormal(5, "Ciudad A", "Grande", true),
            new PaqueteExpress(3, "Ciudad B", true, true)
        };

        foreach (var paquete in paquetes)
        {
            Console.WriteLine($"Costo de envío del paquete: ${paquete.CalcularCostoEnvio()}");
        }
    }
}