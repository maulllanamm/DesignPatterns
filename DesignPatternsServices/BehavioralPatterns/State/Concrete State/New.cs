using DesignPatternsServices.BehavioralPatterns.State.Context;

namespace DesignPatternsServices.BehavioralPatterns.State
{
    public class New : IOrderState
    {
        public string Next(Order order)
        {
            order.SetState(new Processed());
            return "The state changed to Proccesss";
        }
        public string Prev(Order order)
        {
            return "The order is in its new state.";
        }
        public string PrintStatus()
        {
            return "Order is in NEW state.";
        }
    }
}
