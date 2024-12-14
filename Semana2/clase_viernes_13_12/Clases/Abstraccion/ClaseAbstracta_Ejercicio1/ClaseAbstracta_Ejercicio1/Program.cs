using ClaseAbstracta_Ejercicio1;

class Program
{
    static void Main(string[] args)
    {
        List<Producto> productos = new List<Producto>()
        {
            new ProductoElectronico(1, "Laptop", 3000, 5),
            new ProductoElectronico(2, "Celular", 2000, 10),
            new ProductoElectronico(3, "Auriculares", 200, 20),

        };

        Console.WriteLine("Valor individual de cada producto");

        foreach (Producto producto in productos)
        {
            Console.WriteLine($"Producto: {producto.Nombre}, valor total: {producto.CalcularValorTotal()}");
        }

        decimal total = Producto.CalcularValorTotal(productos);
        Console.WriteLine($"\nEl valor total es: {total}");

    }
}