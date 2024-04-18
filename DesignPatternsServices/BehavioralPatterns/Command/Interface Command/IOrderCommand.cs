using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsServices.BehavioralPatterns.Command
{
    public interface IOrderCommand
    {
        string Execute();
    }
}
