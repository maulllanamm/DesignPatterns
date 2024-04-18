using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesignPatternsServices.BehavioralPatterns.ChainOfResponsibility
{
    public class EmailFormatValidator : ValidationHandler
    {
        public override bool Validate(User input)
        {
            // Regex for email validation.
            bool IsValidEmail = Regex.IsMatch(input.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!IsValidEmail)
            {
                return false;
            }
            return nextHandler?.Validate(input) ?? true;
        }
    }
}
