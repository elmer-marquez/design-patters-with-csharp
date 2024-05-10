

using System;

namespace SOLID.One.SingleResponsabilityPrinciple.APT
{
    public static class AppointmentServiceValidator
    {
        public static ValidationResult Validate(Appointment appointment){
            ValidationResult validator = new ValidationResult();

            if(string.IsNullOrEmpty(appointment.Patient.Name)){
                validator.Errors.Add("Cita no agendada, es necesario el nombre del paciente.");
            }

            if(!appointment.Patient.Email.Contains("@") || string.IsNullOrEmpty(appointment.Patient.Email)){
                validator.Errors.Add("Es necesario un email valido.");
            }

            if(appointment.Time < DateTime.Now)
            {
                validator.Errors.Add("Revisar la fecha de la cita, por favor");
            }

            return validator;
        }
    }
}