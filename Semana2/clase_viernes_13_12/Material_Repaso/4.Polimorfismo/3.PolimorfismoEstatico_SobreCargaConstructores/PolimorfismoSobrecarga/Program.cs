
using System;

namespace PolimorfismoSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de la clase Casa utilizando diferentes constructores
            Casa casa1 = new Casa("Casa de campo", 100000);
            Casa casa2 = new Casa("Casa moderna", 150000, 500, 300);
            Casa casa3 = new Casa();

            // Definir propiedades para casa3 manualmente
            casa3.tipo = "Casa tradicional";
            casa3.precio = 120000;
            casa3.areaTerreno = 600;
            casa3.areaConstruida = 350;

            // Utilizar el método vender sin parámetros
            casa1.vender();

            // Utilizar el método vender con un parámetro de tipo string
            casa2.vender("Juan Pérez");

            // Utilizar el método vender con un parámetro de tipo double (descuento)
            casa3.vender(5000);

            // Mantener la consola abierta para visualizar la salida
            Console.ReadKey();
        }
    }
}
