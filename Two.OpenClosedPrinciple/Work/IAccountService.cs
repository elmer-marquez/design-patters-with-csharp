using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Two.OpenClosedPrinciple.Work
{
    public interface IAccountService
    {
        Staff Create(IApplicant applicant);
    }
}