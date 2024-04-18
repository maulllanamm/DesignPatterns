using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsServices.BehavioralPatterns.ChainOfResponsibility
{
    public class NotEmptyValidator : ValidationHandler
    {
        public override bool Validate(User input)
        {
            if (string.IsNullOrWhiteSpace(input.Email) || string.IsNullOrWhiteSpace(input.Password))
            {
                return false;
            }
            return nextHandler?.Validate(input) ?? true;
        }
    }
}
