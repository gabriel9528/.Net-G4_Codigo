

using Ejercicio3A_Abstraccion_Interfaces;

class Program
{
    static void Main()
    {
        // Crear instancias de cada método de pago
        IPago tarjetaCredito = new TarjetaCredito("1234-5678-9123-4567", "Juan Pérez", new DateTime(2025, 12, 31));
        IPago payPal = new PayPal("juan.perez@example.com");
        IPago transferenciaBancaria = new TransferenciaBancaria("0011223344556677", "Banco de Ejemplo");

        // Arreglo de métodos de pago
        IPago[] metodosPago = { tarjetaCredito, payPal, transferenciaBancaria };

        // Procesar pago, verificar estado y obtener detalles de cada método de pago
        foreach (IPago metodo in metodosPago)
        {
            metodo.ProcesarPago(100.00);
            Console.WriteLine(metodo.VerificarEstado());
            Console.WriteLine(metodo.ObtenerDetalles());
            Console.WriteLine();
        }
    }
}