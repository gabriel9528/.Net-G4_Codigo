using System;

class Program
{
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        Console.WriteLine("Ingrese un número para calcular la serie de Fibonacci:");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 0; i < numero; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }
}
