using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo2
{
    public class PaqueteExpress : Paquete
    {
        public bool Urgencia { get; set; }
        public bool Seguro { get; set; }

        public PaqueteExpress(double peso, string destino, bool urgencia, bool seguro)
            : base(peso, destino)
        {
            Urgencia = urgencia;
            Seguro = seguro;
        }

        public override double CalcularCostoEnvio()
        {
            double costoBase = base.CalcularCostoEnvio();

            // Calculamos el costo de envío específico para un paquete express
            double costoAdicional = 0;

            if (Urgencia)
            {
                costoAdicional += 20;
            }

            if (Seguro)
            {
                costoAdicional += 15;
            }

            return costoBase + costoAdicional;
        }
    }

}
