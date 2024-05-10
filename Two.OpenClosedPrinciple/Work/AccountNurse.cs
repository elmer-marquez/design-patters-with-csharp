
namespace SOLID.Two.OpenClosedPrinciple.Work
{
    public class AccountNurse : IAccountService
    {
        public Staff Create(IApplicant applicant)
        {
           var staff = new Staff();
           staff.FirstName = applicant.FirstName;
           staff.LastName = applicant.LastName;
           staff.Email = $"{applicant.FirstName.ToLower()}{applicant.LastName.ToLower()}@nurse.com";

           return staff;
        }
    }
}