using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Diccionario que almacena nombres y calificaciones
        Dictionary<string, int> estudiantes = new Dictionary<string, int>
        {
            { "Ana", 85 },
            { "Juan", 92 },
            { "Pedro", 78 },
            { "Lucía", 88 },
            { "Mario", 95 }
        };

        // Solicitar el nombre del estudiante
        Console.Write("Ingrese el nombre del estudiante: ");
        string nombre = Console.ReadLine();

        // Verificar si el estudiante existe y mostrar la calificación
        if (estudiantes.ContainsKey(nombre))
        {
            Console.WriteLine($"La calificación de {nombre} es {estudiantes[nombre]}.");
        }
        else
        {
            Console.WriteLine("Estudiante no encontrado.");
        }
    }
}
