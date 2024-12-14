using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo2
{
    public class PaqueteNormal : Paquete
    {
        public string Tamaño { get; set; }
        public bool Fragilidad { get; set; }

        public PaqueteNormal(double peso, string destino, string tamaño, bool fragilidad)
            : base(peso, destino)
        {
            Tamaño = tamaño;
            Fragilidad = fragilidad;
        }

        public override double CalcularCostoEnvio()
        {
            double costoBase = base.CalcularCostoEnvio();

            // Calculamos el costo de envío específico para un paquete normal
            double costoAdicional = 0;

            if (Tamaño == "Grande")
            {
                costoAdicional += 5;
            }

            if (Fragilidad)
            {
                costoAdicional += 10;
            }

            return costoBase + costoAdicional;
        }
    }

}
