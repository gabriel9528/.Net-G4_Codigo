using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_After
{
    internal class AppoinmentService
    {
        public string Create(Appoinment appoinment)
        {
            ValidationResult validationResult = AppoinmentServiceValidator.Validate(appoinment);

            return validationResult.IsValid
                ? $"La cita quedo agendada para el paciente {appoinment.Patient.Name}."
                : string.Join(Environment.NewLine, validationResult?.ListErrorMessage);
        }
    }
}
