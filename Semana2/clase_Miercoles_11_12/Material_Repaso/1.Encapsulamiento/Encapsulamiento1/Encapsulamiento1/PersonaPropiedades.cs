using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento1
{
    public class PersonaPropiedades
    {
        //Atributos
        private string _nombre;
        private DateTime _fechaNacimiento;
        private int _edad;

        //Propiedades
        public int Edad
        {
            get //Encapsulación nivel abierto, por defecto es publico porque la propiedad es publico.
            {
                return _edad;
            }
            private set //Encapsulación nivel cerrado- Privado
            {
                _edad = value;
            }
        }
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
        public DateTime FechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }
            set
            {
                _fechaNacimiento = value;
            }
        }



        //Métodos
        private void calcularEdad(DateTime fechaNacimientoPersona)
        {
            DateTime fechaActual = DateTime.Now;
            Edad = fechaActual.Year - fechaNacimientoPersona.Year;
        }
        public void registrar()
        {
            calcularEdad(FechaNacimiento);
            Console.WriteLine(Nombre + " ha sido registrado correctamente");
        }
    }
}
