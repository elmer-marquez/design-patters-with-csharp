using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.One.SingleResponsabilityPrinciple.APT
{
    public class Appointment
    {
        public DateTime Time { get; set; }
        public Patient Patient { get; set; }
    }
}