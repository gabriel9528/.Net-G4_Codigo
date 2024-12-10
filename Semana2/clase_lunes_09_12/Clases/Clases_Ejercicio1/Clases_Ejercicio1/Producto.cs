using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crea una clase Producto con propiedades Nombre y Precio. Luego, crea una clase Tienda que contenga
//una lista de productos. La clase Tienda debe tener un método AgregarProducto, un método EliminarProducto,
//y un método MostrarInventario que imprima todos los productos en el inventario junto con su precio total. 

namespace Clases_Ejercicio1
{
    public class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Producto(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

    }
    
}
