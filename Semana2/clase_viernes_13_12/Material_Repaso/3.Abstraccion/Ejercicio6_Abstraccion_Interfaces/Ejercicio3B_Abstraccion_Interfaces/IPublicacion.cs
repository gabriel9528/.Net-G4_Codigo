using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3B_Abstraccion_Interfaces
{
    public interface IPublicacion
    {
        void Publicar();
        string ObtenerDetalles();
        string VerificarTipo();
    }
}
