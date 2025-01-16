using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Abstract.FabricaAbstracta;
using Abstract.ProductoAbstracto.Interfaces;

namespace Abstract.PizzaModel
{
    //internal class NapolitanaPizza : Pizza
    //{
    //    IPizzaIngredientesFactory _ingredientFactory;
    //    public NapolitanaPizza(IPizzaIngredientesFactory ingredientFactory)
    //    {
    //        _ingredientFactory = ingredientFactory;
    //    }

    //    public override void Prepare()
    //    {
    //        Console.WriteLine($"Prepararando: {Nombre}");
    //        Masa = _ingredientFactory.CrearMasa();
    //        Queso = _ingredientFactory.CrearQueso();
    //        Salsas = _ingredientFactory.CrearSalsas();
    //        Verduras = _ingredientFactory.CrearVerduras();
    //    }
    //}


    //o podria ser asi


    internal class NapolitanaPizza : Pizza
    {
        private readonly IMasa _masa;
        private readonly ISalsas _salsas;
        private readonly IQueso _queso;
        private readonly List<IVerduras> _verduras;
        public NapolitanaPizza(IPizzaIngredientesFactory ingredientFactory)
        {
            _masa = ingredientFactory.CrearMasa();
            _salsas = ingredientFactory.CrearSalsas();
            _queso = ingredientFactory.CrearQueso();
            _verduras = ingredientFactory.CrearVerduras();
        }

        public override void Prepare()
        {
            Console.WriteLine($"Prepararando: {Nombre}");
            _masa.MasaDelgada();
            _queso.QuesoParmesano();
            _salsas.SalsaMarinada();

        }
    }
}
