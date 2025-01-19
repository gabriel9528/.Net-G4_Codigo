using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Before
{
    public class SingletonContainer
    {
        private Dictionary<string, Double> _capitales = new Dictionary<string, Double>();

        public SingletonContainer()
        {
            Console.WriteLine("Inicializando singleton");

            var elementos = File.ReadAllLines("capitales.txt");
            for(int i = 0; i < elementos.Length; i += 2)
            {
                _capitales.Add(elementos[i], Double.Parse(elementos[i + 1]));
            }
        }

        public int GetPopulation(string name)
        {
            return (int)_capitales[name];
        }
    }
}
