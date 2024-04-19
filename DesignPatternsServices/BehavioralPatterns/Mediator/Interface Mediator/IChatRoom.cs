namespace DesignPatternsServices.BehavioralPatterns.Mediator
{
    public interface IChatRoom
    {
        void Register(Participant participant);
        string Send(string from, string to, string message);
    }
}
