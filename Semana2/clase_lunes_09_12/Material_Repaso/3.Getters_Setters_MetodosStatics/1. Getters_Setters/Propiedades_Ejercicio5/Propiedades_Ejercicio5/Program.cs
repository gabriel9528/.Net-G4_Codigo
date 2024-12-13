using System;

public class ProductoInventario
{
    private string nombre;
    private int stockActual;
    private int stockMinimo;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int StockActual
    {
        get { return stockActual; }
        set
        {
            stockActual = value;
            if (stockActual < StockMinimo)
            {
                Console.WriteLine($"Advertencia: El stock de {Nombre} está por debajo del mínimo.");
            }
        }
    }

    public int StockMinimo
    {
        get { return stockMinimo; }
        set { stockMinimo = value; }
    }
}

class Program
{
    static void Main()
    {
        ProductoInventario producto = new ProductoInventario();

        Console.Write("Ingrese el nombre del producto: ");
        producto.Nombre = Console.ReadLine();

        Console.Write("Ingrese el stock mínimo: ");
        if (int.TryParse(Console.ReadLine(), out int stockMinimo))
        {
            producto.StockMinimo = stockMinimo;
        }
        else
        {
            Console.WriteLine("Entrada inválida para el stock mínimo. Se establecerá en 0.");
            producto.StockMinimo = 0;
        }

        Console.Write("Ingrese el stock actual: ");
        if (int.TryParse(Console.ReadLine(), out int stockActual))
        {
            producto.StockActual = stockActual;
        }
        else
        {
            Console.WriteLine("Entrada inválida para el stock actual. Se establecerá en 0.");
            producto.StockActual = 0;
        }

        Console.WriteLine($"Producto: {producto.Nombre}, Stock Actual: {producto.StockActual}, Stock Mínimo: {producto.StockMinimo}");
    }
}
