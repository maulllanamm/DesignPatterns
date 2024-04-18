using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsServices.BehavioralPatterns.Command.Receiver
{
    public class Chef
    {
        public string PrepareBurger()
        {
            return "Preparing Burger...";
        }
        public string PreparePasta()
        {
            return "Preparing Pasta...";
        }
    }
}
