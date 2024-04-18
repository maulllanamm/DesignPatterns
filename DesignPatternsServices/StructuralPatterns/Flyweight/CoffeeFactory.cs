using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.StructuralPatterns.Flyweight
{
    public class CoffeeFactory
    {
        private readonly Dictionary<string, Coffee> _coffees= new Dictionary<string, Coffee>();
        public Coffee GetCoffee(string flavor)
        {
            if (!_coffees.ContainsKey(flavor))
            {
                // For simplicity, let's assume every coffee just has water as its ingredient and is brewed.
                var coffee = new Coffee(flavor, "water", "brewed");
                _coffees.Add(flavor, coffee);
            }
            return _coffees[flavor];
        }
    }
}
