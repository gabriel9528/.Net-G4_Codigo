using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Ejercicio4
{
    internal class Cheff : Cocinero
    {
        public Cheff(string nombre, int edad, decimal salario, string especialidad, int experiencia) 
            : base(nombre, edad, salario, especialidad, experiencia)
        {
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
        }
    }
}
