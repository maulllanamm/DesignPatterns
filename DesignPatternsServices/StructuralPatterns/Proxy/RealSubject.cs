using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.StructuralPatterns.Proxy
{
    public class RealSubject : ISubject
    {
        public string Request()
        {
            return "RealSubject: Permintaan diproses.";
        }
    }
}
