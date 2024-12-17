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

            var appointment = new Appointment
            {
                Patient = new Patient
                {
                    Name = "Gabriel Retamozo", 
                    Email = "gabriel@gmail.com"
                },
                //Time = DateTime.Now,
                Time = new DateTime(2019, 03, 08, 15, 20, 19)

            };
            WriteLine(new AppointmentService().Create(appointment));

            ReadLine();
        }
    }

    public class Patient
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class Appointment
    {
        public DateTime Time { get; set; }
        public Patient Patient { get; set; }
    }

    public class ValidationResult
    {
        public List<string> ErrorMessage { get; set; } = new List<string>();
        public bool IsValid { get { return !ErrorMessage.Any(); } }
    }

    public static class AppointmentServiceValidator
    {
        public static ValidationResult Validate(Appointment appointment)
        {
            ValidationResult validationResult = new ValidationResult();

            if (string.IsNullOrEmpty(appointment.Patient.Name))
                validationResult.ErrorMessage.Add("La cita no puede ser agendada, debido a que debe proporcionar un nombre de paciente.");
            
            if (appointment.Time.Equals(DateTime.MinValue))
                validationResult.ErrorMessage.Add("La cita no puede ser agendada, debido a que debe proporcionar la hora de la cita.");

            if (string.IsNullOrEmpty(appointment.Patient.Email) || !appointment.Patient.Email.Contains("@"))
                validationResult.ErrorMessage.Add("La cita no puede ser agendada, debido a que debe proporcionar un email valido.");

            return validationResult;
        }
    } 
    
    public class AppointmentService
    {
        // 1 Crear una clase para las validaciones
        // 2 Crear un Objeto paciente(appointment)
        // Crear un objeto Cita que tenga un paciente y la fecha cita
        public string Create(Appointment appointment)
        {
            ValidationResult validationResult = AppointmentServiceValidator.Validate(appointment);

            //Environment.NewLine es "\r\n -> separador de linesa
            return validationResult.IsValid ?
                $"La cita quedo agendada para el paciente {appointment.Patient.Name}."
                : string.Join(Environment.NewLine, validationResult.ErrorMessage);

        }

    }
}
