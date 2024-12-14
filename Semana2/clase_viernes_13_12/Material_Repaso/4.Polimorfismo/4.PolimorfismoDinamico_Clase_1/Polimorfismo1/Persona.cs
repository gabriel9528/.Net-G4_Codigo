using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo1
{
    public abstract class Persona
    {
        public string Nombre { get; set; }

        public abstract string Saludar();
    }
}
