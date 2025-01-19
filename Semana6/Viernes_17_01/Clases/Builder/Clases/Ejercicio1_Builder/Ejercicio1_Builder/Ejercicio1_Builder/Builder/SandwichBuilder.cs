using Ejercicio1_Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Builder.Builder
{
    public abstract class SandwichBuilder
    {
        public abstract void AddPan();
        public abstract void AddProteina();
        public abstract void AddQueso();
        public abstract void AddVegetales();
        public abstract void AddCondimentos();


        public abstract Sandwich GetSandwich();
    }
}
