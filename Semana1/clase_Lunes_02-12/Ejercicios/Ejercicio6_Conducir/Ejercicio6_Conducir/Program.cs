using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce tu edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("Puedes obtener una licencia de conducir.");
        }
        else
        {
            Console.WriteLine("No puedes obtener una licencia de conducir.");
        }
    }
}
