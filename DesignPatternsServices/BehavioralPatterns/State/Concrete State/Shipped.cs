using DesignPatternsServices.BehavioralPatterns.State.Context;

namespace DesignPatternsServices.BehavioralPatterns.State
{
    public class Shipped : IOrderState
    {
        public string Next(Order order)
        {
            order.SetState(new Delivered());
            return "The state changed to Delivered";
        }
        public string Prev(Order order)
        {
            order.SetState(new Processed());
            return "The state changed to Processed";
        }
        public string PrintStatus()
        {
            return "Order is SHIPPED.";
        }
    }
}
