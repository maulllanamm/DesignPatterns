namespace DesignPatternsServices.BehavioralPatterns.State.Context
{
    public class Order
    {
        private IOrderState _currentState;
        public Order()
        {
            _currentState = new New();
        }
        public string SetState(IOrderState state)
        {
             _currentState = state;
            return "The state changed to Canceled";
        }
        public string NextState()
        {
            return _currentState.Next(this);
        }
        public string PrevState()
        {
            return _currentState.Prev(this);
        }
        public string PrintStatus()
        {
            return _currentState.PrintStatus();
        }

    }
}
