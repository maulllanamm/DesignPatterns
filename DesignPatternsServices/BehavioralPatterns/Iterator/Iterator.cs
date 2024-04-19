using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsServices.BehavioralPatterns.Iterator
{
    public class Iterator : IAbstractIterator
    {
        private ConcreteCollection Collection;

        private int Current = 0;

        private readonly int step = 1;

        public Iterator(ConcreteCollection collection)
        {
            Collection = collection;
        }

        public Employee First()
        {
            Current = 0;
            return Collection.GetEmployee(Current);
        }

        public Employee Next()
        {
            Current += step;
            if (!IsCompleted)
            {
                return Collection.GetEmployee(Current);
            }
            else
            {
                return null;
            }
        }

        public bool IsCompleted
        {
            //When Current >= Collection.Count, means we have accessed all the elements
            get { return Current >= Collection.Count; }
        }
    }
}
