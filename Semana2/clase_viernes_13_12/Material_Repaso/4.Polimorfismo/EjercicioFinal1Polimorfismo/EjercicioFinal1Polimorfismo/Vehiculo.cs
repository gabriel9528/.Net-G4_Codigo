using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFinal1Polimorfismo
{
    public abstract class Vehiculo
    {
        public string Matricula { get; set; }
        public string Modelo { get; set; }
        public double TarifaDiaria { get; set; }

        public Vehiculo(string matricula, string modelo, double tarifaDiaria)
        {
            Matricula = matricula;
            Modelo = modelo;
            TarifaDiaria = tarifaDiaria;
        }

        public abstract double CalcularTarifa();
    }

}
