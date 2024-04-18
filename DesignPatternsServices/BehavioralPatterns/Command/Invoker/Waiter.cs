using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsServices.BehavioralPatterns.Command.Invoker
{
    public class Waiter
    {
        private List<IOrderCommand> _orders = new List<IOrderCommand>();

        public void TakeOrder(IOrderCommand orderCommand)
        {
            _orders.Add(orderCommand);
        }

        public string PlaceOrders()
        {
            var res = new StringBuilder();
            foreach (var order in _orders)
            {
                res.AppendLine(order.Execute());
            }
            _orders.Clear();
            return res.ToString();
        }
    }
}
