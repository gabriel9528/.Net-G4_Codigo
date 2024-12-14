using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Un banco tiene 3 clientes que pueden hacer depósitos y extracciones.
//También el banco requiere que al final del día calcule la cantidad de dinero que hay depositada.
namespace Ejercicio_con_Clases
{
    public class Banco
    {
        private Cliente yhonas, ana, pedro;

        public Banco()
        {
            yhonas = new Cliente("Yhonas");
            ana = new Cliente("Ana");
            pedro = new Cliente("Pedro");
        }

        public void Operar()
        {
            yhonas.Depositar(100);
            ana.Depositar(150);
            pedro.Depositar(200);
            pedro.Extraer(150);
        }

        public void DepositosTotales()
        {
            int totalBanco = yhonas.RetornarMonto() + ana.RetornarMonto() + pedro.RetornarMonto();

            Console.WriteLine("El total de dinero en el banco es:" + totalBanco);

            yhonas.Imprimir();
            ana.Imprimir();
            pedro.Imprimir();
        }
    }
}
