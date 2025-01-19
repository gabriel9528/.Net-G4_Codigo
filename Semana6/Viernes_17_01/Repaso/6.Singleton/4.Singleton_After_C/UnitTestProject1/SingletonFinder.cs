using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Before
{
    public class SingletonFinder
    {
        //La interfaz ISingletonContainer y su implementación permiten delegar la responsabilidad
        //de obtener las poblaciones a otra clase. Esto cumple con el principio de Inversión de
        //Dependencias del SOLID.

        //Gracias a la inyección de dependencias, puedes pasar un objeto mock o stub de la interfaz
        //ISingletonContainer durante las pruebas.
        //Un mock es una implementación simulada que devuelve valores predefinidos.Esto permite
        //probar tu lógica en SingletonFinder sin depender de una base de datos real.
        private ISingletonContainer _singletonContainer;

        public SingletonFinder(ISingletonContainer singletonContainer)
        {
            _singletonContainer = singletonContainer;
        }
        public int GetTotalPopulation(IEnumerable<string> listCapitals)
        {
            int total = 0;
            foreach(var poblacion in listCapitals)
            {
                total += _singletonContainer.GetPopulation(poblacion);
            }
            return total;
        }
    }
}
