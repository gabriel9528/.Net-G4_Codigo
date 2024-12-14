using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta_Ejercicio1
{
    public abstract class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }


        protected Producto(int id, string nombre, decimal precio, int stock)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public abstract decimal CalcularValorTotal();

        public static decimal CalcularValorTotal(List<Producto> productos)
        {
            decimal total = 0;
            foreach (Producto producto in productos)
            {
                total += producto.CalcularValorTotal();
            }

            return total;
        }

        public void RestarStock(int cantidadVendida)
        {
            if(cantidadVendida <= Stock)
            {
                Stock -= cantidadVendida;
            }
            else
            {
                throw new InvalidOperationException("No ahy suficiente stock para vender.");
            }
        }
    }
}
