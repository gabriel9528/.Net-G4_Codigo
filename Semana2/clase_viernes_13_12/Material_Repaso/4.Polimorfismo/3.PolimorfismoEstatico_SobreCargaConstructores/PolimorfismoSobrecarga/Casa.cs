using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoSobrecarga
{
    public class Casa
    {
        //Estados - Atributos
        public string tipo;
        public double precio;
        public double areaTerreno;
        public double areaConstruida;


        //Constructor
        public Casa()
        {
        }
        public Casa(string tipo, double precio)
        {
            this.tipo = tipo;
            this.precio = precio;
        }
        public Casa(string tipo, double precio, double areaTerreno, double areaConstruida)
        {
            this.tipo = tipo;
            this.precio = precio;
            this.areaTerreno = areaTerreno;
            this.areaConstruida = areaConstruida;
        }


        //Comportamientos - Métodos
        public void vender()
        {
            Console.WriteLine(
                tipo + " VENDIDA por el precio de " + precio
                );
        }
        public void vender(string cliente)
        {
            Console.WriteLine(
                tipo + " VENDIDA por el precio de " + precio + " por cliente: " + cliente
                );
        }
        public void vender(double descuento)
        {
            Console.WriteLine(
                tipo + " VENDIDA por el precio de " + precio + "con descuento: " + descuento
                );
        }
    }
}
