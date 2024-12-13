using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    public class Profesor : Persona
    {
        public double Salario { get; set; }
        public string Especializacion { get; set; }
        public List<string> CursosAsignados { get; set; }

        // Constructor
        public Profesor(int id, string nombre, int edad, double salario, string especializacion)
            : base(id, nombre, edad)
        {
            Salario = salario;
            Especializacion = especializacion;
            CursosAsignados = new List<string>();
        }

        // Método para asignar un curso
        public void AsignarCurso(string curso)
        {
            CursosAsignados.Add(curso);
            Console.WriteLine($"{Nombre} ha sido asignado al curso: {curso}");
        }

        // Sobrescritura del método para mostrar información
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Salario: {Salario}, Especialización: {Especializacion}");
            Console.WriteLine($"Cursos Asignados: {string.Join(", ", CursosAsignados)}");
        }
    }
}
