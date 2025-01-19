using Singleton_Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class DummyDataBase : ISingletonContainer
    {
        //En resumen, el ["name"] se usa para acceder al valor (población) asociado con la clave
        //name en el diccionario que se creó en ese momento. Este enfoque es conveniente para
        //ejemplos simples o casos donde se necesitan pocos valores constantes sin necesidad
        //de mantener un diccionario persistente.

        //[name] -> solo retorna un valor ya sea Brasilia o Lima
        public int GetPopulation(string name)
        {
            return new Dictionary<string, int>
            {
                ["Brasilia"] = 3039444,
                ["Lima"] = 9751717
            }[name];
        }
    }
}
