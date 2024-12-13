using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3
{
    public class Raices
    {
        // Atributos
        private double a;
        private double bb;
        private double cc;

        // Constructores
        //this se usa para referirse a la instancia actual de la clase en la que el código está siendo ejecutado.
        //Esto es útil para distinguir entre los parámetros del constructor y los campos (o propiedades) de la
        //clase que tienen el mismo nombre.
        public Raices(double a, double b, double c)
        {
            this.a = a;
            bb = b;
            cc = c;
        }

        // Propiedades
        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return bb; }
            set { bb = value; }
        }

        public double C
        {
            get { return cc; }
            set { cc = value; }
        }

        // Métodos públicos

        public void Calcular()
        {
            if (TieneRaices())
            {
                ObtenerDosRaices();
            }
            else if (TieneRaiz())
            {
                ObtenerUnicaRaiz();
            }
            else
            {
                Console.WriteLine("No tiene soluciones");
            }
        }

        // Métodos privados

        private double GetDiscriminante()
        {
            return Math.Pow(bb, 2) - (4 * a * cc);
        }

        private bool TieneRaices()
        {
            return GetDiscriminante() > 0;
        }

        private bool TieneRaiz()
        {
            return GetDiscriminante() == 0;
        }

        private void ObtenerDosRaices()
        {
            double x1 = (-bb + Math.Sqrt(GetDiscriminante())) / (2 * a);
            double x2 = (-bb - Math.Sqrt(GetDiscriminante())) / (2 * a);

            Console.WriteLine("Solucion X1:");
            Console.WriteLine(x1);
            Console.WriteLine("Solucion X2:");
            Console.WriteLine(x2);
        }

        private void ObtenerUnicaRaiz()
        {
            double x = (-bb) / (2 * a);

            Console.WriteLine("Unica solucion:");
            Console.WriteLine(x);
        }

        
    }
}
