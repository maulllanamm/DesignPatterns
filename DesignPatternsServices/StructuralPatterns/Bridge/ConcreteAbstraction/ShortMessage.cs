using DesignPatternServices_.StructuralPatterns.Bridge.AbstractImplementor;
using DesignPatternServices_.StructuralPatterns.Bridge.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.StructuralPatterns.Bridge.ConcreteAbstraction
{
    public class ShortMessage : AbstractMessage
    {
        protected IMessageSender _messageSender;
        public ShortMessage(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public override string SendMessage(string message)
        {
            if (message.Length <= 10)
            {
                return _messageSender.SendMessage(message);
            }
            else
            {
                return  "Unable to send the message as length > 10 characters";
            }
        }
    }
}
