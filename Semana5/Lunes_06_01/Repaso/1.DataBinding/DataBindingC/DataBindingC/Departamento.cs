using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingC
{
    public class Departamento : List<Estudiante>
    {
        public string NombreDepartamento { get; set; }

        public Departamento(string nombreDepartamento)
        {
            NombreDepartamento = nombreDepartamento;
        }

        public List<Estudiante> Estudiantessss1
        {
            get { return this; }
        }
    }
}
