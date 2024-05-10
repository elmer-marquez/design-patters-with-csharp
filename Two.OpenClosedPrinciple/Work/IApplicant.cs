

namespace SOLID.Two.OpenClosedPrinciple.Work
{
    public interface IApplicant
    {
        string FirstName {get; set;}
        string LastName {get; set;}

        IAccountService Processor {get; set;}
    }
}