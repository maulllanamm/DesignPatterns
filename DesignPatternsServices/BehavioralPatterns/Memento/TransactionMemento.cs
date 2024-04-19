using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsServices.BehavioralPatterns.Memento
{
    public class TransactionMemento
    {
        public decimal Balance { get; }
        public TransactionMemento(decimal balance)
        {
            Balance = balance;
        }
    }
}
