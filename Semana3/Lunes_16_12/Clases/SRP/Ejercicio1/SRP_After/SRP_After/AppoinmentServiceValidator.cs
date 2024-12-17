using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SRP_After
{
    internal class AppoinmentServiceValidator
    {
        public static ValidationResult Validate(Appoinment appoinment)
        {
            ValidationResult validationResult = new();

            if (string.IsNullOrEmpty(appoinment?.Patient?.Name))
            {
                validationResult.ListErrorMessage.Add("La cita no puede ser agendada, debido a que debe proporcionar un nombre correcto.");
                //validationResult.IsValid = false;
            }

            if ((bool)(appoinment?.Time.Equals(DateTime.MinValue)))
            {
                validationResult.ListErrorMessage.Add("La cita no puede ser agendada, debido a que debe proporcionar la fecha de la cita.");
                //validationResult.IsValid = false;
            }

            if (string.IsNullOrEmpty(appoinment.Patient.Email) || !appoinment.Patient.Email.Contains("@"))
            {
                validationResult.ListErrorMessage.Add("La cita no puede ser agendada, debido a que debe proporcionar un formato valido de correo.");
                //validationResult.IsValid = false;
            }

            return validationResult;
        }
    }
}
