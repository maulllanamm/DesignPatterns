using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.CreationalPatterns.AbstractFactory.Concrete_Product
{
    public class SQLServerConnection : IConnection
    {
        public string OpenConnection()
        {
            return $"SQL Server connection opened.";
        }
    }
}
