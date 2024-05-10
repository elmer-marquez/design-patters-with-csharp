using System;

namespace SOLID.One.SingleResponsabilityPrinciple.APT
{
    public class AppointmentService
    {
        public string Create(Appointment appointment){
            var validation = AppointmentServiceValidator.Validate(appointment);

            return validation.IsValid ? 
                            $"La cita fue agendada [{appointment.Time}] para el paciente: {appointment.Patient.Name} con email: {appointment.Patient.Email}" : string.Join(Environment.NewLine, validation.Errors);
        } 
    }
}