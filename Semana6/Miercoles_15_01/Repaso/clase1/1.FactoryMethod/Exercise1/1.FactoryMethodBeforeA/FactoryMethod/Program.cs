using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace FactoryMethod
{
    //Ejercicio: Crear una clase Usuario, donde por defecto country sea Peru
    class Program
    {
        //Pero con este ejemplo se rompe con el principio de responsabilidad unica de cada clase
        public class User
        {
            public string Name { get; private set; }
            public string Email { get; private set; }
            public string Country { get; private set; }

            public User(string name, string email, string country = "Peru")
            {
                Name = name;
                Email = email;
                Country = "Peru";
            }
            public User(string name, string email)
            {
                Name = name;
                Email = email;
                Country = "Peru";
            }

        }
        static void Main(string[] args)
        {
            //Forma tradicional
            var user = new User("Gabriel", "gabrielsxf@gmail.com", "Peru");
            WriteLine($"Usuario: {user.Name} Email: {user.Email}, Pais: {user.Country}");
            ReadLine();


        }
    }
}
