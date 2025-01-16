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

            //creariamos el metodo para que nos cree por defecto el Pais
            public static User CreateWithDefaultCountry(string name, string email)
            {
                return new User(name, email, "Peru");
            }

            public static User CreateWithDefaultEmail(string name, string country)
            {
                return new User(name, "gabriel@gmail.com", country);
            }

            private User(string name, string email, string country)
            {
                Name = name;
                Email = email;
                Country = country;
            }

        }
        static void Main(string[] args)
        {
            //Forma tradicional
            //var user1 = new User("Gabriel", "gabrielsxf@gmail.com", "Peru");
            //WriteLine($"Usuario: {user.Name} Email: {user.Email}, Pais: {user.Country}");
            //ReadLine();


            var user = User.CreateWithDefaultCountry("Gabriel", "gabriel@gmail.com");

            WriteLine($"Usuario: {user.Name} Email: {user.Email}, Pais: {user.Country}");
            ReadLine();

        }
    }
}
