using AbstractFactoryPizza.FabricaAbstracta;
using AbstractFactoryPizza.ProductoAbstracto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPizza.Cliente
{
    internal class NapolitanaPizza : Pizza
    {
        private readonly IMasa _masa;
        private readonly ISalsas _salsas;
        private readonly IQueso _queso;
        private readonly List<IVerduras> _verduras;

        public NapolitanaPizza(IPizzaIngredientesFactory factory)
        {
            _masa = factory.CrearMasa();
            _salsas = factory.CrearSalsas();
            _verduras = factory.CrearVerduras();
            _queso = factory.CrearQueso();
        }

        public void Preparar()
        {
            Console.WriteLine($"Preparando: {Nombre}");
            _masa.MasaDelgada();
            _queso.QuesoParmesano();
            _salsas.SalsaMarinada();
        }

    }
}
