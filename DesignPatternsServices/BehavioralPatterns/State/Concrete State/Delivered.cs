using DesignPatternsServices.BehavioralPatterns.State.Context;

namespace DesignPatternsServices.BehavioralPatterns.State
{
    public class Delivered : IOrderState
    {
        public string Next(Order order)
        {
            return "Order is already delivered.";
        }
        public string Prev(Order order)
        {
            order.SetState(new Shipped());
            return "The state changed to Shipped";
        }
        public string PrintStatus()
        {
            return "Order is DELIVERED.";
        }
    }
}
