using System;

public static class CalculadoraImpuestos
{
    // Tasa de impuesto (18%)
    private static readonly decimal tasaImpuesto = 0.18m;

    // Método estático para calcular el impuesto sobre un precio
    public static decimal CalcularImpuesto(decimal precio)
    {
        return precio * tasaImpuesto;
    }

    // Método estático para calcular el precio total con impuesto
    public static decimal MostrarPrecioConImpuesto(decimal precio)
    {
        decimal impuesto = CalcularImpuesto(precio);
        return precio + impuesto;
    }
}

class Program
{
    static void Main()
    {
        // Definir variables para los precios de los productos
        decimal precioProducto1, precioProducto2, precioProducto3;

        // Solicitar al usuario que ingrese los precios
        Console.WriteLine("Ingrese el precio del producto 1: ");
        while (!decimal.TryParse(Console.ReadLine(), out precioProducto1))
        {
            Console.WriteLine("Por favor, ingrese un precio válido para el producto 1.");
        }

        Console.WriteLine("Ingrese el precio del producto 2: ");
        while (!decimal.TryParse(Console.ReadLine(), out precioProducto2))
        {
            Console.WriteLine("Por favor, ingrese un precio válido para el producto 2.");
        }

        Console.WriteLine("Ingrese el precio del producto 3: ");
        while (!decimal.TryParse(Console.ReadLine(), out precioProducto3))
        {
            Console.WriteLine("Por favor, ingrese un precio válido para el producto 3.");
        }

        // Mostrar resultados usando la clase estática
        Console.WriteLine($"\nPrecio del producto 1: {precioProducto1:C}");
        Console.WriteLine($"Impuesto sobre el producto 1: {CalculadoraImpuestos.CalcularImpuesto(precioProducto1):C}");
        Console.WriteLine($"Precio total del producto 1 con impuesto: {CalculadoraImpuestos.MostrarPrecioConImpuesto(precioProducto1):C}");

        Console.WriteLine("\n");

        Console.WriteLine($"Precio del producto 2: {precioProducto2:C}");
        Console.WriteLine($"Impuesto sobre el producto 2: {CalculadoraImpuestos.CalcularImpuesto(precioProducto2):C}");
        Console.WriteLine($"Precio total del producto 2 con impuesto: {CalculadoraImpuestos.MostrarPrecioConImpuesto(precioProducto2):C}");

        Console.WriteLine("\n");

        Console.WriteLine($"Precio del producto 3: {precioProducto3:C}");
        Console.WriteLine($"Impuesto sobre el producto 3: {CalculadoraImpuestos.CalcularImpuesto(precioProducto3):C}");
        Console.WriteLine($"Precio total del producto 3 con impuesto: {CalculadoraImpuestos.MostrarPrecioConImpuesto(precioProducto3):C}");
    }
}
