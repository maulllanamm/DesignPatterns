using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.StructuralPatterns.Flyweight
{
    public class CoffeeShop
    {
        private readonly CoffeeFactory _factory = new CoffeeFactory();
        private readonly List<Tuple<Coffee,int,string>> _orders = new List<Tuple<Coffee, int, string>>();

        public void TakeOrder(string flavor, int tableNumber, string customizations = "")
        {
            var coffee = _factory.GetCoffee(flavor);
            _orders.Add(Tuple.Create(coffee, tableNumber, customizations));
        }

        public string ServeOrders()
        {
            var res = new StringBuilder();
            foreach (var order in _orders)
            {
                res.AppendLine(order.Item1.ServeCoffee(order.Item2, order.Item3));
            }
            _orders.Clear();
            return res.ToString();
        }
    }
}
