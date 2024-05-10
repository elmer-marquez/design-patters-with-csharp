using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Two.OpenClosedPrinciple.Work
{
    public class AccountService : IAccountService
    {
        public Staff Create(IApplicant applicant)
        {
            var staff = new Staff();
           staff.FirstName = applicant.FirstName;
           staff.LastName = applicant.LastName;
           staff.Email = $"{applicant.FirstName.ToLower()}{applicant.LastName.ToLower()}@staff.com";

           return staff;
        }
    }
}