using Ejercicio1_Builder.Builder;
using Ejercicio1_Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Builder.Director
{
    public class SandwichAssembly
    {
        private SandwichBuilder _sandwichBuilder;

        public void SetBuilder(SandwichBuilder builder)
        {
            _sandwichBuilder = builder;
        }

        public void Assembly()
        {
            _sandwichBuilder.AddPan();
            _sandwichBuilder.AddQueso();
            _sandwichBuilder.AddVegetales();
            _sandwichBuilder.AddCondimentos();
        }

        public Sandwich GetSandwich()
        {
            return _sandwichBuilder.GetSandwich();
        }
    }
}
