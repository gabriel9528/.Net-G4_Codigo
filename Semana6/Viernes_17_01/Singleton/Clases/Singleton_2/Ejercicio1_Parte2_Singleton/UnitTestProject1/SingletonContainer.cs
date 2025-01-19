using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class SingletonContainer : ISingletonContainer
    {
        private Dictionary<string, Double> _capitales = new Dictionary<string, Double>();

        private SingletonContainer()
        {
            Console.WriteLine("Inicializando singleton");
            var elementos = File.ReadAllLines("Capitales.txt");

            for (int i = 0; i < elementos.Length; i += 2)
            {
                _capitales.Add(elementos[i], Double.Parse(elementos[i + 1]));
            }
        }

        private static Lazy<SingletonContainer> _instance = new Lazy<SingletonContainer>(()
            => new SingletonContainer());

        public static SingletonContainer Instance => _instance.Value;

        public int GetPopulation(string name)
        {
            return (int)_capitales[name];
        }
    }
}
