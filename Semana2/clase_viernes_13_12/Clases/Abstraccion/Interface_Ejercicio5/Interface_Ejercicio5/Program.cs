

using Interface_Ejercicio5;

class Program
{
    static void Main(string[] args)
    {
        //Crear instancias de cada clase
        IPago tarjetaCredito = new TarjetaCredito("4887-5203-9630-4107", "Pepito", new DateTime(2025, 12, 13));
        IPago transferenciaBancaria = new TransferenciaBancaria("5200-1358-9620-1047", "Interbank");
        IPago paypal = new PayPal("pepito@paypal.com");

        List<IPago> lista = new List<IPago>();
        lista.Add(tarjetaCredito);
        lista.Add(transferenciaBancaria);
        lista.Add(paypal);

        foreach (IPago p in lista)
        {
            p.ProcesarPago(1000.00);
            p.VerificarEstado();
            p.ObtenerDetalles();
            Console.WriteLine("*****************************");
            Console.WriteLine("");
        }

    }
}