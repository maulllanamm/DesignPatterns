using DesignPatternsServices.BehavioralPatterns.Command.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsServices.BehavioralPatterns.Command
{
    public class BurgerOrderCommand : IOrderCommand
    {
        private Chef _chef;
        public BurgerOrderCommand(Chef chef)
        {
            _chef = chef;
        }

        public string Execute()
        {
            return _chef.PrepareBurger();
        }
    }
}
