using DesignPatternServices_.StructuralPatterns.Bridge.AbstractImplementor;
using DesignPatternServices_.StructuralPatterns.Bridge.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.StructuralPatterns.Bridge.ConcreteAbstraction
{
    public class LongMessage : AbstractMessage
    {
        protected IMessageSender _messageSender;
        public LongMessage(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public override string SendMessage(string message)
        {
            return _messageSender.SendMessage(message);
        }
    }
}
