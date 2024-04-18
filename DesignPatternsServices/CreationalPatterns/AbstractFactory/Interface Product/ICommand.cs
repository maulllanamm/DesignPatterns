using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.CreationalPatterns.AbstractFactory
{
    public interface ICommand
    {
        string Execute(string query);
    }
}
