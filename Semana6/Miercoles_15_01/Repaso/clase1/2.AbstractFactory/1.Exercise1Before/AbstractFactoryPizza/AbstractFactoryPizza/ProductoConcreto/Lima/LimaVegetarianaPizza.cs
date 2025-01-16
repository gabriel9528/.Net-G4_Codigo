using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AbstractFactoryPizza.ProductoAbstracto;

namespace AbstractFactoryPizza.ProductoConcreto.Lima
{
    internal class LimaVegetarianaPizza : Pizza
    {
        public LimaVegetarianaPizza()
        {
            Nombre = "Vegetariana";
            Masa = "delgada";
            Salsas = "Salsa de tomates";
            Extras.Add("Quesso mozarella");
        }
    }
}
