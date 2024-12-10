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
    public class Tienda
    {
        //public List<Producto> listaProductos = new List<Producto>();
        public List<Producto> listaProductos = new ();

        public void AgregarProducto(Producto producto)
        {
            listaProductos.Add(producto);
            Console.WriteLine($"Producto agregado correctamente: {producto.Nombre}");
        }

        public void EliminarProducto(string nombre)
        {
            Producto productoEncontrado = listaProductos.FirstOrDefault(x => x.Nombre == nombre);
            if(productoEncontrado != null)
            {
                listaProductos.Remove(productoEncontrado);
                Console.WriteLine($"Producto eliminado correctamente: {productoEncontrado.Nombre}");
            }
            else
            {
                Console.WriteLine($"Producto no encontrado: {nombre}");
            }
        }

        public void MostrarInventario()
        {
            if(listaProductos != null && listaProductos.Count > 0)
            {
                Console.WriteLine("Inventario de la tienda: ");
                foreach(Producto p in listaProductos)
                {
                    Console.WriteLine($"{p.Nombre} -> {p.Precio}");
                }
            }
        }
    }
}
