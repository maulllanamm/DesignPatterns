using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsServices.BehavioralPatterns.Mediator
{
    public class ChatRoom : IChatRoom
    {
        private Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();

        public void Register(Participant participant)
        {
            if (!_participants.ContainsValue(participant))
            {
                _participants[participant.Name] = participant;
                participant.ChatRoom = this;
            }
        }

        public string Send(string from, string to, string message)
        {
            Participant participant = _participants[to];
            if (participant != null)
            {
                return participant.Receive(from, message);
            }
            return "";
        }
    }
}
