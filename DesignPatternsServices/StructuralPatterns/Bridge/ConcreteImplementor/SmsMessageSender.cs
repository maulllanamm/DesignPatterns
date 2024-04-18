using DesignPatternServices_.StructuralPatterns.Bridge.AbstractImplementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.StructuralPatterns.Bridge.ConcreteImplementor
{
    public class SmsMessageSender : IMessageSender
    {
        public string SendMessage(string message)
        {
            return $"{message} : this message has been sent using sms";
        }
    }
}
