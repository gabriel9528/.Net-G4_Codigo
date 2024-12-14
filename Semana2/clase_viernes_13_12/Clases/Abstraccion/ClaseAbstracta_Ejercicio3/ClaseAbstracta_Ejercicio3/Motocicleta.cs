using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta_Ejercicio3
{
    internal class Motocicleta : Vehiculo
    {
        public string Casco {  get; set; }
        public Motocicleta(string marca, string modelo, string casco) : base(marca, modelo)
        {
            Casco = casco;
        }

        public override void Detener()
        {
            Console.WriteLine($"El Motocicleta de marca {Marca}, {Modelo} y casco: {Casco} se detuvo");
        }

        public override void Iniciar()
        {
            Console.WriteLine($"El Motocicleta de marca {Marca}, {Modelo} y casco: {Casco} ha iniciado su marcha");
        }

        public override void ObtenerDetalles()
        {
            Console.WriteLine($"Motocicleta de marca {Marca}, {Modelo} y casco: {Casco}");
        }
    }
}
