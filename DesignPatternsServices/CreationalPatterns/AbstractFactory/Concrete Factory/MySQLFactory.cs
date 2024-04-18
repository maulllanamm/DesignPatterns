using DesignPatternServices_.CreationalPatterns.AbstractFactory.Concrete_Product;
using DesignPatternServices_.CreationalPatterns.AbstractFactory.Interface_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.CreationalPatterns.AbstractFactory.Concrete_Factory
{
    public class MySQLFactory : IDatabaseFactory
    {
        public ICommand CreateCommand()
        {
            return new MySQLCommand();
        }
        public IConnection CreateConnection()
        {
            return new MySQLConnection();
        }
    }
}
