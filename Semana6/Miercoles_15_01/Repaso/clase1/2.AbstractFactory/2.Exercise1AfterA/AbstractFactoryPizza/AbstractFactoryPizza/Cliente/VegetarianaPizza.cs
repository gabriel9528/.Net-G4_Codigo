using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Abstract.FabricaAbstracta;

namespace Abstract.PizzaModel
{
    internal class VegetarianaPizza : Pizza
    {
        IPizzaIngredientesFactory _ingredientFactory;
        public VegetarianaPizza(IPizzaIngredientesFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Prepararando: {Nombre}");
            Masa = _ingredientFactory.CrearMasa();
            Queso = _ingredientFactory.CrearQueso();
            Salsas = _ingredientFactory.CrearSalsas();
            Verduras = _ingredientFactory.CrearVerduras();
        }
    }
}
