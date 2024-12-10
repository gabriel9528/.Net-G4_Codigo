

//Crea una clase Producto con propiedades Nombre y Precio. Luego, crea una clase Tienda que contenga
//una lista de productos. La clase Tienda debe tener un método AgregarProducto, un método EliminarProducto,
//y un método MostrarInventario que imprima todos los productos en el inventario junto con su precio total. 

using Clases_Ejercicio1;

class Program
{
    static void Main(string[] args)
    {
        Tienda tiendita = new Tienda();

        Console.WriteLine("¿Cuantos productos desea agregar: ?");
        if(int.TryParse(Console.ReadLine(), out int cantidadProductos) && cantidadProductos > 0)
        {
            for(int i = 0; i < cantidadProductos; i++)
            {
                //NOMBRE
                Console.WriteLine($"Ingrese el nombre del producto {i + 1}: ");
                string nombreProducto = Console.ReadLine();

                //PRECIO
                double precioProducto;
                Console.WriteLine($"Ingrese el precio del producto {i + 1}: ");
                while(!double.TryParse(Console.ReadLine(), out precioProducto) && precioProducto > 0)
                {
                    Console.WriteLine($"Ingrese un precio valido para el producto: {i + 1}");
                }

                tiendita.AgregarProducto(new Producto(nombreProducto, precioProducto));
            }
        }
        else
        {
            Console.WriteLine($"Ingrese un numero valido de productos a agregar");
        }


        //Mostrar inventario
        tiendita.MostrarInventario();

        //Eliminar Producto
        Console.WriteLine("Ingrese el nombre del producto que desea eliminar: ");
        string eliminarProducto = Console.ReadLine();
        tiendita.EliminarProducto(eliminarProducto);

        //Mostrar inventario
        tiendita.MostrarInventario();

    }
}