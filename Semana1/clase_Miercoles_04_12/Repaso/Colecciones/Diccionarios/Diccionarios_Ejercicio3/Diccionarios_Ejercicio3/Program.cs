using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Dictionary<string, string> empleados = new Dictionary<string, string>();

        while (true)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Agregar empleado y cargo");
            Console.WriteLine("2. Listar empleados y cargos");
            Console.WriteLine("3. Contar empleados por cargo");
            Console.WriteLine("4. Salir");

            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("Ingrese el nombre del empleado: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese el cargo del empleado: ");
                string cargo = Console.ReadLine();

                empleados[nombre] = cargo;
                Console.WriteLine("Empleado agregado o actualizado.");
            }
            else if (opcion == "2")
            {
                Console.WriteLine("Lista de empleados y cargos:");
                foreach (var item in empleados)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            else if (opcion == "3")
            {
                var conteoPorCargo = empleados.Values.GroupBy(cargo => cargo)
                                                     .ToDictionary(grupo => grupo.Key, grupo => grupo.Count());

                Console.WriteLine("Cantidad de empleados por cargo:");
                foreach (var item in conteoPorCargo)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
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
