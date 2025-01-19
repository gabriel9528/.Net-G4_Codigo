using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    internal class SingletonFinder
    {
        public int GetTotalPopulation(IEnumerable<string> listCapitals)
        {
            int total = 0;
            foreach(var poblacion in listCapitals)
            {
                total += SingletonContainer.Instance.GetPopulation(poblacion);
            }

            return total;
        }
    }
}
