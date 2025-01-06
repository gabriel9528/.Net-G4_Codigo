using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntornoGrafico
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string direccion;
        private string genero;

        public string Nombre 
        { 
            get { return nombre; } 
            set { nombre = value; } 
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
    }
}
