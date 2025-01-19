using System;
using System.Collections.Generic;
using System.IO;

namespace Singleton_Before
{
    public class SingletonContainer
    {
        private Dictionary<string, int> _capitales = new Dictionary<string, int>();

        private SingletonContainer()
        {
            Console.WriteLine("Inicializando singleton");

            var elementos = File.ReadAllLines("capitales.txt");
            for(int i = 0; i < elementos.Length; i += 2)
            {
                _capitales.Add(elementos[i], int.Parse(elementos[i + 1]));
            }
        }
        private static Lazy<SingletonContainer> _instance = new Lazy<SingletonContainer>(() => new SingletonContainer());
        public static SingletonContainer Instance => _instance.Value;

        public int GetPopulation(string name)
        {
            return (int)_capitales[name];
        }
    }
}
