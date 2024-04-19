using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsServices.BehavioralPatterns.Memento
{
    public class BankAccount
    {
        public decimal Balance { get; private set; }

        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public string Deposit (decimal amount)
        {
            Balance += amount;
            return $"Deposit : {amount}";
        }

        public string Withdraw(decimal amount)
        {
            Balance -= amount;
            return $"Withdraw : {amount}";
        }

        public TransactionMemento CreateMemento()
        {
            return new TransactionMemento(Balance);
        }
        public string RestoreFromMemento(TransactionMemento memento)
        {
            Balance = memento.Balance;
            return $"Restore balance to : {Balance}";
        }
    }
}
