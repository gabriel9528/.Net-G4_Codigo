using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Dictionary<string, decimal> productos = new Dictionary<string, decimal>();

        while (true)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Mostrar precio de un producto");
            Console.WriteLine("3. Listar todos los productos");
            Console.WriteLine("4. Salir");

            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("Ingrese el nombre del producto: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese el precio del producto: ");
                decimal precio = decimal.Parse(Console.ReadLine());

                productos[nombre] = precio; // Añade o actualiza el producto
                Console.WriteLine("Producto agregado o actualizado.");
            }
            else if (opcion == "2")
            {
                Console.Write("Ingrese el nombre del producto: ");
                string nombre = Console.ReadLine();

                if (productos.ContainsKey(nombre))
                {
                    Console.WriteLine($"El precio de {nombre} es {productos[nombre]}.");
                }
                else
                {
                    Console.WriteLine("Producto no encontrado.");
                }
            }
            else if (opcion == "3")
            {
                Console.WriteLine("Lista de productos y precios:");
                foreach (var item in productos)
                {
                    Console.WriteLine($"{item.Key}: {item.Value:C}");
                }
            }
            else if (opcion == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Opción inválida. Intente de nuevo.");
            }
        }
    }
}
