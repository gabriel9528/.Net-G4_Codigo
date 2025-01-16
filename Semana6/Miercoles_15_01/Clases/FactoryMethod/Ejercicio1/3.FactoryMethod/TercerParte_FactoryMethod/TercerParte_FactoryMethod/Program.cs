class Program
{
    public static class UserFactory
    {
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
    }
    public class User
    {

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Country { get; private set; }

        internal User(string name, string email, string country)
        {
            Name = name;
            Email = email;
            Country = country;
        }
    }

    public static void Main(string[] args)
    {
        var user = UserFactory.CreateWithDefaultCountry("Gabriel", "gabriel@gmail.com");
        var user1 = UserFactory.CreateWithDefaultEmail("Gabriel", "Peru");
        Console.WriteLine($"Usuario: {user.Name} Email: {user.Email}, Pais:{user.Country}");
        Console.WriteLine($"Usuario: {user1.Name} Email: {user1.Email}, Pais:{user1.Country}");
        Console.ReadLine();
    }
}