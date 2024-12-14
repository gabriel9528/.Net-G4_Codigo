using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Ejercicio4
{
    internal class Cocinero : Empleado
    {
        public string Especialidad {  get; set; }
        public int Experiencia { get; set; }

        public Cocinero(string nombre, int edad, decimal salario, string especialidad, int experiencia)
            : base(nombre, edad, salario)
        {
            Especialidad = especialidad;
            Experiencia = experiencia;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Especialidad: " + Especialidad);
            Console.WriteLine("Experiencia: " + Experiencia + " años");
        }

        public override sealed void MostrarInformacion2()
        {
            Console.WriteLine("Pruebitaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
        }

    }
}
