using ISP;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Demostración del principio de segregación de interfaces (ISP):");

        HPPrinter test = new HPPrinter();
        test.Fax("123");

        // Crear instancia de HPPrinter
        Console.WriteLine("\nUsando la impresora HPPrinter:");
        IPrint hpPrinter = new HPPrinter();
        IFax hpFax = new HPPrinter();
        IScan hpScan = new HPPrinter();

        hpPrinter.Print("Imprimiendo desde HPPrinter...");
        hpFax.Fax("Enviando fax desde HPPrinter...");
        hpScan.Scan("Escaneando desde HPPrinter...");
        

        // Crear instancia de epsonPrinter
        Console.WriteLine("\nUsando la impresora epsonPrinter:");
        IPrint epsonPrinterPrint = new epsonPrinter();
        IScan epsonPrinterScan = new epsonPrinter();

        try
        {
            // Intentar imprimir con epsonPrinter
            epsonPrinterPrint.Print("Imprimiendo desde epsonPrinter...");
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("El método Print no está implementado en epsonPrinter.");
        }

        try
        {
            // Intentar escanear con epsonPrinter
            epsonPrinterScan.Scan("Escaneando desde epsonPrinter...");
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("El método Scan no está implementado en epsonPrinter.");
        }

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}