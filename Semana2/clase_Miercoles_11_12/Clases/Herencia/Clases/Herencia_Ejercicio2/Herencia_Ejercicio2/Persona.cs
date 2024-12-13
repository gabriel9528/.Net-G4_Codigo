using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Ejercicio2
{
    internal class Persona
    {
        private string _nombre;
        private int _edad;

        internal string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        internal int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        internal void Imprimir()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
        }
    }
}
