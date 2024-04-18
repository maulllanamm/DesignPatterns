using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.StructuralPatterns.Proxy
{
    public class Proxy : ISubject
    {
        private  RealSubject _realSubject;

        public string Request()
        {
            if(_realSubject == null)
            {
                //Proxy: Membuat objek RealSubject.
                _realSubject = new RealSubject();
            }
            return _realSubject.Request();
        }
    }
}
