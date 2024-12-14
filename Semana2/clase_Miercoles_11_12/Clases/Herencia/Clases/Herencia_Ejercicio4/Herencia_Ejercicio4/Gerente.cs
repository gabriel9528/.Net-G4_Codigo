using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Ejercicio4
{
    internal class Gerente : Empleado
    {
        public string Departamento { get; set; }
        public int AñosExperiencia { get; set; }
        public Gerente(string nombre, int edad, decimal salario, string Departamento, int añosExperiencia) 
            : base(nombre, edad, salario)
        {
            this.Departamento = Departamento;
            AñosExperiencia = añosExperiencia;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Departamento: " + Departamento);
            Console.WriteLine("Años de experiencia: " + AñosExperiencia + " años.");
        }
    }
}
