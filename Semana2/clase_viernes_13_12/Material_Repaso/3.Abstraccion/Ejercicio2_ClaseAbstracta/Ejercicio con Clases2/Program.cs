using Ejercicio_con_Clases2;

namespace Ejercicio_con_Clases2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lista de empleados
            List<Empleado> empleados = new List<Empleado>
            {
                new EmpleadoPermanente { Nombre = "Juan", Edad = 30, SalarioMensual = 2500 },
                new EmpleadoPorHoras { Nombre = "María", Edad = 25, PagoPorHora = 20, HorasTrabajadasPorMes = 160 }
            };

            // Mostrar información y calcular el salario anual de cada empleado
            foreach (var empleado in empleados)
            {
                Console.WriteLine(empleado.ToString());
                Console.WriteLine($"Salario Anual: {empleado.CalcularSalarioAnual()}");
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
