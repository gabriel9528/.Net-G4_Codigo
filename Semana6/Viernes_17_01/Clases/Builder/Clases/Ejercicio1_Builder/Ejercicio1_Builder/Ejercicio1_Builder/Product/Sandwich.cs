using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Builder.Product
{
    public class Sandwich
    {
        public string Pan {  get; set; }
        public string Verduras { get; set; }
        public string Proteinas { get; set; }
        public string Condimentos { get; set; }
        public string Queso { get; set; }


        public override string ToString()
        {
            return $"Sandwich: \n" +
                $"- Pan: {Pan}\n" +
                $"- Verduras: {Verduras}\n" +
                $"- Proteina: {Proteinas}\n" +
                $"- Condimentos: {Condimentos}\n" +
                $"- Queso: {Queso}\n";
        }

    }
}
