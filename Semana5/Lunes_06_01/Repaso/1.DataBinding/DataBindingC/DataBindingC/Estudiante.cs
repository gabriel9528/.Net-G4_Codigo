using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingC
{
    public class Estudiante
    {
        public string NombreEstudiante { get; set; }
        public string Direccion { get; set; }

        public Estudiante(string nombre, string direccion)
        {
            NombreEstudiante = nombre;
            Direccion = direccion;
        }
    }
}
