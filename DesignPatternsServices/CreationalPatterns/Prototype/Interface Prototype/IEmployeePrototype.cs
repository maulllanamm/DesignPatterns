using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.CreationalPatterns.Prototype.Interface_Prototype
{
    public interface IEmployeePrototype
    {
        IEmployeePrototype Clone();
    }
}
