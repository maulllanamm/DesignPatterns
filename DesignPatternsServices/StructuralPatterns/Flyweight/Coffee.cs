using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.StructuralPatterns.Flyweight
{
    public class Coffee
    {

        public string Flavor { get; set; }
        public string Ingredients { get; set; }
        public string Preparation { get; set; }
        public Coffee(string flavor, string ingredients, string preparation)
        {
            Flavor = flavor;
            Ingredients = ingredients;
            Preparation = preparation;
        }

        public string ServeCoffee(int tableNumber, string customizations = "")
        {
            return $"Serving {Flavor} coffee (made with {Ingredients} and {Preparation}) to table {tableNumber}. {customizations}";
        }
    }
}
