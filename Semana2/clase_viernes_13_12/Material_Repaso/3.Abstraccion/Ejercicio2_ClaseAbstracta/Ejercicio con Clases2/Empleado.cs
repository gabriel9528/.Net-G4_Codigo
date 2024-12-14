
namespace Ejercicio_con_Clases2
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public abstract decimal CalcularSalarioAnual(); // Método abstracto para calcular el salario anual

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Edad: {Edad}";
        }
    }
}




