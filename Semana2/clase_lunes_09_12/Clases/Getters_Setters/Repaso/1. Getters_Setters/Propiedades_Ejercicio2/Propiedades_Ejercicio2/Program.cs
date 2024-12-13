using System;

public class Alumno
{
    private string nombre;
    private decimal promedio;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public decimal Promedio
    {
        get { return promedio; }
        set
        {
            if (value < 0 || value > 20)
            {
                Console.WriteLine("El promedio debe estar entre 0 y 20. Se establecerá en 0.");
                promedio = 0;
            }
            else
            {
                promedio = value;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Alumno alumno = new Alumno();

        Console.Write("Ingrese el nombre del alumno: ");
        alumno.Nombre = Console.ReadLine();

        Console.Write("Ingrese el promedio del alumno (0-20): ");
        if (decimal.TryParse(Console.ReadLine(), out decimal promedio))
        {
            alumno.Promedio = promedio;
        }
        else
        {
            Console.WriteLine("Entrada inválida. Se establecerá el promedio en 0.");
            alumno.Promedio = 0;
        }

        Console.WriteLine($"Alumno: {alumno.Nombre}, Promedio: {alumno.Promedio}");
    }
}
