using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

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
        //La clase Lazy<T> es una clase genérica que proporciona una inicialización diferida de un objeto.
        //En este caso, Lazy<SingletonContainer> se utiliza para asegurar que solo se cree una instancia
        //de SingletonContainer cuando sea necesario.
        //La inicialización de _instance se realiza mediante la llamada al constructor de
        //Lazy<SingletonContainer>.Esto significa que la instancia de SingletonContainer no se crea
        //inmediatamente, sino que se crea cuando se accede por primera vez a la propiedad Value de _instance.
        //El uso de Lazy<SingletonContainer> garantiza que la instancia de SingletonContainer se
        //cree de forma segura y eficiente, evitando problemas de concurrencia y minimizando el
        //uso de recursos. Además, al utilizar una instancia única de SingletonContainer,
        //se asegura que todos los demás componentes de la aplicación accedan a la misma
        //instancia y compartan los mismos datos. En resumen, este código crea una instancia
        //única de SingletonContainer utilizando el patrón de diseño Singleton y la inicializa de
        //forma diferida utilizando Lazy<T>.
        private static Lazy<SingletonContainer> _instance = new Lazy<SingletonContainer>(() => new SingletonContainer());
        public static SingletonContainer Instance => _instance.Value;

        public int GetPopulation(string name)
        {
            return (int)_capitales[name];
        }
    }
}
