using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AbstractFactoryPizza.ProductoAbstracto;

namespace AbstractFactoryPizza.ProductoConcreto.Arequipa
{
    internal class ArequipaPepperoniPizza : Pizza
    {
        public ArequipaPepperoniPizza()
        {
            Nombre = "Peperoni";
            Masa = "delgada";
            Salsas = "Salsa de tomates";
            Extras.Add("Quesso mozarella");
        }
    }
}
