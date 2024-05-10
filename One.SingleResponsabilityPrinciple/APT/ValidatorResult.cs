using System.Collections.Generic;
using System.Linq;

namespace SOLID.One.SingleResponsabilityPrinciple.APT
{
    public class ValidationResult
    {
        public List<string> Errors { get; set; } = new List<string>();
        public bool IsValid { get=>!Errors.Any(); }
    }
}