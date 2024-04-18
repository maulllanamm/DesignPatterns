using DesignPatternsServices.BehavioralPatterns.State.Context;

namespace DesignPatternsServices.BehavioralPatterns.State
{
    public class Canceled : IOrderState
    {
        public string Next(Order order)
        {
            return "Order is canceled and cannot proceed.";
        }
        public string Prev(Order order)
        {
            return "Order is canceled and cannot go back.";
        }
        public string PrintStatus()
        {
            return "Order is CANCELED.";
        }
    }
}
