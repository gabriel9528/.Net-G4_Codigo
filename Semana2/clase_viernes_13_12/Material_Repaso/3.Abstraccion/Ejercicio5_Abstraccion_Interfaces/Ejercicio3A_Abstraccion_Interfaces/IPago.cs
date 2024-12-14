using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3A_Abstraccion_Interfaces
{
    public interface IPago
    {
        void ProcesarPago(double monto);
        string VerificarEstado();
        string ObtenerDetalles();
    }
}
