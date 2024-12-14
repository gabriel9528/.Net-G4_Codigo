using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoInterfaces
{
    public class Alumno : IPersona
    {
        public string Nombre { get; set; }
        public Alumno(string nombre)
        {
            this.Nombre = nombre;
        }
        public string Despedirse()
        {
            string adios = "El alumno " + this.Nombre + " se despide cordialmente";
            return adios;
        }
    }
}
