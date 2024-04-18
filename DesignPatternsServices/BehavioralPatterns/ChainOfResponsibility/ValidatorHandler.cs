using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsServices.BehavioralPatterns.ChainOfResponsibility
{
    public abstract class ValidationHandler
    {
        protected ValidationHandler nextHandler;
        public void SetNext(ValidationHandler handler)
        {
            nextHandler = handler;
        }
        public abstract bool Validate(User input);
    }
}
