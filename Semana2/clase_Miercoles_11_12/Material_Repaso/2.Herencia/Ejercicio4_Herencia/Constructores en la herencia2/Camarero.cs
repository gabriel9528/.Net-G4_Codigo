using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores_en_la_herencia2
{
    public class Camarero : Empleado
    {
        public int MesasAtendidas { get; set; }
        public string NivelExperiencia { get; set; }

        public Camarero(string nombre, int edad, decimal salario, int mesasAtendidas, string nivelExperiencia)
            : base(nombre, edad, salario)
        {
            MesasAtendidas = mesasAtendidas;
            NivelExperiencia = nivelExperiencia;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Mesas atendidas: " + MesasAtendidas);
            Console.WriteLine("Nivel de experiencia: " + NivelExperiencia);
        }
    }
}
