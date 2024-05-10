using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Two.OpenClosedPrinciple.Work
{
    public class Doctor : IApplicant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IAccountService Processor { get; set; } = new AccountDoctor();
    }
}