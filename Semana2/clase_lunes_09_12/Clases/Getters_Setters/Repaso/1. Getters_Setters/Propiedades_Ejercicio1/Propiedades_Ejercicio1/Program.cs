using System;

public class Producto
{
    private string nombre;
    private decimal precio;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public decimal Precio
    {
        get { return precio; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("El precio no puede ser negativo. Se establecerá en 0.");
                precio = 0;
            }
            else
            {
                precio = value;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Producto producto = new Producto();

        Console.Write("Ingrese el nombre del producto: ");
        producto.Nombre = Console.ReadLine();

        Console.Write("Ingrese el precio del producto: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal precio))
        {
            producto.Precio = precio;
        }
        else
        {
            Console.WriteLine("Entrada inválida. Se establecerá el precio en 0.");
            producto.Precio = 0;
        }

        Console.WriteLine($"Producto: {producto.Nombre}, Precio: {producto.Precio:C}");
    }
}
