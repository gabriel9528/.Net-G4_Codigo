

using PolimorfismoDinamico__Interfaces_2;

class Program
{
    static void Main(string[] args)
    {
        List<IPago> metodosPago = new List<IPago>
            {
                new TarjetaCredito("1234 5678 9012 3456", "Juan Pérez", new DateTime(2025, 12, 31)),
                new PayPal("juan.perez@example.com"),
                new TransferenciaBancaria("987654321", "Banco Ejemplo")
            };

        double monto = 100.0;
        foreach (IPago metodoPago in metodosPago)
        {
            metodoPago.ProcesarPago(monto);
            Console.WriteLine(metodoPago.GenerarRecibo());
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}