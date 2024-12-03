using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un número (1-12) para el mes: ");
        int mes = Convert.ToInt32(Console.ReadLine());

        switch (mes)
        {
            case 1: Console.WriteLine("Enero"); break;
            case 2: Console.WriteLine("Febrero"); break;
            case 3: Console.WriteLine("Marzo"); break;
            case 4: Console.WriteLine("Abril"); break;
            case 5: Console.WriteLine("Mayo"); break;
            case 6: Console.WriteLine("Junio"); break;
            case 7: Console.WriteLine("Julio"); break;
            case 8: Console.WriteLine("Agosto"); break;
            case 9: Console.WriteLine("Septiembre"); break;
            case 10: Console.WriteLine("Octubre"); break;
            case 11: Console.WriteLine("Noviembre"); break;
            case 12: Console.WriteLine("Diciembre"); break;
            default: Console.WriteLine("Número inválido"); break;
        }
    }
}
