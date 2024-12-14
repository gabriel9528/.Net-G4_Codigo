using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_con_Clases3
{
    public class ProductoElectronico : Producto
    {
        public ProductoElectronico(int id, string nombre, decimal precio, int stock)
            : base(id, nombre, precio, stock) { }

        // Implementación del método abstracto
        public override decimal CalcularValorTotal()
        {
            return Precio * Stock;
        }
    }

}
