using System;

namespace PolimorfismoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polimorfismo dinámico: todas las instancias son tratadas como Inmueble
            Inmueble[] inmuebles = {
                new Casa("Casa de campo", 59954),
                new Departamento("Departamento duplex", 95454),
                new Terreno("Terreno amplio", 9545555)
            };

            // Llamada al método vender: se ejecuta el método adecuado dependiendo del tipo real del objeto
            foreach (Inmueble inmueble in inmuebles)
            {
                inmueble.vender();
            }

            Console.ReadKey();
        }
    }
}
