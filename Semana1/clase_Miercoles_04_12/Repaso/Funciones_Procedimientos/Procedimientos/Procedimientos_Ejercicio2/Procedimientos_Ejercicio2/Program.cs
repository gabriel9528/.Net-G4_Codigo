using System;

class Program
{
    static void SumarYRestar(int a, int b)
    {
        int suma = a + b;
        int resta = a - b;
        Console.WriteLine($"La suma es: {suma}");
        Console.WriteLine($"La resta es: {resta}");
    }

    static void Main()
    {
        Console.WriteLine("Ingrese dos números:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        SumarYRestar(num1, num2);
    }
}
