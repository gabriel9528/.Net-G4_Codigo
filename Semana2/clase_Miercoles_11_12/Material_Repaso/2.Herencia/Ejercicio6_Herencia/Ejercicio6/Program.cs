using Ejercicio6;

class Program
{
    static void Main()
    {
        // Crear lista de estudiantes
        var estudiantes = new List<Estudiante>
        {
            new Estudiante(1, "Juan Pérez", 20, 8.5),
            new Estudiante(2, "María López", 22, 9.0)
        };

        // Crear lista de profesores
        var profesores = new List<Profesor>
        {
            new Profesor(101, "Carlos Sánchez", 45, 50000, "Matemáticas"),
            new Profesor(102, "Ana Gómez", 38, 48000, "Historia")
        };

        // Inscribir estudiantes en cursos
        estudiantes[0].InscribirseEnCurso("Álgebra Lineal");
        estudiantes[1].InscribirseEnCurso("Historia Moderna");

        // Asignar cursos a profesores
        profesores[0].AsignarCurso("Álgebra Lineal");
        profesores[1].AsignarCurso("Historia Moderna");

        // Mostrar información de estudiantes
        Console.WriteLine("\n--- Información de Estudiantes ---");
        foreach (var estudiante in estudiantes)
        {
            estudiante.MostrarInformacion();
            Console.WriteLine();
        }

        // Mostrar información de profesores
        Console.WriteLine("\n--- Información de Profesores ---");
        foreach (var profesor in profesores)
        {
            profesor.MostrarInformacion();
            Console.WriteLine();
        }
    }
}