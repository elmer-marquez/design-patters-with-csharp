

namespace SOLID.Two.OpenClosedPrinciple.Work
{
    public class Staff : Person
    {
        public Role Role { get; set; } = Role.None;

        public override string ToString()
        {
            return $"FirstName: {FirstName}, LastName: {LastName}, Email: {Email}, Role: {Role}";
        }
    }
}