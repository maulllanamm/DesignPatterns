using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.StructuralPatterns.Composite
{
    public class Leaf : IComponent
    {

        public string Name { get; set; }
        public int Price { get; set; }

        public Leaf(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public string DisplayPrice()
        {
            return $"Component name : {Name} and price : {Price}";
        }
    }
}
