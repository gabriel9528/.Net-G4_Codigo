//Desarrollar una aplicación para una tienda en línea que vende productos electrónicos.
//Necesitas crear una clase Producto que represente cada producto en el inventario de la tienda.
//Cada producto tiene las siguientes propiedades:

//Id: un identificador único para el producto.
//Nombre: el nombre del producto.
//Precio: el precio del producto.
//Stock: la cantidad de unidades disponibles en el inventario.
//Además, necesitas implementar lo siguiente:

//Un método estático llamado CalcularTotalVentas que tome una lista de productos vendidos y
//devuelva el total de ventas multiplicando el precio de cada producto por la cantidad vendida.

//Un método de instancia llamado RestarStock que acepte una cantidad vendida como parámetro y
//actualice el stock del producto restando esta cantidad.

//Escribe la clase Producto con todas estas características y proporciona un ejemplo de uso en
//el que crees varios objetos Producto, realices ventas y calcules el total de ventas.

using Ejercicio_con_Clases3;

class Program
{
    static void Main(string[] args)
    {
        // Crear una lista de productos
        List<Producto> productos = new List<Producto>
        {
            new ProductoElectronico(1, "Laptop", 1200, 10),
            new ProductoElectronico(2, "Teléfono", 800, 20),
            new ProductoElectronico(3, "Auriculares", 50, 30)
        };

        // Mostrar el valor total individual para cada producto usando el método sobrescrito
        Console.WriteLine("Valor total individual de cada producto:");
        foreach (var producto in productos)
        {
            Console.WriteLine($"Producto: {producto.Nombre}, Valor Total: ${producto.CalcularValorTotal()}");
        }

        // Calcular el valor total de todos los productos usando el método estático
        decimal total = Producto.CalcularValorTotal(productos);
        Console.WriteLine($"\nValor Total de todos los productos: ${total}");
    }
}
