using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ejercicio5
{
    internal interface IPago
    {
        void ProcesarPago(double monto);
        void VerificarEstado();
        string ObtenerDetalles();
    }
}
