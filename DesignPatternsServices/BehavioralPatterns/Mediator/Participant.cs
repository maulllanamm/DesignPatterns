using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsServices.BehavioralPatterns.Mediator
{
    public class Participant
    {
        public string Name { get; private set; }
        public IChatRoom ChatRoom { get; set; }
        public Participant(string name)
        {
            Name = name;
        }
        public string Send(string to, string message)
        {
            return ChatRoom.Send(Name, to, message);
        }
        public string Receive(string from, string message)
        {
            return $"{from} to {Name}: '{message}'";
        }
    }
}
