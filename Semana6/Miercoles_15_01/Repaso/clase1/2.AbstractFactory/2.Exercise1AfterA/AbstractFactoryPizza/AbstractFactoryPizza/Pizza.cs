using Abstract.ProductoAbstracto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Pizza
    {
        public string Nombre { get; set; }
        protected IMasa Masa;
        protected ISalsas Salsas;
        protected IQueso Queso;
        protected List<IVerduras> Verduras = new List<IVerduras>();

        public abstract void Prepare();

        public void Cocinar() => Console.WriteLine($"Cocinar por 20 min");
        public void Cortar() => Console.WriteLine($"Pizza fue cortada en partes iguales");
        public void Encajar() => Console.WriteLine($"Pizza colocada en caja oficial");

    }
}
