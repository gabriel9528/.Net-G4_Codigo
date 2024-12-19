

using ISP;

class Program
{
        static void Main(string[] args)
        {
            Console.WriteLine("Demostración del principio de segregación de interfaces (ISP):");

            // Crear instancia de HPPrinter
            Console.WriteLine("\nUsando la impresora HPPrinter:");
            IPrinterTask hpPrinter = new HPPrinter();
            hpPrinter.Print("Imprimiendo desde HPPrinter...");
            hpPrinter.Scan("Escaneando desde HPPrinter...");
            hpPrinter.Fax("Enviando fax desde HPPrinter...");

            // Crear instancia de epsonPrinter
            Console.WriteLine("\nUsando la impresora epsonPrinter:");
            IPrinterTask epsonPrinter = new epsonPrinter();
            epsonPrinter.Print("Imprimiendo desde epsonPrinter...");

            try
            {
                // Intentando usar Fax en epsonPrinter
                epsonPrinter.Fax("Intentando enviar fax desde epsonPrinter...");
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("El método Fax no está implementado en epsonPrinter.");
            }

            Console.ReadKey();
        }
    }