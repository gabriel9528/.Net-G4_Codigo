using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Polimorfismo2
{
    public class Paquete
    {
        public double Peso { get; set; }
        public string Destino { get; set; }

        public Paquete(double peso, string destino)
        {
            Peso = peso;
            Destino = destino;
        }

        public virtual double CalcularCostoEnvio()
        {
            return 10; // Costo base de envío
        }
    }
}
