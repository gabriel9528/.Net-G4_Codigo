using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crear una clase Persona que tenga como atributos el nombre y la edad
//(definir las propiedades para poder acceder a dichos atributos).
//Definir como responsabilidad un método para imprimir.
//Plantear una segunda clase Empleado que herede de la clase Persona.
//Añadir un atributo sueldo ( y su propiedad) y el método para imprimir su sueldo.
//Definir un objeto de la clase Persona y llamar a sus métodos y propiedades.
//También crear un objeto de la clase Empleado y llamar a sus métodos y propiedades.


namespace Herencia1
{
    public class Persona
    {
        private string nombre;
        private int edad;

        internal string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        internal int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }

        internal void Imprimir()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
        }
    }
}
