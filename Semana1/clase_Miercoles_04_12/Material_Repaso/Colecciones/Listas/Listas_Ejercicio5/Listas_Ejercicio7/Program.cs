using System;
using System.Collections.Generic;
using System.Linq;

class Estudiante
{
    public string Nombre { get; set; }
    public decimal NotaFinal { get; set; }

    public Estudiante(string nombre, decimal notaFinal)
    {
        Nombre = nombre;
        NotaFinal = notaFinal;
    }
}

class Program
{
    static void Main()
    {
        List<Estudiante> estudiantes = new List<Estudiante>();

        // Solicitar la cantidad de estudiantes
        Console.Write("Ingrese el número de estudiantes: ");
        int cantidadEstudiantes = int.Parse(Console.ReadLine());

        // Ingresar los datos de cada estudiante
        for (int i = 0; i < cantidadEstudiantes; i++)
        {
            Console.WriteLine($"\nIngrese los datos del estudiante {i + 1}:");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Nota final: ");
            decimal notaFinal;
            while (!decimal.TryParse(Console.ReadLine(), out notaFinal) || notaFinal < 0 || notaFinal > 100)
            {
                Console.Write("Nota inválida. Ingrese una nota entre 0 y 100: ");
            }

            estudiantes.Add(new Estudiante(nombre, notaFinal));
        }

        // Calcular el promedio de las notas
        decimal promedio = estudiantes.Average(e => e.NotaFinal);
        Console.WriteLine($"\nPromedio de notas: {promedio:F2}");

        // Obtener la lista de estudiantes que aprobaron
        List<Estudiante> aprobados = estudiantes.Where(e => e.NotaFinal >= 60).ToList();
        Console.WriteLine("\nEstudiantes aprobados:");
        foreach (var estudiante in aprobados)
        {
            Console.WriteLine($"{estudiante.Nombre} - Nota: {estudiante.NotaFinal}");
        }

        // Encontrar al estudiante con la nota más alta
        Estudiante mejorEstudiante = estudiantes.OrderByDescending(e => e.NotaFinal).First();
        Console.WriteLine($"\nEl estudiante con la nota más alta es {mejorEstudiante.Nombre} con una nota de {mejorEstudiante.NotaFinal}");

        // Ordenar la lista de estudiantes por su nota en orden descendente
        estudiantes.Sort((a, b) => b.NotaFinal.CompareTo(a.NotaFinal));
        Console.WriteLine("\nEstudiantes ordenados por nota (de mayor a menor):");
        foreach (var estudiante in estudiantes)
        {
            Console.WriteLine($"{estudiante.Nombre} - Nota: {estudiante.NotaFinal}");
        }
    }
}
