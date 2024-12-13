using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento1
{
    public class Persona
    {
        //Atributos
        public string nombre;
        public DateTime fechaNacimiento;
        private int edad;

        //Métodos
        public void registrar()
        {
            calcularEdad(fechaNacimiento);
            Console.WriteLine(nombre + " con " + edad + " años de edad, ha sido registrado correctamente");
        }

        private void calcularEdad(DateTime fechaNacimientoPersona)
        {
            DateTime fechaActual = DateTime.Now;
            edad = fechaActual.Year - fechaNacimientoPersona.Year;
        }
    }
}
