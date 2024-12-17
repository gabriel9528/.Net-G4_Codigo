using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;
namespace Problem
{
    //Reporte de cursos impartidos
    class Program
    {
        static void Main(string[] args)
        {
            var report = new CourseReport();
            report.AddEntry(new CourseReportEntry{ Name = "Patrones de diseño", Students= 1000, Rating = 50 });
            report.AddEntry(new CourseReportEntry { Name = "Flutter", Students = 1900, Rating = 45 });

            Console.WriteLine(report.ToString());
            Console.ReadLine();
            report.SaveToFile(@"Reports123", "WorkReport123.txt", report);
        }
    }

    public class CourseReportEntry
    {
        public string Name { get; set; }
        public int Students { get; set; }
        public double Rating { get; set; }
    }

    public class CourseReport
    {
        private readonly List<CourseReportEntry> _entries;

        public CourseReport()
        {
            _entries = new List<CourseReportEntry>();
        }

        public void AddEntry(CourseReportEntry entry) => _entries.Add(entry);

        public void RemoveEntryAt(int index) => _entries.RemoveAt(index);

        public void SaveToFile(string directoryPath, string fileName, CourseReport report)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            //Esta línea crea o sobrescribe un archivo en la ruta especificada combinando
            //directoryPath y fileName. Path.Combine() se utiliza para combinar la ruta del
            //directorio y el nombre del archivo para formar una ruta completa. ToString()
            //se utiliza para obtener una representación de cadena del objeto actual, la cual es
            //la información que se desea escribir en el archivo. 
            //File.WriteAllText(Path.Combine(directoryPath, fileName), ToString());
            File.WriteAllText(Path.Combine(directoryPath, fileName), report.ToString());
        }
        public override string ToString() =>
            string.Join(Environment.NewLine, _entries.Select(x => $"Curso: {x.Name}, Estudiantes: {x.Students}, Valoración: {x.Rating}"));
    }
}
