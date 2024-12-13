using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores_en_la_herencia2
{
    public class Gerente : Empleado
    {
        public string Departamento { get; set; }
        public int AniosExperiencia { get; set; }

        public Gerente(string nombre, int edad, decimal salario, string departamento, int aniosExperiencia)
            : base(nombre, edad, salario)
        {
            Departamento = departamento;
            AniosExperiencia = aniosExperiencia;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Departamento: " + Departamento);
            Console.WriteLine("Años de experiencia: " + AniosExperiencia);
        }
    }
}
