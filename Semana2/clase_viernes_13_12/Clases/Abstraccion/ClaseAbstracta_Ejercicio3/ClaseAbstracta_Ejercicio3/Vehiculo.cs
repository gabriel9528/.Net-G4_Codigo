using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta_Ejercicio3
{
    internal abstract class Vehiculo
    {
        public string Marca {  get; set; }
        public string Modelo {  get; set; }

        public Vehiculo(string marca, string modelo) 
        {
            Marca = marca;
            Modelo = modelo;
        }

        public abstract void Iniciar();
        public abstract void Detener();
        public abstract void ObtenerDetalles();
    }
}
