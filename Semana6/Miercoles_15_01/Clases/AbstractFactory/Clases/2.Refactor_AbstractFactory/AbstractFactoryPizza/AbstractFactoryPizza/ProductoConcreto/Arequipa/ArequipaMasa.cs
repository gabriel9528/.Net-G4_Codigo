﻿using AbstractFactoryPizza.ProductoAbstracto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPizza.ProductoConcreto.Arequipa
{
    internal class ArequipaMasa : IMasa
    {
        public void MasaDelgada()
        {
            Console.WriteLine("Agregando masa delgada - Arequipa " + Environment.NewLine);
        }
    }
}