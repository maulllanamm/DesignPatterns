using DesignPatternsServices.BehavioralPatterns.State.Context;

namespace DesignPatternsServices.BehavioralPatterns.State
{
    public class Processed : IOrderState
    {
        public string Next(Order order)
        {
            order.SetState(new Shipped());
            return "The state changed to Shipp";
        }
        public string Prev(Order order)
        {
            order.SetState(new New());
            return "The state changed to New";
        }
        public string PrintStatus()
        {
            return "Order is PROCESSED.";
        }
    }
}
