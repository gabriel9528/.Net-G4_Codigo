using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPizza.ProductoAbstracto
{
    public class Pizza
    {
        public string Nombre { get; set; }
        protected string Masa;
        protected string Salsas;
        protected List<string> Extras = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"Prepararando: {Nombre}");
            Console.WriteLine($"Colocando masa: {Masa}");
            Console.WriteLine($"Agregando salsa: {Salsas}");
            Console.WriteLine($"Agregando Capas: {string.Join(",", Extras)}");

        }
        public void Cocinar() => Console.WriteLine($"Cocinar por 20 min");
        public void Cortar() => Console.WriteLine($"Pizza fue cortada en partes iguales");
        public void Encajar() => Console.WriteLine($"Pizza colocada en caja oficial");

    }
}
