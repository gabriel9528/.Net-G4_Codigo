using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettesrSetters_Ejercicio1
{
    public class Producto
    {
        //Atributos o campos
        private string nombre;
        private decimal precio;

        //Propiedad -> Nombre
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        //Propiedad -> Precio

        public decimal Precio
        {
            get { return precio; }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("El precio no puede ser negativo");
                    precio = 0;
                }
                else
                {
                    precio = value;
                }
            }
        }

    }
}
