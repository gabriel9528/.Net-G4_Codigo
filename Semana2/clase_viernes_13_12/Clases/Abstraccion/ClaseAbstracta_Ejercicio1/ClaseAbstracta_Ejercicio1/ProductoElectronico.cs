using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta_Ejercicio1
{
    internal class ProductoElectronico : Producto
    {
        public ProductoElectronico(int id, string nombre, decimal precio, int stock) 
            : base(id, nombre, precio, stock)
        {
        }

        //Implementar nuestro metodo estatico
        public override decimal CalcularValorTotal()
        {
            return Precio * Stock;
        }
    }
}
