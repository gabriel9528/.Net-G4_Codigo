// See htusing System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un número para la tabla de multiplicar: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}
