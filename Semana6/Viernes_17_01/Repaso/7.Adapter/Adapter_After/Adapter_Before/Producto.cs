using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Before
{
    public class Producto
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }

        public Producto(string nombre, int precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public Producto()
        {
            
        }
    }
}
