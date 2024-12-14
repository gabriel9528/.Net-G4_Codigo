using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoEsttico_3
{
    internal class Casa
    {
        public string Tipo { get; set; }
        public double Precio { get; set; }
        public double AreaTerreno { get; set; }
        public double AreaConstruida { get; set; }

        //Constructores
        public Casa()
        {
        }

        public Casa(string tipo, double precio)
        {
            Tipo = tipo;
            Precio = precio;
        }

        public Casa(string tipo, double precio, double areaTerreno, double areaConstruida)
        {
            Tipo = tipo;
            Precio = precio;
            AreaTerreno = areaTerreno;
            AreaConstruida = areaConstruida;
        }

        //Sobrecarga de metodos


        public void Vender()
        {
            Console.WriteLine($"{Tipo} vendida al precio de {Precio}");
        }

        public void Vender(string cliente)
        {
            Console.WriteLine($"{Tipo} vendida al precio de {Precio}, al cliente {cliente}");
        }

        public void Vender(string cliente, double descuento)
        {
            Console.WriteLine($"{Tipo} vendida al precio de {Precio}, al cliente {cliente}, con un descuento de: {descuento}");
        }

    }
}
