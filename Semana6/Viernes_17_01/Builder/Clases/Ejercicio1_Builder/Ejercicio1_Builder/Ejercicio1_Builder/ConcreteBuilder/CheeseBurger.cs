using Ejercicio1_Builder.Builder;
using Ejercicio1_Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Builder.ConcreteBuilder
{
    public class CheeseBurger : SandwichBuilder
    {
        protected Sandwich _sandwich = new Sandwich();
        public override void AddCondimentos()
        {
            _sandwich.Condimentos = "Ketchup, Mostaza"; 
        }

        public override void AddPan()
        {
            _sandwich.Pan = "Pan de hamburguesa";
        }

        public override void AddProteina()
        {
            _sandwich.Proteinas = "carne de hamburguesa";
        }

        public override void AddQueso()
        {
            _sandwich.Queso = "Queso Cheddar";
        }

        public override void AddVegetales()
        {
            _sandwich.Verduras = "Lechuga, tomate";
        }

        public override Sandwich GetSandwich()
        {
            return _sandwich;
        }
    }
}
