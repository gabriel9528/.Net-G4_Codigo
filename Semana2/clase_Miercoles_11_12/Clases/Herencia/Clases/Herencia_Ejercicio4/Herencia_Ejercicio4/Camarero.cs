using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Ejercicio4
{
    internal class Camarero : Empleado
    {
        public int MesasAtendidas {  get; set; }
        public int NivelExperiencia { get; set; }
        public Camarero(string nombre, int edad, decimal salario, int mesasAtendidad, int nivelExperiencia) 
            : base(nombre, edad, salario)
        {
            MesasAtendidas = mesasAtendidad;
            NivelExperiencia = nivelExperiencia;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Mesas Atendidas: " + MesasAtendidas);
            Console.WriteLine("Nivel de Experiencia: " + NivelExperiencia);
        }
    }
}
