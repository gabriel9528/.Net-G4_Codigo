using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Dictionary<string, Dictionary<string, decimal>> inventario = new Dictionary<string, Dictionary<string, decimal>>();

        while (true)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Agregar/Actualizar producto");
            Console.WriteLine("2. Realizar venta");
            Console.WriteLine("3. Mostrar resumen del inventario");
            Console.WriteLine("4. Salir");

            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("Ingrese el nombre del producto: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese el precio del producto: ");
                decimal precio = decimal.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad en inventario: ");
                decimal cantidad = decimal.Parse(Console.ReadLine());

                inventario[nombre] = new Dictionary<string, decimal>
                {
                    { "Precio", precio },
                    { "Cantidad", cantidad }
                };
                Console.WriteLine("Producto agregado o actualizado.");
            }
            else if (opcion == "2")
            {
                Console.Write("Ingrese el nombre del producto a vender: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese la cantidad a vender: ");
                decimal cantidadVenta = decimal.Parse(Console.ReadLine());

                if (inventario.ContainsKey(nombre) && inventario[nombre]["Cantidad"] >= cantidadVenta)
                {
                    inventario[nombre]["Cantidad"] -= cantidadVenta;
                    Console.WriteLine($"Venta realizada. Quedan {inventario[nombre]["Cantidad"]} en inventario.");
                }
                else
                {
                    Console.WriteLine("No hay suficiente cantidad o el producto no existe.");
                }
            }
            else if (opcion == "3")
            {
                Console.WriteLine("Resumen del inventario:");
                foreach (var producto in inventario)
                {
                    string nombre = producto.Key;
                    decimal precio = producto.Value["Precio"];
                    decimal cantidad = producto.Value["Cantidad"];
                    decimal valorTotal = precio * cantidad;
                    Console.WriteLine($"{nombre}: Precio - {precio:C}, Cantidad - {cantidad}, Valor Total - {valorTotal:C}");
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
