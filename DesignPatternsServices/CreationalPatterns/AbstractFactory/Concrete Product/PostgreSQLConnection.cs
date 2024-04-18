using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.CreationalPatterns.AbstractFactory.Concrete_Product
{
    public class PostgreSQLConnection : IConnection
    {
        public string OpenConnection()
        {
            return $"PostgreSQL connection opened.";
        }
        
    }
}
