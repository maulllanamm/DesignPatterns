using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsServices.BehavioralPatterns.ChainOfResponsibility
{
    public class PasswordStrengthValidator : ValidationHandler
    {
        public override bool Validate(User input)
        {
            if (input.Password.Length < 8 || !input.Password.Any(char.IsUpper) ||
                !input.Password.Any(char.IsLower) || !input.Password.Any(char.IsDigit))
            {
                return false;
            }
            return nextHandler?.Validate(input) ?? true;
        }
    }
}
