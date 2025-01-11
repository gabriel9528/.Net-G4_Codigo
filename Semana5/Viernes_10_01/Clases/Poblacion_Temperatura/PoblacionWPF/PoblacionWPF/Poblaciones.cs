using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoblacionWPF
{
    public class Poblaciones
    {
        public string Poblacion1 {  get; set; }
        public string Poblacion2 {  get; set; }
        public int Temperatura1 {  get; set; }
        public int Temperatura2 {  get; set; }
        public int DiferenciaTemperatura
        {
            get { return Math.Abs(Temperatura1 - Temperatura2);  }
        }
    }
}
