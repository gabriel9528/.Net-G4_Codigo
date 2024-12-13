using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    public class Estudiante : Persona
    {
        public double Promedio { get; set; }
        public List<string> CursosInscritos { get; set; }

        // Constructor
        public Estudiante(int id, string nombre, int edad, double promedio)
            : base(id, nombre, edad)
        {
            Promedio = promedio;
            CursosInscritos = new List<string>();
        }

        // Método para inscribirse en un curso
        public void InscribirseEnCurso(string curso)
        {
            CursosInscritos.Add(curso);
            Console.WriteLine($"{Nombre} se ha inscrito en el curso: {curso}");
        }

        // Sobrescritura del método para mostrar información
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Promedio: {Promedio}");
            Console.WriteLine($"Cursos Inscritos: {string.Join(", ", CursosInscritos)}");
        }
    }
}
