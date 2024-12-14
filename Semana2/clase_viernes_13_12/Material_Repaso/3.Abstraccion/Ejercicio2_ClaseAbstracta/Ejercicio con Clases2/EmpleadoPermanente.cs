using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_con_Clases2
{
    public class EmpleadoPermanente : Empleado
    {
        public decimal SalarioMensual { get; set; }

        public override decimal CalcularSalarioAnual()
        {
            return SalarioMensual * 12;
        }

        public override string ToString()
        {
            return base.ToString() + $", Salario Mensual: {SalarioMensual}";
        }
    }
}
