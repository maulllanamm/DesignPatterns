using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.CreationalPatterns.AbstractFactory.Concrete_Product
{
    public class SQLServerCommand : ICommand
    {
        public string Execute(string query)
        {
            return $"SQL Server executing command: {query}";
        }
    }
}
