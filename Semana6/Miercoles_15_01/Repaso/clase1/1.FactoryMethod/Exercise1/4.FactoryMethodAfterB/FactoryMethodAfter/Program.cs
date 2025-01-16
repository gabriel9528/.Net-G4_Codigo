using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace FactoryMethodAfter
{
    class Program
    {
        //Usamos clases anidadas

        public class User
        {
            public string Name { get; private set; }
            public string Email { get; private set; }
            public string Country { get; private set; }

            private User(string name, string email, string country)
            {
                Name = name;
                Email = email;
                Country = country;
            }

            public static class Factory
            {
                public static User CreateWithDefaultCountry(string name, string email)
                {
                    return new User(name, email, "Peru");
                }

                public static User CreateWithDefaultEmail(string name, string country)
                {
                    return new User(name, "gabriel@gmail.com", country);
                }
            }

        }
        static void Main(string[] args)
        {
            var user = User.Factory.CreateWithDefaultCountry("Gabriel", "gabriel@gmail.com");

            WriteLine($"Usuario: {user.Name} Email: {user.Email}, Pais: {user.Country}");
            ReadLine();
        }
    }
}
