using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingB
{
    public class Universidad
    {
        public string Acronimo {  get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public Universidad(string acronimo, string nombre, string direccion)
        {
            Acronimo = acronimo;
            Nombre = nombre;
            Direccion = direccion;
        }
    }
}
