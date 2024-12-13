using System;

class Program
{
    static void Main()
    {
        // Ingresar el número de estudiantes y la cantidad de calificaciones
        Console.Write("Ingrese el número de estudiantes: ");
        int numEstudiantes = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la cantidad de calificaciones por estudiante: ");
        int numCalificaciones = int.Parse(Console.ReadLine());

        // Crear la matriz para almacenar las calificaciones
        double[,] calificaciones = new double[numEstudiantes, numCalificaciones];

        // Ingresar las calificaciones
        for (int i = 0; i < numEstudiantes; i++)
        {
            Console.WriteLine($"\nIngrese las calificaciones para el estudiante {i + 1}:");
            for (int j = 0; j < numCalificaciones; j++)
            {
                Console.Write($"Calificación {j + 1}: ");
                calificaciones[i, j] = double.Parse(Console.ReadLine());
            }
        }

        // Imprimir la matriz de calificaciones
        Console.WriteLine("\nMatriz de calificaciones:");
        for (int i = 0; i < numEstudiantes; i++)
        {
            Console.Write($"Estudiante {i + 1}: ");
            for (int j = 0; j < numCalificaciones; j++)
            {
                Console.Write(calificaciones[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Calcular y mostrar el promedio de cada estudiante
        for (int i = 0; i < numEstudiantes; i++)
        {
            double suma = 0;
            for (int j = 0; j < numCalificaciones; j++)
            {
                suma += calificaciones[i, j];
            }
            double promedio = suma / numCalificaciones;
            Console.WriteLine($"Promedio del estudiante {i + 1}: {promedio:F2}");
        }
    }
}
