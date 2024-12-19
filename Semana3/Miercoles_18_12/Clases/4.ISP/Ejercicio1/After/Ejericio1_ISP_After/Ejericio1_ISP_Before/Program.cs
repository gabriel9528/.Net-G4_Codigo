using Ejericio1_ISP_Before;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Demostracion del principio de separacion de interfaces");
        Console.WriteLine("******************************************************");
        Console.WriteLine("");
        Console.WriteLine("");

        //Crear instancias de HPPriter
        Console.WriteLine("Usando la impresora HPPrinter");
        HPPrinter hpPrinter = new HPPrinter();
        hpPrinter.Print("Imprimiendo desde HPPrinter");
        hpPrinter.Scan("Scaneando desde HPPrinter");
        hpPrinter.Fax("Enviando un Fax desde HPPrinter");

        Console.WriteLine("");
        Console.WriteLine("");

        //Crear instancias de EpsonPrinter
        Console.WriteLine("Usando la impresora Epson");
        EpsonPrinter epsonPrinter = new EpsonPrinter();
        epsonPrinter.Print("Imprimiendo desde EpsonPrinter");
        epsonPrinter.Scan("Scneando desde EpsonPrinter");



        Console.ReadLine();


    }
}