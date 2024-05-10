

namespace SOLID.Two.OpenClosedPrinciple.Work
{
    public class CloudEngineer : IApplicant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccountService Processor { get; set; } = new AccountCloudEngineer();
    }
}