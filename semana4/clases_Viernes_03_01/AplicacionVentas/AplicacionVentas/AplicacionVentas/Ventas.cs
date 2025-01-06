using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionVentas
{
    public class Ventas
    {
        private string _producto;
        private int _cantidad;

        public string Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        //Asignar el precio de los productos
        public double AsignarPrecio()
        {
            switch (Producto)
            {
                case "Celular": return 1000;
                case "Laptop": return 3000;
                case "Monitor": return 500;
                case "Televisor": return 1500;
                case "Lavadora": return 2000;
            }

            return 0;
        }

        //Calcular el subtotal -> precio * cantidad
        public double CalcularSubTotal()
        {
            return AsignarPrecio() * Cantidad;
        }

        //Calcular el descuento
        public double CalcularDescuento()
        {
            double subtotal = CalcularSubTotal();

            if (subtotal <= 1000) return (5.0 / 100) * subtotal;
            else if (subtotal > 1000 && subtotal <= 3000) return (10.0 / 100) * subtotal;
            else return (20.0/100) * subtotal;

        }

        //Calcular el total
        public double CalcularNeto()
        {
            return CalcularSubTotal() - CalcularDescuento();
        }


    }
}
