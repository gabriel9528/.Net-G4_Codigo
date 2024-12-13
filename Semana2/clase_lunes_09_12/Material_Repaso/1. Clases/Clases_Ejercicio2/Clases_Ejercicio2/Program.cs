public class Producto
{
    // Propiedades
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Cantidad { get; set; }

    // Método para calcular el total
    public decimal CalcularTotal()
    {
        return Precio * Cantidad;
    }

    // Método para mostrar el producto
    public void MostrarProducto()
    {
        Console.WriteLine($"Producto: {Nombre}, Total: {CalcularTotal():C}");
    }
}

// Uso de la clase Producto
public class Program
{
    public static void Main(string[] args)
    {
        Producto producto = new Producto();
        producto.Nombre = "Laptop";
        producto.Precio = 800m;
        producto.Cantidad = 2;
        producto.MostrarProducto(); // Salida: Producto: Laptop, Total: $1600.00
    }
}
