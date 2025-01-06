using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntornoGrafico
{
    public class ControladorPersona
    {
        private List<Persona> listPerson;

        public ControladorPersona()
        {
            listPerson = new List<Persona>();
        }

        public void AgregarPersona(Persona persona)
        {
            listPerson.Add(persona);
        }

        public List<Persona> ObtenerPersonas()
        {
            return listPerson;
        }

        public void EliminarPersona(Persona persona)
        {
            listPerson.Remove(persona);
        }

    }
}
