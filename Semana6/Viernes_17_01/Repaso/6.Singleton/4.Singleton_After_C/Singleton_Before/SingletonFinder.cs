using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Before
{
    public class SingletonFinder
    {
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
