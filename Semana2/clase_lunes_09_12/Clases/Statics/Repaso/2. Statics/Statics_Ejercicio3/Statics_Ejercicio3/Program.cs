using System;

public static class ValidadorCredenciales
{
    // Datos simulados de usuarios
    private static readonly string UsuarioRegistrado = "admin";
    private static readonly string ContrasenaRegistrada = "12345";

    // Método estático para validar credenciales
    public static bool EsUsuarioValido(string usuario, string contrasena)
    {
        return usuario == UsuarioRegistrado && contrasena == ContrasenaRegistrada;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Sistema de inicio de sesión");

        Console.Write("Ingresa el nombre de usuario: ");
        string usuario = Console.ReadLine();

        Console.Write("Ingresa la contraseña: ");
        string contrasena = Console.ReadLine();

        // Uso del método estático para validar credenciales
        if (ValidadorCredenciales.EsUsuarioValido(usuario, contrasena))
        {
            Console.WriteLine("Inicio de sesión exitoso. ¡Bienvenido!");
        }
        else
        {
            Console.WriteLine("Credenciales inválidas. Inténtalo de nuevo.");
        }
    }
}
