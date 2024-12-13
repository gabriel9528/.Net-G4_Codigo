using System;
using System.Collections.Generic;
using System.Linq;

class Producto
{
    public string Nombre { get; set; }
    public int CantidadEnStock { get; set; }
    public decimal Precio { get; set; }

    public Producto(string nombre, int cantidadEnStock, decimal precio)
    {
        Nombre = nombre;
        CantidadEnStock = cantidadEnStock;
        Precio = precio;
    }

    public decimal ValorTotal()
    {
        return CantidadEnStock * Precio;
    }
}

class Program
{
    static void Main()
    {
        List<Producto> inventario = new List<Producto>();

        // Solicitar la cantidad de productos
        Console.Write("Ingrese el número de productos: ");
        int cantidadProductos = int.Parse(Console.ReadLine());

        // Ingresar los datos de cada producto
        for (int i = 0; i < cantidadProductos; i++)
        {
            Console.WriteLine($"\nIngrese los datos del producto {i + 1}:");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Cantidad en stock: ");
            int cantidadEnStock;
            while (!int.TryParse(Console.ReadLine(), out cantidadEnStock) || cantidadEnStock < 0)
            {
                Console.Write("Cantidad inválida. Ingrese una cantidad válida en stock: ");
            }

            Console.Write("Precio: ");
            decimal precio;
            while (!decimal.TryParse(Console.ReadLine(), out precio) || precio < 0)
            {
                Console.Write("Precio inválido. Ingrese un precio válido: ");
            }

            inventario.Add(new Producto(nombre, cantidadEnStock, precio));
        }

        // Agregar un nuevo producto
        Console.WriteLine("\nIngrese los datos del nuevo producto para agregar al inventario:");

        Console.Write("Nombre: ");
        string nuevoNombre = Console.ReadLine();

        Console.Write("Cantidad en stock: ");
        int nuevaCantidadEnStock;
        while (!int.TryParse(Console.ReadLine(), out nuevaCantidadEnStock) || nuevaCantidadEnStock < 0)
        {
            Console.Write("Cantidad inválida. Ingrese una cantidad válida en stock: ");
        }

        Console.Write("Precio: ");
        decimal nuevoPrecio;
        while (!decimal.TryParse(Console.ReadLine(), out nuevoPrecio) || nuevoPrecio < 0)
        {
            Console.Write("Precio inválido. Ingrese un precio válido: ");
        }

        inventario.Add(new Producto(nuevoNombre, nuevaCantidadEnStock, nuevoPrecio));

        // Ordenar por precio (de mayor a menor)
        inventario.Sort((a, b) => b.Precio.CompareTo(a.Precio));

        // Verificar si un producto está en el inventario
        Console.Write("\nIngrese el nombre del producto para verificar si está en el inventario: ");
        string nombreProducto = Console.ReadLine();
        bool existeProducto = inventario.Exists(p => p.Nombre.Equals(nombreProducto, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine($"¿El inventario tiene {nombreProducto}? " + (existeProducto ? "Sí" : "No"));

        // Mostrar productos ordenados por precio
        Console.WriteLine("\nProductos ordenados por precio (de mayor a menor):");
        foreach (var producto in inventario)
        {
            Console.WriteLine($"{producto.Nombre} - Precio: {producto.Precio:C} - Stock: {producto.CantidadEnStock}");
        }

        // Calcular el valor total del inventario
        decimal valorTotal = inventario.Sum(p => p.ValorTotal());
        Console.WriteLine($"\nValor total del inventario: {valorTotal:C}");
    }
}
