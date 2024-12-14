using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo1
{
    public class Alumno : Persona
    {
        public Alumno(string nombre)
        {
            this.Nombre = nombre;
        }
        public override string Saludar()
        {
            string saludo = "Hola, mi nombre es " + this.Nombre + " y soy un alumno";
            return saludo;
        }
    }
}
