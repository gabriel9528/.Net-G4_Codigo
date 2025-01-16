
class Program
{
    public class User
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Country { get; private set; }

        //Creamos un metodo para que nos cree el pais por defecto
        public static User CreateWithDefaultCountry(string name, string email)
        {
            return new User(name, email, "Peru");
        }

        //Crea un metodo para que nos cree un correo por defecto
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

        public static void Main(string[] args)
        {
            var user = User.CreateWithDefaultCountry("Gabriel", "gabriel@gmail.com");
            var user1 = User.CreateWithDefaultEmail("Gabriel", "gabriel@gmail.com");
            Console.WriteLine($"Usuario: {user.Name} Email: {user.Email}, Pais:{user.Country}");
            Console.ReadLine();
        }
    }
}