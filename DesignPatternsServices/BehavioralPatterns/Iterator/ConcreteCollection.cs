using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsServices.BehavioralPatterns.Iterator
{
    public class ConcreteCollection : IAbstractCollection
    {
        private List<Employee> listEmployees = new List<Employee>();
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return listEmployees.Count; }
        }
        //Add items to the collection
        public void AddEmployee(Employee employee)
        {
            listEmployees.Add(employee);
        }
        //Get items from the collection based on the Index Position
        //Index is started from 0
        public Employee GetEmployee(int IndexPosition)
        {
            return listEmployees[IndexPosition];
        }
    }
}
