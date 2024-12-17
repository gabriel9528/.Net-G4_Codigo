using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Before
{
    //Vamos a crear una aplicación de citas médicas donde necesitamos crear una clase
    //Appointment service, y crear un método dentro de dicha clase, donde le pasemos por
    //argumentos un nombre, un email, y una fecha, a su vez tenemos que hacer las validaciones
    //correspondientes de cada parámetro, luego si todo es válido entonces se procederá a crear
    //la cita médica.

    internal class AppoinmentService
    {
        public string Create(string name, string email, DateTime time)
        {
            StringBuilder message = new StringBuilder();

            bool isValid = true;

            message.Append($"Iniciando la cita {DateTime.Now.ToString()}.");

            if (string.IsNullOrEmpty(name))
            {
                message.Append("La cita no puede ser agendada, debido a que debe proporcionar un nombre correcto.");
                isValid = false;
            }

            if (time.Equals(DateTime.MinValue))
            {
                message.Append("La cita no puede ser agendada, debido a que debe proporcionar la fecha de la cita.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                message.Append("La cita no puede ser agendada, debido a que debe proporcionar un formato valido de correo.");
                isValid = false;
            }

            if (isValid)
            {
                message.Append($"La cita quedo agendada para el paciente {name}");
            }
            
            return message.ToString().Replace(".", Environment.NewLine);
        }
    }
}
