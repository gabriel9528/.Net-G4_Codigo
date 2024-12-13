using System;
using System.Collections.Generic;
using System.Linq;

public class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }

    public Producto(string nombre, decimal precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}

public class Tienda
{
    private List<Producto> inventario = new List<Producto>();

    public void AgregarProducto(Producto producto)
    {
        inventario.Add(producto);
        Console.WriteLine($"Producto agregado: {producto.Nombre}");
    }

    public void EliminarProducto(string nombre)
    {
        Producto producto = inventario.FirstOrDefault(p => p.Nombre == nombre);
        if (producto != null)
        {
            inventario.Remove(producto);
            Console.WriteLine($"Producto eliminado: {producto.Nombre}");
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }
    }

    public void MostrarInventario()
    {
        Console.WriteLine("Inventario de la tienda:");
        foreach (Producto producto in inventario)
        {
            Console.WriteLine($"{producto.Nombre} - Precio: {producto.Precio:C}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Tienda tienda = new Tienda();

        // Agregar productos
        Console.Write("¿Cuántos productos deseas agregar? ");
        if (int.TryParse(Console.ReadLine(), out int cantidadProductos) && cantidadProductos > 0)
        {
            for (int i = 0; i < cantidadProductos; i++)
            {
                Console.Write($"Ingrese el nombre del producto {i + 1}: ");
                string nombre = Console.ReadLine();

                decimal precio;
                Console.Write($"Ingrese el precio del producto {i + 1}: ");
                while (!decimal.TryParse(Console.ReadLine(), out precio) || precio <= 0)
                {
                    Console.Write("Por favor, ingrese un precio válido para el producto: ");
                }

                tienda.AgregarProducto(new Producto(nombre, precio));
            }
        }
        else
        {
            Console.WriteLine("Número inválido de productos para agregar.");
        }

        // Mostrar inventario
        tienda.MostrarInventario();

        // Eliminar producto
        Console.Write("Ingrese el nombre del producto que desea eliminar: ");
        string nombreEliminar = Console.ReadLine();
        tienda.EliminarProducto(nombreEliminar);

        // Mostrar inventario final
        tienda.MostrarInventario();
    }
}
