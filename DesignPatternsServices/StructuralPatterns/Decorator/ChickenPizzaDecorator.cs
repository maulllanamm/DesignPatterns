using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.StructuralPatterns.Decorator
{
    public class ChickenPizzaDecorator : PizzaDecorator
    {
        protected readonly IPizza _pizza;

        public ChickenPizzaDecorator(IPizza pizza) : base(pizza) 
        {
            _pizza = pizza;
        }

        public override string MakePizza()
        {
            return _pizza.MakePizza() + " Add Chicken";
        }


    }
}
