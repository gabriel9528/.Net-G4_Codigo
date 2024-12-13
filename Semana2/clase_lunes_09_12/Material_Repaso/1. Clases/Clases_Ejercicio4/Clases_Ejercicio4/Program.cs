using System;

public class Empleado
{
    public string Nombre { get; set; }
    public decimal SalarioBase { get; set; }
    public int AñosDeExperiencia { get; set; }

    public decimal CalcularSalario()
    {
        decimal bono = Math.Min(AñosDeExperiencia * 0.05m, 0.20m);
        return SalarioBase * (1 + bono);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Solicitar el nombre del empleado
        Console.Write("Ingrese el nombre del empleado: ");
        string nombre = Console.ReadLine();

        // Solicitar el salario base
        Console.Write("Ingrese el salario base del empleado: ");
        decimal salarioBase;
        while (!decimal.TryParse(Console.ReadLine(), out salarioBase) || salarioBase <= 0)
        {
            Console.Write("Por favor, ingrese un salario base válido (mayor a 0): ");
        }

        // Solicitar los años de experiencia
        Console.Write("Ingrese los años de experiencia del empleado: ");
        int añosDeExperiencia;
        while (!int.TryParse(Console.ReadLine(), out añosDeExperiencia) || añosDeExperiencia < 0)
        {
            Console.Write("Por favor, ingrese una cantidad válida de años de experiencia (mayor o igual a 0): ");
        }

        // Crear la instancia del empleado
        Empleado empleado = new Empleado
        {
            Nombre = nombre,
            SalarioBase = salarioBase,
            AñosDeExperiencia = añosDeExperiencia
        };

        // Calcular y mostrar el salario total
        Console.WriteLine($"Salario total de {empleado.Nombre}: {empleado.CalcularSalario():C}");
    }
}
