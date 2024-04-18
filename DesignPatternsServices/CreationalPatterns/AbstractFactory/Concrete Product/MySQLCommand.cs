using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.CreationalPatterns.AbstractFactory.Concrete_Product
{
    public class MySQLCommand : ICommand
    {
        public string Execute(string query)
        {
            return $"MySQL executing command: {query}";
        }

    }
}
