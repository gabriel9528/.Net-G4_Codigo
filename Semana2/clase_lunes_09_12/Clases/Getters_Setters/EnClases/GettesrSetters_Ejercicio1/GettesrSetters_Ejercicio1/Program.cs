using GettesrSetters_Ejercicio1;

class Program
{
    static void Main(string[] args)
    {
        Producto productoPruebita = new Producto();

        Console.WriteLine("Ingrese el nombre del prodcuto: ");
        productoPruebita.Nombre = Console.ReadLine();

        Console.WriteLine("Ingrese el precio del producto: ");
        if(decimal.TryParse(Console.ReadLine(), out decimal precioEntrada))
        {
            productoPruebita.Precio = precioEntrada;
        }
        else
        {
            Console.WriteLine("Ingrese un precio valido para el prducto ");
            productoPruebita.Precio = 0;
        }

        Console.WriteLine($"Producto: {productoPruebita.Nombre} -> {productoPruebita.Precio}");
    }
}