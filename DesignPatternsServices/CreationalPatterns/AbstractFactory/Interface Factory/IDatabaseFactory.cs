using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.CreationalPatterns.AbstractFactory.Interface_Factory
{
    public interface IDatabaseFactory
    {
        ICommand CreateCommand();
        IConnection CreateConnection();
    }
}
