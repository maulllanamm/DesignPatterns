using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsServices.BehavioralPatterns.Memento
{
    public class TransactionHistory
    {
        private Stack<TransactionMemento> _history = new Stack<TransactionMemento>();
        public void SaveState(BankAccount account)
        {
            _history.Push(account.CreateMemento());
        }
        public TransactionMemento UndoTransaction()
        {
            return _history.Pop();
        }
    }
}
