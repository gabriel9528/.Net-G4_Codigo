using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoInterfaces
{
    public class Empleado : IPersona
    {
        public string Nombre { get; set; }
        public Empleado(string nombre)
        {
            this.Nombre = nombre;
        }
        public string Despedirse()
        {
            string adios = "El empleado " + this.Nombre + " se despide cordialmente";
            return adios;
        }
    }
}
