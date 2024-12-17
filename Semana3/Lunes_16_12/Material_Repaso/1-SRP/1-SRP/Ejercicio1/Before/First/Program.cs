using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime checkInDate = DateTime.Now;
            DateTime checkOutDate = checkInDate.AddDays(2);

            //WriteLine(new AppointmentService().Create("", "", DateTime.MinValue));
            //WriteLine(new AppointmentService().Create("Gabriel Retamozo", "gabriel@gmail.com", checkInDate, checkOutDate));
            WriteLine(new AppointmentService().Create("Pedro Flores", "pedrogmail.com", DateTime.MinValue));

            ReadLine();
        }
    }

    
    public class AppointmentService
    {
        // 1 Crear una clase para las validaciones
        // 2 Crear un Objeto llamador paciente
        // Crear un objeto Cita que tenga un paciente y la fecha cita
        public string Create(string name, string email, DateTime time)
        {//StringBuilder se utiliza para construir un mensaje concatenando diferentes partes de texto de manera eficiente.
            StringBuilder message = new StringBuilder();

            bool isValid = true;
            //DateTime.Now.ToLongTimeString() devolverá una cadena que representa la hora actual en un
            //formato largo, como por ejemplo "12:45:30 PM"
            message.Append($"Iniciando cita {DateTime.Now.ToLongTimeString()}....");

            if (string.IsNullOrEmpty(name))
                message.Append("La cita no puede ser agendada, debido a que debe proporcionar un nombre de paciente.");
            isValid = false;

            if (time.Equals(DateTime.MinValue))
                message.Append("La cita no puede ser agendada, debido a que debe proporcionar la hora de la cita.");
                isValid = false ;

            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
                message.Append("La cita no puede ser agendada, debido a que debe proporcionar un email valido.");
                isValid = false;

            if (isValid)
                message.Append($"La cita quedo agendada para el paciente {name}.");

            return message.ToString().Replace(".", Environment.NewLine);

        }

    }
}
