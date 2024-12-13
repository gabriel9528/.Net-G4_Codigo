using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Encapsulamiento_Ejercicio1
{
    internal class PersonaPropiedades
    {
        //Atributos
        private string _nombre;
        private DateTime _fechaNacimiento;
        private int _edad;

        //Propiedades
        public int Edad
        {
            get { return _edad; }
            private set
            {
                _edad = value;
            }
        }

        internal string Nombre
        {
            get { return _nombre; }
            set
            {
                _nombre = value;
            }
        }

        internal DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set
            {
                _fechaNacimiento = value;
            }
        }


        //Metodos
        public void RegistrarPersona()
        {
            CalcularEdad(FechaNacimiento);
            Console.WriteLine(Nombre + " con " + Edad + " años de edad, ha sido agregado exitosamente");
        }

        private void CalcularEdad(DateTime fechaNacimientoPersona)
        {
            DateTime fechaActual = DateTime.Now;
            Edad = fechaActual.Year - fechaNacimientoPersona.Year;
        }
    }
}
