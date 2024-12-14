using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_con_Clases3
{
    public abstract class Producto
    {
        public int Id { get; }
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

        // Método abstracto para comportamientos específicos (individual)
        public abstract decimal CalcularValorTotal();

        // Método estático para calcular el total de una lista
        public static decimal CalcularValorTotal(List<Producto> productos)
        {
            decimal total = 0;
            foreach (var producto in productos)
            {
                total += producto.CalcularValorTotal(); // Llama al método individual
            }
            return total;
        }

        public void RestarStock(int cantidadVendida)
        {
            if (cantidadVendida <= Stock)
            {
                Stock -= cantidadVendida;
            }
            else
            {
                throw new InvalidOperationException("No hay suficiente stock para realizar la venta.");
            }
        }
    }
}
