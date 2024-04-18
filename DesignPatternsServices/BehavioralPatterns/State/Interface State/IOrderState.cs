using DesignPatternsServices.BehavioralPatterns.State.Context;

namespace DesignPatternsServices.BehavioralPatterns.State
{
    public interface IOrderState
    {
        public string Next(Order order);
        public string Prev(Order order);
        public string PrintStatus();
    }
}
