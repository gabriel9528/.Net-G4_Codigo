using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_con_Clases1
{
    public class JuegoDeDados
    {
        // Propiedades de navegación
        private Dado dado1, dado2, dado3;

        public JuegoDeDados()
        {
            dado1 = new Dado();
            dado2 = new Dado();
            dado3 = new Dado();
        }

        public void Jugar()
        {
            Console.WriteLine("Presiona cualquier tecla para tirar el primer dado...");
            Console.ReadKey();
            dado1.Tirar();
            dado1.Imprimir();

            Console.WriteLine("Presiona cualquier tecla para tirar el segundo dado...");
            Console.ReadKey();
            dado2.Tirar();
            dado2.Imprimir();

            Console.WriteLine("Presiona cualquier tecla para tirar el tercer dado...");
            Console.ReadKey();
            dado3.Tirar();
            dado3.Imprimir();

            // Comprobación de si ganó o perdió
            if (dado1.RetornarValor() == dado2.RetornarValor() &&
                dado1.RetornarValor() == dado3.RetornarValor())
            {
                Console.WriteLine("¡Ganaste!");
            }
            else
            {
                Console.WriteLine("Perdiste");
            }
        }
    }
}
